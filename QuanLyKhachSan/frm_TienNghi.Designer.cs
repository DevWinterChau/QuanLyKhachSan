﻿namespace QuanLyKhachSan
{
    partial class frm_TienNghi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Loadlai = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_TimTn = new System.Windows.Forms.Button();
            this.txt_TimTN = new System.Windows.Forms.TextBox();
            this.cbb_chon = new System.Windows.Forms.ComboBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Capnhat = new System.Windows.Forms.Button();
            this.btn_themTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Dongia = new System.Windows.Forms.TextBox();
            this.txt_TenTN = new System.Windows.Forms.TextBox();
            this.txt_IDTN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_TienNghi = new System.Windows.Forms.DataGridView();
            this.iDTNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chitiet = new System.Windows.Forms.DataGridViewImageColumn();
            this.tienNghiDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TienNghi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tienNghiDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 144);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Loadlai);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.btn_TimTn);
            this.groupBox2.Controls.Add(this.txt_TimTN);
            this.groupBox2.Controls.Add(this.cbb_chon);
            this.groupBox2.Controls.Add(this.btn_Thoat);
            this.groupBox2.Controls.Add(this.btn_Capnhat);
            this.groupBox2.Controls.Add(this.btn_themTN);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(427, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_Loadlai
            // 
            this.btn_Loadlai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Loadlai.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Screenshot_2023_04_12_035535;
            this.btn_Loadlai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Loadlai.Location = new System.Drawing.Point(550, 95);
            this.btn_Loadlai.Name = "btn_Loadlai";
            this.btn_Loadlai.Size = new System.Drawing.Size(56, 49);
            this.btn_Loadlai.TabIndex = 8;
            this.btn_Loadlai.UseVisualStyleBackColor = true;
            this.btn_Loadlai.Click += new System.EventHandler(this.btn_Loadlai_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(8, 118);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(374, 20);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Nhấn click vào tiện nghi nếu muốn chỉnh sửa !";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(8, 95);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(462, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nhấn double click vào tiện nghi để xem chi tiết tiện nghi !";
            // 
            // btn_TimTn
            // 
            this.btn_TimTn.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Screenshot_2023_04_12_040044;
            this.btn_TimTn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimTn.Location = new System.Drawing.Point(464, 60);
            this.btn_TimTn.Name = "btn_TimTn";
            this.btn_TimTn.Size = new System.Drawing.Size(51, 34);
            this.btn_TimTn.TabIndex = 5;
            this.btn_TimTn.UseVisualStyleBackColor = true;
            this.btn_TimTn.Click += new System.EventHandler(this.btn_TimTn_Click);
            // 
            // txt_TimTN
            // 
            this.txt_TimTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_TimTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimTN.Location = new System.Drawing.Point(210, 65);
            this.txt_TimTN.Multiline = true;
            this.txt_TimTN.Name = "txt_TimTN";
            this.txt_TimTN.Size = new System.Drawing.Size(253, 31);
            this.txt_TimTN.TabIndex = 4;
            this.txt_TimTN.Text = "Nhập để tìm";
            this.txt_TimTN.Click += new System.EventHandler(this.txt_TimTN_Click);
            this.txt_TimTN.Leave += new System.EventHandler(this.txt_TimTN_Leave);
            // 
            // cbb_chon
            // 
            this.cbb_chon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbb_chon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_chon.FormattingEnabled = true;
            this.cbb_chon.Items.AddRange(new object[] {
            "Tìm theo ID",
            "Tìm theo Tên ",
            "Tìm theo trạng thái"});
            this.cbb_chon.Location = new System.Drawing.Point(8, 65);
            this.cbb_chon.Name = "cbb_chon";
            this.cbb_chon.Size = new System.Drawing.Size(200, 25);
            this.cbb_chon.TabIndex = 3;
            this.cbb_chon.Text = "Chọn điều kiện tìm";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Thoat.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Thoat.Image = global::QuanLyKhachSan.Properties.Resources.exit__1_;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(253, 24);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(87, 39);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Exit";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Capnhat
            // 
            this.btn_Capnhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Capnhat.Image = global::QuanLyKhachSan.Properties.Resources.settings;
            this.btn_Capnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Capnhat.Location = new System.Drawing.Point(121, 26);
            this.btn_Capnhat.Name = "btn_Capnhat";
            this.btn_Capnhat.Size = new System.Drawing.Size(129, 39);
            this.btn_Capnhat.TabIndex = 1;
            this.btn_Capnhat.Text = "Cập nhật";
            this.btn_Capnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Capnhat.UseVisualStyleBackColor = true;
            this.btn_Capnhat.Click += new System.EventHandler(this.btn_Capnhat_Click);
            // 
            // btn_themTN
            // 
            this.btn_themTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_themTN.Image = global::QuanLyKhachSan.Properties.Resources.plus__1_;
            this.btn_themTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themTN.Location = new System.Drawing.Point(8, 26);
            this.btn_themTN.Name = "btn_themTN";
            this.btn_themTN.Size = new System.Drawing.Size(111, 39);
            this.btn_themTN.TabIndex = 0;
            this.btn_themTN.Text = "Thêm";
            this.btn_themTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themTN.UseVisualStyleBackColor = true;
            this.btn_themTN.Click += new System.EventHandler(this.btn_themTN_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.07427F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(427, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Dongia);
            this.groupBox1.Controls.Add(this.txt_TenTN);
            this.groupBox1.Controls.Add(this.txt_IDTN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_Dongia
            // 
            this.txt_Dongia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Dongia.Location = new System.Drawing.Point(101, 92);
            this.txt_Dongia.Name = "txt_Dongia";
            this.txt_Dongia.Size = new System.Drawing.Size(287, 26);
            this.txt_Dongia.TabIndex = 3;
            // 
            // txt_TenTN
            // 
            this.txt_TenTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TenTN.Location = new System.Drawing.Point(101, 60);
            this.txt_TenTN.Name = "txt_TenTN";
            this.txt_TenTN.Size = new System.Drawing.Size(287, 26);
            this.txt_TenTN.TabIndex = 3;
            // 
            // txt_IDTN
            // 
            this.txt_IDTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_IDTN.Location = new System.Drawing.Point(101, 27);
            this.txt_IDTN.Name = "txt_IDTN";
            this.txt_IDTN.Size = new System.Drawing.Size(287, 26);
            this.txt_IDTN.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá nhập :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_TienNghi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 465);
            this.panel2.TabIndex = 1;
            // 
            // dgv_TienNghi
            // 
            this.dgv_TienNghi.AutoGenerateColumns = false;
            this.dgv_TienNghi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TienNghi.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TienNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TienNghi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTNDataGridViewTextBoxColumn,
            this.tenTNDataGridViewTextBoxColumn,
            this.dongiaDataGridViewTextBoxColumn,
            this.chitiet});
            this.dgv_TienNghi.DataSource = this.tienNghiDTOBindingSource;
            this.dgv_TienNghi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TienNghi.GridColor = System.Drawing.SystemColors.InfoText;
            this.dgv_TienNghi.Location = new System.Drawing.Point(0, 0);
            this.dgv_TienNghi.Name = "dgv_TienNghi";
            this.dgv_TienNghi.RowHeadersWidth = 62;
            this.dgv_TienNghi.RowTemplate.Height = 28;
            this.dgv_TienNghi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TienNghi.Size = new System.Drawing.Size(1032, 465);
            this.dgv_TienNghi.TabIndex = 0;
            this.dgv_TienNghi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TienNghi_CellContentClick);
            this.dgv_TienNghi.Click += new System.EventHandler(this.dgv_TienNghi_Click);
            // 
            // iDTNDataGridViewTextBoxColumn
            // 
            this.iDTNDataGridViewTextBoxColumn.DataPropertyName = "IDTN";
            this.iDTNDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDTNDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDTNDataGridViewTextBoxColumn.Name = "iDTNDataGridViewTextBoxColumn";
            // 
            // tenTNDataGridViewTextBoxColumn
            // 
            this.tenTNDataGridViewTextBoxColumn.DataPropertyName = "TenTN";
            this.tenTNDataGridViewTextBoxColumn.HeaderText = "Tiện Nghi";
            this.tenTNDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenTNDataGridViewTextBoxColumn.Name = "tenTNDataGridViewTextBoxColumn";
            // 
            // dongiaDataGridViewTextBoxColumn
            // 
            this.dongiaDataGridViewTextBoxColumn.DataPropertyName = "Dongia";
            this.dongiaDataGridViewTextBoxColumn.HeaderText = "Đơn Giá";
            this.dongiaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dongiaDataGridViewTextBoxColumn.Name = "dongiaDataGridViewTextBoxColumn";
            // 
            // chitiet
            // 
            this.chitiet.HeaderText = "Chi Tiết";
            this.chitiet.Image = global::QuanLyKhachSan.Properties.Resources.file_circle_info;
            this.chitiet.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.chitiet.MinimumWidth = 8;
            this.chitiet.Name = "chitiet";
            // 
            // tienNghiDTOBindingSource
            // 
            this.tienNghiDTOBindingSource.DataSource = typeof(DTO.TienNghi_DTO);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Chi Tiết";
            this.dataGridViewImageColumn1.Image = global::QuanLyKhachSan.Properties.Resources.file_circle_info;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 968;
            // 
            // frm_TienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1032, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_TienNghi";
            this.Text = "frm_TienNghi";
            this.Load += new System.EventHandler(this.frm_TienNghi_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TienNghi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tienNghiDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_TienNghi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_TimTn;
        private System.Windows.Forms.TextBox txt_TimTN;
        private System.Windows.Forms.ComboBox cbb_chon;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Capnhat;
        private System.Windows.Forms.Button btn_themTN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_Dongia;
        private System.Windows.Forms.TextBox txt_TenTN;
        private System.Windows.Forms.TextBox txt_IDTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_Loadlai;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.BindingSource tienNghiDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn chitiet;
    }
}