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

        public string DisplayHotels()
        {
            Console.WriteLine("Welcome to the Hotels\n");
            try
            {
                foreach (var hotel in this.hotelDetails)
                {
                    return $"Hotel Name: {hotel.hotelName}, RegularRate: {hotel.rate}, WeekendRate: {hotel.weekendrate} and rating: {hotel.rating}";
                }
            }
            catch (CustomExceptions)
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_NAME, "Please Enter valid Name of Hotel");
                
            }
            return "Wrong Name";
        }

        //Find Hotels with cheapest rate

        DateTime startdate = new DateTime(2020, 1, 11);
        DateTime enddate = new DateTime(2020, 4, 11);

        public HotelDetails CheapestHotelandRateforDateRange(DateTime startDate, DateTime endDate)
        {
            int startvalue = DateTime.Compare(startdate, startDate);
            int endvalue = DateTime.Compare(endDate, enddate);
            HotelDetails cheapestHotel = hotelDetails[0];
            try
            {
                if (startvalue < 0)
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_StartDate, "Please book after 1st Nov");
                }
                if (endvalue < 0)
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_EndDate, "No vaccancies after 4th Nov");
                }
                return cheapestHotel; 
            }
            catch
            {
                TimeSpan timeSpan = endDate.Subtract(startDate);
                double dateRange = timeSpan.TotalDays;
                

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
}
