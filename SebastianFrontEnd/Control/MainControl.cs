
namespace SebastianFrontEnd.Control
{
    class MainControl
    {
        #region Fields

        private static SebastianService.SebastianWSClient client = new SebastianService.SebastianWSClient();
        private SebastianService.Airport[] airports;

        #endregion

        #region Properties

        public SebastianService.Airport[] Airports
        {
            get { return airports; }
        }

        #endregion

        public SebastianService.Airport[] GetAllAirports()
        {
            airports = client.GetAllAirports();
            return airports;
        }

        public SebastianService.Schedule GetSchedule(int airportIndex)
        {
            if (airportIndex > -1)
                return client.GetSchedule(airports[airportIndex]);
            else
                return new SebastianService.Schedule();
        }

        public bool BookFlight(SebastianService.Flight flight)
        {
            return client.BookFlight(flight, 1);
        }
    }
}
