namespace WindowsFormsApplication1
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.label13 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btluu = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.dtpkgioban = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpkngayban = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.txtSlban = new System.Windows.Forms.TextBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDongiaban = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.btghang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(8, 649);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 27);
            this.label13.TabIndex = 73;
            this.label13.Text = "Tổng tiền: ";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(155, 786);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(279, 27);
            this.txttimkiem.TabIndex = 72;
            // 
            // btTimkiem
            // 
            this.btTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimkiem.Image")));
            this.btTimkiem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btTimkiem.Location = new System.Drawing.Point(450, 780);
            this.btTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(134, 35);
            this.btTimkiem.TabIndex = 71;
            this.btTimkiem.Text = "Tìm kiếm";
            this.btTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimkiem.UseVisualStyleBackColor = true;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 784);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 26);
            this.label10.TabIndex = 70;
            this.label10.Text = "Mã hóa đơn:";
            // 
            // btluu
            // 
            this.btluu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.Image = ((System.Drawing.Image)(resources.GetObject("btluu.Image")));
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.Location = new System.Drawing.Point(598, 705);
            this.btluu.Margin = new System.Windows.Forms.Padding(4);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(176, 45);
            this.btluu.TabIndex = 69;
            this.btluu.Text = "Lưu hóa đơn ";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btHuy
            // 
            this.btHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Image = ((System.Drawing.Image)(resources.GetObject("btHuy.Image")));
            this.btHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuy.Location = new System.Drawing.Point(802, 705);
            this.btHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(118, 45);
            this.btHuy.TabIndex = 68;
            this.btHuy.Text = "     Hủy ";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // dtpkgioban
            // 
            this.dtpkgioban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkgioban.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkgioban.Location = new System.Drawing.Point(186, 134);
            this.dtpkgioban.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkgioban.Name = "dtpkgioban";
            this.dtpkgioban.Size = new System.Drawing.Size(272, 30);
            this.dtpkgioban.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 136);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 25);
            this.label11.TabIndex = 66;
            this.label11.Text = "Giờ bán: ";
            // 
            // dtpkngayban
            // 
            this.dtpkngayban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkngayban.Location = new System.Drawing.Point(623, 93);
            this.dtpkngayban.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkngayban.Name = "dtpkngayban";
            this.dtpkngayban.Size = new System.Drawing.Size(279, 30);
            this.dtpkngayban.TabIndex = 65;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(487, 94);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 25);
            this.label12.TabIndex = 64;
            this.label12.Text = "Ngày bán:";
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(404, 705);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(180, 45);
            this.btSua.TabIndex = 63;
            this.btSua.Text = "Sửa hóa đơn ";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(207, 705);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(176, 45);
            this.btXoa.TabIndex = 62;
            this.btXoa.Text = " Xóa hóa đơn ";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(13, 705);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(171, 45);
            this.btThem.TabIndex = 61;
            this.btThem.Text = "Thêm hóa đơn";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 183);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 26);
            this.label9.TabIndex = 60;
            this.label9.Text = "Thông tin hàng bán: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(487, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 58;
            this.label7.Text = "Tên hàng ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(487, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "Đơn giá bán ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 26);
            this.label4.TabIndex = 56;
            this.label4.Text = "Thông tin đơn hàng:";
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHDB.Location = new System.Drawing.Point(186, 94);
            this.txtMaHDB.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(272, 30);
            this.txtMaHDB.TabIndex = 55;
            // 
            // txtSlban
            // 
            this.txtSlban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlban.Location = new System.Drawing.Point(187, 276);
            this.txtSlban.Margin = new System.Windows.Forms.Padding(4);
            this.txtSlban.Name = "txtSlban";
            this.txtSlban.Size = new System.Drawing.Size(272, 30);
            this.txtSlban.TabIndex = 54;
            // 
            // txtTenhang
            // 
            this.txtTenhang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenhang.Location = new System.Drawing.Point(632, 225);
            this.txtTenhang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(279, 30);
            this.txtTenhang.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(36, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // txtDongiaban
            // 
            this.txtDongiaban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDongiaban.Location = new System.Drawing.Point(632, 276);
            this.txtDongiaban.Margin = new System.Windows.Forms.Padding(4);
            this.txtDongiaban.Name = "txtDongiaban";
            this.txtDongiaban.Size = new System.Drawing.Size(279, 30);
            this.txtDongiaban.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Số lượng bán";
            // 
            // txtMaH
            // 
            this.txtMaH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaH.Location = new System.Drawing.Point(186, 227);
            this.txtMaH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaH.Name = "txtMaH";
            this.txtMaH.Size = new System.Drawing.Size(272, 30);
            this.txtMaH.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(36, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(301, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 35);
            this.label2.TabIndex = 46;
            this.label2.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(921, 305);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhtien.Location = new System.Drawing.Point(131, 649);
            this.txtThanhtien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.ReadOnly = true;
            this.txtThanhtien.Size = new System.Drawing.Size(337, 30);
            this.txtThanhtien.TabIndex = 52;
            // 
            // btghang
            // 
            this.btghang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btghang.Image = ((System.Drawing.Image)(resources.GetObject("btghang.Image")));
            this.btghang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btghang.Location = new System.Drawing.Point(547, 640);
            this.btghang.Margin = new System.Windows.Forms.Padding(4);
            this.btghang.Name = "btghang";
            this.btghang.Size = new System.Drawing.Size(227, 45);
            this.btghang.TabIndex = 74;
            this.btghang.Text = "Thêm vào giỏ hàng";
            this.btghang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btghang.UseVisualStyleBackColor = true;
            this.btghang.Click += new System.EventHandler(this.btghang_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 827);
            this.Controls.Add(this.btghang);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btTimkiem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.dtpkgioban);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpkngayban);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaHDB);
            this.Controls.Add(this.txtSlban);
            this.Controls.Add(this.txtTenhang);
            this.Controls.Add(this.txtThanhtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDongiaban);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmHoaDon";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.DateTimePicker dtpkgioban;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpkngayban;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.TextBox txtSlban;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDongiaban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.Button btghang;
    }
}

