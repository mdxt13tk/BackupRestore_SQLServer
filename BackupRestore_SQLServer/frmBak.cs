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
    public partial class frmBak : Form
    {
        public frmBak()
        {
            InitializeComponent();
        }

        private void frmBak_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmMain.Enabled = true;
        }

        private void frmBak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.backup_devices' table. You can move, or remove it, as needed.
            this.backup_devicesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.backup_devicesTableAdapter.Fill(this.DS.backup_devices);

            lblDbName.Text = Program.dBname;
            String s0 = "SELECT database_name FROM msdb.dbo.Backupset WHERE database_name='" + lblDbName.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(s0);
            //nếu bản full đã tồn tại thì cho hiện differential.
            if (Program.myReader.HasRows)
            {
                IDictionary<int, string> dict = new Dictionary<int, string>();
                dict.Add(1, "Full");
                dict.Add(2, "Differential");
                dict.Add(3, "Transaction log");
                cmbBakType.DataSource = new BindingSource(dict, null);
            }
            //chưa tồn tại thì k hiện.
            else
            {
                IDictionary<int, string> dict = new Dictionary<int, string>();
                dict.Add(1, "Full");
                dict.Add(2, "Transaction log");
                cmbBakType.DataSource = new BindingSource(dict, null);
            }
            Program.myReader.Close();
            cmbBakType.DisplayMember = "Value";
            cmbBakType.ValueMember = "Value";

        }

        private void cmbBakType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBakType.SelectedValue.ToString() != "Transaction log")
            {
                txtDescript.Enabled = true;
            }
            else
            {
                txtDescript.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String sbak = "";
            String slogbak = "";
            String ow = "";

            if (chkboxOw.Checked == true)
            {
                if (cmbBakType.SelectedValue.ToString() != "Transaction log") ow = ", INIT";
                else ow = " WITH INIT";
            }

            sbak = "BACKUP DATABASE " + Program.dBname.Trim() + " TO " + cmbBakDevice.SelectedValue.ToString() + " WITH DESCRIPTION = '" + txtDescript.Text.Trim() + "'" + ow;
            slogbak = "BACKUP LOG " + Program.dBname.Trim() + " TO " + cmbBakDevice.SelectedValue.ToString() + ow;
            try
            {
                if (cmbBakType.SelectedValue.ToString() != "Transaction log")
                {
                    Program.myReader = Program.ExecSqlDataReader(sbak);
                }
                else
                {
                    Program.myReader = Program.ExecSqlDataReader(slogbak);
                }
                Program.myReader.Close();
                MessageBox.Show("Backup thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Backup được!\n"+ex, "Lỗi!", MessageBoxButtons.OK);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkboxOw_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkboxOw.Checked == true)
            {
                MessageBox.Show("Các bản Backup trong Device này sẽ bị GHI ĐÈ.\nBạn có muốn tiếp tục?", "WARNING!!!", MessageBoxButtons.OK);
            }
        }
    }

}

