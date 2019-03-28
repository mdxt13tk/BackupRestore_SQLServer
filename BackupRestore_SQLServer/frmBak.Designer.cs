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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbFullBak = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescript = new DevExpress.XtraEditors.TextEdit();
            this.cmbBakType = new System.Windows.Forms.ComboBox();
            this.cmbBakDevice = new System.Windows.Forms.ComboBox();
            this.bdsBakDev = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new BackupRestore_SQLServer.DS();
            this.chkboxOw = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkboxLogBak = new System.Windows.Forms.CheckBox();
            this.chkboxFullBak = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDbName = new System.Windows.Forms.Label();
            this.backup_devicesTableAdapter = new BackupRestore_SQLServer.DSTableAdapters.backup_devicesTableAdapter();
            this.tableAdapterManager = new BackupRestore_SQLServer.DSTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            this.grbFullBak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescript.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBakDev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbFullBak);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.chkboxLogBak);
            this.groupBox1.Controls.Add(this.chkboxFullBak);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 509);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // grbFullBak
            // 
            this.grbFullBak.Controls.Add(this.label4);
            this.grbFullBak.Controls.Add(this.txtDescript);
            this.grbFullBak.Controls.Add(this.cmbBakType);
            this.grbFullBak.Controls.Add(this.cmbBakDevice);
            this.grbFullBak.Controls.Add(this.chkboxOw);
            this.grbFullBak.Controls.Add(this.label3);
            this.grbFullBak.Controls.Add(this.label2);
            this.grbFullBak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbFullBak.Location = new System.Drawing.Point(29, 48);
            this.grbFullBak.Name = "grbFullBak";
            this.grbFullBak.Size = new System.Drawing.Size(863, 182);
            this.grbFullBak.TabIndex = 5;
            this.grbFullBak.TabStop = false;
            this.grbFullBak.Text = "Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description:";
            // 
            // txtDescript
            // 
            this.txtDescript.Location = new System.Drawing.Point(124, 84);
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescript.Properties.Appearance.Options.UseFont = true;
            this.txtDescript.Size = new System.Drawing.Size(708, 20);
            this.txtDescript.TabIndex = 5;
            // 
            // cmbBakType
            // 
            this.cmbBakType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBakType.FormattingEnabled = true;
            this.cmbBakType.Location = new System.Drawing.Point(124, 53);
            this.cmbBakType.Name = "cmbBakType";
            this.cmbBakType.Size = new System.Drawing.Size(195, 24);
            this.cmbBakType.TabIndex = 4;
            // 
            // cmbBakDevice
            // 
            this.cmbBakDevice.DataSource = this.bdsBakDev;
            this.cmbBakDevice.DisplayMember = "name";
            this.cmbBakDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBakDevice.FormattingEnabled = true;
            this.cmbBakDevice.Location = new System.Drawing.Point(124, 22);
            this.cmbBakDevice.Name = "cmbBakDevice";
            this.cmbBakDevice.Size = new System.Drawing.Size(195, 24);
            this.cmbBakDevice.TabIndex = 4;
            this.cmbBakDevice.ValueMember = "name";
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
            // chkboxOw
            // 
            this.chkboxOw.AutoSize = true;
            this.chkboxOw.Location = new System.Drawing.Point(337, 24);
            this.chkboxOw.Name = "chkboxOw";
            this.chkboxOw.Size = new System.Drawing.Size(87, 20);
            this.chkboxOw.TabIndex = 0;
            this.chkboxOw.Text = "Over write";
            this.chkboxOw.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Backup Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Backup device:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(321, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(220, 358);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // chkboxLogBak
            // 
            this.chkboxLogBak.AutoSize = true;
            this.chkboxLogBak.Location = new System.Drawing.Point(68, 295);
            this.chkboxLogBak.Name = "chkboxLogBak";
            this.chkboxLogBak.Size = new System.Drawing.Size(91, 20);
            this.chkboxLogBak.TabIndex = 0;
            this.chkboxLogBak.Text = "Log backup";
            this.chkboxLogBak.UseVisualStyleBackColor = true;
            // 
            // chkboxFullBak
            // 
            this.chkboxFullBak.AutoSize = true;
            this.chkboxFullBak.Location = new System.Drawing.Point(12, 22);
            this.chkboxFullBak.Name = "chkboxFullBak";
            this.chkboxFullBak.Size = new System.Drawing.Size(91, 20);
            this.chkboxFullBak.TabIndex = 0;
            this.chkboxFullBak.Text = "Full backup";
            this.chkboxFullBak.UseVisualStyleBackColor = true;
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
            this.panel1.Size = new System.Drawing.Size(946, 49);
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
            // frmBak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBak_FormClosing);
            this.Load += new System.EventHandler(this.frmBak_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbFullBak.ResumeLayout(false);
            this.grbFullBak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescript.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBakDev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkboxLogBak;
        private System.Windows.Forms.CheckBox chkboxFullBak;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBakDevice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbFullBak;
        private System.Windows.Forms.ComboBox cmbBakType;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblDbName;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsBakDev;
        private DSTableAdapters.backup_devicesTableAdapter backup_devicesTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtDescript;
        private System.Windows.Forms.CheckBox chkboxOw;
    }
}