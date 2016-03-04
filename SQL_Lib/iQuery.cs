using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Lib
{
    interface iQuery
    {
        void Add();
        void Edit();
        void Delete();
        bool isExist(string tableName, string primaryKeyField, string primaryKeyValue, string targetFieldName, string stringMatch);
        string getData(string tableName, string primaryKeyField, string primaryKeyValue, string targetFieldName);
        void CommandExec(string selectCommand, DataGridView targetDataGridView);
        void CommandExec(TextBox selectCommandFromTextBox, DataGridView targetDataGridView);
    }
}
