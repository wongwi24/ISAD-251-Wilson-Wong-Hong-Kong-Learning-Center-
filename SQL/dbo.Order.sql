CREATE TABLE [dbo].[Order] (
    [OrderId]   INT             IDENTITY (1, 1) NOT NULL,
    [OrderDate] DATETIME        NOT NULL,
    [Username]  NVARCHAR (MAX)  NULL,
    [Total]     DECIMAL (18, 2) NOT NULL,
    [FirstName] NVARCHAR (255)  NOT NULL,
    [LastName]  NVARCHAR (255)  NOT NULL,
    [Phone]     NVARCHAR (20)   NOT NULL,
    CONSTRAINT [PK_dbo.Order] PRIMARY KEY CLUSTERED ([OrderId] ASC)
);

