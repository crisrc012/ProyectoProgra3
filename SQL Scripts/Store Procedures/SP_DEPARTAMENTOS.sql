-- Filtrar
CREATE PROCEDURE [dbo].[SP_LISTAR_DEPARTAMENTOS]
(
	@Desc nvarchar(265) = '',
	@Id int = -1
)
AS
BEGIN   
  IF @Desc IS NULL
		SET @Desc = '';

  IF @Id < 0
		SET @Id = -1;

  SELECT [Id_Departamento] AS "Id"
      ,[Desc_Departamento] AS "Descripcion"
      ,td.[Id_Estado] AS Estado
      ,td.[FecCreacion] AS "FechaCreacion"
      ,td.[UsuCreacion] AS "CreadoUsuario"
      ,td.[FecModificacion] AS "FechaModificacion"
      ,td.[UsuModificacion] AS "ModificadoUsuario"
  FROM [dbo].[Tbl_Departamentos] td
  INNER JOIN [dbo].[Tbl_Estados] te ON td.Id_Estado = te.Id_Estado
  WHERE [Desc_Departamento] LIKE '%' + @Desc + '%' AND (Id_Departamento = @Id OR @Id < 0)
END
GO

CREATE PROCEDURE [dbo].[SP_MODIFICAR_DEPARTAMENTO]
(
	@Descripcion VARCHAR(65),
	@FechaModificacion DATETIME,
	@IdEstado CHAR,
	@Id INT
)
AS
BEGIN
	UPDATE [dbo].[Tbl_Departamentos]
	SET [Desc_Departamento] = @Descripcion
	   ,[Id_Estado] = @IdEstado
       ,[FecModificacion] = @FechaModificacion
	   ,[UsuModificacion] = SUBSTRING(ORIGINAL_LOGIN(), CHARINDEX('\', ORIGINAL_LOGIN(), 0) + 1,15)
	WHERE Id_Departamento = @Id
END
GO

CREATE PROCEDURE [dbo].[SP_INSERTAR_DEPARTAMENTO]
(
	@Descripcion VARCHAR(65),
	@FechaCreacion DATETIME,
	@IdEstado CHAR
)
AS
BEGIN
	INSERT INTO [dbo].[Tbl_Departamentos]
           ([Desc_Departamento]
           ,[Id_Estado]
           ,[FecCreacion]
           ,[UsuCreacion])
	VALUES
           (@Descripcion
           ,@IdEstado
           ,@FechaCreacion
           ,SUBSTRING(ORIGINAL_LOGIN(), CHARINDEX('\', ORIGINAL_LOGIN(), 0) + 1,15)           )

	SELECT SCOPE_IDENTITY()
END
GO

CREATE PROCEDURE [dbo].[SP_GET_ESTADOS]
AS
BEGIN
	SELECT [Id_Estado] AS "Id"
      ,[Desc_Estado] AS "Descripcion"      
	FROM [dbo].[Tbl_Estados]
	ORDER BY Desc_Estado ASC
END
GO

CREATE PROCEDURE [dbo].SP_BORRAR_DEPARTAMENTOS
(
	@Id INT
)
AS
BEGIN
	DELETE FROM [dbo].[Tbl_Departamentos]
    WHERE Id_Departamento = @Id
END
GO