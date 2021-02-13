using DoodleBlue.Contracts.Response;
using MediatR;
using System.Collections.Generic;

namespace DoodleBlue.Contracts.Requests
{
    public class LeadInformationRequest : IRequest<IEnumerable<LeadInformationResponse>>
    {

    }
}
