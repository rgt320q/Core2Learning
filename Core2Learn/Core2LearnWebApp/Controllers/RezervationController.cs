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
        
        public RezervationController(DataContext _context) => context = _context;

        public ViewResult Index()
        {

            return View();
        }

        public ViewResult List()
        {
            var model = context.Rezervations
                .Include(i => i.Guests)
                .Include(i => i.Payments)
                .ToList();

            return View(model);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            //return View(Tuple.Create<Rezervation,Guest,Payment>(new Rezervation(),new Guest(),new Payment()));
            return View();
        }

        // Tuple Ile Kullanim Icin //
        //public IActionResult Create([Bind(Prefix ="Item1")]Rezervation Model1, [Bind(Prefix = "Item2")]Guest Model2, [Bind(Prefix = "Item3")]Payment Model3)
        [HttpPost]
        public IActionResult Create(RezGuePayVModel _mdl)
        {
            _mdl.Rezervations.InsertDateTime = DateTime.Now;

            context.Rezervations.Add(_mdl.Rezervations);
           

            _mdl.Guests.RezervationId = _mdl.Rezervations.Id;
            _mdl.Guests.GuestSequenceNo = 1;
            _mdl.Guests.UpdateDateTime = DateTime.Now;

            context.Guests.Add(_mdl.Guests);

            _mdl.Payments.RezervationId = _mdl.Rezervations.Id;
            _mdl.Payments.InsertDateTime = DateTime.Now;

            context.Payments.Add(_mdl.Payments);

            // Tuple Ile Kullanim Icin //

            //Model1.InsertDateTime=DateTime.Now;
            //context.Rezervations.Add(Model1);
            ////context.SaveChanges();

            //Model1.Id = Model2.RezervationId;
            //Model2.InsertDateTime=DateTime.Now;
            //Model2.GuestSequenceNo = 1;
            //context.Guests.Add(Model2);
            //Model1.Id = Model3.RezervationId;
            //Model3.InsertDateTime=DateTime.Now;
            //context.Payments.Add(Model3);

            context.SaveChanges();

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