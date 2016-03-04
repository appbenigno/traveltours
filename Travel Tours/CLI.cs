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
    public partial class frmCLI : Form
    {
        /// <summary>
        /// Database Connection Settings
        /// </summary>
        /// 
        Query qr = new Query(new Connections("FAMILY-PC\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS"));
        //------------------------------------------------------

        public frmCLI()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            MessageBox.Show(qr.isExist("ITINERARY_INFORMATION", "TOUR_ITINERARY_CODE", "2000", "TOUR_CODE", "100").GetHashCode().ToString());
        }

        private void txtCLI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Enter)))
            {
                qr.CommandExec(txtCLI, dataGridSched);
            }
        }

        private void frmCLI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                WinForms.CL.Hide();
            }
        }
    }
}
