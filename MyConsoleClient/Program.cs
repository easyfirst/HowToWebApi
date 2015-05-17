using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MyModels;

namespace MyConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start");
            Console.ReadKey();

            CallWorksControllerPost();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }

        private static async void CallWorksControllerPost()
        {
            Console.WriteLine("CallWorksControllerPost");
            var client = new HttpClient();
            var dto = new WorksData
            {
                WorksId=Guid.NewGuid(),
                Album = new WorksAlbum { Id=Guid.NewGuid(),Name="My Album"},
                Topic = new WorksTopic { Id=Guid.NewGuid(),Name="My Topic"},
                WorksMediaList = new List<WorksMedia>
                {
                    new WorksMedia{Id=Guid.NewGuid(),Name="My Media"}
                }
            };
            var response = await client.PostAsJsonAsync("http://localhost:53340/api/works", dto);
            Console.WriteLine(response.StatusCode);
        }
    }
}
