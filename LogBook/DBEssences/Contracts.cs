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
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.ContractsOpenedAll", connection);
                dtOpenedAll = new DataTable();
                dtOpenedAll.Load(command.ExecuteReader());

                connection.Close();
            }
        }

        public void GetOpenedAllDataTable(string ContractNumber, int IdOO, string ResponsibleName, DateTime DateOfSigningOT, DateTime DateOfSigningDO, 
            DateTime DateOfIssueOT, DateTime DateOfIssueDO, DateTime DateOfReturnOT, DateTime DateOfReturnDO)
        {
            DataTable dt = dtOpenedAll.Clone();
            dt.Rows.Clear();

            if (dtOpenedAll.Rows.Count > 0)
            {
                for (int i = 0; i < dtOpenedAll.Rows.Count; i++)
                {
                    string contractCode = dtOpenedAll.Rows[i][1].ToString();
                    int ooCode = int.Parse(dtOpenedAll.Rows[i][2].ToString());
                    string responName = dtOpenedAll.Rows[i][6].ToString();
                    DateTime dateOfSigning = DateTime.Parse(dtOpenedAll.Rows[i][4].ToString());
                    DateTime dateOfIssue = DateTime.Parse(dtOpenedAll.Rows[i][5].ToString());
                    DateTime dateOfReturn = DateTime.Parse(dtOpenedAll.Rows[i][8].ToString());

                    if (contractCode.ToLower().Contains(ContractNumber.ToLower()) &&
                        responName.ToLower().Contains(ResponsibleName.ToLower()) &&
                        (dateOfSigning >= DateOfSigningOT && dateOfSigning <= DateOfSigningDO) &&
                        (dateOfIssue >= DateOfIssueOT && dateOfIssue <= DateOfIssueDO) &&
                        (dateOfReturn >= DateOfReturnOT && dateOfReturn <= DateOfReturnDO))
                    {
                        if (IdOO > 0)
                        {
                            if (IdOO == ooCode)
                            {
                                DataRow row = dt.NewRow();
                                for (int j = 0; j < dtOpenedAll.Columns.Count; j++)
                                    row[j] = dtOpenedAll.Rows[i][j];
                                dt.Rows.Add(row);
                            }
                        }
                        else
                        {
                            DataRow row = dt.NewRow();
                            for (int j = 0; j < dtOpenedAll.Columns.Count; j++)
                                row[j] = dtOpenedAll.Rows[i][j];
                            dt.Rows.Add(row);
                        }
                    }
                }
            }
            dtOpenedAll = new DataTable();
            dtOpenedAll = dt;
        }

        // Представление "Открытые договоры (просрок)"
        public void GetOpenedProsrokDataTable()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.ContractsOpenedProsrok", connection);
                dtOpenedProsrok = new DataTable();
                dtOpenedProsrok.Load(command.ExecuteReader());

                connection.Close();
            }
        }

        // Представление "Закрытые договоры"
        public void GetClosedAllDataTable()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.ContractsClosed", connection);
                dtClosedAll = new DataTable();
                dtClosedAll.Load(command.ExecuteReader());

                connection.Close();
            }
        }

        // Получить список ответственных для combobox
        public void GetResponsiblesAsList()
        {
            listResponsibles = new List<string>();
            listResponsibles.Add("");
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                DataTable dt = new DataTable();
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Name From dbo.Responsibles", connection);
                dt.Load(command.ExecuteReader());

                connection.Close();
                for (int i = 0; i < dt.Rows.Count; i++) listResponsibles.Add(dt.Rows[i][0].ToString());
            }
        }
    }
}
