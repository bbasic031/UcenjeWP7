USE master;
GO
DROP DATABASE IF exists knjizara;
GO
CREATE DATABASE knjizara COLLATE Croatian_CI_AS;
GO
use knjizara;
GO


CREATE TABLE knjiga (
    sifra INT PRIMARY KEY IDENTITY(1,1),
    naslov VARCHAR(255) NOT NULL,
    autor VARCHAR(255) NOT NULL,
    zanr VARCHAR(100) NOT NULL
);


CREATE TABLE kupac (
    sifra INT PRIMARY KEY IDENTITY(1,1),
    ime VARCHAR(100) NOT NULL,
    prezime VARCHAR(100) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    broj_telefona VARCHAR(20),
    adresa VARCHAR(255) NOT NULL
);


CREATE TABLE narudzba (
    sifra_narudzbe INT PRIMARY KEY IDENTITY(1,1),
    sifra_kupca INT NOT NULL,
    datum DATE NOT NULL,
    status VARCHAR(50) NOT NULL,
    FOREIGN KEY (sifra_kupca) REFERENCES kupac(sifra)
);


CREATE TABLE artikli_narudzbe (
    sifra_artikala INT PRIMARY KEY IDENTITY(1,1),
    sifra_narudzbe INT NOT NULL,
    sifra_knjige INT NOT NULL,
    kolicina INT NOT NULL,
    cijena DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (sifra_narudzbe) REFERENCES narudzba(sifra_narudzbe),
    FOREIGN KEY (sifra_knjige) REFERENCES knjiga(sifra)
);

INSERT INTO kupac (ime, prezime, email, adresa) VALUES 
('Ante', 'Janković', 'antejankovic86@gmail.com','Trg Ante Starčevića 12, Osijek'),
('Stojan', 'Carić', 'stojancaric8@gmail.com','Zagrebačka ulica 33, Osijek'),
('Željko', 'Lučan', 'lucko1987vk@gmail.com','Kralja Zvonimira 45, Osijek'),
('Petar', 'Gudelj', 'gudelj.petar2005@gmail.com','Dravska ulica 28, Osijek'),
('Krunoslav', 'Popić', 'kpopic@gmail.com','Fajtićeva 19, Osijek'),
('Jurica', 'Ognjenović', 'ognjenovicjurica0610@gmail.com','Frankopanska 7, Osijek'),
('Lea', 'Bartoš', 'talulea@gmail.com','Strossmayerova 11, Osijek'),
('Tomislav', 'Nađ', 'tomislav.nadj@gmail.com','Sjenjak 56, Osijek'),
('Martin', 'Galik', 'gale1508@gmail.com','Osječka ulica 34, Osijek'),
('Ivan', 'Mišić', 'ivanmisic983@gmail.com','Gajev trg 21, Osijek'),
('Mirjam', 'Koški', 'mir.jam975@gmail.com','Jugovićeva 18, Osijek'),
('Željko', 'Koški', 'zeljko.koski@gmail.com','Ulica Matije Gupca 25, Osijek'),
('Mirza', 'Delagić', 'mirzadelagic@gmail.com','Trg slobode 4, Osijek'),
('Bruno', 'Čačić', 'bruno.cacic@gmail.com','Trpimirova 11, Osijek'),
('David', 'Nađ', 'david08.nadj@gmail.com','Valpovačka ulica 9, Osijek'),
('Antonio', 'Macanga', 'macanga.antonio@gmail.com','Kolodvorska ulica 14, Osijek'),
('Nina', 'Zrno', 'ninaradakovic1234@icloud.com','Vukovarska 37, Osijek'),
('Marko', 'Berberović', 'marko.berberovic@skole.hr','Janka Patačića 5, Osijek'),
('Tomislav', 'Nebes', 'tomislav.nebes@gmail.com','Županijska ulica 13, Osijek'),
('Klara', 'Nađ', 'klara.nad@gmail.com','Hrvatskih branitelja 22, Osijek'),
('Maja', 'Šteler', 'maja5steler@gmail.com','J. J. Strossmayera 16, Osijek'),
('Milan', 'Drača', 'milan.draca@gmail.com','Kneza Branimira 30, Osijek'),
('Marin', 'Vranješ', 'marinvranjes123@gmail.com','Riječka ulica 3, Osijek'),
('Boris', 'Bukovec', 'botaosijek@gmail.com','Ružina 17, Osijek'),
('Luka', 'Jurak', 'jurakluka18@gmail.com','Svete Ane 8, Osijek'),
('Ivan', 'Strmečki', 'ivan.strmecki8@gmail.com','Antuna Mihanovića 20, Osijek'),
('Bruno', 'Bašić', 'brunobasic031@gmail.com','Županijska ulica 42, Osijek');
