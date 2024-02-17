create database SDS 
go
use SDS
create table FamilleProduit(ID_Famille int primary key, NomFamille varchar(50))
create table Produit(ID_Produit int primary key,ID_Famille int foreign key references FamilleProduit(ID_Famille ),Code varchar(50),designation varchar(50))


insert into FamilleProduit values(100,'savons')
insert into FamilleProduit values(150,'gel')
insert into Produit values(10,100,'150','1254k')
insert into Produit values(20,150,'150','1245h')
insert into Produit values(20,150,'150','1285h')

select*from Produit
select*from FamilleProduit