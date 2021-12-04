CREATE TABLE [dbo].[tblStudent] (
    [StudentID]            INT           IDENTITY (1, 1) NOT NULL,
    [StudentFName]         NVARCHAR (50) NOT NULL,
    [StudentLName]         NVARCHAR (50) NOT NULL,
	[DateOfBirth]		   NVARCHAR(50) NOT NULL,
    [Address]			   NVARCHAR (50) NOT NULL,
    [PostalCode]           NVARCHAR (50) NOT NULL,
    [City]                 NVARCHAR (50) NOT NULL,
    [Country]              NVARCHAR (50) NOT NULL,
    [PhoneNum]             NVARCHAR(50)           NOT NULL,
    [FatherName]		   NVARCHAR(50) NULL, 
    [MotherName]		   NVARCHAR(50) NULL, 
    [EmergencyPhone]	   NVARCHAR(50) NULL,  
    PRIMARY KEY CLUSTERED ([StudentID] ASC)
);

