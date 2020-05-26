using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LogBook
{
    class Ate
    {
        SqlConnection CONNECTION;
        SqlDataAdapter ADAPTER;
        public DataTable dataTable { get; set; }

        public Ate()
        {
            using (CONNECTION)
            {
                dataTable = new DataTable();
                CONNECTION = new SqlConnection(Properties.Settings.Default.dbConnectionString);
                ADAPTER = new SqlDataAdapter();
                ADAPTER.SelectCommand = new SqlCommand("SELECT * FROM dbo.ATE", CONNECTION);

                //INSERT
                SqlCommand insertCommand = new SqlCommand("INSERT INTO dbo.ATE (Id, Name) VALUES (@Id, @Name);", CONNECTION);
                insertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                insertCommand.Parameters.Add("@Name", SqlDbType.NVarChar, -1, "Name");
                ADAPTER.InsertCommand = insertCommand;

                //UPDATE
                SqlCommand updateCommand = new SqlCommand("UPDATE dbo.ATE SET Id = @NewId, Name = @Name WHERE Id = @Id", CONNECTION);
                updateCommand.Parameters.Add("@Name", SqlDbType.NVarChar, -1, "Name");
                SqlParameter param = new SqlParameter();
                param = updateCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                param.SourceVersion = DataRowVersion.Original;
                param = new SqlParameter();
                param = updateCommand.Parameters.Add("@NewId", SqlDbType.Int, 0, "Id");
                param.SourceVersion = DataRowVersion.Current;
                ADAPTER.UpdateCommand = updateCommand;

                //DELETE
                SqlCommand deleteCommand = new SqlCommand("DELETE FROM dbo.ATE WHERE Id = @Id", CONNECTION);
                param = deleteCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                param.SourceVersion = DataRowVersion.Original;
                ADAPTER.DeleteCommand = deleteCommand;

                ADAPTER.Fill(dataTable);
            }
        }

        public void Add(int atecode, string name)
        {
            try
            {
                DataRow newRow = dataTable.NewRow();
                newRow["Id"] = atecode;
                newRow["Name"] = name;
                dataTable.Rows.Add(newRow);
                ADAPTER.Update(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Edit(int id, int newCode, string newName)
        {
            try
            {
                DataRow dr = dataTable.Rows[id];
                dr.BeginEdit();
                dr["Id"] = newCode;
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
