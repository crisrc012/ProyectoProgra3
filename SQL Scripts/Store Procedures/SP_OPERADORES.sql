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