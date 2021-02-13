using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DoodleBlue.Data.ConnectionConfiguration;

namespace DoodleBlue.Data
{
    public class DapperQuery : IDapperQuery
    {
        private readonly IConnectionString _connectionString;

        public DapperQuery(IConnectionString connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<TReturn>> QueryListFromProcAsync<TReturn>(string sproc, object parameters)
        {
            IEnumerable<TReturn> result = default;

            using (var db = new SqlConnection(_connectionString.Value))
            {
                result = await db.QueryAsync<TReturn>(sql: sproc, param: parameters, commandType: CommandType.StoredProcedure);
            }
            return result;
        }
    }
}
