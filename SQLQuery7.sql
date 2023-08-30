INSERT INTO Статус_Заказа(Вид)
VALUES('Принят'),
      ('В пути'),
      ('Завершен')
      
      
ALTER TABLE Пицца
 Add constraint DF_Пицца_Доступна_к_Заказу
  DEFAULT 1 FOR Доступна_к_Заказу   
  
  
CREATE PROCEDURE AddPizza
    @Name varchar(50),
    @Mass float,
    @Price money
AS
    INSERT INTO Пицца(Название, Масса, Цена)
    values (@Name, @Mass, @Price)
GO 

CREATE PROCEDURE EditPizza
	@id int,
    @Name varchar(50),
    @Mass float,
    @Price money,
    @AvailOrder bit 
AS
    UPDATE Пицца
    SET Название = @Name,
     Масса = @Mass,
     Цена = @Price,
     Доступна_к_Заказу = @AvailOrder
    WHERE Код_Пиццы = @id
GO


CREATE PROCEDURE AddDelvierman
    @Point varchar(50),
    @Surname varchar(50),
    @Name varchar(50),
    @Patron varchar(50)
AS
	DECLARE @idPoint int
	SET @idPoint = (SELECT Код_Пункта
	FROM Пункт
	WHERE Адрес = @Point)
    INSERT INTO Курьер(Пункт, Фамилия, Имя, Отчество)
    values (@idPoint, @Surname, @Name, @Patron)
GO 

CREATE PROCEDURE AddCustomer
    @Sur varchar(50),
    @Name varchar(50),
    @Patr varchar(50),
    @Phone varchar(50),
    @Adress varchar(100)
AS
    INSERT INTO Покупатель(Фамилия, Имя, Отчество, Телефон, Адрес)
    values (@Sur, @Name, @Patr, @Phone, @Adress)
GO 

INSERT INTO Доставка(Тип, Стоимость)
VALUES('Самовывоз', 0),
      ('Курьерская', 250)
  
  
CREATE PROCEDURE AddDiscount
    @Type varchar(50),
    @Persent float
AS
    INSERT INTO Скидка(Вид, Процент)
    values (@Type, @Persent)
GO  


CREATE PROCEDURE DeletePoint
    @IdPoint int
AS
	DELETE Пункт
	WHERE Код_Пункта = @IdPoint
GO 


CREATE PROCEDURE EditDelvierman
	@id int,
    @Point varchar(100),
    @Surname varchar(50),
    @Name varchar(50),
    @Patron varchar(50)
AS
	DECLARE @idPoint int
	SET @idPoint = (SELECT Код_Пункта
	FROM Пункт	
	WHERE Адрес = @Point)
    
    UPDATE Курьер
    SET Пункт = @idPoint,
		Фамилия = @Surname,
		Имя = @Name,
		Отчество = @Patron
    WHERE Код_Курьера = @id
GO 


CREATE PROCEDURE DeleteDelivman
    @IdMan int
AS
	DELETE Курьер
	WHERE Код_Курьера = @IdMan
GO 


CREATE PROCEDURE EditCustomer
	@id int,
    @Surname varchar(50),
    @Name varchar(50),
    @Patron varchar(50),
    @Phone varchar(50),
    @Adress varchar(100)
AS 
    UPDATE Покупатель
    SET Фамилия = @Surname,
		Имя= @Name,
		Отчество = @Patron,
		Телефон = @Phone,
		Адрес = @Adress
    WHERE Код_Покупателя = @id
GO 


CREATE PROCEDURE EditDiscount
	@id int,
    @DiscType varchar(50),
    @Persent float
AS 
    UPDATE Скидка
    SET Вид = @DiscType,
		Процент = @Persent
    WHERE Код_Скидки = @id
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
	SET @IdCust = (SELECT Код_Покупателя FROM Покупатель WHERE Покупатель.Фамилия = @Customer)	
	SET @IdDelivery = (SELECT Код_Доставки FROM Доставка WHERE Доставка.Тип = @Delivery)	
	SET @IdPoint = (SELECT Код_Пункта FROM Пункт WHERE Пункт.Адрес = @Point)	
	
	IF (EXISTS (SELECT Код_Скидки FROM Скидка WHERE Скидка.Вид = @Disc))
	BEGIN
		SET @IdDisc = (SELECT Код_Скидки FROM Скидка WHERE Скидка.Вид = @Disc)	
		INSERT INTO Заказ(Сумма, Покупатель, Доставка, Пункт, Статус, Скидка, Дата_Заказа)
		VALUES (0, @IdCust, @IdDelivery, @IdPoint, 1, @IdDisc, GETDATE())	
	END
	ELSE
		INSERT INTO Заказ(Сумма, Покупатель, Доставка, Пункт, Статус, Дата_Заказа)
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
	SET @IdPizza = (SELECT Код_Пиццы FROM Пицца WHERE Пицца.Название = @Pizza)	
	
	INSERT INTO Пицца_в_Заказе(Зак_Номер, Пиц_Код_Пиццы, Количество)
	VALUES (@K, @IdPizza, @Number)
GO 


CREATE PROCEDURE AddOrder3
	@K int
AS 
	DECLARE @Summ money
	SET @Summ = (SELECT SUM(Пицца.Цена) FROM Пицца INNER JOIN Пицца_в_Заказе ON Пицца.Код_Пиццы = Пицца_в_Заказе.Пиц_Код_Пиццы WHERE Пицца_в_Заказе.Зак_Номер = @K)
	UPDATE Заказ
	SET Сумма = @Summ
	WHERE Номер = @K
GO 

CREATE PROCEDURE AddOrder4
	@K int,
	@Disc VarChar(50)
AS 
	DECLARE @PerDisc int
	SET @PerDisc = (SELECT Процент FROM Скидка WHERE Вид = @Disc)
	UPDATE Заказ
	SET Сумма = Сумма * (1-0.01*@PerDisc)
	WHERE Номер = @K
GO 

CREATE PROCEDURE AddOrder5
	@K int
AS 
	DECLARE @Delivery int
	SET @Delivery = (SELECT Доставка.Стоимость FROM Доставка INNER JOIN Заказ ON Доставка.Код_Доставки = Заказ.Доставка WHERE Заказ.Номер = @K)
	UPDATE Заказ
	SET Сумма = Сумма + @Delivery
	WHERE Номер = @K
GO 

CREATE TRIGGER DeletePizza ON Пицца
	INSTEAD OF DELETE
AS
	DECLARE @Piz int
	SELECT @Piz = Код_Пиццы
	FROM deleted
	IF (EXISTS (SELECT Пиц_Код_Пиццы FROM Пицца INNER JOIN Пицца_в_Заказе ON Пицца.Код_Пиццы = Пицца_в_Заказе.Пиц_Код_Пиццы
				WHERE Код_Пиццы = @Piz))
	BEGIN
		UPDATE Пицца 
		SET Доступна_к_Заказу = 0
	WHERE Код_Пиццы = @Piz
	END	
	ELSE
	DELETE FROM Пицца WHERE [Код_Пиццы] = @Piz			
GO	




