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
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.статистикаПоПредметамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolsContractsOpAll = new System.Windows.Forms.ToolStrip();
            this.tsbtnConOpAllView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnConOpAllRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnConOpAllNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnConOpAllEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnConOpAllRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnConOpAllExport = new System.Windows.Forms.ToolStripButton();
            this.tpMainContractsOpenedProsrok = new System.Windows.Forms.TabPage();
            this.dgvContractsOpenedProsrok = new System.Windows.Forms.DataGridView();
            this.toolsContractsOpProsrok = new System.Windows.Forms.ToolStrip();
            this.tsbtnConProsrokView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnConProsrokRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnConProsrokNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnConProsrokEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnConOpProsrokRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnConProsrokExport = new System.Windows.Forms.ToolStripButton();
            this.tpMainContractsClosed = new System.Windows.Forms.TabPage();
            this.dgvContractsClosed = new System.Windows.Forms.DataGridView();
            this.toolsContractsClosed = new System.Windows.Forms.ToolStrip();
            this.tsbtnConClosedView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnConClosedRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnConClosedRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnConClosedExport = new System.Windows.Forms.ToolStripButton();
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
            this.toolsOrg = new System.Windows.Forms.ToolStrip();
            this.tsbtnOrgView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnOrgRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnOrgAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOrgEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOrgRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnOrgExport = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboOrgFilterMemberships = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOrgFilterReset = new System.Windows.Forms.Button();
            this.btnOrgFilterApply = new System.Windows.Forms.Button();
            this.comboOrgFilterATE = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbOrgFilterOOName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbOrgFilterOOCode = new System.Windows.Forms.TextBox();
            this.statusConOpAll = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslConOpAllCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusConOpProsrok = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslConOpProsrokCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusConClosed = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslConClosedCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusOrg = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslOrgCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu.SuspendLayout();
            this.tctrlMain.SuspendLayout();
            this.tpMainContracts.SuspendLayout();
            this.tctrlMainContracts.SuspendLayout();
            this.tpMainContractsOpenedAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsOpenedAll)).BeginInit();
            this.toolsContractsOpAll.SuspendLayout();
            this.tpMainContractsOpenedProsrok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsOpenedProsrok)).BeginInit();
            this.toolsContractsOpProsrok.SuspendLayout();
            this.tpMainContractsClosed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsClosed)).BeginInit();
            this.toolsContractsClosed.SuspendLayout();
            this.panelContractsForFilter.SuspendLayout();
            this.gbContractsFilter.SuspendLayout();
            this.tpMainOrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrg)).BeginInit();
            this.toolsOrg.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusConOpAll.SuspendLayout();
            this.statusConOpProsrok.SuspendLayout();
            this.statusConClosed.SuspendLayout();
            this.statusOrg.SuspendLayout();
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
            this.mmBase.Size = new System.Drawing.Size(87, 20);
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
            this.mmContractsResponsibles,
            this.toolStripSeparator14,
            this.статистикаПоПредметамToolStripMenuItem});
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
            this.mmContractsNew.Click += new System.EventHandler(this.tsbtnConOpAllNew_Click);
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
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(223, 6);
            // 
            // статистикаПоПредметамToolStripMenuItem
            // 
            this.статистикаПоПредметамToolStripMenuItem.Name = "статистикаПоПредметамToolStripMenuItem";
            this.статистикаПоПредметамToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.статистикаПоПредметамToolStripMenuItem.Text = "Статистика по предметам";
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
            this.mmOrgNew.Click += new System.EventHandler(this.tsbtnOrgAdd_Click);
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
            this.tpMainContractsOpenedAll.Controls.Add(this.statusConOpAll);
            this.tpMainContractsOpenedAll.Controls.Add(this.toolsContractsOpAll);
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
            this.dgvContractsOpenedAll.Size = new System.Drawing.Size(720, 350);
            this.dgvContractsOpenedAll.TabIndex = 0;
            this.dgvContractsOpenedAll.DataSourceChanged += new System.EventHandler(this.dgvContractsOpenedAll_DataSourceChanged);
            this.dgvContractsOpenedAll.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContractsOpenedAll_CellDoubleClick);
            // 
            // toolsContractsOpAll
            // 
            this.toolsContractsOpAll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnConOpAllView,
            this.toolStripSeparator7,
            this.tsbtnConOpAllRefresh,
            this.toolStripSeparator6,
            this.tsbtnConOpAllNew,
            this.tsbtnConOpAllEdit,
            this.tsbtnConOpAllRemove,
            this.toolStripSeparator5,
            this.tsbtnConOpAllExport});
            this.toolsContractsOpAll.Location = new System.Drawing.Point(3, 3);
            this.toolsContractsOpAll.Name = "toolsContractsOpAll";
            this.toolsContractsOpAll.Size = new System.Drawing.Size(720, 25);
            this.toolsContractsOpAll.TabIndex = 3;
            this.toolsContractsOpAll.Text = "toolStrip2";
            // 
            // tsbtnConOpAllView
            // 
            this.tsbtnConOpAllView.Image = global::LogBook.Properties.Resources.zoom;
            this.tsbtnConOpAllView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConOpAllView.Name = "tsbtnConOpAllView";
            this.tsbtnConOpAllView.Size = new System.Drawing.Size(84, 22);
            this.tsbtnConOpAllView.Text = "Просмотр";
            this.tsbtnConOpAllView.Click += new System.EventHandler(this.tsbtnConOpAllView_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnConOpAllRefresh
            // 
            this.tsbtnConOpAllRefresh.Image = global::LogBook.Properties.Resources.refresh;
            this.tsbtnConOpAllRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConOpAllRefresh.Name = "tsbtnConOpAllRefresh";
            this.tsbtnConOpAllRefresh.Size = new System.Drawing.Size(189, 22);
            this.tsbtnConOpAllRefresh.Text = "Обновить / Сбросить фильтр";
            this.tsbtnConOpAllRefresh.Click += new System.EventHandler(this.tsbtnConOpAllRefresh_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnConOpAllNew
            // 
            this.tsbtnConOpAllNew.Image = global::LogBook.Properties.Resources.tool_new_file;
            this.tsbtnConOpAllNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConOpAllNew.Name = "tsbtnConOpAllNew";
            this.tsbtnConOpAllNew.Size = new System.Drawing.Size(113, 22);
            this.tsbtnConOpAllNew.Text = "Новый договор";
            this.tsbtnConOpAllNew.Click += new System.EventHandler(this.tsbtnConOpAllNew_Click);
            // 
            // tsbtnConOpAllEdit
            // 
            this.tsbtnConOpAllEdit.Image = global::LogBook.Properties.Resources.tool_edit;
            this.tsbtnConOpAllEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConOpAllEdit.Name = "tsbtnConOpAllEdit";
            this.tsbtnConOpAllEdit.Size = new System.Drawing.Size(67, 22);
            this.tsbtnConOpAllEdit.Text = "Правка";
            this.tsbtnConOpAllEdit.Click += new System.EventHandler(this.tsbtnConOpAllEdit_Click);
            // 
            // tsbtnConOpAllRemove
            // 
            this.tsbtnConOpAllRemove.Image = global::LogBook.Properties.Resources.tool_delete;
            this.tsbtnConOpAllRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConOpAllRemove.Name = "tsbtnConOpAllRemove";
            this.tsbtnConOpAllRemove.Size = new System.Drawing.Size(71, 22);
            this.tsbtnConOpAllRemove.Text = "Удалить";
            this.tsbtnConOpAllRemove.Click += new System.EventHandler(this.tsbtnConOpAllRemove_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnConOpAllExport
            // 
            this.tsbtnConOpAllExport.Image = global::LogBook.Properties.Resources.icon_xls;
            this.tsbtnConOpAllExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConOpAllExport.Name = "tsbtnConOpAllExport";
            this.tsbtnConOpAllExport.Size = new System.Drawing.Size(72, 22);
            this.tsbtnConOpAllExport.Text = "Экспорт";
            this.tsbtnConOpAllExport.Click += new System.EventHandler(this.tsbtnConOpAllExport_Click);
            // 
            // tpMainContractsOpenedProsrok
            // 
            this.tpMainContractsOpenedProsrok.Controls.Add(this.dgvContractsOpenedProsrok);
            this.tpMainContractsOpenedProsrok.Controls.Add(this.statusConOpProsrok);
            this.tpMainContractsOpenedProsrok.Controls.Add(this.toolsContractsOpProsrok);
            this.tpMainContractsOpenedProsrok.Location = new System.Drawing.Point(4, 22);
            this.tpMainContractsOpenedProsrok.Name = "tpMainContractsOpenedProsrok";
            this.tpMainContractsOpenedProsrok.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainContractsOpenedProsrok.Size = new System.Drawing.Size(726, 403);
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
            this.dgvContractsOpenedProsrok.Size = new System.Drawing.Size(720, 350);
            this.dgvContractsOpenedProsrok.TabIndex = 0;
            this.dgvContractsOpenedProsrok.DataSourceChanged += new System.EventHandler(this.dgvContractsOpenedProsrok_DataSourceChanged);
            this.dgvContractsOpenedProsrok.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContractsOpenedProsrok_CellDoubleClick);
            // 
            // toolsContractsOpProsrok
            // 
            this.toolsContractsOpProsrok.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnConProsrokView,
            this.toolStripSeparator9,
            this.tsbtnConProsrokRefresh,
            this.toolStripSeparator8,
            this.tsbtnConProsrokNew,
            this.tsbtnConProsrokEdit,
            this.tsbtnConOpProsrokRemove,
            this.toolStripSeparator10,
            this.tsbtnConProsrokExport});
            this.toolsContractsOpProsrok.Location = new System.Drawing.Point(3, 3);
            this.toolsContractsOpProsrok.Name = "toolsContractsOpProsrok";
            this.toolsContractsOpProsrok.Size = new System.Drawing.Size(720, 25);
            this.toolsContractsOpProsrok.TabIndex = 3;
            this.toolsContractsOpProsrok.Text = "toolStrip1";
            // 
            // tsbtnConProsrokView
            // 
            this.tsbtnConProsrokView.Image = global::LogBook.Properties.Resources.zoom;
            this.tsbtnConProsrokView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConProsrokView.Name = "tsbtnConProsrokView";
            this.tsbtnConProsrokView.Size = new System.Drawing.Size(84, 22);
            this.tsbtnConProsrokView.Text = "Просмотр";
            this.tsbtnConProsrokView.Click += new System.EventHandler(this.tsbtnConProsrokView_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnConProsrokRefresh
            // 
            this.tsbtnConProsrokRefresh.Image = global::LogBook.Properties.Resources.refresh;
            this.tsbtnConProsrokRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConProsrokRefresh.Name = "tsbtnConProsrokRefresh";
            this.tsbtnConProsrokRefresh.Size = new System.Drawing.Size(189, 22);
            this.tsbtnConProsrokRefresh.Text = "Обновить / Сбросить фильтр";
            this.tsbtnConProsrokRefresh.Click += new System.EventHandler(this.tsbtnConProsrokRefresh_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnConProsrokNew
            // 
            this.tsbtnConProsrokNew.Image = global::LogBook.Properties.Resources.tool_new_file;
            this.tsbtnConProsrokNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConProsrokNew.Name = "tsbtnConProsrokNew";
            this.tsbtnConProsrokNew.Size = new System.Drawing.Size(113, 22);
            this.tsbtnConProsrokNew.Text = "Новый договор";
            this.tsbtnConProsrokNew.Click += new System.EventHandler(this.tsbtnConOpAllNew_Click);
            // 
            // tsbtnConProsrokEdit
            // 
            this.tsbtnConProsrokEdit.Image = global::LogBook.Properties.Resources.tool_edit;
            this.tsbtnConProsrokEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConProsrokEdit.Name = "tsbtnConProsrokEdit";
            this.tsbtnConProsrokEdit.Size = new System.Drawing.Size(67, 22);
            this.tsbtnConProsrokEdit.Text = "Правка";
            // 
            // tsbtnConOpProsrokRemove
            // 
            this.tsbtnConOpProsrokRemove.Image = global::LogBook.Properties.Resources.tool_delete;
            this.tsbtnConOpProsrokRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConOpProsrokRemove.Name = "tsbtnConOpProsrokRemove";
            this.tsbtnConOpProsrokRemove.Size = new System.Drawing.Size(71, 22);
            this.tsbtnConOpProsrokRemove.Text = "Удалить";
            this.tsbtnConOpProsrokRemove.Click += new System.EventHandler(this.tsbtnConOpProsrok_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnConProsrokExport
            // 
            this.tsbtnConProsrokExport.Image = global::LogBook.Properties.Resources.icon_xls;
            this.tsbtnConProsrokExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConProsrokExport.Name = "tsbtnConProsrokExport";
            this.tsbtnConProsrokExport.Size = new System.Drawing.Size(72, 22);
            this.tsbtnConProsrokExport.Text = "Экспорт";
            this.tsbtnConProsrokExport.Click += new System.EventHandler(this.tsbtnConProsrokExport_Click);
            // 
            // tpMainContractsClosed
            // 
            this.tpMainContractsClosed.Controls.Add(this.dgvContractsClosed);
            this.tpMainContractsClosed.Controls.Add(this.statusConClosed);
            this.tpMainContractsClosed.Controls.Add(this.toolsContractsClosed);
            this.tpMainContractsClosed.Location = new System.Drawing.Point(4, 22);
            this.tpMainContractsClosed.Name = "tpMainContractsClosed";
            this.tpMainContractsClosed.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainContractsClosed.Size = new System.Drawing.Size(726, 403);
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
            this.dgvContractsClosed.Size = new System.Drawing.Size(720, 350);
            this.dgvContractsClosed.TabIndex = 0;
            this.dgvContractsClosed.DataSourceChanged += new System.EventHandler(this.dgvContractsClosed_DataSourceChanged);
            this.dgvContractsClosed.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContractsClosed_CellDoubleClick);
            // 
            // toolsContractsClosed
            // 
            this.toolsContractsClosed.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnConClosedView,
            this.toolStripSeparator13,
            this.tsbtnConClosedRefresh,
            this.toolStripSeparator12,
            this.tsbtnConClosedRemove,
            this.toolStripSeparator11,
            this.tsbtnConClosedExport});
            this.toolsContractsClosed.Location = new System.Drawing.Point(3, 3);
            this.toolsContractsClosed.Name = "toolsContractsClosed";
            this.toolsContractsClosed.Size = new System.Drawing.Size(720, 25);
            this.toolsContractsClosed.TabIndex = 3;
            this.toolsContractsClosed.Text = "toolStrip3";
            // 
            // tsbtnConClosedView
            // 
            this.tsbtnConClosedView.Image = global::LogBook.Properties.Resources.zoom;
            this.tsbtnConClosedView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConClosedView.Name = "tsbtnConClosedView";
            this.tsbtnConClosedView.Size = new System.Drawing.Size(84, 22);
            this.tsbtnConClosedView.Text = "Просмотр";
            this.tsbtnConClosedView.Click += new System.EventHandler(this.tsbtnConClosedView_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnConClosedRefresh
            // 
            this.tsbtnConClosedRefresh.Image = global::LogBook.Properties.Resources.refresh;
            this.tsbtnConClosedRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConClosedRefresh.Name = "tsbtnConClosedRefresh";
            this.tsbtnConClosedRefresh.Size = new System.Drawing.Size(189, 22);
            this.tsbtnConClosedRefresh.Text = "Обновить / Сбросить фильтр";
            this.tsbtnConClosedRefresh.Click += new System.EventHandler(this.tsbtnConClosedRefresh_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnConClosedRemove
            // 
            this.tsbtnConClosedRemove.Image = global::LogBook.Properties.Resources.tool_delete;
            this.tsbtnConClosedRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConClosedRemove.Name = "tsbtnConClosedRemove";
            this.tsbtnConClosedRemove.Size = new System.Drawing.Size(71, 22);
            this.tsbtnConClosedRemove.Text = "Удалить";
            this.tsbtnConClosedRemove.Click += new System.EventHandler(this.tsbtnConClosedRemove_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnConClosedExport
            // 
            this.tsbtnConClosedExport.Image = global::LogBook.Properties.Resources.icon_xls;
            this.tsbtnConClosedExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConClosedExport.Name = "tsbtnConClosedExport";
            this.tsbtnConClosedExport.Size = new System.Drawing.Size(72, 22);
            this.tsbtnConClosedExport.Text = "Экспорт";
            this.tsbtnConClosedExport.Click += new System.EventHandler(this.tsbtnConClosedExport_Click);
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
            this.btnContractsFilterReset.Click += new System.EventHandler(this.btnContractsFilterReset_Click);
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
            this.checkContractsFilterDateOfReturn.CheckStateChanged += new System.EventHandler(this.checkContractsFilterDateOfReturn_CheckStateChanged);
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
            this.checkContractsFilterDateOfIssue.CheckStateChanged += new System.EventHandler(this.checkContractsFilterDateOfIssue_CheckStateChanged);
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
            this.checkContractsFilterDateOfSigning.CheckStateChanged += new System.EventHandler(this.checkContractsFilterDateOfSigning_CheckStateChanged);
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
            this.tpMainOrg.Controls.Add(this.statusOrg);
            this.tpMainOrg.Controls.Add(this.toolsOrg);
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
            this.dgvOrg.Size = new System.Drawing.Size(734, 382);
            this.dgvOrg.TabIndex = 3;
            this.dgvOrg.DataSourceChanged += new System.EventHandler(this.dgvOrg_DataSourceChanged);
            this.dgvOrg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrg_CellDoubleClick);
            // 
            // toolsOrg
            // 
            this.toolsOrg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnOrgView,
            this.toolStripSeparator2,
            this.tsbtnOrgRefresh,
            this.toolStripSeparator4,
            this.tsbtnOrgAdd,
            this.tsbtnOrgEdit,
            this.tsbtnOrgRemove,
            this.toolStripSeparator3,
            this.tsbtnOrgExport});
            this.toolsOrg.Location = new System.Drawing.Point(3, 3);
            this.toolsOrg.Name = "toolsOrg";
            this.toolsOrg.Size = new System.Drawing.Size(734, 25);
            this.toolsOrg.TabIndex = 4;
            this.toolsOrg.Text = "toolStrip4";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnOrgRefresh
            // 
            this.tsbtnOrgRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOrgRefresh.Image")));
            this.tsbtnOrgRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOrgRefresh.Name = "tsbtnOrgRefresh";
            this.tsbtnOrgRefresh.Size = new System.Drawing.Size(189, 22);
            this.tsbtnOrgRefresh.Text = "Обновить / Сбросить фильтр";
            this.tsbtnOrgRefresh.Click += new System.EventHandler(this.tsbtnOrgRefresh_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnOrgAdd
            // 
            this.tsbtnOrgAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOrgAdd.Image")));
            this.tsbtnOrgAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOrgAdd.Name = "tsbtnOrgAdd";
            this.tsbtnOrgAdd.Size = new System.Drawing.Size(79, 22);
            this.tsbtnOrgAdd.Text = "Добавить";
            this.tsbtnOrgAdd.Click += new System.EventHandler(this.tsbtnOrgAdd_Click);
            // 
            // tsbtnOrgEdit
            // 
            this.tsbtnOrgEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOrgEdit.Image")));
            this.tsbtnOrgEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOrgEdit.Name = "tsbtnOrgEdit";
            this.tsbtnOrgEdit.Size = new System.Drawing.Size(81, 22);
            this.tsbtnOrgEdit.Text = "Изменить";
            this.tsbtnOrgEdit.Click += new System.EventHandler(this.tsbtnOrgEdit_Click);
            // 
            // tsbtnOrgRemove
            // 
            this.tsbtnOrgRemove.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOrgRemove.Image")));
            this.tsbtnOrgRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOrgRemove.Name = "tsbtnOrgRemove";
            this.tsbtnOrgRemove.Size = new System.Drawing.Size(71, 22);
            this.tsbtnOrgRemove.Text = "Удалить";
            this.tsbtnOrgRemove.Click += new System.EventHandler(this.tsbtnOrgRemove_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnOrgExport
            // 
            this.tsbtnOrgExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOrgExport.Image")));
            this.tsbtnOrgExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOrgExport.Name = "tsbtnOrgExport";
            this.tsbtnOrgExport.Size = new System.Drawing.Size(72, 22);
            this.tsbtnOrgExport.Text = "Экспорт";
            this.tsbtnOrgExport.Click += new System.EventHandler(this.tsbtnOrgExport_Click);
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
            this.groupBox1.Controls.Add(this.comboOrgFilterMemberships);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnOrgFilterReset);
            this.groupBox1.Controls.Add(this.btnOrgFilterApply);
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
            this.btnOrgFilterReset.Location = new System.Drawing.Point(113, 177);
            this.btnOrgFilterReset.Name = "btnOrgFilterReset";
            this.btnOrgFilterReset.Size = new System.Drawing.Size(102, 23);
            this.btnOrgFilterReset.TabIndex = 23;
            this.btnOrgFilterReset.Text = "Сбросить";
            this.btnOrgFilterReset.UseVisualStyleBackColor = true;
            this.btnOrgFilterReset.Click += new System.EventHandler(this.btnOrgFilterReset_Click);
            // 
            // btnOrgFilterApply
            // 
            this.btnOrgFilterApply.Location = new System.Drawing.Point(6, 177);
            this.btnOrgFilterApply.Name = "btnOrgFilterApply";
            this.btnOrgFilterApply.Size = new System.Drawing.Size(101, 23);
            this.btnOrgFilterApply.TabIndex = 22;
            this.btnOrgFilterApply.Text = "Применить";
            this.btnOrgFilterApply.UseVisualStyleBackColor = true;
            this.btnOrgFilterApply.Click += new System.EventHandler(this.btnOrgFilterApply_Click);
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
            // statusConOpAll
            // 
            this.statusConOpAll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslConOpAllCount});
            this.statusConOpAll.Location = new System.Drawing.Point(3, 378);
            this.statusConOpAll.Name = "statusConOpAll";
            this.statusConOpAll.Size = new System.Drawing.Size(720, 22);
            this.statusConOpAll.SizingGrip = false;
            this.statusConOpAll.TabIndex = 4;
            this.statusConOpAll.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel1.Text = "Всего договоров:";
            // 
            // tslConOpAllCount
            // 
            this.tslConOpAllCount.Name = "tslConOpAllCount";
            this.tslConOpAllCount.Size = new System.Drawing.Size(13, 17);
            this.tslConOpAllCount.Text = "0";
            // 
            // statusConOpProsrok
            // 
            this.statusConOpProsrok.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.tslConOpProsrokCount});
            this.statusConOpProsrok.Location = new System.Drawing.Point(3, 378);
            this.statusConOpProsrok.Name = "statusConOpProsrok";
            this.statusConOpProsrok.Size = new System.Drawing.Size(720, 22);
            this.statusConOpProsrok.SizingGrip = false;
            this.statusConOpProsrok.TabIndex = 5;
            this.statusConOpProsrok.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel2.Text = "Всего договоров:";
            // 
            // tslConOpProsrokCount
            // 
            this.tslConOpProsrokCount.Name = "tslConOpProsrokCount";
            this.tslConOpProsrokCount.Size = new System.Drawing.Size(13, 17);
            this.tslConOpProsrokCount.Text = "0";
            // 
            // statusConClosed
            // 
            this.statusConClosed.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.tslConClosedCount});
            this.statusConClosed.Location = new System.Drawing.Point(3, 378);
            this.statusConClosed.Name = "statusConClosed";
            this.statusConClosed.Size = new System.Drawing.Size(720, 22);
            this.statusConClosed.SizingGrip = false;
            this.statusConClosed.TabIndex = 5;
            this.statusConClosed.Text = "statusStrip3";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel3.Text = "Всего договоров:";
            // 
            // tslConClosedCount
            // 
            this.tslConClosedCount.Name = "tslConClosedCount";
            this.tslConClosedCount.Size = new System.Drawing.Size(13, 17);
            this.tslConClosedCount.Text = "0";
            // 
            // statusOrg
            // 
            this.statusOrg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.tslOrgCount});
            this.statusOrg.Location = new System.Drawing.Point(3, 410);
            this.statusOrg.Name = "statusOrg";
            this.statusOrg.Size = new System.Drawing.Size(734, 22);
            this.statusOrg.SizingGrip = false;
            this.statusOrg.TabIndex = 5;
            this.statusOrg.Text = "statusStrip4";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel4.Text = "Всего организаций:";
            // 
            // tslOrgCount
            // 
            this.tslOrgCount.Name = "tslOrgCount";
            this.tslOrgCount.Size = new System.Drawing.Size(13, 17);
            this.tslOrgCount.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 485);
            this.Controls.Add(this.tctrlMain);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.toolsContractsOpAll.ResumeLayout(false);
            this.toolsContractsOpAll.PerformLayout();
            this.tpMainContractsOpenedProsrok.ResumeLayout(false);
            this.tpMainContractsOpenedProsrok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsOpenedProsrok)).EndInit();
            this.toolsContractsOpProsrok.ResumeLayout(false);
            this.toolsContractsOpProsrok.PerformLayout();
            this.tpMainContractsClosed.ResumeLayout(false);
            this.tpMainContractsClosed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsClosed)).EndInit();
            this.toolsContractsClosed.ResumeLayout(false);
            this.toolsContractsClosed.PerformLayout();
            this.panelContractsForFilter.ResumeLayout(false);
            this.gbContractsFilter.ResumeLayout(false);
            this.gbContractsFilter.PerformLayout();
            this.tpMainOrg.ResumeLayout(false);
            this.tpMainOrg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrg)).EndInit();
            this.toolsOrg.ResumeLayout(false);
            this.toolsOrg.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusConOpAll.ResumeLayout(false);
            this.statusConOpAll.PerformLayout();
            this.statusConOpProsrok.ResumeLayout(false);
            this.statusConOpProsrok.PerformLayout();
            this.statusConClosed.ResumeLayout(false);
            this.statusConClosed.PerformLayout();
            this.statusOrg.ResumeLayout(false);
            this.statusOrg.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboOrgFilterMemberships;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOrgFilterReset;
        private System.Windows.Forms.Button btnOrgFilterApply;
        private System.Windows.Forms.ComboBox comboOrgFilterATE;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbOrgFilterOOName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbOrgFilterOOCode;
        private System.Windows.Forms.ToolStrip toolsContractsOpAll;
        private System.Windows.Forms.ToolStripButton tsbtnConOpAllView;
        private System.Windows.Forms.ToolStripButton tsbtnConOpAllRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnConOpAllExport;
        private System.Windows.Forms.ToolStripButton tsbtnConOpAllNew;
        private System.Windows.Forms.ToolStrip toolsContractsOpProsrok;
        private System.Windows.Forms.ToolStripButton tsbtnConProsrokView;
        private System.Windows.Forms.ToolStripButton tsbtnConProsrokRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnConProsrokExport;
        private System.Windows.Forms.ToolStripButton tsbtnConProsrokNew;
        private System.Windows.Forms.ToolStrip toolsContractsClosed;
        private System.Windows.Forms.ToolStripButton tsbtnConClosedRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnConClosedExport;
        private System.Windows.Forms.ToolStrip toolsOrg;
        private System.Windows.Forms.ToolStripButton tsbtnOrgView;
        private System.Windows.Forms.ToolStripButton tsbtnOrgEdit;
        private System.Windows.Forms.ToolStripButton tsbtnOrgRemove;
        private System.Windows.Forms.ToolStripButton tsbtnOrgRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnOrgExport;
        private System.Windows.Forms.ToolStripButton tsbtnOrgAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbtnConOpAllEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnConProsrokEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tsbtnConClosedView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton tsbtnConOpAllRemove;
        private System.Windows.Forms.ToolStripButton tsbtnConOpProsrokRemove;
        private System.Windows.Forms.ToolStripButton tsbtnConClosedRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem статистикаПоПредметамToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusConOpAll;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslConOpAllCount;
        private System.Windows.Forms.StatusStrip statusConOpProsrok;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tslConOpProsrokCount;
        private System.Windows.Forms.StatusStrip statusConClosed;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tslConClosedCount;
        private System.Windows.Forms.StatusStrip statusOrg;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tslOrgCount;
    }
}

