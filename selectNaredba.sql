
use edunovawp7;

select * from smjerovi;

-- minimalna select naredba
select 1;

-- filtriranje kolona (između select i from)
-- * sve kolona
-- naziv kolone
-- konstanta
-- izraz
select *, naziv, 1 as iznos, getdate() as datum from smjerovi;

select naziv as predmet, getdate() as datumpocetka from smjerovi;

select sifra, naziv from smjerovi;

select ime, prezime from polaznici;

--  filtriranje redova
-- ide u where dio
-- operatori
-- uspoređivanja: =, !=, <, >, <=, >=
-- logički operatori: and, or not
-- ostali operatori: 
-- like (% za bilo koji znak)
-- between
-- in
select * from smjerovi 
where not (sifra=1 or sifra=4);

select * from polaznici
where prezime like '%an%';

select * from polaznici where sifra>=10 and sifra<=15;
select * from polaznici where sifra between 10 and 15;

select * from polaznici where sifra=10 or sifra=15 or sifra=1;
select * from polaznici where sifra in (10,15,1);


-- S najmanjom greškom ispišite sve polaznice
select * from polaznici where ime like '%a';

-- Postavite da 3 smjera se izvode od u različitim 
--mjesecima: siječanj, travanj, listopad

select * from smjerovi;

update smjerovi 
set izvodiseod='2024-10-02 18:30'
where sifra=4;

-- Izlistajte sve smjerovi koji počinju u prvoj polovina 2024 g.
select * from smjerovi
where izvodiseod between '2021-01-01' and '2024-06-30'



