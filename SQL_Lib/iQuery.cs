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
        void Add(int Tour_Code, string Company_Information, string Tour_Start_Date, string Tour_End_Date, int Number_Of_Passengers, int Number_Of_Tour_Guides, int Number_Of_Buses);
        void Edit(string Value_To_Be_Edited);
        void Delete(int Key_Identifier);
        bool isExist(string tableName, string primaryKeyField, string primaryKeyValue, string targetFieldName, string stringMatch);
        string getData(string tableName, string primaryKeyField, string primaryKeyValue, string targetFieldName);
        void CommandExec(string selectCommand, DataGridView targetDataGridView);
        void CommandExec(TextBox selectCommandFromTextBox, DataGridView targetDataGridView);
    }
}
