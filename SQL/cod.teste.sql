USE teste_auto;

-- Tabela utilizatori (deja există, o recreăm dacă e nevoie)
CREATE TABLE IF NOT EXISTS utilizatori (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nume VARCHAR(50) NOT NULL,
    prenume VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    parola VARCHAR(255) NOT NULL,
    rol ENUM('admin', 'candidat') DEFAULT 'candidat',
    data_inregistrare DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Tabela categorii intrebari
CREATE TABLE IF NOT EXISTS categorii (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nume_categorie VARCHAR(100) NOT NULL
);

-- Tabela intrebari
CREATE TABLE IF NOT EXISTS intrebari (
    id INT AUTO_INCREMENT PRIMARY KEY,
    text_intrebare TEXT NOT NULL,
    id_categorie INT,
    data_adaugare DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_categorie) REFERENCES categorii(id) ON DELETE SET NULL
);

-- Tabela raspunsuri
CREATE TABLE IF NOT EXISTS raspunsuri (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_intrebare INT NOT NULL,
    text_raspuns TEXT NOT NULL,
    este_corect TINYINT(1) DEFAULT 0,
    FOREIGN KEY (id_intrebare) REFERENCES intrebari(id) ON DELETE CASCADE
);

-- Tabela teste
CREATE TABLE IF NOT EXISTS teste (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_utilizator INT NOT NULL,
    data_test DATETIME DEFAULT CURRENT_TIMESTAMP,
    scor INT DEFAULT 0,
    timp_secunde INT DEFAULT 0,
    promovat TINYINT(1) DEFAULT 0,
    tip_test ENUM('test', 'examen') DEFAULT 'examen',
    FOREIGN KEY (id_utilizator) REFERENCES utilizatori(id) ON DELETE CASCADE
);

-- Date initiale categorii
INSERT INTO categorii (nume_categorie) VALUES
('Indicatoare rutiere'),
('Reguli de circulatie'),
('Manevre'),
('Situatii de urgenta'),
('Legislatie');

-- Cont admin implicit
INSERT IGNORE INTO utilizatori (nume, prenume, email, parola, rol)
VALUES ('Admin', 'Principal', 'admin@testeauto.ro', 'admin123', 'admin');

SELECT * FROM utilizatori;


UPDATE utilizatori 
SET email = 'VladAdmin@testeauto.com' 
WHERE id = 1;

SELECT * FROM categorii;
DELETE FROM categorii WHERE id > 5;


