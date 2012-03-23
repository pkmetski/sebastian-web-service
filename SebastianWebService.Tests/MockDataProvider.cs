using System;
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

        public bool Reserve(Flight flight, int numberSeats)
        {
            return flight.AvailableSeats >= numberSeats;
        }
    }
}
