using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core2LearnWebApp.Data.EntityFramework;
using Core2LearnWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Core2LearnWebApp.Controllers
{
    public class RezervationController : Controller
    {
        private DataContext context;
        Rezervation Rez = new Rezervation();
        Guest gue = new Guest();
        Payment pay = new Payment();

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

        [HttpGet]
        public IActionResult Create()
        {
            var model = Tuple.Create<Rezervation, Guest, Payment>(new Rezervation(), new Guest(), new Payment());
            return View(model);
        }

        [HttpPost]
        public IActionResult Create([Bind(Prefix = "Item1")]Rezervation Model1, [Bind(Prefix = "Item2")]Guest Model2, [Bind(Prefix ="Item3")]Payment Model3)
        {
            //var all = from b in context.Rezervations
            //          join g in context.Guests
            //          on b.Id equals g.RezervationId
            //          join p in context.Payments
            //          on b.Id equals p.RezervationId
            //          select new
            //          {
            //              b.Arrivaldate,
            //              b.DepartureDate,
            //              g.Name,
            //              g.SurName,
            //              p.TotalPrice
            //          };
            
            //Rez.DepartureDate = Model1.DepartureDate;
            //gue.Name = Model2.Name;
            //gue.SurName = Model2.SurName;
            //pay.TotalPrice = Model3.TotalPrice;

            //Rez.InsertDateTime = DateTime.Now;
            //gue.InsertDateTime = DateTime.Now;
            //gue.GuestSequenceNo = 1;
            //pay.InsertDateTime = DateTime.Now;



            context.Rezervations.Add(Model1);            
            context.Guests.Add(Model2);
            context.Payments.Add(Model3);
            
            context.SaveChanges();


            return RedirectToAction("List");
        }

        public ViewResult Edit(int id)
        {
            var model = context.Rezervations
                .Include(i => i.Guests)
                .Include(i => i.Payments).FirstOrDefault(i=>i.Id==id);

            return View(model);
        }

        //[HttpGet]
        //public ViewResult Edit()
        //{
        //    var model = context.Rezervations
        //        .Include(i => i.Payments)
        //        .Include(i => i.Guests);

        //    return View(model);
        //}

        [HttpPost]
        public IActionResult Edit(Rezervation rezervation)
        {
            context.Rezervations.Update(rezervation);
            context.SaveChanges();

            return RedirectToAction("List");
        }

    }
}