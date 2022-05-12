-- Se conecteaza la baza de date master pentru a executa instructiunile de mai jos.
USE master
GO

-- alter database LibrariusDB set single_user with rollback immediate

-- drop database LibrariusDB

-- Se creeaza o noua baza de date cu numele de 'Librarie_Darii_Dumitru'.
IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = 'Librarius'
)
CREATE DATABASE Librarius
GO

-- drop database Librarius
-- exec sp_who

-- Se conecteaza la baza de date 'Librarie_Darii_Dumitru' pentru a o putea modifica.
USE Librarius
GO

-- Tema: Evidenta cartilor librariei Librarius

-- use master
-- drop database Librarie_Darii_Dumitru

-- Crearea tabelelor bazei de date

/* Tabelul Edituri contine editurile care editeaza cartile.
 * Descrierea colonelor:
 * id - id-ul editurii
 * denumire - denumirea editurii
 */


CREATE TABLE Edituri
(
    id INTEGER,
    denumire NVARCHAR(30) UNIQUE NOT NULL,
    PRIMARY KEY(id)
);

/* Tabelul CategoriiGenuri contine categoriile de genuri specifice cartilor.
 * Descrierea colonelor:
 * id - id-ul categoriei
 * denumire - denumirea categoriei de gen de carte
 */

CREATE TABLE CategoriiGenuri
(
    id INTEGER,
    denumire VARCHAR(40) UNIQUE NOT NULL,
    PRIMARY KEY(id)
);

/* Tabelul Genuri contine genurile din care fac parte cartile.
 * Descrierea colonelor:
 * id - id-ul genului
 * denumire - denumirea genului
 * idCategorieGen - id-ul categoriei din care face parte genul
 */

CREATE TABLE Genuri
(
    id INTEGER,
    denumire VARCHAR(60) NOT NULL,
    idCategorieGen INTEGER NOT NULL,
    PRIMARY KEY(id),
);

/* Tabelul TipuriCarti contine tipurile care pot fi atribuite cartilor. 
 * Descrierea colonelor:
 * id - id-ul tipului de carte
 * denumire - denumirea tipului de carte
 */

CREATE TABLE TipuriCarti
(
    id INTEGER,
    denumire VARCHAR(20) NOT NULL,
    PRIMARY KEY(id)
);

/* Tabelul StariStoc contine starile in care poate fi stocul unei anumite carti.
 * Descrierea colonelor:
 * id - id-ul starii de stoc a cartii
 * denumire - denumirea starii de stoc a cartii
 */

CREATE TABLE StariStoc
(
    id INTEGER,
    denumire VARCHAR(25) UNIQUE NOT NULL,
    PRIMARY KEY(id)
);



/* Tabelul Carti contine cartile si informatia legata de ele.
 * Descrierea colonelor:
 * id - id-ul cartii
 * denumire - denumirea cartii
 * anPublicare - anul cand a fost publicata cartea
 * nrPagini - numarul de pagini ale cartii
 * pret - pretul cartii
 * idEditura - id-ul editurii cartii
 * idGen - id-ul genului din care face parte cartea
 * isbn - International Standard Book Number din 13 cifre, atribuit cartii
 */

CREATE TABLE Carti
(
    id INTEGER,
    denumire NVARCHAR(90) NOT NULL,
    pret SMALLMONEY NOT NULL,
    idEditura INTEGER NOT NULL,
    anPublicare INTEGER,
    nrPagini INTEGER,
    idStareStoc INTEGER NOT NULL,
    reducere INTEGER CHECK((reducere > 0) AND (reducere < 100)),
    idTip INTEGER,
    idGen INTEGER,
    isbn CHAR(13) NOT NULL,
    PRIMARY KEY(id),
);

/* Tabelul Autori contine autorii cartilor.
 * Descrierea colonelor:
 * id - id-ul autorului
 * nume - numele autorului
 * prenume - prenumele autorului
 */

CREATE TABLE Autori
(
    id INTEGER,
    nume NVARCHAR(25) NOT NULL,
    prenume NVARCHAR(25) NOT NULL,
    PRIMARY KEY(id)
);

/* Tabelul CarteAutor contine perechile de autori si carti.
 * Descrierea colonelor:
 * idCarte - id-ul cartii din tabelul Carti
 * idAutor - id-ul autorului din tabelul Autori
 */

CREATE TABLE CarteAutor
(
    idCarte INTEGER NOT NULL,
    idAutor INTEGER NOT NULL,
);
GO

-- Crearea legaturilor dintre tabele

-- Genuri
ALTER TABLE Genuri
ADD CONSTRAINT FK_Gen_CategorieGen
FOREIGN KEY(idCategorieGen) REFERENCES CategoriiGenuri(id);

-- Carti
ALTER TABLE Carti
ADD CONSTRAINT FK_Carte_Editura
FOREIGN KEY(idEditura) REFERENCES Edituri(id);

ALTER TABLE Carti
ADD CONSTRAINT FK_Carte_Gen
FOREIGN KEY(idGen) REFERENCES Genuri(id);

ALTER TABLE Carti
ADD CONSTRAINT FK_Carte_TipCarte
FOREIGN KEY(idTip) REFERENCES TipuriCarti(id);

ALTER TABLE Carti
ADD CONSTRAINT FK_Carte_StareStoc
FOREIGN KEY(idStareStoc) REFERENCES StariStoc(id);

-- CarteAutor
ALTER TABLE CarteAutor
ADD CONSTRAINT FK_CarteAutor_Carte
FOREIGN KEY(idCarte) REFERENCES Carti(id);

ALTER TABLE CarteAutor
ADD CONSTRAINT FK_CarteAutor_Autor
FOREIGN KEY(idAutor) REFERENCES Autori(id);

GO

-- Introducerea datelor in tabele

INSERT INTO Edituri
(id, denumire)
VALUES
 (1,N'Curtea Veche')
,(2,N'Europress')
,(3,N'Vremea')
,(4,N'Trei')
,(5,N'All')
,(6,N'Эксмо')
,(7,N'Flamingo')
,(8,N'Teora')
,(9,N'Niculescu')
,(10,N'Картография')
,(11,N'Steaua Nordului')
,(12,N'Poligraf-Design');

INSERT INTO StariStoc
(id, denumire)
VALUES
 (1,'Ultima carte')
,(2,'Stoc suficient')
,(3,'Stoc limitat')
,(4,'Stoc epuizat');

INSERT INTO TipuriCarti 
(id, denumire)
VALUES
 (1, 'Brosata')
,(2, 'Cartonata');

INSERT INTO CategoriiGenuri
(id, denumire)
VALUES
 (1,'Beletristica')
,(2,'Carte practica,specialitate')
,(3,'Carti pentru copii')
,(4,'Dictionare')
,(5,'Harti Atlase Calendare Agende')
,(6,'Limbi straine')
,(7,'Manuale si auxiliare scolare');

INSERT INTO Genuri
(id, denumire, idCategorieGen)
VALUES
 (1,'Proza , Dramaturgie',1)
,(2,'Roman',1)
,(3,'Fictiune,mistica,fantazy',1)
,(4,'Economie',2)
,(5,'Management',2)
,(6,'Computer,internet',2)
,(7,'Literatura pentru copii 7+',3)
,(8,'Poezii,povesti,povestiri',3)
,(9,'Limba engleza',4)
,(10,'Specialitate',4)
,(11,'Harti',5)
,(12,'Limba germana',6)
,(13,'Gradinita',7);

INSERT INTO Carti
(id, denumire, pret, idEditura, anPublicare, nrPagini, idStareStoc, reducere, idTip, idGen, isbn)
VALUES
 (1,N'Kathie si hipopotamul',132.0000,1,2010,264,1,NULL,1,1,'9786065880702')
,(2,N'Drumul spre Biserica',60.0000,2,2013,312,1,NULL,1,2,'9789975444606')
,(3,N'Venus ia foc Marte e de gheata',235.0000,3,2013,232,2,NULL,1,3,'9789736455575')
,(4,N'Cu ochii mintii',170.0000,4,2016,216,1,30,1,3,'9786067198157')
,(5,N'In apararea pietelor',185.0000,1,2012,416,3,NULL,1,4,'9786065883239')
,(6,N'Cele 12 elemente ale managementului performant',155.0000,5,2009,272,3,NULL,1,5,'9789737241887')
,(7,N'Adobe InDesign CC. Официальный учебный курс (+ CD-ROM)',740.0000,6,2014,496,1,NULL,1,6,'9785699696598')
,(8,N'Щенок Элфи или Не хочу быть один!',65.0000,6,2014,144,3,NULL,2,7,'9785699711932')
,(9,N'Povesti in romana si germana',174.0000,7,2010,104,2,70,2,8,'9789738873308')
,(10,N'Dictionar roman-englez',450.0000,8,NULL,NULL,2,NULL,2,9,'9789736019999')
,(11,N'Dictionar Oxford de istorie universala contemporana (2 vol.)',395.0000,5,2007,504,1,NULL,1,10,'9789735715519')
,(12,N'Harta Bulgaria',106.0000,9,2006,2,2,NULL,1,11,'9789737480804')
,(13,N'Политическая карта мира 1:35000000',135.0000,10,2011,NULL,2,NULL,1,11,'9789669460608')
,(14,N'Ghid de conversatie roman–german',60.0000,11,NULL,NULL,2,NULL,1,12,'9786065114685')
,(15,N'Abecedar 6-7 ani',45.0000,12,2014,NULL,2,NULL,1,13,'9789975140379');

INSERT INTO Autori
(id, nume, prenume)
VALUES
 (1,N'Vargas Llosa',N'Mario')
,(2,N'Dabija',N'Nicolae')
,(3,N'Gray',N'John')
,(4,N'Dashner',N'James')
,(5,N'James',N'Lucian')
,(6,N'Wagner',N'R.')
,(7,N'Круз',N'Дж.')
,(8,N'Вебб',N'Х.')
,(9,N'Sojka',N'Anna')
,(10,N'Levitchi',N'Leon')
,(11,N'Palmowski',N'J.')
,(12,N'Huber',N'Niculescu')
,(13,N'Puscasiu',N'O.')
,(14,N'Jelescu',N'P.');

INSERT INTO CarteAutor
(idCarte,idAutor)
VALUES
 (1,1)
,(2,2)
,(3,3)
,(4,4)
,(5,5)
,(6,6)
,(7,7)
,(8,8)
,(9,9)
,(10,10)
,(11,11)
,(12,12)
,(14,13)
,(15,14);


GO


SELECT * FROM Edituri;

SELECT * FROM Autori;


GO
-- Vedere care contine categoriile si genurile corespunzatoare.
CREATE VIEW vCategorieGen_Gen
AS
SELECT c.denumire AS Categorie, g.denumire AS Gen
FROM Genuri g
JOIN CategoriiGenuri c ON (g.id = c.id);

GO
-- Vedere care contine informatia generala despre fiecare carte
CREATE VIEW vCartiInfo
AS
    SELECT c.denumire AS "Cartea", c.pret AS "Pretul cartii", e.denumire AS "Editura",
        c.anPublicare AS "Anul publicarii", nrPagini,
        ss.denumire AS "Starea stocului", c.reducere, t.denumire AS "Tipul", Genuri.denumire AS "Gen", c.isbn,
		CONCAT(a.nume,' ', a.prenume) as "Autor"
    FROM Carti c
        INNER JOIN Edituri e ON (e.id = c.idEditura)
        INNER JOIN StariStoc ss ON (ss.id = c.idStareStoc)
        INNER JOIN TipuriCarti t ON (t.id = c.idTip)
        INNER JOIN Genuri ON (Genuri.id = c.idGen)
		LEFT JOIN CarteAutor ca ON (ca.idCarte = c.id)
		LEFT JOIN Autori a ON (a.id = ca.idAutor);

GO

-- Vedere care contine Genurile si Categoriile combinate impreuna.
CREATE VIEW vGenuriUnionCategoriiGenuri
AS
    SELECT Genuri.denumire
    FROM Genuri
        UNION ALL
        SELECT CategoriiGenuri.denumire
        FROM CategoriiGenuri;

GO

GO

-- Afisarea datelor din vederi

SELECT *
FROM vCategorieGen_Gen;

SELECT * 
FROM vCartiInfo;

SELECT *
FROM vGenuriUnionCategoriiGenuri;


-- Interogari

-- Cartile si autorii
SELECT c.denumire "carte", a.nume "nume autor", a.prenume "prenume autor"
FROM CarteAutor ca
    INNER JOIN Carti c ON (c.id = ca.idCarte)
    INNER JOIN Autori a ON (a.id = ca.idAutor)
ORDER BY c.denumire;

-- Cartile cu reducere
SELECT c.denumire "carte", c.reducere "reducere"
FROM Carti c
WHERE c.reducere IS NOT NULL;

-- Cartile care au stocul epuizat
SELECT c.denumire "carte", ss.denumire "stare stoc"
FROM Carti c
    INNER JOIN StariStoc ss ON (c.idStareStoc = ss.id)
WHERE ss.denumire LIKE 'stoc epuizat';

-- Cartile care au stocul suficient
SELECT c.denumire "carte", ss.denumire "stare stoc"
FROM Carti c
    INNER JOIN StariStoc ss ON (c.idStareStoc = ss.id)
WHERE ss.denumire LIKE 'stoc suficient';

-- Cartile de tip cartonate
SELECT c.denumire "carte", tc.denumire "tip"
FROM Carti c
    INNER JOIN TipuriCarti tc ON (c.idTip = tc.id)
WHERE tc.denumire LIKE 'cartonata';

-- Cartile publicate de editura "vremea"
SELECT c.denumire "carte", e.denumire "editura"
FROM Carti c
    INNER JOIN Edituri e ON (c.idEditura = e.id)
WHERE e.denumire LIKE 'vremea';

-- Cartile scrise de "Dabija Nicolae"
SELECT c.denumire "carte", a.nume "nume autor", a.prenume "prenume autor"
FROM CarteAutor ca
    INNER JOIN Autori a ON (ca.idAutor = a.id)
    INNER JOIN Carti c ON (ca.idCarte = c.id)
WHERE a.nume LIKE 'Dabija' AND a.prenume LIKE 'Nicolae';

-- Informatille despre cartile ce au mai putin de 200 de pagini
SELECT *
FROM vCartiInfo
WHERE nrPagini < 200;

-- Genurile din categoria Dictionare
SELECT *
FROM vCategorieGen_Gen
WHERE Categorie LIKE 'dictionare';

-- Cartile ce au fost publicate in 2005 si dupa
SELECT c.denumire "carte", c.anPublicare
FROM Carti c
WHERE c.anPublicare >= 2005
ORDER BY c.anPublicare;

-- Darii Dumitru, BD: Librarie_Darii_Dumitru
-- am utilizat len pentru calcularea lungimii denumirii cartilor
-- am utilizat concat pentru a concatena intr-un singur camp denumirea cartii si numele, si prenumele autorului
select len(Carti.denumire) as [Lungimea denumirii cartii],
    concat('Cartea: ', Carti.denumire, ' | Autorul: ', Autori.nume, ' ', Autori.prenume) as [Cartea si autorul]
from CarteAutor
    inner join Autori on (Autori.id = CarteAutor.idAutor)
    inner join Carti on (Carti.id = CarteAutor.idCarte)
order by [Lungimea denumirii cartii];


-- Proceduri

GO

create procedure spCartiAutoriInBazaEditurii
    @editura nvarchar = N'vremea'
AS
SELECT c.denumire "carte", a.nume "nume autor", a.prenume "prenume autor"
FROM CarteAutor ca
    INNER JOIN Carti c ON (c.id = ca.idCarte)
    INNER JOIN Autori a ON (a.id = ca.idAutor)
    INNER JOIN Edituri e ON (e.id = c.idEditura)
    WHERE e.denumire like @editura
GO


execute spCartiAutoriInBazaEditurii


go
/*BD: Librarie_Darii_Dumitru*/
/*Insereaza o noua carte in tabelul carti*/
create procedure sp_insertCarte
    @idCarte int,
    @denumireCarte NVARCHAR(90),
    @pretCarte SMALLMONEY,
    @idEdituraCarte int,
    @anPublicareCarte int,
    @nrPaginiCarte int,
    @idStareStocCarte int,
    @reducereCarte int,
    @idTipCarte int,
    @idGenCarte int,
    @isbnCarte char(13)
as
INSERT INTO Carti
    (id, denumire, pret, idEditura, anPublicare, nrPagini, idStareStoc, reducere, idTip, idGen, isbn)
VALUES
    (@idCarte, @denumireCarte, @pretCarte, @idEdituraCarte, @anPublicareCarte, @nrPaginiCarte,
     @idStareStocCarte, @reducereCarte, @idTipCarte, @idGenCarte, @isbnCarte)

-- exec sp_insertCarte 50, 'newBook', 200, 1, 2007, 100, 1, 50, 2, 1, '1234567890123'