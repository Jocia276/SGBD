use MagazinAlimentar
go

SET DEADLOCK_PRIORITY HIGH
begin tran 
update Producator set nume = 'tran2' where id_producator=1
WAITFOR DELAY '00:00:10'
UPDATE Produs SET denumire = 'denum2' where id_produs = 73
COMMIT TRAN


SELECT *FROM Produs
select *from Producator