namespace MenuForm
{
    partial class OpenSV
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
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.rdKhac = new System.Windows.Forms.RadioButton();
            this.cboHocVan = new System.Windows.Forms.ComboBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.ckDangki = new System.Windows.Forms.CheckBox();
            this.dtbNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtNhapTenSV = new System.Windows.Forms.TextBox();
            this.lblDangKi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblTrinhDoHocVan = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(686, 40);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(97, 25);
            this.lblMatKhau.TabIndex = 30;
            this.lblMatKhau.Text = "Mật Khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(686, 78);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(194, 22);
            this.txtMatKhau.TabIndex = 29;
            // 
            // btnDangKi
            // 
            this.btnDangKi.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKi.Location = new System.Drawing.Point(691, 126);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(158, 49);
            this.btnDangKi.TabIndex = 28;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // rdKhac
            // 
            this.rdKhac.AutoSize = true;
            this.rdKhac.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKhac.Location = new System.Drawing.Point(542, 256);
            this.rdKhac.Name = "rdKhac";
            this.rdKhac.Size = new System.Drawing.Size(82, 30);
            this.rdKhac.TabIndex = 27;
            this.rdKhac.TabStop = true;
            this.rdKhac.Text = "Khác";
            this.rdKhac.UseVisualStyleBackColor = true;
            // 
            // cboHocVan
            // 
            this.cboHocVan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHocVan.FormattingEnabled = true;
            this.cboHocVan.Items.AddRange(new object[] {
            "Tiểu học",
            "THCS",
            "THPT",
            "Kĩ Sư",
            "Tiến Sĩ",
            "Thạc Sĩ"});
            this.cboHocVan.Location = new System.Drawing.Point(279, 187);
            this.cboHocVan.Name = "cboHocVan";
            this.cboHocVan.Size = new System.Drawing.Size(347, 34);
            this.cboHocVan.TabIndex = 26;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.Location = new System.Drawing.Point(414, 256);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(61, 30);
            this.rdNu.TabIndex = 25;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.Location = new System.Drawing.Point(279, 256);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(77, 30);
            this.rdNam.TabIndex = 24;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // ckDangki
            // 
            this.ckDangki.AutoSize = true;
            this.ckDangki.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckDangki.Location = new System.Drawing.Point(279, 316);
            this.ckDangki.Name = "ckDangki";
            this.ckDangki.Size = new System.Drawing.Size(119, 37);
            this.ckDangki.TabIndex = 23;
            this.ckDangki.Text = "Đồng ý";
            this.ckDangki.UseVisualStyleBackColor = true;
            // 
            // dtbNgaySinh
            // 
            this.dtbNgaySinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbNgaySinh.Location = new System.Drawing.Point(279, 126);
            this.dtbNgaySinh.Name = "dtbNgaySinh";
            this.dtbNgaySinh.Size = new System.Drawing.Size(347, 34);
            this.dtbNgaySinh.TabIndex = 22;
            // 
            // txtNhapTenSV
            // 
            this.txtNhapTenSV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTenSV.Location = new System.Drawing.Point(279, 66);
            this.txtNhapTenSV.Name = "txtNhapTenSV";
            this.txtNhapTenSV.Size = new System.Drawing.Size(347, 34);
            this.txtNhapTenSV.TabIndex = 21;
            // 
            // lblDangKi
            // 
            this.lblDangKi.AutoSize = true;
            this.lblDangKi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKi.Location = new System.Drawing.Point(87, 316);
            this.lblDangKi.Name = "lblDangKi";
            this.lblDangKi.Size = new System.Drawing.Size(157, 32);
            this.lblDangKi.TabIndex = 20;
            this.lblDangKi.Text = "Đăng kí học";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(112, 256);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(132, 32);
            this.lblGioiTinh.TabIndex = 19;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblTrinhDoHocVan
            // 
            this.lblTrinhDoHocVan.AutoSize = true;
            this.lblTrinhDoHocVan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrinhDoHocVan.Location = new System.Drawing.Point(25, 194);
            this.lblTrinhDoHocVan.Name = "lblTrinhDoHocVan";
            this.lblTrinhDoHocVan.Size = new System.Drawing.Size(219, 32);
            this.lblTrinhDoHocVan.TabIndex = 18;
            this.lblTrinhDoHocVan.Text = "Trình độ học vấn";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(110, 126);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(134, 32);
            this.lblNgaySinh.TabIndex = 17;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.Location = new System.Drawing.Point(88, 64);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(156, 32);
            this.lblTenSV.TabIndex = 16;
            this.lblTenSV.Text = "Nhập tên sv";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(691, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 49);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(31, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(849, 327);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Tên sinh viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // OpenSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(918, 698);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.rdKhac);
            this.Controls.Add(this.cboHocVan);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.ckDangki);
            this.Controls.Add(this.dtbNgaySinh);
            this.Controls.Add(this.txtNhapTenSV);
            this.Controls.Add(this.lblDangKi);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblTrinhDoHocVan);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblTenSV);
            this.Name = "OpenSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenSV";
            this.Load += new System.EventHandler(this.OpenSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.RadioButton rdKhac;
        private System.Windows.Forms.ComboBox cboHocVan;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.CheckBox ckDangki;
        private System.Windows.Forms.DateTimePicker dtbNgaySinh;
        private System.Windows.Forms.TextBox txtNhapTenSV;
        private System.Windows.Forms.Label lblDangKi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblTrinhDoHocVan;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}