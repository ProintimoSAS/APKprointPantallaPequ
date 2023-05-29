	
create database databaselibros

use databaselibros

create table libros(
  titulo varchar(40) not null,
  autor varchar(30)not null,
  editorial varchar(15)null,
  precio float null,
  cantidad integer not null
);


insert into libros (titulo,autor,editorial,precio,cantidad)
  values ('El aleph','Borges','Emece',25.50,100);
insert into libros (titulo,autor,editorial,precio,cantidad)
  values ('Alicia en el pais de las maravillas','Lewis Carroll','Atlantida',10,200);
insert into libros (titulo,autor,editorial,precio,cantidad)
  values ('Matematica estas ahi','Paenza','Siglo XXI',18.8,200);


  insert into libros (titulo,autor,editorial,precio,cantidad)
  values('andressito','no es por ti es pormi','Emece','','10');

  select titulo,autor  from libros
  select titulo,autor,editorial from libros
select titulo,autor from libros
select * from libros
where editorial='Siglo XXI' and precio= 18.8

	select * from libros

 select * from libros
  where autor<>'Borges';
   
   select * from libros
  where autor='Borges';

  select * from libros
  where precio >='20';

  select *from libros

  drop table libros 





   
  create table usuarios (
  nombre varchar(30),
  clave varchar(10)
);

insert into usuarios (nombre, clave)
  values ('Marcelo','Boca');
insert into usuarios (nombre, clave)
  values ('JuanPerez','Juancito');
insert into usuarios (nombre, clave)
  values ('Susana','River');
insert into usuarios (nombre, clave)
  values ('Luis','River');
  insert into usuarios (nombre,clave)
  values ('Marcelo','River');
insert into usuarios (nombre,clave)
  values ('Susana','chapita');
insert into usuarios (nombre,clave)
  values ('CarlosFuentes','Boca');
insert into usuarios (nombre,clave)
  values ('FedericoLopez','Boca');

  truncate table usuarios

  select * from usuarios
    select nombre from usuarios where clave='River'
    select nombre from usuarios where clave='santi'


	delete from usuarios where nombre='Marcelo'
	delete from usuarios where clave='boca'
	delete from usuarios

	update usuarios set clave='RealMadrid';
	update usuarios set clave='nueva' where nombre='Federicolopez';	
  select nombre,clave from usuarios where nombre='Federicolopez'
  update usuarios set nombre='Marceloduarte', clave='Marce'
  where nombre='Marcelo';
  update usuarios set clave='payaso'
  where nombre='JuanaJuarez';

	  select * from usuarios
	  drop table usuarios







  create table agenda (
  apellido varchar(30),
  nombre varchar (30),
  domicilio varchar (30),
  telefono varchar(11)  
  );

  insert into agenda (apellido,nombre,domicilio,telefono) values 
  ('Acosta', 'Ana', 'Colon 123', '4234567'),
 ('Bustamante', 'Betina', 'Avellaneda 135', '4458787'),
 ('Lopez', 'Hector', 'Salta 545', '4887788'), 
 ('Lopez', 'Luis', 'Urquiza 333', '4545454'),
 ('Lopez', 'Marisa','Urquiza 333', '4545454');

  insert into agenda (apellido,nombre,domicilio,telefono)
  values ('Acosta','Alberto','Colon 123','4234567');
 insert into agenda (apellido,nombre,domicilio,telefono)
  values ('Juarez','Juan','Avellaneda 135','4458787');
 insert into agenda (apellido,nombre,domicilio,telefono)
  values ('Lopez','Maria','Urquiza 333','4545454');
 insert into agenda (apellido,nombre,domicilio,telefono)
  values ('Lopez','Jose','Urquiza 333','4545454');
 insert into agenda (apellido,nombre,domicilio,telefono)
  values ('Suarez','Susana','Gral. Paz 1234','4123456');


 select* from agenda
 select nombre from agenda where nombre= 'marisa'
 select nombre, domicilio from agenda where apellido = 'lopez'
 select nombre from agenda where telefono ='4545454'


 update agenda set nombre ='juan jose' where nombre = 'juan'
 select nombre, apellido from agenda where nombre ='juan jose'
 update agenda set telefono ='4445566' where telefono = '4545454'
 update agenda set nombre= 'juan' where nombre = 'juan jose'





   ----------------------------------------------------------------------------------------------------




 create table articulos(
  codigo integer,
  nombre varchar(20),
  descripcion varchar(30),
  precio float,
  cantidad integer
 );

insert into articulos (codigo, nombre, descripcion, precio,cantidad)
  values (1,'impresora','Epson Stylus C45',400.80,20);
 insert into articulos (codigo, nombre, descripcion, precio,cantidad)
  values (2,'impresora','Epson Stylus C85',500,30);
 insert into articulos (codigo, nombre, descripcion, precio,cantidad)
  values (3,'monitor','Samsung 14',800,10);
 insert into articulos (codigo, nombre, descripcion, precio,cantidad)
  values (4,'teclado','ingles Biswal',100,50);
 insert into articulos (codigo, nombre, descripcion, precio,cantidad)
  values (5,'teclado','español Biswal',90,50);

  select * from articulos
  select nombre from articulos where nombre='impresora'
  select descripcion from articulos where precio >=400
    select codigo,nombre  from articulos where cantidad < 30
	  select nombre, descripcion from articulos where precio <> 100



select * from usuarios;





drop table 
truncate table





--- tabla medicamentos  evaluar val0res nulos 
create table medicamentos(
codigo integer not null,
nombre varchar(30) not null,
laboratorio varchar(30),
precio float,
cantidad integer not null,
);
exec sp_columns medicamentos;
 insert into medicamentos (codigo,nombre,laboratorio,precio,cantidad)
  values(1,'Sertal gotas',null,null,100); 
 insert into medicamentos (codigo,nombre,laboratorio,precio,cantidad)
  values(2,'Sertal compuesto',null,8.90,150);
 insert into medicamentos (codigo,nombre,laboratorio,precio,cantidad)
  values(3,'Buscapina','Roche',null,200);

  select* from medicamentos 





  ----- clave  primaria 

  if object_id('usuarios') is not null
  drop table usuarios;

  create table usuarios(
  nombre varchar(20),
  clave varchar(10),
  primary key(nombre)
);
exec sp_columns usuarios;

insert into usuarios (nombre, clave)
  values ('juanperez','Boca');
insert into usuarios (nombre, clave)
  values ('raulgarcia','River');

  select* from usuarios



    ----------------------------------------------------------------------------------------------------



  -- identidad del campo identity

  create table camas (
  codigo integer identity(100,2),--incremmenta de 2 en 2
  nombre varchar (30) not null,}

  tipo varchar (30) not null,
  precio float not null
  primary key(codigo)
  );

  insert into camas (nombre,tipo,precio)
  values('cama kinkon','matrimonial',50.000),
  ('cama rinkon','matrim',510.000)
 
 select ident_seed('camas') -- para ver en que valor inicia el identity
 set identity_insert libros on -- para porder insertar valores en indentity
  set identity_insert libros off -- des habilitar la funcion anterior 
  select * from camas 
  drop table camas 

  ----------------------------------------------------------------------------------------------------

  --fecha y hora 
set dateformat 'dmy'
  date 23/11/2022
  time 15:00

  if object_id('empleados') is not null
  drop table empleados;

create table empleados(
  nombre varchar(20),
  documento char(8),
  fechaingreso datetime
);


insert into empleados values('Ana Gomez','22222222','12-01-1980'),
insert into empleados values('Bernardo Huerta','23333333','15-03-81'),
insert into empleados values('Carla Juarez','24444444','20/05/1983'),
insert into empleados values('Daniel Lopez','25555555','2.5.1990');

select * from empleados


-----------------------------------------------------------------------------------------------
--cabiar formato de fecha  e insercion de fromato fecha 
set dateformat 'dmy'
create table alumnos(
nombre varchar(30) not null,
apellido varchar(30)not null,
documento integer not null,
domicilio varchar(30) null,
fechaingreso datetime null,
fechaNacimiento datetime null
); 

insert into alumnos (nombre,apellido,documento,domicilio,fechaingreso,fechaNacimiento)
values('andresito','villada',1040037155,'carrera','19-10-2012', '19-7-2023'),
      ('Gonzalz','Ana',22222222,'Colon 123','10-08-1990','15-02-1972'),
	  ('Juarez','Bernardo',25555555,'Sucre 456','03-03-1991','15-02-1972'),
	  ('Perez','Laura',26666666,'Bulnes 345','03-03-1991',null),
	  ('Lopez','Carlos',27777777,'Sarmiento 1254','03-10-1990',null)

select * from alumnos
truncate table alumnos 
drop table alumnos

 select nombre  from alumnos where fechaingreso = '19-10-2012'
  select nombre  from alumnos where fechaNacimiento is NULL


  ---------------------------------------------------------------------------
  ----realizar un insert sin los parametros 
  if object_id('libros') is not null
  drop table libros;

create table libros(
  codigo int identity,
  titulo varchar(40) not null,
  autor varchar(30),
  editorial varchar(15)
);
insert into libros
  values ('Uno','Richard Bach','Planeta');

  insert into libros (titulo, autor)
  values ('El aleph','Borges');

  select * from libros

  --------------------------------------------------------------------------------
  --establecer párametros para los valores nulos o identificadores
  if object_id('libros') is not null
  drop table libros;

  create table libros(
  codigo int identity,
  titulo varchar(40),
  autor varchar(30) not null default 'Desconocido', 
  editorial varchar(20),
  precio decimal(5,2),
  cantidad tinyint default 0
 );


 insert into libros (titulo,autor,precio,cantidad)
  values ('El gato con botas',default,default,100);

  insert into libros default values;

   select * from libros
   -------------------------------------------------------------------------------
   -------------------valores por default
   if object_id('libros') is not null
  drop table libros;

create table libros(
  codigo int identity,
  titulo varchar(40),
  autor varchar(30) not null default 'Desconocido', 
  editorial varchar(20),
  precio decimal(5,2),
  cantidad tinyint default 0
);

go

-- Ingresamos un registro omitiendo los valores para el campo "autor" y "cantidad":
insert into libros (titulo,editorial,precio)
  values('Java en 10 minutos','Paidos',50.40);

select * from libros;

-- Si ingresamos un registro sin valor para el campo "precio", 
-- que admite valores nulos, se ingresará "null" en ese campo:
insert into libros (titulo,editorial)
  values('Aprenda PHP','Siglo XXI');

select * from libros;

-- Visualicemos la estructura de la tabla:
exec sp_columns libros;

-- Podemos emplear "default" para dar el valor por defecto a algunos campos:
insert into libros (titulo,autor,precio,cantidad)
  values ('El gato con botas',default,default,100);

select * from libros;

-- Como todos los campos de "libros" tienen valores predeterminados, podemos tipear:
insert into libros default values;

select * from libros;

-- Podemos ingresar el valor "null" en el campo "cantidad":
insert into libros (titulo,autor,cantidad)
  values ('Alicia en el pais de las maravillas','Lewis Carroll',null);
  ---------------------------------------------------------------------------
  if object_id('visitantes') is not null
  drop table visitantes;

  create table visitantes(
  nombre varchar(30),
  edad tinyint,
  sexo char(1) default 'f',
  domicilio varchar(30),
  ciudad varchar(20) default 'Cordoba',
  telefono varchar(11),
  mail varchar(30) default 'no tiene',
  montocompra decimal (6,2)
 );

4- Vea la información de las columnas "COLUMN_DEF" y "IS_NULLABLE":
 exec sp_columns visitantes;

5- Ingrese algunos registros sin especificar valores para algunos campos para ver cómo opera la 
cláusula "default":
 insert into visitantes (nombre, domicilio, montocompra)
  values ('Susana Molina','Colon 123',59.80);

  select * from visitantes

 insert into visitantes (nombre, edad, ciudad, mail)
  values ('Marcos Torres',29,'Carlos Paz','marcostorres@hotmail.com');

 select * from visitantes;


6- Use la palabra "default" para ingresar valores en un insert.
 
 insert into visitantes default values;

7- Ingrese un registro con "default values".
--------------------------------------------------------------------------
--operadores aritmeticos suma divicion */


  if object_id ('libros') is not null
  drop table libros;

create table libros(
  codigo int identity,
  titulo varchar(40) not null,
  autor varchar(20) default 'Desconocido',
  editorial varchar(20),
  precio decimal(6,2),
  cantidad tinyint default 0,
  primary key (codigo)
);

go

insert into libros (titulo,autor,editorial,precio)
  values('El aleph','Borges','Emece',25);
insert into libros
  values('Java en 10 minutos','Mario Molina','Siglo XXI',50.40,100);
insert into libros (titulo,autor,editorial,precio,cantidad)
  values('Alicia en el pais de las maravillas','Lewis Carroll','Emece',15,50);

-- Queremos saber el monto total en dinero de cada libro: 
select * from libros
select titulo, precio,cantidad,
  precio*cantidad
  from libros;

-- Conocer el precio de cada libro con un 10% de descuento:
select titulo,precio,
  precio-(precio*0.1)
  from libros;

-- Actualizar los precios con un 10% de descuento:
update libros set precio=precio-(precio*0.1);

select * from libros;

-- Queremos una columna con el título, el autor y la editorial de cada libro:
select titulo+'-'+autor+'-'+editorial
  from libros;
  ------------------------------------------------------------------

  -- concatenacion y operaciones aritmeticas
  create table articulos(
  codigo integer identity,
  nombre varchar (30),
  descripcion varchar (30),
  precio smallmoney,
  cantidad tinyint default 0,
  primary key (codigo)
 );

  
  insert into articulos (nombre, descripcion, precio,cantidad)
  values ('impresora','Epson Stylus C45',400.80,20);
 insert into articulos (nombre, descripcion, precio)
  values ('impresora','Epson Stylus C85',500);
 insert into articulos (nombre, descripcion, precio)
  values ('monitor','Samsung 14',800);
 insert into articulos (nombre, descripcion, precio,cantidad)
  values ('teclado','ingles Biswal',100,50);


  select * from articulos

  update articulos set precio= precio+(precio* 0.15)
  select nombre+'-'+descripcion from articulos
  update articulos set cantidad=cantidad-5 where nombre='teclado'
  -----------------------------------------------------------------------
  --alias 
  if object_id('agenda') is not null
  drop table agenda;

create table agenda(
  nombre varchar(30),
  domicilio varchar(30),
  telefono varchar(11)
);

go

insert into agenda
  values('Juan Perez','Avellaneda 908','4252525');
insert into agenda
  values('Marta Lopez','Sucre 34','4556688');
insert into agenda
  values('Carlos Garcia','Sarmiento 1258',null);

  select * from agenda

select nombre as NombreYApellido,
  domicilio,telefono
  from agenda;

select nombre as 'Nombre y apellido',
  domicilio,telefono
  from agenda;

select nombre 'Nombre y apellido',
  domicilio,telefono
  from agenda;

 if object_id ('libros') is not null
  drop table libros;

  create table libros(
  codigo int identity,
  titulo varchar(40) not null,
  autor varchar(20) default 'Desconocido',
  editorial varchar(20),
  precio decimal(6,2),
  cantidad tinyint default 0,
  primary key (codigo)
 );
 insert into libros (titulo,autor,editorial,precio)
  values('El aleph','Borges','Emece',25);
 insert into libros
  values('Java en 10 minutos','Mario Molina','Siglo XXI',50.40,100);
 insert into libros (titulo,autor,editorial,precio,cantidad)
  values('Alicia en el pais de las maravillas','Lewis Carroll','Emece',15,50);

  SELECT * FROM libros


  
select titulo, autor,editorial,precio,cantidad,
  precio*cantidad as 'monto total'
  from libros;

 
 select titulo,autor,precio,
 precio*0.1 as descuento,
 precio-(precio*0.1) as 'precio final'
 from libros where editorial = 'emese'

 truncate table libros


 select titulo+'-'+autor as "Título y autor"
  from libros;
  -----------------------------------------------------------
  -- Valores entre between 
   select *from libros
  where precio between 20 and 35;

   select *from libros
  where precio not between 20 and 35;

  if object_id('visitas') is not null
  drop table visitas;

  create table visitas (
  numero int identity,
  nombre varchar(30) default 'Anonimo',
  mail varchar(50),
  pais varchar (20),
  fechayhora datetime,
  primary key(numero)
);
insert into visitas (nombre,mail,pais,fechayhora)
  values ('Ana Maria Lopez','AnaMaria@hotmail.com','Argentina','2006-10-10 10:10');
 insert into visitas (nombre,mail,pais,fechayhora)
  values ('Gustavo Gonzalez','GustavoGGonzalez@gotmail.com','Chile','2006-10-10 21:30');
 insert into visitas (nombre,mail,pais,fechayhora)
  values ('Juancito','JuanJosePerez@hotmail.com','Argentina','2006-10-11 15:45');
 insert into visitas (nombre,mail,pais,fechayhora)
  values ('Fabiola Martinez','MartinezFabiola@hotmail.com','Mexico','2006-10-12 08:15');
 insert into visitas (nombre,mail,pais,fechayhora)
  values ('Fabiola Martinez','MartinezFabiola@hotmail.com','Mexico','2006-09-12 20:45');
 insert into visitas (nombre,mail,pais,fechayhora)
  values ('Juancito','JuanJosePerez@gmail.com','Argentina','2006-09-12 16:20');
 insert into visitas (nombre,mail,pais,fechayhora)
  values ('Juancito','JuanJosePerez@hotmail.com','Argentina','2006-09-15 16:25');
 insert into visitas (nombre,mail,pais)
  values ('Federico1','federicogarcia@xaxamail.com','Argentina');


  select * from visitas
  select nombre,fechayhora from visitas where fechayhora between '2006-09-12' and '2006-10-11'
  select numero,nombre,mail,pais,fechayhora from visitas where numero between 2 and 5
  ---------------------------------------------------------------

  -- operadores relacionales (in)
  if object_id ('libros') is not null
  drop table libros;

create table libros(
  codigo int identity,
  titulo varchar(40) not null,
  autor varchar(20),
  editorial varchar(20),
  precio decimal(6,2),
);

go

insert into libros
  values('El aleph','Borges','Emece',15.90);
insert into libros
  values('Cervantes y el quijote','Borges','Paidos',null);
insert into libros
  values('Alicia en el pais de las maravillas','Lewis Carroll',null,19.90);
insert into libros
  values('Matematica estas ahi','Paenza','Siglo XXI',15);
insert into libros (titulo,precio)
  values('Antología poética',32);
insert into libros (titulo,autor,precio)
  values('Martin Fierro','Jose Hernandez',40);
insert into libros (titulo,autor,precio)
  values('Aprenda PHP','Mario Molina',56.50);

  select * from libros

select * from libros
  where autor in('Borges','Paenza');

select * from libros
  where autor not in ('Borges','Paenza');


   if object_id('medicamentos') is not null
  drop table medicamentos;

  create table medicamentos(
  codigo int identity,
  nombre varchar(20),
  laboratorio varchar(20),
  precio decimal(6,2),
  cantidad tinyint,
  fechavencimiento datetime not null,
  primary key(codigo)
 );

 insert into medicamentos
  values('Sertal','Roche',5.2,1,'2015-02-01');
 insert into medicamentos 
  values('Buscapina','Roche',4.10,3,'2016-03-01');
 insert into medicamentos 
  values('Amoxidal 500','Bayer',15.60,100,'2017-05-01');
 insert into medicamentos
  values('Paracetamol 500','Bago',1.90,20,'2018-02-01');
 insert into medicamentos 
  values('Bayaspirina','Bayer',2.10,150,'2019-12-01'); 
 insert into medicamentos 
  values('Amoxidal jarabe','Bayer',5.10,250,'2020-10-01'); 

  select * from medicamentos
  select * from medicamentos where laboratorio in ('bayer','bago') 
--Seleccione los remedios cuya cantidad se encuentre entre 1 y 5 empleando el operador "between" y  luego el operador "in" (2 registros):
  select * from medicamentos
  where cantidad between 1 and 5;
 select * from medicamentos
  where cantidad in (1,2,3,4,5);
--Note que es más conveniente emplear, en este caso, el operador ""between".
-----------------------------------------------------

--Búsqueda de patrones (like - not like)para busqueda especifica  en cadenas largas 
select* from libros
-- Recuperamos todos los libros que contengan en el campo "autor" la cadena "Borges":
select * from libros
  where autor like '%Borges%';

-- Seleccionamos los libros cuyos títulos comienzan con la letra "M":
select * from libros
  where titulo like 'M%';

-- Seleccionamos todos los títulos que NO comienzan con "M":
select * from libros
  where titulo not like 'M%';

-- Si queremos ver los libros de "Lewis Carroll" pero no recordamos si se escribe 
-- "Carroll" o "Carrolt", podemos emplear el comodín "_" (guión bajo) y establecer
-- la siguiente condición:
select * from libros
  where autor like '%Carrol_';

-- Buscamos los libros cuya editorial comienza con las letras entre la "P" y la "S":
select titulo,autor,editorial
  from libros
  where editorial like '[P-S]%';

-- Seleccionamos los libros cuya editorial NO comienza con las letras "P" ni "N":
select titulo,autor,editorial
  from libros
  where editorial like '[^PN]%';

-- Recuperamos todos los libros cuyo precio se encuentra entre 10.00 y 19.99:
select titulo,precio from libros
  where precio like '1_.%';

-- Recuperamos los libros que NO incluyen centavos en sus precios:
select titulo,precio from libros
  where precio like '%.00';

  select * from empleados 

  create table empleados(
  nombre varchar(30),
  documento char(8),
  domicilio varchar(30),
  fechaingreso datetime,
  seccion varchar(20),
  sueldo decimal(6,2),
  primary key(documento)
 );
 insert into empleados
  values('Juan Perez','22333444','Colon 123','1990-10-08','Gerencia',900.50);
 insert into empleados
  values('Ana Acosta','23444555','Caseros 987','1995-12-18','Secretaria',590.30);
 insert into empleados
  values('Lucas Duarte','25666777','Sucre 235','2005-05-15','Sistemas',790);
 insert into empleados
  values('Pamela Gonzalez','26777888','Sarmiento 873','1999-02-12','Secretaria',550);
 insert into empleados
  values('Marcos Juarez','30000111','Rivadavia 801','2002-09-22','Contaduria',630.70);
 insert into empleados
  values('Yolanda Perez','35111222','Colon 180','1990-10-08','Administracion',400);
 insert into empleados
  values('Rodolfo Perez','35555888','Coronel Olmedo 588','1990-05-28','Sistemas',800);

  select* from empleados
  select * from empleados where nombre like '%Perez%'
    select * from empleados where domicilio like 'Co%8%' 
	----------------------------------------------------------------------------
	-- funciones de agregado  

	select * from libros
select count(*)
  from libros
  where editorial='Planeta';

  select * from libros
  select count(*)
  from libros;
    select * from libros
  select count(editorial) from libros where autor='Borges'

select sum (precio) from libros
select max (precio)  from libros 

-------------------------------------------------------------------------
-- group by

select * from libros

select editorial, count(*)
  from libros
  group by editorial;

  select * from libros where editorial='Paidos'

 select editorial,
  max(precio) as mayor,
  min(precio) as menor
  from libros
  group by editorial;

  select editorial, avg(precio)
  from libros
  group by editorial;