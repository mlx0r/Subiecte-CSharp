-- Obtin tot continutul din tabela Clienti
-- * inseamna toate coloanele
SELECT * FROM Clienti;

-- obtin toate randurile
-- dar doar coloanele prenume si varsta
SELECT prenume, varsta FROM Clienti;

-- in loc sa obtin valori din coloane, 
-- pot obtine rezultatul unor expresii cu acele coloane
-- aici afisam pentru fiecare rand:
--   dublul id-ului
--   numele complet de forma 'nume prenume'
SELECT id * 2, nume + ' '+ prenume FROM Clienti;

-- pot sa dau si alte nume la coloane la momentul afisarii
-- mentionand aliasul dupa expresie/coloana 
-- sintaxa #1: exprColoana alias
-- sintaxa #2: exprColoana AS alias
SELECT id * 2 dubluId, nume + ' ' + prenume numeComplet
FROM Clienti;

-- Filtrare
-- folosind cuvantul where
-- sintaxa 
-- SELECT ... FROM numeTabel
-- WHERE CONDITIE 

-- am obtinut toti barbatii (sex M)
SELECT * 
FROM Clienti 
WHERE Sex = 'M';

-- toti clientii ce nu sunt Arhitect
SELECT *
FROM Clienti
WHERE Ocupatie <> 'Architect';


-- inserare
INSERT INTO Clienti
(Nume, Prenume, Ocupatie, Varsta, Sex)
VALUES ('Trandafirescu', 'Sabin', 'Vanzator', 33, 'M');

-- stergerea
-- ATENTIE - VA STERGE TOATE RANDURILE!!!
-- DELETE FROM clienti; 
DELETE FROM Clienti
WHERE Id = 113;

-- update (modificare valorilor)
-- Sintaxa:
-- UPDATE numeTabel
-- SET coloana1 = val1, coloana2 = val2 ...
-- WHERE conditie;
-- ATENTIE - Daca nu se mentioneaza 'WHERE' si conditia
-- atunci 'SET' va afecta toate randurile din acea coloana
-- Cerinta:
-- Vreau sa maresti varsta tuturor cu 10 ani
SELECT * FROM Clienti;

-- COMANDA de "imbatranire"
UPDATE Clienti
SET Varsta += 10;
-- vedem ca sunt mai batrani cu 10 ani
SELECT * FROM Clienti;

-- aici maresc varsta cu 10 ani doar la barbati
UPDATE Clienti
SET Varsta = Varsta + 10
where sex = 'M'