USE amazenaf;

CREATE TABLE galaxies
(
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    color VARCHAR(255) NOT NULL,
    stellarContent VARCHAR(255) NOT NULL,

    PRIMARY KEY (id)
);