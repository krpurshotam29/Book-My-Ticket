using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyTicket
{
    public class Screen
    {
        private Seat[,] SeatList;
        private Movie movie;

        public Screen(int noOfSeats)
        {
            SeatList = new Seat[noOfSeats,noOfSeats];
            char seatRow = 'A';
            for (int i = 0; i < noOfSeats; i++)
            {
                for(int j = 0; j < noOfSeats; j++)
                {
                    SeatList[i, j] = new Seat(""+seatRow+(j + 1), SeatType.Normal, false);
                }
                seatRow++;
            }
        }

        public Seat[,] GetSeatList()
        {
            return SeatList;
        }
    }
}
