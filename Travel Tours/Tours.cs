using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Lib;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Travel_Tours
{
    public class Tours : Query, iTour
    {
        /// <summary>
        /// Checks if credential is facilitator or not
        /// </summary>
        /// <returns></returns>
        /// 
        public static bool isFacilitator()
        {
            bool result = false;
            if (Credentials.Position.Contains("Facilitator"))
            {
                result = true;
            }
            else if (Credentials.Position.Contains("FACILITATOR"))
            {
                result = true;
            }
            else if (Credentials.Position.Contains("facilitator"))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
            
        }

        /// <summary>
        /// Tours stored procedures
        /// </summary>
        /// <param name="connect"></param>
        /// 
        public static void initializeStoredProcedures(Connections connect)
        {
            StoredProc sproc = new StoredProc(connect);

            sproc.CreateStoredProcedure("view_BusInformation",
                @"AS select * from BUS_INFORMATION"
                );
            sproc.CreateStoredProcedure("view_ItineraryInfo",
                @"AS select * from ITINERARY_INFORMATION"
                );
            sproc.CreateStoredProcedure("view_TourGudes",
                @"AS select * from TOUR_GUIDES"
                );
            sproc.CreateStoredProcedure("view_TourInformation",
                @"AS select * from TOUR_INFORMATION");
        }

        /// <summary>
        /// Execute bus information stored procedure
        /// </summary>
        /// <param name="targetGridView"></param>
        /// 
        public void viewBusInfo(DataGridView targetGridView)
        {
            CommandExec("EXEC view_BusInformation", targetGridView);
        }

        /// <summary>
        /// Execute itinerary information stored procedure
        /// </summary>
        /// <param name="targetGridView"></param>
        /// 
        public void viewItineraryInfo(DataGridView targetGridView)
        {
            CommandExec("EXEC view_ItineraryInfo", targetGridView);
        }

        /// <summary>
        /// Execute tour guides stored procedure
        /// </summary>
        /// <param name="targetGridView"></param>
        /// 
        public void viewTourGuides(DataGridView targetGridView)
        {
            CommandExec("EXEC view_TourGudes", targetGridView);
        }

        /// <summary>
        /// Execute tour information stored procedure
        /// </summary>
        /// <param name="targetGridView"></param>
        /// 
        public void viewTourInfo(DataGridView targetGridView)
        {
            CommandExec("EXEC view_TourInformation", targetGridView);
        }
        
        /// <summary>
        /// Display selected results
        /// </summary>
        /// <param name="viewType"></param>
        /// <param name="targetGridView"></param>
        /// 
        public void display(ComboBox viewType, DataGridView targetGridView)
        {
            /*
                Tour Information
                Itinerary Information
                Bus Information
                Tour Guides
            */
            if (viewType.Text == "Tour Information")
            {
                viewTourInfo(targetGridView);
            }
            else if (viewType.Text == "Itinerary Information")
            {
                viewItineraryInfo(targetGridView);
            }
            else if (viewType.Text == "Bus Information")
            {
                viewBusInfo(targetGridView);
            }
            else if (viewType.Text == "Tour Guides")
            {
                viewTourGuides(targetGridView);
            }
        }

        /// <summary>
        /// Modify Tour Information
        /// </summary>
        /// <param name="targetGridView"></param>
        /// 
        public void modifyTourInfo(DataGridView targetGridView)
        {
            targetGridView.SelectAll();
            for (int x = 0; x < targetGridView.SelectedRows.Count; x++)
            {
                int primaryKey = Convert.ToInt32(targetGridView.Rows[x].Cells["TOUR_CODE"].Value);
                Command = @"UPDATE TOUR_INFORMATION SET 
                                [TOUR_CODE] = @tour_code, 
                                [TOUR_START] = @tour_start, 
                                [TOUR_END] = @tour_end, 
                                [PERSONNEL_TOURED] = @tour_personel, 
                                [TOTAL_NUMBER_OF_PAX] = @tour_pax, 
                                [TOTAL_NUMBER_OF_BUSES] = @tour_bus, 
                                [TOUR_FACILITATORS] = @tour_facilitator
                                where [TOUR_CODE] = " + primaryKey.ToString();
                SqlConnection conn = new SqlConnection(ConnectString());
                SqlCommand cmd = new SqlCommand(Command, conn);

                cmd.Parameters.AddWithValue("@tour_code", targetGridView.Rows[x].Cells["TOUR_CODE"].Value);
                cmd.Parameters.AddWithValue("@tour_start", targetGridView.Rows[x].Cells["TOUR_START"].Value.ToString());
                cmd.Parameters.AddWithValue("@tour_end", targetGridView.Rows[x].Cells["TOUR_END"].Value.ToString());
                cmd.Parameters.AddWithValue("@tour_personel", targetGridView.Rows[x].Cells["PERSONNEL_TOURED"].Value.ToString());
                cmd.Parameters.AddWithValue("@tour_pax", targetGridView.Rows[x].Cells["TOTAL_NUMBER_OF_PAX"].Value);
                cmd.Parameters.AddWithValue("@tour_bus", targetGridView.Rows[x].Cells["TOTAL_NUMBER_OF_BUSES"].Value);
                cmd.Parameters.AddWithValue("@tour_facilitator", targetGridView.Rows[x].Cells["TOUR_FACILITATORS"].Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        /// <summary>
        /// Modify Itinerary Information
        /// </summary>
        /// <param name="targetGridView"></param>
        /// 
        public void modifyItineraryInfo(DataGridView targetGridView)
        {
            targetGridView.SelectAll();
            for (int x = 0; x < targetGridView.SelectedRows.Count; x++)
            {
                int primaryKey = Convert.ToInt32(targetGridView.Rows[x].Cells["TOUR_ITINERARY_CODE"].Value);
                Command = @"UPDATE ITINERARY_INFORMATION SET 
                                [TOUR_ITINERARY_CODE] = @tour_itinerary_code,
                                [TOUR_CODE] = @tour_code, 
                                [ITINERARY_NAME] = @itinerary_name,
                                [EXPECTED_TIME_OF_ARRIVAL] = @time_arrival, 
                                [EXPECTED_TIME_OF_DEPARTURE] = @time_departure, 
                                [ITINERARY_DESCRIPTION_COMMENTS] = @itinerary_description
                                where [TOUR_ITINERARY_CODE] = " + primaryKey.ToString();
                SqlConnection conn = new SqlConnection(ConnectString());
                SqlCommand cmd = new SqlCommand(Command, conn);

                cmd.Parameters.AddWithValue("@tour_itinerary_code", targetGridView.Rows[x].Cells["TOUR_ITINERARY_CODE"].Value);
                cmd.Parameters.AddWithValue("@tour_code", targetGridView.Rows[x].Cells["TOUR_CODE"].Value);
                cmd.Parameters.AddWithValue("@itinerary_name", targetGridView.Rows[x].Cells["ITINERARY_NAME"].Value.ToString());
                cmd.Parameters.AddWithValue("@time_arrival", targetGridView.Rows[x].Cells["EXPECTED_TIME_OF_ARRIVAL"].Value.ToString());
                cmd.Parameters.AddWithValue("@time_departure", targetGridView.Rows[x].Cells["EXPECTED_TIME_OF_DEPARTURE"].Value.ToString());
                cmd.Parameters.AddWithValue("@itinerary_description", targetGridView.Rows[x].Cells["ITINERARY_DESCRIPTION_COMMENTS"].Value.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        /// <summary>
        /// Modify Bus Information
        /// </summary>
        /// <param name="targetGridView"></param>
        /// 
        public void modifyBusInfo(DataGridView targetGridView)
        {
            targetGridView.SelectAll();
            for (int x = 0; x < targetGridView.SelectedRows.Count; x++)
            {
                int primaryKey = Convert.ToInt32(targetGridView.Rows[x].Cells["BUS_INFO_ID"].Value);
                this.Command = @"UPDATE BUS_INFORMATION SET 
                                [BUS_INFO_ID] = @bus_id,
                                [TOUR_CODE] = @tour_code, 
                                [BUS_NUMBER] = @bus_number,
                                [BUS_PLATE_NUMBER] = @bus_plate, 
                                [BUS_PAX_TOTAL] = @bus_pax, 
                                [BUS_ASSIGNED_TOUR_GUIDE_LNAME] = @tourguide_lname, 
                                [BUS_ASSIGNED_TOUR_GUIDE_FNAME] = @tourguide_fname 
                                where [BUS_INFO_ID] = " + primaryKey;
                SqlConnection conn = new SqlConnection(this.ConnectString());
                SqlCommand cmd = new SqlCommand(this.Command, conn);

                cmd.Parameters.AddWithValue("@bus_id", targetGridView.Rows[x].Cells["BUS_INFO_ID"].Value);
                cmd.Parameters.AddWithValue("@tour_code", targetGridView.Rows[x].Cells["TOUR_CODE"].Value);
                cmd.Parameters.AddWithValue("@bus_number", targetGridView.Rows[x].Cells["BUS_NUMBER"].Value);
                cmd.Parameters.AddWithValue("@bus_plate", targetGridView.Rows[x].Cells["BUS_PLATE_NUMBER"].Value.ToString());
                cmd.Parameters.AddWithValue("@bus_pax", targetGridView.Rows[x].Cells["BUS_PAX_TOTAL"].Value);
                cmd.Parameters.AddWithValue("@tourguide_lname", targetGridView.Rows[x].Cells["BUS_ASSIGNED_TOUR_GUIDE_LNAME"].Value.ToString());
                cmd.Parameters.AddWithValue("@tourguide_fname", targetGridView.Rows[x].Cells["BUS_ASSIGNED_TOUR_GUIDE_FNAME"].Value.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        /// <summary>
        /// Modify Tour Guides
        /// </summary>
        /// <param name="targetGridView"></param>
        /// 
        public void modifyTourGuides(DataGridView targetGridView)
        {
            targetGridView.SelectAll();
            for (int x = 0; x < targetGridView.SelectedRows.Count; x++)
            {
                int primaryKey = Convert.ToInt32(targetGridView.Rows[x].Cells["TOUR_GUIDE_ID"].Value);
                Command = @"UPDATE TOUR_GUIDES SET 
                                [TOUR_GUIDE_ID] = @tourguide_id,
                                [TOUR_CODE] = @tour_code, 
                                [BUS_NUMBER_ASSIGNED] = @bus_number,
                                [TOUR_GUIDE_LAST_NAME] = @tourguide_lname, 
                                [TOUR_GUIDE_FIRST_NAME] = @tourguide_fname
                                where [TOUR_GUIDE_ID] = " + primaryKey.ToString();
                SqlConnection conn = new SqlConnection(ConnectString());
                SqlCommand cmd = new SqlCommand(Command, conn);

                cmd.Parameters.AddWithValue("@tourguide_id", targetGridView.Rows[x].Cells["TOUR_GUIDE_ID"].Value);
                cmd.Parameters.AddWithValue("@tour_code", targetGridView.Rows[x].Cells["TOUR_CODE"].Value);
                cmd.Parameters.AddWithValue("@bus_number", targetGridView.Rows[x].Cells["BUS_NUMBER_ASSIGNED"].Value);
                cmd.Parameters.AddWithValue("@tourguide_lname", targetGridView.Rows[x].Cells["TOUR_GUIDE_LAST_NAME"].Value.ToString());
                cmd.Parameters.AddWithValue("@tourguide_fname", targetGridView.Rows[x].Cells["TOUR_GUIDE_FIRST_NAME"].Value.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void deleteEntry(string selectCommand)
        {
            SqlConnection conn = new SqlConnection(ConnectString());
            SqlCommand cmd = new SqlCommand(selectCommand, conn);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception errDel)
            {
                MessageBox.Show(errDel.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Tours Constructor default
        /// </summary>
        /// 
        public Tours()
        { }

        /// <summary>
        /// Tours Constructor with sql connection
        /// </summary>
        /// <param name="connectName"></param>
        /// 
        public Tours(Connections connectName)
        {
            Connection = connectName;
        }
    }
}
