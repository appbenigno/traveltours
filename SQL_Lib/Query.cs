using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SQL_Lib
{
    public class Query : Connections, iQuery, iConnect
    {
        Connections connection;
        public Query()
        { }

        public Query(Connections connection)
        {
            Connection = connection;
        }

        private string comm = "";
        public string Command
        {
            get { return comm; }
            set { comm = value; }
        }

        public Connections Connection
        {
            get
            {
                return connection;
            }

            set
            {
                connection = value;
            }
        }
        public void Add(int Tour_Code, string Company_Information,DateTime Tour_Start_Date, DateTime Tour_End_Date, int Number_Of_Passengers, int Number_Of_Tour_Guides, int Number_Of_Buses)
        {
            try
            {
                SqlConnection ADD_CONNECTION = new SqlConnection(ConnectString());
                SqlCommand ADD_COMMAND = new SqlCommand ("INSERT INTO TOUR_INFORMATION (TOUR_CODE, TOUR_START, TOUR_END, PERSONNEL_TOURED, TOTAL_NUMBER_OF_PAX, TOTAL_NUMBER_OF_BUSES, TOUR_FACILITATORS) VALUES (@TOUR_CODE, @TOUR_START, @TOUR_END, @PERSONNEL_TOURED, @TOTAL_NUMBER_OF_PAX, @TOTAL_NUMBER_OF_BUSES, @TOUR_FACILITATORS)");
                ADD_COMMAND.CommandType = CommandType.Text;
                ADD_COMMAND.Connection = ADD_CONNECTION;
                ADD_COMMAND.Parameters.AddWithValue("@TOUR_CODE", Tour_Code);
                // cmd.Parameters.Add("@Birthdate", SqlDbType.Date).Value = dateTimePicker.Value.Date;
                ADD_COMMAND.Parameters.AddWithValue("@TOUR_START", SqlDbType.Date).Value = Tour_Start_Date.Date;
                ADD_COMMAND.Parameters.AddWithValue("@TOUR_END", SqlDbType.Date).Value = Tour_End_Date.Date;
                ADD_COMMAND.Parameters.AddWithValue("@PERSONNEL_TOURED", Company_Information);
                ADD_COMMAND.Parameters.AddWithValue("@TOTAL_NUMBER_OF_PAX", Number_Of_Passengers);
                ADD_COMMAND.Parameters.AddWithValue("@TOTAL_NUMBER_OF_BUSES", Number_Of_Buses);
                ADD_COMMAND.Parameters.AddWithValue("@TOUR_FACILITATORS", Number_Of_Tour_Guides);
                ADD_CONNECTION.Open();
                ADD_COMMAND.ExecuteNonQuery();
            }

            catch(Exception ADD_EXCEPTION)
            {
                MessageBox.Show(ADD_EXCEPTION.Message.ToString());
            }
            /*
            {
            SqlCommand cmd = new SqlCommand("INSERT INTO Data (Name, PhoneNo, Address) VALUES (@Name, @PhoneNo, @Address)");
             cmd.CommandType = CommandType.Text;
             cmd.Connection = connection;
             cmd.Parameters.AddWithValue("@Name", txtName.Text);
             cmd.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
             cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
             connection.Open();
             cmd.ExecuteNonQuery();
}
            */


        }

        public void Edit(string Value_To_Be_Edited)
        {
            throw new NotImplementedException();
        }

        public void ADD_ITINERARY(DataGridView ITINERARY_DATAGRID)
        {
            /* Tour Itinerary Code = Column_IT_CODE 
             * Tour Code = Column_TourCode
                Itinerary Name = Column_IT_Name
                Expected Time of Arrival = Column_ETA
                Expected Time of Departure = Column_ETD
                Itinerary Descprtion = Column_IT_Comments_Description
             * 
             * string StrQuery;
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
}
             */

            using (SqlConnection ITINERARY_CONNECTION = new SqlConnection(ConnectString()))
            {
                using (SqlCommand ITINERARY_COMMAND = new SqlCommand())
                {
                    ITINERARY_COMMAND.Connection = ITINERARY_CONNECTION;

                    ITINERARY_CONNECTION.Open();

                    for (int i = 0; i < ITINERARY_DATAGRID.Rows.Count - 1; i++)
                    {
                        int Column_IT_CODE = (int)ITINERARY_DATAGRID.Rows[i].Cells["Column_IT_CODE"].Value;
                        int Column_IT_TOURCODE = (int)ITINERARY_DATAGRID.Rows[i].Cells["Column_TourCode"].Value;

                        ITINERARY_COMMAND.CommandText = @"INSERT INTO ITINERARY_INFORMATION VALUES (" + Column_IT_CODE + ", " + Column_IT_TOURCODE + ", '" + ITINERARY_DATAGRID.Rows[i].Cells["Column_IT_Name"].Value + "', '" + ITINERARY_DATAGRID.Rows[i].Cells["Column_ETA"].Value + "', '" + ITINERARY_DATAGRID.Rows[i].Cells["Column_ETD"].Value + "', '" + ITINERARY_DATAGRID.Rows[i].Cells["Column_IT_Comments_Description"].Value + "')";
                        ITINERARY_COMMAND.ExecuteNonQuery();
                    }
                }
            }
        }


        public void ADD_TOUR_GUIDE(DataGridView TOUR_GUIDE_DATAGRID)
        {

           using (SqlConnection TOUR_GUIDE_CONNECTION = new SqlConnection(ConnectString()))
           {
               using(SqlCommand TOUR_GUIDE_COMMAND = new SqlCommand())
               {
                    TOUR_GUIDE_COMMAND.Connection = TOUR_GUIDE_CONNECTION;

                    TOUR_GUIDE_CONNECTION.Open();

                    for (int i = 0; i < TOUR_GUIDE_DATAGRID.Rows.Count - 1; i++ )
                    {
                        int Column_TOUR_GUIDE_CODE = (int)TOUR_GUIDE_DATAGRID.Rows[i].Cells["Column_TourGuide_ID"].Value;
                        int Column_TOUR_GUIDE_TOURCODE = (int)TOUR_GUIDE_DATAGRID.Rows[i].Cells["Column_TourGuide_TourCode"].Value;

                        TOUR_GUIDE_COMMAND.CommandText = @"INSERT INTO TOUR_GUIDES VALUES (" + Column_TOUR_GUIDE_CODE + ", " + Column_TOUR_GUIDE_TOURCODE + ", '" + TOUR_GUIDE_DATAGRID.Rows[i].Cells["Column_Assigned_Bus_Number"].Value + "', '" + TOUR_GUIDE_DATAGRID.Rows[i].Cells["ColumnTourGuide_LName"].Value + "', '" + TOUR_GUIDE_DATAGRID.Rows[i].Cells["Column_TourGuide_FName"].Value + "')";
                        TOUR_GUIDE_COMMAND.ExecuteNonQuery();

                        /*
                         *  Tour Guide Information

 Tour Guide ID = Column_TourGuide_ID
 Tour Code = Column_TourGuide_TourCode
 Bus Number Assigned = Column_Assigned_Bus_Number
 Tour Guide's Last Name = ColumnTourGuide_LName
 Tour Guide's First Name = Column_TourGuide_FName
                         * 
                         */
                    }
               }
           }
        }

        public void BUS_INFORMATION(DataGridView BUS_INFORMATION_DATAGRID)
        {

            using (SqlConnection BUS_INFORMATION_CONNECTION = new SqlConnection(ConnectString()))
            {
                using (SqlCommand BUS_INFORMATION_COMMAND = new SqlCommand())
                {
                    BUS_INFORMATION_COMMAND.Connection = BUS_INFORMATION_CONNECTION;

                    BUS_INFORMATION_CONNECTION.Open();

                    for (int i = 0; i < BUS_INFORMATION_DATAGRID.Rows.Count - 1; i++)
                    {
                        int Column_BUS_INFORMATION_CODE = (int)BUS_INFORMATION_DATAGRID.Rows[i].Cells["Column_TourGuide_ID"].Value;
                        int Column_BUS_INFORMATION_TOURCODE = (int)BUS_INFORMATION_DATAGRID.Rows[i].Cells["Column_TourGuide_TourCode"].Value;

                        BUS_INFORMATION_COMMAND.CommandText = @"INSERT INTO TOUR_GUIDES VALUES (" + Column_BUS_INFORMATION_CODE + ", " + Column_BUS_INFORMATION_TOURCODE + ", '" + BUS_INFORMATION_DATAGRID.Rows[i].Cells["ColumnBusNumber"].Value + "', '" + BUS_INFORMATION_DATAGRID.Rows[i].Cells["ColumnBusPlateNumber"].Value + "', '" + BUS_INFORMATION_DATAGRID.Rows[i].Cells["ColumnBusPaxTotal"].Value + "', '" + BUS_INFORMATION_DATAGRID.Rows[i].Cells["ColumnBusAssignedTourGuideLName"].Value + "', '" + BUS_INFORMATION_DATAGRID.Rows[i].Cells["ColumnBusAssignedTourGuideFName"].Value + "')";
                        BUS_INFORMATION_COMMAND.ExecuteNonQuery();

                        /*
                         *  Bus Information

 Bus Info ID = Column_BusInfoID
 Tour Code = ColumnTourCode
 Bus Number = ColumnBusNumber
 Bus Plate Number = ColumnBusPlateNumber
 Number of Passengers = ColumnBusPaxTotal
 Tour Guide's Last Name = ColumnBusAssignedTourGuideLName
 Tour Guide's First Name = ColumnBusAssignedTourGuideFName
                         * 
                         */
                    }
                }
            }
        }

        public int Increment_Counter(string INFORMATION_CODE, string DATABASE_TABLE_NAME)
        {
            // SqlConnection ADD_CONNECTION = new SqlConnection(ConnectString());
            //new Connections(".\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS")

            try
            {
                SqlConnection INFORMATION_CODE_INCREMENT_CONNECTION = new SqlConnection(ConnectString());
                SqlCommand INCREMENT = new SqlCommand("SELECT MAX("+INFORMATION_CODE+") FROM "+DATABASE_TABLE_NAME);

                INCREMENT.CommandType = CommandType.Text;
                INCREMENT.Connection = INFORMATION_CODE_INCREMENT_CONNECTION;

                INFORMATION_CODE_INCREMENT_CONNECTION.Open();
                int Information_Code = (int)INCREMENT.ExecuteScalar() + 1;

                return Information_Code;
            }
            catch(Exception COUNTER_EXCEPTION)
            {
                MessageBox.Show("Error: " + COUNTER_EXCEPTION.Message.ToString());

                return 0;
            }
            
        }

        public int STATIC_CODE_GETTER(string INFORMATION_CODE, string DATABASE_TABLE_NAME)
        {
            // SqlConnection ADD_CONNECTION = new SqlConnection(ConnectString());
            //new Connections(".\\SQLEXPRESS", "ELMANJOVIN_TRAVEL_AND_TOURS")

            try
            {
                SqlConnection INFORMATION_CODE_STATIC_CONNECTION = new SqlConnection(ConnectString());
                SqlCommand STATIC = new SqlCommand("SELECT MAX(" + INFORMATION_CODE + ") FROM "+DATABASE_TABLE_NAME);

                STATIC.CommandType = CommandType.Text;
                STATIC.Connection = INFORMATION_CODE_STATIC_CONNECTION;

                INFORMATION_CODE_STATIC_CONNECTION.Open();
                int TourCode = (int)STATIC.ExecuteScalar();

                return TourCode;
            }
            catch (Exception COUNTER_EXCEPTION)
            {
                MessageBox.Show("Error: " + COUNTER_EXCEPTION.Message.ToString());

                return 0;
            }

        }

        public void Delete(int Key_Identifier)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Execute command directly and display result to data grid view
        /// </summary>
        /// <param name="selectCommand"></param>
        /// <param name="targetDataGridView"></param>
        public void CommandExec(string selectCommand, DataGridView targetDataGridView)
        {
            SqlConnection conn = new SqlConnection(ConnectString());
            SqlCommand cmd = new SqlCommand(selectCommand, conn);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                targetDataGridView.DataSource = dataSet.Tables[0];
            }
            catch (Exception err1)
            {
                MessageBox.Show(err1.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Execute command from textbox and display result to data grid view
        /// </summary>
        /// <param name="selectCommandFromTextBox"></param>
        /// <param name="targetDataGridView"></param>
        /// 
        public void CommandExec(TextBox selectCommandFromTextBox, DataGridView targetDataGridView)
        {
            SqlConnection conn = new SqlConnection(ConnectString());
            SqlCommand cmd = new SqlCommand(selectCommandFromTextBox.Text, conn);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommandFromTextBox.Text, conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                targetDataGridView.DataSource = dataSet.Tables[0];
            }
            catch (Exception err2)
            {
                MessageBox.Show(err2.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            
        }

        /// <summary>
        /// Check Existing
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="primaryKeyField"></param>
        /// <param name="primaryKeyValue"></param>
        /// <param name="targetFieldName"></param>
        /// <param name="stringToMatch"></param>
        /// <returns></returns>
        /// 
        public bool isExist(string tableName, string primaryKeyField, string primaryKeyValue, string targetFieldName, string stringToMatch)
        {
            Command = @"SELECT * FROM " + tableName + " WHERE " + primaryKeyField + " = '" + primaryKeyValue + "'";
            bool result = false;
            string str1 = "", str2 = "";
            str1 = getData(tableName, primaryKeyField, primaryKeyValue, targetFieldName);
            str2 = stringToMatch;
            if (str1 == str2)
            {
                result = true;
            }
            else
            { result = false; }
            return result;
        }

        /// <summary>
        /// Get single data value
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="primaryKeyField"></param>
        /// <param name="primaryKeyValue"></param>
        /// <param name="targetFieldName"></param>
        /// <returns></returns>
        public string getData(string tableName, string primaryKeyField, string primaryKeyValue, string targetFieldName)
        {
            Command = @"SELECT * FROM " + tableName + " WHERE " + primaryKeyField + " = '" + primaryKeyValue + "'";
            string result = "";
            SqlConnection conn = new SqlConnection(this.ConnectString());
            SqlCommand command = new SqlCommand(this.Command, conn);
            conn.Open();
            try
            {
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    result = (read[targetFieldName.ToString()].ToString());
                }
                read.Close();
            }
            catch (Exception errGet)
            {
                MessageBox.Show(errGet.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        /// <summary>
        /// Connection String
        /// </summary>
        /// <returns></returns>
        public string ConnectString()
        {
            //Data Source=FAMILY-PC\SQLEXPRESS;Initial Catalog=EX_5;Integrated Security=True
            return string.Concat("Data Source=", Connection.ServerName, ";Initial Catalog=", Connection.DatabaseName, ";Integrated Security=True");
        }
    }
}
