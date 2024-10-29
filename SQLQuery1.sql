---- Таблица для видов чая
--CREATE TABLE Type (
--    Id INT PRIMARY KEY IDENTITY(1,1),
--    Name NVARCHAR(50) NOT NULL
--);

---- Таблица для стран происхождения
--CREATE TABLE Country (
--    Id INT PRIMARY KEY IDENTITY(1,1),
--    Name NVARCHAR(100) NOT NULL
--);

---- Таблица для чая
--CREATE TABLE Tea (
--    Id INT PRIMARY KEY IDENTITY(1,1),
--    Name NVARCHAR(100) NOT NULL,
--    TypeId INT FOREIGN KEY REFERENCES Type(Id),
--    CountryId INT FOREIGN KEY REFERENCES Country(Id),
--    Description NVARCHAR(255),
--    QuantityGrams INT,
--    CostPrice DECIMAL(10, 2)
--);

--INSERT INTO Type (Name) VALUES
--('Зеленый'),
--('Черный'),
--('Белый'),
--('Жёлтый');

--INSERT INTO Country (Name) VALUES
--('Китай'),
--('Индия'),
--('Шри-Ланка');

--INSERT INTO Tea (Name, TypeId, CountryId, Description, QuantityGrams, CostPrice) VALUES
--('Зеленый Дракон', 1, 1, 'Вкусный чай с нотками вишни', 200, 15.50),
--('Чёрный Жемчуг', 2, 2, 'Чёрный чай без добавок', 100, 10.00),
--('Белый Лотос', 3, 1, 'Лёгкий белый чай с ароматом вишни', 150, 20.00),
--('Жёлтый Бамбук', 4, 3, 'Изысканный жёлтый чай', 80, 25.00),
--('Зеленый Жасмин', 1, 2, 'Свежий зеленый чай с жасмином', 250, 12.00),
--('Чёрный Ассам', 2, 2, 'Крепкий чай', 300, 8.50),
--('Белый Пион', 3, 1, 'Мягкий белый чай', 120, 18.00),
--('Жёлтый Император', 4, 3, 'Роскошный чай с золотистым оттенком', 90, 30.00);

SELECT * FROM Tea
WHERE CostPrice BETWEEN 20 AND 25