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

-- Eliminar
create procedure SP_ELIMINAR_ESTADOS
(
	@Id_Estado INT
)
AS
DELETE FROM [dbo].[Tbl_Estados] WHERE [Id_Estado] = @Id_Estado
GO

-- Insertar
CREATE PROCEDURE SP_INSERTAR_ESTADOS
(
	@Desc_Estado varchar(65)
)
AS
INSERT INTO [dbo].[Tbl_Estados]
           ([Id_Estado]
           ,[Desc_Estado]
           ,[FecCreacion]
           ,[UsuCreacion]
           ,[FecModificacion]
           ,[UsuModificacion])
     SELECT
           COUNT(Id_Estado)+1
           ,@Desc_Estado
           ,GETDATE()
           ,SUBSTRING(ORIGINAL_LOGIN(), CHARINDEX('\', ORIGINAL_LOGIN(), 0) + 1,15) --'Obtiene el usuario actual
           ,NULL
           ,NULL
	FROM [dbo].[Tbl_Estados]
GO

-- Update
CREATE PROCEDURE SP_MODIFICAR_ESTADOS
(
	@Id_Estado char(1)
	,@Desc_Estado varchar(65)
)
AS
UPDATE [dbo].[Tbl_Estados]
   SET 
      [Desc_Estado] = @Desc_Estado
      ,[FecModificacion] = GETDATE()
      ,[UsuModificacion] = SUBSTRING(ORIGINAL_LOGIN(), CHARINDEX('\', ORIGINAL_LOGIN(), 0) + 1,15) --'Obtiene el usuario actual
 WHERE [Id_Estado] = @Id_Estado
GO