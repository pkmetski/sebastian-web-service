using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SebastianWebService.DTO;

namespace SebastianWebService.Controller
{
    public class MainControl
    {
        private IDataProvider dataProvider;

        public MainControl(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        public Airport[] GetAllAirports()
        {
            return dataProvider.GetAllAirports();
        }

        public Schedule GetSchedule(Airport airport)
        {
            return dataProvider.GetSchedule(airport);
        }

        public bool BookFlight(Flight flight)
        {
            return dataProvider.ReserveSeat(flight);
        }
    }
}