using Dapper;
using DapperImplementation.DataAccess.Layer.Factory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperImplementation.DataAccess.Layer.DAO
{
    public class DapperDOA
    {
        private readonly ISqlConnectionFactory _connectionFactory;
        public DapperDOA(ISqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<List<T>> LoadDataAsync<T>(string sqlOrProcedure, CommandType commandType, Dictionary<string, object> parameters)
        {
            DynamicParameters dynamicParameters = ToMakeDynamicParameters(parameters);

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                var rows = await connection.QueryAsync<T>(sqlOrProcedure, dynamicParameters, commandType: commandType);
                return rows.ToList();
            }
        }

        public async Task<int> SaveDataAsync(string sqlOrProcedure, CommandType commandType, Dictionary<string, object> parameters)
        {
            DynamicParameters dynamicParameters = ToMakeDynamicParameters(parameters);

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                return await connection.ExecuteAsync(sqlOrProcedure, dynamicParameters, commandType: commandType);
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
