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
            String strlenh = "ALTER DATABASE "+Program.dBname+" SET MULTI_USER";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            Program.myReader.Close();   
        }

        private void frmRestore_Load(object sender, EventArgs e)
        {
            String strlenh = "ALTER DATABASE " + Program.dBname + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            Program.myReader.Close();
        }
    }
}
