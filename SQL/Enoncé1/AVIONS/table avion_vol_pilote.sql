USE avion_vol_pilote;

DROP TABLE if EXISTS avions;
DROP TABLE if EXISTS pilotes;
DROP TABLE if EXISTS vols;

CREATE TABLE if NOT EXISTS AVIONS
(
AV INT PRIMARY KEY AUTO_INCREMENT,
AVMARQ VARCHAR(50) NOT NULL,
AVTYPE VARCHAR(50) NOT NULL,
CAP INT NOT NULL,
LOC VARCHAR(50) 
);

ALTER TABLE AVIONS AUTO_INCREMENT=100;

CREATE TABLE if NOT EXISTS PILOTES
(
PIL INT PRIMARY KEY AUTO_INCREMENT,
PILNOM VARCHAR(30) NOT NULL,
ADR VARCHAR(100) NOT NULL
);

ALTER TABLE PILOTES AUTO_INCREMENT=1;

CREATE TABLE if NOT EXISTS VOLS

(
VOL VARCHAR(5) PRIMARY KEY,
AV INT NOT NULL,
PIL INT NOT NULL,
VD VARCHAR(30) NOT NULL,
VA VARCHAR(30) NOT NULL,
HD TIME NOT NULL,
HA TIME NOT NULL
);

ALTER TABLE VOLS
ADD CONSTRAINT fk_vol1 FOREIGN KEY (PIL) REFERENCES pilotes(PIL);
ALTER TABLE VOLS
ADD CONSTRAINT fk_vol_av FOREIGN KEY (AV) REFERENCES avions(AV);