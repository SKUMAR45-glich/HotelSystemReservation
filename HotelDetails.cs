using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelDetails
    {
        //Name and Rate

        public string hotelName = "^[Aa0-Zz9]";
        public int rate;
        public int weekendrate;
        

        /// Parametrised Constructor
        public HotelDetails(string hotelName, int rate, int weekendrate)
        {
            this.hotelName = hotelName;
            this.rate = rate;
            this.weekendrate = weekendrate;
            
        }
    }
}
