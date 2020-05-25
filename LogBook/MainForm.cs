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
    public partial class MainForm : Form
    {
        Contracts dbContracts = new Contracts();

        public MainForm()
        {
            InitializeComponent();
        }

        public void ConnectionRefresh()
        {
            dgvContractsOpenedAll.DataSource = dbContracts.GetOpenedAllDataTable();
            dgvContractsOpenedProsrok.DataSource = dbContracts.GetOpenedProsrokDataTable();
            dgvContractsClosed.DataSource = dbContracts.GetClosedAllDataTable();
        }

        private void mmBaseSettings_Click(object sender, EventArgs e)
        {
            DBConnectionSettingForm conSettings = new DBConnectionSettingForm();
            conSettings.ShowDialog();
        }

        private void mmBaseExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mmBaseConnect_Click(object sender, EventArgs e)
        {
            ConnectionRefresh();
        }

        private void mmContractsNotReturnableItems_Click(object sender, EventArgs e)
        {
            NotReturnableItemsForm nri = new NotReturnableItemsForm();
            nri.ShowDialog();
        }
    }
}
