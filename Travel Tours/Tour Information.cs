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
    public partial class Tour_Information : Form
    {
        public Tour_Information()
        {
            InitializeComponent();
        }

        private void Tour_Information_Load(object sender, EventArgs e)
        {
            Itineraries_Button.Enabled = false;
 
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Hue Hue Hue

        }

        private void Itineraries_Button_Click(object sender, EventArgs e)
        {
            Add_Itinerary Itinerary_Window = new Add_Itinerary();
            Itinerary_Window.Show();
        }

        private void texBox_TourCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_ADD_TOUR_Click(object sender, EventArgs e)
        {

            try
            {
                SQL_Lib.Query AddTour = new SQL_Lib.Query();
                AddTour.Add(1002, textBox_CompanyInfo.Text, dateTimePicker_START.Value.Date, dateTimePicker_END.Value.Date, int.Parse(textBox_PAX.Text), int.Parse(textBox_Num_Tour_Guides.Text), int.Parse(textBox_Num_Buses.Text));
                MessageBox.Show("Tour added! you can now put in itineraries, click the 'Itineraries' button to start.");
                button_ADD_TOUR.Enabled = false;
                Itineraries_Button.Enabled = true;
            }
            catch(Exception Except)
            {
                MessageBox.Show(Except.Message.ToString() + "\nDid you leave some fields empty?\nyou might have entered an incorrect format to a field.");
            }
           
        }

        private void PreviewInfo_Button_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox_Preview.AppendText
                (
                  "Tour Code: " + texBox_TourCode.Text + "\nCompany/School name: " + textBox_CompanyInfo.Text + "\n Tour Start: " + dateTimePicker_START.Text + "\nTour End: " + dateTimePicker_END.Text + "\n Number of Passengers: " + textBox_PAX.Text + "\nNumber of Tour Guide/Facilitators: " + textBox_Num_Tour_Guides.Text + "\nNumber of Buses: " + textBox_Num_Buses.Text + " "
                );
            }
            catch (Exception Preview_Exception)
            {
                MessageBox.Show("Specific error message: "+ Preview_Exception.Message.ToString());
            }
            
        }

        private void button_Clear_Info_Preview_Click(object sender, EventArgs e)
        {
            richTextBox_Preview.ResetText();
        }

        private void dateTimePicker_START_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
