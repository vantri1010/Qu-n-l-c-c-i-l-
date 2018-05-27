using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace QuanLyDaiLy.Modules
{
    public class Global
    {
        Modules.ConnectionString sqlConn = new ConnectionString();
        Modules.StringMessage strMess = new StringMessage();

        int i = 0;
        bool flag = false;
        SqlCommand commn= null;
        //Hàm Kiểm Tra dữ liệu có trong Database hay không
        public Boolean Test_Database(string strChuoiDieuKien, string strTableName, SqlConnection sqlCNN)
        {
            bool bolReturn = false;
            string strSQL = "SELECT * FROM " + strTableName.Trim() + " WHERE " + strChuoiDieuKien + "";
            SqlCommand sqlCmd = new SqlCommand(strSQL, sqlCNN);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            if ((sqlReader != null) && (!sqlReader.IsClosed)) sqlReader.Close();
            sqlReader = sqlCmd.ExecuteReader();
            if (sqlReader.HasRows)
                bolReturn = true;//Ton tai mau tin == True            
            sqlReader.Dispose();
            sqlReader.Close();
            return bolReturn;
        }

        //Hàm thực hiện câu lệnh SQL
        public void SQL_Database(string str, SqlConnection conn)
        {
            if (MessageBox.Show(strMess.ThucHienThaoTac,strMess.TieuDe_Message, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SqlCommand commn = new SqlCommand(str, conn);
                commn.ExecuteNonQuery();
                MessageBox.Show(strMess.ThaoTacThanhCong, strMess.TieuDe_Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                flag = true;
            }
            else
            {
                MessageBox.Show(strMess.HuyThaoTac, strMess.TieuDe_Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                commn.ExecuteNonQuery();
            }
        }

        public void SQL_Database_NoMessage(string str, SqlConnection conn)
        {
            if (flag)
            {
                SqlCommand commn = new SqlCommand(str, conn);
                commn.ExecuteNonQuery();
            }
            else
            {
                SqlCommand commn = new SqlCommand(str, conn);
                commn.ExecuteNonQuery();
            }
        }

        //Lấy Datagrid
        public void Seach_DataGrid(string sqlstr, SqlConnection conn, DataGrid dataGW)
        {
            if (MessageBox.Show("Bạn có muốn thực hiện thao tác này", "Quản Lý Đại Lý", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlstr, conn);
                DataSet dSet = new DataSet("HSResultssss");
                adapter.Fill(dSet, "HSResultssss");
                dataGW.DataSource = dSet.Tables[0];
            }
            else
            {
                MessageBox.Show("Bạn Đã Huỷ Thao Tác", "Quản Lý Đại Lý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Datagrid
        public DataGridTableStyle MyTableStyleCreate()
        {
            DataGridTableStyle MyStyle = new DataGridTableStyle();
            MyStyle.RowHeadersVisible = false;
            MyStyle.SelectionForeColor = Color.SlateGray;
            MyStyle.AlternatingBackColor = Color.Ivory;
            MyStyle.PreferredRowHeight = 10;
            MyStyle.RowHeaderWidth = 10;
            MyStyle.AllowSorting = false;
            return MyStyle;
        }

        public void LoadDataInToDatagrid(string str,SqlConnection sqlCNN,DataGrid dgrid)
        {
            try
            {
                SqlDataAdapter sqlADP = new SqlDataAdapter(str, sqlCNN);
                DataTable dttable = new DataTable();
                sqlADP.Fill(dttable);
                dttable.DefaultView.AllowEdit = false;
                dttable.DefaultView.AllowNew = false;
                dttable.DefaultView.AllowDelete = false;
                dgrid.DataSource = dttable;
            }
            catch 
            {
                MessageBox.Show("Ngày Tháng Của Bạn Nhập Vào Chưa Chính Xác", strMess.TieuDe_Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Kiểm tra có phải kí tự là 1 số
        public Boolean Test_Number(string str)
        {
            //Số Nguyên
            //int kt = 0;
            //for (i = 0; i < str.Length; i++)
            //{
            //    if ((str[i].ToString()[0] < '0') || str[i].ToString()[0] > '9')
            //    {
            //        kt = kt + 1;
            //        break;
            //    }
            //}
            //if (kt == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            //Số Thực
            int kt = 0;
            for (i = 0; i < str.Length; i++)
            {
                if (((str[i].ToString()[0] >= '0') && str[i].ToString()[0] <= '9') || str[i].ToString()[0] == '.')
                {
                    kt = 0;
                }
                else
                {
                    kt = kt + 1;
                    break;
                }
            }
            if (kt == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Hàm Chuyển ngày tháng năm thành năm tháng ngày
        public string Return_Time_ThangNgay(string str)
        {
            //string strNgay = str.Substring(0, 3);
            //string strThang = str.Substring(3, 3);
            //string strNam = str.Substring(6, 4);
            //return strThang + strNgay + strNam;
            int a = str.IndexOf('/', 0);
            int b = str.IndexOf('/', a+1);
            string strNgay = str.Substring(0, a+1);
            string strThang = str.Substring(a+1,b-a);
            string strNam = str.Substring(b+1, 4);
            return strThang + strNgay + strNam;
        }
    }
}
