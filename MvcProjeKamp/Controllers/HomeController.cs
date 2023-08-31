using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
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

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Values()
        {
            HttpClient client = new HttpClient();

            var response = client.GetAsync("https://localhost:7093/api/Deneme").GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();
            var result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var model = JsonConvert.DeserializeObject<List<Values>>(result);

            return View(model);
        }
    }

    public class Values
    {


        public int Id { get; set; }
        public string Value { get; set; }
        public string Date { get; set; }
    }
}