use master;
go
drop database if exists vjezba1;
go
create database vjezba1 collate Croatian_CI_AS;
go
use vjezba1;
go

create table IspitniRok(
sifra int NOT NULL primary key identity(1,1), -- ovo je primarni ključ
predmet varchar(50) NOT NULL,
vrstaIspita varchar(50) NOT NULL,
datum datetime,
pristupio int NOT NULL
);

create table Pristupnici(
ispitniRok int not null REFERENCES IspitniRok(sifra),
student int not null,
brojbodova int not null,
ocjena int not null
);

SELECT * from IspitniRok

INSERT INTO IspitniRok(predmet,vrstaIspita,pristupio) VALUES
('Programiranje','Pismeni',23),
('Baze podataka','Usmeni',17);

DELETE FROM IspitniRok