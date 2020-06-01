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
    public partial class ItemStatisticForm : Form
    {
        public ItemStatisticForm()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime dateOT, dateDO;
            if (dtpDateOT.Enabled && dtpDateDO.Enabled)
            {
                dateOT = dtpDateOT.Value;
                dateDO = dtpDateDO.Value;
            }
            else
            {
                dateOT = DateTime.Parse("1800-01-01");
                dateDO = DateTime.Parse("9800-01-01");
            }
            try
            {
                dgvReturnableItems.DataSource = ItemStatistic.ReturnableItemsStatistic(dateOT, dateDO);
                dgvReturnableItems.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvNotReturnableItems.DataSource = ItemStatistic.NotReturnableItemsStatistic(dateOT, dateDO);
                dgvNotReturnableItems.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnExportReturnableItems_Click(object sender, EventArgs e)
        {
            exportToCSV((DataTable)dgvReturnableItems.DataSource);
        }

        private void exportToCSV(DataTable dt)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV-Файлы |*.csv";
            save.Title = "Экспорт таблицы";
            if (save.ShowDialog() == DialogResult.OK)
                Export.ToCSV(dt, save.FileName);
        }

        private void tsbtnExportNotReturnableItems_Click(object sender, EventArgs e)
        {
            exportToCSV((DataTable)dgvNotReturnableItems.DataSource);
        }

        private void checkFilterAll_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkFilterAll.Checked)
            {
                dtpDateOT.Enabled = false;
                dtpDateDO.Enabled = false;
            }
            if (!checkFilterAll.Checked)
            {
                dtpDateOT.Enabled = true;
                dtpDateDO.Enabled = true;
            }
        }
    }
}
