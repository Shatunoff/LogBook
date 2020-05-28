namespace LogBook
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mmBase = new System.Windows.Forms.ToolStripMenuItem();
            this.mmBaseConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mmBaseSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mmBaseExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmContracts = new System.Windows.Forms.ToolStripMenuItem();
            this.mmContractsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mmContractsReturnableItems = new System.Windows.Forms.ToolStripMenuItem();
            this.mmContractsNotReturnableItems = new System.Windows.Forms.ToolStripMenuItem();
            this.mmContractsResponsibles = new System.Windows.Forms.ToolStripMenuItem();
            this.mmOrg = new System.Windows.Forms.ToolStripMenuItem();
            this.mmOrgNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mmOrgATE = new System.Windows.Forms.ToolStripMenuItem();
            this.mmOrgMemberships = new System.Windows.Forms.ToolStripMenuItem();
            this.tctrlMain = new System.Windows.Forms.TabControl();
            this.tpMainContracts = new System.Windows.Forms.TabPage();
            this.tctrlMainContracts = new System.Windows.Forms.TabControl();
            this.tpMainContractsOpenedAll = new System.Windows.Forms.TabPage();
            this.dgvContractsOpenedAll = new System.Windows.Forms.DataGridView();
            this.tpMainContractsOpenedProsrok = new System.Windows.Forms.TabPage();
            this.dgvContractsOpenedProsrok = new System.Windows.Forms.DataGridView();
            this.tpMainContractsClosed = new System.Windows.Forms.TabPage();
            this.dgvContractsClosed = new System.Windows.Forms.DataGridView();
            this.panelContractsForFilter = new System.Windows.Forms.Panel();
            this.gbContractsFilter = new System.Windows.Forms.GroupBox();
            this.btnContractsFilterReset = new System.Windows.Forms.Button();
            this.btnContractsFilterApply = new System.Windows.Forms.Button();
            this.checkContractsFilterDateOfReturn = new System.Windows.Forms.CheckBox();
            this.dtpContractsFilterReturnDO = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpContractsFilterReturnOT = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.checkContractsFilterDateOfIssue = new System.Windows.Forms.CheckBox();
            this.dtpContractsFilterIssueDO = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpContractsFilterIssueOT = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.checkContractsFilterDateOfSigning = new System.Windows.Forms.CheckBox();
            this.dtpContractsFilterSingingDO = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboContractsFilterResponsible = new System.Windows.Forms.ComboBox();
            this.dtpContractsFilterSingingOT = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbContractsFilterNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbContractsFilterCodeOO = new System.Windows.Forms.TextBox();
            this.tpMainOrg = new System.Windows.Forms.TabPage();
            this.dgvOrg = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkOrgFilterHasOpenedProsrokContracts = new System.Windows.Forms.CheckBox();
            this.comboOrgFilterMemberships = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOrgFilterReset = new System.Windows.Forms.Button();
            this.btnOrgFilterApply = new System.Windows.Forms.Button();
            this.checkOrgFilterIsPPE11 = new System.Windows.Forms.CheckBox();
            this.checkOrgFilterIsPPE9 = new System.Windows.Forms.CheckBox();
            this.checkOrgFilterHasOpenedContracts = new System.Windows.Forms.CheckBox();
            this.comboOrgFilterATE = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbOrgFilterOOName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbOrgFilterOOCode = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOrgView = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.tctrlMain.SuspendLayout();
            this.tpMainContracts.SuspendLayout();
            this.tctrlMainContracts.SuspendLayout();
            this.tpMainContractsOpenedAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsOpenedAll)).BeginInit();
            this.tpMainContractsOpenedProsrok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsOpenedProsrok)).BeginInit();
            this.tpMainContractsClosed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsClosed)).BeginInit();
            this.panelContractsForFilter.SuspendLayout();
            this.gbContractsFilter.SuspendLayout();
            this.tpMainOrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrg)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmBase,
            this.mmContracts,
            this.mmOrg});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(979, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mmBase
            // 
            this.mmBase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmBaseConnect,
            this.mmBaseSettings,
            this.toolStripMenuItem2,
            this.mmBaseExit});
            this.mmBase.Name = "mmBase";
            this.mmBase.Size = new System.Drawing.Size(86, 20);
            this.mmBase.Text = "База данных";
            // 
            // mmBaseConnect
            // 
            this.mmBaseConnect.Name = "mmBaseConnect";
            this.mmBaseConnect.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mmBaseConnect.Size = new System.Drawing.Size(191, 22);
            this.mmBaseConnect.Text = "Обновить данные";
            this.mmBaseConnect.Click += new System.EventHandler(this.mmBaseConnect_Click);
            // 
            // mmBaseSettings
            // 
            this.mmBaseSettings.Name = "mmBaseSettings";
            this.mmBaseSettings.Size = new System.Drawing.Size(191, 22);
            this.mmBaseSettings.Text = "Настройки";
            this.mmBaseSettings.Click += new System.EventHandler(this.mmBaseSettings_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(188, 6);
            // 
            // mmBaseExit
            // 
            this.mmBaseExit.Name = "mmBaseExit";
            this.mmBaseExit.Size = new System.Drawing.Size(191, 22);
            this.mmBaseExit.Text = "Выход";
            this.mmBaseExit.Click += new System.EventHandler(this.mmBaseExit_Click);
            // 
            // mmContracts
            // 
            this.mmContracts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmContractsNew,
            this.toolStripMenuItem1,
            this.mmContractsReturnableItems,
            this.mmContractsNotReturnableItems,
            this.mmContractsResponsibles});
            this.mmContracts.Name = "mmContracts";
            this.mmContracts.Size = new System.Drawing.Size(75, 20);
            this.mmContracts.Text = "Договоры";
            // 
            // mmContractsNew
            // 
            this.mmContractsNew.Name = "mmContractsNew";
            this.mmContractsNew.ShortcutKeyDisplayString = "";
            this.mmContractsNew.Size = new System.Drawing.Size(226, 22);
            this.mmContractsNew.Text = "Новый договор";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(223, 6);
            // 
            // mmContractsReturnableItems
            // 
            this.mmContractsReturnableItems.Name = "mmContractsReturnableItems";
            this.mmContractsReturnableItems.Size = new System.Drawing.Size(226, 22);
            this.mmContractsReturnableItems.Text = "Возвращаемые предметы...";
            this.mmContractsReturnableItems.Click += new System.EventHandler(this.mmContractsReturnableItems_Click);
            // 
            // mmContractsNotReturnableItems
            // 
            this.mmContractsNotReturnableItems.Name = "mmContractsNotReturnableItems";
            this.mmContractsNotReturnableItems.Size = new System.Drawing.Size(226, 22);
            this.mmContractsNotReturnableItems.Text = "Невозвратные предметы...";
            this.mmContractsNotReturnableItems.Click += new System.EventHandler(this.mmContractsNotReturnableItems_Click);
            // 
            // mmContractsResponsibles
            // 
            this.mmContractsResponsibles.Name = "mmContractsResponsibles";
            this.mmContractsResponsibles.Size = new System.Drawing.Size(226, 22);
            this.mmContractsResponsibles.Text = "Ответственные лица...";
            this.mmContractsResponsibles.Click += new System.EventHandler(this.mmContractsResponsibles_Click);
            // 
            // mmOrg
            // 
            this.mmOrg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmOrgNew,
            this.toolStripSeparator1,
            this.mmOrgATE,
            this.mmOrgMemberships});
            this.mmOrg.Name = "mmOrg";
            this.mmOrg.Size = new System.Drawing.Size(92, 20);
            this.mmOrg.Text = "Организации";
            // 
            // mmOrgNew
            // 
            this.mmOrgNew.Name = "mmOrgNew";
            this.mmOrgNew.Size = new System.Drawing.Size(229, 22);
            this.mmOrgNew.Text = "Новая организация";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // mmOrgATE
            // 
            this.mmOrgATE.Name = "mmOrgATE";
            this.mmOrgATE.Size = new System.Drawing.Size(229, 22);
            this.mmOrgATE.Text = "Районы, городские округа...";
            this.mmOrgATE.Click += new System.EventHandler(this.mmOrgATE_Click);
            // 
            // mmOrgMemberships
            // 
            this.mmOrgMemberships.Name = "mmOrgMemberships";
            this.mmOrgMemberships.Size = new System.Drawing.Size(229, 22);
            this.mmOrgMemberships.Text = "Принадлежности...";
            this.mmOrgMemberships.Click += new System.EventHandler(this.mmOrgMemberships_Click);
            // 
            // tctrlMain
            // 
            this.tctrlMain.Controls.Add(this.tpMainContracts);
            this.tctrlMain.Controls.Add(this.tpMainOrg);
            this.tctrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlMain.Location = new System.Drawing.Point(0, 24);
            this.tctrlMain.Name = "tctrlMain";
            this.tctrlMain.SelectedIndex = 0;
            this.tctrlMain.Size = new System.Drawing.Size(979, 461);
            this.tctrlMain.TabIndex = 2;
            // 
            // tpMainContracts
            // 
            this.tpMainContracts.Controls.Add(this.tctrlMainContracts);
            this.tpMainContracts.Controls.Add(this.panelContractsForFilter);
            this.tpMainContracts.Location = new System.Drawing.Point(4, 22);
            this.tpMainContracts.Name = "tpMainContracts";
            this.tpMainContracts.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainContracts.Size = new System.Drawing.Size(971, 435);
            this.tpMainContracts.TabIndex = 0;
            this.tpMainContracts.Text = "Договоры";
            this.tpMainContracts.UseVisualStyleBackColor = true;
            // 
            // tctrlMainContracts
            // 
            this.tctrlMainContracts.Controls.Add(this.tpMainContractsOpenedAll);
            this.tctrlMainContracts.Controls.Add(this.tpMainContractsOpenedProsrok);
            this.tctrlMainContracts.Controls.Add(this.tpMainContractsClosed);
            this.tctrlMainContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlMainContracts.Location = new System.Drawing.Point(3, 3);
            this.tctrlMainContracts.Name = "tctrlMainContracts";
            this.tctrlMainContracts.SelectedIndex = 0;
            this.tctrlMainContracts.Size = new System.Drawing.Size(734, 429);
            this.tctrlMainContracts.TabIndex = 0;
            // 
            // tpMainContractsOpenedAll
            // 
            this.tpMainContractsOpenedAll.Controls.Add(this.dgvContractsOpenedAll);
            this.tpMainContractsOpenedAll.Controls.Add(this.toolStrip2);
            this.tpMainContractsOpenedAll.Location = new System.Drawing.Point(4, 22);
            this.tpMainContractsOpenedAll.Name = "tpMainContractsOpenedAll";
            this.tpMainContractsOpenedAll.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainContractsOpenedAll.Size = new System.Drawing.Size(726, 403);
            this.tpMainContractsOpenedAll.TabIndex = 0;
            this.tpMainContractsOpenedAll.Text = "Открытые договоры (все)";
            this.tpMainContractsOpenedAll.UseVisualStyleBackColor = true;
            // 
            // dgvContractsOpenedAll
            // 
            this.dgvContractsOpenedAll.AllowUserToAddRows = false;
            this.dgvContractsOpenedAll.AllowUserToDeleteRows = false;
            this.dgvContractsOpenedAll.AllowUserToResizeRows = false;
            this.dgvContractsOpenedAll.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvContractsOpenedAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractsOpenedAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContractsOpenedAll.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContractsOpenedAll.Location = new System.Drawing.Point(3, 28);
            this.dgvContractsOpenedAll.MultiSelect = false;
            this.dgvContractsOpenedAll.Name = "dgvContractsOpenedAll";
            this.dgvContractsOpenedAll.RowHeadersVisible = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContractsOpenedAll.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContractsOpenedAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContractsOpenedAll.Size = new System.Drawing.Size(720, 372);
            this.dgvContractsOpenedAll.TabIndex = 0;
            // 
            // tpMainContractsOpenedProsrok
            // 
            this.tpMainContractsOpenedProsrok.Controls.Add(this.dgvContractsOpenedProsrok);
            this.tpMainContractsOpenedProsrok.Controls.Add(this.toolStrip1);
            this.tpMainContractsOpenedProsrok.Location = new System.Drawing.Point(4, 22);
            this.tpMainContractsOpenedProsrok.Name = "tpMainContractsOpenedProsrok";
            this.tpMainContractsOpenedProsrok.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainContractsOpenedProsrok.Size = new System.Drawing.Size(726, 370);
            this.tpMainContractsOpenedProsrok.TabIndex = 1;
            this.tpMainContractsOpenedProsrok.Text = "Открытые договоры (просрок)";
            this.tpMainContractsOpenedProsrok.UseVisualStyleBackColor = true;
            // 
            // dgvContractsOpenedProsrok
            // 
            this.dgvContractsOpenedProsrok.AllowUserToAddRows = false;
            this.dgvContractsOpenedProsrok.AllowUserToDeleteRows = false;
            this.dgvContractsOpenedProsrok.AllowUserToResizeRows = false;
            this.dgvContractsOpenedProsrok.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvContractsOpenedProsrok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContractsOpenedProsrok.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContractsOpenedProsrok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContractsOpenedProsrok.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContractsOpenedProsrok.Location = new System.Drawing.Point(3, 28);
            this.dgvContractsOpenedProsrok.MultiSelect = false;
            this.dgvContractsOpenedProsrok.Name = "dgvContractsOpenedProsrok";
            this.dgvContractsOpenedProsrok.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContractsOpenedProsrok.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContractsOpenedProsrok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContractsOpenedProsrok.Size = new System.Drawing.Size(720, 339);
            this.dgvContractsOpenedProsrok.TabIndex = 0;
            // 
            // tpMainContractsClosed
            // 
            this.tpMainContractsClosed.Controls.Add(this.dgvContractsClosed);
            this.tpMainContractsClosed.Controls.Add(this.toolStrip3);
            this.tpMainContractsClosed.Location = new System.Drawing.Point(4, 22);
            this.tpMainContractsClosed.Name = "tpMainContractsClosed";
            this.tpMainContractsClosed.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainContractsClosed.Size = new System.Drawing.Size(726, 370);
            this.tpMainContractsClosed.TabIndex = 3;
            this.tpMainContractsClosed.Text = "Закрытые договоры";
            this.tpMainContractsClosed.UseVisualStyleBackColor = true;
            // 
            // dgvContractsClosed
            // 
            this.dgvContractsClosed.AllowUserToAddRows = false;
            this.dgvContractsClosed.AllowUserToDeleteRows = false;
            this.dgvContractsClosed.AllowUserToResizeRows = false;
            this.dgvContractsClosed.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvContractsClosed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContractsClosed.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContractsClosed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContractsClosed.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContractsClosed.Location = new System.Drawing.Point(3, 28);
            this.dgvContractsClosed.MultiSelect = false;
            this.dgvContractsClosed.Name = "dgvContractsClosed";
            this.dgvContractsClosed.RowHeadersVisible = false;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContractsClosed.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvContractsClosed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContractsClosed.Size = new System.Drawing.Size(720, 339);
            this.dgvContractsClosed.TabIndex = 0;
            // 
            // panelContractsForFilter
            // 
            this.panelContractsForFilter.Controls.Add(this.gbContractsFilter);
            this.panelContractsForFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContractsForFilter.Location = new System.Drawing.Point(737, 3);
            this.panelContractsForFilter.Name = "panelContractsForFilter";
            this.panelContractsForFilter.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelContractsForFilter.Size = new System.Drawing.Size(231, 429);
            this.panelContractsForFilter.TabIndex = 1;
            // 
            // gbContractsFilter
            // 
            this.gbContractsFilter.Controls.Add(this.btnContractsFilterReset);
            this.gbContractsFilter.Controls.Add(this.btnContractsFilterApply);
            this.gbContractsFilter.Controls.Add(this.checkContractsFilterDateOfReturn);
            this.gbContractsFilter.Controls.Add(this.dtpContractsFilterReturnDO);
            this.gbContractsFilter.Controls.Add(this.label8);
            this.gbContractsFilter.Controls.Add(this.dtpContractsFilterReturnOT);
            this.gbContractsFilter.Controls.Add(this.label9);
            this.gbContractsFilter.Controls.Add(this.checkContractsFilterDateOfIssue);
            this.gbContractsFilter.Controls.Add(this.dtpContractsFilterIssueDO);
            this.gbContractsFilter.Controls.Add(this.label6);
            this.gbContractsFilter.Controls.Add(this.dtpContractsFilterIssueOT);
            this.gbContractsFilter.Controls.Add(this.label7);
            this.gbContractsFilter.Controls.Add(this.checkContractsFilterDateOfSigning);
            this.gbContractsFilter.Controls.Add(this.dtpContractsFilterSingingDO);
            this.gbContractsFilter.Controls.Add(this.label5);
            this.gbContractsFilter.Controls.Add(this.comboContractsFilterResponsible);
            this.gbContractsFilter.Controls.Add(this.dtpContractsFilterSingingOT);
            this.gbContractsFilter.Controls.Add(this.label4);
            this.gbContractsFilter.Controls.Add(this.label3);
            this.gbContractsFilter.Controls.Add(this.label2);
            this.gbContractsFilter.Controls.Add(this.tbContractsFilterNumber);
            this.gbContractsFilter.Controls.Add(this.label1);
            this.gbContractsFilter.Controls.Add(this.tbContractsFilterCodeOO);
            this.gbContractsFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbContractsFilter.Location = new System.Drawing.Point(5, 0);
            this.gbContractsFilter.Name = "gbContractsFilter";
            this.gbContractsFilter.Size = new System.Drawing.Size(221, 429);
            this.gbContractsFilter.TabIndex = 0;
            this.gbContractsFilter.TabStop = false;
            this.gbContractsFilter.Text = "Фильтр";
            // 
            // btnContractsFilterReset
            // 
            this.btnContractsFilterReset.Location = new System.Drawing.Point(113, 362);
            this.btnContractsFilterReset.Name = "btnContractsFilterReset";
            this.btnContractsFilterReset.Size = new System.Drawing.Size(102, 23);
            this.btnContractsFilterReset.TabIndex = 23;
            this.btnContractsFilterReset.Text = "Сбросить";
            this.btnContractsFilterReset.UseVisualStyleBackColor = true;
            // 
            // btnContractsFilterApply
            // 
            this.btnContractsFilterApply.Location = new System.Drawing.Point(6, 362);
            this.btnContractsFilterApply.Name = "btnContractsFilterApply";
            this.btnContractsFilterApply.Size = new System.Drawing.Size(101, 23);
            this.btnContractsFilterApply.TabIndex = 22;
            this.btnContractsFilterApply.Text = "Применить";
            this.btnContractsFilterApply.UseVisualStyleBackColor = true;
            this.btnContractsFilterApply.Click += new System.EventHandler(this.btnContractsFilterApply_Click);
            // 
            // checkContractsFilterDateOfReturn
            // 
            this.checkContractsFilterDateOfReturn.AutoSize = true;
            this.checkContractsFilterDateOfReturn.Location = new System.Drawing.Point(6, 287);
            this.checkContractsFilterDateOfReturn.Name = "checkContractsFilterDateOfReturn";
            this.checkContractsFilterDateOfReturn.Size = new System.Drawing.Size(105, 17);
            this.checkContractsFilterDateOfReturn.TabIndex = 21;
            this.checkContractsFilterDateOfReturn.Text = "Дата возврата:";
            this.checkContractsFilterDateOfReturn.UseVisualStyleBackColor = true;
            // 
            // dtpContractsFilterReturnDO
            // 
            this.dtpContractsFilterReturnDO.Enabled = false;
            this.dtpContractsFilterReturnDO.Location = new System.Drawing.Point(37, 336);
            this.dtpContractsFilterReturnDO.Name = "dtpContractsFilterReturnDO";
            this.dtpContractsFilterReturnDO.Size = new System.Drawing.Size(175, 20);
            this.dtpContractsFilterReturnDO.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "До:";
            // 
            // dtpContractsFilterReturnOT
            // 
            this.dtpContractsFilterReturnOT.Enabled = false;
            this.dtpContractsFilterReturnOT.Location = new System.Drawing.Point(37, 310);
            this.dtpContractsFilterReturnOT.Name = "dtpContractsFilterReturnOT";
            this.dtpContractsFilterReturnOT.Size = new System.Drawing.Size(175, 20);
            this.dtpContractsFilterReturnOT.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "От:";
            // 
            // checkContractsFilterDateOfIssue
            // 
            this.checkContractsFilterDateOfIssue.AutoSize = true;
            this.checkContractsFilterDateOfIssue.Location = new System.Drawing.Point(9, 212);
            this.checkContractsFilterDateOfIssue.Name = "checkContractsFilterDateOfIssue";
            this.checkContractsFilterDateOfIssue.Size = new System.Drawing.Size(95, 17);
            this.checkContractsFilterDateOfIssue.TabIndex = 16;
            this.checkContractsFilterDateOfIssue.Text = "Дата выдачи:";
            this.checkContractsFilterDateOfIssue.UseVisualStyleBackColor = true;
            // 
            // dtpContractsFilterIssueDO
            // 
            this.dtpContractsFilterIssueDO.Enabled = false;
            this.dtpContractsFilterIssueDO.Location = new System.Drawing.Point(37, 261);
            this.dtpContractsFilterIssueDO.Name = "dtpContractsFilterIssueDO";
            this.dtpContractsFilterIssueDO.Size = new System.Drawing.Size(178, 20);
            this.dtpContractsFilterIssueDO.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "До:";
            // 
            // dtpContractsFilterIssueOT
            // 
            this.dtpContractsFilterIssueOT.Enabled = false;
            this.dtpContractsFilterIssueOT.Location = new System.Drawing.Point(37, 235);
            this.dtpContractsFilterIssueOT.Name = "dtpContractsFilterIssueOT";
            this.dtpContractsFilterIssueOT.Size = new System.Drawing.Size(178, 20);
            this.dtpContractsFilterIssueOT.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "От:";
            // 
            // checkContractsFilterDateOfSigning
            // 
            this.checkContractsFilterDateOfSigning.AutoSize = true;
            this.checkContractsFilterDateOfSigning.Location = new System.Drawing.Point(9, 137);
            this.checkContractsFilterDateOfSigning.Name = "checkContractsFilterDateOfSigning";
            this.checkContractsFilterDateOfSigning.Size = new System.Drawing.Size(118, 17);
            this.checkContractsFilterDateOfSigning.TabIndex = 11;
            this.checkContractsFilterDateOfSigning.Text = "Дата подписания:";
            this.checkContractsFilterDateOfSigning.UseVisualStyleBackColor = true;
            // 
            // dtpContractsFilterSingingDO
            // 
            this.dtpContractsFilterSingingDO.Enabled = false;
            this.dtpContractsFilterSingingDO.Location = new System.Drawing.Point(37, 186);
            this.dtpContractsFilterSingingDO.Name = "dtpContractsFilterSingingDO";
            this.dtpContractsFilterSingingDO.Size = new System.Drawing.Size(178, 20);
            this.dtpContractsFilterSingingDO.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "До:";
            // 
            // comboContractsFilterResponsible
            // 
            this.comboContractsFilterResponsible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContractsFilterResponsible.FormattingEnabled = true;
            this.comboContractsFilterResponsible.Location = new System.Drawing.Point(6, 110);
            this.comboContractsFilterResponsible.Name = "comboContractsFilterResponsible";
            this.comboContractsFilterResponsible.Size = new System.Drawing.Size(209, 21);
            this.comboContractsFilterResponsible.TabIndex = 5;
            // 
            // dtpContractsFilterSingingOT
            // 
            this.dtpContractsFilterSingingOT.Enabled = false;
            this.dtpContractsFilterSingingOT.Location = new System.Drawing.Point(37, 160);
            this.dtpContractsFilterSingingOT.Name = "dtpContractsFilterSingingOT";
            this.dtpContractsFilterSingingOT.Size = new System.Drawing.Size(178, 20);
            this.dtpContractsFilterSingingOT.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "От:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ответственный:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Код ОО:";
            // 
            // tbContractsFilterNumber
            // 
            this.tbContractsFilterNumber.Location = new System.Drawing.Point(6, 32);
            this.tbContractsFilterNumber.Name = "tbContractsFilterNumber";
            this.tbContractsFilterNumber.Size = new System.Drawing.Size(209, 20);
            this.tbContractsFilterNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "№ договора:";
            // 
            // tbContractsFilterCodeOO
            // 
            this.tbContractsFilterCodeOO.Location = new System.Drawing.Point(7, 71);
            this.tbContractsFilterCodeOO.Name = "tbContractsFilterCodeOO";
            this.tbContractsFilterCodeOO.Size = new System.Drawing.Size(208, 20);
            this.tbContractsFilterCodeOO.TabIndex = 2;
            // 
            // tpMainOrg
            // 
            this.tpMainOrg.Controls.Add(this.dgvOrg);
            this.tpMainOrg.Controls.Add(this.toolStrip4);
            this.tpMainOrg.Controls.Add(this.panel1);
            this.tpMainOrg.Location = new System.Drawing.Point(4, 22);
            this.tpMainOrg.Name = "tpMainOrg";
            this.tpMainOrg.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainOrg.Size = new System.Drawing.Size(971, 435);
            this.tpMainOrg.TabIndex = 1;
            this.tpMainOrg.Text = "Организации";
            this.tpMainOrg.UseVisualStyleBackColor = true;
            // 
            // dgvOrg
            // 
            this.dgvOrg.AllowUserToAddRows = false;
            this.dgvOrg.AllowUserToDeleteRows = false;
            this.dgvOrg.AllowUserToResizeRows = false;
            this.dgvOrg.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrg.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrg.Location = new System.Drawing.Point(3, 28);
            this.dgvOrg.MultiSelect = false;
            this.dgvOrg.Name = "dgvOrg";
            this.dgvOrg.RowHeadersVisible = false;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrg.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrg.Size = new System.Drawing.Size(734, 404);
            this.dgvOrg.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(737, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel1.Size = new System.Drawing.Size(231, 429);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkOrgFilterHasOpenedProsrokContracts);
            this.groupBox1.Controls.Add(this.comboOrgFilterMemberships);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnOrgFilterReset);
            this.groupBox1.Controls.Add(this.btnOrgFilterApply);
            this.groupBox1.Controls.Add(this.checkOrgFilterIsPPE11);
            this.groupBox1.Controls.Add(this.checkOrgFilterIsPPE9);
            this.groupBox1.Controls.Add(this.checkOrgFilterHasOpenedContracts);
            this.groupBox1.Controls.Add(this.comboOrgFilterATE);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.tbOrgFilterOOName);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.tbOrgFilterOOCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // checkOrgFilterHasOpenedProsrokContracts
            // 
            this.checkOrgFilterHasOpenedProsrokContracts.AutoSize = true;
            this.checkOrgFilterHasOpenedProsrokContracts.Location = new System.Drawing.Point(6, 200);
            this.checkOrgFilterHasOpenedProsrokContracts.Name = "checkOrgFilterHasOpenedProsrokContracts";
            this.checkOrgFilterHasOpenedProsrokContracts.Size = new System.Drawing.Size(178, 17);
            this.checkOrgFilterHasOpenedProsrokContracts.TabIndex = 26;
            this.checkOrgFilterHasOpenedProsrokContracts.Text = "Есть просроченные договоры";
            this.checkOrgFilterHasOpenedProsrokContracts.UseVisualStyleBackColor = true;
            // 
            // comboOrgFilterMemberships
            // 
            this.comboOrgFilterMemberships.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrgFilterMemberships.FormattingEnabled = true;
            this.comboOrgFilterMemberships.Location = new System.Drawing.Point(6, 150);
            this.comboOrgFilterMemberships.Name = "comboOrgFilterMemberships";
            this.comboOrgFilterMemberships.Size = new System.Drawing.Size(209, 21);
            this.comboOrgFilterMemberships.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Принадлежность:";
            // 
            // btnOrgFilterReset
            // 
            this.btnOrgFilterReset.Location = new System.Drawing.Point(113, 269);
            this.btnOrgFilterReset.Name = "btnOrgFilterReset";
            this.btnOrgFilterReset.Size = new System.Drawing.Size(102, 23);
            this.btnOrgFilterReset.TabIndex = 23;
            this.btnOrgFilterReset.Text = "Сбросить";
            this.btnOrgFilterReset.UseVisualStyleBackColor = true;
            // 
            // btnOrgFilterApply
            // 
            this.btnOrgFilterApply.Location = new System.Drawing.Point(6, 269);
            this.btnOrgFilterApply.Name = "btnOrgFilterApply";
            this.btnOrgFilterApply.Size = new System.Drawing.Size(101, 23);
            this.btnOrgFilterApply.TabIndex = 22;
            this.btnOrgFilterApply.Text = "Применить";
            this.btnOrgFilterApply.UseVisualStyleBackColor = true;
            // 
            // checkOrgFilterIsPPE11
            // 
            this.checkOrgFilterIsPPE11.AutoSize = true;
            this.checkOrgFilterIsPPE11.Location = new System.Drawing.Point(6, 246);
            this.checkOrgFilterIsPPE11.Name = "checkOrgFilterIsPPE11";
            this.checkOrgFilterIsPPE11.Size = new System.Drawing.Size(163, 17);
            this.checkOrgFilterIsPPE11.TabIndex = 21;
            this.checkOrgFilterIsPPE11.Text = "Является ППЭ (11 классы)";
            this.checkOrgFilterIsPPE11.UseVisualStyleBackColor = true;
            // 
            // checkOrgFilterIsPPE9
            // 
            this.checkOrgFilterIsPPE9.AutoSize = true;
            this.checkOrgFilterIsPPE9.Location = new System.Drawing.Point(6, 223);
            this.checkOrgFilterIsPPE9.Name = "checkOrgFilterIsPPE9";
            this.checkOrgFilterIsPPE9.Size = new System.Drawing.Size(157, 17);
            this.checkOrgFilterIsPPE9.TabIndex = 16;
            this.checkOrgFilterIsPPE9.Text = "Является ППЭ (9 классы)";
            this.checkOrgFilterIsPPE9.UseVisualStyleBackColor = true;
            // 
            // checkOrgFilterHasOpenedContracts
            // 
            this.checkOrgFilterHasOpenedContracts.AutoSize = true;
            this.checkOrgFilterHasOpenedContracts.Location = new System.Drawing.Point(6, 177);
            this.checkOrgFilterHasOpenedContracts.Name = "checkOrgFilterHasOpenedContracts";
            this.checkOrgFilterHasOpenedContracts.Size = new System.Drawing.Size(155, 17);
            this.checkOrgFilterHasOpenedContracts.TabIndex = 11;
            this.checkOrgFilterHasOpenedContracts.Text = "Есть открытые договоры";
            this.checkOrgFilterHasOpenedContracts.UseVisualStyleBackColor = true;
            // 
            // comboOrgFilterATE
            // 
            this.comboOrgFilterATE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrgFilterATE.FormattingEnabled = true;
            this.comboOrgFilterATE.Location = new System.Drawing.Point(6, 110);
            this.comboOrgFilterATE.Name = "comboOrgFilterATE";
            this.comboOrgFilterATE.Size = new System.Drawing.Size(209, 21);
            this.comboOrgFilterATE.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Район, городской округ:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Код ОО:";
            // 
            // tbOrgFilterOOName
            // 
            this.tbOrgFilterOOName.Location = new System.Drawing.Point(6, 32);
            this.tbOrgFilterOOName.Name = "tbOrgFilterOOName";
            this.tbOrgFilterOOName.Size = new System.Drawing.Size(209, 20);
            this.tbOrgFilterOOName.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Наименование:";
            // 
            // tbOrgFilterOOCode
            // 
            this.tbOrgFilterOOCode.Location = new System.Drawing.Point(7, 71);
            this.tbOrgFilterOOCode.Name = "tbOrgFilterOOCode";
            this.tbOrgFilterOOCode.Size = new System.Drawing.Size(208, 20);
            this.tbOrgFilterOOCode.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton10});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(720, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(84, 22);
            this.toolStripButton6.Text = "Просмотр";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton7.Text = "Правка";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(189, 22);
            this.toolStripButton8.Text = "Обновить / Сбросить фильтр";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton9.Text = "Экспорт";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(113, 22);
            this.toolStripButton10.Text = "Новый договор";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton5,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(720, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(84, 22);
            this.toolStripButton1.Text = "Просмотр";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton2.Text = "Правка";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(189, 22);
            this.toolStripButton3.Text = "Обновить / Сбросить фильтр";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton5.Text = "Экспорт";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(113, 22);
            this.toolStripButton4.Text = "Новый договор";
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton11,
            this.toolStripButton13,
            this.toolStripButton14});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(720, 25);
            this.toolStrip3.TabIndex = 3;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(84, 22);
            this.toolStripButton11.Text = "Просмотр";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(189, 22);
            this.toolStripButton13.Text = "Обновить / Сбросить фильтр";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton14.Text = "Экспорт";
            // 
            // toolStrip4
            // 
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnOrgView,
            this.toolStripButton12,
            this.toolStripButton18,
            this.toolStripButton16,
            this.toolStripButton17});
            this.toolStrip4.Location = new System.Drawing.Point(3, 3);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(734, 25);
            this.toolStrip4.TabIndex = 4;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(160, 22);
            this.toolStripButton12.Text = "Изменить информацию";
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.Size = new System.Drawing.Size(189, 22);
            this.toolStripButton16.Text = "Обновить / Сбросить фильтр";
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton17.Text = "Экспорт";
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.Size = new System.Drawing.Size(156, 22);
            this.toolStripButton18.Text = "Добавить организацию";
            // 
            // tsbtnOrgView
            // 
            this.tsbtnOrgView.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOrgView.Image")));
            this.tsbtnOrgView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOrgView.Name = "tsbtnOrgView";
            this.tsbtnOrgView.Size = new System.Drawing.Size(84, 22);
            this.tsbtnOrgView.Text = "Просмотр";
            this.tsbtnOrgView.Click += new System.EventHandler(this.tsbtnOrgView_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 485);
            this.Controls.Add(this.tctrlMain);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Журнал учета";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tctrlMain.ResumeLayout(false);
            this.tpMainContracts.ResumeLayout(false);
            this.tctrlMainContracts.ResumeLayout(false);
            this.tpMainContractsOpenedAll.ResumeLayout(false);
            this.tpMainContractsOpenedAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsOpenedAll)).EndInit();
            this.tpMainContractsOpenedProsrok.ResumeLayout(false);
            this.tpMainContractsOpenedProsrok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsOpenedProsrok)).EndInit();
            this.tpMainContractsClosed.ResumeLayout(false);
            this.tpMainContractsClosed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsClosed)).EndInit();
            this.panelContractsForFilter.ResumeLayout(false);
            this.gbContractsFilter.ResumeLayout(false);
            this.gbContractsFilter.PerformLayout();
            this.tpMainOrg.ResumeLayout(false);
            this.tpMainOrg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mmBase;
        private System.Windows.Forms.ToolStripMenuItem mmBaseConnect;
        private System.Windows.Forms.ToolStripMenuItem mmBaseSettings;
        private System.Windows.Forms.ToolStripMenuItem mmContracts;
        private System.Windows.Forms.ToolStripMenuItem mmContractsNew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mmContractsReturnableItems;
        private System.Windows.Forms.ToolStripMenuItem mmContractsNotReturnableItems;
        private System.Windows.Forms.ToolStripMenuItem mmOrg;
        private System.Windows.Forms.ToolStripMenuItem mmOrgNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mmOrgATE;
        private System.Windows.Forms.ToolStripMenuItem mmOrgMemberships;
        private System.Windows.Forms.TabControl tctrlMain;
        private System.Windows.Forms.TabPage tpMainContracts;
        private System.Windows.Forms.TabControl tctrlMainContracts;
        private System.Windows.Forms.TabPage tpMainContractsOpenedAll;
        private System.Windows.Forms.TabPage tpMainContractsOpenedProsrok;
        private System.Windows.Forms.Panel panelContractsForFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbContractsFilterCodeOO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbContractsFilterNumber;
        private System.Windows.Forms.TabPage tpMainOrg;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mmBaseExit;
        private System.Windows.Forms.GroupBox gbContractsFilter;
        private System.Windows.Forms.Button btnContractsFilterReset;
        private System.Windows.Forms.Button btnContractsFilterApply;
        private System.Windows.Forms.CheckBox checkContractsFilterDateOfReturn;
        private System.Windows.Forms.DateTimePicker dtpContractsFilterReturnDO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpContractsFilterReturnOT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkContractsFilterDateOfIssue;
        private System.Windows.Forms.DateTimePicker dtpContractsFilterIssueDO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpContractsFilterIssueOT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkContractsFilterDateOfSigning;
        private System.Windows.Forms.DateTimePicker dtpContractsFilterSingingDO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContractsFilterResponsible;
        private System.Windows.Forms.DateTimePicker dtpContractsFilterSingingOT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvContractsOpenedAll;
        private System.Windows.Forms.DataGridView dgvContractsOpenedProsrok;
        private System.Windows.Forms.TabPage tpMainContractsClosed;
        private System.Windows.Forms.DataGridView dgvContractsClosed;
        private System.Windows.Forms.ToolStripMenuItem mmContractsResponsibles;
        private System.Windows.Forms.DataGridView dgvOrg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkOrgFilterHasOpenedProsrokContracts;
        private System.Windows.Forms.ComboBox comboOrgFilterMemberships;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOrgFilterReset;
        private System.Windows.Forms.Button btnOrgFilterApply;
        private System.Windows.Forms.CheckBox checkOrgFilterIsPPE11;
        private System.Windows.Forms.CheckBox checkOrgFilterIsPPE9;
        private System.Windows.Forms.CheckBox checkOrgFilterHasOpenedContracts;
        private System.Windows.Forms.ComboBox comboOrgFilterATE;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbOrgFilterOOName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbOrgFilterOOCode;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton tsbtnOrgView;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
    }
}

