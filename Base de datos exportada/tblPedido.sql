
use Prointimo
select * from tblPedido

--Pedido
CREATE TABLE tblPedido (
  id INTEGER PRIMARY KEY IDENTITY(100,1),
  Codigo VARCHAR(30) NOT NULL,
  idCliente INTEGER NOT NULL,
  FOREIGN KEY (idCliente) REFERENCES tblCliente(id)
);

CREATE PROCEDURE obtenerPedido
  @id INT
AS
BEGIN
  SELECT * FROM tblPedido WHERE id = @id;
END


CREATE PROCEDURE agregarPedido
  @codigo VARCHAR(30),
  @idCliente INT
AS
BEGIN
  INSERT INTO tblPedido (Codigo, idCliente) VALUES (@codigo, @idCliente);
END

exec agregarPedido '4', '101'


CREATE PROCEDURE actualizarPedido
  @id INT,
  @codigo VARCHAR(30),
  @idCliente INT
AS
BEGIN
  UPDATE tblPedido SET Codigo = @codigo, idCliente = @idCliente WHERE id = @id;
END


CREATE PROCEDURE eliminarPedido
  @id INT
AS
BEGIN
  DELETE FROM tblPedido WHERE id = @id;
END


CREATE PROCEDURE obtenerPedidoPorId
    @id INTEGER
AS
BEGIN
    SELECT * FROM tblPedido WHERE id = @id;
END

exec obtenerPedidoPorId 100