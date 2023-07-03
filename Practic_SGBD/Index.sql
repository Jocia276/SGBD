use S12


SELECT Denumire,PretMediu FROM Fructe WHERE PretMediu>10;
GO
CREATE INDEX IX_Fructe ON Fructe
(Denumire ASC, PretMediu ASC);
GO
--planul de executie contine acum un index seek pe indexul nonclustered
SELECT Denumire, PretMediu FROM Fructe WHERE PretMediu>10;
GO