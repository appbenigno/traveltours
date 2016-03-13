using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Tours
{
    public partial class Information_Viewer : Form
    {
        Tours tour = new Tours(new SQL_Lib.Connections(".\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS"));
        public Information_Viewer()
        {
            InitializeComponent();
        }

        private void Information_Viewer_Load(object sender, EventArgs e)
        {
            // Tour Information Viewer window
            // Displays information and tour details
            // FOR TOUR FACILITATORS: ANYTHING IS EDITABLE AND DELETABLE
        }

        private void comboBox_Information_Viewer_SelectedIndexChanged(object sender, EventArgs e)
        {
            tour.display(comboBox_Information_Viewer, Elmanjovin_Database_Viewer);
        }

        private void Information_Viewer_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Information_Viewer_Activated(object sender, EventArgs e)
        {
            tour.display(comboBox_Information_Viewer, Elmanjovin_Database_Viewer);
            button_Edit_Info.Enabled = Tours.isFacilitator();
            button_DELETE_INFORMATION.Enabled = Tours.isFacilitator();

                //btnManageUsers.Enabled = Tours.isFacilitator();
        }

        private void button_Edit_Info_Click(object sender, EventArgs e)
        {
            Edit_Information Edit_Information_Window = new Edit_Information();

            Edit_Information_Window.Show();
        }

        private void button_DELETE_INFORMATION_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this row?","Confirm delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedIndex = Elmanjovin_Database_Viewer.SelectedCells[0].RowIndex;
                string primaryKey = Elmanjovin_Database_Viewer.Rows[selectedIndex].Cells["TOUR_CODE"].Value.ToString();
                tour.Command = "delete from BUS_INFORMATION where TOUR_CODE = " + primaryKey;
                tour.deleteEntry(tour.Command);
                tour.Command = "delete from TOUR_GUIDES where TOUR_CODE = " + primaryKey;
                tour.deleteEntry(tour.Command);
                tour.Command = "delete from ITINERARY_INFORMATION where TOUR_CODE = " + primaryKey;
                tour.deleteEntry(tour.Command);
                tour.Command = "delete from TOUR_INFORMATION where TOUR_CODE = " + primaryKey;
                tour.deleteEntry(tour.Command);
                tour.display(comboBox_Information_Viewer, Elmanjovin_Database_Viewer);
            }
        }
    }
}
