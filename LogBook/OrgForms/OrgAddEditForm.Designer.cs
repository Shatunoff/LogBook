namespace LogBook
{
    partial class OrgAddEditForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbOOCode = new System.Windows.Forms.TextBox();
            this.comboAteName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMembership = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkIsPPE11 = new System.Windows.Forms.CheckBox();
            this.checkIsPPE9 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbShortName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLongName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(12, 345);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(301, 345);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Сохранить изменения";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbOOCode
            // 
            this.tbOOCode.Location = new System.Drawing.Point(331, 32);
            this.tbOOCode.Name = "tbOOCode";
            this.tbOOCode.Size = new System.Drawing.Size(100, 20);
            this.tbOOCode.TabIndex = 2;
            // 
            // comboAteName
            // 
            this.comboAteName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAteName.FormattingEnabled = true;
            this.comboAteName.Location = new System.Drawing.Point(9, 32);
            this.comboAteName.Name = "comboAteName";
            this.comboAteName.Size = new System.Drawing.Size(190, 21);
            this.comboAteName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Район, городской округ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Принадлежность:";
            // 
            // comboMembership
            // 
            this.comboMembership.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMembership.FormattingEnabled = true;
            this.comboMembership.Location = new System.Drawing.Point(205, 32);
            this.comboMembership.Name = "comboMembership";
            this.comboMembership.Size = new System.Drawing.Size(120, 21);
            this.comboMembership.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Код ОО:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkIsPPE11);
            this.groupBox1.Controls.Add(this.checkIsPPE9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbShortName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbLongName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboAteName);
            this.groupBox1.Controls.Add(this.tbOOCode);
            this.groupBox1.Controls.Add(this.comboMembership);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 183);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основная информация";
            // 
            // checkIsPPE11
            // 
            this.checkIsPPE11.AutoSize = true;
            this.checkIsPPE11.Location = new System.Drawing.Point(205, 157);
            this.checkIsPPE11.Name = "checkIsPPE11";
            this.checkIsPPE11.Size = new System.Drawing.Size(163, 17);
            this.checkIsPPE11.TabIndex = 13;
            this.checkIsPPE11.Text = "Является ППЭ (11 классы)";
            this.checkIsPPE11.UseVisualStyleBackColor = true;
            // 
            // checkIsPPE9
            // 
            this.checkIsPPE9.AutoSize = true;
            this.checkIsPPE9.Location = new System.Drawing.Point(9, 157);
            this.checkIsPPE9.Name = "checkIsPPE9";
            this.checkIsPPE9.Size = new System.Drawing.Size(157, 17);
            this.checkIsPPE9.TabIndex = 12;
            this.checkIsPPE9.Text = "Является ППЭ (9 классы)";
            this.checkIsPPE9.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Краткое наименование организации:";
            // 
            // tbShortName
            // 
            this.tbShortName.Location = new System.Drawing.Point(9, 131);
            this.tbShortName.Name = "tbShortName";
            this.tbShortName.Size = new System.Drawing.Size(422, 20);
            this.tbShortName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Полное наименование организации:";
            // 
            // tbLongName
            // 
            this.tbLongName.Location = new System.Drawing.Point(9, 72);
            this.tbLongName.Multiline = true;
            this.tbLongName.Name = "tbLongName";
            this.tbLongName.Size = new System.Drawing.Size(422, 40);
            this.tbLongName.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbAdress);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbPhone);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbDirector);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 138);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Контактная информация";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(224, 32);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(209, 20);
            this.tbEmail.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Адрес организации:";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(9, 110);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(422, 20);
            this.tbAdress.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Телефон(ы):";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(9, 71);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(422, 20);
            this.tbPhone.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Директор (ФИО):";
            // 
            // tbDirector
            // 
            this.tbDirector.Location = new System.Drawing.Point(9, 32);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(209, 20);
            this.tbDirector.TabIndex = 8;
            // 
            // OrgAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(463, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrgAddEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrgAddEditForm";
            this.Load += new System.EventHandler(this.OrgAddEditForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox comboAteName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMembership;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkIsPPE11;
        private System.Windows.Forms.CheckBox checkIsPPE9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbShortName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLongName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDirector;
        public System.Windows.Forms.TextBox tbOOCode;
    }
}