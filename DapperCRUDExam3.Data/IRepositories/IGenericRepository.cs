using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUDExam3.Data.IRepositories
{
    public interface IGenericRepository: IDisposable
    {
        IDbConnection GetConnection();
        Task<T> GetAsync<T>(string query, DynamicParameters parameters, CommandType type);
        Task<IEnumerable<T>> GetAllAsync<T>(string query, DynamicParameters parameters, CommandType type);
        Task DeleteAsync<T>(string query, DynamicParameters parameters, CommandType type);
        Task<T> UpdateAsync<T>(string query, DynamicParameters parameters, CommandType type);
        Task CreateAsync<T>(string query, DynamicParameters parameters, CommandType type);
    }
}
