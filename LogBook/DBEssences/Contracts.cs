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

        public void GetOpenedAllDataTable(string contractNumber, int idOO, string responsibleName, DateTime dateOfSigningOT, DateTime dateOfSigningDO, 
            DateTime dateOfISsueOT, DateTime dateOfIssueDO, DateTime dateOfReturnOT, DateTime dateOfReturnDO)
        {
            bool checkContractNum = contractNumber != null;
            bool checkIdOO = idOO > 0;
            bool checkRespName = responsibleName != null;

            DataTable dt = dtOpenedAll.Clone();
            dt.Rows.Clear();

            for (int i = 0; i < dtOpenedAll.Rows.Count; i++)
            {
                if (checkContractNum && dtOpenedAll.Rows[i][1].ToString().ToLower().Contains(contractNumber.ToLower()))
                {
                    if (checkIdOO && idOO == int.Parse(dtOpenedAll.Rows[i][2].ToString()))
                    {
                        if (checkRespName && responsibleName == dtOpenedAll.Rows[i][6].ToString())
                        {
                            if (DateTime.Parse(dtOpenedAll.Rows[i][4].ToString()) >= dateOfSigningOT && DateTime.Parse(dtOpenedAll.Rows[i][4].ToString()) <= dateOfSigningDO)
                            {
                                if (DateTime.Parse(dtOpenedAll.Rows[i][5].ToString()) >= dateOfISsueOT && DateTime.Parse(dtOpenedAll.Rows[i][5].ToString()) <= dateOfIssueDO)
                                {
                                    if (DateTime.Parse(dtOpenedAll.Rows[i][8].ToString()) >= dateOfReturnOT && DateTime.Parse(dtOpenedAll.Rows[i][8].ToString()) <= dateOfReturnDO)
                                    {
                                        dt.Rows.Add(dtOpenedAll.Rows[i]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //TODO: Проверь работу этого кода. Это пиздец какой-то, но я надеюсь сработает. Если срабатывает - расшаривай его для остальных datagridview.
            dtOpenedAll = dt;
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
