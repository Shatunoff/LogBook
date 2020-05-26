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
            btnClose.NotifyDefault(true);
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 0)
            {
                nri.ItemAdd(tbName.Text);
                dgvNotReturnableItems.DataSource = nri.GetAllDataTable();
            }
        }

        private void btnItemEdit_Click(object sender, EventArgs e)
        {
            if (dgvNotReturnableItems.SelectedRows.Count > 0 && tbName.Text.Length > 0)
            {
                if (MessageBox.Show($"Вы уверены, что хотите изменить \"{dgvNotReturnableItems.SelectedRows[0].Cells["Name"].Value.ToString()}\" на \"{tbName.Text}\"?", "Изменение выбранного предмета", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    nri.ItemEdit((int)dgvNotReturnableItems.SelectedRows[0].Cells["Id"].Value, tbName.Text);
                    dgvNotReturnableItems.DataSource = nri.GetAllDataTable();
                }
            }
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            if (dgvNotReturnableItems.SelectedRows.Count > 0 && tbName.Text.Length > 0)
            {
                if (MessageBox.Show($"Вы уверены, что хотите удалить предмет \"{dgvNotReturnableItems.SelectedRows[0].Cells["Name"].Value.ToString()}\" из базы данных?\nПредмет будет удален в том числе из всех договоров.", "Удаление выбранного предмета", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    nri.ItemRemove((int)dgvNotReturnableItems.SelectedRows[0].Cells["Id"].Value);
                    dgvNotReturnableItems.DataSource = nri.GetAllDataTable();
                    tbName.Clear();
                }
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
