using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LogBook
{
    public partial class ReturnableItemsForm : Form
    {
        ReturnableItems ri = new ReturnableItems();

        public ReturnableItemsForm()
        {
            InitializeComponent();
            dgvReturnableItems.DataSource = ri.dataTable;
            dgvReturnableItems.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReturnableItems.Columns[0].Visible = false;
            btnClose.NotifyDefault(true);
            dgvReturnableItems.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbItemName.Text.Length > 0 && tbInventoryNumber.Text.Length > 0)
            {
                ri.ItemAdd(tbItemName.Text, tbInventoryNumber.Text);
                dgvReturnableItems.Rows[dgvReturnableItems.Rows.Count - 1].Selected = true;
                dgvReturnableItems.FirstDisplayedScrollingRowIndex = dgvReturnableItems.SelectedRows[0].Index;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReturnableItems.SelectedRows.Count > 0 && tbItemName.Text.Length > 0 && tbInventoryNumber.Text.Length > 0)
            {
                if (MessageBox.Show($"Вы уверены, что хотите изменить \"{dgvReturnableItems.SelectedRows[0].Cells["ItemName"].Value.ToString()} ({dgvReturnableItems.SelectedRows[0].Cells["InventoryNumber"].Value.ToString()})\" на \"{tbItemName.Text} ({tbInventoryNumber.Text})\"?", "Изменение выбранного предмета", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ri.ItemEdit(dgvReturnableItems.SelectedRows[0].Index, tbItemName.Text, tbInventoryNumber.Text);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvReturnableItems.SelectedRows.Count > 0 && tbItemName.Text.Length > 0 && tbInventoryNumber.Text.Length > 0)
            {
                if (MessageBox.Show($"Вы уверены, что хотите удалить предмет \"{dgvReturnableItems.SelectedRows[0].Cells["ItemName"].Value.ToString()} ({dgvReturnableItems.SelectedRows[0].Cells["InventoryNumber"].Value.ToString()})\" из базы данных?\nПредмет будет удален в том числе из всех договоров.", "Удаление выбранного предмета", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ri.ItemRemove(dgvReturnableItems.SelectedRows[0].Index);
                    tbItemName.Clear();
                    tbInventoryNumber.Clear();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выбрать CSV файл для импорта";
            ofd.Filter = "Файлы с разделителями (CSV) |*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = ofd.FileName;
                OpenFile();
            }
        }

        private void OpenFile()
        {
            char sep = ';';
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(tbFilePath.Text, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs, Encoding.Default);

                DataTable dt = new DataTable();
                dt.Columns.Add("ItemName", typeof(string));
                dt.Columns.Add("InventoryNumber", typeof(string));

                string[] line;
                while (!sr.EndOfStream)
                {
                    DataRow dr = dt.NewRow();
                    line = sr.ReadLine().Split(sep);
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        dr[i] = line[i];
                    }
                    dt.Rows.Add(dr);
                }
                dgvPreview.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sr?.Close();
                fs?.Close();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ItemName", typeof(string));
            dt.Columns.Add("InventoryNumber", typeof(string));

            if (dgvPreview.Rows.Count > 0)
            {
                for (int i = 0; i < dgvPreview.Rows.Count; i ++)
                {
                    string invNum = dgvPreview.Rows[i].Cells["InventoryNumber"].Value.ToString();
                    bool flag = true;
                    for (int j = 0; j < ri.dataTable.Rows.Count; j++)
                    {
                        if (ri.dataTable.Rows[j]["InventoryNumber"].ToString() == invNum) flag = false;
                    }
                    if (flag)
                    {
                        dt.Rows.Add(dgvPreview.Rows[i].Cells["ItemName"].Value.ToString(), dgvPreview.Rows[i].Cells["InventoryNumber"].Value.ToString());
                    }
                }
                ri.Import(dt);
                ri = new ReturnableItems();
                dgvReturnableItems.DataSource = ri.dataTable;
                MessageBox.Show("Импорт завершен!");
            }
        }

        private void dgvReturnableItems_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbItemName.Text = dgvReturnableItems.SelectedRows[0].Cells["ItemName"].Value.ToString();
                tbInventoryNumber.Text = dgvReturnableItems.SelectedRows[0].Cells["InventoryNumber"].Value.ToString();
            }
            catch
            {

            }
        }

        private void tbFilePath_Click(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }
    }
}
