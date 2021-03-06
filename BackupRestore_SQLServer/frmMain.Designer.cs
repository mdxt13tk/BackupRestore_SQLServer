﻿namespace BackupRestore_SQLServer
{
    partial class frmMain
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
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnBak = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnBakDv = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.tgbtnConnect = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new BackupRestore_SQLServer.DS();
            this.bdsDbs = new System.Windows.Forms.BindingSource(this.components);
            this.databasesTableAdapter = new BackupRestore_SQLServer.DSTableAdapters.databasesTableAdapter();
            this.tableAdapterManager = new BackupRestore_SQLServer.DSTableAdapters.TableAdapterManager();
            this.grctrlDbs = new DevExpress.XtraGrid.GridControl();
            this.grvDbs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldatabase_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grctrlPbs = new DevExpress.XtraGrid.GridControl();
            this.bdsPbs = new System.Windows.Forms.BindingSource(this.components);
            this.grvPbs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnNf = new System.Windows.Forms.Panel();
            this.lbNf = new System.Windows.Forms.Label();
            this.pnBakInfo = new System.Windows.Forms.Panel();
            this.lbBakInfo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.position_backupsTableAdapter = new BackupRestore_SQLServer.DSTableAdapters.position_backupsTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grctrlDbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDbs)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grctrlPbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPbs)).BeginInit();
            this.pnNf.SuspendLayout();
            this.pnBakInfo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.White;
            nameLabel.Location = new System.Drawing.Point(16, 11);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(75, 18);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Database:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnBak,
            this.btnRestore,
            this.btnExit,
            this.btnLogout,
            this.btnBakDv,
            this.tgbtnConnect});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.FloatLocation = new System.Drawing.Point(431, 220);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBak, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRestore, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBakDv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLogout, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, "", false, true, false, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.tgbtnConnect)});
            this.bar1.Offset = 247;
            this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar1.Text = "Tools";
            // 
            // btnBak
            // 
            this.btnBak.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnBak.Caption = "Backup ...";
            this.btnBak.Id = 1;
            this.btnBak.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBak.ImageOptions.Image")));
            this.btnBak.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBak.ImageOptions.LargeImage")));
            this.btnBak.Name = "btnBak";
            this.btnBak.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBak_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnRestore.Caption = "Restore";
            this.btnRestore.Id = 2;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
            // 
            // btnBakDv
            // 
            this.btnBakDv.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnBakDv.Caption = "Backup device ...";
            this.btnBakDv.Id = 5;
            this.btnBakDv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBakDv.ImageOptions.Image")));
            this.btnBakDv.Name = "btnBakDv";
            this.btnBakDv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBakDv_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnLogout.Caption = "Logout";
            this.btnLogout.Id = 4;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 3;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // tgbtnConnect
            // 
            this.tgbtnConnect.Caption = "MULTI USER";
            this.tgbtnConnect.Id = 6;
            this.tgbtnConnect.Name = "tgbtnConnect";
            this.tgbtnConnect.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.tgbtnConnect_CheckedChanged);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Manager = this.barManager1;
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(1034, 41);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1248, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 708);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1248, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 708);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1248, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 708);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDbs
            // 
            this.bdsDbs.DataMember = "databases";
            this.bdsDbs.DataSource = this.DS;
            // 
            // databasesTableAdapter
            // 
            this.databasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BackupRestore_SQLServer.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // grctrlDbs
            // 
            this.grctrlDbs.DataSource = this.bdsDbs;
            this.grctrlDbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grctrlDbs.Location = new System.Drawing.Point(0, 41);
            this.grctrlDbs.MainView = this.grvDbs;
            this.grctrlDbs.MenuManager = this.barManager1;
            this.grctrlDbs.Name = "grctrlDbs";
            this.grctrlDbs.Size = new System.Drawing.Size(214, 667);
            this.grctrlDbs.TabIndex = 5;
            this.grctrlDbs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDbs});
            // 
            // grvDbs
            // 
            this.grvDbs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldatabase_id,
            this.colname});
            this.grvDbs.GridControl = this.grctrlDbs;
            this.grvDbs.Name = "grvDbs";
            this.grvDbs.OptionsView.ShowGroupPanel = false;
            this.grvDbs.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvDbs_RowClick);
            // 
            // coldatabase_id
            // 
            this.coldatabase_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldatabase_id.AppearanceCell.Options.UseFont = true;
            this.coldatabase_id.AppearanceCell.Options.UseTextOptions = true;
            this.coldatabase_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatabase_id.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coldatabase_id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldatabase_id.AppearanceHeader.Options.UseFont = true;
            this.coldatabase_id.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatabase_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatabase_id.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coldatabase_id.Caption = "ID";
            this.coldatabase_id.FieldName = "database_id";
            this.coldatabase_id.Name = "coldatabase_id";
            this.coldatabase_id.OptionsColumn.AllowEdit = false;
            this.coldatabase_id.Visible = true;
            this.coldatabase_id.VisibleIndex = 0;
            this.coldatabase_id.Width = 99;
            // 
            // colname
            // 
            this.colname.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colname.AppearanceCell.Options.UseFont = true;
            this.colname.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colname.AppearanceHeader.Options.UseFont = true;
            this.colname.AppearanceHeader.Options.UseTextOptions = true;
            this.colname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colname.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colname.Caption = "Database name";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 593;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grctrlPbs);
            this.panel1.Controls.Add(this.pnNf);
            this.panel1.Controls.Add(this.pnBakInfo);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(214, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 708);
            this.panel1.TabIndex = 10;
            // 
            // grctrlPbs
            // 
            this.grctrlPbs.DataSource = this.bdsPbs;
            this.grctrlPbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grctrlPbs.Location = new System.Drawing.Point(0, 168);
            this.grctrlPbs.MainView = this.grvPbs;
            this.grctrlPbs.MenuManager = this.barManager1;
            this.grctrlPbs.Name = "grctrlPbs";
            this.grctrlPbs.Size = new System.Drawing.Size(1034, 540);
            this.grctrlPbs.TabIndex = 2;
            this.grctrlPbs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPbs});
            // 
            // bdsPbs
            // 
            this.bdsPbs.DataMember = "position_backups";
            this.bdsPbs.DataSource = this.DS;
            // 
            // grvPbs
            // 
            this.grvPbs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.coldescription,
            this.colbackup_start_date,
            this.coluser_name});
            this.grvPbs.GridControl = this.grctrlPbs;
            this.grvPbs.Name = "grvPbs";
            this.grvPbs.OptionsView.ShowGroupPanel = false;
            this.grvPbs.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colbackup_start_date, DevExpress.Data.ColumnSortOrder.Descending)});
            this.grvPbs.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvPbs_RowClick);
            // 
            // colposition
            // 
            this.colposition.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colposition.AppearanceCell.Options.UseFont = true;
            this.colposition.AppearanceCell.Options.UseTextOptions = true;
            this.colposition.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colposition.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colposition.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colposition.AppearanceHeader.Options.UseFont = true;
            this.colposition.AppearanceHeader.Options.UseTextOptions = true;
            this.colposition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colposition.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colposition.Caption = "Position";
            this.colposition.FieldName = "position";
            this.colposition.Name = "colposition";
            this.colposition.OptionsColumn.AllowEdit = false;
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 0;
            // 
            // coldescription
            // 
            this.coldescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.coldescription.AppearanceCell.Options.UseFont = true;
            this.coldescription.AppearanceCell.Options.UseTextOptions = true;
            this.coldescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.coldescription.AppearanceHeader.Options.UseFont = true;
            this.coldescription.AppearanceHeader.Options.UseTextOptions = true;
            this.coldescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldescription.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coldescription.Caption = "Description";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.OptionsColumn.AllowEdit = false;
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 1;
            this.coldescription.Width = 89;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colbackup_start_date.AppearanceCell.Options.UseFont = true;
            this.colbackup_start_date.AppearanceCell.Options.UseTextOptions = true;
            this.colbackup_start_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbackup_start_date.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colbackup_start_date.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colbackup_start_date.AppearanceHeader.Options.UseFont = true;
            this.colbackup_start_date.AppearanceHeader.Options.UseTextOptions = true;
            this.colbackup_start_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbackup_start_date.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colbackup_start_date.Caption = "Backup time";
            this.colbackup_start_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colbackup_start_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Date;
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.OptionsColumn.AllowEdit = false;
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 2;
            this.colbackup_start_date.Width = 108;
            // 
            // coluser_name
            // 
            this.coluser_name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.coluser_name.AppearanceCell.Options.UseFont = true;
            this.coluser_name.AppearanceCell.Options.UseTextOptions = true;
            this.coluser_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluser_name.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coluser_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.coluser_name.AppearanceHeader.Options.UseFont = true;
            this.coluser_name.AppearanceHeader.Options.UseTextOptions = true;
            this.coluser_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluser_name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coluser_name.Caption = "Username";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.OptionsColumn.AllowEdit = false;
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 3;
            this.coluser_name.Width = 79;
            // 
            // pnNf
            // 
            this.pnNf.Controls.Add(this.lbNf);
            this.pnNf.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNf.Location = new System.Drawing.Point(0, 68);
            this.pnNf.Name = "pnNf";
            this.pnNf.Size = new System.Drawing.Size(1034, 100);
            this.pnNf.TabIndex = 4;
            // 
            // lbNf
            // 
            this.lbNf.AutoSize = true;
            this.lbNf.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNf.Location = new System.Drawing.Point(349, 36);
            this.lbNf.Name = "lbNf";
            this.lbNf.Size = new System.Drawing.Size(220, 25);
            this.lbNf.TabIndex = 0;
            this.lbNf.Text = "Not found any item!";
            // 
            // pnBakInfo
            // 
            this.pnBakInfo.BackColor = System.Drawing.Color.Teal;
            this.pnBakInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBakInfo.Controls.Add(this.lbBakInfo);
            this.pnBakInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBakInfo.Location = new System.Drawing.Point(0, 41);
            this.pnBakInfo.Name = "pnBakInfo";
            this.pnBakInfo.Size = new System.Drawing.Size(1034, 27);
            this.pnBakInfo.TabIndex = 1;
            // 
            // lbBakInfo
            // 
            this.lbBakInfo.AutoSize = true;
            this.lbBakInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBakInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBakInfo.ForeColor = System.Drawing.Color.White;
            this.lbBakInfo.Location = new System.Drawing.Point(18, 2);
            this.lbBakInfo.Name = "lbBakInfo";
            this.lbBakInfo.Size = new System.Drawing.Size(150, 21);
            this.lbBakInfo.TabIndex = 2;
            this.lbBakInfo.Text = "Backup Information";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.standaloneBarDockControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1034, 41);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(nameLabel);
            this.panel5.Controls.Add(this.nameLabel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(247, 41);
            this.panel5.TabIndex = 4;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDbs, "name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.ForeColor = System.Drawing.Color.White;
            this.nameLabel1.Location = new System.Drawing.Point(97, 11);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(264, 23);
            this.nameLabel1.TabIndex = 1;
            this.nameLabel1.Text = "name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grctrlDbs);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 708);
            this.panel2.TabIndex = 11;
            // 
            // btnReload
            // 
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReload.Location = new System.Drawing.Point(0, 0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(214, 41);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // position_backupsTableAdapter
            // 
            this.position_backupsTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 708);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Backup and Restore SQL Server";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grctrlDbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDbs)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grctrlPbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPbs)).EndInit();
            this.pnNf.ResumeLayout(false);
            this.pnNf.PerformLayout();
            this.pnBakInfo.ResumeLayout(false);
            this.pnBakInfo.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnBak;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource bdsDbs;
        private DS DS;
        private DSTableAdapters.databasesTableAdapter databasesTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl grctrlDbs;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDbs;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnBakDv;
        private DevExpress.XtraGrid.Columns.GridColumn coldatabase_id;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private System.Windows.Forms.Panel pnBakInfo;
        private DSTableAdapters.position_backupsTableAdapter position_backupsTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPbs;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label lbBakInfo;
        private System.Windows.Forms.Panel pnNf;
        private System.Windows.Forms.Label lbNf;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraGrid.GridControl grctrlPbs;
        private System.Windows.Forms.BindingSource bdsPbs;
        private DevExpress.XtraBars.BarToggleSwitchItem tgbtnConnect;
    }
}