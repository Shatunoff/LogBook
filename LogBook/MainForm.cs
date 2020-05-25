﻿using System;
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
        public MainForm()
        {
            InitializeComponent();
        }

        public void ConnectionRefresh()
        {

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
    }
}
