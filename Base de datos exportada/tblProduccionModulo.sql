
use Prointimo

SELECT * FROM tblProduccionModulo
where idOrdenDeProduccion = 414

delete from tblProduccionModulo
where id = 4926

588
388


exec ObtenerProduccionModuloPorCodigoOrdenDeProduccion '47907012'
--ProduccionModulo
create table tblProduccionModulo (
  id integer identity(100,1),
  CantidadPersonas int not null,
  Fecha date not null,
  Hora time not null,
  UnidadesFaltantes int not null,
  UnidadesFabricadas int not null,
  TiempoPrenda float not null,
  NoConformes int not null,
  PorcentajeParcial int not null,
  PorcentajeAcumulado int not null,
  PorcentajeAcumuladoReal float not null,
  UnidadesPorHora float not null,
  UnidadesPorHoraReales float not null,
  Revision BIT not null,
  tiempoImproductivo BIT null,
  ToTalFabricadas int NULL,
  Comentarios VARCHAR(100) NULL,
  UnidadesDejadasDeFabricar float NULL,
  idOrdenDeProduccion integer not null,
  FOREIGN KEY (idOrdenDeProduccion) REFERENCES tblOrdenDeProduccion(id),
  primary key(id));

ALTER TABLE tblProduccionModulo
DROP COLUMN UnidadesEsperadas;


ALTER TABLE tblProduccionModulo
ADD TotalFabricadas int NULL;

ALTER TABLE tblProduccionModulo
ADD  UnidadesPorHoraReales float;

ALTER TABLE tblProduccionModulo
ADD  PorcentajeAcumuladoReal float;


ALTER TABLE tblProduccionModulo
ALTER COLUMN PorcentajeAcumulado float;

ALTER TABLE tblProduccionModulo
ALTER COLUMN PorcentajeAcumulado float;

alter PROCEDURE ObtenerProduccionModuloPorCodigoOrdenDeProduccion
  @codigoOrdenDeProduccion VARCHAR(30)
AS
BEGIN
  SELECT pm.*
  FROM tblProduccionModulo pm
  INNER JOIN tblOrdenDeProduccion op ON op.id = pm.idOrdenDeProduccion
  INNER JOIN tblModulo m ON m.id = op.idModulo
  WHERE op.Codigo = @codigoOrdenDeProduccion
END


exec ObtenerProduccionModuloPorCodigoOrdenDeProduccion '47907012'


CREATE PROCEDURE obtenerProduccionesModulo
    @id INT
AS
BEGIN
    SELECT * FROM tblProduccionModulo WHERE id = @id;
END

----------------------------------------------

CREATE PROCEDURE buscarProduccionModuloPorId
    @Id int
AS
BEGIN
    SELECT *
    FROM tblProduccionModulo
    WHERE id = @Id
END

--107
exec ingresarProduccionModulo 7,'2023-05-25' , '06:30:00',430, 0, 0, 0,0,0,0,0, 0,'',0,0,0,0,'48118004'

--118
exec ingresarProduccionModulo 7,'2023-05-19' , '06:30:00',205, 5, 10.2, 0,15.3,60.8,12.3,0, 0,'',200,21,'3434346'


UnidadesEsperadas ,
    UnidadesDejadasDeFabricar ;

alter PROCEDURE ingresarProduccionModulo
    @CantidadPersonas INT,
    @Fecha DATE,
    @Hora TIME,
    @UnidadesFaltantes INT,
    @UnidadesFabricadas INT,
    @TiempoPrenda FLOAT,
    @NoConformes INT,
    @PorcentajeParcial float,
    @PorcentajeAcumulado float,
    @UnidadesPorHora FLOAT,
    @Revision BIT,	
	@tiempoImproductivo BIT,
	@Comentarios VARCHAR(100),
	@TotalFabricadas int,
	@UnidadesDejadasDeFabricar float,
	@UnidadesPorHoraReales FLOAT,
	@PorcentajeAcumuladoReal float,
    @codigoOrdenDeProduccion VARCHAR(30)	
AS
BEGIN
    DECLARE @idOrdenDeProduccion INT;
    
    SELECT @idOrdenDeProduccion = id
    FROM tblOrdenDeProduccion
    WHERE Codigo = @codigoOrdenDeProduccion;
    
    INSERT INTO tblProduccionModulo (CantidadPersonas, Fecha, Hora, UnidadesFaltantes, UnidadesFabricadas, TiempoPrenda, NoConformes, PorcentajeParcial, PorcentajeAcumulado, UnidadesPorHora, Revision, tiempoImproductivo,Comentarios, TotalFabricadas,UnidadesDejadasDeFabricar, UnidadesPorHoraReales,PorcentajeAcumuladoReal,idOrdenDeProduccion)
    VALUES (@CantidadPersonas, @Fecha, @Hora, @UnidadesFaltantes, @UnidadesFabricadas, @TiempoPrenda, @NoConformes, @PorcentajeParcial, @PorcentajeAcumulado, @UnidadesPorHora, @Revision, @tiempoImproductivo, @Comentarios, @TotalFabricadas,@UnidadesDejadasDeFabricar, @UnidadesPorHoraReales, @PorcentajeAcumuladoReal,@idOrdenDeProduccion);
END


'1002', 552, 8.534, 'Sin talla', 100, 106




exec ingresarProduccionModulo 7,'2023-01-01' , '06:30:00',468, 7, 10.2, 0,62,62,12.3,0,'47555001'


exec ingresarProduccionModulo 5,'2023-01-01' , '06:30:00',115,118, 10.2, 0,81,81,12.3,0,'47780005'


exec ingresarProduccionModulo 6,'2023-01-01' , '06:30:00',135, 0, 10.2, 0,0,0,12.3,0,'47878001'


exec ingresarProduccionModulo 6,'2023-01-01' , '06:30:00',421, 4, 10.2, 0,59,59,12.3,0,'41758003'


alter PROCEDURE obtenerProduccionModuloPorFecha 
    @fecha DATE
AS
BEGIN
    SELECT *
    FROM tblProduccionModulo pm
    INNER JOIN tblOrdenDeProduccion op ON pm.idOrdenDeProduccion = op.id
    WHERE pm.Fecha = @fecha
END

EXEC obtenerProduccionModuloPorFecha '2023-05-16'

alter PROCEDURE obtenerProduccionModuloPorFechaYOrden
    @fecha DATE,
    @codigoOrdenDeProduccion VARCHAR(30)
AS
BEGIN
    DECLARE @idOrdenDeProduccion INT;
    
    SELECT @idOrdenDeProduccion = id
    FROM tblOrdenDeProduccion
    WHERE Codigo = @codigoOrdenDeProduccion;
    
    SELECT *
    FROM tblProduccionModulo pm
    INNER JOIN tblOrdenDeProduccion op ON pm.idOrdenDeProduccion = op.id
    WHERE pm.Fecha = @fecha AND pm.idOrdenDeProduccion = @idOrdenDeProduccion;
END



exec obtenerProduccionModuloPorFechaYOrden '2023-05-19', '3434346'



CREATE PROCEDURE actualizarProduccionModulo
    @id INT,
    @CantidadPersonas INT,
    @Fecha DATE,
    @Hora TIME,
    @UnidadesFaltantes INT,
    @UnidadesFabricadas INT,
    @TiempoPrenda FLOAT,
    @NoConformes INT,
    @PorcentajeParcial INT,
    @PorcentajeAcumulado INT,
    @UnidadesPorHora FLOAT,
    @Revision BIT,
    @idOrdenDeProduccion INT
AS
BEGIN
    UPDATE tblProduccionModulo
    SET CantidadPersonas = @CantidadPersonas,
        Fecha = @Fecha,
        Hora = @Hora,
        UnidadesFaltantes = @UnidadesFaltantes,
        UnidadesFabricadas = @UnidadesFabricadas,
        TiempoPrenda = @TiempoPrenda,
        NoConformes = @NoConformes,
        PorcentajeParcial = @PorcentajeParcial,
        PorcentajeAcumulado = @PorcentajeAcumulado,
        UnidadesPorHora = @UnidadesPorHora,
        Revision = @Revision,
        idOrdenDeProduccion = @idOrdenDeProduccion
    WHERE id = @id;
END


ALTER PROCEDURE eliminarUltimoDatoProduccionModuloPorCodigoOrdenDeProduccion 
    @codigoOrdenDeProduccion VARCHAR(30)
AS
BEGIN
    DECLARE @idOrdenDeProduccion INT
    DECLARE @idUltimoDatoProduccionModulo INT

    -- Obtener el id de la orden de producción a partir de su código
    SELECT @idOrdenDeProduccion = id
    FROM tblOrdenDeProduccion
    WHERE Codigo = @codigoOrdenDeProduccion

    -- Obtener el id del último dato de producción modulo relacionado con la orden de producción especificada
    SELECT TOP 1 @idUltimoDatoProduccionModulo = id
    FROM tblProduccionModulo
    WHERE idOrdenDeProduccion = @idOrdenDeProduccion
    ORDER BY id DESC

    -- Eliminar el último dato de producción modulo
    DELETE FROM tblProduccionModulo
    WHERE id = @idUltimoDatoProduccionModulo
END



exec ingresarProduccionModulo 19,'2022-01-01' , '10:30:00',500,20,10.2,0,83,73,12.3,0,'1001'

exec ObtenerProduccionModuloPorCodigoOrdenDeProduccion '48061003'

exec obtenerProduccionModuloPorFechaYOrden '2023-05-08' , '47863006'

exec eliminarUltimoDatoProduccionModuloPorCodigoOrdenDeProduccion '47933003'

CREATE PROCEDURE eliminarProduccionModulo
    @id INT
AS
BEGIN
    DELETE FROM tblProduccionModulo WHERE id = @id;
END


CREATE PROCEDURE ObtenerProduccionModuloPorFechaYModulo
  @NombreModulo VARCHAR(30),
  @FechaProduccion DATE
AS
BEGIN
  SELECT pm.*
  FROM tblProduccionModulo pm
  INNER JOIN tblOrdenDeProduccion op ON pm.idOrdenDeProduccion = op.id
  INNER JOIN tblModulo m ON op.idModulo = m.id
  WHERE m.Nombre = @NombreModulo
    AND CONVERT(DATE, pm.Fecha) = @FechaProduccion
END

EXEC ObtenerProduccionModuloPorFechaYModulo  '102', '2023-05-26' 


exec obtenerProduccionModuloPorFechaYOrden '2023-05-04', '47560004'



CREATE PROCEDURE ObtenerSumaUnidadesPorHoraPorNaveYFecha
  @nombreNave VARCHAR(30),
  @fecha DATE
AS
BEGIN
  SELECT SUM(UnidadesPorHora) AS SumaUnidadesPorHora
  FROM tblProduccionModulo pm
  INNER JOIN tblOrdenDeProduccion op ON pm.idOrdenDeProduccion = op.id
  INNER JOIN tblModulo m ON op.idModulo = m.id
  WHERE m.nave = @nombreNave
    AND CONVERT(DATE, pm.Fecha) = @fecha;
END;


exec ObtenerSumaUnidadesPorHoraPorNaveYFecha '1','2023-05-23'

CREATE PROCEDURE ObtenerSumaUnidadesFabricadasPorNaveYFecha
  @nombreNave VARCHAR(30),
  @fecha DATE
AS
BEGIN
  SELECT SUM(UnidadesFabricadas) AS SumaUnidadesFabricadas
  FROM tblProduccionModulo pm
  INNER JOIN tblOrdenDeProduccion op ON pm.idOrdenDeProduccion = op.id
  INNER JOIN tblModulo m ON op.idModulo = m.id
  WHERE m.nave = @nombreNave
    AND CONVERT(DATE, pm.Fecha) = @fecha;
END;

exec ObtenerSumaUnidadesFabricadasPorNaveYFecha '4','2023-05-24'


CREATE PROCEDURE ObtenerSumaUnidadesPorHoraRealPorNaveYFecha
  @nombreNave VARCHAR(30),
  @fecha DATE
AS
BEGIN
  SELECT SUM(UnidadesPorHoraReales) AS SumaUnidadesPorHoraReal
  FROM tblProduccionModulo pm
  INNER JOIN tblOrdenDeProduccion op ON pm.idOrdenDeProduccion = op.id
  INNER JOIN tblModulo m ON op.idModulo = m.id
  WHERE m.nave = @nombreNave
    AND CONVERT(DATE, pm.Fecha) = @fecha;
END;

exec ObtenerSumaUnidadesPorHoraRealPorNaveYFecha '4','2023-05-24';





CREATE PROCEDURE ObtenerFabricadasComentariosPorcentajeAcumRealPorFechaYModulo
  @NombreModulo VARCHAR(30),
  @FechaProduccion DATE
AS
BEGIN
  SELECT pm.CantidadPersonas, pm.UnidadesFabricadas, pm.PorcentajeAcumulado, pm.PorcentajeAcumuladoReal
  FROM tblProduccionModulo pm
  INNER JOIN tblOrdenDeProduccion op ON pm.idOrdenDeProduccion = op.id
  INNER JOIN tblModulo m ON op.idModulo = m.id
  WHERE m.Nombre = @NombreModulo
    AND CONVERT(DATE, pm.Fecha) = @FechaProduccion
END


exec ObtenerFabricadasComentariosPorcentajeAcumRealPorFechaYModulo '106', '2023-05-25'




select * from tblProduccionModulo

UPDATE tblProduccionModulo 
    SET UnidadesFaltantes = 380
    WHERE id = 5381