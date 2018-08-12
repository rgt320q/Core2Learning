using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core2LearnWebApp.Models
{
    public class RezervationGuestPaymentModel
    {
        IEnumerable<Rezervation> Rezervations { get; set; }
        IEnumerable<Guest> Guests { get; set; }
        IEnumerable<Payment> Payments { get; set; }

    }
}
