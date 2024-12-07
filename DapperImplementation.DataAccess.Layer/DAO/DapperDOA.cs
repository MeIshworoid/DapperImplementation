using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DapperImplementation.DataAccess.Layer.DAO
{
    public class DapperDOA
    {
        private readonly SqlConnection _connection;
        public DapperDOA(SqlConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<T>> LoadDataAsync<T>(string sqlOrProcedure, CommandType commandType, Dictionary<string, object> parameters)
        {
            DynamicParameters dynamicParameters = ToMakeDynamicParameters(parameters);

            using (_connection)
            {
                var rows = await _connection.QueryAsync<T>(sqlOrProcedure, dynamicParameters, commandType: commandType);
                return rows.ToList();
            }
        }

        public async Task<int> SaveDataAsync(string sqlOrProcedure, CommandType commandType, Dictionary<string, object> parameters)
        {
            DynamicParameters dynamicParameters = ToMakeDynamicParameters(parameters);

            using (_connection)
            {
                return await _connection.ExecuteAsync(sqlOrProcedure, dynamicParameters, commandType: commandType);
            }
        }

        private DynamicParameters ToMakeDynamicParameters(Dictionary<string, object> parameters)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            parameters.ToList().ForEach(x => dynamicParameters.Add(x.Key, x.Value));
            return dynamicParameters;
        }
    }
}
