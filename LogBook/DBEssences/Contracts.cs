using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace LogBook
{
    public class Contracts
    {
        public DataTable dtOpenedAll { get; private set; }
        public DataTable dtOpenedProsrok { get; private set; }
        public DataTable dtClosedAll { get; private set; }
        public List<string> listResponsibles { get; private set; }

        public Contracts()
        {
            dtOpenedAll = new DataTable();
            dtOpenedProsrok = new DataTable();
            dtClosedAll = new DataTable();
            listResponsibles = new List<string>();

            GetAllBoxes();
        }

        // Получить данные для всех хранилищ
        public void GetAllBoxes()
        {
            GetOpenedAllDataTable();
            GetOpenedProsrokDataTable();
            GetClosedAllDataTable();
            GetResponsiblesAsList();
        }

        // Представление "Открытые договоры (все)"
        public void GetOpenedAllDataTable()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.ContractsOpenedAll", connection.ConnectionString);
                adapter.Fill(dtOpenedAll);
            }
        }

        // Представление "Открытые договоры (просрок)"
        public void GetOpenedProsrokDataTable()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.ContractsOpenedProsrok", connection.ConnectionString);
                adapter.Fill(dtOpenedProsrok);
            }
        }

        // Представление "Закрытые договоры"
        public void GetClosedAllDataTable()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.ContractsClosed", connection.ConnectionString);
                adapter.Fill(dtClosedAll);
            }
        }

        // Получить список ответственных для combobox
        public void GetResponsiblesAsList()
        {
            listResponsibles.Clear();
            listResponsibles.Add("");
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT Name From dbo.Responsibles", connection);
                ad.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++) listResponsibles.Add(dt.Rows[i][0].ToString());
            }
        }
    }
}
