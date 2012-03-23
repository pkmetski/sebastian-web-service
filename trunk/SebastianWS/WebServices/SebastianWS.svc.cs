using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SebastianWS.Controller;

namespace SebastianWS.WebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SebastianWS" in code, svc and config file together.
    public class SebastianWS : ISebastianWS
    {
        private static IDataProvider dataProvider = new StaticDataProvider();
        private MainControl ctr = new MainControl(dataProvider);

        public bool BookFlight(DTO.Flight flight)
        {
            return ctr.BookFlight(flight);
        }

        public DTO.Schedule GetSchedule(DTO.Airport airport)
        {
            return ctr.GetSchedule(airport);
        }

        public DTO.Airport[] GetAllAirports()
        {
            return ctr.GetAllAirports();
        }
    }
}
