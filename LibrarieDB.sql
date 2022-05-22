-- Se conecteaza la baza de date master pentru a executa instructiunile de mai jos.
USE master
GO

-- use master; alter database Librarius set single_user with rollback immediate; drop database Librarius

-- Se creeaza o noua baza de date cu numele de 'Librarie_Darii_Dumitru'.
IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = 'Librarius'
)
CREATE DATABASE Librarius
GO

-- Se conecteaza la baza de date 'Librarie_Darii_Dumitru' pentru a o putea modifica.
USE Librarius
GO

-- Tema: Evidenta cartilor librariei Librarius

-- Crearea tabelelor bazei de date

/* Tabelul Edituri contine editurile care editeaza cartile.
 * Descrierea colonelor:
 * id - id-ul editurii
 * denumire - denumirea editurii
 */


CREATE TABLE Edituri
(
    id INTEGER IDENTITY,
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
    id INTEGER IDENTITY,
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
	imagePath NVARCHAR(250) NOT NULL,
	link NVARCHAR(300) NOT NULL,
    PRIMARY KEY(id)
);

/* Tabelul Autori contine autorii cartilor.
 * Descrierea colonelor:
 * id - id-ul autorului
 * nume - numele autorului
 * prenume - prenumele autorului
 */

CREATE TABLE Autori
(
    id INTEGER IDENTITY,
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

CREATE TABLE Users 
(
	id INT IDENTITY,
	nume NVARCHAR(100) UNIQUE not null,
	parola NVARCHAR(50) not null,
	rol NVARCHAR(20) check (rol = 'Client' or rol = 'Manager') not null,
	PRIMARY KEY(id)
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
( denumire)
VALUES
 (N'Curtea Veche')
,(N'Europress')
,(N'Vremea')
,(N'Trei')
,(N'All')
,(N'Эксмо')
,(N'Flamingo')
,(N'Teora')
,(N'Niculescu')
,(N'Картография')
,(N'Steaua Nordului')
,(N'Poligraf-Design');

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
(denumire, pret, idEditura, anPublicare, nrPagini, idStareStoc, reducere, idTip, idGen, isbn, imagePath, link)
VALUES
 (N'Kathie si hipopotamul',132.0000,1,2010,264,1,NULL,1,1,'9786065880702', 'images\kathie-si-hipopotamul.jpg', 'https://librarius.md/ro/book/000744-kathie-si-hipopotamul')
,(N'Drumul spre Biserica',60.0000,2,2013,312,1,NULL,1,2,'9789975444606', 'images\drumul-spre-biserica.jpg', 'https://librarius.md/ro/book/drumul-spre-biserica-348165')
,(N'Venus ia foc Marte e de gheata',235.0000,3,2013,232,2,NULL,1,3,'9789736455575', 'images\venus-ia-foc.jpg', 'https://librarius.md/ro/book/venus-ia-foc-marte-e-de-ghiata-326823')
,(N'Cu ochii mintii',170.0000,4,2016,216,1,30,1,3,'9786067198157', 'images\cu-ochii-mintii.jpg', 'https://librarius.md/ro/book/cu-ochii-intii-474355')
,(N'In apararea pietelor',185.0000,1,2012,416,3,NULL,1,4,'9786065883239', 'images\in-apararea-pietelor.jpg', 'https://librarius.md/ro/book/000260-in-apararea-pietelor')
,(N'Cele 12 elemente ale managementului performant',155.0000,5,2009,272,3,NULL,1,5,'9789737241887', 'images\12-elemente-management.jpg', 'https://librarius.md/ro/book/007339-cele-12-elemente-ale-managementului-performant')
,(N'Adobe InDesign CC. Официальный учебный курс (+ CD-ROM)',740.0000,6,2014,496,1,NULL,1,6,'9785699696598', 'images\adobe-indesign.jpg', 'https://librarius.md/ro/book/006182-adobe-indesign-cc-oficialinyy-uchebnyy-kurs-cd')
,(N'Щенок Элфи или Не хочу быть один!',65.0000,6,2014,144,3,NULL,2,7,'9785699711932', 'images\shenok-elfi.jpg', 'https://librarius.md/ro/book/018514-schenok-elfi-ili-ne-hochu-byti-odin')
,(N'Povesti in romana si germana',174.0000,7,2010,104,2,70,2,8,'9789738873308', 'images\povesti-ro-germ.jpg', 'https://librarius.md/ro/book/001372-povesti-in-romana-si-germana')
,(N'Dictionar roman-englez',450.0000,8,NULL,NULL,2,NULL,2,9,'9789736019999', 'images\dictionar-ro-en.jpg', 'https://librarius.md/ro/book/dictionar-roman-englez-496328')
,(N'Dictionar Oxford de istorie universala contemporana (2 vol.)',395.0000,5,2007,504,1,NULL,1,10,'9789735715519', 'images\dictionar-oxford.jpg', 'https://librarius.md/ro/book/007666-dictionar-oxford-de-istorie-universala-contemporana-2-vol')
,(N'Harta Bulgaria',106.0000,9,2006,2,2,NULL,1,11,'9789737480804', 'images\harta-bulgaria.jpg', 'https://librarius.md/ro/book/007787-harta-bulgaria')
,(N'Политическая карта мира 1:35000000',135.0000,10,2011,NULL,2,NULL,1,11,'9789669460608', 'images\harta-politica-lume.jpg', 'https://librarius.md/ro/book/politicheskaya-karta-mira-135000000-130527')
,(N'Ghid de conversatie roman–german',60.0000,11,NULL,NULL,2,NULL,1,12,'9786065114685', 'images\ghid-convers-ro-germ.jpg', 'https://librarius.md/ro/book/007688-ghid-de-conversatie-roman-german')
,(N'Abecedar 6-7 ani',45.0000,12,2014,NULL,2,NULL,1,13,'9789975140379', 'images\abecedar-6-7.jpg', 'https://librarius.md/ro/book/abecedar-6-7-ani-ed-2014-poligraf-design-372486');

INSERT INTO Autori
(nume, prenume)
VALUES
 (N'Vargas Llosa',N'Mario')
,(N'Dabija',N'Nicolae')
,(N'Gray',N'John')
,(N'Dashner',N'James')
,(N'James',N'Lucian')
,(N'Wagner',N'R.')
,(N'Круз',N'Дж.')
,(N'Вебб',N'Х.')
,(N'Sojka',N'Anna')
,(N'Levitchi',N'Leon')
,(N'Palmowski',N'J.')
,(N'Huber',N'Niculescu')
,(N'Puscasiu',N'O.')
,(N'Jelescu',N'P.');

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

INSERT INTO Users
(nume, parola, rol)
VALUES
 ('admin', '123', 'Manager')
,('user', '123', 'Client');

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
		CONCAT(a.nume,' ', a.prenume) as "Autor", c.imagePath as "ImagePath", c.link as "Link"
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

go

create procedure sp_insertCategorieGen
	@id int,
	@denumire NVARCHAR(40)
as
INSERT INTO CategoriiGenuri
	(id, denumire)
VALUES
	(@id, @denumire)


GO
create procedure sp_insertGen
	@id int,
	@denumire NVARCHAR(60),
	@idCategorieGen int
as
INSERT INTO Genuri
	(id, denumire, idCategorieGen)
VALUES
	(@id, @denumire, @idCategorieGen)


	
go
create procedure sp_deleteBookFromCarteAutor
	@bookName NVARCHAR(100)
as
	delete from CarteAutor where idCarte = (select id from Carti where denumire like @bookName);

GO
create procedure sp_removeBook
	@denumireCarte NVARCHAR(90)
as
begin
	exec sp_deleteBookFromCarteAutor @denumireCarte
	delete from Carti where denumire like @denumireCarte;

end

GO
create procedure sp_addAuthor
	@lastName NVARCHAR(25),
	@firstName NVARCHAR(25)
as
	insert into Autori(nume, prenume) values (@lastName, @firstName);

GO
create procedure sp_addPublisher
	@name NVARCHAR(30)
as
	insert into Edituri(denumire) values (@name);

GO
create procedure sp_addBook
	@id int,
	@name nvarchar(90),
	@price smallmoney,
	@publisherId int,
	@publishingYear int,
	@pages int,
	@stockStateId int,
	@discount int,
	@typeId int,
	@genreId int,
	@isbn char(13),
	@authorId int
as
begin
	declare @imagePath nvarchar(30) = 'images\default.png'
	declare @link nvarchar(100) = 'https://librarius.md/ro/'

	if @discount = 0
		set @discount = null

	insert into Carti(denumire, pret, idEditura, anPublicare, nrPagini, idStareStoc, reducere, idTip, idGen, isbn, imagePath, link)
		values (@name, @price, @publisherId, @publishingYear, @pages, @stockStateId, @discount, @typeId, @genreId, @isbn, @imagePath, @link);
	insert into CarteAutor(idCarte, idAutor) values (@id, @authorId);

	return;
end

GO