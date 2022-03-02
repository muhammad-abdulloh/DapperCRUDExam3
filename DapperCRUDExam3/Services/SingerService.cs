using Dapper;
using DapperCRUDExam3.Data.IRepositories;
using DapperCRUDExam3.Data.Repositories;
using DapperCRUDExam3.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUDExam3.Service.Services
{
    public class SingerServices
    {
        IGenericRepository repo = new GenericRepository();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task AddAsync()
        {
            Console.WriteLine("Entering Singer FullName: ");
            string fullName = Console.ReadLine();
            string query = $"insert into Singer (FullName, CreatedDate) values ('{fullName}', '{DateTime.Now}')";
            await repo.CreateAsync<Singer>(query, null, CommandType.Text);
            Console.WriteLine("Sucsessfully addedd date! ");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deletedId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(int? deletedId)
        {
            if (deletedId is null)
            {
                return false;
            }
            string delete = $"delete Singer where id = {deletedId}";
            await repo.DeleteAsync<Singer>(delete, null, CommandType.Text);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Singer>> GetAllAsync()
        {
            string query = $"select * from Singer";
            
            return await repo.GetAllAsync<Singer>(query, null, CommandType.Text);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task UpdateAsync(string fullName, int id)
        {
            string update = $"update singer set FullName = '{fullName}' where id = {id}";
            await repo.CreateAsync<Singer>(update, null, CommandType.Text);
            Console.WriteLine("Sucsessfully updated date! ");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Singer> GetAsync(int id)
        {
            string query = $"select * from Singer where id = {id}";
            return await repo.GetAsync<Singer>(query, null, CommandType.Text);
        }

    }

}
