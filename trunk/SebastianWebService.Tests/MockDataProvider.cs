using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SebastianWebService.Controller;

namespace SebastianWebService.Tests
{
    class MockDataProvider : IDataProvider
    {
        public DTO.Airport[] GetAllAirports()
        {
            throw new NotImplementedException();
        }

        public DTO.Schedule GetSchedule(DTO.Airport airport)
        {
            throw new NotImplementedException();
        }

        public bool ReserveSeat(DTO.Flight flight)
        {
            return flight.AvailableSeats > 0;
        }
    }
}
