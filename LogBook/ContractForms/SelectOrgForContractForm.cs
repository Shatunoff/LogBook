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
    public partial class SelectOrgForContractForm : Form
    {
        public int OrgId { get; set; }
        public string OrgShortName { get; private set; }

        OrgAddEdit orgAddEdit { get; set; }

        public SelectOrgForContractForm()
        {
            LoadForTwoModes();
        }

        public SelectOrgForContractForm(int idOO)
        {
            try
            {
                LoadForTwoModes();
                OrgId = idOO;

                comboATEs.SelectedValue = OrgAddEdit.GetCurrentAte(idOO);
                tbSearchQuery.Text = idOO.ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void LoadForTwoModes()
        {
            InitializeComponent();
            orgAddEdit = new OrgAddEdit();
            comboATEs.DataSource = new BindingSource(orgAddEdit.ATEs, null);
            comboATEs.DisplayMember = "Value";
            comboATEs.ValueMember = "Key";

            if (dgvOrgShort.Columns.Count > 0)
            {
                dgvOrgShort.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOrgShort.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dgvOrgShort.SelectedRows.Count > 0)
            {
                OrgId = int.Parse(dgvOrgShort.SelectedRows[0].Cells[0].Value.ToString());
                OrgShortName = dgvOrgShort.SelectedRows[0].Cells[1].Value.ToString();
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboATEs_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSearchQuery.Text.Length > 0)
                    dgvOrgShort.DataSource = SelectOrgForContract.getSearchResult((int)comboATEs.SelectedValue, tbSearchQuery.Text);
                else
                    dgvOrgShort.DataSource = SelectOrgForContract.getAllOrgFromATE((int)comboATEs.SelectedValue);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbSearchQuery_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnFind.PerformClick();
        }

        private void comboATEs_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idAte;
                if (int.TryParse(comboATEs.SelectedValue.ToString(), out idAte))
                    dgvOrgShort.DataSource = SelectOrgForContract.getAllOrgFromATE(idAte);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvOrgShort_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrgShort.SelectedRows.Count > 0) btnOK.PerformClick();
        }
    }
}
