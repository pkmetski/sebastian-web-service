using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SebastianWebService.Controller;

namespace SebastianWebService.WebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SebastianWebService" in code, svc and config file together.
    public class SebastianWebService : ISebastianWebService
    {

        private static MainControl ctr = new MainControl(new StaticDataProvider());

        public bool BookFlight(DTO.Flight flight)
        {
            return ctr.BookFlight(flight);
        }

        public DTO.Schedule GetSchedule(DTO.Airport airport)
        {
            return ctr.GetSchedule(airport);
        }

        DTO.Airport[] ISebastianWebService.GetAllAirports()
        {
            return ctr.GetAllAirports();
        }
    }
}
