using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupRestore_SQLServer
{
    public partial class frmCreateBakDevice : Form
    {
        public frmCreateBakDevice()
        {
            InitializeComponent();
        }

        private void frmCreateBakDevice_Load(object sender, EventArgs e)
        {
            txtPath.Enabled = false;
            btnOK.Enabled = false;

            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Disk");
            dict.Add(2, "Pipe");
            dict.Add(3, "Tape");
            cmbType.DataSource = new BindingSource(dict, null);
            cmbType.DisplayMember = "Value";
            cmbType.ValueMember = "Value";
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefd = new SaveFileDialog();
            savefd.Title = "Save Device backup";
            savefd.Filter = "Backup file (*.bak)|*.bak";
            if (savefd.ShowDialog()==DialogResult.OK)
            {
                txtPath.Text = savefd.FileName;
                Program.bakdevname = Path.GetFileNameWithoutExtension(txtPath.Text);
                btnOK.Enabled = true;
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String strLenh = "USE master\nEXEC sp_addumpdevice '"+cmbType.SelectedValue.ToString()+"', '"+Program.bakdevname+"', '"+txtPath.Text+"'";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader != null)
                {
                    MessageBox.Show("Successfully!", "", MessageBoxButtons.OK);
                }
                else return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "!", MessageBoxButtons.OK);
                return;
            }
            Program.myReader.Close();
            Program.conn.Close();
            this.Close();
        }

        private void frmCreateBakDevice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmBakDevice.Enabled = true;
        }
    }
}
