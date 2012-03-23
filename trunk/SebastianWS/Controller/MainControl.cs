using SebastianWS.DTO;

namespace SebastianWS.Controller
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

        public bool BookFlight(Flight flight, int numberSeats)
        {
            return dataProvider.Reserve(flight, numberSeats);
        }
    }
}