CREATE TABLE [dbo].[Invoices Detail]
(
	[InvID] INT NOT NULL , 
    [ProdID] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Total Product Cost] MONEY NOT NULL, 
    PRIMARY KEY ([InvID], [ProdID]), 
    CONSTRAINT [InvID to InvID] FOREIGN KEY ([InvID]) REFERENCES [Invoice]([InvID]), 
    CONSTRAINT [ProdID to ProdID] FOREIGN KEY ([ProdID]) REFERENCES [Products]([ProdID]), 
	
)
