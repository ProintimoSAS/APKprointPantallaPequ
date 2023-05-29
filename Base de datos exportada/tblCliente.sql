use Prointimo

select * from tblCliente


--Cliente
create table tblCliente (
  id integer identity(100,1), 
  Nombre varchar (30) not null,
  NIT varchar (30) not null,
  primary key(id)
);



CREATE PROCEDURE obtenerClientes
AS
BEGIN
  SELECT id, Nombre, NIT FROM tblCliente;
END

exec obtenerClientes


CREATE PROCEDURE obtenerClientePorId
  @clienteId INTEGER
AS
BEGIN
  SELECT id, Nombre, NIT FROM tblCliente WHERE id = @clienteId;
END


CREATE PROCEDURE insertarCliente
  @nombre VARCHAR(30),
  @nit VARCHAR(30)
AS
BEGIN
  INSERT INTO tblCliente (Nombre, NIT) VALUES (@nombre, @nit);
END

exec InsertarCliente 'ZINGARA', '222'


CREATE PROCEDURE actualizarCliente
  @clienteId INTEGER,
  @nombre VARCHAR(30),
  @nit VARCHAR(30)
AS
BEGIN
  UPDATE tblCliente SET Nombre = @nombre, NIT = @nit WHERE id = @clienteId;
END


CREATE PROCEDURE eliminarCliente
  @clienteId INTEGER
AS
BEGIN
  DELETE FROM tblCliente WHERE id = @clienteId;
END
