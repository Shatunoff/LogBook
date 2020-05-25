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
    public partial class DBConnectionSettingForm : Form
    {
        public DBConnectionSettingForm()
        {
            InitializeComponent();
            tbServerName.Text = Properties.Settings.Default.dbServerName;
            tbDBName.Text = Properties.Settings.Default.dbInitialCatalog;
            comboCheckUser.SelectedIndex = Properties.Settings.Default.dbCheckMode;
            if (Properties.Settings.Default.dbCheckMode > 0)
            {
                tbLogin.Text = Properties.Settings.Default.dbLogin;
                tbPassword.Text = Properties.Settings.Default.dbPassword;
            }
            btnSave.NotifyDefault(true);
            tbServerName.Focus();
        }

        // Кнопка сохранения настроек подключения
        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.dbServerName = tbServerName.Text;
            Properties.Settings.Default.dbInitialCatalog = tbDBName.Text;
            Properties.Settings.Default.dbCheckMode = comboCheckUser.SelectedIndex;
            if (comboCheckUser.SelectedIndex > 0)
            {
                Properties.Settings.Default.dbLogin = tbLogin.Text;
                Properties.Settings.Default.dbPassword = tbPassword.Text;
                Properties.Settings.Default.dbConnectionString = $"Data Source = {tbServerName.Text}; Initial Catalog = {tbDBName.Text}; Persist Security Info = True; User ID ={tbLogin.Text}; Password ={tbPassword.Text}";
            }
            else
            {
                Properties.Settings.Default.dbLogin = String.Empty;
                Properties.Settings.Default.dbPassword = String.Empty;
                Properties.Settings.Default.dbConnectionString = $"Data Source = {tbServerName.Text}; Initial Catalog = {tbDBName.Text}; Integrated Security = True";
            }

            Properties.Settings.Default.Save();
            this.Close();
        }

        // Поведение при изменении типа проверки подлинности
        private void comboCheckUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCheckUser.SelectedIndex > 0)
                tbLogin.Enabled = tbPassword.Enabled = true;
            else
                tbLogin.Enabled = tbPassword.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
