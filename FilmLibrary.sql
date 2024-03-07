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
GRANT SELECT, UPDATE, INSERT
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
    description VARCHAR(2500),
    runtime INT,
    rating INT,
    release_year INT,
    movie_poster VARCHAR(45)
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


INSERT INTO movie VALUES (DEFAULT, "Poor Things", "Wildly imaginative and exhilaratingly over the top, Poor Things is a bizarre, brilliant tour de force for director Yorgos Lanthimos and star Emma Stone.", 141, 93, 2023, "poorthings"), 
					     (DEFAULT, "Anatomy of a Fall", "A smart, solidly crafted procedural that's anchored in family drama, Anatomy of a Fall finds star Sandra Hüller and director/co-writer Justine Triet operating at peak power.", 131, 96, 2023, "anatomyofafall"),
					     (DEFAULT, "The Kitchen", "Smart sci-fi that's solidly grounded in social commentary, The Kitchen suggests a bright future for the directing duo of Daniel Kaluuya and Kibwe Tavares.", 88, 77, 2023, "thekitchen"),
					     (DEFAULT, "Saltburn", "Emerald Fennell's candy-coated and incisive Saltburn is a debauched jolt to the senses that will be invigorating for most.", 131, 71, 2023, "saltburn"),
					     (DEFAULT, "The Beekeeper", "Cheerfully undemanding and enjoyably retrograde, The Beekeeper proves that when it comes to dispensing action-thriller justice, Statham hasn't lost his sting.", 133, 69, 2024, "thebeekeeper"),
					     (DEFAULT, "Road House", "Action-packed thriller with a runtime of 112 minutes.", 112, 71, 2024, "roadhouse"),
					     (DEFAULT, "Mean Girls", "Teen comedy with a runtime of 112 minutes.", 112, 63, 2024, "meangirls"),
					     (DEFAULT, "Killers of the Flower Moon", "Epic crime drama spanning 206 minutes.", 206, 77, 2023, "killersoftheflowermoon"),
					     (DEFAULT, "The Holdovers", "Engaging mystery film lasting 133 minutes.", 133, 80, 2023, "theholdovers"),
                         (DEFAULT, "The Midnight Library", "A captivating exploration of life's choices and regrets, The Midnight Library combines heartwarming moments with philosophical depth.", 120, 82, 2023, "themidnightlibrary"),
					     (DEFAULT, "The Forgotten City", "A gripping mystery set in an ancient Roman city, The Forgotten City weaves time-travel elements with moral dilemmas.", 135, 79, 2024, "theforgottencity"),
					     (DEFAULT, "The Starling", "A poignant dramedy about grief, resilience, and unexpected connections, The Starling features Melissa McCarthy in a standout performance.", 98, 75, 2023, "thestarling"),
					     (DEFAULT, "The Lost City", "An action-adventure comedy with Sandra Bullock and Channing Tatum, The Lost City promises laughs, romance, and jungle escapades.", 118, 68, 2024, "thelostcity"),
					     (DEFAULT, "The Velvet Underground", "A documentary exploring the influential rock band's rise and impact, The Velvet Underground is a must-watch for music enthusiasts.", 110, 80, 2023, "thevelvetunderground"),
					     (DEFAULT, "The Last Duel", "A historical drama with Ridley Scott at the helm, The Last Duel delves into betrayal, honor, and a high-stakes duel in medieval France.", 152, 76, 2023, "thelastduel"),
					     (DEFAULT, "The French Dispatch", "Wes Anderson's visually stunning anthology film, The French Dispatch celebrates journalism, art, and quirky storytelling.", 108, 79, 2023, "thefrenchdispatch"),
					     (DEFAULT, "The Northman", "A Viking revenge saga directed by Robert Eggers, The Northman promises brutal battles and atmospheric cinematography.", 140, 78, 2024, "thenorthman"),
					     (DEFAULT, "The Electric Life of Louis Wain", "Benedict Cumberbatch stars in this biographical drama about the eccentric artist Louis Wain, known for his whimsical cat illustrations.", 111, 73, 2023, "theelectriclifeoflouiswain");
    
SELECT * FROM user;SELECT * FROM movie;