using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core2LearnWebApp.Models;
using Core2LearnWebApp.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Core2LearnWebApp.Models.ViewModels;

namespace Core2LearnWebApp.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;
        RezGuePayVModel mdl = new RezGuePayVModel();

        public HomeController(DataContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {

            var model = context.Rezervations
                .Include(i => i.Guests)
                .Include(i => i.Payments).ToList();

            return View(model);
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

        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
