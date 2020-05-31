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
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.OOSvod", connection);
                dtAllOrg = new DataTable();
                dtAllOrg.Load(cmd.ExecuteReader());

                connection.Close();
            }
        }

        public void GetMembershipsAsList()
        {
            listMemberships.Clear();
            listMemberships.Add("");
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT Name From dbo.Memberships", connection);
                dt.Load(cmd.ExecuteReader());

                connection.Close();

                for (int i = 0; i < dt.Rows.Count; i++) listMemberships.Add(dt.Rows[i][0].ToString());

            }
        }

        public void GetATEsAsList()
        {
            listATEs.Clear();
            listATEs.Add("");
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT Name From dbo.ATE", connection);
                dt.Load(cmd.ExecuteReader());

                connection.Close();

                for (int i = 0; i < dt.Rows.Count; i++) listATEs.Add(dt.Rows[i][0].ToString());
            }
        }

        public void FilterOrgs(string name, string idOO, string ateName, string membership)
        {
            string filterName = name == null ? string.Empty : name;
            string filterIdOO = idOO == null ? string.Empty : idOO;
            string filterAteName = ateName == null ? string.Empty : ateName;
            string filterMembership = membership == null ? string.Empty : membership;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                dtAllOrg = new DataTable();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM dbo.OOSvod " +
                    $"WHERE [Район, городской округ] LIKE '%{filterAteName}%' AND [Принадлежность] LIKE '%{filterMembership}%' " +
                    $"AND [Код ОО] LIKE '%{filterIdOO}%' AND [Краткое наименование] LIKE '%{filterName}%'", connection);

                dtAllOrg.Load(cmd.ExecuteReader());

                connection.Close();
            }
        }
    }
}
