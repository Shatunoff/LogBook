namespace LogBook
{
    partial class ItemStatisticForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateOT = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDO = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.checkFilterAll = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvReturnableItems = new System.Windows.Forms.DataGridView();
            this.toolsReturnableItems = new System.Windows.Forms.ToolStrip();
            this.tsbtnExportReturnableItems = new System.Windows.Forms.ToolStripButton();
            this.toolsNotReturnableItems = new System.Windows.Forms.ToolStrip();
            this.tsbtnExportNotReturnableItems = new System.Windows.Forms.ToolStripButton();
            this.dgvNotReturnableItems = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnableItems)).BeginInit();
            this.toolsReturnableItems.SuspendLayout();
            this.toolsNotReturnableItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotReturnableItems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkFilterAll);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.dtpDateDO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDateOT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Диапазон дат";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "С:";
            // 
            // dtpDateOT
            // 
            this.dtpDateOT.Location = new System.Drawing.Point(29, 19);
            this.dtpDateOT.Name = "dtpDateOT";
            this.dtpDateOT.Size = new System.Drawing.Size(150, 20);
            this.dtpDateOT.TabIndex = 1;
            // 
            // dtpDateDO
            // 
            this.dtpDateDO.Location = new System.Drawing.Point(215, 19);
            this.dtpDateDO.Name = "dtpDateDO";
            this.dtpDateDO.Size = new System.Drawing.Size(150, 20);
            this.dtpDateDO.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "По:";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(371, 17);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Показать";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // checkFilterAll
            // 
            this.checkFilterAll.AutoSize = true;
            this.checkFilterAll.Location = new System.Drawing.Point(452, 21);
            this.checkFilterAll.Name = "checkFilterAll";
            this.checkFilterAll.Size = new System.Drawing.Size(137, 17);
            this.checkFilterAll.TabIndex = 5;
            this.checkFilterAll.Text = "Фильтр за все время";
            this.checkFilterAll.UseVisualStyleBackColor = true;
            this.checkFilterAll.CheckStateChanged += new System.EventHandler(this.checkFilterAll_CheckStateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvReturnableItems);
            this.groupBox2.Controls.Add(this.toolsReturnableItems);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 379);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Предметы, подлежащие возврату";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvNotReturnableItems);
            this.groupBox3.Controls.Add(this.toolsNotReturnableItems);
            this.groupBox3.Location = new System.Drawing.Point(338, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 379);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Предметы, подлежащие возврату";
            // 
            // dgvReturnableItems
            // 
            this.dgvReturnableItems.AllowUserToAddRows = false;
            this.dgvReturnableItems.AllowUserToDeleteRows = false;
            this.dgvReturnableItems.AllowUserToResizeColumns = false;
            this.dgvReturnableItems.AllowUserToResizeRows = false;
            this.dgvReturnableItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReturnableItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvReturnableItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnableItems.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvReturnableItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReturnableItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReturnableItems.Location = new System.Drawing.Point(3, 41);
            this.dgvReturnableItems.MultiSelect = false;
            this.dgvReturnableItems.Name = "dgvReturnableItems";
            this.dgvReturnableItems.RowHeadersVisible = false;
            this.dgvReturnableItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnableItems.Size = new System.Drawing.Size(314, 335);
            this.dgvReturnableItems.TabIndex = 0;
            // 
            // toolsReturnableItems
            // 
            this.toolsReturnableItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnExportReturnableItems});
            this.toolsReturnableItems.Location = new System.Drawing.Point(3, 16);
            this.toolsReturnableItems.Name = "toolsReturnableItems";
            this.toolsReturnableItems.Size = new System.Drawing.Size(314, 25);
            this.toolsReturnableItems.TabIndex = 1;
            this.toolsReturnableItems.Text = "toolStrip1";
            // 
            // tsbtnExportReturnableItems
            // 
            this.tsbtnExportReturnableItems.Image = global::LogBook.Properties.Resources.icon_xls;
            this.tsbtnExportReturnableItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExportReturnableItems.Name = "tsbtnExportReturnableItems";
            this.tsbtnExportReturnableItems.Size = new System.Drawing.Size(72, 22);
            this.tsbtnExportReturnableItems.Text = "Экспорт";
            this.tsbtnExportReturnableItems.Click += new System.EventHandler(this.tsbtnExportReturnableItems_Click);
            // 
            // toolsNotReturnableItems
            // 
            this.toolsNotReturnableItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnExportNotReturnableItems});
            this.toolsNotReturnableItems.Location = new System.Drawing.Point(3, 16);
            this.toolsNotReturnableItems.Name = "toolsNotReturnableItems";
            this.toolsNotReturnableItems.Size = new System.Drawing.Size(314, 25);
            this.toolsNotReturnableItems.TabIndex = 2;
            this.toolsNotReturnableItems.Text = "toolStrip2";
            // 
            // tsbtnExportNotReturnableItems
            // 
            this.tsbtnExportNotReturnableItems.Image = global::LogBook.Properties.Resources.icon_xls;
            this.tsbtnExportNotReturnableItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExportNotReturnableItems.Name = "tsbtnExportNotReturnableItems";
            this.tsbtnExportNotReturnableItems.Size = new System.Drawing.Size(72, 22);
            this.tsbtnExportNotReturnableItems.Text = "Экспорт";
            this.tsbtnExportNotReturnableItems.Click += new System.EventHandler(this.tsbtnExportNotReturnableItems_Click);
            // 
            // dgvNotReturnableItems
            // 
            this.dgvNotReturnableItems.AllowUserToAddRows = false;
            this.dgvNotReturnableItems.AllowUserToDeleteRows = false;
            this.dgvNotReturnableItems.AllowUserToResizeColumns = false;
            this.dgvNotReturnableItems.AllowUserToResizeRows = false;
            this.dgvNotReturnableItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNotReturnableItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNotReturnableItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotReturnableItems.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvNotReturnableItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotReturnableItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNotReturnableItems.Location = new System.Drawing.Point(3, 41);
            this.dgvNotReturnableItems.MultiSelect = false;
            this.dgvNotReturnableItems.Name = "dgvNotReturnableItems";
            this.dgvNotReturnableItems.RowHeadersVisible = false;
            this.dgvNotReturnableItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotReturnableItems.Size = new System.Drawing.Size(314, 335);
            this.dgvNotReturnableItems.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(583, 455);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ItemStatisticForm
            // 
            this.AcceptButton = this.btnFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(667, 490);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemStatisticForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Статистика по переданным предметам";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnableItems)).EndInit();
            this.toolsReturnableItems.ResumeLayout(false);
            this.toolsReturnableItems.PerformLayout();
            this.toolsNotReturnableItems.ResumeLayout(false);
            this.toolsNotReturnableItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotReturnableItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkFilterAll;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpDateDO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateOT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvReturnableItems;
        private System.Windows.Forms.ToolStrip toolsReturnableItems;
        private System.Windows.Forms.ToolStripButton tsbtnExportReturnableItems;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvNotReturnableItems;
        private System.Windows.Forms.ToolStrip toolsNotReturnableItems;
        private System.Windows.Forms.ToolStripButton tsbtnExportNotReturnableItems;
        private System.Windows.Forms.Button btnClose;
    }
}