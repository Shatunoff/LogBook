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
            this.panelMainForButtonsF = new System.Windows.Forms.Panel();
            this.tlpForButtonsF = new System.Windows.Forms.TableLayoutPanel();
            this.btnFNew = new System.Windows.Forms.Button();
            this.btnFExit = new System.Windows.Forms.Button();
            this.btnFExport = new System.Windows.Forms.Button();
            this.btnFRefresh = new System.Windows.Forms.Button();
            this.btnFView = new System.Windows.Forms.Button();
            this.btnFEdit = new System.Windows.Forms.Button();
            this.btnFRemove = new System.Windows.Forms.Button();
            this.mmContractsResponsibles = new System.Windows.Forms.ToolStripMenuItem();
            this.tpMainStatistic = new System.Windows.Forms.TabPage();
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
            this.panelMainForButtonsF.SuspendLayout();
            this.tlpForButtonsF.SuspendLayout();
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
            this.mmBaseConnect.Size = new System.Drawing.Size(213, 22);
            this.mmBaseConnect.Text = "Обновить данные";
            this.mmBaseConnect.Click += new System.EventHandler(this.mmBaseConnect_Click);
            // 
            // mmBaseSettings
            // 
            this.mmBaseSettings.Name = "mmBaseSettings";
            this.mmBaseSettings.Size = new System.Drawing.Size(294, 22);
            this.mmBaseSettings.Text = "Настройки подключения";
            this.mmBaseSettings.Click += new System.EventHandler(this.mmBaseSettings_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(291, 6);
            // 
            // mmBaseExit
            // 
            this.mmBaseExit.Name = "mmBaseExit";
            this.mmBaseExit.Size = new System.Drawing.Size(294, 22);
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
            this.mmContractsNew.Size = new System.Drawing.Size(217, 22);
            this.mmContractsNew.Text = "Новый договор";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(214, 6);
            // 
            // mmContractsReturnableItems
            // 
            this.mmContractsReturnableItems.Name = "mmContractsReturnableItems";
            this.mmContractsReturnableItems.Size = new System.Drawing.Size(217, 22);
            this.mmContractsReturnableItems.Text = "Возвращаемые предметы";
            // 
            // mmContractsNotReturnableItems
            // 
            this.mmContractsNotReturnableItems.Name = "mmContractsNotReturnableItems";
            this.mmContractsNotReturnableItems.Size = new System.Drawing.Size(217, 22);
            this.mmContractsNotReturnableItems.Text = "Невозвратные предметы";
            this.mmContractsNotReturnableItems.Click += new System.EventHandler(this.mmContractsNotReturnableItems_Click);
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
            // 
            // mmOrgMemberships
            // 
            this.mmOrgMemberships.Name = "mmOrgMemberships";
            this.mmOrgMemberships.Size = new System.Drawing.Size(229, 22);
            this.mmOrgMemberships.Text = "Принадлежности...";
            // 
            // tctrlMain
            // 
            this.tctrlMain.Controls.Add(this.tpMainContracts);
            this.tctrlMain.Controls.Add(this.tpMainOrg);
            this.tctrlMain.Controls.Add(this.tpMainStatistic);
            this.tctrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlMain.Location = new System.Drawing.Point(0, 24);
            this.tctrlMain.Name = "tctrlMain";
            this.tctrlMain.SelectedIndex = 0;
            this.tctrlMain.Size = new System.Drawing.Size(979, 428);
            this.tctrlMain.TabIndex = 2;
            // 
            // tpMainContracts
            // 
            this.tpMainContracts.Controls.Add(this.tctrlMainContracts);
            this.tpMainContracts.Controls.Add(this.panelContractsForFilter);
            this.tpMainContracts.Location = new System.Drawing.Point(4, 22);
            this.tpMainContracts.Name = "tpMainContracts";
            this.tpMainContracts.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainContracts.Size = new System.Drawing.Size(971, 402);
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
            this.tctrlMainContracts.Size = new System.Drawing.Size(734, 396);
            this.tctrlMainContracts.TabIndex = 0;
            // 
            // tpMainContractsOpenedAll
            // 
            this.tpMainContractsOpenedAll.Controls.Add(this.dgvContractsOpenedAll);
            this.tpMainContractsOpenedAll.Location = new System.Drawing.Point(4, 22);
            this.tpMainContractsOpenedAll.Name = "tpMainContractsOpenedAll";
            this.tpMainContractsOpenedAll.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainContractsOpenedAll.Size = new System.Drawing.Size(726, 370);
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
            this.dgvContractsOpenedAll.Location = new System.Drawing.Point(3, 3);
            this.dgvContractsOpenedAll.Name = "dgvContractsOpenedAll";
            this.dgvContractsOpenedAll.RowHeadersVisible = false;
            this.dgvContractsOpenedAll.Size = new System.Drawing.Size(720, 364);
            this.dgvContractsOpenedAll.TabIndex = 0;
            // 
            // tpMainContractsOpenedProsrok
            // 
            this.tpMainContractsOpenedProsrok.Controls.Add(this.dgvContractsOpenedProsrok);
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
            this.dgvContractsOpenedProsrok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractsOpenedProsrok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContractsOpenedProsrok.Location = new System.Drawing.Point(3, 3);
            this.dgvContractsOpenedProsrok.Name = "dgvContractsOpenedProsrok";
            this.dgvContractsOpenedProsrok.Size = new System.Drawing.Size(720, 364);
            this.dgvContractsOpenedProsrok.TabIndex = 0;
            // 
            // tpMainContractsClosed
            // 
            this.tpMainContractsClosed.Controls.Add(this.dgvContractsClosed);
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
            this.dgvContractsClosed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractsClosed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContractsClosed.Location = new System.Drawing.Point(3, 3);
            this.dgvContractsClosed.Name = "dgvContractsClosed";
            this.dgvContractsClosed.Size = new System.Drawing.Size(720, 364);
            this.dgvContractsClosed.TabIndex = 0;
            // 
            // panelContractsForFilter
            // 
            this.panelContractsForFilter.Controls.Add(this.gbContractsFilter);
            this.panelContractsForFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContractsForFilter.Location = new System.Drawing.Point(737, 3);
            this.panelContractsForFilter.Name = "panelContractsForFilter";
            this.panelContractsForFilter.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelContractsForFilter.Size = new System.Drawing.Size(231, 396);
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
            this.gbContractsFilter.Size = new System.Drawing.Size(221, 396);
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
            this.dtpContractsFilterReturnDO.Location = new System.Drawing.Point(34, 336);
            this.dtpContractsFilterReturnDO.Name = "dtpContractsFilterReturnDO";
            this.dtpContractsFilterReturnDO.Size = new System.Drawing.Size(178, 20);
            this.dtpContractsFilterReturnDO.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "До:";
            // 
            // dtpContractsFilterReturnOT
            // 
            this.dtpContractsFilterReturnOT.Location = new System.Drawing.Point(32, 310);
            this.dtpContractsFilterReturnOT.Name = "dtpContractsFilterReturnOT";
            this.dtpContractsFilterReturnOT.Size = new System.Drawing.Size(180, 20);
            this.dtpContractsFilterReturnOT.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 316);
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
            this.dtpContractsFilterIssueOT.Location = new System.Drawing.Point(35, 235);
            this.dtpContractsFilterIssueOT.Name = "dtpContractsFilterIssueOT";
            this.dtpContractsFilterIssueOT.Size = new System.Drawing.Size(180, 20);
            this.dtpContractsFilterIssueOT.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 241);
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
            this.dtpContractsFilterSingingOT.Location = new System.Drawing.Point(35, 160);
            this.dtpContractsFilterSingingOT.Name = "dtpContractsFilterSingingOT";
            this.dtpContractsFilterSingingOT.Size = new System.Drawing.Size(180, 20);
            this.dtpContractsFilterSingingOT.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 166);
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
            this.tpMainOrg.Location = new System.Drawing.Point(4, 22);
            this.tpMainOrg.Name = "tpMainOrg";
            this.tpMainOrg.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainOrg.Size = new System.Drawing.Size(971, 402);
            this.tpMainOrg.TabIndex = 1;
            this.tpMainOrg.Text = "Организации";
            this.tpMainOrg.UseVisualStyleBackColor = true;
            // 
            // panelMainForButtonsF
            // 
            this.panelMainForButtonsF.Controls.Add(this.tlpForButtonsF);
            this.panelMainForButtonsF.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainForButtonsF.Location = new System.Drawing.Point(0, 452);
            this.panelMainForButtonsF.Name = "panelMainForButtonsF";
            this.panelMainForButtonsF.Size = new System.Drawing.Size(979, 33);
            this.panelMainForButtonsF.TabIndex = 3;
            // 
            // tlpForButtonsF
            // 
            this.tlpForButtonsF.ColumnCount = 7;
            this.tlpForButtonsF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpForButtonsF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpForButtonsF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpForButtonsF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpForButtonsF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpForButtonsF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpForButtonsF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpForButtonsF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpForButtonsF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpForButtonsF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpForButtonsF.Controls.Add(this.btnFNew, 4, 0);
            this.tlpForButtonsF.Controls.Add(this.btnFExit, 6, 0);
            this.tlpForButtonsF.Controls.Add(this.btnFExport, 3, 0);
            this.tlpForButtonsF.Controls.Add(this.btnFRefresh, 2, 0);
            this.tlpForButtonsF.Controls.Add(this.btnFView, 0, 0);
            this.tlpForButtonsF.Controls.Add(this.btnFEdit, 1, 0);
            this.tlpForButtonsF.Controls.Add(this.btnFRemove, 5, 0);
            this.tlpForButtonsF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForButtonsF.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpForButtonsF.Location = new System.Drawing.Point(0, 0);
            this.tlpForButtonsF.Name = "tlpForButtonsF";
            this.tlpForButtonsF.RowCount = 1;
            this.tlpForButtonsF.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForButtonsF.Size = new System.Drawing.Size(979, 33);
            this.tlpForButtonsF.TabIndex = 0;
            // 
            // btnFNew
            // 
            this.btnFNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFNew.Location = new System.Drawing.Point(559, 3);
            this.btnFNew.Name = "btnFNew";
            this.btnFNew.Size = new System.Drawing.Size(133, 27);
            this.btnFNew.TabIndex = 2;
            this.btnFNew.Text = "F7 Создание";
            this.btnFNew.UseVisualStyleBackColor = true;
            // 
            // btnFExit
            // 
            this.btnFExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFExit.Location = new System.Drawing.Point(837, 3);
            this.btnFExit.Name = "btnFExit";
            this.btnFExit.Size = new System.Drawing.Size(139, 27);
            this.btnFExit.TabIndex = 2;
            this.btnFExit.Text = "Alt+F4 Выход";
            this.btnFExit.UseVisualStyleBackColor = true;
            // 
            // btnFExport
            // 
            this.btnFExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFExport.Location = new System.Drawing.Point(420, 3);
            this.btnFExport.Name = "btnFExport";
            this.btnFExport.Size = new System.Drawing.Size(133, 27);
            this.btnFExport.TabIndex = 2;
            this.btnFExport.Text = "F6 Экспорт";
            this.btnFExport.UseVisualStyleBackColor = true;
            // 
            // btnFRefresh
            // 
            this.btnFRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFRefresh.Location = new System.Drawing.Point(281, 3);
            this.btnFRefresh.Name = "btnFRefresh";
            this.btnFRefresh.Size = new System.Drawing.Size(133, 27);
            this.btnFRefresh.TabIndex = 1;
            this.btnFRefresh.Text = "F5 Обновление";
            this.btnFRefresh.UseVisualStyleBackColor = true;
            // 
            // btnFView
            // 
            this.btnFView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFView.Location = new System.Drawing.Point(3, 3);
            this.btnFView.Name = "btnFView";
            this.btnFView.Size = new System.Drawing.Size(133, 27);
            this.btnFView.TabIndex = 0;
            this.btnFView.Text = "F3 Просмотр";
            this.btnFView.UseVisualStyleBackColor = true;
            // 
            // btnFEdit
            // 
            this.btnFEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFEdit.Location = new System.Drawing.Point(142, 3);
            this.btnFEdit.Name = "btnFEdit";
            this.btnFEdit.Size = new System.Drawing.Size(133, 27);
            this.btnFEdit.TabIndex = 1;
            this.btnFEdit.Text = "F4 Правка";
            this.btnFEdit.UseVisualStyleBackColor = true;
            // 
            // btnFRemove
            // 
            this.btnFRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFRemove.Location = new System.Drawing.Point(698, 3);
            this.btnFRemove.Name = "btnFRemove";
            this.btnFRemove.Size = new System.Drawing.Size(133, 27);
            this.btnFRemove.TabIndex = 2;
            this.btnFRemove.Text = "F8 Удаление";
            this.btnFRemove.UseVisualStyleBackColor = true;
            // 
            // mmContractsResponsibles
            // 
            this.mmContractsResponsibles.Name = "mmContractsResponsibles";
            this.mmContractsResponsibles.Size = new System.Drawing.Size(217, 22);
            this.mmContractsResponsibles.Text = "Ответственные лица";
            // 
            // tpMainStatistic
            // 
            this.tpMainStatistic.Location = new System.Drawing.Point(4, 22);
            this.tpMainStatistic.Name = "tpMainStatistic";
            this.tpMainStatistic.Size = new System.Drawing.Size(971, 402);
            this.tpMainStatistic.TabIndex = 2;
            this.tpMainStatistic.Text = "Статистика";
            this.tpMainStatistic.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 485);
            this.Controls.Add(this.tctrlMain);
            this.Controls.Add(this.panelMainForButtonsF);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Журнал учета";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tctrlMain.ResumeLayout(false);
            this.tpMainContracts.ResumeLayout(false);
            this.tctrlMainContracts.ResumeLayout(false);
            this.tpMainContractsOpenedAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsOpenedAll)).EndInit();
            this.tpMainContractsOpenedProsrok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsOpenedProsrok)).EndInit();
            this.tpMainContractsClosed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsClosed)).EndInit();
            this.panelContractsForFilter.ResumeLayout(false);
            this.gbContractsFilter.ResumeLayout(false);
            this.gbContractsFilter.PerformLayout();
            this.panelMainForButtonsF.ResumeLayout(false);
            this.tlpForButtonsF.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelMainForButtonsF;
        private System.Windows.Forms.TableLayoutPanel tlpForButtonsF;
        private System.Windows.Forms.Button btnFView;
        private System.Windows.Forms.Button btnFEdit;
        private System.Windows.Forms.Button btnFExport;
        private System.Windows.Forms.Button btnFRefresh;
        private System.Windows.Forms.Button btnFExit;
        private System.Windows.Forms.Button btnFRemove;
        private System.Windows.Forms.Button btnFNew;
        private System.Windows.Forms.DataGridView dgvContractsOpenedAll;
        private System.Windows.Forms.DataGridView dgvContractsOpenedProsrok;
        private System.Windows.Forms.TabPage tpMainContractsClosed;
        private System.Windows.Forms.DataGridView dgvContractsClosed;
        private System.Windows.Forms.ToolStripMenuItem mmContractsResponsibles;
        private System.Windows.Forms.TabPage tpMainStatistic;
    }
}

