﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MYProfilo.Models;
using System.Collections.Generic;
using System.Diagnostics;

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

        public IActionResult Contact()
        {
            var contact = new Contact()
            {
                Email = "soheilyazdanii1382@gmail.com",

                Github = "github.com/soheil-yz",

                Mobile = "09******522"
            };
            return View(contact);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
