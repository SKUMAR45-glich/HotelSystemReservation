using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class CustomExceptions : Exception
    {
        public enum ExceptionType 
        {
            INVALID_NAME,
            INVALID_StartDate,
            INVALID_EndDate,
            
        }

        ExceptionType type;

        /// <summary>
        /// Parameter Constructor For Setting Exception type And Throwing Exception.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public CustomExceptions(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
