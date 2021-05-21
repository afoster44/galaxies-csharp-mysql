USE amazenaf;

-- CREATE TABLE galaxies
-- (
--     id INT NOT NULL AUTO_INCREMENT,
--     name VARCHAR(255) NOT NULL,
--     color VARCHAR(255) NOT NULL,
--     stellarContent VARCHAR(255) NOT NULL,

--     PRIMARY KEY (id)
-- );

-- CREATE TABLE stars
-- (
--     id INT NOT NULL AUTO_INCREMENT,
--     name VARCHAR(255) NOT NULL,
--     age INT NOT NULL,
--     size VARCHAR(255) NOT NULL,
--     mass VARCHAR(255) NOT NULL,
--     galaxyId INT NOT NULL,

--     PRIMARY KEY (id),

--     FOREIGN KEY (galaxyId)
--     REFERENCES galaxies (id)
--     ON DELETE CASCADE
-- );

-- CREATE TABLE planets
-- (
--     id INT NOT NULL AUTO_INCREMENT,
--     name VARCHAR(255) NOT NULL,
--     moons INT NOT NULL,
--     color VARCHAR(255) NOT NULL,
--     starId INT NOT NULL,
--     PRIMARY KEY (id),

--     FOREIGN KEY (starId)
--     REFERENCES stars (id)
--     ON DELETE CASCADE
-- )

CREATE TABLE species
(
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    description VARCHAR(255) NOT NULL,
    planetId INT NOT NULL,
    PRIMARY KEY (id),

    FOREIGN KEY (planetId)
    REFERENCES planets (id)
    ON DELETE CASCADE
)