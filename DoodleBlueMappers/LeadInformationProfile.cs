using AutoMapper;
using DoodleBlue.Contracts.Response;
using DoodleBlue.Repositories.Entities;

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
