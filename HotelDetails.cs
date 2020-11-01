using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelDetails
    {
        //Name and Rate

        public string hotelName = "^[A-Z][a-z][0-9]?";
        public int rate;

        /// Parametrised Constructor
        public HotelDetails(string hotelName, int rate)
        {
            this.hotelName = hotelName;
            this.rate = rate;
        }
    }
}
