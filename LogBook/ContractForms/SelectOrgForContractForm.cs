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

        Organizations organizations { get; set; }
        OrgAddEdit orgAddEdit { get; set; }

        public SelectOrgForContractForm()
        {
            InitializeComponent();
            organizations = new Organizations();
            orgAddEdit = new OrgAddEdit();

            comboATEs.DataSource = new BindingSource(orgAddEdit.ATEs, null);
            comboATEs.DisplayMember = "Value";
            comboATEs.ValueMember = "Key";
            

        }

        public SelectOrgForContractForm(int idOO)
        {
            InitializeComponent();
            OrgId = idOO;

            orgAddEdit = new OrgAddEdit();

            comboATEs.DataSource = new BindingSource(orgAddEdit.ATEs, null);
            comboATEs.DisplayMember = "Value";
            comboATEs.ValueMember = "Key";
            comboATEs.SelectedValue = OrgAddEdit.GetCurrentAte(idOO);
            tbSearchQuery.Text = idOO.ToString();
            btnFind.PerformClick();
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

        private void getOrgsFromAte()
        {
            if (comboATEs.Items.Count > 0)
                dgvOrgShort.DataSource = SelectOrgForContract.getAllOrgFromATE(Convert.ToInt32(comboATEs.SelectedValue));
        }

        private void comboATEs_SelectedIndexChanged(object sender, EventArgs e)
        {
            getOrgsFromAte();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (tbSearchQuery.Text.Length > 0)
                dgvOrgShort.DataSource = SelectOrgForContract.getSearchResult((int)comboATEs.SelectedValue, tbSearchQuery.Text);
            else
                getOrgsFromAte();
        }

        private void tbSearchQuery_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnFind.PerformClick();
        }
    }
}
