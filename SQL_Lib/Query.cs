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
