CREATE TABLE [dbo].[Student]
(
	[StudentID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StudentFName] NVARCHAR(50) NOT NULL, 
    [StudentLName] NVARCHAR(50) NOT NULL, 
    [EmergencyContactInfo] NVARCHAR(50) NULL, 
    [AddressNum] INT NOT NULL, 
    [AddressStreetName] NVARCHAR(50) NOT NULL, 
    [AddressOptional] NVARCHAR(50) NULL, 
    [PostalCode] NVARCHAR(50) NOT NULL, 
    [City] NVARCHAR(50) NOT NULL, 
    [Country] NVARCHAR(50) NOT NULL, 
    [PhoneNum] NVARCHAR(50) NOT NULL
)
