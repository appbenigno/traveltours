using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQL_Lib
{
    public class StoredProc : Query, iStoredProc
    {
        /// <summary>
        /// Create new procedure
        /// </summary>
        /// <param name="procedureName"></param>
        /// <param name="procedureParameters"></param>
        /// 
        public void CreateStoredProcedure(string procedureName, string procedureParameters)
        {
            Command = @"CREATE PROCEDURE " + procedureName + " " + procedureParameters;
            SqlConnection conn = new SqlConnection(this.ConnectString());
            SqlCommand command = new SqlCommand(this.Command, conn);
            conn.Open();
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Stored procedure: " + procedureName + "\n successfully created!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception errProcCreate)
            {
                throw new NotImplementedException();
                //MessageBox.Show(errProcCreate.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Execute a stored procedure using parameters
        /// </summary>
        /// <param name="procedureName"></param>
        /// <param name="procedureParameters"></param>
        public void ExecuteStoredProcedure(string procedureName, string procedureParameters)
        {
            Command = @"EXEC " + procedureName + " " + procedureParameters;
            SqlConnection conn = new SqlConnection(this.ConnectString());
            SqlCommand command = new SqlCommand(this.Command, conn);
            conn.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception errProcExec)
            {
                MessageBox.Show(errProcExec.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Execute a stored procedure without parameters
        /// </summary>
        /// <param name="procedureName"></param>
        public void ExecuteStoredProcedure(string procedureName)
        {
            Command = @"EXEC " + procedureName;
            SqlConnection conn = new SqlConnection(this.ConnectString());
            SqlCommand command = new SqlCommand(this.Command, conn);
            conn.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception errProcExec)
            {
                MessageBox.Show(errProcExec.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public StoredProc()
        { }
        public StoredProc(Connections connect)
        {
            Connection = connect;
        }
    }
}
