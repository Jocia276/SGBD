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

-- procedura stocata pentru introducerea de produs, producator si de date in tabelul de legatura
-- daca nu se pot introduce date in unul din cele 3 tabele, se va realiza rollback

CREATE OR ALTER PROCEDURE InsertProdusProducator 
@denumire varchar(50),@pret int,@id_cat int,
@nume varchar(50),@adresa varchar(50),
@d_prod date,@d_exp date
AS
BEGIN
BEGIN TRAN
BEGIN TRY
	if(dbo.validate_pret(@pret)!=1)
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
	if(dbo.validate_name(@nume)<>1)
		begin
			RAISERROR('Numele trebuie sa fie format doar din litere',14,1)
		end
	if(dbo.validate_adress(@adresa)<>1)
		begin
			RAISERROR('Adresa trebuie sa fie formata doar din litere',14,1)
		end
	if(dbo.validate_date(@d_prod)<>1)
		begin
			RAISERROR('Data invalida!',14,1)
		end
	if(dbo.validate_date(@d_exp)<>1)
		begin
			RAISERROR('Data invalida!',14,1)
		end

    INSERT INTO Produs values(@denumire, @pret, @id_cat)
	select 'Produsul a fost adaugat!'
    INSERT INTO Producator values(@nume, @adresa)
	select 'Producatorul a fost adaugat'
 
	declare @id_produs int 
	set @id_produs = (SELECT IDENT_CURRENT('Produs'))
	declare @id_producator int
	set @id_producator = (SELECT IDENT_CURRENT('Producator'))

	INSERT INTO Producator_Produs values(@id_producator,@id_produs,@d_prod,@d_exp)
	select 'Au fost introduse datele in tabelul de legatura!'

	commit tran
	select 'Tranzactia a fost efectuata cu succes!'

end try
begin catch
DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE()
			rollback tran
			select 'Transaction rollbacked'
			SELECT @ErrorMessage as ERROR
end catch
end


-- merge OK

select *from Produs
select *from Producator
select *from Producator_Produs
exec InsertProdusProducator portocala,25,1,AGR,'Strada fericirii','2022-05-06','2025-05-07'
select *from Produs
select *from Producator
select *from Producator_Produs

-- rollback

select *from Produs
select *from Producator
select *from Producator_Produs
exec InsertProdusProducator portocale,-25,1,AGR,'Strada fericirii','2022-05-06','2025-05-07'
select *from Produs
select *from Producator
select *from Producator_Produs