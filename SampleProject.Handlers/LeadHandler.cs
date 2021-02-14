using AutoMapper;
using SampleProject.Contracts.Requests;
using SampleProject.Contracts.Response;
using SampleProject.Repositories.Interface;
using SampleProjectMappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleProject.Handlers
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
            var flatItem = await _leadRepository.GetLead();
            var leadInformation = _mapper.MapAll<LeadInformationResponse>(flatItem);
            return leadInformation;
        }
    }
}
