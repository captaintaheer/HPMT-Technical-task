using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace HPMT_Technical_task
{
    class DataAccess
    {
        public IEnumerable<Records> GetRecords1()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Demo")))
            {
                var Output = connection.Query<Records>($"select * from Record1").ToList();
                return Output;
            }
        }

        public IEnumerable<Records> GetRecords2()
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Demo")))
            {
                var Output = connection.Query<Records>($"select * from Record2").ToList();
                return Output;
            }
        }

        public IEnumerable<Records> GetRecords3()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Demo")))
            {
                var Output = connection.Query<Records>($"select * from Record3").ToList();
                return Output;
            }
        }

        public IEnumerable<Records> DeleteRecords()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Demo")))
            {
                var Output = connection.Query<Records>($"DELETE FROM Record1 WHERE Id = " + "id").ToList();
                return Output;
            }
        }

    }
}
