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
            Query STATIC_CODE = new Query(new Connections(".\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS"));
            
            //  dataGridView1[1, 1].Value = "tes";
            dataGridView_Tour_Itineraries[0, 0].Value = INCREMENT_CODE.Increment_Counter("TOUR_ITINERARY_CODE", "ITINERARY_INFORMATION");
            dataGridView_Tour_Itineraries[1, 0].Value = STATIC_CODE.STATIC_CODE_GETTER("TOUR_CODE", "ITINERARY_INFORMATION");

            dataGridView_Bus_Information[0, 0].Value = INCREMENT_CODE.Increment_Counter("BUS_INFO_ID", "BUS_INFORMATION");
            dataGridView_Bus_Information[1, 0].Value = STATIC_CODE.STATIC_CODE_GETTER("TOUR_CODE", "BUS_INFORMATION");

            dataGridView_Tour_Guide_Information[0, 0].Value = INCREMENT_CODE.Increment_Counter("TOUR_GUIDE_ID", "TOUR_GUIDES");
            dataGridView_Tour_Guide_Information[1, 0].Value = STATIC_CODE.STATIC_CODE_GETTER("TOUR_CODE", "TOUR_GUIDES");

           
        }
    }
}
