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
        
        

        /// Parametrised Constructor
        public HotelDetails(string hotelName, int rate)
        {
            this.hotelName = hotelName;
            this.rate = rate;
            
            
        }
    }
}
