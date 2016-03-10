using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Lib;

namespace Travel_Tours
{
    public partial class frmControlPanel : Form
    {
        public frmControlPanel()
        {
            InitializeComponent();
        }

        private void frmControlPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                WinForms.CP.Hide();
                WinForms.IV.Hide();
                WinForms.LF.Show();
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void frmControlPanel_Activated(object sender, EventArgs e)
        {
            statusLabelUser.Text = Credentials.UserName;
            statusLabelPosition.Text = Credentials.Position;

            btnManageUsers.Enabled = Tours.isFacilitator();
        }

        private void btnViewTours_Click(object sender, EventArgs e)
        {
            WinForms.IV.Show();
        }
    }
}
