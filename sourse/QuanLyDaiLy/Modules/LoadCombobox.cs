using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyDaiLy.Modules
{
    public class LoadCombobox
    {
        public void Load_LoaiDaiLy(string sqlstr, string display,string value, ComboBox combobox, SqlConnection conn)
        {
            combobox.Items.Clear();
            //sqlstr = "SELECT MaLoaiDaiLy, TenLoaiDaiLy FROM LoaiDaiLy ORDER BY MaLoaiDaiLy ";
            SqlDataAdapter sqlAdp = new SqlDataAdapter(sqlstr, conn);
            DataTable dtLoad = new DataTable();
            sqlAdp.Fill(dtLoad);
            if ((dtLoad != null) && (dtLoad.Rows.Count > 0))
            {
                combobox.DataSource = dtLoad;
                combobox.DisplayMember = display;
                //combobox.DisplayMember = "TenLoaiDaiLy";
                combobox.ValueMember = value;
            }
            dtLoad = null;
            sqlAdp.Dispose();
        }
    }
}
