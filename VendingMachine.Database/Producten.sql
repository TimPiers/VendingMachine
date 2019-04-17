CREATE TABLE [Machine].[Producten]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Naam] NVARCHAR(50) NOT NULL, 
    [Prijs] DECIMAL(5) NOT NULL, 
    [Afbeelding] IMAGE NULL
)
