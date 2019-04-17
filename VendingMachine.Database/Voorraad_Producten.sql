CREATE TABLE [Machine].[Voorraad_Producten]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Product_Id] INT NOT NULL, 
    [Kwantiteit] INT NOT NULL, 
    CONSTRAINT [FK_Voorraad_Producten_Producten] FOREIGN KEY ([Product_Id]) REFERENCES [Machine].[Producten]([Id])
)
