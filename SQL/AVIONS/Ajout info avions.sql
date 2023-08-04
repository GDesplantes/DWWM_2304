USE avion_vol_pilote;
INSERT INTO avions (AV, AVMARQ, AVTYPE,CAP,LOC)
VALUES 
(AV,'AIRBUS','A320',300,'NICE'),
(AV,'BOEING','B707',250,'PARIS'),
(AV,'AIRBUS','A320', 300,'Toulouse'),
(AV,'CARAVELLE','Caravelle',200,'Toulouse'),
(AV,'BOING','B747',400,'Paris'),
(AV,'AIRBUS','A320',300,'Grenoble'),
(AV,'ATR','ATR42',50,'Paris'),
(AV,'BOEING','B727',300,'Lyon'),
(AV,'BOEING','B727',300,'Nantes'),
(AV,'AIRBUS','A340',350,'Bastia');

INSERT INTO pilotes(PIL,PILNOM,ADR)
VALUES
(PIL,'SERGE','Nice'),
(PIL,'JEAN','Paris'),
(PIL,'CLAUDE','Grenoble'),
(PIL,'ROBERT','Nantes'),
(PIL,'SIMON','PARIS'),
(PIL,'LUCIEN','Toulouse'),
(PIL,'BERTRAND','Lyon'),
(PIL,'HERVE','Bastia'),
(PIL,'LUC','Paris');

INSERT INTO vols(VOL,AV,PIL,VD,VA,HD,HA)
VALUES 
('IT100',100,1,'Nice','Paris',"7:00:00","9:00:00"),
('IT101',100,2,'Paris','Toulouse',"11:00:00","12:00:00"),
('IT102',101,1,'Paris','Nice',"12:00:00","14:00:00"),
('IT103',105,3,'Grenoble','Toulouse',"9:00:00","11:00:00"),
('IT104',105,3,'Toulouse','Grenoble',"17:00:00","19:00:00"),
('IT105',107,7,'Lyon','Paris',"6:00:00","7:00:00"),
('IT106',109,8,'Bastia','Paris',"10:00:00","13:00:00"),
('IT107',106,9,'Paris','Brive',"7:00:00","8:00:00"),
('IT108',106,9,'Brive','Paris',"19:00:00","20:00:00"),
('IT109',107,7,'Paris','Lyon',"18:00:00","19:00:00"),
('IT110',102,2,'Toulouse','Paris',"15:00:00","16:00:00"),
('IT111',101,4,'Nice','Nantes',"17:00:00","19:00:00"),
('IT112',103,5,'Paris','Nice',"11:00:00","13:00:00"),
('IT113',104,6,'Nice','Paris',"13:00:00","15:00:00");