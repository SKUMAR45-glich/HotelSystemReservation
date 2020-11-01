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
                Console.WriteLine($"Hotel Name: {hotel.hotelName} and Rate: {hotel.rate}");
            }
        }

        //Find Hotels with cheapest rate

        DateTime startdate = new DateTime(2020, 1, 11);
        DateTime enddate = new DateTime(2020, 4, 11);

        public HotelDetails CheapestHotelandRateforDateRange(DateTime startDate, DateTime endDate)
        {
            TimeSpan timeSpan = endDate.Subtract(startDate); 
            double dateRange = timeSpan.TotalDays;  
            HotelDetails cheapestHotel = hotelDetails[0]; 

            ////Calculation of total bill:
            double totalRate = dateRange * cheapestHotel.rate;

            foreach (HotelDetails hotels in hotelDetails)
            {
                if (hotels.rate < cheapestHotel.rate)
                {
                    cheapestHotel = hotels;
                }
            }
            Console.WriteLine("Cheapest hotel in the date range" + cheapestHotel.hotelName);
            Console.WriteLine("Total Rate of cheapest Hotel: " + totalRate);
            return cheapestHotel;
        }
    }
}
