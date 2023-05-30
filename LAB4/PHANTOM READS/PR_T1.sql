use MagazinAlimentar
go

-- phantom reads

-- T1: DELAY + INSERT + COMMIT

BEGIN TRAN
WAITFOR DELAY '00:00:05'
INSERT INTO Produs VALUES ('conopida',13,2)
COMMIT TRAN