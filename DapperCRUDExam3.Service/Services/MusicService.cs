using Dapper;
using DapperCRUDExam3.Data.IRepositories;
using DapperCRUDExam3.Data.Repositories;
using DapperCRUDExam3.Domain.Models;
using ExamProject_1.Model.ViewModel;
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
        async Task Add()
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
            string query = $"insert into Musics (Title, Description, Email, SingerId, Length, PlaylistId, created_date)" +
                $" values ('{title}', '{descript}', '{eml}', {sgId}, {length}, {plyId}, '{dateTime}')";
            await repo.CreateAsync<Music>(query, null, CommandType.Text);

            Console.WriteLine("Sucsessfully creste date! ");
        }

        async Task Delete()
        {

            string delete = $"delete music where id = {1}";
            await repo.DeleteAsync<Music>(delete, null, CommandType.Text);
        }

        async Task GetAll()
        {
            string q = $"select * from music";
            var si = await repo.GetAllAsync<Music>(q, null, CommandType.Text);
        }

        async Task Update()
        {
            string update = $"update music set fullname = '{"Muhammadkarim Toxtaboyev"}' where id = {1}";
            await repo.CreateAsync<Music>(update, null, CommandType.Text);
        }

        async Task Get()
        {
            string que = $"select * from music where id = {1}";
            await repo.GetAsync<Music>(que, null, CommandType.Text);
        }

        async Task GetAllInfo()
        {
            string q = "GetAllInfo";
            DynamicParameters pa = new DynamicParameters();
            pa.Add("userId", 1);

            var res = await repo.GetAsync<AllInfo>(q, pa, CommandType.StoredProcedure);
            Console.WriteLine(res.FullName);
        }
    }
}
