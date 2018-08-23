-- Consultar
create PROCEDURE [dbo].[SP_LISTAR_CASO_DETALLE]
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

-- Filtrar
create PROCEDURE [dbo].[SP_FILTRAR_CASO_DETALLE]
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


create procedure SP_ELIMINAR_CASO_DETALLE
(
	@Id_Caso_Det int
)
as
delete from Tbl_Caso_Detalle where Id_Caso_Det = @Id_Caso_Det
go

CREATE PROCEDURE SP_INSERTAR_CASO_DETALLE
(
	  @Id_Caso_Enc INT,
	  @Placa_Activo INT,
	  @Observaciones VARCHAR(450),
	  @FecCreacion DATETIME,
	  @UsuCreacion VARCHAR(15),
	  @FecModificacion DATETIME,
	  @UsuModificacion VARCHAR(15)
)

AS

INSERT INTO [dbo].[Tbl_Caso_Detalle]

		  (
		   [Id_Caso_Enc],
		   [Placa_Activo],
		   [Observaciones],
		   [FecCreacion],
		   [UsuCreacion],
		   [FecModificacion],
		   [UsuModificacion]
		   )

     VALUES
           (
			@Id_Caso_Enc,
			@Placa_Activo,
			@Observaciones,
			@FecCreacion,
			@UsuCreacion,
			@FecModificacion,
			@UsuModificacion)

			select MAX([Id_Caso_Det]) from [dbo].[Tbl_Caso_Detalle]
GO

Create procedure SP_MODIFICAR_CASO_DETALLE

(
	  @Id_Caso_Enc INT,
      	  @Placa_Activo INT,
	  @Observaciones VARCHAR(450),
	  @FecCreacion DATETIME,
	  @UsuCreacion VARCHAR(15),
	  @FecModificacion DATETIME,
	  @UsuModificacion VARCHAR(15)
)

AS
UPDATE [dbo].[Tbl_Caso_Detalle]

	SET
		   [Placa_Activo] = @Placa_Activo,
		   [Observaciones] = @Observaciones,
		   [FecCreacion] = @FecCreacion,
		   [UsuCreacion] = @UsuCreacion,
		   [FecModificacion] = @FecModificacion,
		   [UsuModificacion] = @UsuModificacion

 WHERE [Id_Caso_Enc] = @Id_Caso_Enc
GO






