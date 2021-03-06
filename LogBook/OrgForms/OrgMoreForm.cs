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
    public partial class OrgMoreForm : Form
    {
        OrgMore orgMore;
        int idOO;

        public OrgMoreForm(int idOO, bool state = true)
        {
            InitializeComponent();
            this.idOO = idOO;
            orgMore = new OrgMore(idOO);
            if (!state)
            {
                tsbtnContractMore.Enabled = false;
                tsbtnContractNew.Enabled = false;
            }
        }

        private void OrgMoreForm_Load(object sender, EventArgs e)
        {
            tbAteCode.Text = orgMore.Organization.ateCode.ToString();
            tbAteName.Text = orgMore.Organization.ateName;
            tbOOCode.Text = orgMore.Organization.ooCode.ToString();
            tbMembership.Text = orgMore.Organization.ooMembership;
            checkIsPPE9.Checked = orgMore.Organization.isPPE9;
            checkIsPPE11.Checked = orgMore.Organization.isPPE11;
            tbLongName.Text = orgMore.Organization.ooLongName.ToString();
            tbShortName.Text = orgMore.Organization.ooShortName.ToString();
            tbDirector.Text = orgMore.Organization.DirectorFIO.ToString();
            tbEmail.Text = orgMore.Organization.Email.ToString();
            tbPhone.Text = orgMore.Organization.Phone.ToString();
            tbAdress.Text = orgMore.Organization.Adress.ToString();

            this.Text = orgMore.Organization.ooShortName + " — " + "Информация об образовательной организации";

            dgvContracts.DataSource = orgMore.ContractsOfOrganization;
            if (dgvContracts.Columns.Count > 0)
            {
                dgvContracts.Columns[0].Visible = false;
                dgvContracts.Columns[1].Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkIsPPE11_Click(object sender, EventArgs e)
        {
            if (sender is CheckBox)
                ((CheckBox)sender).Checked = !((CheckBox)sender).Checked;
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            OrgAddEditForm edit = new OrgAddEditForm(idOO);
            if (edit.ShowDialog() == DialogResult.OK)
            {
                orgMore = new OrgMore(int.Parse(edit.tbOOCode.Text));
                OrgMoreForm_Load(sender, e);
            }
        }

        private void tsbtnContractMore_Click(object sender, EventArgs e)
        {
            ContractMoreForm moreContract = new ContractMoreForm(int.Parse(dgvContracts.SelectedRows[0].Cells[0].Value.ToString()), bool.Parse(dgvContracts.SelectedRows[0].Cells[7].Value.ToString()), false);
            moreContract.ShowDialog();
        }

        private void tsbtnContractNew_Click(object sender, EventArgs e)
        {
            ContractAddEditForm newContract = new ContractAddEditForm(idOO, tbShortName.Text);
            if (newContract.ShowDialog() == DialogResult.OK)
                orgMore = new OrgMore(idOO);
        }

        private void dgvContracts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbtnContractMore.PerformClick();
        }

        private void tsbtnExportContractsInOrg_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV-Файлы |*.csv";
            save.Title = "Экспорт таблицы";
            if (save.ShowDialog() == DialogResult.OK)
                Export.ToCSV((DataTable)dgvContracts.DataSource, save.FileName);
        }
    }
}
