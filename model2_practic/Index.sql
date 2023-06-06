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


--Scopul acestui index este de a optimiza căutările bazate pe aceste două coloane. 
--Indexul facilitează găsirea rapidă a înregistrărilor care corespund criteriilor de căutare specifice.
--Cu toate acestea, de data aceasta, după crearea indexului, interogarea beneficiază de indexul nou creat. 
--Aceasta înseamnă că căutarea înregistrărilor cu an_lansare 2007 se va realiza mai eficient, deoarece se va face un "index seek" 
--             (căutare în index), care este mai rapid decât o căutare completă a tuturor înregistrărilor din tabel.
--În concluzie, prin crearea indexului, se optimizează căutările în baza de date, facilitând găsirea rapidă a datelor care corespund criteriilor de căutare specificate.