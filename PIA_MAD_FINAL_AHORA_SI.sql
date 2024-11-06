CREATE DATABASE PIA_BIBLIA;
 
USE PIA_BIBLIA;
-- TABLA USUARIOS
CREATE TABLE USUARIO
(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
correo_electronico VARCHAR(100),
contrase�a VARCHAR(50),
nombre VARCHAR(100),
fecha_nacimiento DATE,
genero BIT,
habilitado BIT,
loging_attempt BIT,
fecha_registro DATE,
fecha_Baja DATE,
--user_admin BIT
);

INSERT INTO USUARIO(correo_electronico,contrase�a,nombre, fecha_nacimiento, genero,habilitado, fecha_registro,loging_attempt, user_admin)
VALUES('torres@gmail.com','Bralex0416','Bryan Alejandro Torres Fuentes','2002-04-16', 0, 1,'2023-11-24', 0, 0),
('jonathan@gmail.com','jonathan1213','Jonathan Alejandro Morales Segura','2000-12-13', 0, 1,'2023-11-24', 0, 0);
SELECT * FROM USUARIO;

INSERT INTO USUARIO(correo_electronico,contrase�a,nombre, fecha_nacimiento, genero,habilitado, fecha_registro,loging_attempt, user_admin)
VALUES('ivan@gmail.com','Bralex0416','Ivan Alexis Cantu','1998-04-16', 0, 1,'2023-11-25', 0, 0);

UPDATE USUARIO
SET habilitado = 1;
UPDATE USUARIO
SET loging_attempt = 0;
UPDATE USUARIO
SET contrase�a = 1;

--HISTORIAL DE CONTRASE�A
CREATE TABLE HISTORIAL_CONTRASE�A
(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
usuario_id INT FOREIGN KEY REFERENCES USUARIO(id),
contrase�a VARCHAR(100)
);
SELECT * FROM HISTORIAL_CONTRASE�A;

--HISTORIAL DE BUSQUEDA
CREATE TABLE HISTORIAL_BUSQUEDA
(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
id_usuario INT NOT NULL FOREIGN KEY REFERENCES USUARIO(id),
texto_buscado VARCHAR(100),
fecha_busqueda DATE
);

SELECT * FROM HISTORIAL_BUSQUEDA;

--Comparar con Historial Contrase�as
CREATE PROCEDURE Historialcontra @ID INT
AS
BEGIN
SELECT HISTORIAL_CONTRASE�A.contrase�a FROM HISTORIAL_CONTRASE�A
INNER JOIN USUARIO ON HISTORIAL_CONTRASE�A.usuario_id = USUARIO.id
WHERE USUARIO.id = @ID
END

--CONTRASE�� TEMPORAL
CREATE TABLE CONTRASE�A_TEMP
(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
id_usuario INT NOT NULL FOREIGN KEY REFERENCES USUARIO(id),
contrase�a VARCHAR(100)
);
INSERT INTO CONTRASE�A_TEMP (id_usuario, contrase�a) VALUES (3,'Pirata123');

SELECT * FROM CONTRASE�A_TEMP;

--TABLA Favoritos
CREATE TABLE FAVORITOS
(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
id_usuario INT NOT NULL FOREIGN KEY REFERENCES USUARIO(id),
id_versiculo INT NOT NULL FOREIGN KEY REFERENCES VERSICULO(id)
);

EXEC Agregar_favorito @ID = '1', @ID_Pas = '10';

--PROCEDUR AGREGAR FAVORITO
CREATE PROCEDURE Agregar_favorito @ID INT, @ID_Pas INT
AS
BEGIN
INSERT INTO FAVORITOS(id_usuario, id_versiculo)
VALUES (@ID, @ID_Pas)
END;

SELECT USUARIO.id AS ID_USUARIO,USUARIO.nombre AS NOMBRE, 
VERSICULO.id AS ID_PASAJE,VERSICULO.descripcion AS PASAJE
FROM USUARIO
INNER JOIN FAVORITOS ON USUARIO.id =FAVORITOS.id_usuario
INNER JOIN VERSICULO ON FAVORITOS.id_versiculo = VERSICULO.id


--Eliminar Favorito
CREATE PROCEDURE Eli_Fav @ID INT, @ID_PAS INT
AS
BEGIN
DELETE FROM FAVORITOS
WHERE id_usuario = @ID AND id_versiculo = @ID_PAS
END;

EXEC Eli_Fav @ID ='"++"', @ID_PAS = '"++"';

--Mostrar Favoritos
CREATE PROCEDURE Mostrar_Fav @ID INT
AS
BEGIN
SELECT VERSICULO.id, CAPITULO.capitulo, VERSICULO.numero, 
VERSICULO.descripcion
FROM USUARIO
INNER JOIN FAVORITOS ON USUARIO.id =FAVORITOS.id_usuario
INNER JOIN VERSICULO ON FAVORITOS.id_versiculo = VERSICULO.id
INNER JOIN CAPITULO ON VERSICULO.id_capitulo = CAPITULO.id
WHERE USUARIO.id = @ID
END;

EXEC Mostrar_His_Bus @ID ='"++"';


--Contrase�a Update Trigger
CREATE TRIGGER Contrase�a_trigger
ON USUARIO
AFTER UPDATE
AS
BEGIN
    IF UPDATE(contrase�a)
    BEGIN
        INSERT INTO HISTORIAL_CONTRASE�A(usuario_id,contrase�a) SELECT id, contrase�a FROM inserted
    END
END;

--Iniciar Sesion 
CREATE PROCEDURE Iniciar_Sesion @Correo VARCHAR(100), @Contrase�a VARCHAR(100)
AS
BEGIN
SELECT * FROM USUARIO 
WHERE correo_electronico = @Correo AND contrase�a = @Contrase�a
END;

--Editar Usuario
CREATE PROCEDURE Editar_usuario @ID_usuario INT, @Nombre VARCHAR(100), @Contrase�a VARCHAR(100), @Correo VARCHAR(100), @Genero BIT, @Fecha_nacimiento DATE
AS 
BEGIN
UPDATE USUARIO
SET nombre = @Nombre, contrase�a = @Contrase�a, correo_electronico = @Correo, genero = @Genero, fecha_nacimiento = @Fecha_nacimiento, habilitado = 1
WHERE id = @ID_usuario;
END;

--Editar Usuario Sin Contra
CREATE PROCEDURE Editar_usuario2 @ID_usuario INT, @Nombre VARCHAR(100), @Correo VARCHAR(100), @Genero BIT, @Fecha_nacimiento DATE
AS 
BEGIN
UPDATE USUARIO
SET nombre = @Nombre,correo_electronico = @Correo, genero = @Genero, fecha_nacimiento = @Fecha_nacimiento 
WHERE id = @ID_usuario;
END;

TRUNCATE TABLE HISTORIAL_CONTRASE�A;


--Asignador de Contra Temporal
CREATE TRIGGER Contrase�a_Temp_TRIGGER
ON USUARIO
AFTER UPDATE
AS
BEGIN
    IF UPDATE(loging_attempt)
    BEGIN
	DECLARE @Datoinsert VARCHAR(100)
	SELECT @Datoinsert = CONTRASE�A_TEMP.contrase�a 
	FROM CONTRASE�A_TEMP 
	INNER JOIN inserted ON CONTRASE�A_TEMP.id_usuario = inserted.id    
	UPDATE USUARIO
	SET USUARIO.contrase�a = @Datoinsert, USUARIO.loging_attempt = 0
	FROM USUARIO
	INNER JOIN inserted ON USUARIO.id = inserted.id;
	END
END;

--TABLA Idioma
CREATE TABLE IDIOMA
(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
idioma VARCHAR(100)
);

--TABLA BIBLIA
CREATE TABLE BIBLIA
(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
id_idioma INT NOT NULL FOREIGN KEY REFERENCES IDIOMA(id),
testamento VARCHAR(100)
);

--LIBRO
CREATE TABLE LIBRO 
(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
id_biblia INT NOT NULL FOREIGN KEY REFERENCES BIBLIA(id),
nombre VARCHAR(100)
);

--CAPITULO
CREATE TABLE CAPITULO
(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
id_libro INT NOT NULL FOREIGN KEY REFERENCES LIBRO(id),
capitulo INT,
);

--VERSICULO
CREATE TABLE VERSICULO
(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
id_capitulo INT NOT NULL FOREIGN KEY REFERENCES CAPITULO(id),
numero INT,
descripcion VARCHAR(250)
);

--INSERTS BIBLIA
 
INSERT INTO IDIOMA (idioma) VALUES('Espa�ol'),('Ingles');

INSERT INTO BIBLIA (id_idioma,testamento) VALUES(1,'Antiguo Testamento'),(1,'Nuevo Testamento'), (2,'The Old Testament'),(2,'The New Testament') ;

--INSERTS LIBROS--
--ANTIGUO TESTAMENTO--
INSERT INTO LIBRO(id_biblia,nombre) VALUES(1,'G�nesis'),(1,'�xodo'),(1,'Lev�tico'), (1,'N�meros'), (1,'Deuteronomio');
INSERT INTO LIBRO(id_biblia,nombre) VALUES(3,'Genesis'),(3,'Exodus'),(3,'Leviticus'), (3,'Numbers'), (3,'Deuteronomy');
--NUEVO TESTAMENTO--
INSERT INTO LIBRO(id_biblia,nombre) VALUES(2,'Mateo'),(2,'Marcos'),(2,'Lucas'), (2,'Juan'), (2,'Hechos De Los Ap�stoles');
INSERT INTO LIBRO(id_biblia,nombre) VALUES(4,'Matthew'),(4,'Mark'),(4,'Luke'), (4,'John'), (4,'Acts');

--INSERT CAPITULOS--
INSERT INTO CAPITULO (id_libro, capitulo) 
VALUES	(1, 1),(1, 2), (2, 1),(2, 2), (3, 1),(3, 2), (4, 1),(4, 2),(5, 1),(5, 2), 
		(6, 1),(6, 2), (7, 1),(7, 2), (8, 1),(8, 2), (9, 1),(9, 2),(10, 1),(10, 2), 
		(11, 1),(11, 2), (12, 1),(12, 2),(13, 1),(13, 2), (14, 1),(14, 2),(15, 1),(15, 2), 
		(16, 1),(16, 2),(17, 1),(17, 2), (18, 1),(18, 2), (19, 1),(19, 2), (20, 1),(20, 2);

INSERT INTO VERSICULO(id_capitulo, numero, descripcion) 
VALUES
(1, 1, 'En el principio cre� Dios los cielos y la tierra.'),
(1, 2, 'Y la tierra estaba desordenada y vac�a, y las tinieblas estaban sobre la faz del abismo, y el Esp�ritu de Dios se mov�a sobre la faz de las aguas.'), 
(2, 1, 'Fueron, pues, acabados los cielos y la tierra, y todo el ej�rcito de ellos.'), 
(2, 2, 'Y acab� Dios en el d�a s�ptimo la obra que hizo; y repos� el d�a s�ptimo de toda la obra que hizo.'), 
(3, 1, 'Estos son los nombres de los hijos de Israel que entraron en Egipto con Jacob; cada uno entr� con su familia:'), 
(3, 2, 'Rub�n, Sime�n, Lev�, Jud�,'), 
(4, 1, 'Un var�n de la familia de Lev� fue y tom� por mujer a una hija de Lev�,'), 
(4, 2, 'la que concibi�, y dio a luz un hijo; y vi�ndole que era hermoso, le tuvo escondido tres meses.'), 
(5, 1, 'Llam� Jehov� a Mois�s, y habl� con �l desde el tabern�culo de reuni�n, diciendo:'), 
(5, 2, 'Habla a los hijos de Israel y diles: Cuando alguno de entre vosotros ofrece ofrenda a Jehov�, de ganado vacuno u ovejuno har�is vuestra ofrenda.'), 
(6, 1, 'Cuando alguna persona ofreciere oblaci�n a Jehov�, su ofrenda ser� flor de harina, sobre la cual echar� aceite, y pondr� sobre ella incienso,'), 
(6, 2, 'y la traer� a los sacerdotes, hijos de Aar�n; y de ello tomar� el sacerdote su pu�o lleno de la flor de harina y del aceite, con todo el incienso, y lo har� arder sobre el altar para memorial; ofrenda encendida es, de olor grato a Jehov�.'), 
(7, 1, 'Habl� Jehov� a Mois�s en el desierto de Sina�, en el tabern�culo de reuni�n, en el d�a primero del mes segundo, en el segundo a�o de su salida de la tierra de Egipto, diciendo:'), 
(7, 2, 'Tomad el censo de toda la congregaci�n de los hijos de Israel por sus familias, por las casas de sus padres, con la cuenta de los nombres, todos los varones por sus cabezas. '), 
(8, 1, 'Habl� Jehov� a Mois�s y a Aar�n, diciendo:'), 
(8, 2, 'Los hijos de Israel acampar�n cada uno junto a su bandera, bajo las ense�as de las casas de sus padres; alrededor del tabern�culo de reuni�n acampar�n.'),
(9, 1, 'Estas son las palabras que habl� Mois�s a todo Israel a este lado del Jord�n en el desierto, en el Arab� frente al Mar Rojo, entre Par�n, Tofel, Lab�n, Hazerot y Dizahab.'), 
(9, 2, 'Once jornadas hay desde Horeb, camino del monte de Seir, hasta Cades-barnea.'), 
(10, 1, 'Luego volvimos y salimos al desierto, camino del Mar Rojo, como Jehov� me hab�a dicho; y rodeamos el monte de Seir por mucho tiempo.'), 
(10, 2, 'Y Jehov� me habl�, diciendo:'),
(11, 1, 'At the first God made the heaven and the earth.'), 
(11, 2, 'And the earth was waste and without form; and it was dark on the face of the deep: and the Spirit of God was moving on the face of the waters.'), 
(12, 1, 'And the heaven and the earth and all things in them were complete.'), 
(12, 2, 'And on the seventh day God came to the end of all his work; and on the seventh day he took his rest from all the work which he had done.'), 
(13, 1, 'Now these are the names of the children of Israel, which came into Egypt; every man and his household came with Jacob.'), 
(13, 2, 'Reuben, Simeon, Levi, and Judah,'), 
(14, 1, 'And there went a man of the house of Levi, and took to wife a daughter of Levi.'), 
(14, 2, 'And the woman conceived, and bare a son: and when she saw him that he was a goodly child, she hid him three months.'), 
(15, 1, 'And the LORD called unto Moses, and spake unto him out of the tabernacle of the congregation, saying,'), 
(15, 2, 'Speak unto the children of Israel, and say unto them, If any man of you bring an offering unto the LORD, ye shall bring your offering of the cattle, even of the herd, and of the flock.'), 
(16, 1, 'And when any will offer a meat offering unto the LORD, his offering shall be of fine flour; and he shall pour oil upon it, and put frankincense thereon:'), 
(16, 2, 'And the remnant of the meat offering shall be Aarons and his sons: it is a thing most holy of the offerings of the LORD made by fire.'), 
(17, 1, 'And the LORD spake unto Moses in the wilderness of Sinai, in the tabernacle of the congregation, on the first day of the second month, in the second year after they were come out of the land of Egypt, saying,'), 
(17, 2, 'Take ye the sum of all the congregation of the children of Israel, after their families, by the house of their fathers, with the number of their names, every male by their polls;'),
(18, 1, 'And the LORD spake unto Moses and unto Aaron, saying,'), 
(18, 2, 'Every man of the children of Israel shall pitch by his own standard, with the ensign of their fathers house: far off about the tabernacle of the congregation shall they pitch.'), 
(19, 1, 'These be the words which Moses spake unto all Israel on this side Jordan in the wilderness, in the plain over against the Red sea, between Paran, and Tophel, and Laban, and Hazeroth, and Dizahab.'), 
(19, 2, '(There are eleven days journey from Horeb by the way of mount Seir unto Kadeshbarnea.)'), 
(20, 1, 'Then we turned, and took our journey into the wilderness by the way of the Red sea, as the LORD spake unto me: and we compassed mount Seir many days.'), 
(20, 2, 'And the LORD spake unto me, saying,'), 
(21, 1, 'Libro de la genealog�a de Jesucristo, hijo de David, hijo de Abraham.'), 
(21, 2, 'Abraham engendr� a Isaac, Isaac a Jacob, y Jacob a Jud� y a sus hermanos.'), 
(22, 1, 'Cuando Jes�s naci� en Bel�n de Judea en d�as del rey Herodes, vinieron del oriente a Jerusal�n unos magos,'), 
(22, 2, 'diciendo: �D�nde est� el rey de los jud�os, que ha nacido? Porque su estrella hemos visto en el oriente, y venimos a adorarle.'), 
(23, 1, 'Principio del evangelio de Jesucristo, Hijo de Dios.'), 
(23, 2, 'Como est� escrito en Isa�as el profeta: He aqu� yo env�o mi mensajero delante de tu faz, El cual preparar� tu camino delante de ti.'), 
(24, 1, 'Entr� Jes�s otra vez en Capernaum despu�s de algunos d�as; y se oy� que estaba en casa.'), 
(24, 2, 'E inmediatamente se juntaron muchos, de manera que ya no cab�an ni aun a la puerta; y les predicaba la palabra.'), 
(25, 1, 'Puesto que ya muchos han tratado de poner en orden la historia de las cosas que entre nosotros han sido ciert�simas,'), 
(25, 2, 'tal como nos lo ense�aron los que desde el principio lo vieron con sus ojos, y fueron ministros de la palabra'), 
(26, 1, 'Aconteci� en aquellos d�as, que se promulg� un edicto de parte de Augusto C�sar, que todo el mundo fuese empadronado.'), 
(26, 2, 'Este primer censo se hizo siendo Cirenio gobernador de Siria.'), 
(27, 1, 'En el principio era el Verbo, y el Verbo era con Dios, y el Verbo era Dios.'), 
(27, 2, 'Este era en el principio con Dios.'), 
(28, 1, 'Al tercer d�a se hicieron unas bodas en Can� de Galilea; y estaba all� la madre de Jes�s.'), 
(28, 2, 'Y fueron tambi�n invitados a las bodas Jes�s y sus disc�pulos.'), 
(29, 1, 'En el primer tratado, oh Te�filo, habl� acerca de todas las cosas que Jes�s comenz� a hacer y a ense�ar,'), 
(29, 2, 'hasta el d�a en que fue recibido arriba, despu�s de haber dado mandamientos por el Esp�ritu Santo a los ap�stoles que hab�a escogido;'), 
(30, 1, 'Cuando lleg� el d�a de Pentecost�s, estaban todos un�nimes juntos.'), 
(30, 2, 'Y de repente vino del cielo un estruendo como de un viento recio que soplaba, el cual llen� toda la casa donde estaban sentados;'), 
(31, 1, 'The book of the generation of Jesus Christ, the son of David, the son of Abraham.'), 
(31, 2, 'Abraham begat Isaac; and Isaac begat Jacob; and Jacob begat Judas and his brethren;'), 
(32, 1, 'Now when Jesus was born in Bethlehem of Judaea in the days of Herod the king, behold, there came wise men from the east to Jerusalem,'), 
(32, 2, 'Saying, Where is he that is born King of the Jews? for we have seen his star in the east, and are come to worship him.'), 
(33, 1, 'The beginning of the gospel of Jesus Christ, the Son of God;'), 
(33, 2, 'As it is written in the prophets, Behold, I send my messenger before thy face, which shall prepare thy way before thee.'), 
(34, 1, 'And again he entered into Capernaum after some days; and it was noised that he was in the house.'), 
(34, 2, 'And straightway many were gathered together, insomuch that there was no room to receive them, no, not so much as about the door: and he preached the word unto them.'), 
(35, 1, 'Forasmuch as many have taken in hand to set forth in order a declaration of those things which are most surely believed among us,'), 
(35, 2, 'Even as they delivered them unto us, which from the beginning were eyewitnesses, and ministers of the word;'), 
(36, 1, 'And it came to pass in those days, that there went out a decree from Caesar Augustus, that all the world should be taxed.'), 
(36, 2, '(And this taxing was first made when Cyrenius was governor of Syria.)'), 
(37, 1, 'In the beginning was the Word, and the Word was with God, and the Word was God.'), 
(37, 2, 'The same was in the beginning with God.'), 
(38, 1, 'And the third day there was a marriage in Cana of Galilee; and the mother of Jesus was there:'), 
(38, 2, 'And both Jesus was called, and his disciples, to the marriage.'), 
(39, 1, 'The former treatise have I made, O Theophilus, of all that Jesus began both to do and teach,'), 
(39, 2, 'Until the day in which he was taken up, after that he through the Holy Ghost had given commandments unto the apostles whom he had chosen:'), 
(40, 1, 'And when the day of Pentecost was fully come, they were all with one accord in one place.'), 
(40, 2, 'And suddenly there came a sound from heaven as of a rushing mighty wind, and it filled all the house where they were sitting.');

SELECT IDIOMA.idioma, BIBLIA.testamento,LIBRO.nombre, CAPITULO.capitulo, VERSICULO.numero, VERSICULO.descripcion
FROM IDIOMA
INNER JOIN BIBLIA ON IDIOMA.ID = BIBLIA.id_idioma
INNER JOIN LIBRO ON BIBLIA.id = LIBRO.id_biblia
INNER JOIN CAPITULO ON LIBRO.id = CAPITULO.id_libro
INNER JOIN VERSICULO ON CAPITULO.id = VERSICULO.id_capitulo;

--Procedure Ver Versiculos por Libro
CREATE PROCEDURE Bus_Ver_Lib @texto_busqueda VARCHAR(100)
AS 
BEGIN
SELECT VERSICULO.id AS ID_VERSICULO, CAPITULO.capitulo AS CAPITULO, VERSICULO.numero AS VERSICULO, VERSICULO.descripcion AS PASAJE
FROM IDIOMA
INNER JOIN BIBLIA ON IDIOMA.ID = BIBLIA.id_idioma
INNER JOIN LIBRO ON BIBLIA.id = LIBRO.id_biblia
INNER JOIN CAPITULO ON LIBRO.id = CAPITULO.id_libro
INNER JOIN VERSICULO ON CAPITULO.id = VERSICULO.id_capitulo
WHERE (LIBRO.nombre LIKE '%'+@texto_busqueda +'%')
END;

EXEC Bus_Ver_Lib @texto_busqueda ='s';

--Procedure Ver Versiculos por Capitulo
CREATE PROCEDURE Bus_Ver_Cap @texto_busqueda VARCHAR(100)
AS 
BEGIN
SELECT VERSICULO.id AS ID_VERSICULO, CAPITULO.capitulo AS CAPITULO, VERSICULO.numero AS VERSICULO, VERSICULO.descripcion AS PASAJE
FROM IDIOMA
INNER JOIN BIBLIA ON IDIOMA.ID = BIBLIA.id_idioma
INNER JOIN LIBRO ON BIBLIA.id = LIBRO.id_biblia
INNER JOIN CAPITULO ON LIBRO.id = CAPITULO.id_libro
INNER JOIN VERSICULO ON CAPITULO.id = VERSICULO.id_capitulo
WHERE (CAPITULO.capitulo LIKE '%'+@texto_busqueda +'%')
END;

--Procedure Ver Versiculos por versiculo
CREATE PROCEDURE Bus_Ver_Ver @texto_busqueda VARCHAR(100)
AS 
BEGIN
SELECT VERSICULO.id AS ID_VERSICULO, CAPITULO.capitulo AS CAPITULO, VERSICULO.numero AS VERSICULO, VERSICULO.descripcion AS PASAJE
FROM IDIOMA
INNER JOIN BIBLIA ON IDIOMA.ID = BIBLIA.id_idioma
INNER JOIN LIBRO ON BIBLIA.id = LIBRO.id_biblia
INNER JOIN CAPITULO ON LIBRO.id = CAPITULO.id_libro
INNER JOIN VERSICULO ON CAPITULO.id = VERSICULO.id_capitulo
WHERE (VERSICULO.numero LIKE '%'+@texto_busqueda+'%')
END;

EXEC Bus_Ver_Ver @texto_busqueda = '"++"';

--Procedure Eliminar Usuario
CREATE PROCEDURE Elim_usuario @ID INT
AS
BEGIN
UPDATE USUARIO SET habilitado = 0, fecha_Baja = GETDATE()
WHERE id = @ID
END;

EXEC Update_usuario @ID = '"++"';

--Procedure Desabilitar Usuario
CREATE PROCEDURE Desha_usuario @correo VARCHAR(100), @contrase�a VARCHAR(100)
AS
BEGIN
UPDATE USUARIO SET habilitado = 0, loging_attempt = 1 
WHERE (correo_electronico = @correo) AND (contrase�a <> @contrase�a);
END;

EXEC Desha_usuario @correo = '"++"',@contrase�a = '"++"';

--
CREATE PROCEDURE Buscar_usu @correo VARCHAR(100)
AS
BEGIN
SELECT * FROM USUARIO 
WHERE correo_electronico = @correo
END;


------VIEWS

--Ver Espa�ol
CREATE VIEW Ver_Espa�ol
AS
SELECT VERSICULO.id,
CAPITULO.capitulo, VERSICULO.numero, 
VERSICULO.descripcion
FROM IDIOMA
INNER JOIN BIBLIA ON IDIOMA.ID = BIBLIA.id_idioma
INNER JOIN LIBRO ON BIBLIA.id = LIBRO.id_biblia
INNER JOIN CAPITULO ON LIBRO.id = CAPITULO.id_libro
INNER JOIN VERSICULO ON CAPITULO.id = VERSICULO.id_capitulo
WHERE IDIOMA.idioma LIKE'%Espa�ol%';

SELECT * FROM Ver_Espa�ol;

--Ver Ingles
CREATE VIEW Ver_Ingles
AS
SELECT VERSICULO.id,
CAPITULO.capitulo, VERSICULO.numero, 
VERSICULO.descripcion
FROM IDIOMA
INNER JOIN BIBLIA ON IDIOMA.ID = BIBLIA.id_idioma
INNER JOIN LIBRO ON BIBLIA.id = LIBRO.id_biblia
INNER JOIN CAPITULO ON LIBRO.id = CAPITULO.id_libro
INNER JOIN VERSICULO ON CAPITULO.id = VERSICULO.id_capitulo
WHERE IDIOMA.idioma LIKE'%Ingles%';

SELECT * FROM Ver_Ingles;

--Ver New Testament
CREATE VIEW Ver_New_Test
AS
SELECT VERSICULO.id,
CAPITULO.capitulo, VERSICULO.numero, 
VERSICULO.descripcion
FROM IDIOMA
INNER JOIN BIBLIA ON IDIOMA.ID = BIBLIA.id_idioma
INNER JOIN LIBRO ON BIBLIA.id = LIBRO.id_biblia
INNER JOIN CAPITULO ON LIBRO.id = CAPITULO.id_libro
INNER JOIN VERSICULO ON CAPITULO.id = VERSICULO.id_capitulo
WHERE BIBLIA.testamento LIKE'%New Testament%';

SELECT * FROM Ver_New_Test;

--Ver Old Testament
CREATE VIEW Ver_Old_Test
AS
SELECT VERSICULO.id,
CAPITULO.capitulo, VERSICULO.numero, 
VERSICULO.descripcion
FROM IDIOMA
INNER JOIN BIBLIA ON IDIOMA.ID = BIBLIA.id_idioma
INNER JOIN LIBRO ON BIBLIA.id = LIBRO.id_biblia
INNER JOIN CAPITULO ON LIBRO.id = CAPITULO.id_libro
INNER JOIN VERSICULO ON CAPITULO.id = VERSICULO.id_capitulo
WHERE BIBLIA.testamento LIKE'%Old Testament%';

SELECT * FROM Ver_Old_Test;

--Ver Nuevo Testamento
CREATE VIEW Ver_Nuevo_Test
AS
SELECT VERSICULO.id,
CAPITULO.capitulo, VERSICULO.numero, 
VERSICULO.descripcion
FROM IDIOMA
INNER JOIN BIBLIA ON IDIOMA.ID = BIBLIA.id_idioma
INNER JOIN LIBRO ON BIBLIA.id = LIBRO.id_biblia
INNER JOIN CAPITULO ON LIBRO.id = CAPITULO.id_libro
INNER JOIN VERSICULO ON CAPITULO.id = VERSICULO.id_capitulo
WHERE BIBLIA.testamento LIKE'%Nuevo Testamento%';

SELECT * FROM Ver_Nuevo_Test;

--Ver Viejo Testamento
CREATE VIEW Ver_Antiguo_Test
AS
SELECT VERSICULO.id,
CAPITULO.capitulo, VERSICULO.numero, 
VERSICULO.descripcion
FROM IDIOMA
INNER JOIN BIBLIA ON IDIOMA.ID = BIBLIA.id_idioma
INNER JOIN LIBRO ON BIBLIA.id = LIBRO.id_biblia
INNER JOIN CAPITULO ON LIBRO.id = CAPITULO.id_libro
INNER JOIN VERSICULO ON CAPITULO.id = VERSICULO.id_capitulo
WHERE BIBLIA.testamento LIKE'%Antiguo Testamento%';

SELECT * FROM Ver_Antiguo_Test;

--Ver Todo
CREATE VIEW Ver_Todo
AS
SELECT VERSICULO.id AS ID_VERSICULO, IDIOMA.idioma AS IDIOMA, 
BIBLIA.testamento AS TESTAMENTO,LIBRO.nombre AS LIBRO,
CAPITULO.capitulo AS CAPITULO, VERSICULO.numero AS VERSICULO, 
VERSICULO.descripcion AS PASAJE
FROM IDIOMA
INNER JOIN BIBLIA ON IDIOMA.ID = BIBLIA.id_idioma
INNER JOIN LIBRO ON BIBLIA.id = LIBRO.id_biblia
INNER JOIN CAPITULO ON LIBRO.id = CAPITULO.id_libro
INNER JOIN VERSICULO ON CAPITULO.id = VERSICULO.id_capitulo;

SELECT * FROM Ver_Todo;

--Procedure ver Versiculos por Libro y TxtBuscar
CREATE PROCEDURE Busq_Lib_Ref @libro VARCHAR(100), @reference VARCHAR(100)
AS
BEGIN
SELECT VERSICULO.id,
CAPITULO.capitulo, VERSICULO.numero, 
VERSICULO.descripcion
FROM  LIBRO 
INNER JOIN CAPITULO ON LIBRO.id = CAPITULO.id_libro
INNER JOIN VERSICULO ON CAPITULO.id = VERSICULO.id_capitulo
WHERE (LIBRO.nombre LIKE '%'+@libro+'%') AND (VERSICULO.descripcion LIKE '%'+@reference+'%')
END;

EXEC Busq_Lib_Ref @libro ='"++"', @reference='"++"';

--Procedure ver Versiculos por Testamento y TxtBuscar
CREATE PROCEDURE Busq_Test_Ref @test VARCHAR(100), @reference VARCHAR(100)
AS
BEGIN
SELECT VERSICULO.id,
CAPITULO.capitulo, VERSICULO.numero, 
VERSICULO.descripcion
FROM BIBLIA 
INNER JOIN LIBRO ON BIBLIA.id = LIBRO.id_biblia
INNER JOIN CAPITULO ON LIBRO.id = CAPITULO.id_libro
INNER JOIN VERSICULO ON CAPITULO.id = VERSICULO.id_capitulo
WHERE (BIBLIA.testamento LIKE '%'+@test+'%') AND (VERSICULO.descripcion LIKE '%'+@reference+'%')
END;

EXEC Busq_Test_Ref @test ='"++"', @reference='"++"';

--Procedure ver Versiculos TxtBuscar
CREATE PROCEDURE Busq_Pas_Ref @reference VARCHAR(100)
AS
BEGIN
SELECT VERSICULO.id,
CAPITULO.capitulo, VERSICULO.numero, 
VERSICULO.descripcion
FROM CAPITULO
INNER JOIN VERSICULO ON CAPITULO.id = VERSICULO.id_capitulo
WHERE VERSICULO.descripcion LIKE '%'+@reference+'%'
END;

EXEC Busq_Pas_Ref @reference='"++"';

--PROCEDURE GUARDAR BUSQUEDA
CREATE PROCEDURE Guardar_busq @ID INT, @reference VARCHAR(100)
AS
BEGIN
INSERT INTO HISTORIAL_BUSQUEDA(id_usuario, texto_buscado, fecha_busqueda)
VALUES (@ID, @reference, GETDATE())
END;

--Mostar Historial Busqueda
CREATE PROCEDURE Mostrar_His_Bus @ID INT
AS
BEGIN
SELECT texto_buscado, fecha_busqueda 
FROM HISTORIAL_BUSQUEDA
WHERE id_usuario = @ID
END;

EXEC Mostrar_His_Bus @ID ='"++"'

--Eliminar Historial
CREATE PROCEDURE Borrar_busq @ID INT
AS
BEGIN
DELETE FROM HISTORIAL_BUSQUEDA
WHERE id_usuario = @ID 
END;

EXEC Borrar_busq @ID ='"++"';