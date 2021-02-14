using SampleProject.Contracts.Response;
using MediatR;

namespace SampleProject.Contracts.Requests
{
    public class InsertLeadInformationRequest : IRequest<InsertLeadInformationResponse>
    {
        public int LoanAmountRequires { get; set; }
        public int LeadSourceId { get; set; }
        public string CommunicationMode { get; set; }
        public int CurrentStatusId { get; set; }
        public int ContactDetailsId { get; set; }
    }
}
