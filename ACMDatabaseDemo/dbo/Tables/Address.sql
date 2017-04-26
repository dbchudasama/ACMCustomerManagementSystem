CREATE TABLE [dbo].[Address] (
    [AddressId]   INT          IDENTITY (1, 1) NOT NULL,
    [AddressType] INT          NOT NULL,
    [Street]      VARCHAR (50) NOT NULL,
    [City]        VARCHAR (50) NOT NULL,
    [State]       VARCHAR (50) NOT NULL,
    [PostCode]    VARCHAR (50) NOT NULL,
    [Country]     VARCHAR (50) NOT NULL,
    [CustomerId] INT NOT NULL, 
    CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED ([AddressId] ASC)
);

