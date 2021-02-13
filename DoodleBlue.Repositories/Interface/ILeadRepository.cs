using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoodleBlue.Repositories.Interface
{
    public interface ILeadRepository
    {
        Task<IEnumerable<string>> GetLead();
    }
}
