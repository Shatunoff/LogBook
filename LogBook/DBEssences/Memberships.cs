using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LogBook
{
    class Memberships
    {
        SqlConnection CONNECTION;
        SqlDataAdapter ADAPTER;
        public DataTable dataTable { get; set; }

        public Memberships()
        {
            using (CONNECTION)
            {
                dataTable = new DataTable();
                CONNECTION = new SqlConnection(Properties.Settings.Default.dbConnectionString);
                ADAPTER = new SqlDataAdapter();
                ADAPTER.SelectCommand = new SqlCommand("SELECT * FROM dbo.Memberships", CONNECTION);

                //INSERT
                SqlCommand insertCommand = new SqlCommand("INSERT INTO dbo.Memberships (Name) VALUES (@Name); SET @Id = @@IDENTITY;", CONNECTION);
                insertCommand.Parameters.Add("@Name", SqlDbType.NVarChar, -1, "Name");
                SqlParameter param = insertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                param.Direction = ParameterDirection.Output;
                ADAPTER.InsertCommand = insertCommand;

                //UPDATE
                SqlCommand updateCommand = new SqlCommand("UPDATE dbo.Memberships SET Name = @Name WHERE Id = @Id", CONNECTION);
                updateCommand.Parameters.Add("@Name", SqlDbType.NVarChar, -1, "Name");
                param = updateCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                param.SourceVersion = DataRowVersion.Original;
                ADAPTER.UpdateCommand = updateCommand;

                //DELETE
                SqlCommand deleteCommand = new SqlCommand("DELETE FROM dbo.Memberships WHERE Id = @Id", CONNECTION);
                param = deleteCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                param.SourceVersion = DataRowVersion.Original;
                ADAPTER.DeleteCommand = deleteCommand;

                ADAPTER.Fill(dataTable);
            }
        }

        public void Add(string name)
        {
            try
            {
                DataRow newRow = dataTable.NewRow();
                newRow["Name"] = name;
                dataTable.Rows.Add(newRow);
                ADAPTER.Update(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Edit(int id, string newName)
        {
            try
            {
                DataRow dr = dataTable.Rows[id];
                dr.BeginEdit();
                dr["Name"] = newName;
                dr.EndEdit();
                ADAPTER.Update(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Remove(int id)
        {
            try
            {
                DataRow dr = dataTable.Rows[id];
                dr.Delete();
                ADAPTER.Update(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
