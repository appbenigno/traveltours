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
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Database Connection Settings
        /// </summary>
        /// 
        Query qr = new Query(new Connections(".\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS"));
        //------------------------------------------------------
        StoredProc sp = new StoredProc();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SQL_Lib.SQL_Lib.initializeStoredProcedures(qr.Connection);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you want to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (qr.isExist("USER_CREDENTIALS", "U_NAME", txtUsername.Text, "U_PASS", txtPassword.Text) && txtUsername.Text != "" && txtPassword.Text != "")
            {
                Credentials.StoreCredentials(
                    txtUsername.Text,
                    qr.getData("USER_CREDENTIALS", "U_NAME", txtUsername.Text, "U_EMAIL"),
                    qr.getData("USER_CREDENTIALS", "U_NAME", txtUsername.Text, "U_GIVENNAME"),
                    qr.getData("USER_CREDENTIALS", "U_NAME", txtUsername.Text, "U_FAMILYNAME"),
                    qr.getData("USER_CREDENTIALS", "U_NAME", txtUsername.Text, "U_POSITION")
                    );
                WinForms.CP.Show();
                WinForms.LF.Hide();
            }
            else
            {
                MessageBox.Show("Invalid user name or password!","Invalid Credentials",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
