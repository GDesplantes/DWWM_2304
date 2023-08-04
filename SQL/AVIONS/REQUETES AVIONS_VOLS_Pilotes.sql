USE avion_vol_pilote;

/*SELECT *
FROM vols
WHERE VD='Paris' AND HD="12:00:00" AND HA="14:00:00";*/

/*QUESTION 2
SELECT *
FROM pilotes
WHERE PILNOM LIKE'S%';*/

/*Q:3
SELECT LOC,CAP,AV
FROM avions;*/

Q4
/*SELECT LOC,AVG(CAP) AS 'capacite moyenne par marque',AVMARQ,COUNT(LOC) AS 'Nombre dappareil'
FROM avions
GROUP BY LOC,AVMARQ
ORDER BY LOC ASC;*/
 /*UPDATE avions SET AVMARQ = 'BOEING' WHERE AV=104;*/

/*Q5*/

SELECT AVG(CAP) AS 'capacite moyenne avions',LOC
FROM VOLSs
where

