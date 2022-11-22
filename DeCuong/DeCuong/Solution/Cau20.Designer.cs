namespace DeCuong.Solution
{
    partial class Cau20
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
            this.btnhienThi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnlamMoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhienThi
            // 
            this.btnhienThi.Location = new System.Drawing.Point(356, 23);
            this.btnhienThi.Name = "btnhienThi";
            this.btnhienThi.Size = new System.Drawing.Size(114, 46);
            this.btnhienThi.TabIndex = 0;
            this.btnhienThi.Text = "Hiển Thị";
            this.btnhienThi.UseVisualStyleBackColor = true;
            this.btnhienThi.Click += new System.EventHandler(this.btnhienThi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 297);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sim theo chiều tăng dần của ngày kích hoạt";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnlamMoi
            // 
            this.btnlamMoi.Location = new System.Drawing.Point(561, 23);
            this.btnlamMoi.Name = "btnlamMoi";
            this.btnlamMoi.Size = new System.Drawing.Size(114, 46);
            this.btnlamMoi.TabIndex = 2;
            this.btnlamMoi.Text = "Làm mới";
            this.btnlamMoi.UseVisualStyleBackColor = true;
            this.btnlamMoi.Click += new System.EventHandler(this.btnlamMoi_Click);
            // 
            // Cau20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 375);
            this.Controls.Add(this.btnlamMoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnhienThi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Cau20";
            this.Text = "Cau20";
            this.Load += new System.EventHandler(this.Cau20_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnhienThi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnlamMoi;
    }
}