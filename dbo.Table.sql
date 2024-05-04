CREATE TABLE [dbo].[Teacher]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Salary] FLOAT NULL, 
    [Subject1] VARCHAR(50) NULL, 
    [Subject2] VARCHAR(50) NULL, 
    [Person_Id] INT NOT NULL, 
    CONSTRAINT [FK_Teacher_ToTable] FOREIGN KEY ([Person_Id]) REFERENCES [Person]([Id])
)
