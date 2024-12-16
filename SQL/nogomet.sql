use master;
go
drop database if exists nogomet;
go
create database nogomet;
go
use nogomet;
go


create table klub(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
osnovan datetime null,
stadion varchar(50) not null,
predsjednik varchar(50) null,
drzava varchar(50) not null,
liga varchar(50) not null,
);

create table utakmica(
sifra int not null primary key identity(1,1),
datum date not null,
vrijeme time not null,
lokacija varchar(50) null,
stadion varchar(50) not null,
domaci_klub int not null references klub(sifra),
gostujuci_klub int not null references klub(sifra)
);

create table igrac(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
datumRodenja datetime not null,
pozicija varchar(20) not null,
broj_dresa int not null,
klub int not null references klub(sifra)
);

create table trener(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
klub int not null references klub(sifra),
nacionalnost varchar(50) not null,
iskustvo varchar(50) not null
);

