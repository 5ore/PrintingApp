

CREATE TABLE PrintLog (
ID INT PRIMARY KEY,
[Date/Time] DATETIME,
[Printer name] NVARCHAR(50),
black_A4 INT,
black_A3 INT,
black_total DECIMAL,
colored_A4 INT,
colored_A3 INT,
colored_total DECIMAL,
[Duplex pages] INT,
[Total price] DECIMAL
)

ALTER TABLE PrintLog ADD ID INT PRIMARY KEY;

DROP TABLE PrintLog;