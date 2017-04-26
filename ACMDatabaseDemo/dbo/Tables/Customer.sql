CREATE TABLE [dbo].[Customer] (
    [CustomerId]   INT          IDENTITY (1, 1) NOT NULL,
    [CustomerType] INT          NOT NULL,
    [FirstName]    VARCHAR (50) NOT NULL,
    [LastName]     VARCHAR (50) NOT NULL,
    [EmailAddress] VARCHAR (50) NOT NULL,
    [Address]      VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

