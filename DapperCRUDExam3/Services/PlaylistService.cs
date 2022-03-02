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
    public class PlaylistServices
    {
        IGenericRepository repo = new GenericRepository();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task AddAsync()
        {
            Console.WriteLine("Entering Name: ");
            string name = Console.ReadLine();
            string query = $"insert into Playlist (Name, CreatedDate) values ('{name}', '{DateTime.Now}')";
            await repo.CreateAsync<Playlist>(query, null, CommandType.Text);
            Console.WriteLine("Sucsessfully create date! ");
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
            string delete = $"delete Playlist where id = {deletedId}";
            await repo.DeleteAsync<Playlist>(delete, null, CommandType.Text);
            return true;


        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Playlist>> GetAllAsync()
        {
            string query = $"select * from Playlist";
            
            return await repo.GetAllAsync<Playlist>(query, null, CommandType.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="updatedId"></param>
        /// <returns></returns>
        public async Task UpdateAsync(string name, int updatedId)
        {
            string query = $"update Playlist set Name = '{name}' where id = {updatedId}";
            await repo.CreateAsync<Playlist>(query, null, CommandType.Text);
            Console.WriteLine("Sucsessfully Update date! ");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="getId"></param>
        /// <returns></returns>
        public async Task<Playlist> GetAsync(int getId)
        {
            string query = $"select * from Playlist where id = {getId}";
            
            return await repo.GetAsync<Playlist>(query, null, CommandType.Text);
        }

    }

}
