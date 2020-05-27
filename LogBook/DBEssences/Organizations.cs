using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace LogBook
{
    class Organizations
    {
        // Представление "Образовательные организации (свод)"
        public DataTable GetOrganizations()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.OOSvod", connection.ConnectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
