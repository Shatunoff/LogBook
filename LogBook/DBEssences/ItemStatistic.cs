using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LogBook
{
    public static class ItemStatistic
    {
        public static DataTable ReturnableItemsStatistic(DateTime dateOT, DateTime dateDO)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetStatReturnableItems", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dateOfIssueOT", dateOT);
                cmd.Parameters.AddWithValue("@dateOfIssueDO", dateDO);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                connection.Close();

                return dt;
            }
        }

        public static DataTable NotReturnableItemsStatistic(DateTime dateOT, DateTime dateDO)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetStatNotReturnableItems", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dateOfIssueOT", dateOT);
                cmd.Parameters.AddWithValue("@dateOfIssueDO", dateDO);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                connection.Close();

                return dt;
            }
        }
    }
}
