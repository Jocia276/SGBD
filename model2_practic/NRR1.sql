use Problema2
go

-- T1: DELAY + UPDATE + COMMIT

select *from Melodii

INSERT INTO Melodii(titlu, an_lansare, durata, cod_artist) VALUES
('dangerous', 2006, '00:04:04', 2)
begin tran
WAITFOR DELAY '00:00:05'
UPDATE Melodii SET an_lansare=2010 WHERE
titlu = 'dangerous'
COMMIT TRAN

select *from Melodii