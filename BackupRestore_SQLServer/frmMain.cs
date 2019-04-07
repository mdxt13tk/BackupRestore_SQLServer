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
    public partial class frmMain : Form
    {
        DateTime dtbak;
        Boolean dangxuat = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.databases' table. You can move, or remove it, as needed.
            this.databasesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.databasesTableAdapter.Fill(this.DS.databases);
            this.position_backupsTableAdapter.Connection.ConnectionString = Program.connstr;

            Program.dBname = ((DataRowView)bdsDbs[bdsDbs.Position])["name"].ToString().Trim();
            this.position_backupsTableAdapter.Fill(this.DS.position_backups, Program.dBname);
            Program.bdsPbs = bdsPbs;
            
            tgbtnConnect.Checked = false;
            if (grvPbs.RowCount == 0)
            {
                grctrlPbs.Visible = false;
                btnRestore.Enabled = false;
                pnNf.Visible = true;
                pnNf.Dock = DockStyle.Fill;
            }
            else
            {
                grctrlPbs.Visible = true;
                btnRestore.Enabled = true;
                pnNf.Visible = false;
                grctrlPbs.Dock = DockStyle.Fill;
            }

            lbNf.Left = (pnNf.Width - lbNf.Width) / 2;
            lbBakInfo.Left = (pnBakInfo.Width - lbBakInfo.Width) / 2;
            

        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!dangxuat)
            {
                if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Program.FrmLogin.Visible = true;
                    Program.FrmLogin.Close();
                }
                else e.Cancel = true;
            }
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangxuat = true;
            Program.FrmLogin.Visible = true;
            Program.FrmMain.Close();
        }

        private void btnBakDv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.FrmMain.Enabled = false;
            Program.FrmBakDevice = new frmBakDevice();
            Program.FrmBakDevice.Show();
        }

        private void btnBak_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.FrmMain.Enabled = false;
            frmBak f = new frmBak();
            f.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                this.databasesTableAdapter.Fill(this.DS.databases);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.FrmMain.Enabled = false;
            frmRestore f = new frmRestore();
            f.Show();
        }

        private void grvDbs_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Program.bdsPbs = bdsPbs;
            Program.bdsPbs.Position = bdsPbs.Position;
            tgbtnConnect.Checked = false;
            Program.dBname = ((DataRowView)bdsDbs[bdsDbs.Position])["name"].ToString().Trim();
            this.position_backupsTableAdapter.Fill(this.DS.position_backups, Program.dBname);
            if (grvPbs.RowCount==0)
            {
                grctrlPbs.Visible = false;
                btnRestore.Enabled = false;
                pnNf.Visible = true;
                pnNf.Dock = DockStyle.Fill;
            }
            else
            {
                grctrlPbs.Visible = true;
                btnRestore.Enabled = true;
                pnNf.Visible = false;
                grctrlPbs.Dock = DockStyle.Fill;
            }
        }

        private void grvPbs_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Program.bdsPbs.Position = bdsPbs.Position;
        }
        private void tgbtnConnect_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tgbtnConnect.Checked==false)
            {
                tgbtnConnect.Caption = "MULTI USER";
                String strLenh1 = "ALTER DATABASE "+Program.dBname+" SET MULTI_USER WITH ROLLBACK IMMEDIATE";
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(strLenh1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(""+ex, "Lỗi!", MessageBoxButtons.OK);
                }
                Program.myReader.Close();
            }
            else
            {
                tgbtnConnect.Caption = "SINGLE USER";
                String strLenh2 = "ALTER DATABASE " + Program.dBname + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(strLenh2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(""+ex, "Lỗi!", MessageBoxButtons.OK);
                }
                Program.myReader.Close();
            }
        }
    }
}
