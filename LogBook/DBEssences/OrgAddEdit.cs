using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LogBook
{
    public class OrgAddEdit
    {
        public Dictionary<int, string> ATEs { get; private set; }
        public Dictionary<int, string> Memberships { get; private set; }

        public OrgAddEdit()
        {
            RefreshATEs();
            RefreshMemberships();
        }

        private void RefreshATEs()
        {
            ATEs = new Dictionary<int, string>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.ATE", connection);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                        ATEs.Add(int.Parse(dt.Rows[i]["Id"].ToString()), dt.Rows[i]["Name"].ToString());
                }

                connection.Close();
            }
        }

        public void RefreshMemberships()
        {
            Memberships = new Dictionary<int, string>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Memberships", connection);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                        Memberships.Add(int.Parse(dt.Rows[i]["Id"].ToString()), dt.Rows[i]["Name"].ToString());
                }

                connection.Close();
            }
        }

        public static int GetCurrentAte(int idOO)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT dbo.GetCurrentATE ({idOO})", connection);
                int result = (int)cmd.ExecuteScalar();

                connection.Close();
                return result;
            }
        }

        public static int GetCurrentMembership(int idOO)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT dbo.GetCurrentMembership ({idOO})", connection);

                int result = (int)cmd.ExecuteScalar();

                connection.Close();
                return result;
            }
        }

        public static void AddOO(int idOO, int idAte, string longName, string shortName, int idMembership, bool isPPE9, bool isPPE11,
            string directorFIO, string phone, string email, string adress)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("dbo.AddOO", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IdOO", Value = idOO });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IdAte", Value = idAte });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@LongName", Value = longName });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@ShortName", Value = shortName });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IdMembership", Value = idMembership });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IsPPE9", Value = isPPE9 });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IsPPE11", Value = isPPE11 });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@Director_FIO", Value = directorFIO });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@Phone", Value = phone });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@Email", Value = email });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@Adress", Value = adress });

                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void EditOO(int idOO, int newIdOO, int idAte, string longName, string shortName, int idMembership, bool isPPE9, bool isPPE11)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("dbo.EditOO", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter{ ParameterName = "@IdOO", Value = idOO });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@NewIdOO", Value = newIdOO });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IdAte", Value = idAte });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@LongName", Value = longName });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@ShortName", Value = shortName });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IdMembership", Value = idMembership });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IsPPE9", Value = isPPE9 });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IsPPE11", Value = isPPE11 });

                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void EditOOContacts(int idOO, string directorFIO, string phone, string email, string adress)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("dbo.EditOOContacts", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IdOO", Value = idOO });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@Director_FIO", Value = directorFIO });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@Phone", Value = phone });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@Email", Value = email });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@Adress", Value = adress });

                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void RemoveOO(int idOO)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("dbo.RemoveOO", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@IdOO",
                    Value = idOO
                });

                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
