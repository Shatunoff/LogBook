using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LogBook
{
    public class NotReturnableItems
    {
        // Представление "Открытые договоры (все)"
        public DataTable GetAllDataTable()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.NotReturnableItems", connection.ConnectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Хранимая процедура "Добавить невозвращаемый предмет"
        public void ItemAdd(string name)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("dbo.AddNotReturnableItem", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = name
                };

                command.Parameters.Add(nameParam);
                command.ExecuteNonQuery();
            }
        }

        // Хранимая процедура "Изменить невозвращаемый предмет"
        public void ItemEdit(int id, string newName)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("dbo.EditNotReturnableItem", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@Id",
                    Value = id
                };
                command.Parameters.Add(idParam);

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = newName
                };
                command.Parameters.Add(nameParam);

                command.ExecuteNonQuery();
            }
        }

        // Хранимая процедура "Удалить невозвращаемый предмет"
        public void ItemRemove(int id)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("dbo.RemoveNotReturnableItem", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@Id",
                    Value = id
                };

                command.Parameters.Add(idParam);
                command.ExecuteNonQuery();
            }
        }
    }
}
