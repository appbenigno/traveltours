using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SQL_Lib;

namespace Travel_Tours
{
    public partial class Edit_Information : Form
    {
        Tours tour = new Tours(new Connections(".\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS"));
        public Edit_Information()
        {
            InitializeComponent();
        }

        private void Edit_Information_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void button_EDIT_ITINERARY_Click(object sender, EventArgs e)
        {
            tour.modifyItineraryInfo(dataGridView_EDIT_IT_INFO);
            tour.viewItineraryInfo(dataGridView_EDIT_IT_INFO);
        }

        private void button_EDIT_TOUR_GUIDES_Click(object sender, EventArgs e)
        {
            tour.modifyTourGuides(dataGridView_EDIT_TOUR_GUIDES);
            tour.viewTourGuides(dataGridView_EDIT_TOUR_GUIDES);
        }

        private void button_EDIT_BUS_INFORMATION_Click(object sender, EventArgs e)
        {
            tour.modifyBusInfo(dataGridView_EDIT_BUS_INFO);
            tour.viewBusInfo(dataGridView_EDIT_BUS_INFO);
        }

        private void button_EDIT_INFO_Click(object sender, EventArgs e)
        {
            tour.modifyTourInfo(dataGrid_EDIT_TOURINFO);
            tour.viewTourInfo(dataGrid_EDIT_TOURINFO);
        }

        private void tabBusInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void tabTourGuides_Click(object sender, EventArgs e)
        {
            
        }

        private void tabTourItinerary_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl_TourInfo_Click(object sender, EventArgs e)
        {
        }

        private void Edit_Information_Load(object sender, EventArgs e)
        {
            tour.viewTourInfo(dataGrid_EDIT_TOURINFO);
            tour.viewTourGuides(dataGridView_EDIT_TOUR_GUIDES);
            tour.viewBusInfo(dataGridView_EDIT_BUS_INFO);
            tour.viewItineraryInfo(dataGridView_EDIT_IT_INFO);
        }
    }
}
