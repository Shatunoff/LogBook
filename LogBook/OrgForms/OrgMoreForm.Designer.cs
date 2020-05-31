namespace LogBook
{
    partial class OrgMoreForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnContractMore = new System.Windows.Forms.ToolStripButton();
            this.tsbtnContractNew = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMembership = new System.Windows.Forms.TextBox();
            this.checkIsPPE9 = new System.Windows.Forms.CheckBox();
            this.checkIsPPE11 = new System.Windows.Forms.CheckBox();
            this.tbShortName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLongName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAteName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAteCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOOCode = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvContracts);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Location = new System.Drawing.Point(12, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заключенные договоры";
            // 
            // dgvContracts
            // 
            this.dgvContracts.AllowUserToAddRows = false;
            this.dgvContracts.AllowUserToDeleteRows = false;
            this.dgvContracts.AllowUserToResizeRows = false;
            this.dgvContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContracts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContracts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContracts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContracts.Location = new System.Drawing.Point(3, 41);
            this.dgvContracts.MultiSelect = false;
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.RowHeadersVisible = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracts.Size = new System.Drawing.Size(700, 154);
            this.dgvContracts.TabIndex = 1;
            this.dgvContracts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContracts_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnContractMore,
            this.tsbtnContractNew});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnContractMore
            // 
            this.tsbtnContractMore.Image = global::LogBook.Properties.Resources.zoom;
            this.tsbtnContractMore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnContractMore.Name = "tsbtnContractMore";
            this.tsbtnContractMore.Size = new System.Drawing.Size(89, 22);
            this.tsbtnContractMore.Text = "Подробнее";
            this.tsbtnContractMore.Click += new System.EventHandler(this.tsbtnContractMore_Click);
            // 
            // tsbtnContractNew
            // 
            this.tsbtnContractNew.Image = global::LogBook.Properties.Resources.tool_new_file;
            this.tsbtnContractNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnContractNew.Name = "tsbtnContractNew";
            this.tsbtnContractNew.Size = new System.Drawing.Size(113, 22);
            this.tsbtnContractNew.Text = "Новый договор";
            this.tsbtnContractNew.Click += new System.EventHandler(this.tsbtnContractNew_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbMembership);
            this.groupBox2.Controls.Add(this.checkIsPPE9);
            this.groupBox2.Controls.Add(this.checkIsPPE11);
            this.groupBox2.Controls.Add(this.tbShortName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbLongName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbAteName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbAteCode);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbOOCode);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Основная информация";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Принадлежность:";
            // 
            // tbMembership
            // 
            this.tbMembership.BackColor = System.Drawing.SystemColors.Window;
            this.tbMembership.Location = new System.Drawing.Point(308, 45);
            this.tbMembership.Name = "tbMembership";
            this.tbMembership.ReadOnly = true;
            this.tbMembership.Size = new System.Drawing.Size(220, 20);
            this.tbMembership.TabIndex = 12;
            // 
            // checkIsPPE9
            // 
            this.checkIsPPE9.AutoSize = true;
            this.checkIsPPE9.Location = new System.Drawing.Point(534, 47);
            this.checkIsPPE9.Name = "checkIsPPE9";
            this.checkIsPPE9.Size = new System.Drawing.Size(157, 17);
            this.checkIsPPE9.TabIndex = 11;
            this.checkIsPPE9.Text = "Является ППЭ (9 классы)";
            this.checkIsPPE9.UseVisualStyleBackColor = true;
            this.checkIsPPE9.Click += new System.EventHandler(this.checkIsPPE11_Click);
            // 
            // checkIsPPE11
            // 
            this.checkIsPPE11.AutoSize = true;
            this.checkIsPPE11.Location = new System.Drawing.Point(534, 21);
            this.checkIsPPE11.Name = "checkIsPPE11";
            this.checkIsPPE11.Size = new System.Drawing.Size(163, 17);
            this.checkIsPPE11.TabIndex = 10;
            this.checkIsPPE11.Text = "Является ППЭ (11 классы)";
            this.checkIsPPE11.UseVisualStyleBackColor = true;
            this.checkIsPPE11.Click += new System.EventHandler(this.checkIsPPE11_Click);
            // 
            // tbShortName
            // 
            this.tbShortName.BackColor = System.Drawing.SystemColors.Window;
            this.tbShortName.Location = new System.Drawing.Point(362, 84);
            this.tbShortName.Multiline = true;
            this.tbShortName.Name = "tbShortName";
            this.tbShortName.ReadOnly = true;
            this.tbShortName.Size = new System.Drawing.Size(338, 40);
            this.tbShortName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Краткое наименование:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Полное наименование:";
            // 
            // tbLongName
            // 
            this.tbLongName.BackColor = System.Drawing.SystemColors.Window;
            this.tbLongName.Location = new System.Drawing.Point(6, 84);
            this.tbLongName.Multiline = true;
            this.tbLongName.Name = "tbLongName";
            this.tbLongName.ReadOnly = true;
            this.tbLongName.Size = new System.Drawing.Size(350, 40);
            this.tbLongName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Район, городской округ:";
            // 
            // tbAteName
            // 
            this.tbAteName.BackColor = System.Drawing.SystemColors.Window;
            this.tbAteName.Location = new System.Drawing.Point(308, 19);
            this.tbAteName.Name = "tbAteName";
            this.tbAteName.ReadOnly = true;
            this.tbAteName.Size = new System.Drawing.Size(220, 20);
            this.tbAteName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Код АТЕ:";
            // 
            // tbAteCode
            // 
            this.tbAteCode.BackColor = System.Drawing.SystemColors.Window;
            this.tbAteCode.Location = new System.Drawing.Point(65, 19);
            this.tbAteCode.Name = "tbAteCode";
            this.tbAteCode.ReadOnly = true;
            this.tbAteCode.Size = new System.Drawing.Size(100, 20);
            this.tbAteCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код ОО:";
            // 
            // tbOOCode
            // 
            this.tbOOCode.BackColor = System.Drawing.SystemColors.Window;
            this.tbOOCode.Location = new System.Drawing.Point(65, 45);
            this.tbOOCode.Name = "tbOOCode";
            this.tbOOCode.ReadOnly = true;
            this.tbOOCode.Size = new System.Drawing.Size(100, 20);
            this.tbOOCode.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(643, 494);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditInfo);
            this.groupBox3.Controls.Add(this.tbEmail);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbDirector);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbAdress);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbPhone);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(706, 133);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Контактная информация";
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Location = new System.Drawing.Point(534, 104);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(166, 23);
            this.btnEditInfo.TabIndex = 14;
            this.btnEditInfo.Text = "Редактировать информацию";
            this.btnEditInfo.UseVisualStyleBackColor = true;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbEmail.Location = new System.Drawing.Point(403, 19);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(297, 20);
            this.tbEmail.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(362, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Email:";
            // 
            // tbDirector
            // 
            this.tbDirector.BackColor = System.Drawing.SystemColors.Window;
            this.tbDirector.Location = new System.Drawing.Point(72, 19);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.ReadOnly = true;
            this.tbDirector.Size = new System.Drawing.Size(284, 20);
            this.tbDirector.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Директор:";
            // 
            // tbAdress
            // 
            this.tbAdress.BackColor = System.Drawing.SystemColors.Window;
            this.tbAdress.Location = new System.Drawing.Point(6, 58);
            this.tbAdress.Multiline = true;
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.ReadOnly = true;
            this.tbAdress.Size = new System.Drawing.Size(350, 40);
            this.tbAdress.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Адрес организации:";
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.SystemColors.Window;
            this.tbPhone.Location = new System.Drawing.Point(362, 58);
            this.tbPhone.Multiline = true;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(338, 40);
            this.tbPhone.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Телефон(ы):";
            // 
            // OrgMoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(730, 529);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrgMoreForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация об образовательной организации";
            this.Load += new System.EventHandler(this.OrgMoreForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnContractMore;
        private System.Windows.Forms.ToolStripButton tsbtnContractNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMembership;
        private System.Windows.Forms.CheckBox checkIsPPE9;
        private System.Windows.Forms.CheckBox checkIsPPE11;
        private System.Windows.Forms.TextBox tbShortName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLongName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAteName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAteCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOOCode;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.Button btnEditInfo;
    }
}