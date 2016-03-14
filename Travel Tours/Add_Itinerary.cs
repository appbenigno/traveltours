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
    public partial class Add_Itinerary : Form
    {
        public Add_Itinerary()
        {
            InitializeComponent();
        }

        private void button_ADD_INFO_Click(object sender, EventArgs e)
        {
            try
            {
                Query ADD_ITINERARY_DATABASE = new Query(new Connections(".\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS"));
                Query ADD_TOUR_GUIDES = new Query(new Connections(".\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS"));
                Query ADD_BUS_INFORMATION = new Query(new Connections(".\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS"));
                ADD_ITINERARY_DATABASE.ADD_ITINERARY(dataGridView_Tour_Itineraries);
                ADD_TOUR_GUIDES.ADD_TOUR_GUIDE(dataGridView_Tour_Guide_Information);
                ADD_BUS_INFORMATION.BUS_INFORMATION(dataGridView_Bus_Information);

                MessageBox.Show("Informations Successfully added!");
            }
            catch(Exception ADD_ITINERARY)
            {
                MessageBox.Show("Error: " + ADD_ITINERARY.Message.ToString());
            }
            

          /*  string StrQuery;
try
{
    using (SqlConnection conn = new SqlConnection(ConnString))
    {
        using (SqlCommand comm = new SqlCommand())
        {
            comm.Connection = conn;
            conn.Open();
            for(int i=0; i< dataGridView1.Rows.Count;i++)
            {
                StrQuery= @"INSERT INTO tableName VALUES (" 
                    + dataGridView1.Rows[i].Cells["ColumnName"].Value +", " 
                    + dataGridView1.Rows[i].Cells["ColumnName"].Value +");";
                comm.CommandText = StrQuery;
                comm.ExecuteNonQuery();
            }
        }
    }
}*/
        }

        private void Add_Itinerary_Load(object sender, EventArgs e)
        {
            Query INCREMENT_CODE = new Query(new Connections(".\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS"));
            dataGridView_Tour_Itineraries.Rows[0].Cells[0].Value = INCREMENT_CODE.Increment_Counter("TOUR_ITINERARY_CODE", "ITINERARY_INFORMATION");
            dataGridView_Tour_Guide_Information.Rows[0].Cells[0].Value = INCREMENT_CODE.Increment_Counter("TOUR_GUIDE_ID", "TOUR_GUIDES");
            dataGridView_Bus_Information.Rows[0].Cells[0].Value = INCREMENT_CODE.Increment_Counter("BUS_INFO_ID", "BUS_INFORMATION");

           
        }

        /*private void dataGridView1_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
{
    e.Row.Cells["Region"].Value = "WA";
    e.Row.Cells["City"].Value = "Redmond";
    e.Row.Cells["PostalCode"].Value = "98052-6399";
    e.Row.Cells["Country"].Value = "USA";
    e.Row.Cells["CustomerID"].Value = NewCustomerId();
}*/

        private void dataGridView_Tour_Itineraries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Tour_Itineraries_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            
            Query STATIC_CODE = new Query(new Connections(".\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS"));
            e.Row.Cells["Column_TourCode"].Value = STATIC_CODE.STATIC_CODE_GETTER("TOUR_CODE", "ITINERARY_INFORMATION");

            //  dataGridView1[1, 1].Value = "tes";
            /* Tour Itineraries DataGridView





 Bus Information

 Bus Info ID = Column_BusInfoID
 Tour Code = ColumnTourCode
 Bus Number = ColumnBusNumber
 Bus Plate Number = ColumnBusPlateNumber
 Number of Passengers = ColumnBusPaxTotal
 Tour Guide's Last Name = ColumnBusAssignedTourGuideLName
 Tour Guide's First Name = ColumnBusAssignedTourGuideFName
*/
        }

        private void dataGridView_Tour_Itineraries_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int Incremented_Value = (int)dataGridView_Tour_Itineraries.Rows[dataGridView_Tour_Itineraries.CurrentRow.Index].Cells[0].Value;
            dataGridView_Tour_Itineraries.Rows[dataGridView_Tour_Itineraries.CurrentRow.Index + 1].Cells[0].Value = Incremented_Value + 1;
            // int value = (int)dataGridViewX1.Rows[dataGridViewX1.CurrentRow.Index].Cells[2].Value;
            // dataGridViewX1.Rows[dataGridViewX1.CurrentRow.Index].Cells[2].Value = value + 1;
            //dataGridViewX1.Rows[dataGridViewX1.CurrentRow.Index].Cells[2].Value =+ 1;
                // Do something with the added row here
                // Raise a custom RowAdded event if you want that passes individual rows.
           
        }

        private void dataGridView_Tour_Guide_Information_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int Incremented_Value = (int)dataGridView_Tour_Guide_Information.Rows[dataGridView_Tour_Guide_Information.CurrentRow.Index].Cells[0].Value;
            dataGridView_Tour_Guide_Information.Rows[dataGridView_Tour_Guide_Information.CurrentRow.Index + 1].Cells[0].Value = Incremented_Value + 1;
        }

        private void dataGridView_Bus_Information_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int Incremented_Value = (int)dataGridView_Bus_Information.Rows[dataGridView_Bus_Information.CurrentRow.Index].Cells[0].Value;
            dataGridView_Bus_Information.Rows[dataGridView_Bus_Information.CurrentRow.Index + 1].Cells[0].Value = Incremented_Value + 1;
        }

        private void dataGridView_Tour_Guide_Information_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            Query STATIC_CODE = new Query(new Connections(".\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS"));
            e.Row.Cells["Column_TourGuide_TourCode"].Value = STATIC_CODE.STATIC_CODE_GETTER("TOUR_CODE", "TOUR_GUIDES");
        }

        private void dataGridView_Bus_Information_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dataGridView_Bus_Information_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            Query STATIC_CODE = new Query(new Connections(".\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS"));
            e.Row.Cells["ColumnTourCode"].Value = STATIC_CODE.STATIC_CODE_GETTER("TOUR_CODE", "BUS_INFORMATION");
        }

        private void button_TEST_IT_Click(object sender, EventArgs e)
        {

            Query ADD_ITINERARY_DATABASE = new Query(new Connections(".\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS"));

            ADD_ITINERARY_DATABASE.ADD_ITINERARY(dataGridView_Tour_Itineraries);
        }


    }
}
