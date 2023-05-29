use master 

create database APKProin

use APKProin

EXEC master..sp_addsrvrolemember @loginame = N'Shubhankar', @rolename = N'dbcreator'
GO

create table tblIngresoLogin (
codigo int identity (1,1),
usuario varchar (30)not null,
clave varchar (30) not null
primary key (usuario));

  

  insert into tblIngresoLogin values ('andres','123');

  select * from tblIngresoLogin
 

  CREATE PROCEDURE SP_Ingresologin 
  @usuario varchar (30),
  @clave varchar (30) 
  as 
  begin 
  select * from tblIngresoLogin
  where tblIngresoLogin.usuario=@usuario and tblIngresoLogin.clave=@clave

  end
  go

----------------------------------------------------------------------------------------------------------------------------------
  

create table tblEpleado(
codigo varchar (10),
nombre varchar (30)not null,
apellido varchar (30) not null,
area varchar (30)not null,
cargo varchar (30)not null,
primary key (codigo));


 insert into tblEpleado values 
 ('i130','andres','villada','sistemas','analista'),
 ('i131','juan camilo','vargas','comercio','analista'),
 ('i140','juan david','palacio','confeccion','comercial'),
  ('i115','viviana farley','aristizabal','confeccion','confecionista');
  
  select * from tblEpleado

  create procedure SP_InsetarUsuario


----------------------------------------------------------------------------------------------------------------

  create table tblControlPiso (

  codigo integer identity(100,1), 
  Referencia varchar (30) not null,
  OrdenProduccion varchar (30) not null,
  fecha date not null,
  hora time not null,
  UnidadesAFabricar int not null,
  Cantpersonas int not null,
  TiempoEnsamble float not null,
  UnidadesPorHora int  not null,
  CantUnidadesFabricadas int not null,
  modulo int not null,
  NoConformes int not null
  primary key(codigo));

  truncate table tblControlPiso
  drop table tblControlPiso

  set dateformat 'dmy';


  insert into tblControlPiso values 
    ('O072F526','4265852','2022/11/10',' 06:30','325','8','14.611','33','0','103','0'),
  ('O072F526','4265852','2022/11/10',' 07:30','292','8','14.611','33','33','103','0'),
  ('O072F526','4265852','2022/11/10',' 08:30','259','8','14.611','33','33','103','0'),
  ('O072F526','4265852','2022/11/10','09:30','226','8','14.611','33','33','103','0'),
   ('O072F526','4265852','2022/11/10','10:30','193','8','14.611','33','33','103','0'),
  ('O072F526','4265852','2022/11/10','11:30','160','8','14.611','33','33','103','0'),
  ('O072F526','4265852','2022/11/10','12:30','127','8','14.611','33','33','103','0'),
   ('O072F526','4265852','2022/11/10','13:30','94','8','14.611','33','33','103','0'),
  ('O072F526','4265852','2022/11/10','14:30','61','8','14.611','33','33','103','0'),
  ('O072F526','4265852','2022/11/10','15:30','28','8','14.611','33','28','103','0'),
  ('O072F526','4265852','2022/11/10','16:30','0','8','14.611','33','28','103','0')

  select sum (UnidadesAFabricar) from tblControlPiso

    select * from tblControlPiso


	create procedure sp_IngresoInformacion  

  @Referencia as varchar (30),
  @OrdenProduccion as varchar (30),
  @fecha as date,
  @hora as time,
  @UnidadesAFabricar as int,
  @Cantpersonas as int,
  @TiempoEnsamble as  float,
  @UnidadesPorHora as int,
  @CantUnidadesFabricadas as int,
  @Modulo as int,
  @NoConformes as int
  as 
  begin
  insert into tblControlPiso
 values
(@Referencia,@OrdenProduccion, @fecha,@hora,@UnidadesAFabricar, @Cantpersonas,@TiempoEnsamble,@UnidadesPorHora,
  @CantUnidadesFabricadas,@modulo,@NoConformes)

  END
GO
	
	exec sp_IngresoInformacion 'O072F526','4265852','2022/11/10',' 07:30','292','8','14.61','33','33','103','0'

	select * from tblControlPiso 



---------------------------------------------------------------------------------------------------------------------------------------

create procedure sp_ListarDatosControlPiso

 as 
  begin
  select * from tblControlPiso 

  end 
  go

  exec sp_ListarDatosControlPiso
  ---------------------------------------------------------------------------------------------

  
	create procedure sp_listarproductos  

  @Referencia as varchar (30),
  @OrdenProduccion as varchar (30),
  @fecha as date,
  @hora as time,
  @UnidadesAFabricar as int,
  @Cantpersonas as int,
  @TiempoEnsamble as  float,
  @UnidadesPorHora as int,
  @CantUnidadesFabricadas as int,
  @Modulo as int,
  @NoConformes as int
  as 
  begin
  select 