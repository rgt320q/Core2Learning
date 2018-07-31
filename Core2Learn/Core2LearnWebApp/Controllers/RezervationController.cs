using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core2LearnWebApp.Data.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Core2LearnWebApp.Controllers
{
    public class RezervationController : Controller
    {
        private DataContext context;

        public RezervationController(DataContext _context)
        {
            context = _context;
        }
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult List()
        {
            var rez = context.Rezervations
                .Include(i => i.Guests)
                .Include(i => i.Payments)
                .ToList();

            return View(rez);
        }
    }
}