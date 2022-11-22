namespace Demo1___WindowsForms
{
    partial class frmMain
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyPhongBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhanSuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyLuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyHoSoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoThongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bangLuongTheoThangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoKetQuaKinhDoanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(26, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 29);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(27, 68);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(303, 31);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Cat",
            "Fog",
            "Cow",
            "Tiger\t\t\t\t",
            "Chicken",
            "Monkey"});
            this.listBox1.Location = new System.Drawing.Point(18, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(332, 124);
            this.listBox1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(433, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 348);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cat",
            "Dog",
            "Cow",
            "Tiger",
            "Chicken",
            "Monkey"});
            this.comboBox1.Location = new System.Drawing.Point(20, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(331, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kiểm tra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.quanLyToolStripMenuItem,
            this.quanLyNhanSuToolStripMenuItem,
            this.baoCaoThongKeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangNhapToolStripMenuItem,
            this.dangXuatToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.heThongToolStripMenuItem.Text = "He thong";
            // 
            // dangNhapToolStripMenuItem
            // 
            this.dangNhapToolStripMenuItem.Name = "dangNhapToolStripMenuItem";
            this.dangNhapToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dangNhapToolStripMenuItem.Text = "Dang Nhap";
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dangXuatToolStripMenuItem.Text = "Dang Xuat";
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qToolStripMenuItem,
            this.quanLyPhongBanToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.quanLyToolStripMenuItem.Text = "Quan ly danh muc";
            // 
            // qToolStripMenuItem
            // 
            this.qToolStripMenuItem.Name = "qToolStripMenuItem";
            this.qToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.qToolStripMenuItem.Text = "Quan ly chuc vu";
            // 
            // quanLyPhongBanToolStripMenuItem
            // 
            this.quanLyPhongBanToolStripMenuItem.Name = "quanLyPhongBanToolStripMenuItem";
            this.quanLyPhongBanToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.quanLyPhongBanToolStripMenuItem.Text = "Quan ly phong ban";
            // 
            // quanLyNhanSuToolStripMenuItem
            // 
            this.quanLyNhanSuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyLuongToolStripMenuItem,
            this.quanLyHoSoToolStripMenuItem});
            this.quanLyNhanSuToolStripMenuItem.Name = "quanLyNhanSuToolStripMenuItem";
            this.quanLyNhanSuToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.quanLyNhanSuToolStripMenuItem.Text = "Quan ly nhan su";
            // 
            // quanLyLuongToolStripMenuItem
            // 
            this.quanLyLuongToolStripMenuItem.Name = "quanLyLuongToolStripMenuItem";
            this.quanLyLuongToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.quanLyLuongToolStripMenuItem.Text = "Quan ly luong";
            // 
            // quanLyHoSoToolStripMenuItem
            // 
            this.quanLyHoSoToolStripMenuItem.Name = "quanLyHoSoToolStripMenuItem";
            this.quanLyHoSoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.quanLyHoSoToolStripMenuItem.Text = "Quan ly ho so";
            // 
            // baoCaoThongKeToolStripMenuItem
            // 
            this.baoCaoThongKeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bangLuongTheoThangToolStripMenuItem,
            this.baoCaoKetQuaKinhDoanhToolStripMenuItem});
            this.baoCaoThongKeToolStripMenuItem.Name = "baoCaoThongKeToolStripMenuItem";
            this.baoCaoThongKeToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.baoCaoThongKeToolStripMenuItem.Text = "Bao cao - Thong ke";
            // 
            // bangLuongTheoThangToolStripMenuItem
            // 
            this.bangLuongTheoThangToolStripMenuItem.Name = "bangLuongTheoThangToolStripMenuItem";
            this.bangLuongTheoThangToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.bangLuongTheoThangToolStripMenuItem.Text = "Bang luong theo thang";
            // 
            // baoCaoKetQuaKinhDoanhToolStripMenuItem
            // 
            this.baoCaoKetQuaKinhDoanhToolStripMenuItem.Name = "baoCaoKetQuaKinhDoanhToolStripMenuItem";
            this.baoCaoKetQuaKinhDoanhToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.baoCaoKetQuaKinhDoanhToolStripMenuItem.Text = "Bao cao ket qua kinh doanh";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Cat",
            "Fog",
            "Cow",
            "Tiger",
            "Chicken",
            "Monkey"});
            this.checkedListBox1.Location = new System.Drawing.Point(38, 308);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(185, 130);
            this.checkedListBox1.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangNhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyPhongBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhanSuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyLuongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyHoSoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoThongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bangLuongTheoThangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoKetQuaKinhDoanhToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}