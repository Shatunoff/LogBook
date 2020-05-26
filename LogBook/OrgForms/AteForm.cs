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
    public partial class AteForm : Form
    {
        Ate ate = new Ate();
        public AteForm()
        {
            InitializeComponent();
            dgvAte.DataSource = ate.dataTable;
            dgvAte.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            btnClose.NotifyDefault(true);
            tbAteCode.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbAteCode.Text.Length > 0 && tbAteName.Text.Length > 0)
            {
                int ateCode;
                bool flag = int.TryParse(tbAteCode.Text, out ateCode);
                if (flag)
                {
                    ate.Add(ateCode, tbAteName.Text);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAte.SelectedRows.Count > 0 && tbAteCode.Text.Length > 0 && tbAteName.Text.Length > 0)
            {
                int ateCode;
                bool flag = int.TryParse(tbAteCode.Text, out ateCode);
                if (flag)
                {
                    if (MessageBox.Show($"Вы уверены, что хотите изменить \"{dgvAte.SelectedRows[0].Cells["Name"].Value.ToString()} ({dgvAte.SelectedRows[0].Cells["Id"].Value.ToString()})\" на \"{tbAteName.Text} ({tbAteCode.Text})\"?", "Изменение выбранного АТЕ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        ate.Edit(dgvAte.SelectedRows[0].Index, ateCode, tbAteName.Text);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvAte.SelectedRows.Count > 0)
            {
                if (MessageBox.Show($"Вы уверены, что хотите удалить ответственного \"{dgvAte.SelectedRows[0].Cells["Name"].Value.ToString()}\" из базы данных?\nВсе организации с участием данного АТЕ будут также удалены.", "Удаление выбранного АТЕ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ate.Remove(dgvAte.SelectedRows[0].Index);
                    tbAteName.Clear();
                    tbAteCode.Clear();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAte_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbAteCode.Text = dgvAte.SelectedRows[0].Cells["Id"].Value.ToString();
                tbAteName.Text = dgvAte.SelectedRows[0].Cells["Name"].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
