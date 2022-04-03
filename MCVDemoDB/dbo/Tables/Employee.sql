CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL identity(1,1) PRIMARY KEY, 
    [EmployeeId] NCHAR(10) NOT NULL, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [EmailAddress] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL
)
