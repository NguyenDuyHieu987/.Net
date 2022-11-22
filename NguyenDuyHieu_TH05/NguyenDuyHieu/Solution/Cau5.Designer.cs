namespace NguyenDuyHieu.Solution
{
    partial class Cau5
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
            this.grThongTin_HetHan = new System.Windows.Forms.GroupBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.dataGridViewThongTin_Hethan = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grThongTin_HetHan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTin_Hethan)).BeginInit();
            this.SuspendLayout();
            // 
            // grThongTin_HetHan
            // 
            this.grThongTin_HetHan.Controls.Add(this.dataGridViewThongTin_Hethan);
            this.grThongTin_HetHan.Location = new System.Drawing.Point(1, 156);
            this.grThongTin_HetHan.Name = "grThongTin_HetHan";
            this.grThongTin_HetHan.Size = new System.Drawing.Size(835, 281);
            this.grThongTin_HetHan.TabIndex = 0;
            this.grThongTin_HetHan.TabStop = false;
            this.grThongTin_HetHan.Text = "Thông tin sản phẩm hết hạn hoặc số lượng tồn bằng 0";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(273, 53);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(134, 42);
            this.btnHienThi.TabIndex = 1;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // dataGridViewThongTin_Hethan
            // 
            this.dataGridViewThongTin_Hethan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTin_Hethan.Location = new System.Drawing.Point(11, 42);
            this.dataGridViewThongTin_Hethan.Name = "dataGridViewThongTin_Hethan";
            this.dataGridViewThongTin_Hethan.Size = new System.Drawing.Size(824, 233);
            this.dataGridViewThongTin_Hethan.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(541, 53);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(134, 42);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // Cau5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 449);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.grThongTin_HetHan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Cau5";
            this.Text = "Cau5";
            this.Load += new System.EventHandler(this.Cau5_Load);
            this.grThongTin_HetHan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTin_Hethan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grThongTin_HetHan;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.DataGridView dataGridViewThongTin_Hethan;
        private System.Windows.Forms.Button btnLamMoi;
    }
}