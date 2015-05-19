using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MyModels;

namespace MyMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PostWork()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> PostWork(WorksData model)
        {
            if (ModelState.IsValid)
            {
                model.Album = new WorksAlbum {Id = Guid.NewGuid(), Name = "My Album"};
                model.Topic = new WorksTopic {Id = Guid.NewGuid(), Name = "My Topic"};
                model.WorksMediaList = new List<WorksMedia>
                {
                    new WorksMedia {Id = Guid.NewGuid(), Name = "My Media"}
                };

                var client = new HttpClient();
                var response = await client.PostAsJsonAsync("http://localhost:53340/api/works", model);

                return Content(string.Format("<h1>{0}</h1>", response.StatusCode));
            }
            return View(model);
        }
    }
}