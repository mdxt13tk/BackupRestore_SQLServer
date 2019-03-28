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
    public partial class frmBakDevice : Form
    {
        public frmBakDevice()
        {
            InitializeComponent();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            Program.FrmBakDevice.Enabled = false;
            frmCreateBakDevice f = new frmCreateBakDevice();
            f.Show();
        }

        private void frmBakDevice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmMain.Enabled = true;
        }
    }
}
