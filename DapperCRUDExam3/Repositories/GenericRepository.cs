using CrudDapper.Domain.Customs;
using Dapper;
using DapperCRUDExam3.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUDExam3.Data.Repositories
{

#pragma warning disable
    public class GenericRepository : IGenericRepository
    {
        public async Task CreateAsync<T>(string query, DynamicParameters parameters, CommandType type)
        {
            using (IDbConnection dbase = GetConnection())
            {
                await dbase.QueryAsync<T>(query, parameters, commandType: type);
            }
        }

        public async Task DeleteAsync<T>(string query, DynamicParameters parameters, CommandType type)
        {
            using (IDbConnection dbase = GetConnection())
            {
                await dbase.QueryAsync<T>(query, parameters, commandType: type);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(string query, DynamicParameters parameters, CommandType type)
        {
            using (IDbConnection dbase = GetConnection())
            {
                return await dbase.QueryAsync<T>(query, parameters, commandType: type);
            }
        }

        public async Task<T> GetAsync<T>(string query, DynamicParameters parameters, CommandType type)
        {
            using (IDbConnection dbase = GetConnection())
            {
                return (await dbase.QueryAsync<T>(query, parameters, commandType: type)).FirstOrDefault();
            }
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(Constants.CONNECTION_DB);
        }

        public async Task<T> UpdateAsync<T>(string query, DynamicParameters parameters, CommandType type)
        {
            using (IDbConnection dbase = GetConnection())
            {
                return (await dbase.QueryAsync<T>(query, parameters, commandType: type)).FirstOrDefault();
            }
        }
    }
}
