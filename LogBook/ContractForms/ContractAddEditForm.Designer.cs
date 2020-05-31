namespace LogBook
{
    partial class ContractAddEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbOOName = new System.Windows.Forms.TextBox();
            this.btnSelectOO = new System.Windows.Forms.Button();
            this.tbIdOO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboResponsible = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbContractCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHostOrganization = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateOfSigning = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateOfReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOfIssue = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearchInNotReturnableItems = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSearchNotReturnableItems = new System.Windows.Forms.TextBox();
            this.dgvNotReturnableItems = new System.Windows.Forms.DataGridView();
            this.dgvNotReturnableItemsInContract = new System.Windows.Forms.DataGridView();
            this.btnEditCountNotReturnableItemInContract = new System.Windows.Forms.Button();
            this.btnAddNotReturnableItemInContract = new System.Windows.Forms.Button();
            this.btnRemoveNotReturnableItemInContract = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchInReturnableItems = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSearchReturnableItems = new System.Windows.Forms.TextBox();
            this.dgvReturnableItems = new System.Windows.Forms.DataGridView();
            this.dgvReturnableItemsInContract = new System.Windows.Forms.DataGridView();
            this.btnRemoveReturnableItemFromInContract = new System.Windows.Forms.Button();
            this.btnAddReturnableItemInContract = new System.Windows.Forms.Button();
            this.btnCloseContract = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotReturnableItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotReturnableItemsInContract)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnableItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnableItemsInContract)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbOOName);
            this.groupBox4.Controls.Add(this.btnSelectOO);
            this.groupBox4.Controls.Add(this.tbIdOO);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.comboResponsible);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tbContractCode);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tbHostOrganization);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dtpDateOfSigning);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.dtpDateOfReturn);
            this.groupBox4.Controls.Add(this.dtpDateOfIssue);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(704, 127);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Договор";
            // 
            // tbOOName
            // 
            this.tbOOName.BackColor = System.Drawing.SystemColors.Window;
            this.tbOOName.Location = new System.Drawing.Point(461, 19);
            this.tbOOName.Name = "tbOOName";
            this.tbOOName.ReadOnly = true;
            this.tbOOName.Size = new System.Drawing.Size(161, 20);
            this.tbOOName.TabIndex = 41;
            this.tbOOName.DoubleClick += new System.EventHandler(this.tbIdOO_DoubleClick);
            // 
            // btnSelectOO
            // 
            this.btnSelectOO.Location = new System.Drawing.Point(628, 17);
            this.btnSelectOO.Name = "btnSelectOO";
            this.btnSelectOO.Size = new System.Drawing.Size(70, 23);
            this.btnSelectOO.TabIndex = 5;
            this.btnSelectOO.Text = "Выбрать";
            this.btnSelectOO.UseVisualStyleBackColor = true;
            this.btnSelectOO.Click += new System.EventHandler(this.btnSelectOO_Click);
            // 
            // tbIdOO
            // 
            this.tbIdOO.BackColor = System.Drawing.SystemColors.Window;
            this.tbIdOO.Location = new System.Drawing.Point(405, 19);
            this.tbIdOO.Name = "tbIdOO";
            this.tbIdOO.ReadOnly = true;
            this.tbIdOO.Size = new System.Drawing.Size(50, 20);
            this.tbIdOO.TabIndex = 40;
            this.tbIdOO.DoubleClick += new System.EventHandler(this.tbIdOO_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Организация:";
            // 
            // comboResponsible
            // 
            this.comboResponsible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboResponsible.FormattingEnabled = true;
            this.comboResponsible.Location = new System.Drawing.Point(471, 97);
            this.comboResponsible.Name = "comboResponsible";
            this.comboResponsible.Size = new System.Drawing.Size(227, 21);
            this.comboResponsible.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ответственный за выдачу:";
            // 
            // tbContractCode
            // 
            this.tbContractCode.Location = new System.Drawing.Point(171, 19);
            this.tbContractCode.Name = "tbContractCode";
            this.tbContractCode.Size = new System.Drawing.Size(145, 20);
            this.tbContractCode.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "№ Договора:";
            // 
            // tbHostOrganization
            // 
            this.tbHostOrganization.Location = new System.Drawing.Point(322, 71);
            this.tbHostOrganization.Name = "tbHostOrganization";
            this.tbHostOrganization.Size = new System.Drawing.Size(376, 20);
            this.tbHostOrganization.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Принимающая организация, ФИО принимающего, должность:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата заключения договора:";
            // 
            // dtpDateOfSigning
            // 
            this.dtpDateOfSigning.Location = new System.Drawing.Point(171, 45);
            this.dtpDateOfSigning.Name = "dtpDateOfSigning";
            this.dtpDateOfSigning.Size = new System.Drawing.Size(145, 20);
            this.dtpDateOfSigning.TabIndex = 1;
            this.dtpDateOfSigning.Value = new System.DateTime(2020, 5, 29, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата выдачи оборудования:";
            // 
            // dtpDateOfReturn
            // 
            this.dtpDateOfReturn.Location = new System.Drawing.Point(171, 97);
            this.dtpDateOfReturn.Name = "dtpDateOfReturn";
            this.dtpDateOfReturn.Size = new System.Drawing.Size(145, 20);
            this.dtpDateOfReturn.TabIndex = 3;
            this.dtpDateOfReturn.Value = new System.DateTime(2020, 5, 29, 0, 0, 0, 0);
            // 
            // dtpDateOfIssue
            // 
            this.dtpDateOfIssue.Location = new System.Drawing.Point(171, 71);
            this.dtpDateOfIssue.Name = "dtpDateOfIssue";
            this.dtpDateOfIssue.Size = new System.Drawing.Size(145, 20);
            this.dtpDateOfIssue.TabIndex = 2;
            this.dtpDateOfIssue.Value = new System.DateTime(2020, 5, 29, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Срок возврата оборудования:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(586, 593);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(130, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 442);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выдача предметов";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearchInNotReturnableItems);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbSearchNotReturnableItems);
            this.groupBox3.Controls.Add(this.dgvNotReturnableItems);
            this.groupBox3.Controls.Add(this.dgvNotReturnableItemsInContract);
            this.groupBox3.Controls.Add(this.btnEditCountNotReturnableItemInContract);
            this.groupBox3.Controls.Add(this.btnAddNotReturnableItemInContract);
            this.groupBox3.Controls.Add(this.btnRemoveNotReturnableItemInContract);
            this.groupBox3.Location = new System.Drawing.Point(6, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(690, 205);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Передается на безвозвратное основе";
            // 
            // btnSearchInNotReturnableItems
            // 
            this.btnSearchInNotReturnableItems.Location = new System.Drawing.Point(647, 18);
            this.btnSearchInNotReturnableItems.Name = "btnSearchInNotReturnableItems";
            this.btnSearchInNotReturnableItems.Size = new System.Drawing.Size(35, 23);
            this.btnSearchInNotReturnableItems.TabIndex = 4;
            this.btnSearchInNotReturnableItems.Text = "ОК";
            this.btnSearchInNotReturnableItems.UseVisualStyleBackColor = true;
            this.btnSearchInNotReturnableItems.Click += new System.EventHandler(this.btnSearchInNotReturnableItems_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Поиск:";
            // 
            // tbSearchNotReturnableItems
            // 
            this.tbSearchNotReturnableItems.Location = new System.Drawing.Point(410, 20);
            this.tbSearchNotReturnableItems.Name = "tbSearchNotReturnableItems";
            this.tbSearchNotReturnableItems.Size = new System.Drawing.Size(231, 20);
            this.tbSearchNotReturnableItems.TabIndex = 3;
            this.tbSearchNotReturnableItems.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchNotReturnableItems_KeyUp);
            // 
            // dgvNotReturnableItems
            // 
            this.dgvNotReturnableItems.AllowUserToAddRows = false;
            this.dgvNotReturnableItems.AllowUserToDeleteRows = false;
            this.dgvNotReturnableItems.AllowUserToResizeColumns = false;
            this.dgvNotReturnableItems.AllowUserToResizeRows = false;
            this.dgvNotReturnableItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotReturnableItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNotReturnableItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNotReturnableItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotReturnableItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotReturnableItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNotReturnableItems.Location = new System.Drawing.Point(362, 46);
            this.dgvNotReturnableItems.MultiSelect = false;
            this.dgvNotReturnableItems.Name = "dgvNotReturnableItems";
            this.dgvNotReturnableItems.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotReturnableItems.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotReturnableItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotReturnableItems.Size = new System.Drawing.Size(320, 120);
            this.dgvNotReturnableItems.StandardTab = true;
            this.dgvNotReturnableItems.TabIndex = 5;
            this.dgvNotReturnableItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotReturnableItems_CellDoubleClick);
            // 
            // dgvNotReturnableItemsInContract
            // 
            this.dgvNotReturnableItemsInContract.AllowUserToAddRows = false;
            this.dgvNotReturnableItemsInContract.AllowUserToDeleteRows = false;
            this.dgvNotReturnableItemsInContract.AllowUserToResizeColumns = false;
            this.dgvNotReturnableItemsInContract.AllowUserToResizeRows = false;
            this.dgvNotReturnableItemsInContract.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNotReturnableItemsInContract.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNotReturnableItemsInContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotReturnableItemsInContract.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNotReturnableItemsInContract.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNotReturnableItemsInContract.Location = new System.Drawing.Point(6, 20);
            this.dgvNotReturnableItemsInContract.MultiSelect = false;
            this.dgvNotReturnableItemsInContract.Name = "dgvNotReturnableItemsInContract";
            this.dgvNotReturnableItemsInContract.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotReturnableItemsInContract.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNotReturnableItemsInContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotReturnableItemsInContract.Size = new System.Drawing.Size(350, 146);
            this.dgvNotReturnableItemsInContract.StandardTab = true;
            this.dgvNotReturnableItemsInContract.TabIndex = 0;
            this.dgvNotReturnableItemsInContract.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotReturnableItemsInContract_CellDoubleClick);
            // 
            // btnEditCountNotReturnableItemInContract
            // 
            this.btnEditCountNotReturnableItemInContract.Location = new System.Drawing.Point(6, 172);
            this.btnEditCountNotReturnableItemInContract.Name = "btnEditCountNotReturnableItemInContract";
            this.btnEditCountNotReturnableItemInContract.Size = new System.Drawing.Size(172, 23);
            this.btnEditCountNotReturnableItemInContract.TabIndex = 1;
            this.btnEditCountNotReturnableItemInContract.Text = "Изменить количество";
            this.btnEditCountNotReturnableItemInContract.UseVisualStyleBackColor = true;
            this.btnEditCountNotReturnableItemInContract.Click += new System.EventHandler(this.btnEditCountNotReturnableItemInContract_Click);
            // 
            // btnAddNotReturnableItemInContract
            // 
            this.btnAddNotReturnableItemInContract.Location = new System.Drawing.Point(362, 172);
            this.btnAddNotReturnableItemInContract.Name = "btnAddNotReturnableItemInContract";
            this.btnAddNotReturnableItemInContract.Size = new System.Drawing.Size(320, 23);
            this.btnAddNotReturnableItemInContract.TabIndex = 6;
            this.btnAddNotReturnableItemInContract.Text = "Добавить предмет в договор";
            this.btnAddNotReturnableItemInContract.UseVisualStyleBackColor = true;
            this.btnAddNotReturnableItemInContract.Click += new System.EventHandler(this.btnAddNotReturnableItemInContract_Click);
            // 
            // btnRemoveNotReturnableItemInContract
            // 
            this.btnRemoveNotReturnableItemInContract.Location = new System.Drawing.Point(184, 172);
            this.btnRemoveNotReturnableItemInContract.Name = "btnRemoveNotReturnableItemInContract";
            this.btnRemoveNotReturnableItemInContract.Size = new System.Drawing.Size(172, 23);
            this.btnRemoveNotReturnableItemInContract.TabIndex = 2;
            this.btnRemoveNotReturnableItemInContract.Text = "Удалить предмет";
            this.btnRemoveNotReturnableItemInContract.UseVisualStyleBackColor = true;
            this.btnRemoveNotReturnableItemInContract.Click += new System.EventHandler(this.btnRemoveNotReturnableItemInContract_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchInReturnableItems);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbSearchReturnableItems);
            this.groupBox2.Controls.Add(this.dgvReturnableItems);
            this.groupBox2.Controls.Add(this.dgvReturnableItemsInContract);
            this.groupBox2.Controls.Add(this.btnRemoveReturnableItemFromInContract);
            this.groupBox2.Controls.Add(this.btnAddReturnableItemInContract);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 205);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Передается на время действия договора";
            // 
            // btnSearchInReturnableItems
            // 
            this.btnSearchInReturnableItems.Location = new System.Drawing.Point(647, 17);
            this.btnSearchInReturnableItems.Name = "btnSearchInReturnableItems";
            this.btnSearchInReturnableItems.Size = new System.Drawing.Size(35, 23);
            this.btnSearchInReturnableItems.TabIndex = 3;
            this.btnSearchInReturnableItems.Text = "ОК";
            this.btnSearchInReturnableItems.UseVisualStyleBackColor = true;
            this.btnSearchInReturnableItems.Click += new System.EventHandler(this.btnSearchInReturnableItems_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Поиск:";
            // 
            // tbSearchReturnableItems
            // 
            this.tbSearchReturnableItems.Location = new System.Drawing.Point(410, 19);
            this.tbSearchReturnableItems.Name = "tbSearchReturnableItems";
            this.tbSearchReturnableItems.Size = new System.Drawing.Size(231, 20);
            this.tbSearchReturnableItems.TabIndex = 2;
            this.tbSearchReturnableItems.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchReturnableItems_KeyUp);
            // 
            // dgvReturnableItems
            // 
            this.dgvReturnableItems.AllowUserToAddRows = false;
            this.dgvReturnableItems.AllowUserToDeleteRows = false;
            this.dgvReturnableItems.AllowUserToResizeColumns = false;
            this.dgvReturnableItems.AllowUserToResizeRows = false;
            this.dgvReturnableItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnableItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReturnableItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvReturnableItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnableItems.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReturnableItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReturnableItems.Location = new System.Drawing.Point(362, 45);
            this.dgvReturnableItems.MultiSelect = false;
            this.dgvReturnableItems.Name = "dgvReturnableItems";
            this.dgvReturnableItems.RowHeadersVisible = false;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnableItems.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReturnableItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnableItems.Size = new System.Drawing.Size(320, 121);
            this.dgvReturnableItems.StandardTab = true;
            this.dgvReturnableItems.TabIndex = 4;
            this.dgvReturnableItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturnableItems_CellDoubleClick);
            // 
            // dgvReturnableItemsInContract
            // 
            this.dgvReturnableItemsInContract.AllowUserToAddRows = false;
            this.dgvReturnableItemsInContract.AllowUserToDeleteRows = false;
            this.dgvReturnableItemsInContract.AllowUserToResizeColumns = false;
            this.dgvReturnableItemsInContract.AllowUserToResizeRows = false;
            this.dgvReturnableItemsInContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnableItemsInContract.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReturnableItemsInContract.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvReturnableItemsInContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnableItemsInContract.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReturnableItemsInContract.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReturnableItemsInContract.Location = new System.Drawing.Point(6, 19);
            this.dgvReturnableItemsInContract.MultiSelect = false;
            this.dgvReturnableItemsInContract.Name = "dgvReturnableItemsInContract";
            this.dgvReturnableItemsInContract.RowHeadersVisible = false;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnableItemsInContract.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReturnableItemsInContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnableItemsInContract.Size = new System.Drawing.Size(350, 147);
            this.dgvReturnableItemsInContract.StandardTab = true;
            this.dgvReturnableItemsInContract.TabIndex = 0;
            // 
            // btnRemoveReturnableItemFromInContract
            // 
            this.btnRemoveReturnableItemFromInContract.Location = new System.Drawing.Point(6, 172);
            this.btnRemoveReturnableItemFromInContract.Name = "btnRemoveReturnableItemFromInContract";
            this.btnRemoveReturnableItemFromInContract.Size = new System.Drawing.Size(350, 23);
            this.btnRemoveReturnableItemFromInContract.TabIndex = 1;
            this.btnRemoveReturnableItemFromInContract.Text = "Удалить предмет";
            this.btnRemoveReturnableItemFromInContract.UseVisualStyleBackColor = true;
            this.btnRemoveReturnableItemFromInContract.Click += new System.EventHandler(this.btnRemoveReturnableItemFromInContract_Click);
            // 
            // btnAddReturnableItemInContract
            // 
            this.btnAddReturnableItemInContract.Location = new System.Drawing.Point(362, 172);
            this.btnAddReturnableItemInContract.Name = "btnAddReturnableItemInContract";
            this.btnAddReturnableItemInContract.Size = new System.Drawing.Size(320, 23);
            this.btnAddReturnableItemInContract.TabIndex = 5;
            this.btnAddReturnableItemInContract.Text = "Добавить предмет в договор";
            this.btnAddReturnableItemInContract.UseVisualStyleBackColor = true;
            this.btnAddReturnableItemInContract.Click += new System.EventHandler(this.btnAddReturnableItemInContract_Click);
            // 
            // btnCloseContract
            // 
            this.btnCloseContract.Location = new System.Drawing.Point(450, 593);
            this.btnCloseContract.Name = "btnCloseContract";
            this.btnCloseContract.Size = new System.Drawing.Size(130, 23);
            this.btnCloseContract.TabIndex = 3;
            this.btnCloseContract.Text = "Закрыть договор";
            this.btnCloseContract.UseVisualStyleBackColor = true;
            this.btnCloseContract.Click += new System.EventHandler(this.btnCloseContract_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(12, 593);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ContractAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(728, 628);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCloseContract);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContractAddEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ContractAddEditForm";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotReturnableItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotReturnableItemsInContract)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnableItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnableItemsInContract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSelectOO;
        private System.Windows.Forms.TextBox tbIdOO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboResponsible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbContractCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHostOrganization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateOfSigning;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateOfReturn;
        private System.Windows.Forms.DateTimePicker dtpDateOfIssue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEditCountNotReturnableItemInContract;
        private System.Windows.Forms.Button btnAddNotReturnableItemInContract;
        private System.Windows.Forms.Button btnRemoveNotReturnableItemInContract;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveReturnableItemFromInContract;
        private System.Windows.Forms.Button btnAddReturnableItemInContract;
        private System.Windows.Forms.DataGridView dgvReturnableItems;
        private System.Windows.Forms.DataGridView dgvReturnableItemsInContract;
        private System.Windows.Forms.DataGridView dgvNotReturnableItems;
        private System.Windows.Forms.DataGridView dgvNotReturnableItemsInContract;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSearchNotReturnableItems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSearchReturnableItems;
        private System.Windows.Forms.Button btnCloseContract;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearchInNotReturnableItems;
        private System.Windows.Forms.Button btnSearchInReturnableItems;
        private System.Windows.Forms.TextBox tbOOName;
    }
}