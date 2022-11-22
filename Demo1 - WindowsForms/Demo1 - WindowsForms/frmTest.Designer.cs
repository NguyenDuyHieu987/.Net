namespace Demo1___WindowsForms
{
    partial class frmTest
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
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.lbMaChucVu = new System.Windows.Forms.Label();
            this.lbTenChucVu = new System.Windows.Forms.Label();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.lbHSPhuCap = new System.Windows.Forms.Label();
            this.txtHeSoPhuCap = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnSoNhanVien = new System.Windows.Forms.Button();
            this.btnPROC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(63, 128);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(109, 45);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // lbMaChucVu
            // 
            this.lbMaChucVu.AutoSize = true;
            this.lbMaChucVu.Location = new System.Drawing.Point(357, 70);
            this.lbMaChucVu.Name = "lbMaChucVu";
            this.lbMaChucVu.Size = new System.Drawing.Size(101, 22);
            this.lbMaChucVu.TabIndex = 7;
            this.lbMaChucVu.Text = "Mã chức vụ";
            // 
            // lbTenChucVu
            // 
            this.lbTenChucVu.AutoSize = true;
            this.lbTenChucVu.Location = new System.Drawing.Point(357, 140);
            this.lbTenChucVu.Name = "lbTenChucVu";
            this.lbTenChucVu.Size = new System.Drawing.Size(109, 22);
            this.lbTenChucVu.TabIndex = 8;
            this.lbTenChucVu.Text = "Tên chức vụ";
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Location = new System.Drawing.Point(507, 67);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(224, 27);
            this.txtMaChucVu.TabIndex = 1;
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Location = new System.Drawing.Point(507, 135);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(224, 27);
            this.txtTenChucVu.TabIndex = 2;
            // 
            // lbHSPhuCap
            // 
            this.lbHSPhuCap.AutoSize = true;
            this.lbHSPhuCap.Location = new System.Drawing.Point(357, 221);
            this.lbHSPhuCap.Name = "lbHSPhuCap";
            this.lbHSPhuCap.Size = new System.Drawing.Size(126, 22);
            this.lbHSPhuCap.TabIndex = 9;
            this.lbHSPhuCap.Text = "Hệ số phụ cấp";
            // 
            // txtHeSoPhuCap
            // 
            this.txtHeSoPhuCap.Location = new System.Drawing.Point(507, 218);
            this.txtHeSoPhuCap.Name = "txtHeSoPhuCap";
            this.txtHeSoPhuCap.Size = new System.Drawing.Size(224, 27);
            this.txtHeSoPhuCap.TabIndex = 3;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(63, 218);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(109, 45);
            this.btnHienThi.TabIndex = 5;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnSoNhanVien
            // 
            this.btnSoNhanVien.Location = new System.Drawing.Point(54, 306);
            this.btnSoNhanVien.Name = "btnSoNhanVien";
            this.btnSoNhanVien.Size = new System.Drawing.Size(129, 45);
            this.btnSoNhanVien.TabIndex = 6;
            this.btnSoNhanVien.Text = "Số nhân viên";
            this.btnSoNhanVien.UseVisualStyleBackColor = true;
            this.btnSoNhanVien.Click += new System.EventHandler(this.btnSoNhanVien_Click);
            // 
            // btnPROC
            // 
            this.btnPROC.Location = new System.Drawing.Point(288, 306);
            this.btnPROC.Name = "btnPROC";
            this.btnPROC.Size = new System.Drawing.Size(129, 45);
            this.btnPROC.TabIndex = 10;
            this.btnPROC.Text = "Procedure";
            this.btnPROC.UseVisualStyleBackColor = true;
            this.btnPROC.Click += new System.EventHandler(this.btnPROC_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 469);
            this.Controls.Add(this.btnPROC);
            this.Controls.Add(this.btnSoNhanVien);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.txtHeSoPhuCap);
            this.Controls.Add(this.lbHSPhuCap);
            this.Controls.Add(this.txtTenChucVu);
            this.Controls.Add(this.txtMaChucVu);
            this.Controls.Add(this.lbTenChucVu);
            this.Controls.Add(this.lbMaChucVu);
            this.Controls.Add(this.btnThemMoi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Label lbMaChucVu;
        private System.Windows.Forms.Label lbTenChucVu;
        private System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.Label lbHSPhuCap;
        private System.Windows.Forms.TextBox txtHeSoPhuCap;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnSoNhanVien;
        private System.Windows.Forms.Button btnPROC;
    }
}