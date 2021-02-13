using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoodleBlue.Data
{
    public interface IDapperQuery
    {
        Task<IEnumerable<TReturn>> QueryListFromProcAsync<TReturn>(string sproc, object parameters);
    }
}
