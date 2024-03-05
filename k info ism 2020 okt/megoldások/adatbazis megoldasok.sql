-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

-- 10. feladat:
CREATE DATABASE tisza DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;

-- 12. feladat:
DELETE FROM meres WHERE nap = '2020-03-27';

-- 13. feladat:
UPDATE vizmerce SET igId = '2' WHERE varos LIKE 'Tokaj';

-- 14. feladat:
SELECT varos, MIN(nullPont) AS 'nullPont' FROM vizmerce;

-- 15. feladat:
SELECT varos, (lnv - lkv) AS 'ingadozas' FROM vizmerce ORDER BY ingadozas DESC
 
-- 16. feladat:
SELECT nev, COUNT(vizmerce.id) AS 'merceszam' FROM igazgatosag INNER JOIN vizmerce ON igazgatosag.id = vizmerce.igId GROUP BY nev;
  
-- 17. feladat:
SELECT AVG(vizAllas) FROM vizmerce INNER JOIN meres ON vizmerce.id = meres.vmId WHERE MONTH(nap) = 4 AND varos = 'Szolnok';
