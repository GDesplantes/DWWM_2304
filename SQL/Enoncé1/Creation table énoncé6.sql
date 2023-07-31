USE exo03_enonce6;

DROP TABLE if EXISTS rayons;
DROP TABLE if EXISTS fournisseurs;
DROP TABLE if EXISTS articles;
DROP TABLE if EXISTS livraisons;
DROP TABLE if EXISTS employes;

CREATE TABLE if NOT EXISTS rayons
(
nom_R VARCHAR(25) PRIMARY KEY,
etage INT 
);

CREATE TABLE if NOT EXISTS fournisseurs
(
code_F INT  PRIMARY KEY ,
adresse VARCHAR(120),
nom_F  VARCHAR(20)
);

CREATE TABLE if NOT EXISTS articles
(
code_A INT PRIMARY KEY ,
nom_A VARCHAR(50),
type_A VARCHAR(50),
nom_R VARCHAR(25) 
);

CREATE TABLE if NOT EXISTS livraisons
(
code_F INT  ,
code_A INT ,
quantite INT 
);

CREATE TABLE if NOT EXISTS employes
(
code_E INT AUTO_INCREMENT PRIMARY KEY,
nom VARCHAR(50),
salaire DOUBLE(10,2),
code_E_encadrant INT, 
nom_R VARCHAR(25)
);

ALTER TABLE articles
ADD CONSTRAINT Fk_rayon FOREIGN KEY (nom_R) REFERENCES rayons (nom_R);
ALTER TABLE articles
MODIFY COLUMN nom_R VARCHAR(25) NOT NULL 

ALTER TABLE livraisons
ADD CONSTRAINT fk_fournisseur FOREIGN KEY (code_F) REFERENCES fournisseurs (code_F),
ADD CONSTRAINT fk_article FOREIGN KEY (code_A) REFERENCES articles (code_A),
ADD CONSTRAINT pk_livraison PRIMARY KEY (code_A,code_F);

ALTER TABLE EMPLOYES
ADD CONSTRAINT FOREIGN KEY (code_E_encadrant) REFERENCES EMPLOYES (code_E);
ALTER TABLE EMPLOYES
ADD CONSTRAINT FOREIGN KEY (nom_R) REFERENCES rayons (nom_R);

CREATE INDEX nom_emp ON  employes (nom);
CREATE INDEX type_A ON articles (type_A);