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
    public partial class NotReturnableItemsForm : Form
    {
        NotReturnableItems nri = new NotReturnableItems();
        public NotReturnableItemsForm()
        {
            InitializeComponent();
            dgvNotReturnableItems.DataSource = nri.GetAllDataTable();
            dgvNotReturnableItems.Columns[0].Visible = false;
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            nri.ItemAdd(tbName.Text);
            dgvNotReturnableItems.DataSource = nri.GetAllDataTable();
        }

        private void btnItemEdit_Click(object sender, EventArgs e)
        {
            if (dgvNotReturnableItems.SelectedRows.Count > 0)
            {
                nri.ItemEdit((int)dgvNotReturnableItems.SelectedRows[0].Cells["Id"].Value, tbName.Text);
                dgvNotReturnableItems.DataSource = nri.GetAllDataTable();
            }
        }

        private void dgvNotReturnableItems_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbName.Text = dgvNotReturnableItems.SelectedRows[0].Cells["Name"].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
