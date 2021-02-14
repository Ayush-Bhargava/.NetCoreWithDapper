CREATE TABLE CommunicationLogs
(
	CommunicationLogsId INT Primary key IDENTITY(1,1),
	LeadId  int FOREIGN KEY REFERENCES LeadInformation(LeadId),
	CommunicationDate datetime,
	CommunicationMode nvarchar(10),
	[Status] nvarchar(10)
)