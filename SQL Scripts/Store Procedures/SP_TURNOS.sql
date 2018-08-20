USE [DB_CALL_CENTER_PROGRA_III]
GO
------------------------------Listar------------------------------
CREATE PROCEDURE SP_LISTAR_TURNOS
AS
SELECT [Id_Turno] AS "Código"
      ,[Desc_Turno] AS "Descripción"
      ,[Cant_Horas] AS "Cantidad de horas"
      ,[HoraEntrada] AS "Hora de Entrada"
      ,[HoraSalida] AS "Hora de Salida"
      ,te.[Desc_Estado] AS Estado
      ,tt.[FecCreacion] AS "Fecha de Creación"
      ,tt.[UsuCreacion] AS "Creado por"
      ,tt.[FecModificacion] AS "Fecha de Modificación"
      ,tt.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Turnos] tt
  INNER JOIN [dbo].[Tbl_Estados] te ON tt.Id_Estado = te.Id_Estado
GO
------------------------------Filtrar------------------------------
CREATE PROCEDURE SP_FILTRAR_TURNOS
(
	@Desc_Turno varchar(65)
)
AS
SELECT [Id_Turno] AS "Código"
      ,[Desc_Turno] AS "Descripción"
      ,[Cant_Horas] AS "Cantidad de horas"
      ,[HoraEntrada] AS "Hora de Entrada"
      ,[HoraSalida] AS "Hora de Salida"
      ,te.[Desc_Estado] AS Estado
      ,tt.[FecCreacion] AS "Fecha de Creación"
      ,tt.[UsuCreacion] AS "Creado por"
      ,tt.[FecModificacion] AS "Fecha de Modificación"
      ,tt.[UsuModificacion] AS "Modificado por"
  FROM [dbo].[Tbl_Turnos] tt
  INNER JOIN [dbo].[Tbl_Estados] te ON tt.Id_Estado = te.Id_Estado
  WHERE [Desc_Turno] LIKE '%' + @Desc_Turno + '%'
GO
------------------------------Insertar------------------------------
create PROCEDURE SP_INSERTAR_TURNOS
(
	@Id_Turno char(1),
	@Desc_Turno varchar(65),
    @Cant_Horas int,
    @HoraEntrada varchar(10),
    @HoraSalida varchar(10),
    @Id_Estado char(1)
)
AS
INSERT INTO [dbo].[Tbl_Turnos]
           ([Id_Turno]
           ,[Desc_Turno]
           ,[Cant_Horas]
           ,[HoraEntrada]
           ,[HoraSalida]
           ,[Id_Estado]
           ,[FecCreacion]
           ,[UsuCreacion]
           ,[FecModificacion]
           ,[UsuModificacion])
     SELECT
			@Id_Turno, @Desc_Turno, @Cant_Horas, @HoraEntrada, 
			@HoraSalida, @Id_Estado, GETDATE(), 
			SUBSTRING(ORIGINAL_LOGIN(), CHARINDEX('\', ORIGINAL_LOGIN(), 0) + 1,15),
			null, null
	FROM [dbo].[Tbl_Turnos]
GO
------------------------------Eliminar------------------------------
create procedure SP_ELIMINAR_TURNOS
(
	@Id_Turno char(1)
)
AS
DELETE FROM [dbo].[Tbl_Turnos] WHERE Id_Turno = @Id_Turno
Go
------------------------------Modificar------------------------------
CREATE PROCEDURE SP_MODIFICAR_TURNOS

(
	@Id_Turno char(1),
	@Desc_Turno varchar(65),
	@Cant_Horas int,
    @HoraEntrada varchar(10),
    @HoraSalida varchar(10),
    @Id_Estado char(1)
)
AS
UPDATE [dbo].[Tbl_Turnos]
   SET [Id_Turno] = @Id_Turno
      ,[Desc_Turno] = @Desc_Turno
      ,[Cant_Horas] = @Cant_Horas
      ,[HoraEntrada] = @HoraEntrada
      ,[HoraSalida] = @HoraSalida
      ,[Id_Estado] = @Id_Estado
      ,[FecModificacion] = GETDATE()
      ,[UsuModificacion] = SUBSTRING(ORIGINAL_LOGIN(), CHARINDEX('\', ORIGINAL_LOGIN(), 0) + 1,15)
 WHERE [Id_Turno] = @Id_Turno
GO
