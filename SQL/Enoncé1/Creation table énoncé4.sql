USE exo03_enonce4;

DROP TABLE if EXISTS LIVRES;
DROP TABLE if EXISTS exemplaires;

CREATE TABLE if NOT EXISTS LIVRES
(
isbn VARCHAR(50)  PRIMARY KEY,
titre VARCHAR(50) NOT NULL
);

CREATE TABLE if NOT EXISTS exemplaires
(
num_exempl INT PRIMARY KEY AUTO_INCREMENT,
etat CHAR(1) NOT NULL , 
CONSTRAINT ck_etat  CHECK ( etat ='D' OR 'E' OR 'P'),
isbn VARCHAR(50) NOT NULL 
);

ALTER TABLE exemplaires 
ADD CONSTRAINT FOREIGN KEY (isbn) REFERENCES LIVRES(isbn);

ALTER TABLE EXEMPLAIRES
ALTER etat SET DEFAULT 'D';