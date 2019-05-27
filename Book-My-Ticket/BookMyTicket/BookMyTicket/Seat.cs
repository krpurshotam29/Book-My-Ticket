using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyTicket
{
    public class Seat
    {
        public string SeatNumber;
        SeatType seatType;
        public bool IsBooked;

        public Seat(string seatNumber, SeatType seatType, bool isBooked)
        {
            this.SeatNumber = seatNumber;
            this.seatType = seatType;
            this.IsBooked = isBooked;
        }
    }
}
