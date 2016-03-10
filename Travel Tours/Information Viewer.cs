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
        }
    }
}
