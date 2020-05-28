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
    public partial class OrgMoreForm : Form
    {
        OrgMore orgMore;

        public OrgMoreForm(int idOO)
        {
            InitializeComponent();
            orgMore = new OrgMore(idOO);
        }

        private void OrgMoreForm_Load(object sender, EventArgs e)
        {
            tbAteCode.Text = orgMore.Organization.ateCode.ToString();
            tbAteName.Text = orgMore.Organization.ateName;
            tbOOCode.Text = orgMore.Organization.ooCode.ToString();
            tbMembership.Text = orgMore.Organization.ooMembership;
            checkIsPPE9.Checked = orgMore.Organization.isPPE9;
            checkIsPPE11.Checked = orgMore.Organization.isPPE11;
            tbLongName.Text = orgMore.Organization.ooLongName.ToString();
            tbShortName.Text = orgMore.Organization.ooShortName.ToString();
            tbDirector.Text = orgMore.Organization.DirectorFIO.ToString();
            tbEmail.Text = orgMore.Organization.Email.ToString();
            tbPhone.Text = orgMore.Organization.Phone.ToString();
            tbAdress.Text = orgMore.Organization.Adress.ToString();

            this.Text = orgMore.Organization.ooShortName + " — " + this.Text;

            dgvContracts.DataSource = orgMore.ContractsOfOrganization;
            if(dgvContracts.Columns.Count > 0) dgvContracts.Columns[0].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkIsPPE11_Click(object sender, EventArgs e)
        {
            if (sender is CheckBox)
                ((CheckBox)sender).Checked = !((CheckBox)sender).Checked;
        }
    }
}
