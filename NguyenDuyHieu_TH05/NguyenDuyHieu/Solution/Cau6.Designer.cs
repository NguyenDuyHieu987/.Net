namespace NguyenDuyHieu.Solution
{
    partial class Cau6
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
            this.btnHienThi = new System.Windows.Forms.Button();
            this.grThongTin_HetHan = new System.Windows.Forms.GroupBox();
            this.dataGridViewThongTin_NCC = new System.Windows.Forms.DataGridView();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grThongTin_HetHan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTin_NCC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(337, 114);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(134, 42);
            this.btnHienThi.TabIndex = 7;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // grThongTin_HetHan
            // 
            this.grThongTin_HetHan.Controls.Add(this.dataGridViewThongTin_NCC);
            this.grThongTin_HetHan.Location = new System.Drawing.Point(21, 197);
            this.grThongTin_HetHan.Name = "grThongTin_HetHan";
            this.grThongTin_HetHan.Size = new System.Drawing.Size(835, 281);
            this.grThongTin_HetHan.TabIndex = 6;
            this.grThongTin_HetHan.TabStop = false;
            this.grThongTin_HetHan.Text = "Thông tin của sản phẩm có nhà cung cấp trên ";
            // 
            // dataGridViewThongTin_NCC
            // 
            this.dataGridViewThongTin_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTin_NCC.Location = new System.Drawing.Point(11, 42);
            this.dataGridViewThongTin_NCC.Name = "dataGridViewThongTin_NCC";
            this.dataGridViewThongTin_NCC.Size = new System.Drawing.Size(824, 233);
            this.dataGridViewThongTin_NCC.TabIndex = 0;
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(427, 49);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(163, 27);
            this.txtNCC.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập nhà cung cấp";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(580, 114);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(134, 42);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // Cau6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 481);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.grThongTin_HetHan);
            this.Controls.Add(this.txtNCC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Cau6";
            this.Text = "Cau6";
            this.Load += new System.EventHandler(this.Cau6_Load);
            this.grThongTin_HetHan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTin_NCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.GroupBox grThongTin_HetHan;
        private System.Windows.Forms.DataGridView dataGridViewThongTin_NCC;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
    }
}