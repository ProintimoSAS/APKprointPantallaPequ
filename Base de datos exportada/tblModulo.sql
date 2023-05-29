
use Prointimo

SELECT * FROM tblModulo
--Módulo
create table tblModulo (
  id integer identity(100,1), 
  Nombre varchar (30) not null,
  nave varchar (30) null,
  primary key(id)
);

alter PROCEDURE spPromedioEficienciaAcumuladaPorNave
  @nave varchar(1)
AS
BEGIN
  SELECT 
    AVG(tblProduccionModulo.PorcentajeAcumulado) AS MediaUltimoDatoEficienciaAcumulada
  FROM tblProduccionModulo
  INNER JOIN tblOrdenDeProduccion ON tblProduccionModulo.idOrdenDeProduccion = tblOrdenDeProduccion.id
  INNER JOIN tblModulo ON tblOrdenDeProduccion.idModulo = tblModulo.id
  WHERE tblModulo.nave = @nave AND tblProduccionModulo.id = 
      (SELECT MAX(id) FROM tblProduccionModulo WHERE idOrdenDeProduccion IN 
          (SELECT id FROM tblOrdenDeProduccion WHERE idModulo = tblModulo.id)
      )
END


ALTER PROCEDURE spSumaEficienciaAcumuladaUltimoDatoPorNave
@nave VARCHAR(30),
@fechaEspecifica DATE
AS
BEGIN
SELECT
SUM(tblProduccionModulo.PorcentajeAcumulado) AS SumaUltimoDatoEficienciaAcumulada
FROM tblProduccionModulo
INNER JOIN tblOrdenDeProduccion ON tblProduccionModulo.idOrdenDeProduccion = tblOrdenDeProduccion.id
INNER JOIN tblModulo ON tblOrdenDeProduccion.idModulo = tblModulo.id
WHERE tblModulo.nave = @nave
AND tblProduccionModulo.id = (
SELECT MAX(id)
FROM tblProduccionModulo
WHERE idOrdenDeProduccion IN (
SELECT id
FROM tblOrdenDeProduccion
WHERE idModulo = tblModulo.id
)
AND CONVERT(DATE, Fecha) = @fechaEspecifica
)
END

exec spPromedioEficienciaAcumuladaPorNave '1'


EXEC spPromedioEficienciaAcumuladaPorNave '2'

ALTER TABLE tblModulo
ADD nave varchar(30) null;

CREATE PROCEDURE obtenerModulo
AS
BEGIN
  SELECT * FROM tblModulo;
END

CREATE PROCEDURE obtenerModuloPorId
  @id int
AS
BEGIN
  SELECT * FROM tblModulo WHERE id = @id;
END

CREATE PROCEDURE obtenerIdPorNombreModulo
  @nombreModulo varchar(30)
AS
BEGIN
  SELECT id FROM tblModulo WHERE Nombre = 'nombreModulo';
END

CREATE PROCEDURE insertarModulo
  @Nombre varchar(30)
AS
BEGIN
  INSERT INTO tblModulo (Nombre) VALUES (@Nombre);
END


exec insertarModulo '102'
exec insertarModulo '103'
exec insertarModulo '105'
exec insertarModulo '106'
exec insertarModulo '110'
exec insertarModulo '118'
exec insertarModulo '200'
exec insertarModulo '127'
exec insertarModulo '107'

exec insertarModulo '104'
exec insertarModulo '111'
exec insertarModulo '112'
exec insertarModulo '113'
exec insertarModulo '116'
exec insertarModulo '132'
exec insertarModulo '135'

exec insertarModulo '115'
exec insertarModulo '117'
exec insertarModulo '120'
exec insertarModulo '126'
exec insertarModulo '127'

exec insertarModulo '107'
exec insertarModulo '108'
exec insertarModulo '114'
exec insertarModulo '121'
exec insertarModulo '122'
exec insertarModulo '125'


CREATE PROCEDURE actualizarModulo
  @id int,
  @Nombre varchar(30)
AS
BEGIN
  UPDATE tblModulo SET Nombre = @Nombre WHERE id = @id;
END



CREATE PROCEDURE eliminarModulo
  @id int
AS
BEGIN
  DELETE FROM tblModulo WHERE id = @id;
END
