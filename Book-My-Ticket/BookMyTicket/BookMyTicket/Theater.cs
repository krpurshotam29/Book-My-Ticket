using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyTicket
{
    public class Theater
    {
        List<Screen> ScreenList;
        string TheaterName;
        List<Ticket> TicketList;

        public Theater(string theaterName)
        {
            this.TheaterName = theaterName;
            ScreenList = new List<Screen>();
            this.TicketList = new List<Ticket>();
            ScreenList.Add(new Screen(50));
        }

        public List<Screen> GetScreenList()
        {
            return ScreenList;
        }

        public void BookTicket(string seatNumber)
        {

        }
    }
}