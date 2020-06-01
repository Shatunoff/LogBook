using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace LogBook
{
    public partial class MainForm : Form
    {
        Contracts dbContracts;
        Organizations dbOrg;

        public MainForm()
        {
            InitializeComponent();
            dgvContractsOpenedAll.DoubleBuffered(true);
            dgvContractsOpenedProsrok.DoubleBuffered(true);
            dgvContractsClosed.DoubleBuffered(true);
            dgvOrg.DoubleBuffered(true);
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
                for (int i = 0; i < dgvOrg.Columns.Count; i++) dgvOrg.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvOrg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvOrg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvOrg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrg.Columns[1].MinimumWidth = 150;
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
            string contractCode = tbContractsFilterNumber.Text;
            string ooCode = null;
            int idOO;
            if (int.TryParse(tbContractsFilterCodeOO.Text, out idOO))
                ooCode = idOO.ToString();
            string responsible = comboContractsFilterResponsible.Text;

            DateTime dtSigningOT, dtSigningDO, dtIssueOT, dtIssueDO, dtReturnOT, dtReturnDO;

            if (checkContractsFilterDateOfSigning.Checked)
            {
                dtSigningOT = dtpContractsFilterSingingOT.Value;
                dtSigningDO = dtpContractsFilterSingingDO.Value;
            }
            else
            {
                dtSigningOT = DateTime.Parse("01.01.1800");
                dtSigningDO = DateTime.Parse("01.01.9800");
            }

            if (checkContractsFilterDateOfIssue.Checked)
            {
                dtIssueOT = dtpContractsFilterIssueOT.Value;
                dtIssueDO = dtpContractsFilterIssueDO.Value;
            }
            else
            {
                dtIssueOT = DateTime.Parse("01.01.1800");
                dtIssueDO = DateTime.Parse("01.01.9800");
            }

            if (checkContractsFilterDateOfReturn.Checked)
            {
                dtReturnOT = dtpContractsFilterReturnOT.Value;
                dtReturnDO = dtpContractsFilterReturnDO.Value;
            }
            else
            {
                dtReturnOT = DateTime.Parse("01.01.1800");
                dtReturnDO = DateTime.Parse("01.01.9800");
            }

            dbContracts.FilterContracts(contractCode, ooCode, responsible, dtSigningOT, dtSigningDO, dtIssueOT, dtIssueDO, dtReturnOT, dtReturnDO);
            dgvContractsOpenedAll.DataSource = dbContracts.dtOpenedAll;
            dgvContractsOpenedProsrok.DataSource = dbContracts.dtOpenedProsrok;
            dgvContractsClosed.DataSource = dbContracts.dtClosedAll;
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

        private void tsbtnOrgAdd_Click(object sender, EventArgs e)
        {
            OrgAddEditForm add = new OrgAddEditForm();
            if (add.ShowDialog() == DialogResult.OK)
                Refresh_OrganizationsDataGridView();
        }

        private void tsbtnOrgEdit_Click(object sender, EventArgs e)
        {
            if (dgvOrg.SelectedRows.Count > 0)
            {
                int idOO = int.Parse(dgvOrg.SelectedRows[0].Cells[3].Value.ToString());
                OrgAddEditForm edit = new OrgAddEditForm(idOO);
                if (edit.ShowDialog() == DialogResult.OK)
                    Refresh_OrganizationsDataGridView();
            }
        }

        private void tsbtnOrgRemove_Click(object sender, EventArgs e)
        {
            if (dgvOrg.SelectedRows.Count > 0)
            {
                int idOO = int.Parse(dgvOrg.SelectedRows[0].Cells[3].Value.ToString());
                if (MessageBox.Show("Вы уверены, что хотите удалить данную организацию? Все договоры с ее участием также будут удалены!", "Подтверждение удаления", 
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    OrgAddEdit.RemoveOO(idOO);
                    Refresh_OrganizationsDataGridView();
                }
            }
        }

        private void tsbtnOrgRefresh_Click(object sender, EventArgs e)
        {
            Refresh_OrganizationsDataGridView();
        }

        private void tsbtnOrgExport_Click(object sender, EventArgs e)
        {
            exportToCSV((DataTable)dgvOrg.DataSource);
        }

        private void exportToCSV(DataTable dt)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV-Файлы |*.csv";
            save.Title = "Экспорт таблицы";
            if (save.ShowDialog() == DialogResult.OK)
                Export.ToCSV(dt, save.FileName);
        }

        private void tsbtnConClosedExport_Click(object sender, EventArgs e)
        {
            exportToCSV((DataTable)dgvContractsClosed.DataSource);
        }

        private void tsbtnConProsrokExport_Click(object sender, EventArgs e)
        {
            exportToCSV((DataTable)dgvContractsOpenedProsrok.DataSource);
        }

        private void tsbtnConOpAllExport_Click(object sender, EventArgs e)
        {
            exportToCSV((DataTable)dgvContractsOpenedAll.DataSource);
        }

        private void ViewMoreOfContract(int idContract, bool contractOpened)
        {
            ContractMoreForm contMore = new ContractMoreForm(idContract, contractOpened);
            contMore.ShowDialog();
        }

        private void tsbtnConOpAllView_Click(object sender, EventArgs e)
        {
            if (dgvContractsOpenedAll.SelectedRows.Count > 0)
            {
                int idContract = int.Parse(dgvContractsOpenedAll.SelectedRows[0].Cells[0].Value.ToString());
                ViewMoreOfContract(idContract, true);
            }
        }

        private void tsbtnConProsrokView_Click(object sender, EventArgs e)
        {
            if (dgvContractsOpenedProsrok.SelectedRows.Count > 0)
            {
                int idContract = int.Parse(dgvContractsOpenedProsrok.SelectedRows[0].Cells[0].Value.ToString());
                ViewMoreOfContract(idContract, true);
            }
        }

        private void tsbtnConClosedView_Click(object sender, EventArgs e)
        {
            if (dgvContractsClosed.SelectedRows.Count > 0)
            {
                int idContract = int.Parse(dgvContractsClosed.SelectedRows[0].Cells[0].Value.ToString());
                ViewMoreOfContract(idContract, false);
            }
        }

        private void tsbtnConOpAllNew_Click(object sender, EventArgs e)
        {
            ContractAddEditForm addContract = new ContractAddEditForm();
            if(addContract.ShowDialog() == DialogResult.OK)
            {
                Refresh_ContractsOpenedDataGridView();
            }
        }

        private void RemoveContract(int id)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить данную организацию? Все договоры с ее участием также будут удалены!", "Подтверждение удаления",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ContractAddEdit.RemoveContract(id);
                Refresh_ContractsDataGridView();
            }

        }

        private void tsbtnConOpAllRemove_Click(object sender, EventArgs e)
        {
            if (dgvContractsOpenedAll.SelectedRows.Count > 0)
            {
                RemoveContract(int.Parse(dgvContractsOpenedAll.SelectedRows[0].Cells[0].Value.ToString()));
            }
        }

        private void tsbtnConOpProsrok_Click(object sender, EventArgs e)
        {
            if (dgvContractsOpenedProsrok.SelectedRows.Count > 0)
            {
                RemoveContract(int.Parse(dgvContractsOpenedProsrok.SelectedRows[0].Cells[0].Value.ToString()));
            }
        }

        private void tsbtnConClosedRemove_Click(object sender, EventArgs e)
        {
            if (dgvContractsClosed.SelectedRows.Count > 0)
            {
                RemoveContract(int.Parse(dgvContractsClosed.SelectedRows[0].Cells[0].Value.ToString()));
            }
        }

        private void tsbtnConOpAllRefresh_Click(object sender, EventArgs e)
        {
            Refresh_ContractsOpenedDataGridView();
        }

        private void tsbtnConProsrokRefresh_Click(object sender, EventArgs e)
        {
            Refresh_ContractsOpenedProsrokDataGridView();
        }

        private void tsbtnConClosedRefresh_Click(object sender, EventArgs e)
        {
            Refresh_ContractsClosedDataGridView();
        }

        private void tsbtnConOpAllEdit_Click(object sender, EventArgs e)
        {
            if (dgvContractsOpenedAll.SelectedRows.Count > 0)
            {
                ContractAddEditForm edit = new ContractAddEditForm(int.Parse(dgvContractsOpenedAll.SelectedRows[0].Cells[0].Value.ToString()));
                if (edit.ShowDialog() == DialogResult.OK)
                    Refresh_ContractsDataGridView();
            }
        }

        private void dgvContractsOpenedAll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbtnConOpAllView.PerformClick();
        }

        private void dgvContractsOpenedProsrok_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbtnConProsrokView.PerformClick();
        }

        private void dgvContractsClosed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbtnConClosedView.PerformClick();
        }

        private void dgvOrg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbtnOrgView.PerformClick();
        }

        private void dgvOrg_DataSourceChanged(object sender, EventArgs e)
        {
            tslOrgCount.Text = dgvOrg.Rows.Count.ToString();
        }

        private void dgvContractsOpenedAll_DataSourceChanged(object sender, EventArgs e)
        {
            tslConOpAllCount.Text = dgvContractsOpenedAll.Rows.Count.ToString();
        }

        private void dgvContractsOpenedProsrok_DataSourceChanged(object sender, EventArgs e)
        {
            tslConOpProsrokCount.Text = dgvContractsOpenedProsrok.Rows.Count.ToString();
        }

        private void dgvContractsClosed_DataSourceChanged(object sender, EventArgs e)
        {
            tslConClosedCount.Text = dgvContractsClosed.Rows.Count.ToString();
        }

        private void btnOrgFilterApply_Click(object sender, EventArgs e)
        {
            string ooCode = null;
            int idOO;
            if (int.TryParse(tbOrgFilterOOCode.Text, out idOO))
                ooCode = idOO.ToString();
            string ooName = tbOrgFilterOOName.Text;
            string ateName = comboOrgFilterATE.Text;
            string membership = comboOrgFilterMemberships.Text;

            dbOrg.FilterOrgs(ooName, ooCode, ateName, membership);
            dgvOrg.DataSource = dbOrg.dtAllOrg;
        }

        private void btnOrgFilterReset_Click(object sender, EventArgs e)
        {
            tbOrgFilterOOCode.Clear();
            tbOrgFilterOOName.Clear();
            comboOrgFilterATE.SelectedIndex = 0;
            comboOrgFilterMemberships.SelectedIndex = 0;
            tsbtnOrgRefresh.PerformClick();
        }

        private void checkContractsFilterDateOfSigning_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkContractsFilterDateOfSigning.Checked)
            {
                dtpContractsFilterSingingOT.Enabled = true;
                dtpContractsFilterSingingDO.Enabled = true;
            }
            else
            {
                dtpContractsFilterSingingOT.Enabled = false;
                dtpContractsFilterSingingDO.Enabled = false;
            }

        }

        private void checkContractsFilterDateOfIssue_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkContractsFilterDateOfIssue.Checked)
            {
                dtpContractsFilterIssueOT.Enabled = true;
                dtpContractsFilterIssueDO.Enabled = true;
            }
            else
            {
                dtpContractsFilterIssueOT.Enabled = false;
                dtpContractsFilterIssueDO.Enabled = false;
            }
        }

        private void checkContractsFilterDateOfReturn_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkContractsFilterDateOfReturn.Checked)
            {
                dtpContractsFilterReturnOT.Enabled = true;
                dtpContractsFilterReturnDO.Enabled = true;
            }
            else
            {
                dtpContractsFilterReturnOT.Enabled = false;
                dtpContractsFilterReturnDO.Enabled = false;
            }
        }

        private void btnContractsFilterReset_Click(object sender, EventArgs e)
        {
            tbContractsFilterCodeOO.Clear();
            tbContractsFilterNumber.Clear();
            comboContractsFilterResponsible.SelectedIndex = 0;
            checkContractsFilterDateOfSigning.Checked = false;
            checkContractsFilterDateOfIssue.Checked = false;
            checkContractsFilterDateOfReturn.Checked = false;
            Refresh_ContractsDataGridView();
        }

        private void статистикаПоПредметамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemStatisticForm stat = new ItemStatisticForm();
            stat.ShowDialog();
        }
    }

    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }
}
