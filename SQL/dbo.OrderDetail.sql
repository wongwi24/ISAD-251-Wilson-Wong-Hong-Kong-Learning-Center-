CREATE TABLE [dbo].[OrderDetail] (
    [OrderDetailId] INT             IDENTITY (1, 1) NOT NULL,
    [OrderId]       INT             NOT NULL,
    [FoodId]        INT             NOT NULL,
    [OrderQty]      INT             NOT NULL,
    [UnitPrice]     DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_dbo.OrderDetail] PRIMARY KEY CLUSTERED ([OrderDetailId] ASC),
    CONSTRAINT [FK_dbo.OrderDetail_dbo.Food_FoodId] FOREIGN KEY ([FoodId]) REFERENCES [dbo].[Food] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.OrderDetail_dbo.Order_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([OrderId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_OrderId]
    ON [dbo].[OrderDetail]([OrderId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FoodId]
    ON [dbo].[OrderDetail]([FoodId] ASC);

