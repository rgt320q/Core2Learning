using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core2LearnWebApp.Models
{
    public class Rezervation
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Lütfen geçerli bir tarih girin!")]       
        public DateTime? Arrivaldate { get; set; }
        [Required(ErrorMessage = "Lütfen geçerli bir tarih girin!")]
        public DateTime? DepartureDate { get; set; }
        public string RoomNo { get; set; }
        public string Status { get; set; }
        public int? TatolDays { get; set; }
        public int? TotalChildren { get; set; }
        public int? TotalChildrenWithPrice { get; set; }
        public int? TotalAdult { get; set; }
        public int? TotalPersons { get; set; }
        public string AccommodationType { get; set; }
        public string BoardType { get; set; }
        public string Breakfast { get; set; }
        public string Lunch { get; set; }
        public string Dinner { get; set; }
        public DateTime? InsertDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }

        public IEnumerable<Guest> Guests { get; set; }
        public IEnumerable<Payment> Payments { get; set; }
    }
}
