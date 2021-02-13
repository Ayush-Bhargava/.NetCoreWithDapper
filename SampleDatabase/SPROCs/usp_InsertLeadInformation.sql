CREATE PROCEDURE [usp_InsertLeadInformation]
	@LoanAmountRequires int,
	@LeadSourceId int,
	@CommunicationMode nvarchar(10),
	@CurrentStatusId int,
	@ContactDetailsId int
AS 
BEGIN
	DECLARE @LeadID int

	INSERT INTO LeadInformation
	(
		LoanAmountRequires,
		LeadSourceId,
		CommunicationMode,
		CurrentStatusId,
		ContactDetailsId
	)
	VALUES
	(
		@LoanAmountRequires,
		@LeadSourceId,
		@CommunicationMode,
		@CurrentStatusId,
		@ContactDetailsId
	);
	SET @LeadID = SCOPE_IDENTITY();
	SELECT @LeadID AS LeadInformationId
END