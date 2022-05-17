CREATE TABLE [dbo].[Invoice] (
    [InvID]             INT      NOT NULL,
    [PerID]             INT      NULL,
    [Date Of Invoice]   DATETIME NULL,
    [Amount Of Product] INT      NULL,
    [Is Paid For]       BIT      NULL,
    [Total Cost]        MONEY    NULL,
    PRIMARY KEY CLUSTERED ([InvID] ASC),
    FOREIGN KEY ([PerID]) REFERENCES [dbo].[Person] ([PerID])
);

