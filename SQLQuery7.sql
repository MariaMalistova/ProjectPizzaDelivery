INSERT INTO ������_������(���)
VALUES('������'),
      ('� ����'),
      ('��������')
      
      
ALTER TABLE �����
 Add constraint DF_�����_��������_�_������
  DEFAULT 1 FOR ��������_�_������   
  
  
CREATE PROCEDURE AddPizza
    @Name varchar(50),
    @Mass float,
    @Price money
AS
    INSERT INTO �����(��������, �����, ����)
    values (@Name, @Mass, @Price)
GO 

CREATE PROCEDURE EditPizza
	@id int,
    @Name varchar(50),
    @Mass float,
    @Price money,
    @AvailOrder bit 
AS
    UPDATE �����
    SET �������� = @Name,
     ����� = @Mass,
     ���� = @Price,
     ��������_�_������ = @AvailOrder
    WHERE ���_����� = @id
GO


CREATE PROCEDURE AddDelvierman
    @Point varchar(50),
    @Surname varchar(50),
    @Name varchar(50),
    @Patron varchar(50)
AS
	DECLARE @idPoint int
	SET @idPoint = (SELECT ���_������
	FROM �����
	WHERE ����� = @Point)
    INSERT INTO ������(�����, �������, ���, ��������)
    values (@idPoint, @Surname, @Name, @Patron)
GO 

CREATE PROCEDURE AddCustomer
    @Sur varchar(50),
    @Name varchar(50),
    @Patr varchar(50),
    @Phone varchar(50),
    @Adress varchar(100)
AS
    INSERT INTO ����������(�������, ���, ��������, �������, �����)
    values (@Sur, @Name, @Patr, @Phone, @Adress)
GO 

INSERT INTO ��������(���, ���������)
VALUES('���������', 0),
      ('����������', 250)
  
  
CREATE PROCEDURE AddDiscount
    @Type varchar(50),
    @Persent float
AS
    INSERT INTO ������(���, �������)
    values (@Type, @Persent)
GO  


CREATE PROCEDURE DeletePoint
    @IdPoint int
AS
	DELETE �����
	WHERE ���_������ = @IdPoint
GO 


CREATE PROCEDURE EditDelvierman
	@id int,
    @Point varchar(100),
    @Surname varchar(50),
    @Name varchar(50),
    @Patron varchar(50)
AS
	DECLARE @idPoint int
	SET @idPoint = (SELECT ���_������
	FROM �����	
	WHERE ����� = @Point)
    
    UPDATE ������
    SET ����� = @idPoint,
		������� = @Surname,
		��� = @Name,
		�������� = @Patron
    WHERE ���_������� = @id
GO 


CREATE PROCEDURE DeleteDelivman
    @IdMan int
AS
	DELETE ������
	WHERE ���_������� = @IdMan
GO 


CREATE PROCEDURE EditCustomer
	@id int,
    @Surname varchar(50),
    @Name varchar(50),
    @Patron varchar(50),
    @Phone varchar(50),
    @Adress varchar(100)
AS 
    UPDATE ����������
    SET ������� = @Surname,
		���= @Name,
		�������� = @Patron,
		������� = @Phone,
		����� = @Adress
    WHERE ���_���������� = @id
GO 


CREATE PROCEDURE EditDiscount
	@id int,
    @DiscType varchar(50),
    @Persent float
AS 
    UPDATE ������
    SET ��� = @DiscType,
		������� = @Persent
    WHERE ���_������ = @id
GO 
------------
ALTER PROCEDURE AddOrder
	@Customer varchar(50),
    @DelivMan varchar(50),
    @Delivery varchar(50),
    @Point varchar(100),
    @Disc varchar(50)   
AS 
	DECLARE @IdCust int, @IdDelivMan int, @IdDelivery int, @IdPoint int, @IdDisc int, @K int
	SET @IdCust = (SELECT ���_���������� FROM ���������� WHERE ����������.������� = @Customer)	
	SET @IdDelivery = (SELECT ���_�������� FROM �������� WHERE ��������.��� = @Delivery)	
	SET @IdPoint = (SELECT ���_������ FROM ����� WHERE �����.����� = @Point)	
	
	IF (EXISTS (SELECT ���_������ FROM ������ WHERE ������.��� = @Disc))
	BEGIN
		SET @IdDisc = (SELECT ���_������ FROM ������ WHERE ������.��� = @Disc)	
		INSERT INTO �����(�����, ����������, ��������, �����, ������, ������, ����_������)
		VALUES (0, @IdCust, @IdDelivery, @IdPoint, 1, @IdDisc, GETDATE())	
	END
	ELSE
		INSERT INTO �����(�����, ����������, ��������, �����, ������, ����_������)
		VALUES (0, @IdCust, @IdDelivery, @IdPoint, 1, GETDATE())	

	SET @K = @@IDENTITY	
	RETURN @K
	
GO 


CREATE PROCEDURE AddOrder2
	@K int,
    @Pizza varchar(50),
    @Number int  
AS 
	DECLARE @IdPizza int
	SET @IdPizza = (SELECT ���_����� FROM ����� WHERE �����.�������� = @Pizza)	
	
	INSERT INTO �����_�_������(���_�����, ���_���_�����, ����������)
	VALUES (@K, @IdPizza, @Number)
GO 


CREATE PROCEDURE AddOrder3
	@K int
AS 
	DECLARE @Summ money
	SET @Summ = (SELECT SUM(�����.����) FROM ����� INNER JOIN �����_�_������ ON �����.���_����� = �����_�_������.���_���_����� WHERE �����_�_������.���_����� = @K)
	UPDATE �����
	SET ����� = @Summ
	WHERE ����� = @K
GO 

CREATE PROCEDURE AddOrder4
	@K int,
	@Disc VarChar(50)
AS 
	DECLARE @PerDisc int
	SET @PerDisc = (SELECT ������� FROM ������ WHERE ��� = @Disc)
	UPDATE �����
	SET ����� = ����� * (1-0.01*@PerDisc)
	WHERE ����� = @K
GO 

CREATE PROCEDURE AddOrder5
	@K int
AS 
	DECLARE @Delivery int
	SET @Delivery = (SELECT ��������.��������� FROM �������� INNER JOIN ����� ON ��������.���_�������� = �����.�������� WHERE �����.����� = @K)
	UPDATE �����
	SET ����� = ����� + @Delivery
	WHERE ����� = @K
GO 

CREATE TRIGGER DeletePizza ON �����
	INSTEAD OF DELETE
AS
	DECLARE @Piz int
	SELECT @Piz = ���_�����
	FROM deleted
	IF (EXISTS (SELECT ���_���_����� FROM ����� INNER JOIN �����_�_������ ON �����.���_����� = �����_�_������.���_���_�����
				WHERE ���_����� = @Piz))
	BEGIN
		UPDATE ����� 
		SET ��������_�_������ = 0
	WHERE ���_����� = @Piz
	END	
	ELSE
	DELETE FROM ����� WHERE [���_�����] = @Piz			
GO	




