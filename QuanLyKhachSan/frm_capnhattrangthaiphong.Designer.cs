namespace QuanLyKhachSan
{
    partial class frm_capnhatphong
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_trangthai = new System.Windows.Forms.ComboBox();
            this.trangThaiPhongDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_tang = new System.Windows.Forms.ComboBox();
            this.tangDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_loaiphong = new System.Windows.Forms.ComboBox();
            this.loaiPhongDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_themtang = new System.Windows.Forms.Button();
            this.btn_themloaiphong = new System.Windows.Forms.Button();
            this.btn_capnhatphong = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trangThaiPhongDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tangDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phòng:";
            // 
            // txt_tenphong
            // 
            this.txt_tenphong.Location = new System.Drawing.Point(138, 38);
            this.txt_tenphong.Name = "txt_tenphong";
            this.txt_tenphong.Size = new System.Drawing.Size(298, 26);
            this.txt_tenphong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(170, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "THÔNG TIN PHÒNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng thái:";
            // 
            // cbb_trangthai
            // 
            this.cbb_trangthai.DataSource = this.trangThaiPhongDTOBindingSource;
            this.cbb_trangthai.DisplayMember = "TenTTPhong";
            this.cbb_trangthai.FormattingEnabled = true;
            this.cbb_trangthai.Location = new System.Drawing.Point(138, 69);
            this.cbb_trangthai.Name = "cbb_trangthai";
            this.cbb_trangthai.Size = new System.Drawing.Size(297, 27);
            this.cbb_trangthai.TabIndex = 2;
            this.cbb_trangthai.ValueMember = "IDTTPhong";
            // 
            // trangThaiPhongDTOBindingSource
            // 
            this.trangThaiPhongDTOBindingSource.DataSource = typeof(DTO.TrangThai_Phong_DTO);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tầng:";
            // 
            // cbb_tang
            // 
            this.cbb_tang.DataSource = this.tangDTOBindingSource;
            this.cbb_tang.DisplayMember = "TenTang";
            this.cbb_tang.FormattingEnabled = true;
            this.cbb_tang.Location = new System.Drawing.Point(138, 102);
            this.cbb_tang.Name = "cbb_tang";
            this.cbb_tang.Size = new System.Drawing.Size(297, 27);
            this.cbb_tang.TabIndex = 2;
            this.cbb_tang.ValueMember = "IDtang";
            // 
            // tangDTOBindingSource
            // 
            this.tangDTOBindingSource.DataSource = typeof(DTO.Tang_DTO);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại phòng:";
            // 
            // cbb_loaiphong
            // 
            this.cbb_loaiphong.DataSource = this.loaiPhongDTOBindingSource;
            this.cbb_loaiphong.DisplayMember = "TenLoaiP";
            this.cbb_loaiphong.FormattingEnabled = true;
            this.cbb_loaiphong.Location = new System.Drawing.Point(138, 136);
            this.cbb_loaiphong.Name = "cbb_loaiphong";
            this.cbb_loaiphong.Size = new System.Drawing.Size(297, 27);
            this.cbb_loaiphong.TabIndex = 2;
            this.cbb_loaiphong.ValueMember = "IDLoaiP";
            // 
            // loaiPhongDTOBindingSource
            // 
            this.loaiPhongDTOBindingSource.DataSource = typeof(DTO.Loai_Phong_DTO);
            // 
            // btn_themtang
            // 
            this.btn_themtang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themtang.Location = new System.Drawing.Point(442, 102);
            this.btn_themtang.Name = "btn_themtang";
            this.btn_themtang.Size = new System.Drawing.Size(47, 27);
            this.btn_themtang.TabIndex = 3;
            this.btn_themtang.Text = "- - -";
            this.btn_themtang.UseVisualStyleBackColor = true;
            // 
            // btn_themloaiphong
            // 
            this.btn_themloaiphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themloaiphong.Location = new System.Drawing.Point(442, 136);
            this.btn_themloaiphong.Name = "btn_themloaiphong";
            this.btn_themloaiphong.Size = new System.Drawing.Size(47, 27);
            this.btn_themloaiphong.TabIndex = 3;
            this.btn_themloaiphong.Text = "- - -";
            this.btn_themloaiphong.UseVisualStyleBackColor = true;
            // 
            // btn_capnhatphong
            // 
            this.btn_capnhatphong.Location = new System.Drawing.Point(139, 186);
            this.btn_capnhatphong.Name = "btn_capnhatphong";
            this.btn_capnhatphong.Size = new System.Drawing.Size(110, 39);
            this.btn_capnhatphong.TabIndex = 4;
            this.btn_capnhatphong.Text = "Cập nhật";
            this.btn_capnhatphong.UseVisualStyleBackColor = true;
            this.btn_capnhatphong.Click += new System.EventHandler(this.btn_capnhatphong_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(282, 186);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(110, 39);
            this.btn_dong.TabIndex = 4;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // frm_capnhatphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 235);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_capnhatphong);
            this.Controls.Add(this.btn_themloaiphong);
            this.Controls.Add(this.btn_themtang);
            this.Controls.Add(this.cbb_loaiphong);
            this.Controls.Add(this.cbb_tang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_trangthai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenphong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_capnhatphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẬP NHẬT PHÒNG";
            this.Load += new System.EventHandler(this.frm_capnhatphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trangThaiPhongDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tangDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tenphong;
        private System.Windows.Forms.ComboBox cbb_trangthai;
        private System.Windows.Forms.BindingSource trangThaiPhongDTOBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_tang;
        private System.Windows.Forms.BindingSource tangDTOBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_loaiphong;
        private System.Windows.Forms.BindingSource loaiPhongDTOBindingSource;
        private System.Windows.Forms.Button btn_themtang;
        private System.Windows.Forms.Button btn_themloaiphong;
        private System.Windows.Forms.Button btn_capnhatphong;
        private System.Windows.Forms.Button btn_dong;
    }
}