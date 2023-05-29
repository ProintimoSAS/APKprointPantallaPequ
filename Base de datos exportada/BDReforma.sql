use APKproint

-------Creación tablas-------------------------------------------------------------------------------------------------------------------------------------------------------------

--Cliente
create table tblCliente (
  id integer identity(100,1), 
  Nombre varchar (30) not null,
  NIT varchar (30) not null,
  primary key(id)
);

--Pedido
CREATE TABLE tblPedido (
  id INTEGER PRIMARY KEY IDENTITY(100,1),
  Codigo VARCHAR(30) NOT NULL,
  idCliente INTEGER NOT NULL,
  FOREIGN KEY (idCliente) REFERENCES tblCliente(id)
);

--Referencia
create table tblReferencia (
  id integer identity(100,1),  
  Codigo varchar (30)not null,
  Color varchar (30)not null,
  Descripcion varchar (100)not null,
  FechaCreacion date not null,
  UnidadesTotalesAFabricar int not null,
  idPedido integer not null
  CONSTRAINT FK_Modulo FOREIGN KEY (idPedido) REFERENCES tblPedido(id),
  primary key(id)
);

--Módulo
create table tblModulo (
  id integer identity(100,1), 
  Nombre varchar (30) not null,
  primary key(id)
);

--ORDEN DE PRODUCCIÓN
create table tblOrdenDeProduccion (
  id integer identity(100,1),  
  Codigo varchar (30)not null,
  UnidadesAFabricar int not null,
  Sam float not null,
  Talla varchar (30)not null,
  idModulo integer not null,
  idReferencia integer not null
  CONSTRAINT FK_Modulo FOREIGN KEY (idModulo) REFERENCES tblModulo(id),
  CONSTRAINT FK_Modulo FOREIGN KEY (idReferencia) REFERENCES tblReferencia(id),
  primary key(id)
);

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
  UnidadesPorHora float not null,
  Revision BIT not null,
  idOrdenDeProduccion integer not null,  
  CONSTRAINT FK_ModuloC FOREIGN KEY (idOrdenDeProduccion) REFERENCES tblModulo(id),
  primary key(id));

--Empleado
create table tblEmpleado (
  id integer identity(100,1), 
  Nombre varchar (30) not null,
  idCargo int not null,
  idArea int not null,
  CONSTRAINT FK_Cargo FOREIGN KEY (idCargo) REFERENCES tblCargo(id),
  CONSTRAINT FK_Area FOREIGN KEY (idArea) REFERENCES tblArea(id),
  primary key(id)
);

--Imagenes
CREATE TABLE tblImagen (
  id INTEGER PRIMARY KEY IDENTITY(1,1),
  idModulo INTEGER NOT NULL,
  imagen IMAGE NOT NULL,
  FOREIGN KEY (idModulo) REFERENCES tblModulo(id)
);


--Partes de la prenda
CREATE TABLE tblPartePrenda (
  id integer identity(100,1), 
  Descripcion varchar (30) not null
  primary key(id)
);

--Tallas
CREATE TABLE tblTalla (
  id integer identity(100,1), 
  Talla varchar (30) not null
  primary key(id)
);

--Medidas
CREATE TABLE tblMedida (
  id integer identity(100,1), 
  Medida float (30) not null,
  Tipo varchar (30) not null,
  Tolerancia int not null,
  idPartePrenda int not null,
  idTalla int not null
  FOREIGN KEY (idPartePrenda) REFERENCES tblPartePrenda(id),
  FOREIGN KEY (idTalla) REFERENCES tblTalla(id),
  primary key(id)
);

--Medidas de calidad
CREATE TABLE tblMedidasDeCalidad (
  id integer identity(100,1),
  FechaAuditoria date not null,
  Hora time not null,
  UnidadesFueraTolerancia int not null,
  idReferencia int not null,
  idRevisora int not null,
  idAuditora int not null,
  idMedida int not null,
  CONSTRAINT FKReferencia FOREIGN KEY (idReferencia) REFERENCES tblReferencia(id),
  CONSTRAINT FK_Revisora FOREIGN KEY (idRevisora) REFERENCES tblEmpleado(id),
  CONSTRAINT FK_Auditora FOREIGN KEY (idAuditora) REFERENCES tblEmpleado(id),
  CONSTRAINT FK_Medida FOREIGN KEY (idMedida) REFERENCES tblMedida(id),
  primary key(id)
);

--Cargo
create table tblCargo (
  id integer identity(100,1), 
  Descripcion varchar (30) not null,
  primary key(id)
);

--Cargo
create table tblArea (
  id integer identity(100,1), 
  Descripcion varchar (30) not null,
  primary key(id)
);