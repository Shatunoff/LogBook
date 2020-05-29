using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LogBook
{
    public class ContractAddEdit
    {
        public Dictionary<int, string> Responsibles { get; private set; }
        public DataTable ReturnableItems { get; private set; }
        public DataTable NotReturnableItems { get; private set; }

        public ContractAddEdit()
        {
            RefreshResponsibles();
            RefreshReturnableItems();
            RefreshNotReturnableItems();
        }

        public void RefreshReturnableItems()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT Id, ItemName, InventoryNumber FROM dbo.ReturnableItems WHERE InContract = 0", connection);

                ReturnableItems = new DataTable();
                ReturnableItems.Load(cmd.ExecuteReader());

                connection.Close();
            }
        }

        public void SearchInReturnableItems(string contains)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT Id, ItemName, InventoryNumber FROM dbo.ReturnableItems WHERE InContract = 0 AND (ItemName LIKE '%{contains}%' OR InventoryNumber LIKE '%{contains}%')", connection);

                ReturnableItems = new DataTable();
                ReturnableItems.Load(cmd.ExecuteReader());

                connection.Close();
            }
        }

        public void RefreshNotReturnableItems()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.NotReturnableItems", connection);

                NotReturnableItems = new DataTable();
                NotReturnableItems.Load(cmd.ExecuteReader());

                connection.Close();
            }
        }

        public void SearchInNotReturnableItems(string contains)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM dbo.NotReturnableItems WHERE Name LIKE '%{contains}%'", connection);

                NotReturnableItems = new DataTable();
                NotReturnableItems.Load(cmd.ExecuteReader());

                connection.Close();
            }
        }

        private void RefreshResponsibles()
        {
            Responsibles = new Dictionary<int, string>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Responsibles", connection);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                Responsibles.Add(0, string.Empty);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                        Responsibles.Add(int.Parse(dt.Rows[i]["Id"].ToString()), dt.Rows[i]["Name"].ToString());
                }

                connection.Close();
            }
        }

        public static int GetCurrentResponsible(int idContract)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT dbo.GetCurrentResponsible ({idContract})", connection);
                int result = (int)cmd.ExecuteScalar();

                connection.Close();
                return result;
            }
        }

        public static void AddContract(string contractCode, int idOO, DateTime dateOfSigning, DateTime dateOfIssue, DateTime dateOfReturn, int idResponsible, string hostOrg, out int idContract)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("dbo.AddContract", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@ContractCode", Value = contractCode});
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IdOO", Value = idOO });
                cmd.Parameters.AddWithValue("@DateOfSigning", dateOfSigning);
                cmd.Parameters.AddWithValue("@DateOfIssue", dateOfIssue);
                cmd.Parameters.AddWithValue("@DateOfReturn", dateOfReturn);
                //cmd.Parameters.Add(new SqlParameter { ParameterName = "@DateOfSigning", Value = dateOfSigning.ToString("yyyy-mm-dd") });
                //cmd.Parameters.Add(new SqlParameter { ParameterName = "@DateOfIssue", Value = dateOfIssue.ToString("yyyy-mm-dd") });
                //cmd.Parameters.Add(new SqlParameter { ParameterName = "@DateOfReturn", Value = dateOfReturn.ToString("yyyy-mm-dd") });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IdResponsible", Value = idResponsible });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@HostOrganization", Value = hostOrg });

                cmd.ExecuteNonQuery();

                SqlCommand getId = new SqlCommand($"SELECT dbo.GetCurrentContractId {contractCode}", connection);
                idContract = (int)getId.ExecuteScalar();

                connection.Close();
            }
        }

        public static void AddReturnableItemsInContract(int idReturnableItem, int idContract)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("dbo.AddReturnableItemInContract", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IdReturnableItem", Value = idReturnableItem });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IdContract", Value = idContract });
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void AddNotReturnableItemsInContract(int idNotReturnableItem, int itemsCount, int idContract)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("dbo.AddNotReturnableItemInContract", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IdNotReturnableItem", Value = idNotReturnableItem });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IdContract", Value = idContract });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@ItemsCount", Value = itemsCount });
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
