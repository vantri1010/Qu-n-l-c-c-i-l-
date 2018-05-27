using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLiDaiLy
{
    public partial class FormGioiThieu : Form
    {
        int index = -1;
        public FormGioiThieu()
        {
            InitializeComponent();
        }
        
        private void FormGioiThieu_Load(object sender, EventArgs e)
        {
            timerGt1.Enabled = true;
            timerGt2.Enabled = true;
        }

        private void timerGt_Tick(object sender, EventArgs e)
        {
            //Hiển thị hình ảnh liên tục trong picturebox
            if (index < imageListGt.Images.Count - 1) index++;
            timerGt1.Enabled = false;
            timerGt1.Interval = 1200;      
            picBoxGioiThieu.Image = imageListGt.Images[index];
            timerGt1.Enabled = true;

            //Hiển thị Form chính sau 7 giây
            if (index == 6)
            {
                timerGt1.Stop();
                this.Hide();
                QuanLyDaiLy.frmMain FormC = new QuanLyDaiLy.frmMain();
                FormC.ShowDialog();                       
            }
        }

        private void timerGt2_Tick(object sender, EventArgs e)
        {
            timerGt2.Interval = 150;
            label2.Left += 10;
            //label2.Text = label2.Text.Substring(label2.Text.Length - 1, 1) + label2.Text.Substring(0, label2.Text.Length - 1);
        }        
    }
}