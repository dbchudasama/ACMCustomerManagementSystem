CREATE TABLE [dbo].[Product] (
    [ProductId]          INT          IDENTITY (1, 1) NOT NULL,
    [ProductName]        VARCHAR (50) NOT NULL,
    [ProductDescription] VARCHAR (50) NOT NULL,
    [ProductPrice]       DECIMAL (18) NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([ProductId] ASC)
);

