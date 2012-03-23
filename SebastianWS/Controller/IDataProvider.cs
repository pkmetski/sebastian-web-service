using SebastianWS.DTO;

namespace SebastianWS.Controller
{
    public interface IDataProvider
    {
        Airport[] GetAllAirports();
        Schedule GetSchedule(Airport airport);
        bool Reserve(Flight flight, int numberSeats);
    }
}