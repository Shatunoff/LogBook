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
    public partial class ResponsiblesForm : Form
    {
        Responsibles resp = new Responsibles();
        public ResponsiblesForm()
        {
            InitializeComponent();
            dgvResponsibles.DataSource = resp.dataTable;
            dgvResponsibles.Columns[0].Visible = false;
            btnClose.NotifyDefault(true);
            dgvResponsibles.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 0) resp.Add(tbName.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvResponsibles.SelectedRows.Count > 0 && tbName.Text.Length > 0)
            {
                if (MessageBox.Show($"Вы уверены, что хотите изменить \"{dgvResponsibles.SelectedRows[0].Cells["Name"].Value.ToString()}\" на \"{tbName.Text}\"?", "Изменение выбранного ответственного", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    resp.Edit(dgvResponsibles.SelectedRows[0].Index, tbName.Text);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvResponsibles.SelectedRows.Count > 0 && tbName.Text.Length > 0)
            {
                if (MessageBox.Show($"Вы уверены, что хотите удалить ответственного \"{dgvResponsibles.SelectedRows[0].Cells["Name"].Value.ToString()}\" из базы данных?\nВсе договоры с участием данного ответственного будут также удалены.", "Удаление выбранного ответственного", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    resp.Remove(dgvResponsibles.SelectedRows[0].Index);
                    tbName.Clear();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvResponsibles_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbName.Text = dgvResponsibles.SelectedRows[0].Cells["Name"].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
