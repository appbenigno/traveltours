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
