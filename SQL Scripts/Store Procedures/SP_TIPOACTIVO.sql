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

create procedure SP_ELIMINAR_TIPOACTIVOS
(
	@Id_TipoActivo INT
)
AS
DELETE FROM [dbo].Tbl_TipoActivo WHERE Id_TipoActivo = @Id_TipoActivo
GO

CREATE PROCEDURE SP_INSERTAR_TIPOACTIVO
(
	@Desc_tipoActivo varchar(65)
    ,@Id_Estado char(1)
)
AS
INSERT INTO  [dbo].[Tbl_TipoActivo]
           ([Desc_TipoActivo]
           ,[Id_Estado]
           ,[FecCreacion]
           ,[UsuCreacion]
           ,[FecModificacion]
           ,[UsuModificacion])
     VALUES
           (@Desc_tipoActivo
			,@Id_Estado
			,GETDATE()
			,'admin'
			,null
			,null)
	SELECT MAX ([Id_TipoActivo])
	FROM [dbo].[Tbl_TipoActivo]
GO

CREATE PROCEDURE [SP_MODIFICAR_TIPOACTIVOS]
(
	@Id_TipoActivo int
	,@Desc_TipoActivo varchar(65)
	,@Id_Estado char(1)
)
AS
UPDATE [dbo].[Tbl_TipoActivo]
   SET [Desc_TipoActivo] = @Desc_TipoActivo
      ,[Id_Estado] = @Id_Estado
      ,[FecModificacion] = GETDATE()
      ,[UsuModificacion] =  'admin'
 WHERE [Id_TipoActivo] = @Id_TipoActivo
GO