using Course.Interfaces.Entities;
using Course.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course.Interfaces
{
    class InterfacesProgram
    {
        public InterfacesProgram()
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (yyyy-MM-dd hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (yyyy-MM-dd hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine());

            Console.Write("Enter price per Day: ");
            double pricePerDay = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
