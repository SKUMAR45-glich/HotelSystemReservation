using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservationSystem;
using System.Linq;
using System;

namespace HotelReservationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenDetailsforDisplayingDetailsofHotel()
        {
            HotelReservation hotelReservation = new HotelReservation();
            hotelReservation.AddHotel(new HotelDetails("Lakewood", 110 ,90,3));
            hotelReservation.AddHotel(new HotelDetails("Bridgewood", 150,50,4));
            hotelReservation.AddHotel(new HotelDetails("Ridgewood", 220,150,5));

            string expected = "Hotel Name: Lakewood and RegularRate: Bridgewood and WeekendRate: Ridgewood";
            string actual = hotelReservation.DisplayHotels();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenDetailsforCheapestHotelinaDateRange()
        {
            string start = "2 Nov 2020";
            DateTime startDate = DateTime.Parse(start);
            string end = "4 Nov 2020";
            DateTime endDate = DateTime.Parse(end);
            HotelReservation hotelReservation = new HotelReservation();
            hotelReservation.AddHotel(new HotelDetails("Lakewood", 110, 90, 3));
            hotelReservation.AddHotel(new HotelDetails("Bridgewood", 150, 50, 4));
            hotelReservation.AddHotel(new HotelDetails("Ridgewood", 220, 150, 5));

            ////Check cheapest available hotel
            HotelDetails cheapestHotel = hotelReservation.CheapestHotelandRateforDateRange(startDate, endDate);
            string expected = "Lakewood and Bridgewood";
            string actual = cheapestHotel.hotelName;

            ////Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
