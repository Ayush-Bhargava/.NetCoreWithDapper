CREATE TABLE LeadInformation	
(
	LeadId INT Primary key IDENTITY(1,1),
	LoanAmountRequires int,
	LeadSourceId int FOREIGN KEY REFERENCES LeadSourceValue(LeadSourceId),
	CommunicationMode nvarchar(10),
	CurrentStatusId int FOREIGN KEY REFERENCES CurrentStatusValues(CurrentStatusId),
	ContactDetailsId int NOT NULL FOREIGN KEY REFERENCES ContactDetails(ContactDetailsId),
)