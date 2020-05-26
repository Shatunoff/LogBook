namespace LogBook
{
    partial class NotReturnableItemsForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.btnItemEdit = new System.Windows.Forms.Button();
            this.dgvNotReturnableItems = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnItemRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotReturnableItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(102, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(177, 20);
            this.tbName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя предмета:";
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Location = new System.Drawing.Point(12, 38);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(130, 23);
            this.btnItemAdd.TabIndex = 5;
            this.btnItemAdd.Text = "Добавить предмет";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // btnItemEdit
            // 
            this.btnItemEdit.Location = new System.Drawing.Point(149, 38);
            this.btnItemEdit.Name = "btnItemEdit";
            this.btnItemEdit.Size = new System.Drawing.Size(130, 23);
            this.btnItemEdit.TabIndex = 6;
            this.btnItemEdit.Text = "Изменить выбранный";
            this.btnItemEdit.UseVisualStyleBackColor = true;
            this.btnItemEdit.Click += new System.EventHandler(this.btnItemEdit_Click);
            // 
            // dgvNotReturnableItems
            // 
            this.dgvNotReturnableItems.AllowUserToAddRows = false;
            this.dgvNotReturnableItems.AllowUserToDeleteRows = false;
            this.dgvNotReturnableItems.AllowUserToOrderColumns = true;
            this.dgvNotReturnableItems.AllowUserToResizeColumns = false;
            this.dgvNotReturnableItems.AllowUserToResizeRows = false;
            this.dgvNotReturnableItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotReturnableItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvNotReturnableItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNotReturnableItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotReturnableItems.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotReturnableItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotReturnableItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNotReturnableItems.Location = new System.Drawing.Point(12, 67);
            this.dgvNotReturnableItems.MultiSelect = false;
            this.dgvNotReturnableItems.Name = "dgvNotReturnableItems";
            this.dgvNotReturnableItems.RowHeadersVisible = false;
            this.dgvNotReturnableItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotReturnableItems.Size = new System.Drawing.Size(267, 154);
            this.dgvNotReturnableItems.TabIndex = 7;
            this.dgvNotReturnableItems.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNotReturnableItems_CellMouseClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(179, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnItemRemove
            // 
            this.btnItemRemove.Location = new System.Drawing.Point(12, 227);
            this.btnItemRemove.Name = "btnItemRemove";
            this.btnItemRemove.Size = new System.Drawing.Size(130, 23);
            this.btnItemRemove.TabIndex = 9;
            this.btnItemRemove.Text = "Удалить выбранный";
            this.btnItemRemove.UseVisualStyleBackColor = true;
            this.btnItemRemove.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // NotReturnableItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 262);
            this.Controls.Add(this.btnItemRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvNotReturnableItems);
            this.Controls.Add(this.btnItemEdit);
            this.Controls.Add(this.btnItemAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotReturnableItemsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Невозвращаемые предметы";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotReturnableItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Button btnItemEdit;
        private System.Windows.Forms.DataGridView dgvNotReturnableItems;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnItemRemove;
    }
}