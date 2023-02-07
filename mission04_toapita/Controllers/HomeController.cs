using Microsoft.AspNetCore.Mvc;
using mission04_toapita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission04_toapita.Views.Home
{
    public class HomeController : Controller
    {
        //Define the get and post requests
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Grades()
        {
            return View();
        }

        //Give the post request access to the model

        [HttpPost]
        public IActionResult Grades(GradesModel model)
        {
            return View();
        }
    }
}
