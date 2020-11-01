using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelReservation
    {
        public List<HotelDetails> hotelDetails = new List<HotelDetails>();

        
        public void AddHotel(HotelDetails newHotelAdd)
        {
            this.hotelDetails.Add(newHotelAdd);
        }


        /// Display the hotel names and their rates
       
        public void DisplayHotels()
        {
            Console.WriteLine("Welcome to the Hotels\n");
            foreach (var hotel in this.hotelDetails)
            {
                Console.WriteLine($"Hotel Name: {hotel.hotelName} and Rate: {hotel.regularRate}");
            }
        }
    }
}
