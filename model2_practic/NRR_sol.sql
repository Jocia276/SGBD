use Problema2
go


SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
SELECT *FROM Melodii
WAITFOR DELAY '00:00:10'
SELECT *FROM Melodii
COMMIT TRAN

select *from Melodii