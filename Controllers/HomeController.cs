using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MYProfilo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MYProfilo.Models;
namespace MYProfilo.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Portfolio> _portfolio = new List<Portfolio>
        {
            new Portfolio
            {
                Id = 1, Title = "Project1" ,Image = "01.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit"

            },
            new Portfolio
            {
                Id = 2, Title = "Project2" ,Image = "02.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit"

            },
            new Portfolio
            {
                Id = 3, Title = "Project3" ,Image = "03.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit"

            },
            new Portfolio
            {
                Id = 4, Title = "Project4" ,Image = "04.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit"

            },

        };

        public IActionResult Index()
        {
            return View(_portfolio);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
