using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab3.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        { 
            DateTime now = DateTime.Now;
            if (now.Hour < 12)
            {
                ViewData["greetingMsg"] = "Good Morning!";
            }
            else if (now.Hour < 18)
            {
                ViewData["greetingMsg"] = "Good Afternoon!";
            }
            else
                ViewData["greetingMsg"] = "Good Evening!";

            var time = now.ToString("hh:mm tt");
            var date = now.ToString("dddd, MMMM dd, yyyy");
            var year = now.DayOfYear;
            var daysLeftInYear = 365 - year;
            var nextYear = now.AddYears(1).Year;
            ViewData["time"] = time;
            ViewData["date"] = date;
            ViewData["year"] = nextYear;
            ViewData["daysLeftInYear"] = daysLeftInYear;
            

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
