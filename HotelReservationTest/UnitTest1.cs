using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservationSystem;
using System.Linq;
using System;

namespace HotelReservationTest
{
    [TestClass]
    public class UnitTest1
    {
        HotelReservation hotelReservation = new HotelReservation();

        //UC5 To get the rating of the Hotel

        [TestMethod]
        public void GivenDetailsforDisplayingDetailsofHotel()
        {
            hotelReservation.AddHotel(new HotelDetails("Lakewood", 110, 90, 3,80,80));
            hotelReservation.AddHotel(new HotelDetails("Bridgewood", 150, 50, 4,110,50));
            hotelReservation.AddHotel(new HotelDetails("Ridgewood", 220, 150,5, 100,40));

            string expected = "Hotel Name: Lakewood, RegularRate: 110, WeekendRate: 90 and rating: 3";
            string actual = hotelReservation.DisplayHotels();

            Assert.AreEqual(expected, actual);
        }

        //UC4_Cheapest Hotel in Week and Weekend

        [TestMethod]
        public void GivenDetailsforCheapestHotelinaDateRange()
        {
            var startDate = Convert.ToDateTime("11Sep2020");
            var endDate = Convert.ToDateTime("12Sep2020");

            hotelReservation.AddHotel(new HotelDetails("Lakewood", 110, 90, 3, 80, 80));
            hotelReservation.AddHotel(new HotelDetails("Bridgewood", 150, 50, 4, 110, 50));
            hotelReservation.AddHotel(new HotelDetails("Ridgewood", 220, 150, 5, 100, 40));

            ////Check cheapest available hotel
            HotelDetails cheapestHotel = hotelReservation.CheapestHotelandRateforDateRange(startDate, endDate);
            string expected = "Lakewood";
            string actual = cheapestHotel.hotelName;

            ////Assert
            Assert.AreEqual(expected, actual);
        }

        //UC6 to check for cheapandbestratedHotel

        [TestMethod]
        public void GivenDetailsforCheapestBestRatedHotelinaDateRange()
        {
            var startDate = Convert.ToDateTime("11Sep2020");
            var endDate = Convert.ToDateTime("13Sep2020");
            hotelReservation.AddHotel(new HotelDetails("Lakewood", 110, 90, 3, 80, 80));
            hotelReservation.AddHotel(new HotelDetails("Bridgewood", 150, 50, 4, 110, 50));
            hotelReservation.AddHotel(new HotelDetails("Ridgewood", 220, 150, 5, 100, 40));

            ////Check cheapest available hotel 
            HotelDetails cheapestbestratedHotel = hotelReservation.CheapestHotelandRateforDateRange(startDate, endDate);
            string expected = "Bridgewood";
            string actual = cheapestbestratedHotel.hotelName;
            Assert.AreEqual(expected, actual);

            int expectedrate = 4;
            int actualrate = cheapestbestratedHotel.rating;
            Assert.AreEqual(expectedrate, actualrate);

            int expectedbill = 200;
            int actualbill = hotelReservation.CalculateTotalBill(cheapestbestratedHotel, startDate, endDate);
            Assert.AreEqual(expectedbill, actualbill);
        }

        //UC7 to get the best Rated Hotel 

        [TestMethod]
        public void GivenDetailsforBestRatedHotelinaDateRange()
        {
            var startDate = Convert.ToDateTime("11Sep2020");
            var endDate = Convert.ToDateTime("12Sep2020");
            hotelReservation.AddHotel(new HotelDetails("Lakewood", 110, 90, 3, 80, 80));
            hotelReservation.AddHotel(new HotelDetails("Bridgewood", 150, 50, 4, 110, 50));
            hotelReservation.AddHotel(new HotelDetails("Ridgewood", 220, 150, 5, 100, 40));

            ////Check best rated available hotel 
            HotelDetails bestratedHotel = hotelReservation.CheapestHotelandRateforDateRange(startDate, endDate);
            string expected = "Ridgewood";
            string actual = bestratedHotel.hotelName;
            Assert.AreEqual(expected, actual);

            int expectedbill = 370;
            int actualbill = hotelReservation.CalculateTotalBill(bestratedHotel, startDate, endDate);
            Assert.AreEqual(expectedbill, actualbill);
        }

        //UC9 to add special rate for loyal customers

        [TestMethod]
        public void GivenDetailsforSpecialrateforloyalcustomers()
        {
            HotelDetails loayaltyrate = hotelReservation.Weekandweekendrateforspecialcustomer(DateTime startDate, DateTime endDate)
            string expected = "Ridgewood";
            string actual = loayaltyrate.hotelName;
            Assert.AreEqual(expected, actual);

            int expectedcost = 100;
            int actualrate = loayaltyrate.special_cust_rate;
            Assert.AreEqual(expectedcost, actualrate);

            int expectedcostatweekend = 40;
            int actualcost = loayaltyrate.special_cust_weekendrate;
            Assert.AreEqual(expectedcostatweekend, actualcost);
        }
    }
}
