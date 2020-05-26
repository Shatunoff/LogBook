using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LogBook
{
    public class ReturnableItems
    {
        SqlConnection CONNECTION;
        SqlDataAdapter ADAPTER;
        public DataTable dataTable { get; set; }

        public ReturnableItems()
        {
            using (CONNECTION)
            {
                dataTable = new DataTable();
                CONNECTION = new SqlConnection(Properties.Settings.Default.dbConnectionString);
                ADAPTER = new SqlDataAdapter();
                ADAPTER.SelectCommand = new SqlCommand("SELECT * FROM dbo.ReturnableItems", CONNECTION);

                //INSERT
                SqlCommand insertCommand = new SqlCommand("INSERT INTO dbo.ReturnableItems (ItemName, InventoryNumber) VALUES (@ItemName, @InventoryNumber); SET @Id = @@IDENTITY;", CONNECTION);
                insertCommand.Parameters.Add("@ItemName", SqlDbType.NVarChar, -1, "ItemName");
                insertCommand.Parameters.Add("@InventoryNumber", SqlDbType.NVarChar, -1, "InventoryNumber");
                SqlParameter param = insertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                param.Direction = ParameterDirection.Output;
                ADAPTER.InsertCommand = insertCommand;

                //UPDATE
                SqlCommand updateCommand = new SqlCommand("UPDATE dbo.ReturnableItems SET ItemName = @ItemName, InventoryNumber = @InventoryNumber WHERE Id = @Id", CONNECTION);
                updateCommand.Parameters.Add("@ItemName", SqlDbType.NVarChar, -1, "ItemName");
                updateCommand.Parameters.Add("@InventoryNumber", SqlDbType.NVarChar, -1, "InventoryNumber");
                param = updateCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                param.SourceVersion = DataRowVersion.Original;
                ADAPTER.UpdateCommand = updateCommand;

                //DELETE
                SqlCommand deleteCommand = new SqlCommand("DELETE FROM dbo.ReturnableItems WHERE Id = @Id", CONNECTION);
                param = deleteCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                param.SourceVersion = DataRowVersion.Original;
                ADAPTER.DeleteCommand = deleteCommand;

                ADAPTER.Fill(dataTable);
            }
        }

        public void ItemAdd(string name, string inventoryNumber)
        {
            try
            {
                DataRow newRow = dataTable.NewRow();
                newRow["ItemName"] = name;
                newRow["InventoryNumber"] = inventoryNumber;
                dataTable.Rows.Add(newRow);
                ADAPTER.Update(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ItemEdit(int id, string newName, string newInventoryNumber)
        {
            try
            {
                DataRow dr = dataTable.Rows[id];
                dr.BeginEdit();
                dr["ItemName"] = newName;
                dr["InventoryNumber"] = newInventoryNumber;
                dr.EndEdit();
                ADAPTER.Update(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ItemRemove(int id)
        {
            try
            {
                DataRow dr = dataTable.Rows[id];
                dr.Delete();
                ADAPTER.Update(dataTable);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Import(DataTable iTable)
        {
            try
            {
                using (CONNECTION)
                {
                    for (int i = 0; i < iTable.Rows.Count; i++)
                    {
                        CONNECTION.Open();
                        SqlCommand command = new SqlCommand("dbo.AddReturnableItem", CONNECTION);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter { ParameterName = "@ItemName", Value = iTable.Rows[i]["ItemName"]});
                        command.Parameters.Add(new SqlParameter { ParameterName = "@InventoryNumber", Value = iTable.Rows[i]["InventoryNumber"] });
                        command.ExecuteNonQuery();
                        CONNECTION.Close();
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
