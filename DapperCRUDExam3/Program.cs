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

            //var getResult = await music.GetAsync(); done

            //Console.WriteLine(getResult.SingerId);
            //await music.Delete(2); done
            /*var rests = await music.GetAllAsync(); //done

            foreach (var rest in rests)
            {
                Console.WriteLine(rest.Id + " " + rest.Description);
            }*/
            // await music.UpdateAsync("Bu yangi description", 1); done



        }
    }
}
#pragma warning restore