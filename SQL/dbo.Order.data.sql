SET IDENTITY_INSERT [dbo].[Order] ON
INSERT INTO [dbo].[Order] ([OrderId], [OrderDate], [Username], [Total], [FirstName], [LastName], [Phone]) VALUES (23, N'2020-02-15 09:32:23', N'guest@outlook.com', CAST(48.00 AS Decimal(18, 2)), N'Peter', N'Park', N'93466600')
INSERT INTO [dbo].[Order] ([OrderId], [OrderDate], [Username], [Total], [FirstName], [LastName], [Phone]) VALUES (24, N'2020-02-16 12:32:23', N'guest@outlook.com', CAST(28.00 AS Decimal(18, 2)), N'Sam', N'Fisher', N'97632110')
SET IDENTITY_INSERT [dbo].[Order] OFF
