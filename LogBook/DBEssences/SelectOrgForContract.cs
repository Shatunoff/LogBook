using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LogBook
{
    public static class SelectOrgForContract
    {
        public static DataTable getAllOrgFromATE(int idAte)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("dbo.OOSvodInCurrentATE", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IdAte", Value = idAte });
                dt.Load(cmd.ExecuteReader());
                connection.Close();
                return dt;
            }
        }

        public static DataTable getSearchResult(int idAte, string searchQuery)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("dbo.OOSvodInCurrentATESearch", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IdAte", Value = idAte });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@Query", Value = searchQuery });
                dt.Load(cmd.ExecuteReader());
                connection.Close();
                return dt;
            }
        }
    }
}
