using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyTicket
{
    class TicketBookingSimulator
    {
        List<Theater> TheaterList;

        public TicketBookingSimulator()
        {
            TheaterList = new List<Theater>();
            TheaterList.Add(new Theater("Theater 1"));
            TheaterList.Add(new Theater("Theater 2"));
        }

        public void MainMenu()
        {
            foreach(Theater theater in TheaterList)
            {
                List<Screen> screenList = theater.GetScreenList();
                Seat[,] seatList = screenList[0].GetSeatList();
                for(int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write((seatList[i, j].IsBooked ? "X" : seatList[i,j].SeatNumber)+ "\t");
                    }
                    Console.WriteLine();
                }

            }
        }

        public void BookTicket()
        {
            Console.Write("Select Theater");
            string theaterName = Console.ReadLine();
            Console.WriteLine("Select Screen");
        }
    }
}