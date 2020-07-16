using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPMT_Technical_task
{
    
    class SqlHelper
       
    {
        SqlConnection Demo;
        public SqlHelper(string connectionString)
        {
            Demo = new SqlConnection(connectionString);
        }

        public bool IsConnection
        {
            get
            {
                if (Demo.State == System.Data.ConnectionState.Closed)
                    Demo.Open();
                return true;
            }
        }
    }
}
