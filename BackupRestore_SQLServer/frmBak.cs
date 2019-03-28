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
            grbFullBak.Enabled = false;
            String s0 = "SELECT database_name FROM msdb.dbo.Backupset WHERE database_name='"+lblDbName.Text+"'";
            Program.myReader = Program.ExecSqlDataReader(s0);
            if (Program.myReader.HasRows)
            {
                IDictionary<int, string> dict = new Dictionary<int, string>();
                dict.Add(1, "Full");
                dict.Add(2, "Differential");
                dict.Add(3, "Transaction log");
                cmbBakType.DataSource = new BindingSource(dict, null);
            }
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

            String s1 = "";
            if (chkboxFullBak.Checked==true)
            {
                grbFullBak.Enabled = true;
                s1 =s1+ "BACKUP DATABASE " + Program.dBname.Trim() + " TO " + cmbBakDevice.SelectedValue.ToString() + " WITH DESCRIPTION = '" + txtDescript.Text.Trim()+"', ";
                
            }
            
        }
        
    }
}
