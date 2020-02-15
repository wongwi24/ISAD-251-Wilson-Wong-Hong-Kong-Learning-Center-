CREATE TABLE [dbo].[Category] (
    [ID]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Category] PRIMARY KEY CLUSTERED ([ID] ASC)
);

