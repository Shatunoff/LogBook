using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LogBook
{
    public class Organization
    {
        public int ateCode { get; private set; }
        public string ateName { get; private set; }
        public string ooMembership { get; private set; }
        public int ooCode { get; private set; }
        public string ooLongName { get; private set; }
        public string ooShortName { get; private set; }
        public bool isPPE9 { get; private set; }
        public bool isPPE11 { get; private set; }
        public string DirectorFIO { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Adress { get; private set; }

        public Organization(int idOO)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("ViewCurrentOO", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@IdOO",
                    Value = idOO
                });

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                ateCode = int.Parse(dt.Rows[0][0].ToString());
                ateName = dt.Rows[0][1].ToString();
                ooMembership = dt.Rows[0][2].ToString();
                ooCode = int.Parse(dt.Rows[0][3].ToString());
                ooLongName = dt.Rows[0][4].ToString();
                ooShortName = dt.Rows[0][5].ToString();
                isPPE9 = bool.Parse(dt.Rows[0][6].ToString());
                isPPE11 = bool.Parse(dt.Rows[0][7].ToString());
                DirectorFIO = dt.Rows[0][8].ToString();
                Phone = dt.Rows[0][9].ToString();
                Email = dt.Rows[0][10].ToString();
                Adress = dt.Rows[0][11].ToString();

                connection.Close();
            }
        }
    }

    public class OrgMore
    {
        public Organization Organization { get; private set; }
        public DataTable ContractsOfOrganization { get; private set; }

        public OrgMore(int idOO)
        {
            Organization = new Organization(idOO);
            RefreshContractsOfOrg(idOO);
        }

        public void RefreshContractsOfOrg(int idOO)
        {
            ContractsOfOrganization = new DataTable();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("dbo.ProcContractsOfOO", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@IdOO",
                    Value = idOO
                });

                ContractsOfOrganization = new DataTable();
                ContractsOfOrganization.Load(cmd.ExecuteReader());

                connection.Close();
            }
        }
    }
}
