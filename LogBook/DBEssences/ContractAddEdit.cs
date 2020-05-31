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
        // Для редактирования договора
        SqlConnection connection; //= new SqlConnection(Properties.Settings.Default.dbConnectionString);
        SqlDataAdapter adapterReturnable;
        SqlDataAdapter adapterNotReturnable;
        public DataTable ReturnableItemsInContract { get; private set; }
        public DataTable NotReturnableItemsInContract { get; private set; }
        public int IdContract { get; private set; }

        public ContractAddEdit()
        {
            RefreshResponsibles();
            RefreshReturnableItems();
            RefreshNotReturnableItems();
        }

        public ContractAddEdit(int idContract)
        {
            //connection = new SqlConnection(Properties.Settings.Default.dbConnectionString);
            IdContract = idContract;
            GetItems();
            RefreshResponsibles();
            RefreshReturnableItems();
            RefreshNotReturnableItems();
        }

        public void GetItems()
        {
            using (connection)
            {
                connection = new SqlConnection(Properties.Settings.Default.dbConnectionString);
                ReturnableItemsInContract = new DataTable();
                NotReturnableItemsInContract = new DataTable();

                // Адаптер возвращаемых предметов
                adapterReturnable = new SqlDataAdapter();
                //SELECT
                SqlCommand selectCmd = new SqlCommand("dbo.ReturnableItemsInOpenedContract", connection);
                selectCmd.CommandType = CommandType.StoredProcedure;
                selectCmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@IdContract",
                    Value = IdContract
                });
                adapterReturnable.SelectCommand = selectCmd;

                //INSERT
                SqlCommand insertCmd = new SqlCommand("dbo.AddReturnableItemInContract", connection);
                insertCmd.CommandType = CommandType.StoredProcedure;
                insertCmd.Parameters.Add("@IdReturnableItem", SqlDbType.Int, 0, "Id предмета");
                insertCmd.Parameters.Add("@IdContract", SqlDbType.Int, 0, "Id договора");
                adapterReturnable.InsertCommand = insertCmd;

                //UPDATE
                SqlCommand updCommand = new SqlCommand("UPDATE dbo.ReturnableItemsInContracts SET IdReturnableItem = @IdReturnableItem WHERE IdContract = @Id", connection);
                updCommand.Parameters.Add("@IdReturnableItem", SqlDbType.Int, 0, "Id предмета");
                SqlParameter param = updCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id договора");
                param.SourceVersion = DataRowVersion.Original;
                adapterReturnable.UpdateCommand = updCommand;

                //DELETE
                SqlCommand deleteCmd = new SqlCommand("dbo.RemoveReturnableItemInContract", connection); //dbo.RemoveReturnableItemInContract
                deleteCmd.CommandType = CommandType.StoredProcedure;
                deleteCmd.Parameters.Add("@IdReturnableItem", SqlDbType.Int, 0, "Id предмета");
                param = deleteCmd.Parameters.Add("@IdContract", SqlDbType.Int, 0, "Id договора");
                param.SourceVersion = DataRowVersion.Original;
                adapterReturnable.DeleteCommand = deleteCmd;

                adapterReturnable.Fill(ReturnableItemsInContract);

                // Адаптер невозвратных предметов
                adapterNotReturnable = new SqlDataAdapter();
                //SELECT
                selectCmd = new SqlCommand("dbo.NotReturnableItemsInCurrentContract", connection);
                selectCmd.CommandType = CommandType.StoredProcedure;
                selectCmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@IdContract",
                    Value = IdContract
                });
                adapterNotReturnable.SelectCommand = selectCmd;

                //INSERT
                insertCmd = new SqlCommand("dbo.AddNotReturnableItemInContract", connection);
                insertCmd.CommandType = CommandType.StoredProcedure;
                insertCmd.Parameters.Add("@IdNotReturnableItem", SqlDbType.Int, 0, "Id предмета");
                insertCmd.Parameters.Add("@IdContract", SqlDbType.Int, 0, "Id договора");
                insertCmd.Parameters.Add("@ItemsCount", SqlDbType.Int, 0, "Количество");
                adapterNotReturnable.InsertCommand = insertCmd;

                //UPDATE
                SqlCommand updateCommand = new SqlCommand("UPDATE dbo.NotReturnableItemsInContracts SET ItemsCount = @ItemsCount WHERE IdContract = @IdContract AND IdNotReturnableItem = @IdNotReturnableItem", connection); //dbo.EditNotReturnableItemInContract
                //updateCommand.CommandType = CommandType.StoredProcedure;
                updateCommand.Parameters.Add("@IdNotReturnableItem", SqlDbType.Int, 0, "Id предмета");
                updateCommand.Parameters.Add("@IdContract", SqlDbType.Int, 0, "Id договора");
                updateCommand.Parameters.Add("@ItemsCount", SqlDbType.Int, 0, "Количество");
                adapterNotReturnable.UpdateCommand = updateCommand;

                //DELETE
                deleteCmd = new SqlCommand("DELETE FROM dbo.NotReturnableItemsInContracts WHERE IdContract = @IdContract AND IdNotReturnableItem = @IdNotReturnableItem", connection);//dbo.RemoveNotReturnableItemInContract
                //deleteCmd.CommandType = CommandType.StoredProcedure;
                deleteCmd.Parameters.Add("@IdNotReturnableItem", SqlDbType.Int, 0, "Id предмета");
                deleteCmd.Parameters.Add("@IdContract", SqlDbType.Int, 0, "Id договора");
                adapterNotReturnable.DeleteCommand = deleteCmd;

                adapterNotReturnable.Fill(NotReturnableItemsInContract);

            }
        }

        public void AddReturnableItemInOpenedContract(int idReturnableItem, string itemName, string invNumber)
        {
            DataRow dr = ReturnableItemsInContract.NewRow();
            dr[0] = IdContract;
            dr[1] = idReturnableItem;
            dr[2] = itemName;
            dr[3] = invNumber;
            ReturnableItemsInContract.Rows.Add(dr);
            adapterReturnable.Update(ReturnableItemsInContract);
        }

        public void RemoveReturnableItemFromOpenedContract(int rowId)
        {
            DataRow dr = ReturnableItemsInContract.Rows[rowId];
            dr.Delete();
            adapterReturnable.Update(ReturnableItemsInContract);
        }
        
        public void AddNotReturnableItemInOpenedContract(int idNotReturnableItem, string itemName, int itemsCount)
        {
            DataRow dr = NotReturnableItemsInContract.NewRow();
            dr[0] = IdContract;
            dr[1] = idNotReturnableItem;
            dr[2] = itemName;
            dr[3] = itemsCount;
            NotReturnableItemsInContract.Rows.Add(dr);
            adapterNotReturnable.Update(NotReturnableItemsInContract);
        }

        public void EditNotReturnableItemInOpenedContract(int rowId, int newItemsCount)
        {
            DataRow dr = NotReturnableItemsInContract.Rows[rowId];
            dr.BeginEdit();
            dr[3] = newItemsCount;
            dr.EndEdit();
            adapterNotReturnable.Update(NotReturnableItemsInContract);
        }

        public void RemoveNotReturnableItemFromOpenedContract(int rowId)
        {
            DataRow dr = NotReturnableItemsInContract.Rows[rowId];
            dr.Delete();
            adapterNotReturnable.Update(NotReturnableItemsInContract);
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
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@IdResponsible", Value = idResponsible });
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@HostOrganization", Value = hostOrg });

                cmd.ExecuteNonQuery();

                SqlCommand getId = new SqlCommand($"SELECT dbo.GetCurrentContractId ('{contractCode}')", connection);
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

        public static void RemoveContract(int idContract)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("dbo.RemoveContract", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@Id", Value = idContract });
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }
    
        public static void EditContract(int idContract, string newContractCode, int newIdOO, DateTime newDateOfSigning, DateTime newDateOfIssue, DateTime newDateOfReturn, int newIdResponsible, string newHostOrg)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("dbo.EditContract", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", idContract);
                cmd.Parameters.AddWithValue("@ContractCode", newContractCode);
                cmd.Parameters.AddWithValue("@IdOO", newIdOO);
                cmd.Parameters.AddWithValue("@DateOfSigning", newDateOfSigning);
                cmd.Parameters.AddWithValue("@DateOfIssue", newDateOfIssue);
                cmd.Parameters.AddWithValue("@DateOfReturn", newDateOfReturn);
                cmd.Parameters.AddWithValue("@IdResponsible", newIdResponsible);
                cmd.Parameters.AddWithValue("@HostOrganization", newHostOrg);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void CloseContract(int idContract)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmdReturnables = new SqlCommand($"SELECT IdReturnableItem, IdContract FROM dbo.ReturnableItemsInContracts WHERE IdContract = {idContract}", connection);
                DataTable dt = new DataTable();
                dt.Load(cmdReturnables.ExecuteReader());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SqlCommand cmdIns = new SqlCommand($"INSERT INTO dbo.ReturnableItemsInClosedContracts VALUES ({dt.Rows[i][0]}, {dt.Rows[i][1]})", connection);
                    cmdIns.ExecuteNonQuery();
                }

                SqlCommand cmd = new SqlCommand("dbo.CloseContract", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdContract", idContract);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
