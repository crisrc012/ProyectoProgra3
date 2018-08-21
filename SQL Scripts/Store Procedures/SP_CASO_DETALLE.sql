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

create procedure SP_ELIMINAR_ACTIVOS
(
	@Placa_Activo INT
)
AS
DELETE FROM [dbo].[Tbl_Activos] WHERE Placa_Activo = @Placa_Activo
GO

CREATE PROCEDURE SP_INSERTAR_ACTIVO
(
	  @Placa_Activo INT,
	  @Id_TipoActivo INT,
	  @Desc_Activo VARCHAR(265),
	  @Id_MarcaActivo INT,
	  @Id_Departamento_Responsable INT,
	  @Prioridad_SLA DECIMAL(8,2),
	  @Id_Estado CHAR (1),
	  @FecCreacion DATETIME,
	  @UsuCreacion VARCHAR(15),
	  @FecModificacion DATETIME,
	  @UsuModificacion VARCHAR(15)
)

AS

INSERT INTO [Tbl_Activos]

		  ([Placa_Activo],
		   [Id_TipoActivo],
		   [Desc_Activo],
		   [Id_MarcaActivo],
		   [Id_Departamento_Responsable],
		   [Prioridad_SLA],
		   [Id_Estado],
		   [FecCreacion],
		   [UsuCreacion],
		   [FecModificacion],
		   [UsuModificacion]
		   )

     VALUES
           (@Placa_Activo,
			@Id_TipoActivo,
			@Desc_Activo,
			@Id_MarcaActivo,
			@Id_Departamento_Responsable,
			@Prioridad_SLA,
			@Id_Estado,
			@FecCreacion,
			@UsuCreacion,
			@FecModificacion,
			@UsuModificacion)
GO

Create procedure SP_MODIFICAR_ACTIVO

(
	  @Placa_Activo INT,
	  @Id_TipoActivo INT,
	  @Desc_Activo VARCHAR(265),
	  @Id_MarcaActivo INT,
	  @Id_Departamento_Responsable INT,
	  @Prioridad_SLA DECIMAL(8,2),
	  @Id_Estado CHAR (1),
	  @FecCreacion DATETIME,
	  @UsuCreacion VARCHAR(15),
	  @FecModificacion DATETIME,
	  @UsuModificacion VARCHAR(15)
)

AS
UPDATE [dbo].[Tbl_Activos]

	SET
		   [Id_TipoActivo] = @Id_TipoActivo,
		   [Desc_Activo] = @Desc_Activo,
		   [Id_MarcaActivo] = @Id_MarcaActivo,
		   [Id_Departamento_Responsable] = @Id_Departamento_Responsable,
		   [Prioridad_SLA] = @Prioridad_SLA,
		   [Id_Estado] = @Id_Estado,
		   [FecCreacion] = @FecCreacion,
		   [UsuCreacion] = @UsuCreacion,
		   [FecModificacion] = @FecModificacion,
		   [UsuModificacion] = @UsuModificacion

 WHERE [Placa_Activo] = @Placa_Activo
GO





