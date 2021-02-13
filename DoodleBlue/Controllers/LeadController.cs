using DoodleBlue.Contracts.Requests;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoodleBlue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeadController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<string> GetLead()
        {
            LeadRequest leadRequest = new LeadRequest();
            var response = await _mediator.Send(leadRequest);
            return response;
        }
    }
}
