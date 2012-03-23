using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SebastianWS.DTO
{
    public class Flight
    {
        #region Fields

        private int flightId;
        private Airport from;
        private Airport to;
        private DateTime departureTime;
        private DateTime arrivalTime;
        private double price;
        private int availableSeats;

        #endregion

        #region Properties

        public int FlightId
        {
            get { return flightId; }
            set { flightId = value; }
        }

        public Airport From
        {
            get { return from; }
            set { from = value; }
        }

        public Airport To
        {
            get { return to; }
            set { to = value; }
        }

        public DateTime DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }

        public DateTime ArrivalTime
        {
            get { return arrivalTime; }
            set { arrivalTime = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int AvailableSeats
        {
            get { return availableSeats; }
            set { availableSeats = value; }
        }

        #endregion

        public Flight() { }
        public Flight(int flightId, Airport from, Airport to, DateTime departureTime, DateTime arrivalTime, double price, int availableSeats)
        {
            this.flightId = flightId;
            this.from = from;
            this.to = to;
            this.departureTime = departureTime;
            this.arrivalTime = arrivalTime;
            this.price = price;
            this.availableSeats = availableSeats;
        }
    }
}