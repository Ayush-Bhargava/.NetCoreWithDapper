using DoodleBlue.Contracts.Requests;
using DoodleBlue.Contracts.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoodleBlue.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeadController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("leadInformation")]
        public async Task<IEnumerable<LeadInformationResponse>> GetLeadInformation()
        {
            LeadInformationRequest leadRequest = new LeadInformationRequest();
            var response = await _mediator.Send(leadRequest);
            return response;
        }
    }
}
