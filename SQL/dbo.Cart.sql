CREATE TABLE [dbo].[Cart] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [CartId]      NVARCHAR (MAX) NULL,
    [FoodId]      INT            NOT NULL,
    [Count]       INT            NOT NULL,
    [DateCreated] DATETIME       NOT NULL,
    CONSTRAINT [PK_dbo.Cart] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_dbo.Cart_dbo.Food_FoodId] FOREIGN KEY ([FoodId]) REFERENCES [dbo].[Food] ([ID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_FoodId]
    ON [dbo].[Cart]([FoodId] ASC);

