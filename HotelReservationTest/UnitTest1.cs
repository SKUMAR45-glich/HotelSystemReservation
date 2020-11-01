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
        public void GivenDetailsforCountfornumberofhotels()
        {
            HotelReservation hotelReservation = new HotelReservation();
            hotelReservation.AddHotel(new HotelDetails("Lakewood", 110));
            hotelReservation.AddHotel(new HotelDetails("Bridgewood", 160));
            hotelReservation.AddHotel(new HotelDetails("Ridgewood", 220));

            int expected = 3;
            int actual = hotelReservation.hotelDetails.Count();

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
            hotelReservation.AddHotel(new HotelDetails("Bridgewood", 160));
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
