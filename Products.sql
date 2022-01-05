USE [MCComputerSolutionDb]
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [ProductName], [AvbQty], [Price], [IsDeleted], [SysCreatedBy], [SysCreatedOn], [SysDeletedBy], [SysDeletedOn], [SysUpdatedBy], [SysUpdatedOn]) VALUES (1, N'Mouse SM', 100, CAST(500.00 AS Decimal(18, 2)), 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Products] ([ProductId], [ProductName], [AvbQty], [Price], [IsDeleted], [SysCreatedBy], [SysCreatedOn], [SysDeletedBy], [SysDeletedOn], [SysUpdatedBy], [SysUpdatedOn]) VALUES (3, N'Keyboard Wired', 300, CAST(650.00 AS Decimal(18, 2)), 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Products] ([ProductId], [ProductName], [AvbQty], [Price], [IsDeleted], [SysCreatedBy], [SysCreatedOn], [SysDeletedBy], [SysDeletedOn], [SysUpdatedBy], [SysUpdatedOn]) VALUES (5, N'Combo Mouse HP', 400, CAST(45000.00 AS Decimal(18, 2)), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
