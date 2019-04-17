CREATE TABLE [Machine].[Bestellingen]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Bedrag] DECIMAL(5) NOT NULL, 
    [Product_Id] INT NOT NULL, 
    [Datum] TIMESTAMP NULL
	CONSTRAINT [FK_Bestellingen_Producten] FOREIGN KEY ([Product_Id]) REFERENCES [Machine].[Producten]([Id])
)
