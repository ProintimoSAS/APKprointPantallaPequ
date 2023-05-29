use Prointimo

select * from tblOrdenDeProduccion
where id = 413

delete from tblOrdenDeProduccion
where id = 413

select * from tblOrdenDeProduccion
where codigo = '47858005'

exec ObtenerOrdenesProduccionPorNombreModulo '120'

--ORDEN DE PRODUCCIÓN
create table tblOrdenDeProduccion (
  id integer identity(100,1),
  Codigo varchar (30)not null,
  UnidadesAFabricar int not null,
  Sam float not null,
  Talla varchar (30)not null,
  idModulo integer not null,
  idReferencia integer not null
  FOREIGN KEY (idModulo) REFERENCES tblModulo(id),
  FOREIGN KEY (idReferencia) REFERENCES tblReferencia(id),
  primary key(id)
);


CREATE PROCEDURE ObtenerOrdenesProduccionPorNombreModulo
  @nombreModulo VARCHAR(30)
AS
BEGIN
  SELECT op.*
  FROM tblOrdenDeProduccion op
  INNER JOIN tblModulo m ON op.idModulo = m.id
  WHERE m.Nombre = @nombreModulo;
END

exec ObtenerOrdenesProduccionPorNombreModulo '117'

alter PROCEDURE spBuscarCodigoOrdenProduccion
    @nombreModulo varchar(30)
AS
BEGIN
    SELECT TOP 1 tblOrdenDeProduccion.Codigo
    FROM tblOrdenDeProduccion
    INNER JOIN tblModulo ON tblOrdenDeProduccion.idModulo = tblModulo.id
    WHERE tblModulo.Nombre = @nombreModulo
    AND tblOrdenDeProduccion.id = (SELECT MAX(id) FROM tblOrdenDeProduccion WHERE idModulo = tblModulo.id)
    ORDER BY tblOrdenDeProduccion.id DESC
END


exec InsertarOrdenDeProduccion '1002', 552, 8.534, 'Sin talla', 100, 106

EXEC spBuscarCodigoOrdenProduccion '108';



CREATE PROCEDURE obtenerOrdenProduccionPorId
    @id int
AS
BEGIN
    SELECT * FROM tblOrdenDeProduccion WHERE id = @id;
END



CREATE PROCEDURE obtenerOrdenesDeProduccion
AS
BEGIN
    SELECT * FROM tblOrdenDeProduccion;
END



alter PROCEDURE insertarOrdenDeProduccion
    @Codigo varchar(30),
    @UnidadesAFabricar int,
    @Sam float,
    @Talla varchar(30),
    @nombreModulo varchar(30),
    @codigoReferencia varchar(30)
AS
BEGIN
    INSERT INTO tblOrdenDeProduccion (Codigo, UnidadesAFabricar, Sam, Talla, idModulo, idReferencia)
    VALUES (@Codigo, @UnidadesAFabricar, @Sam, @Talla, (SELECT id FROM tblModulo WHERE Nombre = @nombreModulo), (SELECT id FROM tblReferencia WHERE Codigo = @codigoReferencia));
END


exec insertarOrdenDeProduccion '111', 200, 12.1, 'M', '115', 106

exec InsertarOrdenDeProduccion '47878001', 135, 15.5335, 'XL', 120, 106

exec InsertarOrdenDeProduccion '47555001', 493, 14.56, 'L', 121, 106

exec InsertarOrdenDeProduccion '47780005', 690, 6.787, 'S', 123, 106

exec InsertarOrdenDeProduccion '41758003', 430, 20, 'XS', 124, 106

exec InsertarOrdenDeProduccion '1006', 100, 10.6, 'M', 105, 100

exec InsertarOrdenDeProduccion '1007', 210000, 7.7, 'XL', 106, 100


exec InsertarOrdenDeProduccion '1001', 500, 14.6, 'XL', 100, 106

exec InsertarOrdenDeProduccion '2002', 200, 11.3, 'XL', 108, 101

exec InsertarOrdenDeProduccion '2003', 500, 12.1, 'L', 109, 101

exec InsertarOrdenDeProduccion '2004', 300, 17.8, 'S', 110, 101

exec InsertarOrdenDeProduccion '2005', 100, 9.2, 'XS', 111, 102

exec InsertarOrdenDeProduccion '2006', 300, 10.6, 'M', 112, 102

exec InsertarOrdenDeProduccion '2007', 200, 7.7, 'XL', 113, 102


exec InsertarOrdenDeProduccion '3001', 100, 14.6, 'XL', 114, 103

exec InsertarOrdenDeProduccion '3002', 300, 11.3, 'XL', 115, 103

exec InsertarOrdenDeProduccion '3003', 100, 12.1, 'L', 116, 103

exec InsertarOrdenDeProduccion '3004', 200, 17.8, 'S', 117, 103

exec InsertarOrdenDeProduccion '3005', 100, 9.2, 'XS', 118, 103



exec InsertarOrdenDeProduccion '4001', 300, 14.6, 'M', 119, 104

exec InsertarOrdenDeProduccion '4002', 200, 11.3, 'XL', 120, 104

exec InsertarOrdenDeProduccion '4003', 100, 12.1, 'L', 121, 104

exec InsertarOrdenDeProduccion '4004', 100, 17.8, 'S', 122, 105

exec InsertarOrdenDeProduccion '4005', 150, 9.2, 'XS', 123, 105

exec InsertarOrdenDeProduccion '4006', 250, 10.6, 'M', 124, 105

exec spBuscarCodigoOrdenProduccion '102'

CREATE PROCEDURE actualizarOrdenDeProduccion
    @id int,
    @Codigo varchar(30),
    @UnidadesAFabricar int,
    @Sam float,
    @Talla varchar(30),
    @idModulo int,
    @idReferencia int
AS
BEGIN
    UPDATE tblOrdenDeProduccion 
    SET Codigo = @Codigo, UnidadesAFabricar = @UnidadesAFabricar, Sam = @Sam, Talla = @Talla, idModulo = @idModulo, idReferencia = @idReferencia
    WHERE id = @id;
END



CREATE PROCEDURE eliminarOrdenDeProduccion
    @id int
AS
BEGIN
    DELETE FROM tblOrdenDeProduccion WHERE id = @id;
END


select * from tblOrdenDeProduccion

UPDATE tblOrdenDeProduccion 
    SET UnidadesAFabricar = 588
    WHERE Codigo = '47858005'