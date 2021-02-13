﻿using AutoMapper;
using DoodleBlue.Contracts.Requests;
using DoodleBlue.Contracts.Response;
using DoodleBlue.Repositories.Interface;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DoodleBlue.Handlers
{
    public class PostLeadHandler : IRequestHandler<InsertLeadInformationRequest, InsertLeadInformationResponse>
    {
        private readonly ILeadRepository _leadRepository;
        private readonly IMapper _mapper;

        public PostLeadHandler(ILeadRepository leadRepository, IMapper mapper)
        {
            _leadRepository = leadRepository;
            _mapper = mapper;
        }

        public async Task<InsertLeadInformationResponse> Handle(InsertLeadInformationRequest leadInformationRequest, CancellationToken cancellationToken = default)
        {
            var flatItem = await _leadRepository.PostLeadInformation(leadInformationRequest);
            var leadInformationId = _mapper.Map<InsertLeadInformationResponse>(flatItem);
            return leadInformationId;
        }
    }
}
