using Course.CreateException.Entities;
using Course.CreateException.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.CreateException
{
    class CreateExceptionProgram
    {
        public CreateExceptionProgram()
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine($"Reservation: {reservation}");
            } 
            catch (DomainException err)
            {
                Console.WriteLine($"Error in reservation: {err.Message}");
            }
            catch (FormatException err)
            {
                Console.WriteLine($"Format error: {err.Message}");
            }
            catch (Exception err)
            {
                Console.WriteLine($"Unexpected Error: {err.Message}");
            }
        }
    }
}
