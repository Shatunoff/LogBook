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
    public partial class OrgAddEditForm : Form
    {
        OrgMore more;
        OrgAddEdit orgEdit = new OrgAddEdit();
        public int idOO = -1;
        // Режим добавления новой ОО
        public OrgAddEditForm()
        {
            InitializeComponent();
            this.Text = "Добавление новой организации";
            btnOk.Text = "Добавить";
        }

        // Режим редактирования информации об ОО
        public OrgAddEditForm(int idOO)
        {
            InitializeComponent();
            this.Text = $"{idOO} - Изменение организации";
            btnOk.Text = "Сохранить изменения";
            this.idOO = idOO;
            more = new OrgMore(idOO);
        }

        private void OrgAddEditForm_Load(object sender, EventArgs e)
        {
            comboAteName.DataSource = new BindingSource(orgEdit.ATEs, null);
            comboAteName.DisplayMember = "Value";
            comboAteName.ValueMember = "Key";

            comboMembership.DataSource = new BindingSource(orgEdit.Memberships, null);
            comboMembership.DisplayMember = "Value";
            comboMembership.ValueMember = "Key";

            if (idOO > 0) FillFormEditingOrg();
        }

        private void FillFormEditingOrg()
        {
            comboAteName.SelectedValue = OrgAddEdit.GetCurrentAte(idOO);
            comboMembership.SelectedValue = OrgAddEdit.GetCurrentMembership(idOO);
            tbOOCode.Text = more.Organization.ooCode.ToString();
            tbLongName.Text = more.Organization.ooLongName.ToString();
            tbShortName.Text = more.Organization.ooShortName.ToString();
            checkIsPPE9.Checked = more.Organization.isPPE9;
            checkIsPPE11.Checked = more.Organization.isPPE11;
            tbDirector.Text = more.Organization.DirectorFIO.ToString();
            tbEmail.Text = more.Organization.Email.ToString();
            tbPhone.Text = more.Organization.Phone.ToString();
            tbAdress.Text = more.Organization.Adress.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbOOCode.TextLength > 0 && tbLongName.TextLength > 0 && tbShortName.TextLength > 0 && tbDirector.TextLength > 0 &&
                    tbEmail.TextLength > 0 && tbPhone.TextLength > 0 && tbAdress.TextLength > 0 && comboAteName.Text.Length > 0 && comboMembership.Text.Length > 0)
                {
                    if (idOO < 0) AddOO();
                    else EditOO();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void AddOO()
        {
            int ooCode;
            
            if (int.TryParse(tbOOCode.Text, out ooCode))
            {
                OrgAddEdit.AddOO(ooCode, (int)comboAteName.SelectedValue, tbLongName.Text, tbShortName.Text, (int)comboMembership.SelectedValue, 
                    checkIsPPE9.Checked, checkIsPPE11.Checked, tbDirector.Text, tbPhone.Text, tbEmail.Text, tbAdress.Text);
            }
        }

        private void EditOO()
        {
            int ooCode;

            if (int.TryParse(tbOOCode.Text, out ooCode))
            {
                OrgAddEdit.EditOOContacts(idOO, tbDirector.Text, tbPhone.Text, tbEmail.Text, tbAdress.Text);
                OrgAddEdit.EditOO(idOO, ooCode, (int)comboAteName.SelectedValue, tbLongName.Text, tbShortName.Text, (int)comboMembership.SelectedValue,
                    checkIsPPE9.Checked, checkIsPPE11.Checked);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
