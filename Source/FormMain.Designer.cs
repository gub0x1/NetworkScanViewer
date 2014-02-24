﻿namespace woanware
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveResults = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveResultsCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveResultsXml = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveHostSummary = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveHostSummaryCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSepOne = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpSepOne = new System.Windows.Forms.ToolStripSeparator();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.lblFilterType = new System.Windows.Forms.ToolStripLabel();
            this.cboFilterType = new System.Windows.Forms.ToolStripComboBox();
            this.lblFilterIp = new System.Windows.Forms.ToolStripLabel();
            this.cboFilterIp = new System.Windows.Forms.ToolStripComboBox();
            this.lblFilterPort = new System.Windows.Forms.ToolStripLabel();
            this.cboFilterPort = new System.Windows.Forms.ToolStripComboBox();
            this.lblFilterService = new System.Windows.Forms.ToolStripLabel();
            this.cboFilterService = new System.Windows.Forms.ToolStripComboBox();
            this.lblFilterSearch = new System.Windows.Forms.ToolStripLabel();
            this.txtFilterSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnResultsLastPage = new System.Windows.Forms.Button();
            this.btnResultsNextPage = new System.Windows.Forms.Button();
            this.btnResultsPreviousPage = new System.Windows.Forms.Button();
            this.btnResultsFirstPage = new System.Windows.Forms.Button();
            this.listResults = new BrightIdeasSoftware.FastObjectListView();
            this.colResultsType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colResultsIpAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colResultsHostName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colResultsPort = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colResultsProtocol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colResultsState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colResultsService = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colResultsSeverity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colResultsSynopsis = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colResultsPluginId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colResultsPluginName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colResultsPluginFamily = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colResultsId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ctxMenuResults = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMenuResultsCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsCopyIpAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsCopyPort = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsCopyService = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsSepOne = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMenuResultsFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsFilterType = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsFilterHost = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsFilterPort = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsFilterProtocol = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsFilterService = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsFilterSeverity = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsFilterPluginId = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsFilterPluginFamily = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsFilterPluginName = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsFilterProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsFilterVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResultsSepTwo = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMenuResultsIgnorePlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMenuResultsClearFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.tabFilters = new System.Windows.Forms.TabPage();
            this.cboFilterExploitAvailable = new System.Windows.Forms.ComboBox();
            this.lblExploitAvailable = new System.Windows.Forms.Label();
            this.cboFilterHostName = new System.Windows.Forms.ComboBox();
            this.lblFilterHost = new System.Windows.Forms.Label();
            this.cboFilterState = new System.Windows.Forms.ComboBox();
            this.lblFilterState = new System.Windows.Forms.Label();
            this.lblFilterSeverity = new System.Windows.Forms.Label();
            this.cboFilterSeverity = new System.Windows.Forms.ComboBox();
            this.cboFilterVersion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboFilterProduct = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboFilterPluginFamilyName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboFilterPluginName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFilterPluginId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFilterProtocol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabHostSummary = new System.Windows.Forms.TabPage();
            this.listHostSummary = new BrightIdeasSoftware.FastObjectListView();
            this.colHsIpAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHsNetBiosName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHsDnsName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHsMacAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHsOs = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHsSystemType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHsPorts = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHsNumCritical = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHsNumHigh = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHsNumMed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHsNumLow = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHsStartTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHsEndTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ctxMenuSummary = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMenuSummaryCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuSummaryCopyIp = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuSummaryCopyNetbios = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuSummaryCopyDns = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuSummaryCopyMac = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuSummaryCopyOs = new System.Windows.Forms.ToolStripMenuItem();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listResults)).BeginInit();
            this.ctxMenuResults.SuspendLayout();
            this.tabFilters.SuspendLayout();
            this.tabHostSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listHostSummary)).BeginInit();
            this.ctxMenuSummary.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuTools,
            this.menuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSepOne,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(103, 22);
            this.menuFileOpen.Text = "Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileSaveResults,
            this.menuFileSaveHostSummary});
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(103, 22);
            this.menuFileSave.Text = "Save";
            // 
            // menuFileSaveResults
            // 
            this.menuFileSaveResults.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileSaveResultsCsv,
            this.menuFileSaveResultsXml});
            this.menuFileSaveResults.Name = "menuFileSaveResults";
            this.menuFileSaveResults.Size = new System.Drawing.Size(153, 22);
            this.menuFileSaveResults.Text = "Results";
            // 
            // menuFileSaveResultsCsv
            // 
            this.menuFileSaveResultsCsv.Name = "menuFileSaveResultsCsv";
            this.menuFileSaveResultsCsv.Size = new System.Drawing.Size(98, 22);
            this.menuFileSaveResultsCsv.Text = "CSV";
            this.menuFileSaveResultsCsv.Click += new System.EventHandler(this.menuFileSaveResultsCsv_Click);
            // 
            // menuFileSaveResultsXml
            // 
            this.menuFileSaveResultsXml.Name = "menuFileSaveResultsXml";
            this.menuFileSaveResultsXml.Size = new System.Drawing.Size(98, 22);
            this.menuFileSaveResultsXml.Text = "XML";
            this.menuFileSaveResultsXml.Visible = false;
            this.menuFileSaveResultsXml.Click += new System.EventHandler(this.menuFileSaveResultsXml_Click);
            // 
            // menuFileSaveHostSummary
            // 
            this.menuFileSaveHostSummary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileSaveHostSummaryCsv});
            this.menuFileSaveHostSummary.Name = "menuFileSaveHostSummary";
            this.menuFileSaveHostSummary.Size = new System.Drawing.Size(153, 22);
            this.menuFileSaveHostSummary.Text = "Host Summary";
            // 
            // menuFileSaveHostSummaryCsv
            // 
            this.menuFileSaveHostSummaryCsv.Name = "menuFileSaveHostSummaryCsv";
            this.menuFileSaveHostSummaryCsv.Size = new System.Drawing.Size(95, 22);
            this.menuFileSaveHostSummaryCsv.Text = "CSV";
            this.menuFileSaveHostSummaryCsv.Click += new System.EventHandler(this.menuFileSaveHostSummaryCsv_Click);
            // 
            // menuFileSepOne
            // 
            this.menuFileSepOne.Name = "menuFileSepOne";
            this.menuFileSepOne.Size = new System.Drawing.Size(100, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(103, 22);
            this.menuFileExit.Text = "&Exit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuTools
            // 
            this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolsOptions});
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(48, 20);
            this.menuTools.Text = "&Tools";
            // 
            // menuToolsOptions
            // 
            this.menuToolsOptions.Name = "menuToolsOptions";
            this.menuToolsOptions.Size = new System.Drawing.Size(116, 22);
            this.menuToolsOptions.Text = "Options";
            this.menuToolsOptions.Click += new System.EventHandler(this.menuToolsOptions_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpHelp,
            this.menuHelpSepOne,
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // menuHelpHelp
            // 
            this.menuHelpHelp.Name = "menuHelpHelp";
            this.menuHelpHelp.Size = new System.Drawing.Size(107, 22);
            this.menuHelpHelp.Text = "&Help";
            this.menuHelpHelp.Click += new System.EventHandler(this.menuHelpHelp_Click);
            // 
            // menuHelpSepOne
            // 
            this.menuHelpSepOne.Name = "menuHelpSepOne";
            this.menuHelpSepOne.Size = new System.Drawing.Size(104, 6);
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.menuHelpAbout.Text = "&About";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 363);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFilterType,
            this.cboFilterType,
            this.lblFilterIp,
            this.cboFilterIp,
            this.lblFilterPort,
            this.cboFilterPort,
            this.lblFilterService,
            this.cboFilterService,
            this.lblFilterSearch,
            this.txtFilterSearch,
            this.toolBtnSearch});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(1021, 25);
            this.toolStrip.TabIndex = 2;
            // 
            // lblFilterType
            // 
            this.lblFilterType.Name = "lblFilterType";
            this.lblFilterType.Size = new System.Drawing.Size(33, 22);
            this.lblFilterType.Text = "Type";
            // 
            // cboFilterType
            // 
            this.cboFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterType.Name = "cboFilterType";
            this.cboFilterType.Size = new System.Drawing.Size(140, 25);
            this.cboFilterType.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // lblFilterIp
            // 
            this.lblFilterIp.Name = "lblFilterIp";
            this.lblFilterIp.Size = new System.Drawing.Size(17, 22);
            this.lblFilterIp.Text = "IP";
            // 
            // cboFilterIp
            // 
            this.cboFilterIp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterIp.Name = "cboFilterIp";
            this.cboFilterIp.Size = new System.Drawing.Size(140, 25);
            this.cboFilterIp.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // lblFilterPort
            // 
            this.lblFilterPort.Name = "lblFilterPort";
            this.lblFilterPort.Size = new System.Drawing.Size(29, 22);
            this.lblFilterPort.Text = "Port";
            // 
            // cboFilterPort
            // 
            this.cboFilterPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterPort.Name = "cboFilterPort";
            this.cboFilterPort.Size = new System.Drawing.Size(75, 25);
            this.cboFilterPort.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // lblFilterService
            // 
            this.lblFilterService.Name = "lblFilterService";
            this.lblFilterService.Size = new System.Drawing.Size(44, 22);
            this.lblFilterService.Text = "Service";
            // 
            // cboFilterService
            // 
            this.cboFilterService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterService.Name = "cboFilterService";
            this.cboFilterService.Size = new System.Drawing.Size(140, 25);
            this.cboFilterService.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // lblFilterSearch
            // 
            this.lblFilterSearch.Name = "lblFilterSearch";
            this.lblFilterSearch.Size = new System.Drawing.Size(42, 22);
            this.lblFilterSearch.Text = "Search";
            // 
            // txtFilterSearch
            // 
            this.txtFilterSearch.Name = "txtFilterSearch";
            this.txtFilterSearch.Size = new System.Drawing.Size(233, 25);
            this.txtFilterSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterSearch_KeyDown);
            // 
            // toolBtnSearch
            // 
            this.toolBtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnSearch.Image")));
            this.toolBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSearch.Name = "toolBtnSearch";
            this.toolBtnSearch.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSearch.ToolTipText = "Search";
            this.toolBtnSearch.Click += new System.EventHandler(this.toolBtnSearch_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select results directory";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabResults);
            this.tabControl.Controls.Add(this.tabFilters);
            this.tabControl.Controls.Add(this.tabHostSummary);
            this.tabControl.Controls.Add(this.tabLog);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 49);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1021, 314);
            this.tabControl.TabIndex = 3;
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.splitContainer);
            this.tabResults.Location = new System.Drawing.Point(4, 24);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabResults.Size = new System.Drawing.Size(1013, 286);
            this.tabResults.TabIndex = 0;
            this.tabResults.Text = "Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnResultsLastPage);
            this.splitContainer.Panel1.Controls.Add(this.btnResultsNextPage);
            this.splitContainer.Panel1.Controls.Add(this.btnResultsPreviousPage);
            this.splitContainer.Panel1.Controls.Add(this.btnResultsFirstPage);
            this.splitContainer.Panel1.Controls.Add(this.listResults);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.txtData);
            this.splitContainer.Size = new System.Drawing.Size(1007, 280);
            this.splitContainer.SplitterDistance = 606;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 0;
            // 
            // btnResultsLastPage
            // 
            this.btnResultsLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResultsLastPage.Image = ((System.Drawing.Image)(resources.GetObject("btnResultsLastPage.Image")));
            this.btnResultsLastPage.Location = new System.Drawing.Point(574, 254);
            this.btnResultsLastPage.Name = "btnResultsLastPage";
            this.btnResultsLastPage.Size = new System.Drawing.Size(33, 27);
            this.btnResultsLastPage.TabIndex = 9;
            this.btnResultsLastPage.UseVisualStyleBackColor = true;
            this.btnResultsLastPage.Click += new System.EventHandler(this.btnResultsLastPage_Click);
            // 
            // btnResultsNextPage
            // 
            this.btnResultsNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResultsNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnResultsNextPage.Image")));
            this.btnResultsNextPage.Location = new System.Drawing.Point(539, 254);
            this.btnResultsNextPage.Name = "btnResultsNextPage";
            this.btnResultsNextPage.Size = new System.Drawing.Size(33, 27);
            this.btnResultsNextPage.TabIndex = 8;
            this.btnResultsNextPage.UseVisualStyleBackColor = true;
            this.btnResultsNextPage.Click += new System.EventHandler(this.btnResultsNextPage_Click);
            // 
            // btnResultsPreviousPage
            // 
            this.btnResultsPreviousPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResultsPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("btnResultsPreviousPage.Image")));
            this.btnResultsPreviousPage.Location = new System.Drawing.Point(34, 254);
            this.btnResultsPreviousPage.Name = "btnResultsPreviousPage";
            this.btnResultsPreviousPage.Size = new System.Drawing.Size(33, 27);
            this.btnResultsPreviousPage.TabIndex = 7;
            this.btnResultsPreviousPage.UseVisualStyleBackColor = true;
            this.btnResultsPreviousPage.Click += new System.EventHandler(this.btnResultsPreviousPage_Click);
            // 
            // btnResultsFirstPage
            // 
            this.btnResultsFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResultsFirstPage.Image = ((System.Drawing.Image)(resources.GetObject("btnResultsFirstPage.Image")));
            this.btnResultsFirstPage.Location = new System.Drawing.Point(-1, 254);
            this.btnResultsFirstPage.Name = "btnResultsFirstPage";
            this.btnResultsFirstPage.Size = new System.Drawing.Size(33, 27);
            this.btnResultsFirstPage.TabIndex = 6;
            this.btnResultsFirstPage.UseVisualStyleBackColor = true;
            this.btnResultsFirstPage.Click += new System.EventHandler(this.btnResultsFirstPage_Click);
            // 
            // listResults
            // 
            this.listResults.AllColumns.Add(this.colResultsType);
            this.listResults.AllColumns.Add(this.colResultsIpAddress);
            this.listResults.AllColumns.Add(this.colResultsHostName);
            this.listResults.AllColumns.Add(this.colResultsPort);
            this.listResults.AllColumns.Add(this.colResultsProtocol);
            this.listResults.AllColumns.Add(this.colResultsState);
            this.listResults.AllColumns.Add(this.colResultsService);
            this.listResults.AllColumns.Add(this.colResultsSeverity);
            this.listResults.AllColumns.Add(this.colResultsSynopsis);
            this.listResults.AllColumns.Add(this.colResultsPluginId);
            this.listResults.AllColumns.Add(this.colResultsPluginName);
            this.listResults.AllColumns.Add(this.colResultsPluginFamily);
            this.listResults.AllColumns.Add(this.colResultsId);
            this.listResults.AllowColumnReorder = true;
            this.listResults.AlternateRowBackColor = System.Drawing.Color.LightGray;
            this.listResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colResultsType,
            this.colResultsIpAddress,
            this.colResultsHostName,
            this.colResultsPort,
            this.colResultsProtocol,
            this.colResultsState,
            this.colResultsService,
            this.colResultsSeverity,
            this.colResultsSynopsis,
            this.colResultsPluginId,
            this.colResultsPluginName,
            this.colResultsPluginFamily});
            this.listResults.ContextMenuStrip = this.ctxMenuResults;
            this.listResults.FullRowSelect = true;
            this.listResults.HasCollapsibleGroups = false;
            this.listResults.HideSelection = false;
            this.listResults.Location = new System.Drawing.Point(0, 0);
            this.listResults.Name = "listResults";
            this.listResults.ShowGroups = false;
            this.listResults.Size = new System.Drawing.Size(606, 247);
            this.listResults.TabIndex = 0;
            this.listResults.UseAlternatingBackColors = true;
            this.listResults.UseCompatibleStateImageBehavior = false;
            this.listResults.UseExplorerTheme = true;
            this.listResults.View = System.Windows.Forms.View.Details;
            this.listResults.VirtualMode = true;
            this.listResults.SelectedIndexChanged += new System.EventHandler(this.listResults_SelectedIndexChanged);
            // 
            // colResultsType
            // 
            this.colResultsType.AspectName = "Type";
            this.colResultsType.CellPadding = null;
            this.colResultsType.IsEditable = false;
            this.colResultsType.Text = "Type";
            // 
            // colResultsIpAddress
            // 
            this.colResultsIpAddress.AspectName = "IpAddress";
            this.colResultsIpAddress.CellPadding = null;
            this.colResultsIpAddress.IsEditable = false;
            this.colResultsIpAddress.Text = "IP Address";
            this.colResultsIpAddress.Width = 100;
            // 
            // colResultsHostName
            // 
            this.colResultsHostName.AspectName = "HostName";
            this.colResultsHostName.CellPadding = null;
            this.colResultsHostName.Text = "Host Name";
            // 
            // colResultsPort
            // 
            this.colResultsPort.AspectName = "Port";
            this.colResultsPort.CellPadding = null;
            this.colResultsPort.IsEditable = false;
            this.colResultsPort.Text = "Port";
            // 
            // colResultsProtocol
            // 
            this.colResultsProtocol.AspectName = "Protocol";
            this.colResultsProtocol.CellPadding = null;
            this.colResultsProtocol.IsEditable = false;
            this.colResultsProtocol.Text = "Protocol";
            // 
            // colResultsState
            // 
            this.colResultsState.AspectName = "State";
            this.colResultsState.CellPadding = null;
            this.colResultsState.Text = "State";
            // 
            // colResultsService
            // 
            this.colResultsService.AspectName = "Service";
            this.colResultsService.CellPadding = null;
            this.colResultsService.IsEditable = false;
            this.colResultsService.Text = "Service";
            this.colResultsService.Width = 100;
            // 
            // colResultsSeverity
            // 
            this.colResultsSeverity.AspectName = "Severity";
            this.colResultsSeverity.CellPadding = null;
            this.colResultsSeverity.IsEditable = false;
            this.colResultsSeverity.Text = "Severity";
            // 
            // colResultsSynopsis
            // 
            this.colResultsSynopsis.AspectName = "Synopsis";
            this.colResultsSynopsis.CellPadding = null;
            this.colResultsSynopsis.FillsFreeSpace = true;
            this.colResultsSynopsis.IsEditable = false;
            this.colResultsSynopsis.Text = "Synopsis";
            this.colResultsSynopsis.Width = 100;
            // 
            // colResultsPluginId
            // 
            this.colResultsPluginId.AspectName = "PluginId";
            this.colResultsPluginId.CellPadding = null;
            this.colResultsPluginId.IsEditable = false;
            this.colResultsPluginId.Text = "Plugin ID";
            this.colResultsPluginId.Width = 100;
            // 
            // colResultsPluginName
            // 
            this.colResultsPluginName.AspectName = "PluginName";
            this.colResultsPluginName.CellPadding = null;
            this.colResultsPluginName.IsEditable = false;
            this.colResultsPluginName.Text = "Plugin Name";
            this.colResultsPluginName.Width = 100;
            // 
            // colResultsPluginFamily
            // 
            this.colResultsPluginFamily.AspectName = "PluginFamily";
            this.colResultsPluginFamily.CellPadding = null;
            this.colResultsPluginFamily.IsEditable = false;
            this.colResultsPluginFamily.Text = "Plugin Family";
            this.colResultsPluginFamily.Width = 100;
            // 
            // colResultsId
            // 
            this.colResultsId.AspectName = "Id";
            this.colResultsId.CellPadding = null;
            this.colResultsId.IsVisible = false;
            this.colResultsId.Text = "ID";
            // 
            // ctxMenuResults
            // 
            this.ctxMenuResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuResultsCopy,
            this.ctxMenuResultsSepOne,
            this.ctxMenuResultsFilter,
            this.ctxMenuResultsSepTwo,
            this.ctxMenuResultsIgnorePlugin,
            this.toolStripMenuItem2,
            this.ctxMenuResultsClearFilters});
            this.ctxMenuResults.Name = "ctxMenuResults";
            this.ctxMenuResults.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctxMenuResults.Size = new System.Drawing.Size(146, 110);
            this.ctxMenuResults.Opening += new System.ComponentModel.CancelEventHandler(this.ctxMenuResults_Opening);
            // 
            // ctxMenuResultsCopy
            // 
            this.ctxMenuResultsCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuResultsCopyIpAddress,
            this.ctxMenuResultsCopyPort,
            this.ctxMenuResultsCopyService});
            this.ctxMenuResultsCopy.Name = "ctxMenuResultsCopy";
            this.ctxMenuResultsCopy.Size = new System.Drawing.Size(145, 22);
            this.ctxMenuResultsCopy.Text = "Copy";
            // 
            // ctxMenuResultsCopyIpAddress
            // 
            this.ctxMenuResultsCopyIpAddress.Name = "ctxMenuResultsCopyIpAddress";
            this.ctxMenuResultsCopyIpAddress.Size = new System.Drawing.Size(129, 22);
            this.ctxMenuResultsCopyIpAddress.Text = "IP Address";
            this.ctxMenuResultsCopyIpAddress.Click += new System.EventHandler(this.ctxMenuResultsCopyIpAddress_Click);
            // 
            // ctxMenuResultsCopyPort
            // 
            this.ctxMenuResultsCopyPort.Name = "ctxMenuResultsCopyPort";
            this.ctxMenuResultsCopyPort.Size = new System.Drawing.Size(129, 22);
            this.ctxMenuResultsCopyPort.Text = "Port";
            this.ctxMenuResultsCopyPort.Click += new System.EventHandler(this.ctxMenuResultsCopyPort_Click);
            // 
            // ctxMenuResultsCopyService
            // 
            this.ctxMenuResultsCopyService.Name = "ctxMenuResultsCopyService";
            this.ctxMenuResultsCopyService.Size = new System.Drawing.Size(129, 22);
            this.ctxMenuResultsCopyService.Text = "Service";
            this.ctxMenuResultsCopyService.Click += new System.EventHandler(this.ctxMenuResultsCopyService_Click);
            // 
            // ctxMenuResultsSepOne
            // 
            this.ctxMenuResultsSepOne.Name = "ctxMenuResultsSepOne";
            this.ctxMenuResultsSepOne.Size = new System.Drawing.Size(142, 6);
            // 
            // ctxMenuResultsFilter
            // 
            this.ctxMenuResultsFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuResultsFilterType,
            this.ctxMenuResultsFilterHost,
            this.ctxMenuResultsFilterPort,
            this.ctxMenuResultsFilterProtocol,
            this.ctxMenuResultsFilterService,
            this.ctxMenuResultsFilterSeverity,
            this.ctxMenuResultsFilterPluginId,
            this.ctxMenuResultsFilterPluginFamily,
            this.ctxMenuResultsFilterPluginName,
            this.ctxMenuResultsFilterProduct,
            this.ctxMenuResultsFilterVersion});
            this.ctxMenuResultsFilter.Name = "ctxMenuResultsFilter";
            this.ctxMenuResultsFilter.Size = new System.Drawing.Size(145, 22);
            this.ctxMenuResultsFilter.Text = "Filter";
            // 
            // ctxMenuResultsFilterType
            // 
            this.ctxMenuResultsFilterType.Name = "ctxMenuResultsFilterType";
            this.ctxMenuResultsFilterType.Size = new System.Drawing.Size(146, 22);
            this.ctxMenuResultsFilterType.Text = "Type";
            this.ctxMenuResultsFilterType.Click += new System.EventHandler(this.ctxMenuResultsFilterType_Click);
            // 
            // ctxMenuResultsFilterHost
            // 
            this.ctxMenuResultsFilterHost.Name = "ctxMenuResultsFilterHost";
            this.ctxMenuResultsFilterHost.Size = new System.Drawing.Size(146, 22);
            this.ctxMenuResultsFilterHost.Text = "Host";
            this.ctxMenuResultsFilterHost.Click += new System.EventHandler(this.ctxMenuResultsFilterHost_Click);
            // 
            // ctxMenuResultsFilterPort
            // 
            this.ctxMenuResultsFilterPort.Name = "ctxMenuResultsFilterPort";
            this.ctxMenuResultsFilterPort.Size = new System.Drawing.Size(146, 22);
            this.ctxMenuResultsFilterPort.Text = "Port";
            this.ctxMenuResultsFilterPort.Click += new System.EventHandler(this.ctxMenuResultsFilterPort_Click);
            // 
            // ctxMenuResultsFilterProtocol
            // 
            this.ctxMenuResultsFilterProtocol.Name = "ctxMenuResultsFilterProtocol";
            this.ctxMenuResultsFilterProtocol.Size = new System.Drawing.Size(146, 22);
            this.ctxMenuResultsFilterProtocol.Text = "Protocol";
            this.ctxMenuResultsFilterProtocol.Click += new System.EventHandler(this.ctxMenuResultsFilterProtocol_Click);
            // 
            // ctxMenuResultsFilterService
            // 
            this.ctxMenuResultsFilterService.Name = "ctxMenuResultsFilterService";
            this.ctxMenuResultsFilterService.Size = new System.Drawing.Size(146, 22);
            this.ctxMenuResultsFilterService.Text = "Service";
            this.ctxMenuResultsFilterService.Click += new System.EventHandler(this.ctxMenuResultsFilterService_Click);
            // 
            // ctxMenuResultsFilterSeverity
            // 
            this.ctxMenuResultsFilterSeverity.Name = "ctxMenuResultsFilterSeverity";
            this.ctxMenuResultsFilterSeverity.Size = new System.Drawing.Size(146, 22);
            this.ctxMenuResultsFilterSeverity.Text = "Severity";
            this.ctxMenuResultsFilterSeverity.Click += new System.EventHandler(this.ctxMenuResultsFilterSeverity_Click);
            // 
            // ctxMenuResultsFilterPluginId
            // 
            this.ctxMenuResultsFilterPluginId.Name = "ctxMenuResultsFilterPluginId";
            this.ctxMenuResultsFilterPluginId.Size = new System.Drawing.Size(146, 22);
            this.ctxMenuResultsFilterPluginId.Text = "Plugin ID";
            this.ctxMenuResultsFilterPluginId.Click += new System.EventHandler(this.ctxMenuResultsFilterPluginId_Click);
            // 
            // ctxMenuResultsFilterPluginFamily
            // 
            this.ctxMenuResultsFilterPluginFamily.Name = "ctxMenuResultsFilterPluginFamily";
            this.ctxMenuResultsFilterPluginFamily.Size = new System.Drawing.Size(146, 22);
            this.ctxMenuResultsFilterPluginFamily.Text = "Plugin Family";
            this.ctxMenuResultsFilterPluginFamily.Click += new System.EventHandler(this.ctxMenuResultsFilterPluginFamily_Click);
            // 
            // ctxMenuResultsFilterPluginName
            // 
            this.ctxMenuResultsFilterPluginName.Name = "ctxMenuResultsFilterPluginName";
            this.ctxMenuResultsFilterPluginName.Size = new System.Drawing.Size(146, 22);
            this.ctxMenuResultsFilterPluginName.Text = "Plugin Name";
            this.ctxMenuResultsFilterPluginName.Click += new System.EventHandler(this.ctxMenuResultsFilterPluginName_Click);
            // 
            // ctxMenuResultsFilterProduct
            // 
            this.ctxMenuResultsFilterProduct.Name = "ctxMenuResultsFilterProduct";
            this.ctxMenuResultsFilterProduct.Size = new System.Drawing.Size(146, 22);
            this.ctxMenuResultsFilterProduct.Text = "Product";
            this.ctxMenuResultsFilterProduct.Click += new System.EventHandler(this.ctxMenuResultsFilterProduct_Click);
            // 
            // ctxMenuResultsFilterVersion
            // 
            this.ctxMenuResultsFilterVersion.Name = "ctxMenuResultsFilterVersion";
            this.ctxMenuResultsFilterVersion.Size = new System.Drawing.Size(146, 22);
            this.ctxMenuResultsFilterVersion.Text = "Version";
            this.ctxMenuResultsFilterVersion.Click += new System.EventHandler(this.ctxMenuResultsFilterVersion_Click);
            // 
            // ctxMenuResultsSepTwo
            // 
            this.ctxMenuResultsSepTwo.Name = "ctxMenuResultsSepTwo";
            this.ctxMenuResultsSepTwo.Size = new System.Drawing.Size(142, 6);
            // 
            // ctxMenuResultsIgnorePlugin
            // 
            this.ctxMenuResultsIgnorePlugin.Name = "ctxMenuResultsIgnorePlugin";
            this.ctxMenuResultsIgnorePlugin.Size = new System.Drawing.Size(145, 22);
            this.ctxMenuResultsIgnorePlugin.Text = "Ignore Plugin";
            this.ctxMenuResultsIgnorePlugin.Click += new System.EventHandler(this.ctxMenuResultsIgnorePlugin_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(142, 6);
            // 
            // ctxMenuResultsClearFilters
            // 
            this.ctxMenuResultsClearFilters.Name = "ctxMenuResultsClearFilters";
            this.ctxMenuResultsClearFilters.Size = new System.Drawing.Size(145, 22);
            this.ctxMenuResultsClearFilters.Text = "Clear Filters";
            this.ctxMenuResultsClearFilters.Click += new System.EventHandler(this.ctxMenuResultsClearFilters_Click);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.White;
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(0, 0);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtData.Size = new System.Drawing.Size(396, 280);
            this.txtData.TabIndex = 8;
            this.txtData.Text = "";
            // 
            // tabFilters
            // 
            this.tabFilters.Controls.Add(this.cboFilterExploitAvailable);
            this.tabFilters.Controls.Add(this.lblExploitAvailable);
            this.tabFilters.Controls.Add(this.cboFilterHostName);
            this.tabFilters.Controls.Add(this.lblFilterHost);
            this.tabFilters.Controls.Add(this.cboFilterState);
            this.tabFilters.Controls.Add(this.lblFilterState);
            this.tabFilters.Controls.Add(this.lblFilterSeverity);
            this.tabFilters.Controls.Add(this.cboFilterSeverity);
            this.tabFilters.Controls.Add(this.cboFilterVersion);
            this.tabFilters.Controls.Add(this.label9);
            this.tabFilters.Controls.Add(this.cboFilterProduct);
            this.tabFilters.Controls.Add(this.label8);
            this.tabFilters.Controls.Add(this.cboFilterPluginFamilyName);
            this.tabFilters.Controls.Add(this.label7);
            this.tabFilters.Controls.Add(this.cboFilterPluginName);
            this.tabFilters.Controls.Add(this.label6);
            this.tabFilters.Controls.Add(this.cboFilterPluginId);
            this.tabFilters.Controls.Add(this.label5);
            this.tabFilters.Controls.Add(this.cboFilterProtocol);
            this.tabFilters.Controls.Add(this.label3);
            this.tabFilters.Location = new System.Drawing.Point(4, 24);
            this.tabFilters.Name = "tabFilters";
            this.tabFilters.Size = new System.Drawing.Size(680, 251);
            this.tabFilters.TabIndex = 2;
            this.tabFilters.Text = "Filters";
            this.tabFilters.UseVisualStyleBackColor = true;
            // 
            // cboFilterExploitAvailable
            // 
            this.cboFilterExploitAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterExploitAvailable.FormattingEnabled = true;
            this.cboFilterExploitAvailable.Location = new System.Drawing.Point(103, 279);
            this.cboFilterExploitAvailable.Name = "cboFilterExploitAvailable";
            this.cboFilterExploitAvailable.Size = new System.Drawing.Size(387, 23);
            this.cboFilterExploitAvailable.TabIndex = 19;
            this.cboFilterExploitAvailable.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // lblExploitAvailable
            // 
            this.lblExploitAvailable.AutoSize = true;
            this.lblExploitAvailable.Location = new System.Drawing.Point(2, 284);
            this.lblExploitAvailable.Name = "lblExploitAvailable";
            this.lblExploitAvailable.Size = new System.Drawing.Size(93, 15);
            this.lblExploitAvailable.TabIndex = 18;
            this.lblExploitAvailable.Text = "Exploit Available";
            // 
            // cboFilterHostName
            // 
            this.cboFilterHostName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterHostName.FormattingEnabled = true;
            this.cboFilterHostName.Location = new System.Drawing.Point(103, 9);
            this.cboFilterHostName.Name = "cboFilterHostName";
            this.cboFilterHostName.Size = new System.Drawing.Size(387, 23);
            this.cboFilterHostName.TabIndex = 17;
            this.cboFilterHostName.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // lblFilterHost
            // 
            this.lblFilterHost.AutoSize = true;
            this.lblFilterHost.Location = new System.Drawing.Point(30, 14);
            this.lblFilterHost.Name = "lblFilterHost";
            this.lblFilterHost.Size = new System.Drawing.Size(67, 15);
            this.lblFilterHost.TabIndex = 16;
            this.lblFilterHost.Text = "Host Name";
            // 
            // cboFilterState
            // 
            this.cboFilterState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterState.FormattingEnabled = true;
            this.cboFilterState.Location = new System.Drawing.Point(103, 39);
            this.cboFilterState.Name = "cboFilterState";
            this.cboFilterState.Size = new System.Drawing.Size(387, 23);
            this.cboFilterState.TabIndex = 15;
            this.cboFilterState.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // lblFilterState
            // 
            this.lblFilterState.AutoSize = true;
            this.lblFilterState.Location = new System.Drawing.Point(63, 44);
            this.lblFilterState.Name = "lblFilterState";
            this.lblFilterState.Size = new System.Drawing.Size(33, 15);
            this.lblFilterState.TabIndex = 14;
            this.lblFilterState.Text = "State";
            // 
            // lblFilterSeverity
            // 
            this.lblFilterSeverity.AutoSize = true;
            this.lblFilterSeverity.Location = new System.Drawing.Point(48, 104);
            this.lblFilterSeverity.Name = "lblFilterSeverity";
            this.lblFilterSeverity.Size = new System.Drawing.Size(48, 15);
            this.lblFilterSeverity.TabIndex = 2;
            this.lblFilterSeverity.Text = "Severity";
            // 
            // cboFilterSeverity
            // 
            this.cboFilterSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterSeverity.FormattingEnabled = true;
            this.cboFilterSeverity.Location = new System.Drawing.Point(103, 99);
            this.cboFilterSeverity.Name = "cboFilterSeverity";
            this.cboFilterSeverity.Size = new System.Drawing.Size(387, 23);
            this.cboFilterSeverity.TabIndex = 3;
            this.cboFilterSeverity.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // cboFilterVersion
            // 
            this.cboFilterVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterVersion.FormattingEnabled = true;
            this.cboFilterVersion.Location = new System.Drawing.Point(103, 249);
            this.cboFilterVersion.Name = "cboFilterVersion";
            this.cboFilterVersion.Size = new System.Drawing.Size(387, 23);
            this.cboFilterVersion.TabIndex = 13;
            this.cboFilterVersion.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Version";
            // 
            // cboFilterProduct
            // 
            this.cboFilterProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterProduct.FormattingEnabled = true;
            this.cboFilterProduct.Location = new System.Drawing.Point(103, 219);
            this.cboFilterProduct.Name = "cboFilterProduct";
            this.cboFilterProduct.Size = new System.Drawing.Size(387, 23);
            this.cboFilterProduct.TabIndex = 11;
            this.cboFilterProduct.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Product";
            // 
            // cboFilterPluginFamilyName
            // 
            this.cboFilterPluginFamilyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterPluginFamilyName.FormattingEnabled = true;
            this.cboFilterPluginFamilyName.Location = new System.Drawing.Point(103, 189);
            this.cboFilterPluginFamilyName.Name = "cboFilterPluginFamilyName";
            this.cboFilterPluginFamilyName.Size = new System.Drawing.Size(387, 23);
            this.cboFilterPluginFamilyName.TabIndex = 9;
            this.cboFilterPluginFamilyName.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Plugin ID";
            // 
            // cboFilterPluginName
            // 
            this.cboFilterPluginName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterPluginName.FormattingEnabled = true;
            this.cboFilterPluginName.Location = new System.Drawing.Point(103, 159);
            this.cboFilterPluginName.Name = "cboFilterPluginName";
            this.cboFilterPluginName.Size = new System.Drawing.Size(387, 23);
            this.cboFilterPluginName.TabIndex = 7;
            this.cboFilterPluginName.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Plugin Family";
            // 
            // cboFilterPluginId
            // 
            this.cboFilterPluginId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterPluginId.FormattingEnabled = true;
            this.cboFilterPluginId.Location = new System.Drawing.Point(103, 129);
            this.cboFilterPluginId.Name = "cboFilterPluginId";
            this.cboFilterPluginId.Size = new System.Drawing.Size(387, 23);
            this.cboFilterPluginId.TabIndex = 5;
            this.cboFilterPluginId.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Plugin Name";
            // 
            // cboFilterProtocol
            // 
            this.cboFilterProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterProtocol.FormattingEnabled = true;
            this.cboFilterProtocol.Location = new System.Drawing.Point(103, 69);
            this.cboFilterProtocol.Name = "cboFilterProtocol";
            this.cboFilterProtocol.Size = new System.Drawing.Size(387, 23);
            this.cboFilterProtocol.TabIndex = 1;
            this.cboFilterProtocol.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Protocol";
            // 
            // tabHostSummary
            // 
            this.tabHostSummary.Controls.Add(this.listHostSummary);
            this.tabHostSummary.Location = new System.Drawing.Point(4, 24);
            this.tabHostSummary.Name = "tabHostSummary";
            this.tabHostSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabHostSummary.Size = new System.Drawing.Size(680, 251);
            this.tabHostSummary.TabIndex = 3;
            this.tabHostSummary.Text = "Host Summary";
            this.tabHostSummary.UseVisualStyleBackColor = true;
            // 
            // listHostSummary
            // 
            this.listHostSummary.AllColumns.Add(this.colHsIpAddress);
            this.listHostSummary.AllColumns.Add(this.colHsNetBiosName);
            this.listHostSummary.AllColumns.Add(this.colHsDnsName);
            this.listHostSummary.AllColumns.Add(this.colHsMacAddress);
            this.listHostSummary.AllColumns.Add(this.colHsOs);
            this.listHostSummary.AllColumns.Add(this.colHsSystemType);
            this.listHostSummary.AllColumns.Add(this.colHsPorts);
            this.listHostSummary.AllColumns.Add(this.colHsNumCritical);
            this.listHostSummary.AllColumns.Add(this.colHsNumHigh);
            this.listHostSummary.AllColumns.Add(this.colHsNumMed);
            this.listHostSummary.AllColumns.Add(this.colHsNumLow);
            this.listHostSummary.AllColumns.Add(this.colHsStartTime);
            this.listHostSummary.AllColumns.Add(this.colHsEndTime);
            this.listHostSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHsIpAddress,
            this.colHsNetBiosName,
            this.colHsDnsName,
            this.colHsMacAddress,
            this.colHsOs,
            this.colHsSystemType,
            this.colHsPorts,
            this.colHsNumCritical,
            this.colHsNumHigh,
            this.colHsNumMed,
            this.colHsNumLow,
            this.colHsStartTime,
            this.colHsEndTime});
            this.listHostSummary.ContextMenuStrip = this.ctxMenuSummary;
            this.listHostSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listHostSummary.FullRowSelect = true;
            this.listHostSummary.Location = new System.Drawing.Point(3, 3);
            this.listHostSummary.Name = "listHostSummary";
            this.listHostSummary.ShowGroups = false;
            this.listHostSummary.Size = new System.Drawing.Size(674, 245);
            this.listHostSummary.TabIndex = 0;
            this.listHostSummary.UseCompatibleStateImageBehavior = false;
            this.listHostSummary.View = System.Windows.Forms.View.Details;
            this.listHostSummary.VirtualMode = true;
            // 
            // colHsIpAddress
            // 
            this.colHsIpAddress.AspectName = "IpAddress";
            this.colHsIpAddress.CellPadding = null;
            this.colHsIpAddress.Text = "IP Address";
            this.colHsIpAddress.Width = 100;
            // 
            // colHsNetBiosName
            // 
            this.colHsNetBiosName.AspectName = "NetBiosName";
            this.colHsNetBiosName.CellPadding = null;
            this.colHsNetBiosName.Text = "NetBIOS Name";
            this.colHsNetBiosName.Width = 100;
            // 
            // colHsDnsName
            // 
            this.colHsDnsName.AspectName = "DnsName";
            this.colHsDnsName.CellPadding = null;
            this.colHsDnsName.Text = "DNS Name";
            this.colHsDnsName.Width = 100;
            // 
            // colHsMacAddress
            // 
            this.colHsMacAddress.AspectName = "MacAddress";
            this.colHsMacAddress.CellPadding = null;
            this.colHsMacAddress.Text = "MAC";
            this.colHsMacAddress.Width = 100;
            // 
            // colHsOs
            // 
            this.colHsOs.AspectName = "Os";
            this.colHsOs.CellPadding = null;
            this.colHsOs.Text = "OS";
            this.colHsOs.Width = 100;
            // 
            // colHsSystemType
            // 
            this.colHsSystemType.AspectName = "SystemType";
            this.colHsSystemType.CellPadding = null;
            this.colHsSystemType.Text = "System Type";
            // 
            // colHsPorts
            // 
            this.colHsPorts.AspectName = "NumPorts";
            this.colHsPorts.CellPadding = null;
            this.colHsPorts.Text = "Ports";
            // 
            // colHsNumCritical
            // 
            this.colHsNumCritical.AspectName = "NumCritical";
            this.colHsNumCritical.CellPadding = null;
            this.colHsNumCritical.Text = "Critical";
            // 
            // colHsNumHigh
            // 
            this.colHsNumHigh.AspectName = "NumHigh";
            this.colHsNumHigh.CellPadding = null;
            this.colHsNumHigh.Text = "High";
            // 
            // colHsNumMed
            // 
            this.colHsNumMed.AspectName = "NumMed";
            this.colHsNumMed.CellPadding = null;
            this.colHsNumMed.Text = "Medium";
            // 
            // colHsNumLow
            // 
            this.colHsNumLow.AspectName = "NumLow";
            this.colHsNumLow.CellPadding = null;
            this.colHsNumLow.Text = "Low";
            // 
            // colHsStartTime
            // 
            this.colHsStartTime.AspectName = "StartTime";
            this.colHsStartTime.CellPadding = null;
            this.colHsStartTime.Text = "Start Time";
            this.colHsStartTime.Width = 120;
            // 
            // colHsEndTime
            // 
            this.colHsEndTime.AspectName = "EndTime";
            this.colHsEndTime.CellPadding = null;
            this.colHsEndTime.Text = "End Time";
            this.colHsEndTime.Width = 120;
            // 
            // ctxMenuSummary
            // 
            this.ctxMenuSummary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuSummaryCopy});
            this.ctxMenuSummary.Name = "contextMenuStrip1";
            this.ctxMenuSummary.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctxMenuSummary.Size = new System.Drawing.Size(103, 26);
            // 
            // ctxMenuSummaryCopy
            // 
            this.ctxMenuSummaryCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuSummaryCopyIp,
            this.ctxMenuSummaryCopyNetbios,
            this.ctxMenuSummaryCopyDns,
            this.ctxMenuSummaryCopyMac,
            this.ctxMenuSummaryCopyOs});
            this.ctxMenuSummaryCopy.Name = "ctxMenuSummaryCopy";
            this.ctxMenuSummaryCopy.Size = new System.Drawing.Size(102, 22);
            this.ctxMenuSummaryCopy.Text = "Copy";
            // 
            // ctxMenuSummaryCopyIp
            // 
            this.ctxMenuSummaryCopyIp.Name = "ctxMenuSummaryCopyIp";
            this.ctxMenuSummaryCopyIp.Size = new System.Drawing.Size(153, 22);
            this.ctxMenuSummaryCopyIp.Text = "IP Address";
            this.ctxMenuSummaryCopyIp.Click += new System.EventHandler(this.ctxMenuSummaryCopyIp_Click);
            // 
            // ctxMenuSummaryCopyNetbios
            // 
            this.ctxMenuSummaryCopyNetbios.Name = "ctxMenuSummaryCopyNetbios";
            this.ctxMenuSummaryCopyNetbios.Size = new System.Drawing.Size(153, 22);
            this.ctxMenuSummaryCopyNetbios.Text = "NetBIOS Name";
            this.ctxMenuSummaryCopyNetbios.Click += new System.EventHandler(this.ctxMenuSummaryCopyNetbios_Click);
            // 
            // ctxMenuSummaryCopyDns
            // 
            this.ctxMenuSummaryCopyDns.Name = "ctxMenuSummaryCopyDns";
            this.ctxMenuSummaryCopyDns.Size = new System.Drawing.Size(153, 22);
            this.ctxMenuSummaryCopyDns.Text = "DNS Name";
            this.ctxMenuSummaryCopyDns.Click += new System.EventHandler(this.ctxMenuSummaryCopyDns_Click);
            // 
            // ctxMenuSummaryCopyMac
            // 
            this.ctxMenuSummaryCopyMac.Name = "ctxMenuSummaryCopyMac";
            this.ctxMenuSummaryCopyMac.Size = new System.Drawing.Size(153, 22);
            this.ctxMenuSummaryCopyMac.Text = "MAC";
            this.ctxMenuSummaryCopyMac.Click += new System.EventHandler(this.ctxMenuSummaryCopyMac_Click);
            // 
            // ctxMenuSummaryCopyOs
            // 
            this.ctxMenuSummaryCopyOs.Name = "ctxMenuSummaryCopyOs";
            this.ctxMenuSummaryCopyOs.Size = new System.Drawing.Size(153, 22);
            this.ctxMenuSummaryCopyOs.Text = "OS";
            this.ctxMenuSummaryCopyOs.Click += new System.EventHandler(this.ctxMenuSummaryCopyOs_Click);
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.txtLog);
            this.tabLog.Location = new System.Drawing.Point(4, 24);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(680, 251);
            this.tabLog.TabIndex = 1;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(3, 3);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtLog.Size = new System.Drawing.Size(674, 245);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 385);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetworkScanViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabResults.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listResults)).EndInit();
            this.ctxMenuResults.ResumeLayout(false);
            this.tabFilters.ResumeLayout(false);
            this.tabFilters.PerformLayout();
            this.tabHostSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listHostSummary)).EndInit();
            this.ctxMenuSummary.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripSeparator menuFileSepOne;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpHelp;
        private System.Windows.Forms.ToolStripSeparator menuHelpSepOne;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.SplitContainer splitContainer;
        private BrightIdeasSoftware.FastObjectListView listResults;
        private BrightIdeasSoftware.FastObjectListView listHostSummary;
        private BrightIdeasSoftware.OLVColumn colResultsType;
        private BrightIdeasSoftware.OLVColumn colResultsIpAddress;
        private BrightIdeasSoftware.OLVColumn colResultsPort;
        private BrightIdeasSoftware.OLVColumn colResultsProtocol;
        private BrightIdeasSoftware.OLVColumn colResultsService;
        private BrightIdeasSoftware.OLVColumn colResultsSeverity;
        private BrightIdeasSoftware.OLVColumn colResultsPluginId;
        private BrightIdeasSoftware.OLVColumn colResultsPluginName;
        private BrightIdeasSoftware.OLVColumn colResultsPluginFamily;
        private BrightIdeasSoftware.OLVColumn colResultsSynopsis;
        private System.Windows.Forms.RichTextBox txtData;
        private System.Windows.Forms.TabPage tabFilters;
        private System.Windows.Forms.ComboBox cboFilterPluginName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFilterPluginId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboFilterProtocol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.ComboBox cboFilterPluginFamilyName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboFilterProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboFilterVersion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripLabel lblFilterSearch;
        private System.Windows.Forms.ToolStripTextBox txtFilterSearch;
        private System.Windows.Forms.ToolStripButton toolBtnSearch;
        private BrightIdeasSoftware.OLVColumn colResultsId;
        private System.Windows.Forms.ContextMenuStrip ctxMenuResults;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsCopy;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsCopyIpAddress;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsCopyPort;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsCopyService;
        private System.Windows.Forms.ToolStripSeparator ctxMenuResultsSepOne;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsFilter;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsFilterType;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsFilterHost;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsFilterPort;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsFilterProtocol;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsFilterService;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsFilterSeverity;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsFilterPluginId;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsFilterPluginFamily;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsFilterPluginName;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsFilterProduct;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsFilterVersion;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripComboBox cboFilterType;
        private System.Windows.Forms.ToolStripComboBox cboFilterIp;
        private System.Windows.Forms.ToolStripComboBox cboFilterService;
        private System.Windows.Forms.ToolStripLabel lblFilterType;
        private System.Windows.Forms.ToolStripLabel lblFilterIp;
        private System.Windows.Forms.ToolStripLabel lblFilterService;
        private System.Windows.Forms.ToolStripLabel lblFilterPort;
        private System.Windows.Forms.ToolStripComboBox cboFilterPort;
        private System.Windows.Forms.ToolStripSeparator ctxMenuResultsSepTwo;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsIgnorePlugin;
        private System.Windows.Forms.ToolStripMenuItem menuTools;
        private System.Windows.Forms.ToolStripMenuItem menuToolsOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResultsClearFilters;
        private System.Windows.Forms.Label lblFilterSeverity;
        private System.Windows.Forms.ComboBox cboFilterSeverity;
        private BrightIdeasSoftware.OLVColumn colResultsState;
        private System.Windows.Forms.ComboBox cboFilterState;
        private System.Windows.Forms.Label lblFilterState;
        private System.Windows.Forms.TabPage tabHostSummary;
        private BrightIdeasSoftware.OLVColumn colHsIpAddress;
        private BrightIdeasSoftware.OLVColumn colHsNetBiosName;
        private BrightIdeasSoftware.OLVColumn colHsDnsName;
        private BrightIdeasSoftware.OLVColumn colHsMacAddress;
        private BrightIdeasSoftware.OLVColumn colHsOs;
        private BrightIdeasSoftware.OLVColumn colHsPorts;
        private BrightIdeasSoftware.OLVColumn colHsNumHigh;
        private BrightIdeasSoftware.OLVColumn colHsNumMed;
        private BrightIdeasSoftware.OLVColumn colHsNumLow;
        private BrightIdeasSoftware.OLVColumn colHsStartTime;
        private BrightIdeasSoftware.OLVColumn colHsEndTime;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveResults;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveResultsCsv;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveResultsXml;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveHostSummary;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveHostSummaryCsv;
        private System.Windows.Forms.Button btnResultsLastPage;
        private System.Windows.Forms.Button btnResultsNextPage;
        private System.Windows.Forms.Button btnResultsPreviousPage;
        private System.Windows.Forms.Button btnResultsFirstPage;
        private BrightIdeasSoftware.OLVColumn colResultsHostName;
        private System.Windows.Forms.ComboBox cboFilterHostName;
        private System.Windows.Forms.Label lblFilterHost;
        private System.Windows.Forms.ContextMenuStrip ctxMenuSummary;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuSummaryCopy;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuSummaryCopyIp;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuSummaryCopyNetbios;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuSummaryCopyDns;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuSummaryCopyMac;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuSummaryCopyOs;
        private System.Windows.Forms.ComboBox cboFilterExploitAvailable;
        private System.Windows.Forms.Label lblExploitAvailable;
        private BrightIdeasSoftware.OLVColumn colHsNumCritical;
        private BrightIdeasSoftware.OLVColumn colHsSystemType;
    }
}

