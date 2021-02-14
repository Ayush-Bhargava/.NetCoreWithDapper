using SampleProject.Contracts.Requests;
using SampleProject.Data;
using SampleProject.Repositories.Entities;
using SampleProject.Repositories.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleProject.Repositories
{
    public class LeadRepository : ILeadRepository
    {
        internal const string SPROC_GET_LEAD = "usp_GetLead";
        internal const string SPROC_INSERT_LEAD = "usp_InsertLeadInformation";

        private readonly IDapperQuery _dapperQuery;

        public LeadRepository(IDapperQuery dapperQuery)
        {
            _dapperQuery = dapperQuery;
        }

        public async Task<IEnumerable<LeadInformation>> GetLead()
        {
            return await _dapperQuery.QueryListFromProcAsync<LeadInformation>(SPROC_GET_LEAD, null);
        }
        public async Task<InsertLeadInformation> PostLeadInformation(InsertLeadInformationRequest leadInformationRequest)
        {
            return await _dapperQuery.QueryStoredProcAsync<InsertLeadInformation>(SPROC_INSERT_LEAD, leadInformationRequest);
        }
    }
}
