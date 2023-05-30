--control + M pentru a afisa planul de executie
use Problema2

SELECT titlu, an_lansare FROM Melodii WHERE an_lansare=2007;
GO
CREATE INDEX IX_Briose_an_lansare_asc_titlu_asc ON Melodii
(an_lansare ASC, titlu ASC);
GO
--planul de executie contine acum un index seek pe indexul nonclustered
SELECT titlu, an_lansare FROM Melodii WHERE an_lansare=2007;
GO