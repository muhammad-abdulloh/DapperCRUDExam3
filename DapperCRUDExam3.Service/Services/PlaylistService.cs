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
    public class PlaylistServices
    {
        IGenericRepository repo = new GenericRepository();
        async Task Add()
        {
            string query = $"insert into playlist (name, created_date) values ('{"Ali"}', '{"200-200-20"}')";
            await repo.CreateAsync<Music>(query, null, CommandType.Text);
        }

        async Task Delete()
        {

            string delete = $"delete playlist where id = {1}";
            await repo.DeleteAsync<Music>(delete, null, CommandType.Text);
        }

        async Task GetAll()
        {
            string q = $"select * from playlist";
            var si = await repo.GetAllAsync<Music>(q, null, CommandType.Text);
        }

        async Task Update()
        {
            string update = $"update playlist set name = '{"New"}' where id = {1}";
            await repo.CreateAsync<Music>(update, null, CommandType.Text);
        }

        async Task Get()
        {
            string que = $"select * from playlist where id = {1}";
            await repo.GetAsync<Music>(que, null, CommandType.Text);
        }

        async Task GetAllInfo()
        {
            string q = "GetAllInfoPlaylist";
            DynamicParameters pa = new DynamicParameters();
            pa.Add("userId", 1);
            var res = await repo.GetAsync<AllInfoPlaylist>(q, pa, CommandType.StoredProcedure);
            Console.WriteLine();
        }
    }

}
