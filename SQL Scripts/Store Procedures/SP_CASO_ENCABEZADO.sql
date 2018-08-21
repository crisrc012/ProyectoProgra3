-- Consultar
CREATE PROCEDURE [dbo].[SP_LISTAR_ENCABEZADO]
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

  SELECT [Id_Caso_Enc] as Id
      ,[Fecha] as FechaCaso
      ,[Id_Operador] as Operador
      ,[ComentariosReporte] as Comentarios
      ,[Id_Estado_SemaforoCaso] as EstadoSemaforo
      ,[Id_Estado] as Estado
      ,[FecCreacion] as FechaCreacion
      ,[UsuCreacion] as CreadoUsuario
      ,[FecModificacion] as FechaModificacion
      ,[UsuModificacion] as ModificadoUsuario
  FROM [dbo].[Tbl_Caso_Encabezado]
  WHERE [ComentariosReporte] LIKE '%' + @Desc + '%' AND ([Id_Caso_Enc] = @Id OR @Id < 0)
END

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

CREATE PROCEDURE [dbo].[SP_INSERTAR_ENCABEZADOS]
(
	@Descripcion VARCHAR(65),
	@FechaCaso DATETIME,
	@IdEstado CHAR,
	@IdSemaforo CHAR,
	@IdOperador VARCHAR(11),
	@FechaCreacion DATETIME
)
AS
BEGIN
	INSERT INTO [dbo].[Tbl_Caso_Encabezado]
           (Fecha
           ,Id_Operador
           ,ComentariosReporte
           ,Id_Estado_SemaforoCaso
		   ,Id_Estado
		   ,FecCreacion
		   ,UsuCreacion)
	VALUES
           (@FechaCaso
           ,@IdOperador
		   ,@Descripcion
		   ,@IdSemaforo
		   ,@IdEstado
           ,@FechaCreacion
           ,SUBSTRING(ORIGINAL_LOGIN(), CHARINDEX('\', ORIGINAL_LOGIN(), 0) + 1,15)           )

	SELECT SCOPE_IDENTITY()
END
GO

CREATE PROCEDURE [dbo].SP_BORRAR_ENCABEZADOS
(
	@Id INT
)
AS
BEGIN
	DELETE FROM [dbo].[Tbl_Caso_Encabezado]
    WHERE Id_Caso_Enc = @Id
END
GO


CREATE PROCEDURE [dbo].[SP_MODIFICAR_ENCABEZADOS]
(
	@Descripcion VARCHAR(65),
	@FechaCaso DATETIME,
	@FechaModificacion DATETIME,
	@IdEstado CHAR,
	@IdSemaforo CHAR,
	@Id INT,
	@IdOperador VARCHAR(11)
)
AS
BEGIN
	UPDATE [dbo].[Tbl_Caso_Encabezado]
	SET ComentariosReporte = @Descripcion
	   ,Fecha = @FechaCaso
	   ,[Id_Estado] = @IdEstado
	   ,Id_Estado_SemaforoCaso = @IdSemaforo
	   ,Id_Operador = @IdOperador
       ,[FecModificacion] = @FechaModificacion
	   ,[UsuModificacion] = SUBSTRING(ORIGINAL_LOGIN(), CHARINDEX('\', ORIGINAL_LOGIN(), 0) + 1,15)
	WHERE Id_Caso_Enc = @Id
END
GO