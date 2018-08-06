USE [DB_CALL_CENTER_PROGRA_III]
GO

-----------------------------------------------------------------------------------------------------------------------------
-- ****************************************************** TABLA # 1 ****************************************************** --
-----------------------------------------------------------------------------------------------------------------------------

-- Consultar
CREATE PROCEDURE SP_LISTAR_ESTADOS
AS
SELECT [Id_Estado] AS "Código"
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
SELECT [Id_Estado] AS "Código"
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
SELECT [Id_Estado_SemaforoCaso] AS "Código"
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
SELECT [Id_Estado_SemaforoCaso] AS "Código"
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
SELECT [Id_TipoActivo] AS "Código"
      ,[Desc_TipoActivo] AS "Descripción"
      ,tta.[Id_Estado] AS Estado
      ,tta.[FecCreacion] AS "Fecha de Creación"
      ,tta.[UsuCreacion] AS "Creado por"
      ,tta.[FecModificacion] AS "Fecha de Modificación"
      ,tta.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_TipoActivo] tta
  INNER JOIN [dbo].[Tbl_Estados] te ON tta.Id_Estado = te.Id_Estado
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_TIPOACTIVO
(
	@Desc_TipoActivo varchar(65)
)
AS
SELECT [Id_TipoActivo] AS "Código"
      ,[Desc_TipoActivo] AS "Descripción"
      ,tta.[Id_Estado] AS Estado
      ,tta.[FecCreacion] AS "Fecha de Creación"
      ,tta.[UsuCreacion] AS "Creado por"
      ,tta.[FecModificacion] AS "Fecha de Modificación"
      ,tta.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_TipoActivo] tta
  INNER JOIN [dbo].[Tbl_Estados] te ON tta.Id_Estado = te.Id_Estado
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
SELECT [Id_MarcaActivo] AS "Código"
      ,[Desc_MarcaActivo] AS "Descripción"
      ,tma.[Id_Estado] AS Estado
      ,tma.[FecCreacion] AS "Fecha de Creación"
      ,tma.[UsuCreacion] AS "Creado por"
      ,tma.[FecModificacion] AS "Fecha de Modificación"
      ,tma.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_MarcaActivo] tma
  INNER JOIN [dbo].[Tbl_Estados] te ON tma.Id_Estado = te.Id_Estado
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_MARCAACTIVO
(
	@Desc_MarcaActivo varchar(65)
)
AS
SELECT [Id_MarcaActivo] AS "Código"
      ,[Desc_MarcaActivo] AS "Descripción"
      ,tma.[Id_Estado] AS Estado
      ,tma.[FecCreacion] AS "Fecha de Creación"
      ,tma.[UsuCreacion] AS "Creado por"
      ,tma.[FecModificacion] AS "Fecha de Modificación"
      ,tma.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_MarcaActivo] tma
  INNER JOIN [dbo].[Tbl_Estados] te ON tma.Id_Estado = te.Id_Estado
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
SELECT [Id_Departamento] AS "Código"
      ,[Desc_Departamento] AS "Descripción"
      ,td.[Id_Estado] AS Estado
      ,td.[FecCreacion] AS "Fecha de Creación"
      ,td.[UsuCreacion] AS "Creado por"
      ,td.[FecModificacion] AS "Fecha de Modificación"
      ,td.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Departamentos] td
  INNER JOIN [dbo].[Tbl_Estados] te ON td.Id_Estado = te.Id_Estado
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_DEPARTAMENTOS
(
	@Desc_Departamento varchar(65)
)
AS
SELECT [Id_Departamento] AS "Código"
      ,[Desc_Departamento] AS "Descripción"
      ,td.[Id_Estado] AS Estado
      ,td.[FecCreacion] AS "Fecha de Creación"
      ,td.[UsuCreacion] AS "Creado por"
      ,td.[FecModificacion] AS "Fecha de Modificación"
      ,td.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Departamentos] td
  INNER JOIN [dbo].[Tbl_Estados] te ON td.Id_Estado = te.Id_Estado
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
SELECT [Placa_Activo] AS "Placa"
      ,tac.[Desc_TipoActivo] AS "Tipo"
      ,[Desc_Activo] AS "Descripción"
      ,tma.[Desc_MarcaActivo] AS "Marca"
      ,td.[Desc_Departamento] AS "Departamento Responsable"
      ,[Prioridad_SLA] AS "Prioridad (SLA)"
      ,te.[Desc_Estado] AS Estado
      ,ta.[FecCreacion] AS "Fecha de Creación"
      ,ta.[UsuCreacion] AS "Creado por"
      ,ta.[FecModificacion] AS "Fecha de Modificación"
      ,ta.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Activos] ta
  INNER JOIN [dbo].[Tbl_Estados] te ON ta.Id_Estado = te.Id_Estado
  INNER JOIN [dbo].[Tbl_TipoActivo] tac ON ta.Id_TipoActivo = tac.Id_TipoActivo
  INNER JOIN [dbo].[Tbl_MarcaActivo] tma ON ta.Id_MarcaActivo = tma.Id_MarcaActivo
  INNER JOIN [dbo].[Tbl_Departamentos] td ON ta.Id_Departamento_Responsable = td.Id_Departamento
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_ACTIVOS
(
	@Desc_Activo nvarchar(265)
)
AS
SELECT [Placa_Activo] AS "Placa"
      ,tac.[Desc_TipoActivo] AS "Tipo"
      ,[Desc_Activo] AS "Descripción"
      ,tma.[Desc_MarcaActivo] AS "Marca"
      ,td.[Desc_Departamento] AS "Departamento Responsable"
      ,[Prioridad_SLA] AS "Prioridad (SLA)"
      ,te.[Desc_Estado] AS Estado
      ,ta.[FecCreacion] AS "Fecha de Creación"
      ,ta.[UsuCreacion] AS "Creado por"
      ,ta.[FecModificacion] AS "Fecha de Modificación"
      ,ta.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Activos] ta
  INNER JOIN [dbo].[Tbl_Estados] te ON ta.Id_Estado = te.Id_Estado
  INNER JOIN [dbo].[Tbl_TipoActivo] tac ON ta.Id_TipoActivo = tac.Id_TipoActivo
  INNER JOIN [dbo].[Tbl_MarcaActivo] tma ON ta.Id_MarcaActivo = tma.Id_MarcaActivo
  INNER JOIN [dbo].[Tbl_Departamentos] td ON ta.Id_Departamento_Responsable = td.Id_Departamento
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
SELECT [Id_Turno] AS "Código"
      ,[Desc_Turno] AS "Descripción"
      ,[Cant_Horas] AS "Cantidad de horas"
      ,[HoraEntrada] AS "Hora de Entrada"
      ,[HoraSalida] AS "Hora de Salida"
      ,te.[Desc_Estado] AS Estado
      ,tt.[FecCreacion] AS "Fecha de Creación"
      ,tt.[UsuCreacion] AS "Creado por"
      ,tt.[FecModificacion] AS "Fecha de Modificación"
      ,tt.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Turnos] tt
  INNER JOIN [dbo].[Tbl_Estados] te ON tt.Id_Estado = te.Id_Estado
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_TURNOS
(
	@Desc_Turno varchar(65)
)
AS
SELECT [Id_Turno] AS "Código"
      ,[Desc_Turno] AS "Descripción"
      ,[Cant_Horas] AS "Cantidad de horas"
      ,[HoraEntrada] AS "Hora de Entrada"
      ,[HoraSalida] AS "Hora de Salida"
      ,te.[Desc_Estado] AS Estado
      ,tt.[FecCreacion] AS "Fecha de Creación"
      ,tt.[UsuCreacion] AS "Creado por"
      ,tt.[FecModificacion] AS "Fecha de Modificación"
      ,tt.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Turnos] tt
  INNER JOIN [dbo].[Tbl_Estados] te ON tt.Id_Estado = te.Id_Estado
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
SELECT [Id_Operador] AS "Código"
      ,[Nombre_Operador] AS Nombre
      ,[Apellidos_Operador] AS Apellidos
      ,[NickNameOperador] AS Usuario
      ,tt.[Desc_Turno] AS Turno
      ,[Nivel]
      ,te.[Desc_Estado] AS Estado
      ,tbo.[FecCreacion] AS "Fecha de Creación"
      ,tbo.[UsuCreacion] AS "Creado por"
      ,tbo.[FecModificacion] AS "Fecha de Modificación"
      ,tbo.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Operadores] tbo
  INNER JOIN [dbo].[Tbl_Estados] te ON tbo.Id_Estado = te.Id_Estado
  INNER JOIN [dbo].[Tbl_Turnos] tt ON tbo.[Id_Turno] = tt.Id_Turno
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_OPERADORES
(
	@Id_Operador varchar(11)
)
AS
SELECT [Id_Operador] AS "Código"
      ,[Nombre_Operador] AS Nombre
      ,[Apellidos_Operador] AS Apellidos
      ,[NickNameOperador] AS Usuario
      ,tt.[Desc_Turno] AS Turno
      ,[Nivel]
      ,te.[Desc_Estado] AS Estado
      ,tbo.[FecCreacion] AS "Fecha de Creación"
      ,tbo.[UsuCreacion] AS "Creado por"
      ,tbo.[FecModificacion] AS "Fecha de Modificación"
      ,tbo.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Operadores] tbo
  INNER JOIN [dbo].[Tbl_Estados] te ON tbo.Id_Estado = te.Id_Estado
  INNER JOIN [dbo].[Tbl_Turnos] tt ON tbo.[Id_Turno] = tt.Id_Turno
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
SELECT [Id_Caso_Enc] AS "Código"
      ,[Fecha]
      ,[Id_Operador] AS "Operador"
      ,[ComentariosReporte] AS "Comentarios"
      ,tsc.[Desc_Estado_SemaforoCaso] AS "Semáforo"
      ,te.[Desc_Estado] AS "Estado"
      ,tce.[FecCreacion] AS "Fecha de Creación"
      ,tce.[UsuCreacion] AS "Creado por"
      ,tce.[FecModificacion] AS "Fecha de Modificación"
      ,tce.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Caso_Encabezado] tce
  INNER JOIN [dbo].[Tbl_Estados] te ON tce.Id_Estado = te.Id_Estado
  INNER JOIN [dbo].[Tbl_SemaforoCasos] tsc ON tce.Id_Estado_SemaforoCaso = tsc.Id_Estado_SemaforoCaso
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_CASO_ENCABEZADO
(
	@ComentariosReporte varchar(450)
)
AS
SELECT [Id_Caso_Enc] AS "Código"
      ,[Fecha]
      ,[Id_Operador] AS "Operador"
      ,[ComentariosReporte] AS "Comentarios"
      ,tsc.[Desc_Estado_SemaforoCaso] AS "Semáforo"
      ,te.[Desc_Estado] AS "Estado"
      ,tce.[FecCreacion] AS "Fecha de Creación"
      ,tce.[UsuCreacion] AS "Creado por"
      ,tce.[FecModificacion] AS "Fecha de Modificación"
      ,tce.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Caso_Encabezado] tce
  INNER JOIN [dbo].[Tbl_Estados] te ON tce.Id_Estado = te.Id_Estado
  INNER JOIN [dbo].[Tbl_SemaforoCasos] tsc ON tce.Id_Estado_SemaforoCaso = tsc.Id_Estado_SemaforoCaso
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
SELECT [Id_Caso_Det] AS "Código"
      ,tce.ComentariosReporte AS "Encabezado"
      ,[Placa_Activo] AS "Placa"
      ,[Observaciones]
      ,tcd.[FecCreacion] AS "Fecha de Creación"
      ,tcd.[UsuCreacion] AS "Creado por"
      ,tcd.[FecModificacion] AS "Fecha de Modificación"
      ,tcd.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Caso_Detalle] tcd
  INNER JOIN [dbo].[Tbl_Caso_Encabezado] tce ON tcd.Id_Caso_Enc = tce.Id_Caso_Enc
GO

-- Filtrar
CREATE PROCEDURE SP_FILTRAR_CASO_DETALLE
(
	@Observaciones varchar(450)
)
AS
SELECT [Id_Caso_Det] AS "Código"
      ,tce.ComentariosReporte AS "Encabezado"
      ,[Placa_Activo] AS "Placa"
      ,[Observaciones]
      ,tcd.[FecCreacion] AS "Fecha de Creación"
      ,tcd.[UsuCreacion] AS "Creado por"
      ,tcd.[FecModificacion] AS "Fecha de Modificación"
      ,tcd.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Caso_Detalle] tcd
  INNER JOIN [dbo].[Tbl_Caso_Encabezado] tce ON tcd.Id_Caso_Enc = tce.Id_Caso_Enc
  WHERE [Observaciones] LIKE '%' + @Observaciones + '%'
GO

-----------------------------------------------------------------------------------------------------------------------------
-- **************************************************** FIN TABLA # 10 **************************************************** --
-----------------------------------------------------------------------------------------------------------------------------
