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