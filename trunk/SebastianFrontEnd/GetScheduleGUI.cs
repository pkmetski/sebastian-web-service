using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SebastianFrontEnd.Control;
using SebastianFrontEnd.SebastianService;

namespace SebastianFrontEnd
{
    public partial class GetScheduleGUI : Form
    {
        private MainControl ctr = new MainControl();
        public delegate void FlightsSelected(Flight[] flights);
        private event FlightsSelected selFlights;

        public GetScheduleGUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            selFlights = GetSelectedFlights;
            foreach (SebastianService.Airport a in ctr.GetAllAirports())
            {
                comboBox1.Items.Add(a.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var flights = ctr.GetSchedule(comboBox1.SelectedIndex).Flights;
            var bookWindow = new BookFlightGUI(selFlights, flights);
            bookWindow.StartPosition = FormStartPosition.CenterParent;
            bookWindow.ShowDialog(this);
        }

        private void GetSelectedFlights(Flight[] selected)
        {
            bool success = ctr.BookFlight(selected[0]);
            MessageBox.Show(success ? "Flight Booked" : "Booking Failed");
        }
    }
}
