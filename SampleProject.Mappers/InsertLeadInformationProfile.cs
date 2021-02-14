using AutoMapper;
using SampleProject.Contracts.Response;
using SampleProject.Repositories.Entities;

namespace SampleProject.Mappers
{
    public class InsertLeadInformationProfile : Profile
    {
        public InsertLeadInformationProfile()
        {
            CreateMap<InsertLeadInformation, InsertLeadInformationResponse>()
                .ForMember(dest => dest.LeadInformationId, opt => opt.MapFrom(x => x.LeadInformationId));
        }
    }
}
