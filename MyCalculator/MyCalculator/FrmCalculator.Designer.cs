namespace MyCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(96, 53);
            this.txtSo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(132, 22);
            this.txtSo1.TabIndex = 0;
            this.txtSo1.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(403, 53);
            this.txtSo2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(132, 22);
            this.txtSo2.TabIndex = 1;
            this.txtSo2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(248, 117);
            this.txtKQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(132, 22);
            this.txtKQ.TabIndex = 2;
            // 
            // btnCong
            // 
            this.btnCong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCong.Location = new System.Drawing.Point(57, 199);
            this.btnCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(100, 36);
            this.btnCong.TabIndex = 3;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = false;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTru.Location = new System.Drawing.Point(197, 199);
            this.btnTru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(100, 36);
            this.btnTru.TabIndex = 4;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = false;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNhan.Location = new System.Drawing.Point(335, 199);
            this.btnNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(100, 36);
            this.btnNhan.TabIndex = 5;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = false;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnChia.Location = new System.Drawing.Point(477, 199);
            this.btnChia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(100, 36);
            this.btnChia.TabIndex = 6;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = false;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(621, 343);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "MyCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
    }
}

