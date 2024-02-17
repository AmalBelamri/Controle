
create database Produits
use Produits
create table F_P (id int primary key identity,nom varchar(30));
create table Pro (id int primary key identity ,Id_fa int , code varchar(30),Desi varchar(30)
,foreign key (Id_Fa) references F_P(id));

 