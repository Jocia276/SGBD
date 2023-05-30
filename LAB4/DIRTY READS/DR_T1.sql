use MagazinAlimentar

-- dirty reads

-- T1: UPDATE + DELAY + ROLLBACK

select *from Produs

BEGIN TRANSACTION
UPDATE Produs SET
pret=15 WHERE id_produs=71
WAITFOR DELAY '00:00:05'
ROLLBACK TRANSACTION

select *from Produs
