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
    public partial class AddNotReturnableInContractForm : Form
    {
        public int Count
        {
            get
            {
                return (int)nud.Value;
            }
            set
            {
                nud.Value = value;
            }
        }

        public AddNotReturnableInContractForm()
        {
            InitializeComponent();
        }

        private void AddNotReturnableInContractForm_Load(object sender, EventArgs e)
        {
            nud.Focus();
            nud.Select(0, nud.Value.ToString().Length);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
