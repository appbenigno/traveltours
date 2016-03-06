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

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Edit()
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
