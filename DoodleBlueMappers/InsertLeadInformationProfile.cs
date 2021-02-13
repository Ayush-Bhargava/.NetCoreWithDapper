using AutoMapper;
using DoodleBlue.Contracts.Response;
using DoodleBlue.Repositories.Entities;

namespace DoodleBlue.Mappers
{
    public class InsertLeadInformationProfile : Profile
    {
        public InsertLeadInformationProfile()
        {
            CreateMap<InsertLeadInformation, InsertLeadInformationResponse>();
        }
    }
}
