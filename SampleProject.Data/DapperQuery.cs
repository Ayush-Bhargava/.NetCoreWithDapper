using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using SampleProject.Data.ConnectionConfiguration;

namespace SampleProject.Data
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
        public async Task<TReturn> QueryStoredProcAsync<TReturn>(string sproc, object paramerters)
        {
            TReturn result = default;

            using (var db = new SqlConnection(_connectionString.Value))
            {
                var results = await db.QueryAsync<TReturn>(sql: sproc, param: paramerters, commandType: CommandType.StoredProcedure);
                result = results.FirstOrDefault();
            }
            return result;
        } 
    }
}
