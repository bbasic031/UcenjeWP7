use master;
go
drop database if exists knjizara;
go
create database knjizara;
go
use knjizara;
go


CREATE TABLE knjiga (
    sifra INT PRIMARY KEY AUTO_INCREMENT,
    naslov VARCHAR(255) NOT NULL,
    autor VARCHAR(255) NOT NULL,
    zanr VARCHAR(100) NOT NULL
);


CREATE TABLE kupac (
    sifra INT PRIMARY KEY AUTO_INCREMENT,
    ime VARCHAR(100) NOT NULL,
    prezime VARCHAR(100) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    broj_telefona VARCHAR(20),
    adresa TEXT NOT NULL
);


CREATE TABLE narudzba (
    sifra_narudzbe INT PRIMARY KEY AUTO_INCREMENT,
    sifra_kupca INT NOT NULL,
    datum DATE NOT NULL,
    status VARCHAR(50) NOT NULL,
    FOREIGN KEY (sifra_kupca) REFERENCES kupac(sifra)
);


CREATE TABLE artikli_narudzbe (
    sifra_artikala INT PRIMARY KEY AUTO_INCREMENT,
    sifra_narudzbe INT NOT NULL,
    sifra_knjige INT NOT NULL,
    kolicina INT NOT NULL,
    cijena DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (sifra_narudzbe) REFERENCES narudzba(sifra_narudzbe),
    FOREIGN KEY (sifra_knjige) REFERENCES knjiga(sifra)
);
