using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SebastianWS.DTO;

namespace SebastianWS.Controller
{
    public interface IDataProvider
    {
        Airport[] GetAllAirports();
        Schedule GetSchedule(Airport airport);
        bool ReserveSeat(Flight flight);
    }
}