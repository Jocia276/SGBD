use S12
go

SET DEADLOCK_PRIORITY HIGH
begin tran 
update Fructe set Denumire = 'tran2' where Fid=1
WAITFOR DELAY '00:00:10'
UPDATE SucuriNaturale SET Denumire = 'denum2' where Sid = 1
COMMIT TRAN


select *from Fructe 
select *from SucuriNaturale