using SampleProject.Contracts.Requests;
using SampleProject.Repositories.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleProject.Repositories.Interface
{
    public interface ILeadRepository
    {
        Task<IEnumerable<LeadInformation>> GetLead();
        Task<InsertLeadInformation> PostLeadInformation(InsertLeadInformationRequest leadInformationRequest);
    }
}
