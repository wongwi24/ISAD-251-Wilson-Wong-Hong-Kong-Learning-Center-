SET IDENTITY_INSERT [dbo].[OrderDetail] ON
INSERT INTO [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [FoodId], [OrderQty], [UnitPrice]) VALUES (44, 23, 4, 1, CAST(8.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [FoodId], [OrderQty], [UnitPrice]) VALUES (45, 23, 2, 2, CAST(20.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [FoodId], [OrderQty], [UnitPrice]) VALUES (46, 24, 4, 1, CAST(8.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [FoodId], [OrderQty], [UnitPrice]) VALUES (47, 24, 2, 1, CAST(20.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
