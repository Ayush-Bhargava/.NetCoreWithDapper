CREATE TABLE ContactDetails
(
	ContactDetailsId INT Primary key IDENTITY(1,1),
	ContactType nvarchar(10),
	ContactName nvarchar(20),
	DateOfBirth datetime,
	Gender nvarchar(1),
	EmailAddress nvarchar(20),
	ContactNumbers nvarchar(10)
)