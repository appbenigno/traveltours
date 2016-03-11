using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Lib;
using System.Windows.Forms;

namespace Travel_Tours
{
    interface iTour
    {
        /// <summary>
        /// View tour information
        /// </summary>
        /// <param name="targetGridView"></param>
        /// 
        void viewTourInfo(DataGridView targetGridView);

        /// <summary>
        /// View itinerary information
        /// </summary>
        /// <param name="targetGridView"></param>
        /// 
        void viewItineraryInfo(DataGridView targetGridView);

        /// <summary>
        /// View bus information
        /// </summary>
        /// <param name="targetGridView"></param>
        /// 
        void viewBusInfo(DataGridView targetGridView);

        /// <summary>
        /// View tour guides
        /// </summary>
        /// <param name="targetGridView"></param>
        /// 
        void viewTourGuides(DataGridView targetGridView);
    }
}
