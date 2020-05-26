using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace LogBook
{
    public class Contracts
    {
        // Представление "Открытые договоры (все)"
        public DataTable GetOpenedAllDataTable()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.ContractsOpenedAll", connection.ConnectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Представление "Открытые договоры (просрок)"
        public DataTable GetOpenedProsrokDataTable()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.ContractsOpenedProsrok", connection.ConnectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Представление "Закрытые договоры"
        public DataTable GetClosedAllDataTable()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.ContractsClosed", connection.ConnectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public List<string> GetResponsiblesAsList()
        {
            List<string> list = new List<string>();
            list.Add("");
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT Name From dbo.Responsibles", connection);
                ad.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++) list.Add(dt.Rows[i][0].ToString());
            }

            return list;
        }
    }
}
