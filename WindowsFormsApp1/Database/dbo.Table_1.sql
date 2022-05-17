CREATE TABLE [dbo].[Products]
(
	[ProdID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(50) NULL, 
    [Cost] MONEY NULL, 
    [Product Type] NVARCHAR(50) NULL
)
