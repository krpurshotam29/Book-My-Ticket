using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyTicket
{
    public class Ticket
    {
        string TicketNumber;
        string SeatNumber;
        string MovieName;
        string ShowTime;
        string ScreenNumber;

        public Ticket(string ticketNumber, string seatNumber, string movieName, string showTime, string screenNumber)
        {
            this.TicketNumber = ticketNumber;
            this.SeatNumber = seatNumber;
            this.MovieName = movieName;
            this.ShowTime = showTime;
            this.ScreenNumber = screenNumber;
        }

    }
}
