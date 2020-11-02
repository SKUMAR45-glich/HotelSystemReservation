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
            hotelReservation.AddHotel(new HotelDetails("Lakewood", 110));
            hotelReservation.AddHotel(new HotelDetails("Bridgewood", 150));
            hotelReservation.AddHotel(new HotelDetails("Ridgewood", 220));

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
            hotelReservation.AddHotel(new HotelDetails("Lakewood", 110));
            hotelReservation.AddHotel(new HotelDetails("Bridgewood", 150));
            hotelReservation.AddHotel(new HotelDetails("Ridgewood", 220));

            ////Check cheapest available hotel
            HotelDetails cheapestHotel = hotelReservation.CheapestHotelandRateforDateRange(startDate, endDate);
            string expected = "Lakewood";
            string actual = cheapestHotel.hotelName;

            ////Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
