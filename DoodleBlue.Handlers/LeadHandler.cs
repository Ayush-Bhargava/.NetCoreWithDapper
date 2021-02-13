using DoodleBlue.Contracts.Requests;
using DoodleBlue.Repositories.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoodleBlue.Handlers
{
    public class LeadHandler : IRequestHandler<LeadRequest,string>
    {
        private readonly ILeadRepository _leadRepository;

        public LeadHandler(ILeadRepository leadRepository)
        {
            _leadRepository = leadRepository;
        }

        public async Task<string> Handle(LeadRequest request, CancellationToken cancellationToken = default)
        {
            var flatIem = await _leadRepository.GetLead();
            return flatIem.FirstOrDefault();
        }
    }
}
