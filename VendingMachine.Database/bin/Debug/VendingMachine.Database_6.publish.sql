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
PRINT N'The following operation was generated from a refactoring log file 64b54360-cc82-4138-95b0-c068aac8c9a7';

PRINT N'Rename [Machine].[Voorraad_Geld].[Hoeveelheid] to Valuta';


GO
EXECUTE sp_rename @objname = N'[Machine].[Voorraad_Geld].[Hoeveelheid]', @newname = N'Valuta', @objtype = N'COLUMN';


GO
-- Refactoring step to update target server with deployed transaction logs
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '64b54360-cc82-4138-95b0-c068aac8c9a7')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('64b54360-cc82-4138-95b0-c068aac8c9a7')

GO

GO
PRINT N'Update complete.';


GO
