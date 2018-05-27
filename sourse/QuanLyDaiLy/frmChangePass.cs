using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyDaiLy
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }
        Modules.ConnectionString sqlConn = new QuanLyDaiLy.Modules.ConnectionString();
        Modules.Global global = new QuanLyDaiLy.Modules.Global();
        Modules.StringMessage strMess = new QuanLyDaiLy.Modules.StringMessage();
        Error.Error_ChangePass error = new QuanLyDaiLy.Error.Error_ChangePass();

        private SqlCommand commnd = null;
        private string sqlstr;
        private void frmChangePass_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConn.getConnectionString();
            }
            catch
            {
                MessageBox.Show(strMess.ChuaKetNoiCSDL, strMess.TieuDe_Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();
            string strDangNhap = frmMain.strTenDangNhap;
            string strMatKhau = txtMatKhauCu.Text.Trim();
            string strChuoiDieuKien = "TenDangNhap='" + strDangNhap + "' and MatKhau='" + strMatKhau + "'";
            string strTableName = "TaiKhoan";
            if (global.Test_Database(strChuoiDieuKien, strTableName, sqlConn.sqlCNN))
            {
                string strMatKhauMoi = txtMatKhauMoi.Text.Trim();
                string strLapLaiMatKhau = txtNhapLaiMK.Text.Trim();
                try
                {
                    error.Exception_MatKhau(strMatKhauMoi, commnd);
                    error.Exception_MatKhau(strLapLaiMatKhau, commnd);
                    if (!(strMatKhauMoi == "" || strLapLaiMatKhau == ""))
                    {
                        if (strMatKhauMoi == strLapLaiMatKhau && strMatKhauMoi != strMatKhau )
                        {
                            sqlstr = "update TaiKhoan set MatKhau='" + strMatKhauMoi + "' where TenDangNhap='" + strDangNhap + "' ";
                            global.SQL_Database(sqlstr, sqlConn.sqlCNN);
                        }
                        else
                        {
                            MessageBox.Show(strMess.MatKhauKhac, strMess.TieuDe_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới của bạn không được rỗng", strMess.TieuDe_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                { }
            }
            else
            {
                MessageBox.Show(strMess.MatKhauCu, strMess.TieuDe_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Download source code tại Sharecode.vn
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}