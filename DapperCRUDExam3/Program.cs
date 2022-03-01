using DapperCRUDExam3.Service.Services;
using System;
using System.Threading.Tasks;

namespace DapperCRUDExam3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            MusicService music = new MusicService();
            await music.Add();
        }
    }
}
