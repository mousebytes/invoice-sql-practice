USE [InvoiceApp]
GO

IF COL_LENGTH('[dbo].[InvoiceItems]', '[Description]') IS NULL
BEGIN
    ALTER TABLE [dbo].[InvoiceItems]
    ADD [Description] VARCHAR(500)
END