using DoodleBlue.Contracts.Requests;
using DoodleBlue.Contracts.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger _logger;

        public LeadController(IMediator mediator, ILogger<LeadController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        [Route("leadInformation")]
        public async Task<IEnumerable<LeadInformationResponse>> GetLeadInformation()
        {
            _logger.LogInformation("Get lead api started on {Time}", DateTime.Now);
            LeadInformationRequest leadRequest = new LeadInformationRequest();
            var response = await _mediator.Send(leadRequest);
            _logger.LogInformation("Get lead api ended on {Time}", DateTime.Now);
            return response;
        }

        [HttpPost]
        [Route("leadInformation")]
        public async Task<InsertLeadInformationResponse> PostLeadInformation(InsertLeadInformationRequest leadInformationRequest)
        {
            var response = await _mediator.Send(leadInformationRequest);
            return response;
        }
    }
}
