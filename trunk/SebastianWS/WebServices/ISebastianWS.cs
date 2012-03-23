using System.ServiceModel;
using SebastianWS.DTO;

namespace SebastianWS.WebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISebastianWS" in both code and config file together.
    [ServiceContract]
    public interface ISebastianWS
    {
        [OperationContract]
        DTO.Airport[] GetAllAirports();

        [OperationContract]
        Schedule GetSchedule(DTO.Airport airport);

        [OperationContract]
        bool BookFlight(DTO.Flight flight, int numberSeats);
    }
}
