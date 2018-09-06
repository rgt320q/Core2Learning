using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core2LearnWebApp.Models.ViewModels
{
    public class RezGuePayVModel
    {
        public Rezervation Rezervations { get; set; }
        public Guest Guests { get; set; }
        public Payment Payments { get; set; }

    }
}
