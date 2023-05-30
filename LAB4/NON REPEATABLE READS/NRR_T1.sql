use MagazinAlimentar
go

-- T1: DELAY + UPDATE + COMMIT

select *from Produs

INSERT INTO Produs(denumire, pret) VALUES
('pizza', 70)
begin tran
WAITFOR DELAY '00:00:05'
UPDATE Produs SET pret=30 WHERE
denumire = 'pizza'
COMMIT TRAN

select *from Produs
