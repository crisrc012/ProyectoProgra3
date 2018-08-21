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

--Eliminar
create procedure SP_ELIMINAR_ACTIVOS
(
	@Placa_Activo INT
)
AS
DELETE FROM [dbo].[Tbl_Activos] WHERE Placa_Activo = @Placa_Activo
GO

--Insertar
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

--Modificar
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