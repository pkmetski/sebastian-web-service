using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SebastianFrontEnd.SebastianService;
using SebastianFrontEnd.Control;

namespace SebastianFrontEnd
{
    public partial class BookFlightGUI : Form
    {
        Flight[] flights;
        private event GetScheduleGUI.FlightsSelected flightsSelected;

        public BookFlightGUI(GetScheduleGUI.FlightsSelected flightsSelected, Flight[] flights)
        {
            this.flightsSelected = flightsSelected;
            this.flights = flights;
            InitializeComponent();

            this.AutoSize = true;


            RadioButton rb;

            if (flights != null)
            {
                tableLayoutPanel1.RowCount = flights.Length + 1;
                for (int i = 0; i < flights.Length; i++)
                {
                    rb = new RadioButton();
                    rb.Name = i.ToString();
                    rb.Text = GetFlightDescription(flights[i]);
                    rb.AutoSize = true;
                    tableLayoutPanel1.Controls.Add(rb);
                }
                Button btn = new Button();
                btn.Text = "Book";
                btn.Click += new EventHandler(btn_Click);
                tableLayoutPanel1.Controls.Add(btn);
            }
            this.Width -= 20;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            List<Flight> selected = new List<Flight>();
            foreach (System.Windows.Forms.Control ctr in tableLayoutPanel1.Controls)
            {
                if (ctr is RadioButton)
                {
                    if (((RadioButton)ctr).Checked)
                    {
                        selected.Add(flights[int.Parse(((RadioButton)ctr).Name)]);
                    }
                }
            }
            flightsSelected(selected.ToArray());
            this.Close();
        }

        private string GetFlightDescription(Flight flight)
        {
            return string.Format
                          ("From: {0}" + Environment.NewLine +
                          "To: {1}" + Environment.NewLine +
                          "Departure Time: {2}" + Environment.NewLine +
                          "Arrival Time: {3}" + Environment.NewLine +
                          "Price: {4}" + Environment.NewLine +
                          "Seats Available: {5}",
                          flight.From.Name, flight.To.Name, flight.DepartureTime, flight.ArrivalTime, flight.Price, flight.AvailableSeats);
        }
    }
}
