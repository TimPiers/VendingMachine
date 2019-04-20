﻿/*
Deployment script for VendingMachine

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "VendingMachine"
:setvar DefaultFilePrefix "VendingMachine"
:setvar DefaultDataPath "C:\Users\admin\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\SoftwareDevelopment"
:setvar DefaultLogPath "C:\Users\admin\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\SoftwareDevelopment"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'The following operation was generated from a refactoring log file 059822ee-53fb-425e-9935-c5790d985348';

PRINT N'Rename [Machine].[Voorraad_Geld].[Hoeveelheden] to Hoeveelheid';


GO
EXECUTE sp_rename @objname = N'[Machine].[Voorraad_Geld].[Hoeveelheden]', @newname = N'Hoeveelheid', @objtype = N'COLUMN';


GO
PRINT N'Altering [Machine].[Producten]...';


GO
ALTER TABLE [Machine].[Producten] ALTER COLUMN [Prijs] FLOAT (53) NOT NULL;


GO
PRINT N'Altering [Machine].[Voorraad_Geld]...';


GO
ALTER TABLE [Machine].[Voorraad_Geld] ALTER COLUMN [Hoeveelheid] FLOAT (53) NOT NULL;


GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '059822ee-53fb-425e-9935-c5790d985348')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('059822ee-53fb-425e-9935-c5790d985348')

GO

GO
PRINT N'Update complete.';


GO
