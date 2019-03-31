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
        public frmRestore()
        {
            InitializeComponent();
        }

        private void frmRestore_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmMain.Enabled = true;
        }
    }
}
