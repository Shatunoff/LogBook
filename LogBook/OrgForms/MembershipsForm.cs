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
    public partial class MembershipsForm : Form
    {
        Memberships mem = new Memberships();

        public MembershipsForm()
        {
            InitializeComponent();
            dgvMemberships.DataSource = mem.dataTable;
            dgvMemberships.Columns[0].Visible = false;
            btnClose.NotifyDefault(true);
            dgvMemberships.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 0) mem.Add(tbName.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMemberships.SelectedRows.Count > 0 && tbName.Text.Length > 0)
            {
                if (MessageBox.Show($"Вы уверены, что хотите изменить \"{dgvMemberships.SelectedRows[0].Cells["Name"].Value.ToString()}\" на \"{tbName.Text}\"?", "Изменение выбранной принадлежности", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    mem.Edit(dgvMemberships.SelectedRows[0].Index, tbName.Text);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvMemberships.SelectedRows.Count > 0 && tbName.Text.Length > 0)
            {
                if (MessageBox.Show($"Вы уверены, что хотите удалить ответственного \"{dgvMemberships.SelectedRows[0].Cells["Name"].Value.ToString()}\" из базы данных?\nВсе организации с участием данной принадлежности будут также удалены.", "Удаление выбранной принадлежности", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    mem.Remove(dgvMemberships.SelectedRows[0].Index);
                    tbName.Clear();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMemberships_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbName.Text = dgvMemberships.SelectedRows[0].Cells["Name"].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
