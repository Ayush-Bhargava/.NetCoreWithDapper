using AutoMapper;
using SampleProject.Contracts.Response;
using SampleProject.Repositories.Entities;

namespace SampleProjectMappers
{
    public class LeadInformationProfile : Profile
    {
        public LeadInformationProfile()
        {
            CreateMap<LeadInformation, LeadInformationResponse>();
        }
    }
}
