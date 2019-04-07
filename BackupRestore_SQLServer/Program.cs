using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupRestore_SQLServer
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;

        public static String servername;
        public static String loginname;
        public static String password;
        public static String bakdevname;
        public static String dBname;
        public static BindingSource bdsPbs;

        public static frmLogin FrmLogin;
        public static frmMain FrmMain;
        public static frmBakDevice FrmBakDevice;
        public static int KetNoi() //null thì lỗi, không null thì chạy
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";User ID=" + Program.loginname + ";password=" + Program.password;
                //Program.conn.ConnectionString = connstr;
                Program.conn = new SqlConnection(Program.connstr);
                Program.conn.Open();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại username và password.\n" + ex.Message, "Lỗi kết nối!", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh) //truy vấn nhanh, chỉ thích hợp để xem; không cho sửa, thêm, xóa; nếu nhiều dòng, chỉ cho phép đi xuống, k cho phép đi ngược lại.
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300; // Đợi lệnh chạy. đơn vị: giây.
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close(); //vì sao phải close kết nối??
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin = new frmLogin();
            Application.Run(FrmLogin);

        }
    }
}
