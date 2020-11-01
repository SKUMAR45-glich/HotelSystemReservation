using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservationSystem;
using System.Linq;
namespace HotelReservationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestforCountofHotels()
        {
            HotelReservation hotelReservation = new HotelReservation();
            hotelReservation.AddHotel(new HotelDetails("Lakewood", 110));
            hotelReservation.AddHotel(new HotelDetails("Bridgewood", 160));
            hotelReservation.AddHotel(new HotelDetails("Ridgewood", 220));

            int expected = 3;
            int actual = hotelReservation.hotelDetails.Count();

            Assert.AreEqual(expected, actual);
        }
    }
}
