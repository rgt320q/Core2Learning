using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core2LearnWebApp.Data.EntityFramework;
using Core2LearnWebApp.Models;
using Core2LearnWebApp.Models.ViewModels;
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
            var model = context.Payments
                .Include(i => i.Guest)
                .ThenInclude(i => i.Rezervation)
                .ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
             var model=context.Payments
               .Include(i => i.Guest)
               .ThenInclude(i => i.Rezervation);

            //return View(Tuple.Create<Rezervation,Guest,Payment>(new Rezervation(),new Guest(),new Payment()));
            return View();
        }

        //public IQueryable<Rezervation> Rezervations => context.Rezervations;

        //public IActionResult Create([Bind(Prefix ="Item1")]Rezervation Model1, [Bind(Prefix = "Item2")]Guest Model2, [Bind(Prefix = "Item3")]Payment Model3)
        [HttpPost]
        public IActionResult Create(Payment payment)
        {

            //context.Rezervations
            //    .Include(i => i.Guests)
            //    .Include(i => i.Payments);
            payment.Guest.GuestSequenceNo = 1;
            payment.InsertDateTime = DateTime.Now;
            payment.UpdateDateTime = DateTime.Now;
            payment.Guest.InsertDateTime = DateTime.Now;
            payment.Guest.UpdateDateTime = DateTime.Now;
            payment.Guest.Rezervation.InsertDateTime = DateTime.Now;
            payment.Guest.Rezervation.UpdateDateTime = DateTime.Now;


            context.Payments.Add(payment);
            //context.Guests.Add(Model2);
            //context.Payments.Add(Model3);

            //context.Add(guest);
            //context.Add(payment);

            context.SaveChanges();

            //var model = new RezGuePayVModel();

            //model.Rezervations = context.Rezervations;
            //model.Guests = context.Guests;
            //model.Payments = context.Payments;

            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //var rezervation=context.Rezervations
            //    .Include(i => i.Guests)
            //    .Include(i => i.Payments)
            //    .FirstOrDefault(i => i.Id == id);

            //rezervation.Guests = context.Guests.ToList();

            

            return View();
        }

        [HttpPost]
        public IActionResult Edit(Rezervation rezervation,Guest guest,Payment payment)
        {
           
            
            context.SaveChanges();

            return RedirectToAction("List");
        }


    }
}