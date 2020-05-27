using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace LogBook
{
    public class Organizations
    {
        public DataTable dtAllOrg { get; private set; }
        public List<string> listMemberships { get; private set; }
        public List<string> listATEs { get; private set; }

        public Organizations()
        {
            dtAllOrg = new DataTable();
            listMemberships = new List<string>();
            listATEs = new List<string>();

            GetAllBoxes();
        }

        public void GetAllBoxes()
        {
            GetOrganizations();
            GetMembershipsAsList();
            GetATEsAsList();
        }

        // Представление "Образовательные организации (свод)"
        public void GetOrganizations()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.OOSvod", connection.ConnectionString);
                adapter.Fill(dtAllOrg);
            }
        }

        public void GetMembershipsAsList()
        {
            listMemberships.Clear();
            listMemberships.Add("");
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT Name From dbo.Memberships", connection);
                ad.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++) listMemberships.Add(dt.Rows[i][0].ToString());
            }
        }

        public void GetATEsAsList()
        {
            listATEs.Clear();
            listATEs.Add("");
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT Name From dbo.ATE", connection);
                ad.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++) listATEs.Add(dt.Rows[i][0].ToString());
            }
        }
    }
}
