CREATE TABLE [dbo].[Guests]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NCHAR(30) NOT NULL, 
    [LastName] NCHAR(30) NOT NULL, 
    [Addresses] NCHAR(50) NULL, 
    [PostCode] NCHAR(20) NULL, 
    [EmailAddress] NCHAR(50) NULL, 
    [PhoneNumber] NCHAR(50) NULL
)
