using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core2LearnWebApp.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public double? DailyAdultPrice { get; set; }
        public double? DailyGuestPrice { get; set; }
        public double? ExtrasPrice { get; set; }
        public double? DiscountPrice { get; set; }
        public double? ChildPrice { get; set; }
        public double? RoomPrice { get; set; }
        public double? BreakfastPrice { get; set; }
        public double? LunchPrice { get; set; }
        public double? DinnerPrice { get; set; }
        public double? TotalChildPrice { get; set; }
        public double? TotalAccommodationPrice { get; set; }
        public double? TotalRoomPrice { get; set; }
        public double? TotalBreakFastPrice { get; set; }
        public double? TotalLunchPrice { get; set; }
        public double? TotalDinnerPrice { get; set; }
        public double? TotalPersonPrice { get; set; }
        public double TotalPrice { get; set; }
        public DateTime? InsertDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }

        public int RezervationId { get; set; }
        public Rezervation Rezervation { get; set; }
    }
}
