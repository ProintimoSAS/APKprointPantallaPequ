use APKProin
---------MODULO
create table tblModulo (
  id integer identity(100,1), 
  Nombre varchar (30) not null,
  primary key(id));
  
  CREATE PROCEDURE spInsertarModulo
  @Nombre varchar(30)
AS
BEGIN
  INSERT INTO tblModulo (Nombre)
  VALUES (@Nombre)
END

EXEC spInsertarModulo '107'
EXEC spInsertarModulo '108'
EXEC spInsertarModulo '114'
EXEC spInsertarModulo '121'
EXEC spInsertarModulo '122'
EXEC spInsertarModulo '125'

CREATE PROCEDURE spConsultarModulo
AS
BEGIN
  SELECT * FROM tblModulo
END

EXEC spConsultarModulo


--------------ORDEN DE PRODUCCIÓN
create table tblOrdenDeProduccion (
  id integer identity(100,1),
  idModulo integer not null,
  NumeroOrden varchar (30)not null,
  Referencia varchar (30) not null,
  UnidadesTotalesAFabricar int not null,
  Sam float not null
  CONSTRAINT FK_Modulo FOREIGN KEY (idModulo) REFERENCES tblModulo(id),
  primary key(id));


  alter PROCEDURE spInsertarOrdenProduccion
  @nombreModulo varchar(30),
  @NumeroOrden varchar(30),
  @Referencia varchar(30),
  @UnidadesTotalesAFabricar int,
  @Sam float
AS
BEGIN
	DECLARE @idModulo int;

  -- Obtener el ID del módulo correspondiente al nombre ingresado
  SELECT @idModulo = id FROM tblModulo WHERE Nombre = @nombreModulo;

  INSERT INTO tblOrdenDeProduccion (idModulo, NumeroOrden, Referencia, UnidadesTotalesAFabricar, Sam)
  VALUES (@idModulo, @NumeroOrden, @Referencia, @UnidadesTotalesAFabricar, @Sam)
END

CREATE PROCEDURE spConsultarOrdenProduccion
AS
BEGIN
  SELECT * FROM tblModulo
  SELECT * FROM tblOrdenDeProduccion

END

exec spConsultarOrdenProduccion

CREATE PROCEDURE ObtenerUnidadesAFabricarPorModulo
    @nombreModulo varchar(30)
AS
BEGIN
    SELECT o.UnidadesTotalesAFabricar
    FROM tblOrdenDeProduccion o
    JOIN tblControl c ON o.idModulo = c.idModulo
    JOIN tblModulo m ON o.idModulo = m.id
    WHERE m.Nombre = @nombreModulo;
END

exec ObtenerOrdenesProduccionPorModulo '102'

CREATE PROCEDURE ObtenerOrdenesProduccionPorModulo
  @NombreModulo varchar(30)
AS
BEGIN
  SELECT op.id, op.NumeroOrden, op.Referencia, op.UnidadesTotalesAFabricar, op.Sam
  FROM tblOrdenDeProduccion op
  INNER JOIN tblModulo m ON op.idModulo = m.id
  WHERE m.Nombre = @NombreModulo
END

CREATE PROCEDURE spInsertarOrdenPorModulo
  @NombreModulo varchar(30),
  @NumeroOrden varchar(30),
  @Referencia varchar(30),
  @UnidadesTotalesAFabricar int,
  @Sam float
AS
BEGIN
  DECLARE @idModulo int
  SELECT @idModulo = id FROM tblModulo WHERE Nombre = @NombreModulo
  
  INSERT INTO tblOrdenDeProduccion (idModulo, NumeroOrden, Referencia, UnidadesTotalesAFabricar, Sam)
  VALUES (@idModulo, @NumeroOrden, @Referencia, @UnidadesTotalesAFabricar, @Sam)
END


exec spInsertarOrdenPorModulo '108', '12345678', '13254', 420, 14.655

exec spInsertarOrdenPorModulo '107', '47334002', 'as42gd', 300, 14.655

exec spInsertarOrdenPorModulo '114', '96325841', '25sf15', 215, 14.655

exec spInsertarOrdenPorModulo '121', '15963278', '45678', 118, 14.655

exec spInsertarOrdenPorModulo '122', '45678925', 'asdb1', 200, 14.655

exec spInsertarOrdenPorModulo '125', '96314587', '12df1', 400, 14.655
-----------------CONTROL
  create table tblControl (
  id integer identity(100,1),
  idModulo integer not null,
  CantidadPersonas int not null,
  Fecha date not null,
  Hora time not null,
  UnidadesFaltantes int not null,
  UnidadesFabricadas int not null,
  TiempoPrenda float not null,
  NoConformes int,
  PorcentajeParcial int not null,
  PorcentajeAcumulado int not null
  CONSTRAINT FK_ModuloC FOREIGN KEY (idModulo) REFERENCES tblModulo(id),
  primary key(id));


  ALTER TABLE tblControl ADD UnidadesXHora float not null DEFAULT 0


  CREATE PROCEDURE spInsertarControl
  @nombreModulo varchar(30),
  @CantidadPersonas int,
  @Fecha date,
  @Hora time,
  @UnidadesFaltantes int,
  @UnidadesFabricadas int,
  @TiempoPrenda float,
  @NoConformes int
AS
BEGIN
	DECLARE @idModulo int;

	-- Obtener el ID del módulo correspondiente al nombre ingresado
  SELECT @idModulo = id FROM tblModulo WHERE Nombre = @nombreModulo;

  INSERT INTO tblControl (idModulo, CantidadPersonas, Fecha, Hora, UnidadesFaltantes, UnidadesFabricadas, TiempoPrenda, NoConformes)
  VALUES (@idModulo, @CantidadPersonas, @Fecha, @Hora, @UnidadesFaltantes, @UnidadesFabricadas, @TiempoPrenda, @NoConformes)
END


exec spInsertarControl '102', 6,'2022-01-01' , '10:30:00', 200, 12, 15.3, 0

CREATE PROCEDURE spConsultarControl
AS
BEGIN
  SELECT * FROM tblControl
END

ALTER PROCEDURE ObtenerDatosControlPorModulo
    @nombreModulo VARCHAR(30)
AS
BEGIN
    SELECT tblControl.id, tblControl.CantidadPersonas, tblControl.Fecha, tblControl.Hora, tblControl.UnidadesFaltantes, 
           tblControl.UnidadesFabricadas, tblControl.TiempoPrenda, tblControl.NoConformes, tblControl.PorcentajeParcial, 
           tblControl.PorcentajeAcumulado, tblControl.UnidadesXHora
    FROM tblControl
    INNER JOIN tblModulo ON tblControl.idModulo = tblModulo.id
    WHERE tblModulo.Nombre = @nombreModulo
END

	exec  ObtenerDatosControlPorModulo '102'


ALTER PROCEDURE InsertarControlParaModulo
  @nombreModulo VARCHAR(30),
  @cantidadPersonas INT,
  @fecha DATE,
  @hora TIME,
  @unidadesFaltantes INT,
  @unidadesFabricadas INT,
  @tiempoPrenda FLOAT,
  @noConformes INT,
  @porcentajeParcial INT,
  @porcentajeAcumulado INT,
  @unidadesXHora FLOAT -- Nuevo parámetro
AS
BEGIN
  DECLARE @idModulo INT;

  -- Obtener el ID del módulo correspondiente al nombre ingresado
  SELECT @idModulo = id FROM tblModulo WHERE Nombre = @nombreModulo;

  -- Insertar el registro en tblControl con el ID del módulo correspondiente y los porcentajes parcial y acumulado
  INSERT INTO tblControl (idModulo, CantidadPersonas, Fecha, Hora, UnidadesFaltantes, UnidadesFabricadas, TiempoPrenda, NoConformes, PorcentajeParcial, PorcentajeAcumulado, UnidadesXHora)
  VALUES (@idModulo, @cantidadPersonas, @fecha, @hora, @unidadesFaltantes, @unidadesFabricadas, @tiempoPrenda, @noConformes, @porcentajeParcial, @porcentajeAcumulado, @unidadesXHora);
END

EXEC InsertarControlParaModulo '125',6, '2023-02-28', '6:30:00', 10, 20, 1.5, 2, 12, 10;


alter PROCEDURE spActualizarControlPorModulo
    @nombreModulo VARCHAR(30),
    @unidadesFaltantes INT
AS
BEGIN
    UPDATE tblControl
    SET UnidadesFaltantes = @unidadesFaltantes,
        UnidadesFabricadas = 0,
		PorcentajeAcumulado = 0,
		PorcentajeParcial = 0
    FROM tblControl AS C
    INNER JOIN tblModulo AS M ON C.idModulo = M.id
    WHERE M.Nombre = @nombreModulo
END



  -------------------------------------------------------------------------------------------------
  --CONSULTAS

alter PROCEDURE sp_obtener_datos_modulo
    @nombre_modulo varchar(30),
    @dato_a_obtener varchar(30) -- 'numero', 'referencia', 'cantidad_personas', 'unidades_totales' o 'no_conformes'
AS
BEGIN
    IF @dato_a_obtener = 'NumeroOrden'
    BEGIN
        SELECT o.NumeroOrden
        FROM tblOrdenDeProduccion o
        INNER JOIN tblModulo m ON m.id = o.idModulo
        WHERE m.Nombre = @nombre_modulo
    END
    ELSE IF @dato_a_obtener = 'Referencia'
    BEGIN
        SELECT o.Referencia
        FROM tblOrdenDeProduccion o
        INNER JOIN tblModulo m ON m.id = o.idModulo
        WHERE m.Nombre = @nombre_modulo
    END
    ELSE IF @dato_a_obtener = 'CantidadPersonas'
    BEGIN
        SELECT c.CantidadPersonas
        FROM tblControl c
        INNER JOIN tblModulo m ON m.id = c.idModulo
        WHERE m.Nombre = @nombre_modulo
    END
    ELSE IF @dato_a_obtener = 'UnidadesTotalesAFabricar'
    BEGIN
        SELECT o.UnidadesTotalesAFabricar
        FROM tblOrdenDeProduccion o
        INNER JOIN tblModulo m ON m.id = o.idModulo
        WHERE m.Nombre = @nombre_modulo
    END
    ELSE IF @dato_a_obtener = 'NoConformes'
    BEGIN
        SELECT c.NoConformes
        FROM tblControl c
        INNER JOIN tblModulo m ON m.id = c.idModulo
        WHERE m.Nombre = @nombre_modulo
    END
	ELSE IF @dato_a_obtener = 'Sam'
    BEGIN
        SELECT o.Sam
        FROM tblOrdenDeProduccion o
        INNER JOIN tblModulo m ON m.id = o.idModulo
        WHERE m.Nombre = @nombre_modulo
    END
	ELSE IF @dato_a_obtener = 'UnidadesFabricadas'
    BEGIN
        SELECT c.UnidadesFabricadas
        FROM tblControl c
        INNER JOIN tblModulo m ON m.id = c.idModulo
        WHERE m.Nombre = @nombre_modulo
    END
	ELSE IF @dato_a_obtener = 'PorcentajeAcumulado'
    BEGIN
        SELECT c.PorcentajeAcumulado
        FROM tblControl c
        INNER JOIN tblModulo m ON m.id = c.idModulo
        WHERE m.Nombre = @nombre_modulo
    END   
	ELSE IF @dato_a_obtener = 'PorcentajeParcial'
    BEGIN
        SELECT c.PorcentajeParcial
        FROM tblControl c
        INNER JOIN tblModulo m ON m.id = c.idModulo
        WHERE m.Nombre = @nombre_modulo
    END
    ELSE
    BEGIN
        PRINT 'Error: El parámetro @dato_a_obtener debe ser "numero", "referencia", "cantidad_personas", "unidades_totales" o "no_conformes".'
    END
END

exec sp_obtener_datos_modulo '102','SAM'

SELECT *
FROM tblOrdenDeProduccion;

-- Consulta para mostrar la información de la tabla tblModulo
SELECT *
FROM tblModulo;

-- Consulta para mostrar la información de la tabla tblControl
SELECT *
FROM tblControl;


<<<<<<< HEAD
<<<<<<< HEAD
Delete from tblControl
where id >= 100
=======
	Delete from tblControl
	where idModulo = 108
=======
	delete from tblControl
	where id >= 100
>>>>>>> 596f4ff8879d01b39b7f6c5aaf2bb73e17e9265e

	EXEC InsertarControlParaModulo '102',6, '2023-02-28', '6:30:00', 10, 20, 1.5, 2, 12, 10;

<<<<<<< HEAD
>>>>>>> 9c5f08b1c90e90b023645750982ed2cac7bbe917
=======
	DBCC CHECKIDENT ('tblModulo', RESEED, 99);
>>>>>>> 596f4ff8879d01b39b7f6c5aaf2bb73e17e9265e
