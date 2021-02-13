using AutoMapper;
using DoodleBlue.Contracts.Response;
using DoodleBlue.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoodleBlueMappers
{
    public class LeadInformationProfile : Profile
    {
        public LeadInformationProfile()
        {
            CreateMap<LeadInformation, LeadInformationResponse>();
        }
    }
}
