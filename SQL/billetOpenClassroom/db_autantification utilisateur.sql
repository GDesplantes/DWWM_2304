 DROP DATABASE if EXISTS db_utilisateurs;

 CREATE DATABASE if NOT EXISTS  db_utilisateurs;
 
 USE db_utilisateurs;
 
 
 DROP TABLE if EXISTS utilisateurs;
 
 CREATE TABLE IF NOT EXISTS utilisateurs (
 id_user int(10) UNSIGNED NOT NULL ,
 lastname_user varchar(50) NOT NULL,
 firstname_user varchar(50) NOT NULL,
 mail_user varchar(150) NOT NULL,
 pass_user varchar(400) NOT NULL,
 lvl int(10) UNSIGNED NOT NULL,
 PRIMARY KEY (id_user)
) ENGINE=InnoDB DEFAULT CHARSET=UTF8;



INSERT INTO utilisateurs (id_user,lastname_user,firstname_user,mail_user,pass_user,lvl) VALUES 
(1,'CASTAFIORE', 'Bianca', 'b.castafiore@gmail.com','Rossignol',2),
(2,'TOURNESOL','Tryphon','t.tournesol@gmail.com','Tournedisque',1); 