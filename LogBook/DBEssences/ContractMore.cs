using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LogBook
{
    public class Contract
    {
        public int      IdContract          { get; private set; }
        public string   ContractCode        { get; private set; }
        public int      IdOO                { get; private set; }
        public DateTime DateOfSigning       { get; private set; }
        public DateTime DateOfIssue         { get; private set; }
        public DateTime DateOfReturn        { get; private set; }
        public string   Responsible         { get; private set; }
        public string   HostOrganization    { get; private set; }
        public bool     ContractClosed      { get; private set; }
        public DateTime ActualReturnDate    { get; private set; }

        public Contract(int idContract)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("dbo.ViewCurrentContract", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@IdContract",
                    Value = idContract
                });

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                connection.Close();

                IdContract = int.Parse(dt.Rows[0][0].ToString());
                ContractCode = dt.Rows[0][1].ToString();
                IdOO = int.Parse(dt.Rows[0][2].ToString());
                DateOfSigning = DateTime.Parse(dt.Rows[0][3].ToString());
                DateOfIssue = DateTime.Parse(dt.Rows[0][4].ToString());
                DateOfReturn = DateTime.Parse(dt.Rows[0][5].ToString());
                Responsible = dt.Rows[0][6].ToString();
                HostOrganization = dt.Rows[0][7].ToString();
                ContractClosed = bool.Parse(dt.Rows[0][8].ToString());
                if (bool.Parse(dt.Rows[0][8].ToString()))
                    ActualReturnDate = DateTime.Parse(dt.Rows[0][9].ToString());
            }
        }
    }

    public class ItemsInContract
    {
        public int IdContract { get; private set; }
        public DataTable NotReturnableItems { get; private set; }
        public DataTable ReturnableItems { get; private set; }

        public ItemsInContract(int IdContract, bool ContractClosed)
        {
            this.IdContract = IdContract;
            GetNotReturnableItems();
            if (ContractClosed)
                GetReturnableItemsInClosedContracts();
            else
                GetReturnableItemsInOpenedContracts();
        }


        private void FillDataTable(DataTable dt, string StoredProcedureName)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(StoredProcedureName, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@IdContract",
                    Value = IdContract
                });

                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                connection.Close();
            }
        }

        public void GetNotReturnableItems()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("dbo.NotReturnableItemsInCurrentContract", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@IdContract",
                    Value = IdContract
                });

                NotReturnableItems = new DataTable();
                NotReturnableItems.Load(cmd.ExecuteReader());

                connection.Close();
            }
        }

        public void GetReturnableItemsInClosedContracts()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("dbo.ReturnableItemsInClosedContract", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@IdContract",
                    Value = IdContract
                });

                ReturnableItems = new DataTable();
                ReturnableItems.Load(cmd.ExecuteReader());

                connection.Close();
            }
        }

        public void GetReturnableItemsInOpenedContracts()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("dbo.ReturnableItemsInOpenedContract", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@IdContract",
                    Value = IdContract
                });

                ReturnableItems = new DataTable();
                ReturnableItems.Load(cmd.ExecuteReader());

                connection.Close();
            }
        }
    }

    public class ContractMore
    {
        public Contract thisContract { get; private set; }
        public Organization thisOrganization { get; private set; }
        public ItemsInContract thisItems { get; private set; }


        public ContractMore(int idContract)
        {
            thisContract = new Contract(idContract);
            thisOrganization = new Organization(thisContract.IdOO);
            thisItems = new ItemsInContract(idContract, thisContract.ContractClosed);
        }
    }
}
