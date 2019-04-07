namespace BackupRestore_SQLServer
{
    partial class frmRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestore));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label nameLabel1;
            this.grbRestore = new System.Windows.Forms.GroupBox();
            this.lb = new System.Windows.Forms.Label();
            this.lbDBName = new System.Windows.Forms.Label();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.lbStopAt = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.DS = new BackupRestore_SQLServer.DS();
            this.bdsBakDev = new System.Windows.Forms.BindingSource(this.components);
            this.backup_devicesTableAdapter = new BackupRestore_SQLServer.DSTableAdapters.backup_devicesTableAdapter();
            this.tableAdapterManager = new BackupRestore_SQLServer.DSTableAdapters.TableAdapterManager();
            this.cmbLog = new System.Windows.Forms.ComboBox();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.bdsBakLog = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            this.grbRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBakDev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBakLog)).BeginInit();
            this.SuspendLayout();
            // 
            // grbRestore
            // 
            this.grbRestore.Controls.Add(nameLabel1);
            this.grbRestore.Controls.Add(this.cmbDevice);
            this.grbRestore.Controls.Add(nameLabel);
            this.grbRestore.Controls.Add(this.cmbLog);
            this.grbRestore.Controls.Add(this.lb);
            this.grbRestore.Controls.Add(this.lbDBName);
            this.grbRestore.Controls.Add(this.txtHelp);
            this.grbRestore.Controls.Add(this.lbStopAt);
            this.grbRestore.Controls.Add(this.dtpTime);
            this.grbRestore.Controls.Add(this.dtpDate);
            this.grbRestore.Controls.Add(this.btnCancel);
            this.grbRestore.Controls.Add(this.btnOK);
            this.grbRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbRestore.Location = new System.Drawing.Point(0, 0);
            this.grbRestore.Name = "grbRestore";
            this.grbRestore.Size = new System.Drawing.Size(675, 403);
            this.grbRestore.TabIndex = 0;
            this.grbRestore.TabStop = false;
            this.grbRestore.Text = "Restore detail";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(33, 69);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(100, 16);
            this.lb.TabIndex = 9;
            this.lb.Text = "Info backup file:";
            // 
            // lbDBName
            // 
            this.lbDBName.AutoSize = true;
            this.lbDBName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDBName.Location = new System.Drawing.Point(33, 31);
            this.lbDBName.Name = "lbDBName";
            this.lbDBName.Size = new System.Drawing.Size(110, 23);
            this.lbDBName.TabIndex = 8;
            this.lbDBName.Text = "lbDBName";
            // 
            // txtHelp
            // 
            this.txtHelp.BackColor = System.Drawing.Color.White;
            this.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHelp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelp.Location = new System.Drawing.Point(95, 224);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.Size = new System.Drawing.Size(503, 95);
            this.txtHelp.TabIndex = 7;
            this.txtHelp.Text = resources.GetString("txtHelp.Text");
            // 
            // lbStopAt
            // 
            this.lbStopAt.AutoSize = true;
            this.lbStopAt.Location = new System.Drawing.Point(34, 182);
            this.lbStopAt.Name = "lbStopAt";
            this.lbStopAt.Size = new System.Drawing.Size(55, 16);
            this.lbStopAt.TabIndex = 6;
            this.lbStopAt.Text = "Stop At:";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm:ss";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(256, 179);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(141, 23);
            this.dtpTime.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(95, 179);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(141, 23);
            this.dtpDate.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(342, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(244, 342);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsBakDev
            // 
            this.bdsBakDev.DataMember = "backup_devices";
            this.bdsBakDev.DataSource = this.DS;
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
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(34, 151);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(31, 16);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "LOG";
            // 
            // cmbLog
            // 
            this.cmbLog.DataSource = this.bdsBakLog;
            this.cmbLog.DisplayMember = "name";
            this.cmbLog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLog.FormattingEnabled = true;
            this.cmbLog.Location = new System.Drawing.Point(95, 147);
            this.cmbLog.Name = "cmbLog";
            this.cmbLog.Size = new System.Drawing.Size(503, 24);
            this.cmbLog.TabIndex = 10;
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(34, 120);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(50, 16);
            nameLabel1.TabIndex = 10;
            nameLabel1.Text = "DEVICE";
            // 
            // cmbDevice
            // 
            this.cmbDevice.DataSource = this.bdsBakDev;
            this.cmbDevice.DisplayMember = "name";
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(95, 116);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(503, 24);
            this.cmbDevice.TabIndex = 11;
            // 
            // bdsBakLog
            // 
            this.bdsBakLog.DataMember = "backup_devices";
            this.bdsBakLog.DataSource = this.DS;
            // 
            // frmRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 403);
            this.Controls.Add(this.grbRestore);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRestore_FormClosing);
            this.Load += new System.EventHandler(this.frmRestore_Load);
            this.grbRestore.ResumeLayout(false);
            this.grbRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBakDev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBakLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRestore;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.Label lbStopAt;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbDBName;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsBakDev;
        private DSTableAdapters.backup_devicesTableAdapter backup_devicesTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.ComboBox cmbLog;
        private System.Windows.Forms.BindingSource bdsBakLog;
    }
}