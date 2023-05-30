use MagazinAlimentar
go

-- functie pentru validarea id-ului categoriei din care face parte produsul
-- id-ul trebuie sa fie un numar pozitiv
-- returneaza 1 daca id-ul este valid, 0 altfel
CREATE OR ALTER FUNCTION validate_id_cat( @id_cat int)
 RETURNS INT 
 BEGIN
 DECLARE @valid INT
 SET @valid = 1
 IF (@id_cat < 0) SET @valid = 0
 RETURN @valid
 END
go

-- functie pentru validarea numelui; acesta poate fi format doar din litere
-- returneaza 1 daca numele este valid, 0 altfel
 CREATE or ALTER FUNCTION validate_name( @name varchar(50))
 RETURNS int 
 BEGIN
 DECLARE @valid int
 SET @valid = 1
 IF (@name NOT LIKE '%[a-zA-Z]') SET @valid = 0
 RETURN @valid
 END
 go

 -- functie care valideaza adresa; aceasta poate fi formata doar din litere si cifre
 -- returneaza 1 data adresa este valida, 0 altfel
 CREATE or ALTER FUNCTION validate_adress( @adress varchar(50))
 RETURNS int 
 BEGIN
 DECLARE @valid int
 SET @valid = 1
 IF (@adress NOT LIKE '%[0-9a-zA-Z]') SET @valid = 0
 RETURN @valid
 END
 go

 -- functie care valideaza pretul; acesta trebuie sa fie un numar pozitiv
 -- returneaza 1 daca pretul este valid, 0 altfel
 CREATE or ALTER FUNCTION validate_pret( @pret int)
 RETURNS INT
 BEGIN
 DECLARE @valid INT
 SET @valid = 1
 IF (@pret < 0) SET @valid = 0
 RETURN @valid
 END
 go

--functie care verifica daca data introdusa este valida
--retuneaza 1 daca data este valida, 0 altfel
CREATE or Alter FUNCTION validate_date (@date date)
RETURNS INT
BEGIN
DECLARE @valid int
SET @valid=1
declare @val_date varchar(50)
set @val_date = convert(varchar(50), @date)
IF (ISDATE(@val_date)!=1) set @valid = 0;
return @valid
end
go

-- procedura pentru adaugarea unui produs
-- daca produsul esta valid, el este inserat in tabel
-- daca produsul NU este valid, se realizeaza rollback
CREATE or ALTER PROCEDURE AddProd @denumire varchar(50), @pret int, @id_cat int 
AS
BEGIN
set nocount on

BEGIN TRAN
BEGIN TRY
	if(dbo.validate_pret(@pret)<>1)
		begin
			RAISERROR('Pretul trebuie sa fie pozitiv',14,1)
		end
	if(dbo.validate_name(@denumire)<>1)
		begin
			RAISERROR('Denumirea trebuie sa fie formata doar din litere',14,1)
		end
	if(dbo.validate_id_cat(@id_cat)<>1)
		begin
			RAISERROR('Id-ul categoriei din care face parte produsul trebuie sa fie pozitiv', 14, 1)
		end
	INSERT INTO Produs values(@denumire, @pret, @id_cat)
	COMMIT TRAN
	SELECT 'Tranzactie efectuata cu succes!' as Status_Produs
END TRY

BEGIN CATCH
DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE()
ROLLBACK TRAN
SELECT 'Transaction rollbacked'
SELECT @ErrorMessage as ERROR
END CATCH
END
go

-- rollback, eroare
select *from Produs
exec AddProd a78,23,1 
select *from Produs

-- merge ok
select *from Produs
exec AddProd 'miere de albine',25,1
select *from Produs

go

--procedura stocata pentru adaugarea unui producator
--daca producatorul este valid, acesta se introduce in tabel
--daca producatroul NU este valid, se realizarea rollback
CREATE or ALTER PROCEDURE AddProducator @nume varchar(50), @adresa varchar(50) AS
BEGIN
BEGIN TRAN
BEGIN TRY
	if(dbo.validate_name(@nume) <> 1)
		begin
			RAISERROR('Numele trebuie sa fie format doar din litere',14,1)
		end
	if(dbo.validate_adress(@adresa) <> 1)
		begin
			RAISERROR('Adresa trebuie sa fie formata doar din litere',14,1)
		end
	INSERT INTO Producator values(@nume, @adresa)
	COMMIT TRAN
	SELECT 'Tranzactie efectuata cu succes!' AS Status_Producator
END TRY

BEGIN CATCH
DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE()
	ROLLBACK TRAN
	SELECT 'Transaction rollbacked'
	SELECT @ErrorMessage as ERROR
END CATCH
END

--merge OK

select *from Producator
exec AddProducator FructeLegumeSRL, 'Str trandafirului nr 2'
select *from Producator

--rollback

select *from Producator
exec AddProducator Fructe2324, 'adresa 1'
select *from Producator


go
-- procedura pentru a adauga date de legatura intre Produs si Producator
CREATE or ALTER PROCEDURE AddProducatorProdus @d_producere date, @d_expirare date AS
BEGIN
BEGIN TRAN
BEGIN TRY
	if(dbo.validate_date(@d_producere) <> 1)
		begin
			RAISERROR('Data invalida!',14,1)
		end
	if(dbo.validate_date(@d_expirare) <> 1)
		begin
			RAISERROR('Data invalida!',14,1)
		end

	declare @id_produs int 
	set @id_produs = (SELECT IDENT_CURRENT('Produs'))
	declare @id_producator int
	set @id_producator = (SELECT IDENT_CURRENT('Producator'))

	INSERT INTO Producator_Produs values(@id_producator,@id_produs,@d_producere,@d_expirare)
	COMMIT TRAN
	SELECT 'Tranzactie efectuata cu succes!' AS Status_Producator_Produs
END TRY

BEGIN CATCH
DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE()
	ROLLBACK TRAN
	SELECT 'Transaction rollbacked'
	SELECT @ErrorMessage as ERROR
END CATCH
END


GO
CREATE OR ALTER PROCEDURE AddProdProd 
@denumire varchar(50),@pret int, @id_cat int, 
@nume varchar(50),@adresa varchar(50),
@d_producere date, @d_exp date
AS BEGIN
	declare @produs int
	execute @produs = AddProd @denumire,@pret,@id_cat
	if(@produs <> 1)
		begin
		declare @producator int
		execute @producator = AddProducator @nume,@adresa
		if(@producator <> 1)
			execute AddProducatorProdus @d_producere, @d_exp
		end	
END

exec AddProdProd banane,25,1,bananier,abc,'2022-05-06','2025-05-07'
exec AddProdProd bananeee45,25,1,bananieeer,abc,'2022-05-06','2025-05-07'
select *from Producator
select *from Produs
select *from Producator_Produs

-- insereaza ok

select *from Produs
select *from Producator
select *from Producator_Produs
exec AddProdProd prune,15,2,FructeSRL,'Str Principala nr 5','2022-05-06','2025-05-07'
select *from Produs
select *from Producator
select *from Producator_Produs

-- rollback

-- eroare la produs
select *from Produs
select *from Producator
select *from Producator_Produs
exec AddProdProd ardei,-15,2,LegumeSRL,'Str Principala nr 5','2022-05-06','2025-05-07'
select *from Produs
select *from Producator
select *from Producator_Produs

--eroare la producator
select *from Produs
select *from Producator
select *from Producator_Produs
exec AddProdProd ardei,15,2,LegumeSRL3224,'Str Principala nr 5','2022-05-06','2025-05-07'
select *from Produs
select *from Producator
select *from Producator_Produs