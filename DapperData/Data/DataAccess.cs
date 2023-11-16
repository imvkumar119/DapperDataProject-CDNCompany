using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DapperData.Data
{
    public class DataAccess : IDataAccess
    {
        private readonly IConfiguration _config;
        public DataAccess(IConfiguration config)
        {
            _config = config; 
        }


        // this method is return the users list from database
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <param name="connectionID"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetData<T,P>(string query,P parameters, string connectionID = "default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionID));
            return await connection.QueryAsync<T>(query, parameters);
        }

        // this method save the user data to database
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="P"></typeparam>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <param name="connectionID"></param>
        /// <returns></returns>
        public async Task SaveData<P>(string query,P parameters, string connectionID = "default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionID));
            await connection.ExecuteAsync(query, parameters);
        }
    }
}
