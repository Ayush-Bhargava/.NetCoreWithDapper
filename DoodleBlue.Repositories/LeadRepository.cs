using DoodleBlue.Data;
using DoodleBlue.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoodleBlue.Repositories
{
    public class LeadRepository : ILeadRepository
    {
        internal const string SPROC_GET_LEAD = "usp_GetLead";

        private readonly IDapperQuery _dapperQuery;

        public LeadRepository(IDapperQuery dapperQuery)
        {
            _dapperQuery = dapperQuery;
        }

        public async Task<IEnumerable<string>> GetLead()
        {
            return await _dapperQuery.QueryListFromProcAsync<string>(SPROC_GET_LEAD, null);
        }
    }
}
