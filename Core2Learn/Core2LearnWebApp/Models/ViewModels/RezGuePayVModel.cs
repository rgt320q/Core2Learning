using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core2LearnWebApp.Models.ViewModels
{
    public class RezGuePayVModel
    {
        public IEnumerable<Rezervation> Rezervations { get; set; }
        public IEnumerable<Guest> Guests { get; set; }
        public IEnumerable<Payment> Payments { get; set; }

    }
}
