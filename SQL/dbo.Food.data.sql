SET IDENTITY_INSERT [dbo].[Food] ON
INSERT INTO [dbo].[Food] ([ID], [CategoryId], [Name], [Description], [Price], [FoodPictureUrl], [IsVisible]) VALUES (1, 1, N'Coke', N'Full of Gas', CAST(5.00 AS Decimal(18, 2)), N'\Content\image\coke.jpg', 1)
INSERT INTO [dbo].[Food] ([ID], [CategoryId], [Name], [Description], [Price], [FoodPictureUrl], [IsVisible]) VALUES (2, 2, N'Burger', N'Yummy', CAST(20.00 AS Decimal(18, 2)), N'\Content\image\burger.jpg', 1)
INSERT INTO [dbo].[Food] ([ID], [CategoryId], [Name], [Description], [Price], [FoodPictureUrl], [IsVisible]) VALUES (3, 1, N'Earl Grey Tea', N'Rich taste', CAST(10.00 AS Decimal(18, 2)), N'\Content\image\earlgrey.jpg', 1)
INSERT INTO [dbo].[Food] ([ID], [CategoryId], [Name], [Description], [Price], [FoodPictureUrl], [IsVisible]) VALUES (4, 1, N'Apple Juice', N'Really Fresh', CAST(8.00 AS Decimal(18, 2)), N'\Content\image\applejuice.jpg', 1)
INSERT INTO [dbo].[Food] ([ID], [CategoryId], [Name], [Description], [Price], [FoodPictureUrl], [IsVisible]) VALUES (7, 1, N'Rose Tea ', N'Sweet odour ', CAST(6.00 AS Decimal(18, 2)), N'\Content\image\rosetea.jpg', 1)
INSERT INTO [dbo].[Food] ([ID], [CategoryId], [Name], [Description], [Price], [FoodPictureUrl], [IsVisible]) VALUES (8, 2, N'Fish and Chips', N'Should definitely try', CAST(15.00 AS Decimal(18, 2)), N'\Content\image\fishnchips.jpg', 1)
INSERT INTO [dbo].[Food] ([ID], [CategoryId], [Name], [Description], [Price], [FoodPictureUrl], [IsVisible]) VALUES (10, 2, N'NY Cheese Cake', N'Cheesy!', CAST(11.00 AS Decimal(18, 2)), N'\Content\image\nycheesecake.jpg', 1)
SET IDENTITY_INSERT [dbo].[Food] OFF
