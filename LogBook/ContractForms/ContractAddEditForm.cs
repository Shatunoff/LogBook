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
    public enum ContractFormType { Adding, Editing }

    public partial class ContractAddEditForm : Form
    {
        ContractFormType thisFormType { get; set; }
        int ContractId { get; set; }
        ContractAddEdit addedit { get; set; } = new ContractAddEdit();

        public ContractAddEditForm(int contractID = -1)
        {
            InitializeComponent();
            if (contractID < 0)
            {
                thisFormType = ContractFormType.Adding;
                FillAddingForm();
            }
            else
            {
                thisFormType = ContractFormType.Editing;
                ContractId = contractID;
                FillEditingForm();
            }

            dgvReturnableItems.DataSource = addedit.ReturnableItems;
            dgvReturnableItems.Columns[0].Visible = false;
            dgvReturnableItems.Columns[1].HeaderText = "Наименование";
            dgvReturnableItems.Columns[2].HeaderText = "Инвентарный номер";
            dgvReturnableItems.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvReturnableItems.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvNotReturnableItems.DataSource = addedit.NotReturnableItems;
            dgvNotReturnableItems.Columns[0].Visible = false;
            dgvNotReturnableItems.Columns[1].HeaderText = "Наименование";
            dgvNotReturnableItems.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            comboResponsible.DataSource = new BindingSource(addedit.Responsibles, null);
            comboResponsible.DisplayMember = "Value";
            comboResponsible.ValueMember = "Key";
        }

        public void FillAddingForm()
        {
            this.Text = "Добавление договора";

            dtpDateOfSigning.Value = DateTime.Now;
            dtpDateOfIssue.Value = DateTime.Now;
            dtpDateOfReturn.Value = DateTime.Now;

            dgvReturnableItemsInContract.Columns.Add("Id", "Id");
            dgvReturnableItemsInContract.Columns.Add("Name", "Наименование");
            dgvReturnableItemsInContract.Columns.Add("InventoryNumber", "Инвентарный номер");
            dgvReturnableItemsInContract.Columns[0].Visible = false;
            dgvReturnableItemsInContract.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvReturnableItemsInContract.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvNotReturnableItemsInContract.Columns.Add("Id", "Id");
            dgvNotReturnableItemsInContract.Columns.Add("Name", "Наименование");
            dgvNotReturnableItemsInContract.Columns.Add("Count", "Количество");
            dgvNotReturnableItemsInContract.Columns[0].Visible = false;
            dgvNotReturnableItemsInContract.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNotReturnableItemsInContract.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvNotReturnableItemsInContract.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            btnCloseContract.Visible = false;
            btnCloseContract.Enabled = false;
            btnOK.Text = "Добавить договор";
        }

        public void FillEditingForm()
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (thisFormType == ContractFormType.Adding)
            {
                AddContract();
            }
            else
            {
                Edit();
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddContract()
        {
            //try
            //{
                int id = 0;
                ContractAddEdit.AddContract(tbContractCode.Text, int.Parse(tbIdOO.Text), dtpDateOfSigning.Value, dtpDateOfIssue.Value, dtpDateOfReturn.Value,
                    (int)comboResponsible.SelectedValue, tbHostOrganization.Text, out id);

                // Добавление возвращаемых предметов в договор
                if (dgvNotReturnableItemsInContract.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvReturnableItemsInContract.Rows.Count; i++)
                    {
                        ContractAddEdit.AddReturnableItemsInContract(int.Parse(dgvReturnableItemsInContract.Rows[i].Cells["Id"].Value.ToString()), id);
                    }
                }

                // Добавление невозвращаемых предметов в договор
                if (dgvNotReturnableItemsInContract.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvNotReturnableItemsInContract.Rows.Count; i++)
                    {
                        ContractAddEdit.AddNotReturnableItemsInContract(int.Parse(dgvNotReturnableItemsInContract.Rows[i].Cells["Id"].Value.ToString()), int.Parse(dgvNotReturnableItemsInContract.Rows[i].Cells["Count"].Value.ToString()), id);
                    }
                }
            //}
            //catch(Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}
        }

        private void Edit()
        {

        }

        private void btnSearchInReturnableItems_Click(object sender, EventArgs e)
        {
            if (tbSearchReturnableItems.TextLength > 0)
            {
                addedit.SearchInReturnableItems(tbSearchReturnableItems.Text);
                dgvReturnableItems.DataSource = addedit.ReturnableItems;
            }
            else
            {
                addedit.RefreshReturnableItems();
                dgvReturnableItems.DataSource = addedit.ReturnableItems;
            }
        }

        private void btnSearchInNotReturnableItems_Click(object sender, EventArgs e)
        {
            if (tbSearchNotReturnableItems.TextLength > 0)
            {
                addedit.SearchInNotReturnableItems(tbSearchNotReturnableItems.Text);
                dgvNotReturnableItems.DataSource = addedit.NotReturnableItems;
            }
            else
            {
                addedit.RefreshNotReturnableItems();
                dgvNotReturnableItems.DataSource = addedit.NotReturnableItems;
            }
        }

        private void tbSearchReturnableItems_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchInReturnableItems.PerformClick();
        }

        private void tbSearchNotReturnableItems_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchInNotReturnableItems.PerformClick();
        }

        private void btnRemoveReturnableItemFromInContract_Click(object sender, EventArgs e)
        {
            if (dgvReturnableItemsInContract.SelectedRows.Count > 0)
            {
                dgvReturnableItemsInContract.Rows.RemoveAt(dgvReturnableItemsInContract.SelectedRows[0].Index);
            }
        }

        private void btnAddReturnableItemInContract_Click(object sender, EventArgs e)
        {
            bool accept = true;
            for (int i = 0; i < dgvReturnableItemsInContract.Rows.Count; i++)
            {
                if (dgvReturnableItemsInContract.Rows[i].Cells[2].Value.ToString() == dgvReturnableItems.SelectedRows[0].Cells[2].Value.ToString())
                    accept = false;
            }
            if (accept)
            {
                dgvReturnableItemsInContract.Rows.Add(dgvReturnableItems.SelectedRows[0].Cells[0].Value.ToString(), 
                    dgvReturnableItems.SelectedRows[0].Cells[1].Value.ToString(), dgvReturnableItems.SelectedRows[0].Cells[2].Value.ToString());
            }
        }

        private void btnAddNotReturnableItemInContract_Click(object sender, EventArgs e)
        {
            bool accept = true;
            for (int i = 0; i < dgvNotReturnableItemsInContract.Rows.Count; i++)
            {
                if (dgvNotReturnableItemsInContract.Rows[i].Cells[0].Value.ToString() == dgvNotReturnableItems.SelectedRows[0].Cells[0].Value.ToString())
                    accept = false;
            }
            if (accept)
            {
                AddNotReturnableInContractForm addNotReturnableForm = new AddNotReturnableInContractForm();
                if (addNotReturnableForm.ShowDialog() == DialogResult.OK)
                {
                    dgvNotReturnableItemsInContract.Rows.Add(dgvNotReturnableItems.SelectedRows[0].Cells[0].Value.ToString(),
                           dgvNotReturnableItems.SelectedRows[0].Cells[1].Value.ToString(), addNotReturnableForm.Count);
                }
            }
        }

        private void btnEditCountNotReturnableItemInContract_Click(object sender, EventArgs e)
        {
            if (dgvNotReturnableItemsInContract.SelectedRows.Count > 0)
            {
                AddNotReturnableInContractForm editCount = new AddNotReturnableInContractForm();
                editCount.Count = int.Parse(dgvNotReturnableItemsInContract.SelectedRows[0].Cells[2].Value.ToString());
                if (editCount.ShowDialog() == DialogResult.OK)
                {
                    dgvNotReturnableItemsInContract.SelectedRows[0].Cells[2].Value = editCount.Count;
                }
            }
        }

        private void btnRemoveNotReturnableItemInContract_Click(object sender, EventArgs e)
        {
            if (dgvNotReturnableItemsInContract.SelectedRows.Count > 0)
            {
                dgvNotReturnableItemsInContract.Rows.RemoveAt(dgvNotReturnableItemsInContract.SelectedRows[0].Index);
            }
        }

        private void btnSelectOO_Click(object sender, EventArgs e)
        {
            SelectOrgForContractForm selectOO = null;
            if (tbIdOO.Text.Length > 0) selectOO = new SelectOrgForContractForm(int.Parse(tbIdOO.Text));
            else selectOO = new SelectOrgForContractForm();
            if (selectOO.ShowDialog() == DialogResult.OK)
            {
                tbIdOO.Text = selectOO.OrgId.ToString();
                tbOOName.Text = selectOO.OrgShortName;
            }
        }
    }
}
