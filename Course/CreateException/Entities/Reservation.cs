using Course.CreateException.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.CreateException.Entities
{
    class Reservation
    {

        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut < checkIn)
            {
                throw new DomainException("Error in reservation: Check-out date must be future dates");
            }

            this.RoomNumber = roomNumber;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = this.CheckOut.Subtract(this.CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Error in reservation: Reservation dates for update must be future dates");
            }
            
            if (checkOut < checkIn)
            {
                throw new DomainException("Error in reservation: Check-out date must be future dates");
            }

            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Room {this.RoomNumber}, check-in: {this.CheckIn.ToString("dd/MM/yyyy")}, " +
                $"check-out: {this.CheckOut.ToString("dd/MM/yyyy")}, {this.Duration()} nights";
        }
    }
}
