USE [InvoiceApp]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET NOCOUNT ON
GO

CREATE OR ALTER PROCEDURE spCustomer_Add
(
    @PK_Customer AS INT,
    @Tenant_PK AS INT,
    @FirstName AS VARCHAR(100),
    @LastName AS VARCHAR(100),
    @Street AS VARCHAR(100),
    @City AS VARCHAR(100),
    @State AS VARCHAR(2)
)
AS
    INSERT INTO [dbo].[Customers]
    (
        [Tenant_PK],
        [FirstName],
        [LastName],
        [Street],
        [City],
        [State]
    )
    VALUES
    (
        @Tenant_PK,
        @FirstName,
        @LastName,
        @Street,
        @City,
        @State
    )
GO