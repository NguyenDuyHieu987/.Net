namespace NguyenDuyHieu.Solution
{
    partial class Cau1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedtxtNamSinh = new System.Windows.Forms.MaskedTextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTenCD = new System.Windows.Forms.TextBox();
            this.txtMaPhuong = new System.Windows.Forms.TextBox();
            this.txtMaCD = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbNamSinh = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbTenCD = new System.Windows.Forms.Label();
            this.lbMaPhuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedtxtNamSinh);
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtTenCD);
            this.groupBox1.Controls.Add(this.txtMaPhuong);
            this.groupBox1.Controls.Add(this.txtMaCD);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.lbNamSinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbSDT);
            this.groupBox1.Controls.Add(this.lbCMND);
            this.groupBox1.Controls.Add(this.lbTenCD);
            this.groupBox1.Controls.Add(this.lbMaPhuong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 451);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diều tra dân số";
            // 
            // maskedtxtNamSinh
            // 
            this.maskedtxtNamSinh.Location = new System.Drawing.Point(677, 97);
            this.maskedtxtNamSinh.Mask = "0000";
            this.maskedtxtNamSinh.Name = "maskedtxtNamSinh";
            this.maskedtxtNamSinh.Size = new System.Drawing.Size(277, 27);
            this.maskedtxtNamSinh.TabIndex = 15;
            this.maskedtxtNamSinh.ValidatingType = typeof(int);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbGioiTinh.Location = new System.Drawing.Point(677, 40);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(277, 28);
            this.cbGioiTinh.TabIndex = 14;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(677, 154);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(277, 27);
            this.txtSDT.TabIndex = 13;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(187, 215);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(277, 27);
            this.txtCMND.TabIndex = 10;
            // 
            // txtTenCD
            // 
            this.txtTenCD.Location = new System.Drawing.Point(187, 154);
            this.txtTenCD.Name = "txtTenCD";
            this.txtTenCD.Size = new System.Drawing.Size(277, 27);
            this.txtTenCD.TabIndex = 9;
            // 
            // txtMaPhuong
            // 
            this.txtMaPhuong.Location = new System.Drawing.Point(187, 97);
            this.txtMaPhuong.Name = "txtMaPhuong";
            this.txtMaPhuong.Size = new System.Drawing.Size(277, 27);
            this.txtMaPhuong.TabIndex = 8;
            // 
            // txtMaCD
            // 
            this.txtMaCD.Location = new System.Drawing.Point(187, 44);
            this.txtMaCD.Name = "txtMaCD";
            this.txtMaCD.Size = new System.Drawing.Size(277, 27);
            this.txtMaCD.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(91, 303);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 49);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbNamSinh
            // 
            this.lbNamSinh.AutoSize = true;
            this.lbNamSinh.Location = new System.Drawing.Point(535, 100);
            this.lbNamSinh.Name = "lbNamSinh";
            this.lbNamSinh.Size = new System.Drawing.Size(130, 22);
            this.lbNamSinh.TabIndex = 5;
            this.lbNamSinh.Text = "Nhập năm sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nhập giới tính";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(535, 157);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(115, 22);
            this.lbSDT.TabIndex = 4;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Location = new System.Drawing.Point(6, 220);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(111, 22);
            this.lbCMND.TabIndex = 3;
            this.lbCMND.Text = "Nhập CMND";
            // 
            // lbTenCD
            // 
            this.lbTenCD.AutoSize = true;
            this.lbTenCD.Location = new System.Drawing.Point(6, 157);
            this.lbTenCD.Name = "lbTenCD";
            this.lbTenCD.Size = new System.Drawing.Size(162, 22);
            this.lbTenCD.TabIndex = 2;
            this.lbTenCD.Text = "Nhập tên công dân";
            // 
            // lbMaPhuong
            // 
            this.lbMaPhuong.AutoSize = true;
            this.lbMaPhuong.Location = new System.Drawing.Point(6, 97);
            this.lbMaPhuong.Name = "lbMaPhuong";
            this.lbMaPhuong.Size = new System.Drawing.Size(147, 22);
            this.lbMaPhuong.TabIndex = 1;
            this.lbMaPhuong.Text = "Nhập mã phường";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã công dân";
            // 
            // Cau1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 470);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Cau1";
            this.Text = "Cau1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTenCD;
        private System.Windows.Forms.TextBox txtMaPhuong;
        private System.Windows.Forms.TextBox txtMaCD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbNamSinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbTenCD;
        private System.Windows.Forms.Label lbMaPhuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.MaskedTextBox maskedtxtNamSinh;
    }
}