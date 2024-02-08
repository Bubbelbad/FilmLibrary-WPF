DROP DATABASE IF EXISTS FilmLibrary;
CREATE DATABASE FilmLibrary;
USE FilmLibrary;

DROP USER IF EXISTS 'admin'@'localhost';
CREATE USER 'admin'@'localhost' IDENTIFIED BY 'admin';
GRANT SELECT, UPDATE, DELETE, INSERT, EXECUTE
ON FilmLibrary.*
TO 'admin'@'localhost';

DROP USER IF EXISTS 'user'@'localhost';
CREATE USER 'user'@'localhost' IDENTIFIED BY 'password';
GRANT SELECT, UPDATE
ON FilmLibrary.*
TO 'user'@'localhost';

DROP TABLE IF EXISTS user;
CREATE TABLE user(
	id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    first_name VARCHAR(100),
    last_name VARCHAR(100),
    email VARCHAR(320),
    password VARCHAR(45),
    admin BOOLEAN
);

DROP TABLE IF EXISTS movie;
CREATE TABLE movie(
	id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    title VARCHAR(45),
    descript VARCHAR(2500),
    runtime INT,
    rating INT,
    release_year INT
);

DROP TABLE IF EXISTS category;
CREATE TABLE category(
	id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    name VARCHAR(45)
);

DROP TABLE IF EXISTS movie_has_category;
CREATE TABLE movie_has_category(
	movie_id INT,
    category_id INT,
    FOREIGN KEY (movie_id) REFERENCES movie(id),
    FOREIGN KEY (category_id) REFERENCES category(id)
);
    

INSERT INTO user VALUES (DEFAULT, "admin", "adminsson", "admin", "admin", true),
						(DEFAULT, "user", "Svensson", "user", "user", false),
						(DEFAULT, "Bengan", "Bengtsson", "bengan.bengtsson@example.se", "1234", false),
						(DEFAULT, "Farbror", "Barbro", "farbror.barbro@hifiklubben.se", "1234", false),
						(DEFAULT, "Al B.", "Bachman", "al.bach.bachman@example.com", "1234", false),
						(DEFAULT, "Candice B.", "DePlace", "candice.b.deplace@example.com", "1234", false),
						(DEFAULT, "Drew", "Peacock", "drew.peacock@example.com", "1234", false),
						(DEFAULT, "Ella", "Vader", "ella.vader@example.com", "1234", false),
						(DEFAULT, "Frank N.", "Stein", "frank.n.stein@example.com", "1234", false),
						(DEFAULT, "Ginger", "Vitis", "ginger.vitis@example.com", "1234", false),
						(DEFAULT, "Ivana", "Tinkle", "ivana.tinkle@example.com", "1234", false),
						(DEFAULT, "Jack", "Pott", "jack.pott@example.com", "1234", false),
						(DEFAULT, "Justin", "Thyme", "justin.thyme@example.com", "1234", false),
						(DEFAULT, "Kurt N.", "Rodd", "kurt.n.rodd@example.com", "1234", false),
						(DEFAULT, "Manny", "Kinn", "manny.kinn@example.com", "1234", false),
						(DEFAULT, "May B.", "Knott", "may.b.knott@example.com", "1234", false),
						(DEFAULT, "Olive", "Yew", "olive.yew@example.com", "1234", false),
						(DEFAULT, "Paige", "Turner", "paige.turner@example.com", "1234", false),
						(DEFAULT, "Phil", "Harmonic", "phil.harmonic@example.com", "1234", false),
						(DEFAULT, "Ray N.", "Carnation", "ray.n.carnation.@example.com", "1234", false);


INSERT INTO movie VALUES (DEFAULT, "Poor Things", "Wildly imaginative and exhilaratingly over the top, Poor Things is a bizarre, brilliant tour de force for director Yorgos Lanthimos and star Emma Stone.", 141, 93, 2023), 
					     (DEFAULT, "Anatomy of a Fall", "A smart, solidly crafted procedural that's anchored in family drama, Anatomy of a Fall finds star Sandra Hüller and director/co-writer Justine Triet operating at peak power.", 131, 96, 2023),
					     (DEFAULT, "The Kitchen", "Smart sci-fi that's solidly grounded in social commentary, The Kitchen suggests a bright future for the directing duo of Daniel Kaluuya and Kibwe Tavares.", 88, 77, 2023),
					     (DEFAULT, "Saltburn", "Emerald Fennell's candy-coated and incisive Saltburn is a debauched jolt to the senses that will be invigorating for most.", 131, 71, 2023),
					     (DEFAULT, "The Beekeeper", "Cheerfully undemanding and enjoyably retrograde, The Beekeeper proves that when it comes to dispensing action-thriller justice, Statham hasn't lost his sting.", 133, 69, 2024),
					     (DEFAULT, "Road House", "Action-packed thriller with a runtime of 112 minutes.", 112, 7.1, 2024),
					     (DEFAULT, "Mean Girls", "Teen comedy with a runtime of 112 minutes.", 112, 6.3, 2024),
					     (DEFAULT, "Killers of the Flower Moon", "Epic crime drama spanning 206 minutes.", 206, 7.7, 2023),
					     (DEFAULT, "The Holdovers", "Engaging mystery film lasting 133 minutes.", 133, 8.0, 2023),
					     (DEFAULT, "Wonka", "Family-friendly adventure movie running for 116 minutes.", 116, NULL, 2023),
					     (DEFAULT, "Dumb Money", "Comedy now available on Netflix.", NULL, NULL, NULL),
					     (DEFAULT, "Godzilla Minus One", "Black-and-white edition release of the classic monster film.", NULL, NULL, NULL);
    