using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SebastianWebService.DTO;

namespace SebastianWebService.Controller
{
    public interface IDataProvider
    {
        Airport[] GetAllAirports();
        Schedule GetSchedule(Airport airport);
        bool ReserveSeat(Flight flight);
    }
}