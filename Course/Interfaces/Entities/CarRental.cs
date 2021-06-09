using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Interfaces.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vechicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vechicle)
        {
            this.Start = start;
            this.Finish = finish;
            this.Vechicle = vechicle;
            this.Invoice = null;
        }
    }
}
