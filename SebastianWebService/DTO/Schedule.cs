﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SebastianWebService.DTO
{
    public class Schedule
    {
        #region Fields

        private DTO.Flight[] flights = new Flight[0];

        #endregion

        #region Properties

        public Flight[] Flights
        {
            get { return flights; }
            set { flights = value; }
        }

        #endregion

        public Schedule() { }

        public Schedule(DTO.Flight[] flights)
        {
            this.flights = flights;
        }
    }
}