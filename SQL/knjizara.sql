USE master;
GO
DROP DATABASE IF exists knjizara;
GO
CREATE DATABASE knjizara COLLATE Croatian_CI_AS;
GO
use knjizara;
GO


CREATE TABLE knjiga (
    sifra_knjige INT PRIMARY KEY IDENTITY(1,1),
    naslov VARCHAR(255) NOT NULL,
    autor VARCHAR(255) NOT NULL,
    zanr VARCHAR(100) NOT NULL
);


CREATE TABLE kupac (
    sifra_kupca INT PRIMARY KEY IDENTITY(1,1),
    ime VARCHAR(100) NOT NULL,
    prezime VARCHAR(100) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    broj_telefona VARCHAR(20),
    adresa VARCHAR(255) NOT NULL
);


CREATE TABLE narudzba (
    sifra_narudzbe INT PRIMARY KEY IDENTITY(1,1),
    datum DATE NOT NULL,
    status_narudzbe VARCHAR(50) NOT NULL,
    sifra_kupca INT REFERENCES kupac(sifra_kupca)
);


CREATE TABLE artikli_narudzbe (
    sifra INT PRIMARY KEY IDENTITY(1,1),
    kolicina INT NOT NULL,
    cijena DECIMAL(10, 2) NOT NULL,
    sifra_narudzbe INT REFERENCES narudzba(sifra_narudzbe),
    sifra_knjige INT REFERENCES knjiga(sifra_knjige)
);

INSERT INTO kupac (ime, prezime, email, adresa, broj_telefona) VALUES  
('Ante', 'Janković', 'antejankovic86@gmail.com', 'Trg Ante Starčevića 12, Osijek', '+385 91 234 5678'),
('Stojan', 'Carić', 'stojancaric8@gmail.com', 'Zagrebačka ulica 33, Osijek', '+385 91 345 6789'),
('Željko', 'Lučan', 'lucko1987vk@gmail.com', 'Kralja Zvonimira 45, Osijek', '+385 91 456 7890'),
('Petar', 'Gudelj', 'gudelj.petar2005@gmail.com', 'Dravska ulica 28, Osijek', '+385 91 567 8901'),
('Krunoslav', 'Popić', 'kpopic@gmail.com', 'Fajtićeva 19, Osijek', '+385 91 678 9012'),
('Jurica', 'Ognjenović', 'ognjenovicjurica0610@gmail.com', 'Frankopanska 7, Osijek', '+385 91 789 0123'),
('Lea', 'Bartoš', 'talulea@gmail.com', 'Strossmayerova 11, Osijek', '+385 91 890 1234'),
('Tomislav', 'Nađ', 'tomislav.nadj@gmail.com', 'Sjenjak 56, Osijek', '+385 91 901 2345'),
('Martin', 'Galik', 'gale1508@gmail.com', 'Osječka ulica 34, Osijek', '+385 91 012 3456'),
('Ivan', 'Mišić', 'ivanmisic983@gmail.com', 'Gajev trg 21, Osijek', '+385 91 123 4567'),
('Mirjam', 'Koški', 'mir.jam975@gmail.com', 'Jugovićeva 18, Osijek', '+385 91 234 5670'),
('Željko', 'Koški', 'zeljko.koski@gmail.com', 'Ulica Matije Gupca 25, Osijek', '+385 91 345 6781'),
('Mirza', 'Delagić', 'mirzadelagic@gmail.com', 'Trg slobode 4, Osijek', '+385 91 456 7892'),
('Bruno', 'Čačić', 'bruno.cacic@gmail.com', 'Trpimirova 11, Osijek', '+385 91 567 8903'),
('David', 'Nađ', 'david08.nadj@gmail.com', 'Valpovačka ulica 9, Osijek', '+385 91 678 9014'),
('Antonio', 'Macanga', 'macanga.antonio@gmail.com', 'Kolodvorska ulica 14, Osijek', '+385 91 789 0125'),
('Nina', 'Zrno', 'ninaradakovic1234@icloud.com', 'Vukovarska 37, Osijek', '+385 91 890 1236'),
('Marko', 'Berberović', 'marko.berberovic@skole.hr', 'Janka Patačića 5, Osijek', '+385 91 901 2347'),
('Tomislav', 'Nebes', 'tomislav.nebes@gmail.com', 'Županijska ulica 13, Osijek', '+385 91 012 3458'),
('Klara', 'Nađ', 'klara.nad@gmail.com', 'Hrvatskih branitelja 22, Osijek', '+385 91 123 4569'),
('Maja', 'Šteler', 'maja5steler@gmail.com', 'J. J. Strossmayera 16, Osijek', '+385 91 234 5671'),
('Milan', 'Drača', 'milan.draca@gmail.com', 'Kneza Branimira 30, Osijek', '+385 91 345 6782'),
('Marin', 'Vranješ', 'marinvranjes123@gmail.com', 'Riječka ulica 3, Osijek', '+385 91 456 7893'),
('Boris', 'Bukovec', 'botaosijek@gmail.com', 'Ružina 17, Osijek', '+385 91 567 8904'),
('Luka', 'Jurak', 'jurakluka18@gmail.com', 'Svete Ane 8, Osijek', '+385 91 678 9015'),
('Ivan', 'Strmečki', 'ivan.strmecki8@gmail.com', 'Antuna Mihanovića 20, Osijek', '+385 91 789 0126'),
('Bruno', 'Bašić', 'brunobasic031@gmail.com', 'Županijska ulica 42, Osijek', '+385 91 890 1237');

INSERT INTO knjiga (naslov, autor, zanr) VALUES
('To Kill a Mockingbird', 'Harper Lee', 'Fiction'),
('1984', 'George Orwell', 'Dystopian'),
('The Great Gatsby', 'F. Scott Fitzgerald', 'Classic'),
('The Catcher in the Rye', 'J.D. Salinger', 'Fiction'),
('Pride and Prejudice', 'Jane Austen', 'Romance'),
('The Lord of the Rings', 'J.R.R. Tolkien', 'Fantasy'),
('The Hobbit', 'J.R.R. Tolkien', 'Fantasy'),
('Harry Potter and the Sorcerers Stone', 'J.K. Rowling', 'Fantasy'),
('Moby-Dick', 'Herman Melville', 'Adventure'),
('War and Peace', 'Leo Tolstoy', 'Historical Fiction');

INSERT INTO narudzba (datum, status_narudzbe, sifra_kupca) VALUES
('2024-12-01', 'Procesuirana',9),
('2024-12-02', 'Poslana',2),
('2024-12-03', 'U čekanju',11),
('2024-12-04', 'Dostavljena',9),
('2024-12-05', 'Otkazana',26);


INSERT INTO artikli_narudzbe (kolicina, cijena, sifra_narudzbe, sifra_knjige) VALUES
-- 1
(2, 15.99, 1, 2), 
(1, 12.50, 1, 7), 
(3, 10.00, 1, 4),

-- 2
(1, 8.99, 2, 1),
(2, 14.99, 2, 6),
(1, 25.00, 2, 5),

-- 3
(1, 20.00, 3, 3),
(2, 22.50, 3, 8),
(3, 18.00, 3, 2),

-- 4
(1, 30.00, 4, 10),
(1, 15.99, 4, 1),
(2, 10.00, 4, 9),

-- 5
(1, 12.50, 5, 2),
(1, 14.99, 5, 5),
(2, 18.00, 5, 9);

SELECT * FROM artikli_narudzbe