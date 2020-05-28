﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogBook
{
    public partial class MainForm : Form
    {
        Contracts dbContracts;
        Organizations dbOrg;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Refresh_Connection();

            // Установка ширины столбцов таблиц договоров
            if (dgvContractsOpenedAll.ColumnCount > 0)
            {
                dgvContractsOpenedAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvContractsOpenedAll.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvContractsOpenedAll.Columns[0].Visible = false;
                dgvContractsOpenedAll.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsOpenedAll.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsOpenedAll.Columns[3].MinimumWidth = 100;
                dgvContractsOpenedAll.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvContractsOpenedAll.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsOpenedAll.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsOpenedAll.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsOpenedAll.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsOpenedAll.Columns[8].MinimumWidth = 100;
                dgvContractsOpenedAll.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (dgvContractsOpenedProsrok.ColumnCount > 0)
            {
                dgvContractsOpenedProsrok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvContractsOpenedProsrok.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvContractsOpenedProsrok.Columns[0].Visible = false;
                dgvContractsOpenedProsrok.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsOpenedProsrok.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsOpenedProsrok.Columns[3].MinimumWidth = 100;
                dgvContractsOpenedProsrok.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvContractsOpenedProsrok.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsOpenedProsrok.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsOpenedProsrok.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsOpenedProsrok.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsOpenedProsrok.Columns[8].MinimumWidth = 100;
                dgvContractsOpenedProsrok.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (dgvContractsClosed.ColumnCount > 0)
            {
                dgvContractsClosed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvContractsClosed.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvContractsClosed.Columns[0].Visible = false;
                dgvContractsClosed.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsClosed.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsClosed.Columns[3].MinimumWidth = 100;
                dgvContractsClosed.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvContractsClosed.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsClosed.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsClosed.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsClosed.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsClosed.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvContractsClosed.Columns[9].MinimumWidth = 100;
                dgvContractsClosed.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Установка ширины столбцов таблицы организаций
            if (dgvOrg.ColumnCount > 0)
            {
                dgvOrg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvOrg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvOrg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrg.Columns[4].MinimumWidth = 200;
                dgvOrg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvOrg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrg.Columns[7].MinimumWidth = 200;
                dgvOrg.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void Refresh_Connection()
        {
            try
            {
                dbContracts = new Contracts();
                dbOrg = new Organizations();

                dgvContractsOpenedAll.DataSource = dbContracts.dtOpenedAll;
                dgvContractsOpenedProsrok.DataSource = dbContracts.dtOpenedProsrok;
                dgvContractsClosed.DataSource = dbContracts.dtClosedAll;
                comboContractsFilterResponsible.DataSource = dbContracts.listResponsibles;

                dgvOrg.DataSource = dbOrg.dtAllOrg;
                comboOrgFilterATE.DataSource = dbOrg.listATEs;
                comboOrgFilterMemberships.DataSource = dbOrg.listMemberships;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка соединения с базой данных");
            }
        }

        public void Refresh_AllDataGridView()
        {
            try
            {
                dbContracts.GetAllBoxes();
                dbOrg.GetAllBoxes();

                dgvContractsOpenedAll.DataSource = dbContracts.dtOpenedAll;
                dgvContractsOpenedProsrok.DataSource = dbContracts.dtOpenedProsrok;
                dgvContractsClosed.DataSource = dbContracts.dtClosedAll;
                comboContractsFilterResponsible.DataSource = dbContracts.listResponsibles;

                dgvOrg.DataSource = dbOrg.dtAllOrg;
                comboOrgFilterATE.DataSource = dbOrg.listATEs;
                comboOrgFilterMemberships.DataSource = dbOrg.listMemberships;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка соединения с базой данных");
            }
        }

        public void Refresh_ContractsDataGridView()
        {
            try
            {
                dbContracts.GetAllBoxes();

                dgvContractsOpenedAll.DataSource = dbContracts.dtOpenedAll;
                dgvContractsOpenedProsrok.DataSource = dbContracts.dtOpenedProsrok;
                dgvContractsClosed.DataSource = dbContracts.dtClosedAll;
                comboContractsFilterResponsible.DataSource = dbContracts.listResponsibles;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка соединения с базой данных");
            }
        }

        public void Refresh_ContractsOpenedDataGridView()
        {
            try
            {
                dbContracts.GetOpenedAllDataTable();
                dbContracts.GetResponsiblesAsList();

                dgvContractsOpenedAll.DataSource = dbContracts.dtOpenedAll;
                comboContractsFilterResponsible.DataSource = dbContracts.listResponsibles;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка соединения с базой данных");
            }
        }

        public void Refresh_ContractsOpenedProsrokDataGridView()
        {
            try
            {
                dbContracts.GetOpenedProsrokDataTable();
                dbContracts.GetResponsiblesAsList();

                dgvContractsOpenedProsrok.DataSource = dbContracts.dtOpenedProsrok;
                comboContractsFilterResponsible.DataSource = dbContracts.listResponsibles;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка соединения с базой данных");
            }
        }

        public void Refresh_ContractsClosedDataGridView()
        {
            try
            {
                dbContracts.GetClosedAllDataTable();
                dbContracts.GetResponsiblesAsList();

                dgvContractsClosed.DataSource = dbContracts.dtClosedAll;
                comboContractsFilterResponsible.DataSource = dbContracts.listResponsibles;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка соединения с базой данных");
            }
        }

        public void Refresh_OrganizationsDataGridView()
        {
            try
            {
                dbOrg.GetAllBoxes();

                dgvOrg.DataSource = dbOrg.dtAllOrg;
                comboOrgFilterATE.DataSource = dbOrg.listATEs;
                comboOrgFilterMemberships.DataSource = dbOrg.listMemberships;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка соединения с базой данных");
            }
        }

        private void mmBaseSettings_Click(object sender, EventArgs e)
        {
            DBConnectionSettingForm conSettings = new DBConnectionSettingForm();
            conSettings.ShowDialog();
        }

        private void mmBaseExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mmBaseConnect_Click(object sender, EventArgs e)
        {
            Refresh_AllDataGridView();
        }

        private void mmContractsNotReturnableItems_Click(object sender, EventArgs e)
        {
            NotReturnableItemsForm nri = new NotReturnableItemsForm();
            nri.ShowDialog();
        }

        private void mmContractsReturnableItems_Click(object sender, EventArgs e)
        {
            ReturnableItemsForm ri = new ReturnableItemsForm();
            ri.ShowDialog();
        }

        private void mmContractsResponsibles_Click(object sender, EventArgs e)
        {
            ResponsiblesForm rf = new ResponsiblesForm();
            rf.ShowDialog();
        }

        private void mmOrgATE_Click(object sender, EventArgs e)
        {
            AteForm ate = new AteForm();
            ate.ShowDialog();
        }

        private void mmOrgMemberships_Click(object sender, EventArgs e)
        {
            MembershipsForm member = new MembershipsForm();
            member.ShowDialog();
        }

        private void btnContractsFilterApply_Click(object sender, EventArgs e)
        {
            if ((checkContractsFilterDateOfSigning.Checked && dtpContractsFilterSingingOT.Value > dtpContractsFilterSingingDO.Value) || 
                (checkContractsFilterDateOfIssue.Checked && dtpContractsFilterIssueOT.Value > dtpContractsFilterIssueDO.Value) ||
                (checkContractsFilterDateOfReturn.Checked && dtpContractsFilterReturnOT.Value > dtpContractsFilterReturnDO.Value))
            {
                MessageBox.Show("Диапазон дат указан неверно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime dtSigningOT, dtSigningDO, dtIssueOT, dtIssueDO, dtReturnOT, dtReturnDO;
            string contractNumber = tbContractsFilterNumber.TextLength > 0 ? tbContractsFilterNumber.Text : String.Empty;
            int ooCode = 0;

            if (tbContractsFilterCodeOO.TextLength > 0)
            {
                int code;
                if (int.TryParse(tbContractsFilterCodeOO.Text, out code))
                    ooCode = code;
            }

            string responsible = comboContractsFilterResponsible.Text.Length > 0 ? comboContractsFilterResponsible.Text : String.Empty;

            if (checkContractsFilterDateOfSigning.Checked)
            {
                dtSigningOT = DateTime.Parse(dtpContractsFilterSingingOT.Value.ToShortDateString());
                dtSigningDO = DateTime.Parse(dtpContractsFilterSingingDO.Value.ToShortDateString());
            }
            else
            {
                dtSigningOT = DateTime.Parse(DateTime.MinValue.ToShortDateString());
                dtSigningDO = DateTime.Parse(DateTime.MaxValue.ToShortDateString());
            }

            if (checkContractsFilterDateOfIssue.Checked)
            {
                dtIssueOT = DateTime.Parse(dtpContractsFilterIssueOT.Value.ToShortDateString());
                dtIssueDO = DateTime.Parse(dtpContractsFilterIssueDO.Value.ToShortDateString());
            }
            else
            {
                dtIssueOT = DateTime.Parse(DateTime.MinValue.ToShortDateString());
                dtIssueDO = DateTime.Parse(DateTime.MaxValue.ToShortDateString());
            }

            if (checkContractsFilterDateOfReturn.Checked)
            {
                dtReturnOT = DateTime.Parse(dtpContractsFilterReturnOT.Value.ToShortDateString());
                dtReturnDO = DateTime.Parse(dtpContractsFilterReturnDO.Value.ToShortDateString());
            }
            else
            {
                dtReturnOT = DateTime.Parse(DateTime.MinValue.ToShortDateString());
                dtReturnDO = DateTime.Parse(DateTime.MaxValue.ToShortDateString());
            }

            dbContracts?.GetOpenedAllDataTable(contractNumber, ooCode, responsible, dtSigningOT, dtSigningDO, dtIssueOT, dtIssueDO, dtReturnOT, dtReturnDO);

            btnContractsFilterReset.Enabled = true;
        }

        private void tsbtnOrgView_Click(object sender, EventArgs e)
        {
            if (dgvOrg.SelectedRows.Count > 0)
            {
                int idOO = int.Parse(dgvOrg.SelectedRows[0].Cells[3].Value.ToString());
                OrgMoreForm orgMore = new OrgMoreForm(idOO);
                orgMore.ShowDialog();
            }
        }
    }
}
