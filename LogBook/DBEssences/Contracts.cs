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

        public void FilterContracts(string contractNum, string idOO, string responsible, DateTime dateOfSigningOT, DateTime dateOfSigningDO,
            DateTime dateOfIssueOT, DateTime dateOfIssueDO, DateTime dateOfReturnOT, DateTime dateOfReturnDO)
        {
            string filterContractNum = contractNum == null ? string.Empty : contractNum;
            string filterIdOO = idOO == null ? string.Empty : idOO;
            string filterResponsible = responsible == null ? string.Empty : responsible;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                dtOpenedAll = new DataTable();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM dbo.ContractsOpenedAll " +
                    $"WHERE [Номер договора] LIKE '%{filterContractNum}%' AND [Ответственный за выдачу] LIKE '%{filterResponsible}%' " +
                    $"AND [Код ОО] LIKE '%{filterIdOO}%' AND ([Дата заключения] >= @DateOfSigningOT AND [Дата заключения] <= @DateOfSigningDO) AND" +
                    $"([Дата выдачи] >= @DateOfIssueOT AND [Дата выдачи] <= @DateOfIssueDO) AND" +
                    $"([Дата возврата] >= @DateOfReturnOT AND [Дата возврата] <= @DateOfReturnDO)", connection);
                cmd.Parameters.AddWithValue("@DateOfSigningOT", dateOfSigningOT);
                cmd.Parameters.AddWithValue("@DateOfSigningDO", dateOfSigningDO);
                cmd.Parameters.AddWithValue("@DateOfIssueOT", dateOfIssueOT);
                cmd.Parameters.AddWithValue("@DateOfIssueDO", dateOfIssueDO);
                cmd.Parameters.AddWithValue("@DateOfReturnOT", dateOfReturnOT);
                cmd.Parameters.AddWithValue("@DateOfReturnDO", dateOfReturnDO);
                dtOpenedAll.Load(cmd.ExecuteReader());

                dtOpenedProsrok = new DataTable();
                cmd = new SqlCommand($"SELECT * FROM dbo.ContractsOpenedProsrok " +
                    $"WHERE [Номер договора] LIKE '%{filterContractNum}%' AND [Ответственный за выдачу] LIKE '%{filterResponsible}%' " +
                    $"AND [Код ОО] LIKE '%{filterIdOO}%' AND ([Дата заключения] >= @DateOfSigningOT AND [Дата заключения] <= @DateOfSigningDO) AND" +
                    $"([Дата выдачи] >= @DateOfIssueOT AND [Дата выдачи] <= @DateOfIssueDO) AND" +
                    $"([Дата возврата] >= @DateOfReturnOT AND [Дата возврата] <= @DateOfReturnDO)", connection);
                cmd.Parameters.AddWithValue("@DateOfSigningOT", dateOfSigningOT);
                cmd.Parameters.AddWithValue("@DateOfSigningDO", dateOfSigningDO);
                cmd.Parameters.AddWithValue("@DateOfIssueOT", dateOfIssueOT);
                cmd.Parameters.AddWithValue("@DateOfIssueDO", dateOfIssueDO);
                cmd.Parameters.AddWithValue("@DateOfReturnOT", dateOfReturnOT);
                cmd.Parameters.AddWithValue("@DateOfReturnDO", dateOfReturnDO);
                dtOpenedProsrok.Load(cmd.ExecuteReader());

                dtClosedAll = new DataTable();
                cmd = new SqlCommand($"SELECT * FROM dbo.ContractsClosed " +
                    $"WHERE [Номер договора] LIKE '%{filterContractNum}%' AND [Ответственный за выдачу] LIKE '%{filterResponsible}%' " +
                    $"AND [Код ОО] LIKE '%{filterIdOO}%' AND ([Дата заключения] >= @DateOfSigningOT AND [Дата заключения] <= @DateOfSigningDO) AND" +
                    $"([Дата выдачи] >= @DateOfIssueOT AND [Дата выдачи] <= @DateOfIssueDO) AND" +
                    $"([Дата возврата по договору] >= @DateOfReturnOT AND [Дата возврата по договору] <= @DateOfReturnDO)", connection);
                cmd.Parameters.AddWithValue("@DateOfSigningOT", dateOfSigningOT);
                cmd.Parameters.AddWithValue("@DateOfSigningDO", dateOfSigningDO);
                cmd.Parameters.AddWithValue("@DateOfIssueOT", dateOfIssueOT);
                cmd.Parameters.AddWithValue("@DateOfIssueDO", dateOfIssueDO);
                cmd.Parameters.AddWithValue("@DateOfReturnOT", dateOfReturnOT);
                cmd.Parameters.AddWithValue("@DateOfReturnDO", dateOfReturnDO);
                dtClosedAll.Load(cmd.ExecuteReader());

                connection.Close();
            }
        }
    }
}
