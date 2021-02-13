using DoodleBlue.Contracts.Requests;
using DoodleBlue.Repositories.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoodleBlue.Repositories.Interface
{
    public interface ILeadRepository
    {
        Task<IEnumerable<LeadInformation>> GetLead();
        Task<InsertLeadInformation> PostLeadInformation(InsertLeadInformationRequest leadInformationRequest);
    }
}
