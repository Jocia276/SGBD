USE MagazinAlimentar
go

-- T2: UPDATE ON TABLE Producator + DELAY + UPDATE ON TABLE Produs

begin tran 
update Producator set nume = 'tran2' where id_producator=1
WAITFOR DELAY '00:00:10'
UPDATE Produs SET denumire = 'denum2' where id_produs = 73
COMMIT TRAN

select *from Produs 
select *from Producator