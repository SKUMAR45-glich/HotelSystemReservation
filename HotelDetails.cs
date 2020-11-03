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
        public int rating;
        public int special_cust_rate;
        public int special_cust_weekendrate;

        /// Parametrised Constructor
        public HotelDetails(string hotelName, int rate, int weekendrate, int rating, int special_cust_rate,int special_cust_weekendrate)
        {
            this.hotelName = hotelName;
            this.rate = rate;
            this.weekendrate = weekendrate;
            this.rating = rating;
            this.special_cust_rate = special_cust_rate;
            this.special_cust_weekendrate = special_cust_weekendrate;
        }
    }
}
