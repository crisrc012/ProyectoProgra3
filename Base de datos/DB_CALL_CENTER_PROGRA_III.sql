USE [master]

GO

CREATE DATABASE [DB_CALL_CENTER_PROGRA_III]

GO

USE [DB_CALL_CENTER_PROGRA_III]

GO

-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 1 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

		CREATE TABLE [dbo].[Tbl_Estados]
		(
			Id_Estado CHAR(1) NOT NULL,
			Desc_Estado VARCHAR(65) NOT NULL,
			FecCreacion DATETIME NOT NULL,
			UsuCreacion VARCHAR(15) NOT NULL,
			FecModificacion DATETIME NULL,
			UsuModificacion VARCHAR(15) NULL,

			CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
			(
				Id_Estado ASC
			)

		) ON [PRIMARY]

		GO

		ALTER TABLE [dbo].[Tbl_Estados]
			ADD CONSTRAINT UNQ_DESC_ESTADO UNIQUE (Desc_Estado)

		GO

-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 1 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 2 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

		CREATE TABLE [dbo].[Tbl_SemaforoCasos]
		(
			Id_Estado_SemaforoCaso CHAR(1) NOT NULL,
			Desc_Estado_SemaforoCaso VARCHAR(65) NOT NULL,
			Color VARCHAR(65) NOT NULL,
			Id_Estado CHAR(1) NOT NULL,
			FecCreacion DATETIME NOT NULL,
			UsuCreacion VARCHAR(15) NOT NULL,
			FecModificacion DATETIME NULL,
			UsuModificacion VARCHAR(15) NULL,

			CONSTRAINT [PK_SemaforoCasos] PRIMARY KEY CLUSTERED 
			(
				Id_Estado_SemaforoCaso ASC
			)

		) ON [PRIMARY]

		GO

		ALTER TABLE [dbo].[Tbl_SemaforoCasos]
			ADD CONSTRAINT UNQ_DESC_SEMAFOROCASOS UNIQUE (Desc_Estado_SemaforoCaso)

		GO

		ALTER TABLE [dbo].[Tbl_SemaforoCasos]
			ADD CONSTRAINT UNQ_COLOR_SEMAFOROCASOS UNIQUE (Color)

		GO

		ALTER TABLE [dbo].[Tbl_SemaforoCasos]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_SemaforoCasos_Estados] FOREIGN KEY([Id_Estado])
				REFERENCES [dbo].[Tbl_Estados] ([Id_Estado])

				GO

		ALTER TABLE [dbo].[Tbl_SemaforoCasos]
			CHECK CONSTRAINT [FK_SemaforoCasos_Estados]

		GO


-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 2 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 3 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

		CREATE TABLE [dbo].[Tbl_TipoActivo]
		(
			Id_TipoActivo INT IDENTITY(1,1) NOT NULL ,
			Desc_TipoActivo VARCHAR(65) NOT NULL,			
			Id_Estado CHAR(1) NOT NULL,
			FecCreacion DATETIME NOT NULL,
			UsuCreacion VARCHAR(15) NOT NULL,
			FecModificacion DATETIME NULL,
			UsuModificacion VARCHAR(15) NULL,

			CONSTRAINT [PK_TipoActivo] PRIMARY KEY CLUSTERED 
			(
				Id_TipoActivo ASC
			)

		) ON [PRIMARY]

		GO

		ALTER TABLE [dbo].[Tbl_TipoActivo]
			ADD CONSTRAINT UNQ_DESC_TIPOACTIVO UNIQUE (Desc_TipoActivo)

		GO

		ALTER TABLE [dbo].[Tbl_TipoActivo]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_TipoActivo_Estados] FOREIGN KEY([Id_Estado])
				REFERENCES [dbo].[Tbl_Estados] ([Id_Estado])

				GO

		ALTER TABLE [dbo].[Tbl_TipoActivo]
			CHECK CONSTRAINT [FK_TipoActivo_Estados]

		GO


-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 3 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 4 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

		CREATE TABLE [dbo].[Tbl_MarcaActivo]
		(
			Id_MarcaActivo INT IDENTITY(1,1) NOT NULL,
			Desc_MarcaActivo VARCHAR(65) NOT NULL,			
			Id_Estado CHAR(1) NOT NULL,
			FecCreacion DATETIME NOT NULL,
			UsuCreacion VARCHAR(15) NOT NULL,
			FecModificacion DATETIME NULL,
			UsuModificacion VARCHAR(15) NULL,

			CONSTRAINT [PK_MarcaActivo] PRIMARY KEY CLUSTERED 
			(
				Id_MarcaActivo ASC
			)

		) ON [PRIMARY]

		GO

		ALTER TABLE [dbo].[Tbl_MarcaActivo]
			ADD CONSTRAINT UNQ_DESC_MARCAACTIVO UNIQUE (Desc_MarcaActivo)

		GO

		ALTER TABLE [dbo].[Tbl_MarcaActivo]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_MarcaActivo_Estados] FOREIGN KEY([Id_Estado])
				REFERENCES [dbo].[Tbl_Estados] ([Id_Estado])

				GO

		ALTER TABLE [dbo].[Tbl_MarcaActivo]
			CHECK CONSTRAINT [FK_MarcaActivo_Estados]

		GO


-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 4 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 5 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

		CREATE TABLE [dbo].[Tbl_Departamentos]
		(
			Id_Departamento INT IDENTITY(1,1) NOT NULL,
			Desc_Departamento VARCHAR(65) NOT NULL,			
			Id_Estado CHAR(1) NOT NULL,
			FecCreacion DATETIME NOT NULL,
			UsuCreacion VARCHAR(15) NOT NULL,
			FecModificacion DATETIME NULL,
			UsuModificacion VARCHAR(15) NULL,

			CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
			(
				Id_Departamento ASC
			)

		) ON [PRIMARY]

		GO

		ALTER TABLE [dbo].[Tbl_Departamentos]
			ADD CONSTRAINT UNQ_DESC_DEPARTAMENTO UNIQUE (Desc_Departamento)

		GO

		ALTER TABLE [dbo].[Tbl_Departamentos]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_Departamentos_Estados] FOREIGN KEY([Id_Estado])
				REFERENCES [dbo].[Tbl_Estados] ([Id_Estado])

				GO

		ALTER TABLE [dbo].[Tbl_Departamentos]
			CHECK CONSTRAINT [FK_Departamentos_Estados]

		GO


-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 5 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 6 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

		CREATE TABLE [dbo].[Tbl_Activos]
		(
			Placa_Activo INT IDENTITY(1,1) NOT NULL ,
			Id_TipoActivo INT NOT NULL ,
			Desc_Activo VARCHAR(265) NOT NULL,	
			Id_MarcaActivo INT NOT NULL,
			Id_Departamento_Responsable INT NOT NULL ,
			Prioridad_SLA DECIMAL(8,2) NOT NULL,
			Id_Estado CHAR(1) NOT NULL,
			FecCreacion DATETIME NOT NULL,
			UsuCreacion VARCHAR(15) NOT NULL,
			FecModificacion DATETIME NULL,
			UsuModificacion VARCHAR(15) NULL,

			CONSTRAINT [PK_Activos] PRIMARY KEY CLUSTERED 
			(
				Placa_Activo ASC
			)

		) ON [PRIMARY]

		GO

		ALTER TABLE [dbo].[Tbl_Activos]
			ADD CONSTRAINT UNQ_DESC_ACTIVO UNIQUE (Desc_Activo)

		GO

		ALTER TABLE [dbo].[Tbl_Activos]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_Activos_TipoActivo] FOREIGN KEY([Id_TipoActivo])
				REFERENCES [dbo].[Tbl_TipoActivo] ([Id_TipoActivo])

		GO

		ALTER TABLE [dbo].[Tbl_Activos]
			CHECK CONSTRAINT [FK_Activos_TipoActivo]

		GO

		ALTER TABLE [dbo].[Tbl_Activos]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_Activos_MarcaActivo] FOREIGN KEY([Id_MarcaActivo])
				REFERENCES [dbo].[Tbl_MarcaActivo] ([Id_MarcaActivo])

		GO

		ALTER TABLE [dbo].[Tbl_Activos]
			CHECK CONSTRAINT [FK_Activos_MarcaActivo]

		GO

		ALTER TABLE [dbo].[Tbl_Activos]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_Activos_Departamentos] FOREIGN KEY([Id_Departamento_Responsable])
				REFERENCES [dbo].[Tbl_Departamentos] ([Id_Departamento])

		GO

		ALTER TABLE [dbo].[Tbl_Activos]
			CHECK CONSTRAINT [FK_Activos_Departamentos]

		GO

		ALTER TABLE [dbo].[Tbl_Activos]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_Activos_Estados] FOREIGN KEY([Id_Estado])
				REFERENCES [dbo].[Tbl_Estados] ([Id_Estado])

		GO

		ALTER TABLE [dbo].[Tbl_Activos]
			CHECK CONSTRAINT [FK_Activos_Estados]

		GO


-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 6 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 7 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

		CREATE TABLE [dbo].[Tbl_Turnos]
		(
			Id_Turno CHAR(1) NOT NULL,
			Desc_Turno VARCHAR(65) NOT NULL,			
			Cant_Horas INT NOT NULL,
			HoraEntrada VARCHAR(10) NOT NULL,
			HoraSalida VARCHAR(10) NOT NULL,
			Id_Estado CHAR(1) NOT NULL,
			FecCreacion DATETIME NOT NULL,
			UsuCreacion VARCHAR(15) NOT NULL,
			FecModificacion DATETIME NULL,
			UsuModificacion VARCHAR(15) NULL,

			CONSTRAINT [PK_Turnos] PRIMARY KEY CLUSTERED 
			(
				Id_Turno ASC
			)

		) ON [PRIMARY]

		GO

		ALTER TABLE [dbo].[Tbl_Turnos]
			ADD CONSTRAINT UNQ_DESC_TURNOS UNIQUE (Desc_Turno)

		GO

		ALTER TABLE [dbo].[Tbl_Turnos]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_Turnos_Estados] FOREIGN KEY([Id_Estado])
				REFERENCES [dbo].[Tbl_Estados] ([Id_Estado])

				GO

		ALTER TABLE [dbo].[Tbl_Turnos]
			CHECK CONSTRAINT [FK_Turnos_Estados]

		GO


-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 7 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 8 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

		CREATE TABLE [dbo].[Tbl_Operadores]
		(
			Id_Operador VARCHAR(11) NOT NULL,
			Nombre_Operador VARCHAR(45) NOT NULL,
			Apellidos_Operador VARCHAR(140) NOT NULL,
			NickNameOperador VARCHAR(10) NOT NULL, 
			Id_Turno CHAR(1) NOT NULL,
			Nivel VARCHAR(65) NOT NULL,
			Id_Estado CHAR(1) NOT NULL,
			FecCreacion DATETIME NOT NULL,
			UsuCreacion VARCHAR(15) NOT NULL,
			FecModificacion DATETIME NULL,
			UsuModificacion VARCHAR(15) NULL,

			CONSTRAINT [PK_Operadores] PRIMARY KEY CLUSTERED 
			(
				Id_Operador ASC
			)

		) ON [PRIMARY]

		GO

		ALTER TABLE [dbo].[Tbl_Operadores]
			ADD CONSTRAINT UNQ_DESC_OPERADOR UNIQUE (NickNameOperador)

		GO

		ALTER TABLE [dbo].[Tbl_Operadores]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_Operadores_Turnos] FOREIGN KEY([Id_Turno])
				REFERENCES [dbo].[Tbl_Turnos] ([Id_Turno])

		GO

		ALTER TABLE [dbo].[Tbl_Operadores]
			CHECK CONSTRAINT [FK_Operadores_Turnos]

		GO

		ALTER TABLE [dbo].[Tbl_Operadores]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_Operadores_Estados] FOREIGN KEY([Id_Estado])
				REFERENCES [dbo].[Tbl_Estados] ([Id_Estado])

		GO

		ALTER TABLE [dbo].[Tbl_Operadores]
			CHECK CONSTRAINT [FK_Operadores_Estados]

		GO


-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 8 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 9 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

		CREATE TABLE [dbo].[Tbl_Caso_Encabezado]
		(
			Id_Caso_Enc INT IDENTITY(1,1) NOT NULL,	
			Fecha DATETIME NOT NULL,
			Id_Operador VARCHAR(11) NOT NULL,
			ComentariosReporte VARCHAR(450) NOT NULL,
			Id_Estado_SemaforoCaso CHAR(1) NOT NULL,						
			Id_Estado CHAR(1) NOT NULL,
			FecCreacion DATETIME NOT NULL,
			UsuCreacion VARCHAR(15) NOT NULL,
			FecModificacion DATETIME NULL,
			UsuModificacion VARCHAR(15) NULL,

			CONSTRAINT [PK_Caso_Encabezado] PRIMARY KEY CLUSTERED 
			(
				Id_Caso_Enc ASC
			)

		) ON [PRIMARY]

		GO	

		ALTER TABLE [dbo].[Tbl_Caso_Encabezado]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_Caso_Encabezado_Operadores] FOREIGN KEY([Id_Operador])
				REFERENCES [dbo].[Tbl_Operadores] ([Id_Operador])

		GO

		ALTER TABLE [dbo].[Tbl_Caso_Encabezado]
			CHECK CONSTRAINT [FK_Caso_Encabezado_Operadores]

		GO	

		ALTER TABLE [dbo].[Tbl_Caso_Encabezado]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_Caso_Encabezado_SemaforoCasos] FOREIGN KEY([Id_Estado_SemaforoCaso])
				REFERENCES [dbo].[Tbl_SemaforoCasos] ([Id_Estado_SemaforoCaso])

		GO

		ALTER TABLE [dbo].[Tbl_Caso_Encabezado]
			CHECK CONSTRAINT [FK_Caso_Encabezado_SemaforoCasos]

		GO	

		ALTER TABLE [dbo].[Tbl_Caso_Encabezado]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_Caso_Encabezado_Estados] FOREIGN KEY([Id_Estado])
				REFERENCES [dbo].[Tbl_Estados] ([Id_Estado])

		GO

		ALTER TABLE [dbo].[Tbl_Caso_Encabezado]
			CHECK CONSTRAINT [FK_Caso_Encabezado_Estados]

		GO

		
-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 9 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 10 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

		CREATE TABLE [dbo].[Tbl_Caso_Detalle]
		(
			Id_Caso_Det INT IDENTITY(1,1) NOT NULL,	
			Id_Caso_Enc INT NOT NULL,	
			Placa_Activo INT NOT NULL,
			Observaciones VARCHAR(450) NOT NULL,
			FecCreacion DATETIME NOT NULL,
			UsuCreacion VARCHAR(15) NOT NULL,
			FecModificacion DATETIME NULL,
			UsuModificacion VARCHAR(15) NULL,

			CONSTRAINT [PK_Caso_Detalle] PRIMARY KEY CLUSTERED 
			(
				Id_Caso_Det ASC
			)

		) ON [PRIMARY]

		GO	

		ALTER TABLE [dbo].[Tbl_Caso_Detalle]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_Caso_Detalle_Encabezado] FOREIGN KEY([Id_Caso_Enc])
				REFERENCES [dbo].[Tbl_Caso_Encabezado] ([Id_Caso_Enc])

		GO

		ALTER TABLE [dbo].[Tbl_Caso_Detalle]
			CHECK CONSTRAINT [FK_Caso_Detalle_Encabezado]

		GO	

		ALTER TABLE [dbo].[Tbl_Caso_Detalle]  WITH NOCHECK 
			ADD  CONSTRAINT [FK_Caso_Detalle_Activos] FOREIGN KEY([Placa_Activo])
				REFERENCES [dbo].[Tbl_Activos] ([Placa_Activo])

		GO

		ALTER TABLE [dbo].[Tbl_Caso_Detalle]
			CHECK CONSTRAINT [FK_Caso_Detalle_Activos]
		GO


-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 10 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------
