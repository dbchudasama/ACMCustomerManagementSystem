CREATE TABLE [dbo].[Order] (
    [OrderId]       INT                IDENTITY (1, 1) NOT NULL,
    [CustomerId]    INT                NOT NULL,
    [AddressId]     INT                NOT NULL,
    [OrderDate]     DATETIMEOFFSET (7) NOT NULL,
    [OrderItems]    VARCHAR (50)       NOT NULL,
    [OrderQuantity] INT                NOT NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([OrderId] ASC)
);

