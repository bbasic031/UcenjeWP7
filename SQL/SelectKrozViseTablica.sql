SELECT * FROM grupe;

SELECT b.naziv AS grupa, a.naziv AS smjer, b.predavac FROM smjerovi a INNER JOIN grupe b ON a.sifra = b.smjer;

SELECT a.naziv, b.naziv AS grupa, b.predavac FROM smjerovi a LEFT JOIN grupe b ON a.sifra = b.smjer;

SELECT b.naziv AS Grupa, a.naziv AS Smjer, d.ime AS Ime, d.prezime AS Prezime FROM smjerovi a LEFT JOIN grupe b ON a.sifra=b.smjer LEFT JOIN clanovi c ON b.sifra=c.grupa LEFT JOIN polaznici d ON c.polaznik=d.sifra;


USE knjiznica;

SELECT a.ime, a.prezime, b.naslov, c.naziv AS izdavac, d.naziv AS mjesto FROM autor a INNER JOIN katalog b ON a.sifra=b.autor INNER JOIN izdavac c ON c.sifra=b.izdavac INNER JOIN mjesto d ON d.sifra=b.mjesto


USE svastara;

SELECT c.redniBroj, a.dugiNaziv, b.cijena, b.kolicina, b.cijena * b.kolicina AS vrijednost FROM Artikli a INNER JOIN ArtikliNaPrimci b ON a.sifra=b.artikl INNER JOIN Primke c ON c.sifra=b.primka WHERE c.redniBroj='1/2008';

SELECT SUM(b.cijena * b.kolicina) AS vrijednost FROM Artikli a INNER JOIN ArtikliNaPrimci b ON a.sifra=b.artikl INNER JOIN Primke c ON c.sifra=b.primka WHERE c.redniBroj='1/2008';

SELECT TOP 1 d.naziv, c.redniBroj, SUM(b.cijena * b.kolicina) AS vrijednost FROM Artikli a INNER JOIN ArtikliNaPrimci b ON a.sifra=b.artikl INNER JOIN Primke c ON c.sifra=b.primka INNER JOIN Dobavljaci d ON c.dobavljac=d.sifra GROUP BY c.redniBroj, d.naziv HAVING SUM(b.cijena * b.kolicina)>13000000 ORDER BY 2 DESC;

SELECT COUNT(*) FROM Artikli;
SELECT DISTINCT artikl FROM ArtikliNaPrimci;

SELECT * FROM Artikli WHERE sifra NOT IN(SELECT DISTINCT artikl FROM ArtikliNaPrimci);