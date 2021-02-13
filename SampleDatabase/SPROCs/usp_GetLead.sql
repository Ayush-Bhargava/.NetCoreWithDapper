CREATE PROCEDURE [dbo].[usp_GetLead]
AS
BEGIN
	SELECT
		LeadId,
		LoanAmountRequires,
		LeadSourceId,
		CommunicationMode,
		CurrentStatusId,
		ContactDetailsId
	From LeadInformation
END