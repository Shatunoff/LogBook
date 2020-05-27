using System;
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
            //if ((checkDateCreate.Checked && dtpDateCreateOT.Value > dtpDateCreateDO.Value) || (checkDateToTrash.Checked && dtpDateToTrashOT.Value > dtpDateToTrashDO.Value))
            //{
            //    MessageBox.Show("Диапазон дат указан неверно!", "Ошибка",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //DateTime dtCreateOT, dtCreateDO, dtTrashOT, dtTrashDO;
            //if (checkDateCreate.Checked)
            //{
            //    dtCreateOT = DateTime.Parse(dtpDateCreateOT.Value.ToShortDateString());
            //    dtCreateDO = DateTime.Parse(dtpDateCreateDO.Value.ToShortDateString());
            //}
            //else
            //{
            //    dtCreateOT = DateTime.MinValue;
            //    dtCreateDO = DateTime.MaxValue;
            //}

            //if (checkDateToTrash.Checked)
            //{
            //    dtTrashOT = DateTime.Parse(dtpDateToTrashOT.Value.ToShortDateString());
            //    dtTrashDO = DateTime.Parse(dtpDateToTrashDO.Value.ToShortDateString());
            //}
            //else
            //{
            //    dtTrashOT = DateTime.MinValue;
            //    dtTrashDO = DateTime.MaxValue;
            //}
            //dgvAll.DataSource = items.GetAllItemsAsDataTable(tbFilterName.Text, cbFilterCategory.Text,
            //    tbFilterComment.Text, dtCreateOT, dtCreateDO, dtTrashOT, dtTrashDO);
            //dgvIsOkay.DataSource = items.GetIsOkayItemsAsDataTable(tbFilterName.Text, cbFilterCategory.Text,
            //    tbFilterComment.Text, dtCreateOT, dtCreateDO, dtTrashOT, dtTrashDO);
            //dgvSoon.DataSource = items.GetIsSoonItemsAsDataTable(tbFilterName.Text, cbFilterCategory.Text,
            //    tbFilterComment.Text, dtCreateOT, dtCreateDO, dtTrashOT, dtTrashDO);
            //dgvOverdue.DataSource = items.GetIsOverdueItemsAsDataTable(tbFilterName.Text, cbFilterCategory.Text,
            //    tbFilterComment.Text, dtCreateOT, dtCreateDO, dtTrashOT, dtTrashDO);
            //butFilterReset.Enabled = true;
        }
    }
}
