using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DonNetCore.Services;
using Microsoft.CodeAnalysis.Options;
using DonNetCore.Configuration;
using Microsoft.Extensions.Options;

namespace DonNetCore.Controllers
{
    public class HomeController : Controller
    {
        IDatetime _datetime;
        MyOptions _options;
        public HomeController(
            IDatetime datetime,
            IOptions<MyOptions> setting
            )
        {
            this._datetime = datetime;
            this._options = setting.Value;
        }

        //public IActionResult Index([FromServices] IDatetime datetime)
        //{
        //    var now = _datetime.Now();

        //    return View();
        //}

        public IActionResult Index()
        {
            var now = _datetime.Now();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
