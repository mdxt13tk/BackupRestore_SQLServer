using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupRestore_SQLServer
{
    public partial class frmRestore : Form
    {
        DateTime dtbak;
        String device,log;
        public frmRestore()
        {
            InitializeComponent();
        }

        private void frmRestore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.backup_devices' table. You can move, or remove it, as needed.
            this.backup_devicesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.backup_devicesTableAdapter.Fill(this.DS.backup_devices);

            String strlenh = "ALTER DATABASE " + Program.dBname + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            Program.myReader.Close();
            

            txtHelp.Left = (grbRestore.Width - txtHelp.Width) / 2;
            lbDBName.Text = Program.dBname;
            String position = ((DataRowView)Program.bdsPbs[Program.bdsPbs.Position])["position"].ToString().Trim();
            String description = ((DataRowView)Program.bdsPbs[Program.bdsPbs.Position])["description"].ToString().Trim();
            String backuptime = ((DataRowView)Program.bdsPbs[Program.bdsPbs.Position])["backup_start_date"].ToString().Trim();
            dtbak = DateTime.Parse(backuptime);
            String username = ((DataRowView)Program.bdsPbs[Program.bdsPbs.Position])["user_name"].ToString().Trim();
            lb.Text = "Potision: " + position + " | Description: " + description + " | Backup time: " + backuptime + " | Username: " + username;
            device = cmbDevice.Text;
            log = cmbLog.Text;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpDate.MinDate = dtbak.Date;
            dtpDate.MaxDate = DateTime.Now.Date;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime dtstopat = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
            if (dtstopat.Date == dtbak.Date)
            {
                if (dtstopat.TimeOfDay > dtbak.TimeOfDay)
                {
                    RestoreDiaglog(dtstopat);
                }
                else
                {
                    MessageBox.Show("Thời gian Restore phải lớn hơn thời gian của bản Backup.", "Lỗi!", MessageBoxButtons.OK);
                }
            }
            else if (dtstopat.Date == DateTime.Now.Date)
            {
                if (dtstopat.TimeOfDay < DateTime.Now.TimeOfDay.Subtract(new TimeSpan(0, 1, 0)))
                {
                    RestoreDiaglog(dtstopat);
                }
                else
                {
                    MessageBox.Show("Thời gian Restore phải bé hơn thời gian hiện tại ít nhất 1 phút.", "Lỗi!", MessageBoxButtons.OK);
                }
            }
            else
            {
                RestoreDiaglog(dtstopat);
            }
        
        }

        private void frmRestore_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmMain.Enabled = true;
            String strlenh1 = "ALTER DATABASE " + Program.dBname + " SET MULTI_USER";
            Program.myReader = Program.ExecSqlDataReader(strlenh1);
            Program.myReader.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestoreDiaglog(DateTime dtStopAt)
        {
            DialogResult rsdiaglog = MessageBox.Show("Time restore: " + dtStopAt.ToString(), Program.dBname + " - Restore dialog", MessageBoxButtons.OKCancel);
            if (rsdiaglog == DialogResult.OK)
            {
                try
                {
                    String cmd = "USE master GO RESTORE DATABASE " + Program.dBname + " FROM " + device + " WITH NORECOVERY RESTORE LOG "+Program.dBname+" FROM "+log+" WITH STOPAT=N'"+dtStopAt.Date.ToString()+"T"+dtStopAt.TimeOfDay.ToString()+"'";
                    Program.myReader = Program.ExecSqlDataReader(cmd);
                    Program.myReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Restore:\n" + ex, "Xảy ra lỗi", MessageBoxButtons.OK);
                }
            }
            else
            {
                return;
            }
        }
    }
}
