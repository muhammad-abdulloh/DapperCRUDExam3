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
    public class MusicService
    {
        IGenericRepository repo = new GenericRepository();
        public async Task AddAsync()
        {
            Console.WriteLine("Entering Title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Entering Description: ");
            string descript = Console.ReadLine();

            Console.WriteLine("Entering Email: ");
            string eml = Console.ReadLine();

            Console.WriteLine("Entering SingerId: ");
            int sgId = int.Parse(Console.ReadLine());

            Console.WriteLine("Entering Length: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Entering PlaylistId: ");
            int plyId = int.Parse(Console.ReadLine());

            DateTime dateTime = DateTime.Now;
            string query = $"insert into Musics (Title, Description, Email, SingerId, Length, PlaylistId, CreatedDate)" +
                $" values ('{title}', '{descript}', '{eml}', {sgId}, {length}, {plyId}, '{dateTime}')";
            await repo.CreateAsync<Music>(query, null, CommandType.Text);

            Console.WriteLine("Sucsessfully creste date! ");
        }

        public async Task<bool> DeleteAsync(int? id)
        {
            if (id is null)
            {
                return false;
            }
            string delete = $"delete musics where id = {id}";
            await repo.DeleteAsync<Music>(delete, null, CommandType.Text);
            Console.WriteLine("Sucsessfully deleted date! ");
            return true;
        }

        public async Task<IEnumerable<Music>> GetAllAsync()
        {
            string q = $"select * from musics";
            var result = await repo.GetAllAsync<Music>(q, null, CommandType.Text);
            return result;
        }

        public async Task UpdateAsync(string descript, int updatedId)
        {
            string update = $"update musics set Description = '{descript}' where id = {updatedId}";
            await repo.CreateAsync<Music>(update, null, CommandType.Text);
            Console.WriteLine("Sucsessfully update date! ");
        }

        public async Task<Music> GetAsync(int getID)
        {
            string que = $"select * from musics where id = {getID}";
            var result = await repo.GetAsync<Music>(que, null, CommandType.Text);
            return result;
        }

    }
}
