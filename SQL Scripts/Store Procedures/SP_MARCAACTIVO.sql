-- Consultar
CREATE PROCEDURE SP_LISTAR_MARCAACTIVO
AS
SELECT [Id_MarcaActivo] AS "Código"
      ,[Desc_MarcaActivo] AS "Descripción"
      ,[Desc_Estado] AS Estado
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

-- Eliminar
create procedure SP_ELIMINAR_MARCAACTIVO
(
	@Id_MarcaActivo INT
)
AS
DELETE FROM [dbo].[Tbl_MarcaActivo] WHERE [Id_MarcaActivo] = @Id_MarcaActivo
GO

-- Insertar
CREATE PROCEDURE SP_INSERTAR_MARCAACTIVO
(
	@Desc_MarcaActivo varchar(65)
    ,@Id_Estado char(1)
)
AS
INSERT INTO [dbo].[Tbl_MarcaActivo]
           ([Desc_MarcaActivo]
           ,[Id_Estado]
           ,[FecCreacion]
           ,[UsuCreacion]
           ,[FecModificacion]
           ,[UsuModificacion])
     VALUES
           (@Desc_MarcaActivo
			,@Id_Estado
			,GETDATE()
			,SUBSTRING(ORIGINAL_LOGIN(), CHARINDEX('\', ORIGINAL_LOGIN(), 0) + 1, 15)
			,null
			,null)
	SELECT MAX ([Id_MarcaActivo])
	FROM [dbo].[Tbl_MarcaActivo]
GO

-- Modificar
CREATE PROCEDURE SP_MODIFICAR_MARCAACTIVO
(
	@Id_MarcaActivo int
	,@Desc_MarcaActivo varchar(65)
	,@Id_Estado char(1)
)
AS
UPDATE [dbo].[Tbl_MarcaActivo]
   SET [Desc_MarcaActivo] = @Desc_MarcaActivo
      ,[Id_Estado] = @Id_Estado
      ,[FecModificacion] = GETDATE()
      ,[UsuModificacion] = SUBSTRING(ORIGINAL_LOGIN(), CHARINDEX('\', ORIGINAL_LOGIN(), 0) + 1, 15)
 WHERE [Id_MarcaActivo] = @Id_MarcaActivo
GO
