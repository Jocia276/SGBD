use S12
go

--deadlock

--T1: UPDATE ON TABLE Produs + DELAY + UPDATE ON TABLE Producator
BEGIN TRAN
UPDATE SucuriNaturale SET Denumire = 'denum 1' where Sid = 1 
-- this transaction has exclusively lock on table Produs
WAITFOR DELAY '00:00:10'
UPDATE Fructe SET Denumire='tran 1' where Fid = 1
COMMIT TRAN

select *from SucuriNaturale
select *from Fructe