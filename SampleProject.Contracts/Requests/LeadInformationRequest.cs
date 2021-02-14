using SampleProject.Contracts.Response;
using MediatR;
using System.Collections.Generic;

namespace SampleProject.Contracts.Requests
{
    public class LeadInformationRequest : IRequest<IEnumerable<LeadInformationResponse>>
    {

    }
}
