using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Lib
{
    interface iStoredProc
    {
        void CreateStoredProcedure(string procedureName, string procedureParameters);
        void ExecuteStoredProcedure(string procedureName, string procedureParameters);
        void ExecuteStoredProcedure(string procedureName);
    }
}
