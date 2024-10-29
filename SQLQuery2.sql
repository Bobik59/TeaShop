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

INSERT INTO Type (Name) VALUES
(N'Зеленый'),
(N'Черный'),
(N'Белый'),
(N'Жёлтый');

INSERT INTO Country (Name) VALUES
(N'Китай'),
(N'Индия'),
(N'Шри-Ланка');

INSERT INTO Tea (Name, TypeId, CountryId, Description, QuantityGrams, CostPrice) VALUES
(N'Зеленый Дракон', 1, 1, N'Вкусный чай с нотками вишни', 200, 15.50),
(N'Чёрный Жемчуг', 2, 2, N'Чёрный чай без добавок', 100, 10.00),
(N'Белый Лотос', 3, 1, N'Лёгкий белый чай с ароматом вишни', 150, 20.00),
(N'Жёлтый Бамбук', 4, 3, N'Изысканный жёлтый чай', 80, 25.00),
(N'Зеленый Жасмин', 1, 2, N'Свежий зеленый чай с жасмином', 250, 12.00),
(N'Чёрный Ассам', 2, 2, N'Крепкий чай', 300, 8.50),
(N'Белый Пион', 3, 1, N'Мягкий белый чай', 120, 18.00),
(N'Жёлтый Император', 4, 3, N'Роскошный чай с золотистым оттенком', 90, 30.00);