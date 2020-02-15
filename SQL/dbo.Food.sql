CREATE TABLE [dbo].[Food] (
    [ID]             INT             IDENTITY (1, 1) NOT NULL,
    [CategoryId]     INT             NOT NULL,
    [Name]           NVARCHAR (255)  NOT NULL,
    [Description]    NVARCHAR (2000) NULL,
    [Price]          DECIMAL (18, 2) NOT NULL,
    [FoodPictureUrl] NVARCHAR (1024) NULL,
    [IsVisible]      BIT             DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_dbo.Food] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_dbo.Food_dbo.Category_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([ID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_CategoryId]
    ON [dbo].[Food]([CategoryId] ASC);

