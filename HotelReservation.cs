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

        DateTime startdate = new DateTime(2020, 1, 1);
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
                
                var price = Int32.MaxValue;

                foreach (HotelDetails hotels in hotelDetails)
                {
                    price = Math.Min(price, CalculateTotalBill(hotels, startDate, endDate));
                }

                foreach (HotelDetails hotels in hotelDetails)
                {
                    if (CalculateTotalBill(hotels, startDate, endDate) == price)
                    {
                        cheapestHotel = hotels;
                    }
                }

                return cheapestHotel;

            }
        }

        //To Calculate Total Bill of a particular Hotel
        public int CalculateTotalBill(HotelDetails hotelDetails,DateTime startDate,DateTime endDate)
        {
            TimeSpan timeSpan = endDate.Subtract(startDate);
            int dateRange = Convert.ToInt32(timeSpan.TotalDays);
            int weekDays = CheckforWeekDays(startDate, endDate);
            int weekEnds = dateRange - weekDays;

            int totalRate = (weekDays * hotelDetails.rate) + (weekEnds * hotelDetails.weekendrate);
            return totalRate;
        }

        //Check for the weekdays and weekends
        public int CheckforWeekDays(DateTime startDate, DateTime endDate)
        {
            int numberofDays = 0;
            while (startDate <= endDate)
            {
                ////Checking start days is Weekend or not
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    numberofDays++;
                }

                startDate = startDate.AddDays(1);
            }
            return numberofDays;
        }

        //Get the Cheapest and Best Rated Hotel

        public HotelDetails CheapestandBestRatedHotel(DateTime startDate, DateTime endDate)
        {
            var cheapestHotel = CheapestHotelandRateforDateRange(startDate, endDate);
            int maxrating = Int32.MinValue;
            HotelDetails cheapandbesthotel = hotelDetails[0];

            foreach (HotelDetails hotels in hotelDetails)
            {
                maxrating = Math.Max(maxrating, hotels.rating);
            }

            foreach (HotelDetails hotels in hotelDetails)
            {
                if (maxrating == hotels.rating)
                {
                    cheapandbesthotel = hotels;
                }
            }
            return cheapandbesthotel;
        }

    }
}
