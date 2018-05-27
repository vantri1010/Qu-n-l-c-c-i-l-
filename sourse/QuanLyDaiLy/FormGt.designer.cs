namespace QuanLiDaiLy
{
    partial class FormGioiThieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGioiThieu));
            this.imageListGt = new System.Windows.Forms.ImageList(this.components);
            this.timerGt1 = new System.Windows.Forms.Timer(this.components);
            this.picBoxGioiThieu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerGt2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGioiThieu)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListGt
            // 
            this.imageListGt.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListGt.ImageStream")));
            this.imageListGt.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListGt.Images.SetKeyName(0, "1fb925af.png");
            this.imageListGt.Images.SetKeyName(1, "EE19.jpg");
            this.imageListGt.Images.SetKeyName(2, "m57823204.png");
            this.imageListGt.Images.SetKeyName(3, "z7833681.jpg");
            this.imageListGt.Images.SetKeyName(4, "z12638990.png");
            this.imageListGt.Images.SetKeyName(5, "z57289214.png");
            this.imageListGt.Images.SetKeyName(6, "z74619478.png");
            // 
            // timerGt1
            // 
            this.timerGt1.Tick += new System.EventHandler(this.timerGt_Tick);
            // 
            // picBoxGioiThieu
            // 
            this.picBoxGioiThieu.Location = new System.Drawing.Point(210, 124);
            this.picBoxGioiThieu.Name = "picBoxGioiThieu";
            this.picBoxGioiThieu.Size = new System.Drawing.Size(100, 100);
            this.picBoxGioiThieu.TabIndex = 0;
            this.picBoxGioiThieu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(78, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ CÁC ĐẠI LÍ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(-3, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "";
            // 
            // timerGt2
            // 
            this.timerGt2.Tick += new System.EventHandler(this.timerGt2_Tick);
            // 
            // FormGioiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(521, 289);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxGioiThieu);
            this.Name = "FormGioiThieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormGioiThieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGioiThieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageListGt;
        private System.Windows.Forms.Timer timerGt1;
        private System.Windows.Forms.PictureBox picBoxGioiThieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerGt2;
    }
}

