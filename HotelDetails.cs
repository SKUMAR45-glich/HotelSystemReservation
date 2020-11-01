using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelDetails
    {
        //Name and Rate

        public string hotelName = "^[A-Z][a-z][0-9]?";
        public int regularRate;

        /// Parametrised Constructor
        public HotelDetails(string hotelName, int regularRate)
        {
            this.hotelName = hotelName;
            this.regularRate = regularRate;
        }
    }
}
