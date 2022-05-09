select g.denumire as [Gen] from Genuri g
where idCategorieGen in (select id from CategoriiGenuri where CategoriiGenuri.denumire like 'beletristica1');

select denumire from CategoriiGenuri;

select * from Genuri g
inner join CategoriiGenuri cg on (g.idCategorieGen = cg.id)
where cg.denumire = 'dictionare';

select g.denumire as [Gen] from Genuri g where idCategorieGen = (select id from CategoriiGenuri where CategoriiGenuri.denumire like 'beletristica')

select denumire as [Carte] from carti
where idGen = (select id from Genuri where denumire like '');

select c.denumire, g.denumire from Carti c
inner join Genuri g on (c.idGen = g.id);

select * from vCartiInfo;
