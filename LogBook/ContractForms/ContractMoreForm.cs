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
    public partial class ContractMoreForm : Form
    {
        public int IdContract { get; private set; }
        public bool ContractOpened { get; private set; }
        public ContractMore contMore { get; private set; }

        public ContractMoreForm(int IdContract, bool ContractOpened = true)
        {
            InitializeComponent();
            this.IdContract = IdContract;
            this.ContractOpened = ContractOpened;
            
            FillForm();
        }

        public void FillForm()
        {
            contMore = new ContractMore(IdContract);
            // Информация о договоре
            tbContractCode.Text = contMore.thisContract.ContractCode;
            tbResponsible.Text = contMore.thisContract.Responsible;
            tbDateOfSigning.Text = contMore.thisContract.DateOfSigning.ToShortDateString();
            tbDateOfIssue.Text = contMore.thisContract.DateOfIssue.ToShortDateString();
            tbDateOfReturn.Text = contMore.thisContract.DateOfReturn.ToShortDateString();
            if (contMore.thisContract.ContractClosed)
            {
                tbContractStatus.Text = "ЗАКРЫТ";
                tbActualReturnDate.Text = contMore.thisContract.ActualReturnDate.ToShortDateString();
                btnContractEdit.Visible = false;
            }
            else tbContractStatus.Text = "ОТКРЫТ";

            // Контактная информация ОО
            tbOOCode.Text = contMore.thisContract.IdOO.ToString();
            tbOOAteName.Text = contMore.thisOrganization.ateName;
            tbOOShortName.Text = contMore.thisOrganization.ooShortName;
            tbOOLongName.Text = contMore.thisOrganization.ooLongName;
            tbOODirector.Text = contMore.thisOrganization.DirectorFIO;
            tbOOEmail.Text = contMore.thisOrganization.Email;
            tbOOPhone.Text = contMore.thisOrganization.Phone;
            tbOOAdress.Text = contMore.thisOrganization.Adress;
            tbHostOrganization.Text = contMore.thisContract.HostOrganization;

            // Выданные предметы
            dgvNotReturnableItemsInContract.DataSource = contMore.thisItems.NotReturnableItems;
            if (dgvNotReturnableItemsInContract.Columns.Count > 0)
            {
                dgvNotReturnableItemsInContract.Columns[0].Visible = false;
                dgvNotReturnableItemsInContract.Columns[1].Visible = false;
                dgvNotReturnableItemsInContract.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dgvReturnableItemsInContract.DataSource = contMore.thisItems.ReturnableItems;
            if (dgvReturnableItemsInContract.Columns.Count > 0)
            {
                dgvReturnableItemsInContract.Columns[0].Visible = false;
                dgvReturnableItemsInContract.Columns[1].Visible = false;
            }
        }

        private void btnOOMore_Click(object sender, EventArgs e)
        {
            OrgMoreForm orgMore = new OrgMoreForm(contMore.thisContract.IdOO);
            if (orgMore.ShowDialog() == DialogResult.OK)
                FillForm();
        }

        private void btnContractEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
