namespace QuanLyKhachSan
{
    partial class frm_Phong
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
            this.tabControl_Phong = new System.Windows.Forms.TabControl();
            this.tab_Phong = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.check_chontimkiem = new System.Windows.Forms.CheckBox();
            this.btn_timphong = new System.Windows.Forms.Button();
            this.txt_timphong = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_loaiphong = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_themphong = new System.Windows.Forms.Button();
            this.panel_trangthai = new System.Windows.Forms.Panel();
            this.rad_tt_dánguachua = new System.Windows.Forms.RadioButton();
            this.rad_tt_chuadon = new System.Windows.Forms.RadioButton();
            this.rad_tt_datphong = new System.Windows.Forms.RadioButton();
            this.rad_tt_thuephong = new System.Windows.Forms.RadioButton();
            this.rad_tt_trong = new System.Windows.Forms.RadioButton();
            this.panel_loaiphong = new System.Windows.Forms.Panel();
            this.cbb_loaiphong = new System.Windows.Forms.ComboBox();
            this.loaiPhongDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tab_loaiPhong = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_loaiPhong = new System.Windows.Forms.DataGridView();
            this.iDLoaiPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNguoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGiuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaTimeLPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaLPngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhongDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_timloai = new System.Windows.Forms.TextBox();
            this.cbb_chon_timloai = new System.Windows.Forms.ComboBox();
            this.btn_timloai = new System.Windows.Forms.Button();
            this.btn_thoatLoai = new System.Windows.Forms.Button();
            this.btn_xoaloai = new System.Windows.Forms.Button();
            this.btn_themloaiphong = new System.Windows.Forms.Button();
            this.btn_sualoai = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl_Phong.SuspendLayout();
            this.tab_Phong.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_trangthai.SuspendLayout();
            this.panel_loaiphong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongDTOBindingSource1)).BeginInit();
            this.tab_loaiPhong.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongDTOBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Phong
            // 
            this.tabControl_Phong.Controls.Add(this.tab_Phong);
            this.tabControl_Phong.Controls.Add(this.tab_loaiPhong);
            this.tabControl_Phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Phong.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Phong.Name = "tabControl_Phong";
            this.tabControl_Phong.SelectedIndex = 0;
            this.tabControl_Phong.Size = new System.Drawing.Size(1079, 609);
            this.tabControl_Phong.TabIndex = 0;
            // 
            // tab_Phong
            // 
            this.tab_Phong.Controls.Add(this.flowLayoutPanel1);
            this.tab_Phong.Controls.Add(this.panel1);
            this.tab_Phong.Location = new System.Drawing.Point(4, 29);
            this.tab_Phong.Name = "tab_Phong";
            this.tab_Phong.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Phong.Size = new System.Drawing.Size(1071, 576);
            this.tab_Phong.TabIndex = 0;
            this.tab_Phong.Text = "Danh Sách Phòng";
            this.tab_Phong.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(228, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(840, 570);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.check_chontimkiem);
            this.panel1.Controls.Add(this.btn_timphong);
            this.panel1.Controls.Add(this.txt_timphong);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.linkLabel_loaiphong);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_themphong);
            this.panel1.Controls.Add(this.panel_trangthai);
            this.panel1.Controls.Add(this.panel_loaiphong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 570);
            this.panel1.TabIndex = 0;
            // 
            // check_chontimkiem
            // 
            this.check_chontimkiem.AutoSize = true;
            this.check_chontimkiem.Location = new System.Drawing.Point(12, 9);
            this.check_chontimkiem.Name = "check_chontimkiem";
            this.check_chontimkiem.Size = new System.Drawing.Size(173, 24);
            this.check_chontimkiem.TabIndex = 22;
            this.check_chontimkiem.Text = "Chọn để tìm kiếm";
            this.check_chontimkiem.UseVisualStyleBackColor = true;
            this.check_chontimkiem.CheckedChanged += new System.EventHandler(this.check_chontimkiem_CheckedChanged);
            // 
            // btn_timphong
            // 
            this.btn_timphong.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Screenshot_2023_04_12_040044;
            this.btn_timphong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_timphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timphong.Location = new System.Drawing.Point(173, 307);
            this.btn_timphong.Name = "btn_timphong";
            this.btn_timphong.Size = new System.Drawing.Size(45, 39);
            this.btn_timphong.TabIndex = 20;
            this.btn_timphong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timphong.UseVisualStyleBackColor = true;
            this.btn_timphong.Click += new System.EventHandler(this.btn_timphong_Click_1);
            // 
            // txt_timphong
            // 
            this.txt_timphong.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timphong.Location = new System.Drawing.Point(9, 310);
            this.txt_timphong.Multiline = true;
            this.txt_timphong.Name = "txt_timphong";
            this.txt_timphong.Size = new System.Drawing.Size(161, 36);
            this.txt_timphong.TabIndex = 19;
            this.txt_timphong.Text = "Nhập phòng để tìm";
            this.txt_timphong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_timphong.Click += new System.EventHandler(this.txt_timphong_Click_1);
            this.txt_timphong.TextChanged += new System.EventHandler(this.txt_timphong_TextChanged);
            this.txt_timphong.Leave += new System.EventHandler(this.txt_timphong_Leave_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(7, 112);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 20);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Trạng Thái ";
            // 
            // linkLabel_loaiphong
            // 
            this.linkLabel_loaiphong.AutoSize = true;
            this.linkLabel_loaiphong.Location = new System.Drawing.Point(15, 38);
            this.linkLabel_loaiphong.Name = "linkLabel_loaiphong";
            this.linkLabel_loaiphong.Size = new System.Drawing.Size(99, 20);
            this.linkLabel_loaiphong.TabIndex = 17;
            this.linkLabel_loaiphong.TabStop = true;
            this.linkLabel_loaiphong.Text = "Loại Phòng";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::QuanLyKhachSan.Properties.Resources.exit;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 39);
            this.button2.TabIndex = 13;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_themphong
            // 
            this.btn_themphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themphong.Image = global::QuanLyKhachSan.Properties.Resources.plus__1_;
            this.btn_themphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themphong.Location = new System.Drawing.Point(9, 355);
            this.btn_themphong.Name = "btn_themphong";
            this.btn_themphong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_themphong.Size = new System.Drawing.Size(207, 39);
            this.btn_themphong.TabIndex = 9;
            this.btn_themphong.Text = "Thêm Phòng";
            this.btn_themphong.UseVisualStyleBackColor = true;
            this.btn_themphong.Click += new System.EventHandler(this.btn_themphong_Click);
            // 
            // panel_trangthai
            // 
            this.panel_trangthai.Controls.Add(this.rad_tt_dánguachua);
            this.panel_trangthai.Controls.Add(this.rad_tt_chuadon);
            this.panel_trangthai.Controls.Add(this.rad_tt_datphong);
            this.panel_trangthai.Controls.Add(this.rad_tt_thuephong);
            this.panel_trangthai.Controls.Add(this.rad_tt_trong);
            this.panel_trangthai.Enabled = false;
            this.panel_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_trangthai.Location = new System.Drawing.Point(11, 137);
            this.panel_trangthai.Name = "panel_trangthai";
            this.panel_trangthai.Size = new System.Drawing.Size(186, 161);
            this.panel_trangthai.TabIndex = 8;
            // 
            // rad_tt_dánguachua
            // 
            this.rad_tt_dánguachua.AutoSize = true;
            this.rad_tt_dánguachua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_tt_dánguachua.Location = new System.Drawing.Point(12, 128);
            this.rad_tt_dánguachua.Name = "rad_tt_dánguachua";
            this.rad_tt_dánguachua.Size = new System.Drawing.Size(133, 23);
            this.rad_tt_dánguachua.TabIndex = 10;
            this.rad_tt_dánguachua.Text = "Đang sửa chữa";
            this.rad_tt_dánguachua.UseVisualStyleBackColor = true;
            this.rad_tt_dánguachua.CheckedChanged += new System.EventHandler(this.rad_tt_dánguachua_CheckedChanged);
            // 
            // rad_tt_chuadon
            // 
            this.rad_tt_chuadon.AutoSize = true;
            this.rad_tt_chuadon.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_tt_chuadon.Location = new System.Drawing.Point(11, 98);
            this.rad_tt_chuadon.Name = "rad_tt_chuadon";
            this.rad_tt_chuadon.Size = new System.Drawing.Size(125, 23);
            this.rad_tt_chuadon.TabIndex = 6;
            this.rad_tt_chuadon.Text = "Chưa dọn dẹp";
            this.rad_tt_chuadon.UseVisualStyleBackColor = true;
            this.rad_tt_chuadon.CheckedChanged += new System.EventHandler(this.rad_tt_chuadon_CheckedChanged);
            // 
            // rad_tt_datphong
            // 
            this.rad_tt_datphong.AutoSize = true;
            this.rad_tt_datphong.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_tt_datphong.Location = new System.Drawing.Point(11, 68);
            this.rad_tt_datphong.Name = "rad_tt_datphong";
            this.rad_tt_datphong.Size = new System.Drawing.Size(125, 23);
            this.rad_tt_datphong.TabIndex = 7;
            this.rad_tt_datphong.Text = "Có khách đặt ";
            this.rad_tt_datphong.UseVisualStyleBackColor = true;
            this.rad_tt_datphong.CheckedChanged += new System.EventHandler(this.rad_tt_datphong_CheckedChanged);
            // 
            // rad_tt_thuephong
            // 
            this.rad_tt_thuephong.AutoSize = true;
            this.rad_tt_thuephong.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_tt_thuephong.Location = new System.Drawing.Point(12, 38);
            this.rad_tt_thuephong.Name = "rad_tt_thuephong";
            this.rad_tt_thuephong.Size = new System.Drawing.Size(128, 23);
            this.rad_tt_thuephong.TabIndex = 8;
            this.rad_tt_thuephong.Text = "Có khách thuê";
            this.rad_tt_thuephong.UseVisualStyleBackColor = true;
            this.rad_tt_thuephong.CheckedChanged += new System.EventHandler(this.rad_tt_thuephong_CheckedChanged);
            // 
            // rad_tt_trong
            // 
            this.rad_tt_trong.AutoSize = true;
            this.rad_tt_trong.Checked = true;
            this.rad_tt_trong.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_tt_trong.Location = new System.Drawing.Point(11, 8);
            this.rad_tt_trong.Name = "rad_tt_trong";
            this.rad_tt_trong.Size = new System.Drawing.Size(72, 23);
            this.rad_tt_trong.TabIndex = 9;
            this.rad_tt_trong.TabStop = true;
            this.rad_tt_trong.Text = "Trống";
            this.rad_tt_trong.UseVisualStyleBackColor = true;
            this.rad_tt_trong.CheckedChanged += new System.EventHandler(this.rad_tt_trong_CheckedChanged);
            // 
            // panel_loaiphong
            // 
            this.panel_loaiphong.Controls.Add(this.cbb_loaiphong);
            this.panel_loaiphong.Enabled = false;
            this.panel_loaiphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_loaiphong.Location = new System.Drawing.Point(11, 62);
            this.panel_loaiphong.Name = "panel_loaiphong";
            this.panel_loaiphong.Size = new System.Drawing.Size(186, 46);
            this.panel_loaiphong.TabIndex = 8;
            // 
            // cbb_loaiphong
            // 
            this.cbb_loaiphong.DataSource = this.loaiPhongDTOBindingSource1;
            this.cbb_loaiphong.DisplayMember = "TenLoaiP";
            this.cbb_loaiphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loaiphong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbb_loaiphong.FormattingEnabled = true;
            this.cbb_loaiphong.Location = new System.Drawing.Point(5, 8);
            this.cbb_loaiphong.Name = "cbb_loaiphong";
            this.cbb_loaiphong.Size = new System.Drawing.Size(175, 28);
            this.cbb_loaiphong.TabIndex = 0;
            this.cbb_loaiphong.ValueMember = "IDLoaiP";
            this.cbb_loaiphong.SelectedValueChanged += new System.EventHandler(this.cbb_loaiphong_SelectedValueChanged);
            // 
            // loaiPhongDTOBindingSource1
            // 
            this.loaiPhongDTOBindingSource1.DataSource = typeof(DTO.Loai_Phong_DTO);
            // 
            // tab_loaiPhong
            // 
            this.tab_loaiPhong.BackColor = System.Drawing.Color.Khaki;
            this.tab_loaiPhong.Controls.Add(this.panel3);
            this.tab_loaiPhong.Controls.Add(this.panel2);
            this.tab_loaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_loaiPhong.Location = new System.Drawing.Point(4, 29);
            this.tab_loaiPhong.Name = "tab_loaiPhong";
            this.tab_loaiPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tab_loaiPhong.Size = new System.Drawing.Size(1071, 576);
            this.tab_loaiPhong.TabIndex = 1;
            this.tab_loaiPhong.Text = "Danh Sách Loại Phòng";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.Controls.Add(this.dgv_loaiPhong);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1065, 516);
            this.panel3.TabIndex = 2;
            // 
            // dgv_loaiPhong
            // 
            this.dgv_loaiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_loaiPhong.AutoGenerateColumns = false;
            this.dgv_loaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_loaiPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgv_loaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDLoaiPDataGridViewTextBoxColumn,
            this.tenLoaiPDataGridViewTextBoxColumn,
            this.soNguoiDataGridViewTextBoxColumn,
            this.soGiuongDataGridViewTextBoxColumn,
            this.dongiaTimeLPDataGridViewTextBoxColumn,
            this.dongiaLPngayDataGridViewTextBoxColumn});
            this.dgv_loaiPhong.DataSource = this.loaiPhongDTOBindingSource;
            this.dgv_loaiPhong.Location = new System.Drawing.Point(3, 32);
            this.dgv_loaiPhong.Name = "dgv_loaiPhong";
            this.dgv_loaiPhong.RowHeadersWidth = 62;
            this.dgv_loaiPhong.RowTemplate.Height = 28;
            this.dgv_loaiPhong.Size = new System.Drawing.Size(1057, 484);
            this.dgv_loaiPhong.TabIndex = 1;
            // 
            // iDLoaiPDataGridViewTextBoxColumn
            // 
            this.iDLoaiPDataGridViewTextBoxColumn.DataPropertyName = "IDLoaiP";
            this.iDLoaiPDataGridViewTextBoxColumn.HeaderText = "ID Loại";
            this.iDLoaiPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDLoaiPDataGridViewTextBoxColumn.Name = "iDLoaiPDataGridViewTextBoxColumn";
            // 
            // tenLoaiPDataGridViewTextBoxColumn
            // 
            this.tenLoaiPDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiP";
            this.tenLoaiPDataGridViewTextBoxColumn.HeaderText = "Tên Loại";
            this.tenLoaiPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenLoaiPDataGridViewTextBoxColumn.Name = "tenLoaiPDataGridViewTextBoxColumn";
            // 
            // soNguoiDataGridViewTextBoxColumn
            // 
            this.soNguoiDataGridViewTextBoxColumn.DataPropertyName = "SoNguoi";
            this.soNguoiDataGridViewTextBoxColumn.HeaderText = "Số người";
            this.soNguoiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soNguoiDataGridViewTextBoxColumn.Name = "soNguoiDataGridViewTextBoxColumn";
            // 
            // soGiuongDataGridViewTextBoxColumn
            // 
            this.soGiuongDataGridViewTextBoxColumn.DataPropertyName = "SoGiuong";
            this.soGiuongDataGridViewTextBoxColumn.HeaderText = "Số giường";
            this.soGiuongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soGiuongDataGridViewTextBoxColumn.Name = "soGiuongDataGridViewTextBoxColumn";
            // 
            // dongiaTimeLPDataGridViewTextBoxColumn
            // 
            this.dongiaTimeLPDataGridViewTextBoxColumn.DataPropertyName = "Dongia_Time_LP";
            this.dongiaTimeLPDataGridViewTextBoxColumn.HeaderText = "Đơn giá giờ";
            this.dongiaTimeLPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dongiaTimeLPDataGridViewTextBoxColumn.Name = "dongiaTimeLPDataGridViewTextBoxColumn";
            // 
            // dongiaLPngayDataGridViewTextBoxColumn
            // 
            this.dongiaLPngayDataGridViewTextBoxColumn.DataPropertyName = "DongiaLP_ngay";
            this.dongiaLPngayDataGridViewTextBoxColumn.HeaderText = "Đơn giá ngày";
            this.dongiaLPngayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dongiaLPngayDataGridViewTextBoxColumn.Name = "dongiaLPngayDataGridViewTextBoxColumn";
            // 
            // loaiPhongDTOBindingSource
            // 
            this.loaiPhongDTOBindingSource.DataSource = typeof(DTO.Loai_Phong_DTO);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Loại Phòng";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.txt_timloai);
            this.panel2.Controls.Add(this.cbb_chon_timloai);
            this.panel2.Controls.Add(this.btn_timloai);
            this.panel2.Controls.Add(this.btn_thoatLoai);
            this.panel2.Controls.Add(this.btn_xoaloai);
            this.panel2.Controls.Add(this.btn_themloaiphong);
            this.panel2.Controls.Add(this.btn_sualoai);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 48);
            this.panel2.TabIndex = 0;
            // 
            // txt_timloai
            // 
            this.txt_timloai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timloai.Location = new System.Drawing.Point(742, 11);
            this.txt_timloai.Multiline = true;
            this.txt_timloai.Name = "txt_timloai";
            this.txt_timloai.Size = new System.Drawing.Size(262, 29);
            this.txt_timloai.TabIndex = 2;
            this.txt_timloai.Text = "Nhập để tìm kiếm";
            // 
            // cbb_chon_timloai
            // 
            this.cbb_chon_timloai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_chon_timloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_chon_timloai.FormattingEnabled = true;
            this.cbb_chon_timloai.Location = new System.Drawing.Point(580, 13);
            this.cbb_chon_timloai.Name = "cbb_chon_timloai";
            this.cbb_chon_timloai.Size = new System.Drawing.Size(155, 25);
            this.cbb_chon_timloai.TabIndex = 1;
            this.cbb_chon_timloai.Text = "Chọn điều kiện tìm";
            // 
            // btn_timloai
            // 
            this.btn_timloai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timloai.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Screenshot_20221115_053228;
            this.btn_timloai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_timloai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timloai.Location = new System.Drawing.Point(1005, 3);
            this.btn_timloai.Name = "btn_timloai";
            this.btn_timloai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_timloai.Size = new System.Drawing.Size(57, 43);
            this.btn_timloai.TabIndex = 0;
            this.btn_timloai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timloai.UseVisualStyleBackColor = true;
            // 
            // btn_thoatLoai
            // 
            this.btn_thoatLoai.BackColor = System.Drawing.Color.IndianRed;
            this.btn_thoatLoai.Image = global::QuanLyKhachSan.Properties.Resources.exit;
            this.btn_thoatLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoatLoai.Location = new System.Drawing.Point(393, 8);
            this.btn_thoatLoai.Name = "btn_thoatLoai";
            this.btn_thoatLoai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_thoatLoai.Size = new System.Drawing.Size(97, 32);
            this.btn_thoatLoai.TabIndex = 0;
            this.btn_thoatLoai.Text = "Thoát";
            this.btn_thoatLoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoatLoai.UseVisualStyleBackColor = false;
            this.btn_thoatLoai.Click += new System.EventHandler(this.btn_thoatLoai_Click);
            // 
            // btn_xoaloai
            // 
            this.btn_xoaloai.Image = global::QuanLyKhachSan.Properties.Resources.trash;
            this.btn_xoaloai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoaloai.Location = new System.Drawing.Point(284, 8);
            this.btn_xoaloai.Name = "btn_xoaloai";
            this.btn_xoaloai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_xoaloai.Size = new System.Drawing.Size(104, 32);
            this.btn_xoaloai.TabIndex = 0;
            this.btn_xoaloai.Text = "Xóa";
            this.btn_xoaloai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoaloai.UseVisualStyleBackColor = true;
            this.btn_xoaloai.Click += new System.EventHandler(this.btn_xoaloai_Click);
            // 
            // btn_themloaiphong
            // 
            this.btn_themloaiphong.Image = global::QuanLyKhachSan.Properties.Resources.settings;
            this.btn_themloaiphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themloaiphong.Location = new System.Drawing.Point(7, 8);
            this.btn_themloaiphong.Name = "btn_themloaiphong";
            this.btn_themloaiphong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_themloaiphong.Size = new System.Drawing.Size(125, 32);
            this.btn_themloaiphong.TabIndex = 0;
            this.btn_themloaiphong.Text = "Thêm";
            this.btn_themloaiphong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themloaiphong.UseVisualStyleBackColor = true;
            this.btn_themloaiphong.Click += new System.EventHandler(this.btn_themloaiphong_Click);
            // 
            // btn_sualoai
            // 
            this.btn_sualoai.Image = global::QuanLyKhachSan.Properties.Resources.settings;
            this.btn_sualoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sualoai.Location = new System.Drawing.Point(140, 8);
            this.btn_sualoai.Name = "btn_sualoai";
            this.btn_sualoai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_sualoai.Size = new System.Drawing.Size(139, 32);
            this.btn_sualoai.TabIndex = 0;
            this.btn_sualoai.Text = "Cập nhật";
            this.btn_sualoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sualoai.UseVisualStyleBackColor = true;
            this.btn_sualoai.Click += new System.EventHandler(this.btn_sualoai_Click);
            // 
            // frm_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 609);
            this.Controls.Add(this.tabControl_Phong);
            this.Name = "frm_Phong";
            this.Text = "QUẢN LÝ PHÒNG";
            this.Load += new System.EventHandler(this.frm_Phong_Load);
            this.tabControl_Phong.ResumeLayout(false);
            this.tab_Phong.ResumeLayout(false);
            this.tab_Phong.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_trangthai.ResumeLayout(false);
            this.panel_trangthai.PerformLayout();
            this.panel_loaiphong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongDTOBindingSource1)).EndInit();
            this.tab_loaiPhong.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongDTOBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Phong;
        private System.Windows.Forms.TabPage tab_Phong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tab_loaiPhong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sualoai;
        private System.Windows.Forms.Button btn_xoaloai;
        private System.Windows.Forms.TextBox txt_timloai;
        private System.Windows.Forms.ComboBox cbb_chon_timloai;
        private System.Windows.Forms.Button btn_timloai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_loaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLoaiPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNguoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGiuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaTimeLPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaLPngayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource loaiPhongDTOBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thoatLoai;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_trangthai;
        private System.Windows.Forms.RadioButton rad_tt_chuadon;
        private System.Windows.Forms.RadioButton rad_tt_datphong;
        private System.Windows.Forms.RadioButton rad_tt_thuephong;
        private System.Windows.Forms.RadioButton rad_tt_trong;
        private System.Windows.Forms.Panel panel_loaiphong;
        private System.Windows.Forms.Button btn_themphong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel_loaiphong;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_timphong;
        private System.Windows.Forms.TextBox txt_timphong;
        private System.Windows.Forms.RadioButton rad_tt_dánguachua;
        private System.Windows.Forms.ComboBox cbb_loaiphong;
        private System.Windows.Forms.BindingSource loaiPhongDTOBindingSource1;
        private System.Windows.Forms.Button btn_themloaiphong;
        private System.Windows.Forms.CheckBox check_chontimkiem;
    }
}