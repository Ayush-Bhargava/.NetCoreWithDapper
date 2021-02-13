using AutoMapper;
using DoodleBlue.Contracts.Requests;
using DoodleBlue.Contracts.Response;
using DoodleBlue.Repositories.Interface;
using DoodleBlueMappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoodleBlue.Handlers
{
    public class LeadHandler : IRequestHandler<LeadInformationRequest, IEnumerable<LeadInformationResponse>>
    {
        private readonly ILeadRepository _leadRepository;
        private readonly IMapper _mapper;

        public LeadHandler(ILeadRepository leadRepository, IMapper mapper)
        {
            _leadRepository = leadRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LeadInformationResponse>> Handle(LeadInformationRequest request, CancellationToken cancellationToken = default)
        {
            var flatIem = await _leadRepository.GetLead();
            var leadInformation = _mapper.MapAll<LeadInformationResponse>(flatIem);
            return leadInformation;
        }
    }
}
