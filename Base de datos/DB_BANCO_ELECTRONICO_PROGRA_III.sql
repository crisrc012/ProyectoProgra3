USE [master]

GO

CREATE DATABASE [DB_BANCO_ELECTRONICO_PROGRA_III]

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

USE [DB_BANCO_ELECTRONICO_PROGRA_III]

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		CREATE TABLE [dbo].[T_Estados]
		(
			[IdEstado] [char] (1) NOT NULL,			
			[Descripcion] [varchar](25) NOT NULL,
	
			CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
			(
				[IdEstado] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Estados]
		ADD CONSTRAINT UC_Descripcion_Est UNIQUE ([Descripcion])


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		CREATE TABLE [dbo].[T_Monedas]
		(
			[IdMoneda] [int] IDENTITY(1,1) NOT NULL,
			[DescMoneda] [varchar](90) NOT NULL,
			[IdEstado] [char] (1) NOT NULL,

			CONSTRAINT [PK_Monedas] PRIMARY KEY CLUSTERED 
			(
				[IdMoneda] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Monedas]
		ADD CONSTRAINT UC_DescMoneda UNIQUE ([DescMoneda])


GO

		ALTER TABLE [dbo].[T_Monedas]  WITH NOCHECK ADD  CONSTRAINT FK_Monedas_Estados FOREIGN KEY(IdEstado)
		REFERENCES [dbo].[T_Estados] (IdEstado)


GO

		ALTER TABLE [dbo].[T_Monedas] CHECK CONSTRAINT FK_Monedas_Estados



-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		CREATE TABLE [dbo].[T_Paises]
		(
			[IdPais] [int] IDENTITY(1,1) NOT NULL,	
			[NombrePais] [varchar](85) NOT NULL,
			[CodigoISOPais] [char](4) NOT NULL,
			[CodigoAreaPais] [char](5) NOT NULL,	
			[MonedaStand] [int] NOT NULL,		
			[IdEstado] [char] (1) NOT NULL,
	
			CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED 
			(
				[IdPais] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Paises]
		ADD CONSTRAINT UC_NombrePais UNIQUE ([NombrePais])

GO

		ALTER TABLE [dbo].[T_Paises]  WITH NOCHECK ADD  CONSTRAINT FK_Paises_Monedas FOREIGN KEY([MonedaStand])
		REFERENCES [dbo].[T_Monedas] ([IdMoneda])

GO

		ALTER TABLE [dbo].[T_Paises] CHECK CONSTRAINT FK_Paises_Monedas

GO

		ALTER TABLE [dbo].[T_Paises]  WITH NOCHECK ADD  CONSTRAINT FK_Paises_Estados FOREIGN KEY(IdEstado)
		REFERENCES [dbo].[T_Estados] (IdEstado)


GO

		ALTER TABLE [dbo].[T_Paises] CHECK CONSTRAINT FK_Paises_Estados

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		CREATE TABLE [dbo].[T_Productos]
		(
			[IdProducto] [int] IDENTITY(1,1) NOT NULL,
			[NombreProducto] [varchar](130) NOT NULL,
			[IdMoneda] [int] NOT NULL,
			[IdEstado] [char] (1) NOT NULL,

			CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
			(
				[IdProducto] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Productos]
		ADD CONSTRAINT UC_NombreProducto UNIQUE ([NombreProducto])

GO

		ALTER TABLE [dbo].[T_Productos]  WITH NOCHECK ADD  CONSTRAINT FK_Productos_Monedas FOREIGN KEY([IdMoneda])
		REFERENCES [dbo].[T_Monedas] ([IdMoneda])

GO

		ALTER TABLE [dbo].[T_Productos] CHECK CONSTRAINT FK_Productos_Monedas

GO

		ALTER TABLE [dbo].[T_Productos]  WITH NOCHECK ADD  CONSTRAINT FK_Productos_Estados FOREIGN KEY([IdEstado])
		REFERENCES [dbo].[T_Estados] (IdEstado)

GO

		ALTER TABLE [dbo].[T_Productos] CHECK CONSTRAINT FK_Productos_Estados


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		CREATE TABLE [dbo].[T_Horarios]
		(
			[IdHorario] [int] IDENTITY(1,1) NOT NULL,
			[DescHorario] [varchar](150) NOT NULL,
			[CantHoras] [int] NOT NULL,
			[Entrada] [varchar](8) NOT NULL,
			[Salida] [varchar](8) NOT NULL,
			[IdEstado] [char] (1) NOT NULL

			CONSTRAINT [PK_Horarios] PRIMARY KEY CLUSTERED 
			(
				[IdHorario] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Horarios]
		ADD CONSTRAINT UC_DescHorario UNIQUE ([DescHorario])


GO

		ALTER TABLE [dbo].[T_Horarios]  WITH NOCHECK ADD  CONSTRAINT FK_Horarios_Estados FOREIGN KEY(IdEstado)
		REFERENCES [dbo].[T_Estados] (IdEstado)

GO

		ALTER TABLE [dbo].[T_Horarios] CHECK CONSTRAINT FK_Horarios_Estados


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		CREATE TABLE [dbo].[T_TiposEmpleados]
		(
			[IdTipoEmpleado] [int] IDENTITY(1,1) NOT NULL,
			[DescTipo] [varchar](150) NOT NULL,
			[IdEstado] [char] (1) NOT NULL,

			CONSTRAINT [PK_IdTiposEmpleados] PRIMARY KEY CLUSTERED 
			(
				[IdTipoEmpleado] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_TiposEmpleados]
		ADD CONSTRAINT UC_Tipo_Emp UNIQUE ([DescTipo])


GO

		ALTER TABLE [dbo].[T_TiposEmpleados]  WITH NOCHECK ADD  CONSTRAINT FK_TiposEmpleados_Estados FOREIGN KEY(IdEstado)
		REFERENCES [dbo].[T_Estados] (IdEstado)

GO

		ALTER TABLE [dbo].[T_TiposEmpleados] CHECK CONSTRAINT FK_TiposEmpleados_Estados


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		CREATE TABLE [dbo].[T_Departamentos]
		(
			[IdDepartamento] [char] (5) NOT NULL,
			[DescDepartamento] [varchar](60) NOT NULL,
			[IdEstado] [char] (1) NOT NULL,

			CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
			(
				[IdDepartamento] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Departamentos]
		ADD CONSTRAINT UC_DescDepartamento UNIQUE ([DescDepartamento])


GO

		ALTER TABLE [dbo].[T_Departamentos]  WITH NOCHECK ADD  CONSTRAINT FK_Departamentos_Estados FOREIGN KEY(IdEstado)
		REFERENCES [dbo].[T_Estados] (IdEstado)

GO

		ALTER TABLE [dbo].[T_Departamentos] CHECK CONSTRAINT FK_Departamentos_Estados


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		CREATE TABLE [dbo].[T_Empleados]
		(
			[IdEmpleado] [varchar](7) NOT NULL,
			[Cedula] [varchar](11) NOT NULL,
			[Nombre] [varchar](25) NOT NULL,
			[Apellidos] [varchar](150) NOT NULL,			
			[Direccion] [varchar](150) NOT NULL,
			[Edad] [int] NOT NULL,
			[Telefono_Casa] [varchar](9) NOT NULL,			
			[Telefono_Referencia] [varchar](9) NOT NULL,			
			[Celular] [varchar](9) NOT NULL,			
			[Salario] [decimal](18,2) NOT NULL,
			[IdTipoEmpleado] [int] NOT NULL,
			[IdDepartamento] [char] (5) NOT NULL,
			[IdHorario] [int] NOT NULL,
			[IdEstado] [char] (1) NOT NULL,

			CONSTRAINT [PK_IdEmpledo] PRIMARY KEY CLUSTERED 
			(
				[IdEmpleado] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Empleados]
		ADD CONSTRAINT UC_Empleado UNIQUE ([Cedula])


GO

		ALTER TABLE [dbo].[T_Empleados]  WITH NOCHECK ADD  CONSTRAINT FK_Empleados_TiposEmpleados FOREIGN KEY([IdTipoEmpleado])
		REFERENCES [dbo].[T_TiposEmpleados] ([IdTipoEmpleado])

GO

		ALTER TABLE [dbo].[T_Empleados] CHECK CONSTRAINT FK_Empleados_TiposEmpleados

GO

		ALTER TABLE [dbo].[T_Empleados]  WITH NOCHECK ADD  CONSTRAINT FK_Empleados_Departamentos FOREIGN KEY([IdDepartamento])
		REFERENCES [dbo].[T_Departamentos] ([IdDepartamento])

GO

		ALTER TABLE [dbo].[T_Empleados] CHECK CONSTRAINT FK_Empleados_Departamentos

GO

		ALTER TABLE [dbo].[T_Empleados]  WITH NOCHECK ADD  CONSTRAINT FK_Empleados_Horarios FOREIGN KEY([IdHorario])
		REFERENCES [dbo].[T_Horarios] ([IdHorario])

GO

		ALTER TABLE [dbo].[T_Empleados] CHECK CONSTRAINT FK_Empleados_Horarios

GO

		ALTER TABLE [dbo].[T_Empleados]  WITH NOCHECK ADD  CONSTRAINT FK_Empleados_Estados FOREIGN KEY(IdEstado)
		REFERENCES [dbo].[T_Estados] (IdEstado)

GO

		ALTER TABLE [dbo].[T_Empleados] CHECK CONSTRAINT FK_Empleados_Estados


GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		CREATE TABLE [dbo].[T_Usuarios]
		(			
			[Username] [varchar](15) NOT NULL,
			[Password] [varchar](8) NOT NULL,
			[IdEmpleado] [varchar](7) NOT NULL,					
			[IdEstado] [char] (1) NOT NULL,

			CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
			(				
				[Username] DESC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Usuarios]
		ADD CONSTRAINT UC_Username UNIQUE ([Username])


GO

		ALTER TABLE [dbo].[T_Usuarios]  WITH NOCHECK ADD  CONSTRAINT FK_Usuarios_Empleados FOREIGN KEY([IdEmpleado])
		REFERENCES [dbo].[T_Empleados] ([IdEmpleado])

GO

		ALTER TABLE [dbo].[T_Usuarios] CHECK CONSTRAINT FK_Usuarios_Empleados

GO		

		ALTER TABLE [dbo].[T_Usuarios]  WITH NOCHECK ADD  CONSTRAINT FK_Usuarios_Estados FOREIGN KEY(IdEstado)
		REFERENCES [dbo].[T_Estados] (IdEstado)

GO

		ALTER TABLE [dbo].[T_Usuarios] CHECK CONSTRAINT FK_Usuarios_Estados


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		CREATE TABLE [dbo].[T_TiposClientes]
		(
			[IdTipoCliente] [int] IDENTITY(1,1) NOT NULL,
			[TipoCliente] [varchar](50) NOT NULL,
			[Descripcion] [varchar](150) NOT NULL,
			[IdEstado] [char] (1) NOT NULL,
			CONSTRAINT [PK_TiposClientes] PRIMARY KEY CLUSTERED 
			(
				[IdTipoCliente] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_TiposClientes]
		ADD CONSTRAINT UC_Tipo_Client UNIQUE ([TipoCliente])


GO

		ALTER TABLE [dbo].[T_TiposClientes]  WITH NOCHECK ADD  CONSTRAINT FK_TiposClientes_Estados FOREIGN KEY(IdEstado)
		REFERENCES [dbo].[T_Estados] (IdEstado)

GO

		ALTER TABLE [dbo].[T_TiposClientes] CHECK CONSTRAINT FK_TiposClientes_Estados


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		CREATE TABLE [dbo].[T_Clientes]
		(
			[IdCliente] [varchar](7) NOT NULL,
			[Cedula] [varchar](11) NOT NULL,
			[Nombre] [varchar](25) NOT NULL,
			[Apellidos] [varchar](150) NOT NULL,						
			[TelefonoCasa] [varchar](9) NOT NULL,	
			[TelefonoTrabajo] [varchar](9) NOT NULL,	
			[Fax] [varchar](9) NOT NULL,	
			[Celular1] [varchar](9) NOT NULL,	
			[Celular2] [varchar](9) NOT NULL,	
			[Email] [varchar](150) NOT NULL,	
			[DireccionFisica] [varchar](350) NOT NULL,	
			[IdTipoCliente] [int] NOT NULL,
			[IdEstado] [char] (1) NOT NULL,
	
			CONSTRAINT [PK_IdCliente] PRIMARY KEY CLUSTERED 
			(
				[IdCliente] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Clientes]
		ADD CONSTRAINT UC_Cliente UNIQUE ([Cedula])


GO

		ALTER TABLE [dbo].[T_Clientes]  WITH NOCHECK ADD  CONSTRAINT FK_Clientes_TiposClientes FOREIGN KEY([IdTipoCliente])
		REFERENCES [dbo].[T_TiposClientes] ([IdTipoCliente])

GO

		ALTER TABLE [dbo].[T_Clientes] CHECK CONSTRAINT FK_Clientes_TiposClientes

GO

		ALTER TABLE [dbo].[T_Clientes]  WITH NOCHECK ADD  CONSTRAINT FK_Clientes_Estados FOREIGN KEY(IdEstado)
		REFERENCES [dbo].[T_Estados] (IdEstado)

GO

		ALTER TABLE [dbo].[T_Clientes] CHECK CONSTRAINT FK_Clientes_Estados


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		CREATE TABLE [dbo].[T_MediosElectronicos]
		(
			[IdMedioElectronico] [varchar](7) NOT NULL,
			[NombreMedioElectronico] [varchar](90) NOT NULL,
			[DescMedioElectronico] [varchar](90) NOT NULL,			
			[IdEstado] [char] (1) NOT NULL,

			CONSTRAINT [PK_MediosElectronicos] PRIMARY KEY CLUSTERED 
			(
				[IdMedioElectronico] ASC
			)
		) ON [PRIMARY]
		
GO

		ALTER TABLE [dbo].[T_MediosElectronicos]
		ADD CONSTRAINT UC_NombreMedioElectronico UNIQUE ([NombreMedioElectronico])

GO

		ALTER TABLE [dbo].[T_MediosElectronicos] WITH NOCHECK ADD  CONSTRAINT FK_MediosElectronicos_Estados FOREIGN KEY(IdEstado)
		REFERENCES [dbo].[T_Estados] (IdEstado)

GO

		ALTER TABLE [dbo].[T_MediosElectronicos] CHECK CONSTRAINT FK_MediosElectronicos_Estados



-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		CREATE TABLE [dbo].[T_Cuentas]
		(
			[IdCuenta] [varchar](16) NOT NULL,
			[IdCliente] [varchar](7) NOT NULL,
			[IdProducto] [int] NOT NULL,
			[IdMedioElectronico] [varchar](7) NOT NULL,
			[Saldo] [decimal] (18,2) NOT NULL,
			[FechaApertura] [datetime] NOT NULL,							
			[IdEstado] [char] (1) NOT NULL,

			CONSTRAINT [PK_Cuentas] PRIMARY KEY CLUSTERED 
			(
				[IdCuenta] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Cuentas] WITH NOCHECK ADD  CONSTRAINT FK_Cuentas_Clientes FOREIGN KEY([IdCliente])
		REFERENCES [dbo].[T_Clientes] ([IdCliente])

GO

		ALTER TABLE [dbo].[T_Cuentas] CHECK CONSTRAINT FK_Cuentas_Clientes

GO

		ALTER TABLE [dbo].[T_Cuentas] WITH NOCHECK ADD  CONSTRAINT FK_Cuentas_Productos FOREIGN KEY([IdProducto])
		REFERENCES [dbo].[T_Productos] ([IdProducto])

GO

		ALTER TABLE [dbo].[T_Cuentas] CHECK CONSTRAINT FK_Cuentas_Productos

GO

		ALTER TABLE [dbo].[T_Cuentas] WITH NOCHECK ADD  CONSTRAINT FK_Cuentas_MediosElectronicos FOREIGN KEY([IdMedioElectronico])
		REFERENCES [dbo].[T_MediosElectronicos] ([IdMedioElectronico])

GO

		ALTER TABLE [dbo].[T_Cuentas] CHECK CONSTRAINT FK_Cuentas_MediosElectronicos
		
GO

		ALTER TABLE [dbo].[T_Cuentas] WITH NOCHECK ADD  CONSTRAINT FK_Cuentas_Estados FOREIGN KEY(IdEstado)
		REFERENCES [dbo].[T_Estados] (IdEstado)

GO

		ALTER TABLE [dbo].[T_Cuentas] CHECK CONSTRAINT FK_Cuentas_Estados



-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
