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
    public class SQL_Lib
    {
        public static void initializeStoredProcedures(Connections connection)
        {
            StoredProc sproc = new StoredProc(connection);
            string procName = "", procParam = "";

            // Create Stored Procedure: proc_build_UserCredentials
            procName = @"proc_build_UserCredentials(
                                @U_NAME NVARCHAR(60),
                                @U_PASS NVARCHAR(60),
                                @U_EMAIL NVARCHAR(60),
                                @U_POSITION NVARCHAR(30),
                                @U_GIVENNAME NVARCHAR(30),
                                @U_FAMILYNAME NVARCHAR(30)
                                )";
            procParam = @"AS
                             CREATE TABLE USER_CREDENTIALS(
                             U_NAME varchar(60) primary key not null,
                             U_PASS varchar(60) not null,
                             U_EMAIL varchar(60) not null,
                             U_POSITION varchar(30) not null,
                             U_GIVENNAME varchar(30) not null,
                             U_FAMILYNAME varchar(30) not null
                             )";
            sproc.CreateStoredProcedure(procName, procParam);


            // Create Stored Procedure: proc_insert_UserCredentials
            procName = @"proc_insert_UserCredentials(
                            @U_NAME NVARCHAR(60),
                            @U_PASS NVARCHAR(60),
                            @U_EMAIL NVARCHAR(60),
                            @U_POSITION NVARCHAR(30),
                            @U_GIVENNAME NVARCHAR(30),
                            @U_FAMILYNAME NVARCHAR(30))";
            procParam = @"AS
                            INSERT INTO USER_CREDENTIALS values(
                                @U_NAME, 
                                @U_PASS, 
                                @U_EMAIL, 
                                @U_POSITION, 
                                @U_GIVENNAME, 
                                @U_FAMILYNAME)";
            sproc.CreateStoredProcedure(procName, procParam);


            // Create Stored Procedure: proc_default_UserCredentials
            procName = @"proc_default_UserCredentials";
            procParam = @"AS
	                        DELETE FROM USER_CREDENTIALS
	                        EXEC proc_insert_UserCredentials 'luke','skywalker','luke@starwars.com','Tour Guide','Luke','Skywalker'
	                        EXEC proc_insert_UserCredentials 'anakin','skywalker','anakin@starwars.com','Tour Facilitator','Anakin','Skywalker'
                        ";
            sproc.CreateStoredProcedure(procName, procParam);

            sproc.ExecuteStoredProcedure(procName);
        }
    }
}
