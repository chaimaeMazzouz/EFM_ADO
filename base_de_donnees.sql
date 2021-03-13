Create database Gestion_Consultants
go 
use Gestion_Consultants
 create table Consultant(
 CIN varchar(20) Primary key,
 Nom_Prenom_Consultant varchar(20),
 ville varchar(20)
 )
 create table Organisme(
RefOrganisme varchar(10) Primary key,
 NomOrganisme varchar(40),
 pays varchar(20)
 )
  create table Mission(
Num_mission int identity(1,1) Primary key,
DateMission Date,
CIN varchar(20) foreign key references Consultant(CIN),
RefOrganisme varchar(10) foreign key references Organisme(RefOrganisme),
Descrp varchar(20)
 )

 insert into Consultant values('EE1223','Mazzouz chaimae','Marrakech')
 insert into Consultant values('EE2222','Alaoui Mohamed','Rabat')

 insert into Organisme values('A00A','Organisme1','Maroc')
 insert into Organisme values('B00B','Organisme2','US')


 insert into Mission values('12-12-2020','EE1223','B00B','Description1')
 insert into Mission values('12-01-2020','EE2222','A00A','Description1')

