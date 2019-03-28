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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtServer.Focus();
            txtServer.Text = "TK13SERVER00";
            txtLogin.Text = "sa";
            txtPass.Text = "sa";
            btnLogin.PerformClick();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtServer.Focus();
            if (txtServer.Text.Trim() == "" || txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!\nMời nhập lại.", "Lỗi đăng nhập!", MessageBoxButtons.OK);
                txtServer.Focus();
                return;
            }

            Program.servername = "TK13\\"+txtServer.Text.Trim().ToUpper();
            Program.loginname = txtLogin.Text.Trim();
            Program.password = txtPass.Text.Trim();
            
            if (Program.KetNoi() == 0) return;
            Program.conn.Close();

            Program.FrmMain = new frmMain();
            Program.FrmMain.Show();
            Program.FrmLogin.Visible = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Program.FrmLogin.Close();
        }
    }
}
