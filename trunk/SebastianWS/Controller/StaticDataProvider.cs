using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SebastianWS.Controller
{
    public class StaticDataProvider : IDataProvider
    {
        #region Fields

        private static DTO.Airport[] airports = new DTO.Airport[] 
        { 
        new DTO.Airport(1, "JFK"),
        new DTO.Airport(2, "Heathrow"),
        new DTO.Airport(3, "Charles de Gaulle"),
        new DTO.Airport(4, "San Francisco"),
        new DTO.Airport(5, "Sydney"),
        new DTO.Airport(6, "Munich"),
        };

        private DTO.Flight[] staticSchedule = new DTO.Flight[]
        {
        new DTO.Flight(1, airports[0],airports[1],new DateTime(1999,12,21,22,00,00),new DateTime(1999,12,21,23,00,00),100,0),
        new DTO.Flight(2,airports[1],airports[2],new DateTime(2001,05,26,07,00,00),new DateTime(2001,05,26,12,00,00),200,1),
        new DTO.Flight(3,airports[2],airports[3],new DateTime(2002,08,12,13,30,00),new DateTime(2002,08,12,16,30,00),300,2),
        new DTO.Flight(4,airports[3],airports[4],new DateTime(2003,02,28,18,00,00),new DateTime(2003,02,28,18,30,00),400,50),
        new DTO.Flight(5,airports[4],airports[5],new DateTime(2004,01,31,20,00,00),new DateTime(2004,01,31,00,00,00),500,12)
        };

        private DTO.Schedule schedule;

        #endregion

        public StaticDataProvider()
        {
            schedule = new DTO.Schedule(staticSchedule);
        }

        public DTO.Airport[] GetAllAirports()
        {
            return airports;
        }

        /*Returns all flights from/to the specified airport*/
        public DTO.Schedule GetSchedule(DTO.Airport airport)
        {
            return new DTO.Schedule
                (
                staticSchedule.Where(f => { return f.To.ID == airport.ID || f.From.ID == airport.ID; }).ToArray()
                );
        }

        public bool ReserveSeat(DTO.Flight flight)
        {
            bool booked = false;
            for (int i = 0; i < staticSchedule.Length; i++)
            {
                if (staticSchedule[i].FlightId == flight.FlightId)
                {
                    if (staticSchedule[i].AvailableSeats > 0)
                    {
                        staticSchedule[i].AvailableSeats--;
                        booked = true;
                    }
                    break;
                }
            }
            return booked;
        }
    }
}