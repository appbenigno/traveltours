﻿using System;
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
        Query qr = new Query(new Connections("FAMILY-PC\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS"));
        //------------------------------------------------------

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void txtCLI_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
            if (qr.isExist("USER_CREDENTIALS", "U_NAME", txtUsername.Text, "U_PASS", txtPassword.Text))
            {
                MessageBox.Show("found");
            }
            else
            {
                MessageBox.Show("not found");
            }
        }
    }
}
