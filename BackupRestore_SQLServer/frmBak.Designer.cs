namespace BackupRestore_SQLServer
{
    partial class frmBak
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
            this.bdsBakDev = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new BackupRestore_SQLServer.DS();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDbName = new System.Windows.Forms.Label();
            this.backup_devicesTableAdapter = new BackupRestore_SQLServer.DSTableAdapters.backup_devicesTableAdapter();
            this.tableAdapterManager = new BackupRestore_SQLServer.DSTableAdapters.TableAdapterManager();
            this.grbFullBak = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtDescript = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbBakType = new System.Windows.Forms.ComboBox();
            this.chkboxOw = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbBakDevice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBakDev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbFullBak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescript.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdsBakDev
            // 
            this.bdsBakDev.DataMember = "backup_devices";
            this.bdsBakDev.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDbName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 49);
            this.panel1.TabIndex = 1;
            // 
            // lblDbName
            // 
            this.lblDbName.AutoSize = true;
            this.lblDbName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbName.Location = new System.Drawing.Point(112, 15);
            this.lblDbName.Name = "lblDbName";
            this.lblDbName.Size = new System.Drawing.Size(74, 16);
            this.lblDbName.TabIndex = 2;
            this.lblDbName.Text = "lblDbName";
            // 
            // backup_devicesTableAdapter
            // 
            this.backup_devicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BackupRestore_SQLServer.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // grbFullBak
            // 
            this.grbFullBak.Controls.Add(this.label5);
            this.grbFullBak.Controls.Add(this.label4);
            this.grbFullBak.Controls.Add(this.btnCancel);
            this.grbFullBak.Controls.Add(this.txtDescript);
            this.grbFullBak.Controls.Add(this.btnOK);
            this.grbFullBak.Controls.Add(this.cmbBakType);
            this.grbFullBak.Controls.Add(this.chkboxOw);
            this.grbFullBak.Controls.Add(this.label3);
            this.grbFullBak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbFullBak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbFullBak.Location = new System.Drawing.Point(0, 100);
            this.grbFullBak.Name = "grbFullBak";
            this.grbFullBak.Size = new System.Drawing.Size(623, 204);
            this.grbFullBak.TabIndex = 5;
            this.grbFullBak.TabStop = false;
            this.grbFullBak.Text = "Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Overwrite:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(321, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtDescript
            // 
            this.txtDescript.Location = new System.Drawing.Point(112, 52);
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescript.Properties.Appearance.Options.UseFont = true;
            this.txtDescript.Size = new System.Drawing.Size(416, 20);
            this.txtDescript.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(220, 144);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbBakType
            // 
            this.cmbBakType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBakType.FormattingEnabled = true;
            this.cmbBakType.Location = new System.Drawing.Point(112, 22);
            this.cmbBakType.Name = "cmbBakType";
            this.cmbBakType.Size = new System.Drawing.Size(195, 24);
            this.cmbBakType.TabIndex = 4;
            this.cmbBakType.SelectedIndexChanged += new System.EventHandler(this.cmbBakType_SelectedIndexChanged);
            // 
            // chkboxOw
            // 
            this.chkboxOw.AutoSize = true;
            this.chkboxOw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkboxOw.Location = new System.Drawing.Point(112, 82);
            this.chkboxOw.Name = "chkboxOw";
            this.chkboxOw.Size = new System.Drawing.Size(15, 14);
            this.chkboxOw.TabIndex = 0;
            this.chkboxOw.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Backup Type:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbBakDevice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 51);
            this.panel2.TabIndex = 6;
            // 
            // cmbBakDevice
            // 
            this.cmbBakDevice.DataSource = this.bdsBakDev;
            this.cmbBakDevice.DisplayMember = "name";
            this.cmbBakDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBakDevice.FormattingEnabled = true;
            this.cmbBakDevice.Location = new System.Drawing.Point(112, 13);
            this.cmbBakDevice.Name = "cmbBakDevice";
            this.cmbBakDevice.Size = new System.Drawing.Size(195, 24);
            this.cmbBakDevice.TabIndex = 4;
            this.cmbBakDevice.ValueMember = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Backup device:";
            // 
            // frmBak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 304);
            this.Controls.Add(this.grbFullBak);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBak_FormClosing);
            this.Load += new System.EventHandler(this.frmBak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsBakDev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbFullBak.ResumeLayout(false);
            this.grbFullBak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescript.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblDbName;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsBakDev;
        private DSTableAdapters.backup_devicesTableAdapter backup_devicesTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox grbFullBak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private DevExpress.XtraEditors.TextEdit txtDescript;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbBakType;
        private System.Windows.Forms.CheckBox chkboxOw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbBakDevice;
        private System.Windows.Forms.Label label2;
    }
}