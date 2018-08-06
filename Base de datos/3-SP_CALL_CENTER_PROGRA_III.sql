USE [DB_CALL_CENTER_PROGRA_III]
GO

-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 1 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-- Consultar
CREATE PROCEDURE SP_LISTAR_ESTADOS
AS
SELECT [Id_Estado] AS ID
      ,[Desc_Estado] AS "Descripción"
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Estados]
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_ESTADOS
(
	@Desc_Estado varchar(65)
)
AS
SELECT [Id_Estado] AS ID
      ,[Desc_Estado] AS "Descripción"
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Estados]
  WHERE [Desc_Estado] LIKE '%' + @Desc_Estado + '%'
GO

-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 1 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 2 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-- Consultar
CREATE PROCEDURE SP_LISTAR_SEMAFOROCASOS
AS
SELECT [Id_Estado_SemaforoCaso] AS ID
      ,[Desc_Estado_SemaforoCaso] AS "Descripción"
      ,[Color]
      ,te.[Desc_Estado] AS Estado
      ,tsc.[FecCreacion] AS "Fecha de Creación"
      ,tsc.[UsuCreacion] AS "Creado por"
      ,tsc.[FecModificacion] AS "Fecha de Modificación"
      ,tsc.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_SemaforoCasos] tsc
  INNER JOIN [dbo].[Tbl_Estados] te ON tsc.Id_Estado = te.Id_Estado
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_SEMAFOROCASOS
(
	@Desc_Estado_SemaforoCaso varchar(65)
)
AS
SELECT [Id_Estado_SemaforoCaso] AS ID
      ,[Desc_Estado_SemaforoCaso] AS "Descripción"
      ,[Color]
      ,te.[Desc_Estado] AS Estado
      ,tsc.[FecCreacion] AS "Fecha de Creación"
      ,tsc.[UsuCreacion] AS "Creado por"
      ,tsc.[FecModificacion] AS "Fecha de Modificación"
      ,tsc.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_SemaforoCasos] tsc
  INNER JOIN [dbo].[Tbl_Estados] te ON tsc.Id_Estado = te.Id_Estado
  WHERE [Desc_Estado_SemaforoCaso] LIKE '%' + @Desc_Estado_SemaforoCaso + '%'
GO

-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 2 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 3 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-- Consultar
CREATE PROCEDURE SP_LISTAR_TIPOACTIVO
AS
SELECT [Id_TipoActivo]
      ,[Desc_TipoActivo]
      ,[Id_Estado]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_TipoActivo]
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_TIPOACTIVO
(
	@Desc_TipoActivo varchar(65)
)
AS
SELECT [Id_TipoActivo]
      ,[Desc_TipoActivo]
      ,[Id_Estado]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_TipoActivo]
  WHERE [Desc_TipoActivo] LIKE '%' + @Desc_TipoActivo + '%'
GO

-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 3 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 4 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-- Consultar
CREATE PROCEDURE SP_LISTAR_MARCAACTIVO
AS
SELECT [Id_MarcaActivo]
      ,[Desc_MarcaActivo]
      ,[Id_Estado]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_MarcaActivo]
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_MARCAACTIVO
(
	@Desc_MarcaActivo varchar(65)
)
AS
SELECT [Id_MarcaActivo]
      ,[Desc_MarcaActivo]
      ,[Id_Estado]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_MarcaActivo]
  WHERE [Desc_MarcaActivo] LIKE '%' + @Desc_MarcaActivo + '%'
GO

-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 4 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 5 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-- Consultar
CREATE PROCEDURE SP_LISTAR_DEPARTAMENTOS
AS
SELECT [Id_Departamento]
      ,[Desc_Departamento]
      ,[Id_Estado]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Departamentos]
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_DEPARTAMENTOS
(
	@Desc_Departamento varchar(65)
)
AS
SELECT [Id_Departamento]
      ,[Desc_Departamento]
      ,[Id_Estado]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Departamentos]
  WHERE [Desc_Departamento] LIKE '%' + @Desc_Departamento + '%'
GO

-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 5 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 6 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-- Consultar
CREATE PROCEDURE SP_LISTAR_ACTIVOS
AS
SELECT [Placa_Activo]
      ,[Id_TipoActivo]
      ,[Desc_Activo]
      ,[Id_MarcaActivo]
      ,[Id_Departamento_Responsable]
      ,[Prioridad_SLA]
      ,[Id_Estado]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Activos]
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_ACTIVOS
(
	@Desc_Activo nvarchar(265)
)
AS
SELECT [Placa_Activo]
      ,[Id_TipoActivo]
      ,[Desc_Activo]
      ,[Id_MarcaActivo]
      ,[Id_Departamento_Responsable]
      ,[Prioridad_SLA]
      ,[Id_Estado]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Activos]
  WHERE [Desc_Activo] LIKE '%' + @Desc_Activo + '%'
GO

-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 6 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 7 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-- Consultar
CREATE PROCEDURE SP_LISTAR_TURNOS
AS
SELECT [Id_Turno]
      ,[Desc_Turno]
      ,[Cant_Horas]
      ,[HoraEntrada]
      ,[HoraSalida]
      ,[Id_Estado]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Turnos]
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_TURNOS
(
	@Desc_Turno varchar(65)
)
AS
SELECT [Id_Turno]
      ,[Desc_Turno]
      ,[Cant_Horas]
      ,[HoraEntrada]
      ,[HoraSalida]
      ,[Id_Estado]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Turnos]
  WHERE [Desc_Turno] LIKE '%' + @Desc_Turno + '%'
GO

-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 7 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 8 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-- Consultar
CREATE PROCEDURE SP_LISTAR_OPERADORES
AS
SELECT [Id_Operador]
      ,[Nombre_Operador]
      ,[Apellidos_Operador]
      ,[NickNameOperador]
      ,[Id_Turno]
      ,[Nivel]
      ,[Id_Estado]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Operadores]
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_OPERADORES
(
	@Id_Operador varchar(11)
)
AS
SELECT [Id_Operador]
      ,[Nombre_Operador]
      ,[Apellidos_Operador]
      ,[NickNameOperador]
      ,[Id_Turno]
      ,[Nivel]
      ,[Id_Estado]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Operadores]
  WHERE [Id_Operador] LIKE '%' + @Id_Operador + '%'
GO

-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 8 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 9 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-- Consultar
CREATE PROCEDURE SP_LISTAR_CASO_ENCABEZADO
AS
SELECT [Id_Caso_Enc]
      ,[Fecha]
      ,[Id_Operador]
      ,[ComentariosReporte]
      ,[Id_Estado_SemaforoCaso]
      ,[Id_Estado]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Caso_Encabezado]
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_CASO_ENCABEZADO
(
	@ComentariosReporte varchar(450)
)
AS
SELECT [Id_Caso_Enc]
      ,[Fecha]
      ,[Id_Operador]
      ,[ComentariosReporte]
      ,[Id_Estado_SemaforoCaso]
      ,[Id_Estado]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Caso_Encabezado]
  WHERE [ComentariosReporte] LIKE '%' + @ComentariosReporte + '%'
GO

-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 9 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 10 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-- Consultar
CREATE PROCEDURE SP_LISTAR_CASO_DETALLE
AS
SELECT [Id_Caso_Det]
      ,[Id_Caso_Enc]
      ,[Placa_Activo]
      ,[Observaciones]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Caso_Detalle]
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_CASO_DETALLE
(
	@Observaciones varchar(450)
)
AS
SELECT [Id_Caso_Det]
      ,[Id_Caso_Enc]
      ,[Placa_Activo]
      ,[Observaciones]
      ,[FecCreacion] AS "Fecha de Creación"
      ,[UsuCreacion] AS "Creado por"
      ,[FecModificacion] AS "Fecha de Modificación"
      ,[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Caso_Detalle]
  WHERE [Observaciones] LIKE '%' + @Observaciones + '%'
GO

-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 10 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------
