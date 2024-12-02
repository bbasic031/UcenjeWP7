use master;
go
drop database if exists edunovawp7;
go
create database edunovawp7;
go
use edunovawp7;
go


create table IspitniRok(
sifra int not null primary key identity(1,1),
predmet varchar(50) not null,
vrstaIspita varchar(20) not null,
datum datetime null,
pristupio bit not null,
);

create table pristupnici(
ispitniRok int not null references IspitniRok(sifra),
student varchar(50) not null,
brojBodova int not null,
ocjena int not null
);