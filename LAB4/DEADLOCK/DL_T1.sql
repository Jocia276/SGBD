use MagazinAlimentar
go

--deadlock

--T1: UPDATE ON TABLE Produs + DELAY + UPDATE ON TABLE Producator
BEGIN TRAN
UPDATE Produs SET denumire = 'denum 1' where id_produs = 73 
-- this transaction has exclusively lock on table Produs
WAITFOR DELAY '00:00:10'
UPDATE Producator SET nume='tran 1' where id_producator=1
COMMIT TRAN

select *from Produs
select *from Producator