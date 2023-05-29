
use Prointimo
select * from tblReferencia

delete  from tblReferencia
where id >201

--Referencia
create table tblReferencia (
  id integer identity(100,1),  
  Codigo varchar (30)not null,
  Color varchar (30)not null,
  Descripcion varchar (100)not null,
  FechaCreacion date not null,
  UnidadesTotalesAFabricar int not null,
  idPedido integer not null
  FOREIGN KEY (idPedido) REFERENCES tblPedido(id),
  primary key(id)
);

CREATE PROCEDURE BuscarReferenciaPorCodigo
  @codigo_referencia varchar(30)
AS
BEGIN
  SELECT id, Codigo, Color, Descripcion, FechaCreacion, UnidadesTotalesAFabricar, idPedido
  FROM tblReferencia
  WHERE Codigo = @codigo_referencia;
END

exec BuscarReferenciaPorCodigo '12'


CREATE PROCEDURE BuscarReferenciaPorOrdenProduccion
    @codigoOrdenProduccion VARCHAR(30)
AS
BEGIN
    SELECT r.*
    FROM tblReferencia r
    INNER JOIN tblPedido p ON r.idPedido = p.id
    INNER JOIN tblOrdenDeProduccion o ON r.id = o.idReferencia
    WHERE o.Codigo = @codigoOrdenProduccion;
END

exec BuscarReferenciaPorOrdenProduccion '123'


CREATE PROCEDURE obtenerReferencias
AS
BEGIN
  SELECT * FROM tblReferencia;
END;


CREATE PROCEDURE obtenerReferenciaPorID
  @id INT
AS
BEGIN
  SELECT * FROM tblReferencia WHERE id = @id;
END;


CREATE PROCEDURE insertarReferencia
  @Codigo VARCHAR(30),
  @Color VARCHAR(30),
  @Descripcion VARCHAR(100),
  @FechaCreacion DATE,
  @UnidadesTotalesAFabricar INT,
  @idPedido INT
AS
BEGIN
  INSERT INTO tblReferencia (Codigo, Color, Descripcion, FechaCreacion, UnidadesTotalesAFabricar, idPedido)
  VALUES (@Codigo, @Color, @Descripcion, @FechaCreacion, @UnidadesTotalesAFabricar, @idPedido);
END;

exec insertarReferencia 'ZB1000257','VERDE','LEGGIGNS','2022-01-01', 430, 103


CREATE PROCEDURE actualizarReferencia
  @id INT,
  @Codigo VARCHAR(30),
  @Color VARCHAR(30),
  @Descripcion VARCHAR(100),
  @FechaCreacion DATE,
  @UnidadesTotalesAFabricar INT,
  @idPedido INT
AS
BEGIN
  UPDATE tblReferencia
  SET Codigo = @Codigo,
      Color = @Color,
      Descripcion = @Descripcion,
      FechaCreacion = @FechaCreacion,
      UnidadesTotalesAFabricar = @UnidadesTotalesAFabricar,
      idPedido = @idPedido
  WHERE id = @id;
END;


CREATE PROCEDURE eliminarReferencia
  @id INT
AS
BEGIN
  DELETE FROM tblReferencia WHERE id = @id;
END;


