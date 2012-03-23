using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SebastianWS.Controller;
using SebastianWS.DTO;

namespace SebastianWebService.Tests
{
    class MockDataProvider : IDataProvider
    {
        public Airport[] GetAllAirports()
        {
            throw new NotImplementedException();
        }

        public Schedule GetSchedule(Airport airport)
        {
            throw new NotImplementedException();
        }

        public bool ReserveSeat(Flight flight)
        {
            return flight.AvailableSeats > 0;
        }
    }
}
