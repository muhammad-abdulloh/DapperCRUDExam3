using DapperCRUDExam3.Service.Services;
using System;
using System.Threading.Tasks;

#pragma warning disable
namespace DapperCRUDExam3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            MusicService music = new MusicService();

            //await music.AddAsync(); //done
            //PlaylistServices playlist = new PlaylistServices();
            //var result = await playlist.GetAllAsync();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}

            SingerServices singer = new SingerServices();
            var rests = await singer.GetAllAsync();
            foreach (var item in rests)
            {
                Console.WriteLine(item.FullName);
            }

            //var getResult = await music.GetAsync(); done

            //Console.WriteLine(getResult.SingerId);
            //await music.Delete(2); done
            //var rests = await music.GetAllAsync(); //done

            //foreach (var rest in rests)
            //{
            //    Console.WriteLine(rest.Id + " " + rest.Description);
            //}
            // await music.UpdateAsync("Bu yangi description", 1); done



        }
    }
}
#pragma warning restore