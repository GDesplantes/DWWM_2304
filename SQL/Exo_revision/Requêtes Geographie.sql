USE GEOGRAPHIE;

/*1/ Afficher le nom de tous les fleuves.*/
SELECT fleuve.nom_fleuve
FROM fleuve;

/*2/ Afficher le nom et la capitale de tous les pays dont le nom de la capitale commence par un “B”.*/
SELECT pays.capitale,pays.nom_pays
FROM pays
WHERE pays.capitale LIKE 'B%';

/*3/ Afficher le nom et la superficie de tous les pays ayant une superficie supérieure à 200 000 km².*/
SELECT pays.nom_pays, pays.superficieKm2
FROM pays
WHERE pays.superficieKm2 >200000;

/*4/ Afficher le nombre de pays de la table Pays.*/
SELECT COUNT(*) FROM pays;
/*5/ Afficher le nom et la superficie du pays le plus grand.*/

SELECT pays.nom_pays, pays.superficieKm2 FROM pays
WHERE pays.superficieKm2 =(SELECT MAX(pays.superficieKm2)FROM pays);
/*6/ Afficher le nom et la capitale de tous les pays d’Afrique (jointure) classés par ordre alphabétique.*/
SELECT pays.nom_pays,pays.capitale FROM 
pays JOIN continent ON pays.num_continent = continent.num_continent
WHERE continent.num_continent =1
ORDER BY pays.nom_pays ASC;

/*7/ Afficher le nom et la capitale de tous les pays d’Afrique (jointure) classés par superficie décroissante.*/
SELECT pays.nom_pays, pays.capitale,pays.superficieKm2 FROM pays JOIN continent ON pays.num_continent = continent.num_continent
WHERE continent.nom_continent ='Afrique'
ORDER BY pays.superficieKm2 DESC;

/*8/ Afficher la superficie totale de tous les pays d’Afrique (jointure).*/
SELECT  SUM(pays.superficieKm2) AS 'Superficie Total Afrique' FROM pays JOIN continent ON pays.num_continent = continent.num_continent
WHERE continent.num_continent=1;

/*9/ Afficher les noms des continents et leur superficie totale pour chaque continent.*/
SELECT DISTINCT continent.nom_continent, SUM(pays.superficieKm2) AS 'Superficie totale' FROM pays JOIN continent ON pays.num_continent = continent.num_continent
GROUP BY continent.nom_continent;


/*10/ Afficher la superficie moyenne d’un pays (tout pays confondu).*/
SELECT pays.nom_pays,AVG(pays.superficieKm2) AS 'superficie moyenne par pays'
FROM pays
GROUP BY pays.nom_pays;

/*11/ Afficher pour chaque nom de pays, le nombre de fleuve qui le traverse.*/
SELECT pays.nom_pays, COUNT(traverser.num_fleuve) FROM pays JOIN traverser ON pays.num_pays = traverser.num_pays
GROUP BY pays.nom_pays

/*12/ Afficher le nom de tous les pays d’Amérique ayant une superficie inférieure à 10 000 000 km² classés par superficie croissante.*/
SELECT pays.nom_pays, pays.superficieKm2 FROM pays JOIN continent ON pays.num_continent = continent.num_continent
WHERE continent.num_continent=2 AND pays.superficieKm2 <10000000;

/*13/ Afficher le nom et la capitale des pays traversés par plus de 2 fleuves.*/
SELECT DISTINCT pays.nom_pays,pays.capitale,traverser.num_fleuve FROM pays JOIN traverser ON pays.num_pays = traverser.num_pays
WHERE traverser.num_fleuve>2;

/*14/ Afficher pour chaque nom de pays, tous les noms de pays frontaliers classés par ordre alpha.*/
