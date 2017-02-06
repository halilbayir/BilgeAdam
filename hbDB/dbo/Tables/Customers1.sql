CREATE TABLE [dbo].[Customers1] (
    [CustomerId]   INT            IDENTITY (1, 1) NOT NULL,
    [CustomerName] NVARCHAR (25)  NULL,
    [ContactName]  NVARCHAR (25)  NULL,
    [Adress]       NVARCHAR (100) NULL,
    [City]         NCHAR (20)     NULL,
    [PostalCode]   INT            NULL,
    [Country]      NCHAR (20)     NULL,
    CONSTRAINT [PK_Customers1] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

