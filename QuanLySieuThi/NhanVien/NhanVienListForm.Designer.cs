using Common.Forms;

namespace QuanLySieuThi.NhanVien
{
    partial class NhanVienListForm : QuanLySieuThiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienListForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.NhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HoVaTenColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinhColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.NgaySinhColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.TenDangNhapColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MatKhauColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucVuColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDienThoaiColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmailColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiTaoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTaoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiChinhSuaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayChinhSuaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.DeleteButton = new Common.Controls.QButtonControl();
            this.OKButton = new Common.Controls.QButtonControl();
            this.EditButton = new Common.Controls.QButtonControl();
            this.AddButton = new Common.Controls.QButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.NhanVienGridControl);
            this.layoutControl1.Location = new System.Drawing.Point(1, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(935, 416);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // NhanVienGridControl
            // 
            this.NhanVienGridControl.Location = new System.Drawing.Point(12, 12);
            this.NhanVienGridControl.MainView = this.GridView1;
            this.NhanVienGridControl.Name = "NhanVienGridControl";
            this.NhanVienGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.CheckEdit,
            this.DateEdit});
            this.NhanVienGridControl.Size = new System.Drawing.Size(911, 392);
            this.NhanVienGridControl.TabIndex = 4;
            this.NhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView1});
            // 
            // GridView1
            // 
            this.GridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView1.Appearance.Row.Options.UseFont = true;
            this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HoVaTenColumn,
            this.GioiTinhColumn,
            this.NgaySinhColumn,
            this.TenDangNhapColumn,
            this.MatKhauColumn,
            this.ChucVuColumn,
            this.SoDienThoaiColumn,
            this.DiaChiColumn,
            this.EmailColumn,
            this.NguoiTaoColumn,
            this.NgayTaoColumn,
            this.NguoiChinhSuaColumn,
            this.NgayChinhSuaColumn});
            this.GridView1.GridControl = this.NhanVienGridControl;
            this.GridView1.Name = "GridView1";
            this.GridView1.OptionsBehavior.Editable = false;
            this.GridView1.OptionsView.ColumnAutoWidth = false;
            this.GridView1.OptionsView.ShowAutoFilterRow = true;
            this.GridView1.OptionsView.ShowGroupPanel = false;
            this.GridView1.OptionsView.ShowIndicator = false;
            this.GridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridView1_FocusedRowChanged);
            this.GridView1.DoubleClick += new System.EventHandler(this.GridView1_DoubleClick);
            // 
            // HoVaTenColumn
            // 
            this.HoVaTenColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoVaTenColumn.AppearanceCell.Options.UseFont = true;
            this.HoVaTenColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoVaTenColumn.AppearanceHeader.Options.UseFont = true;
            this.HoVaTenColumn.Caption = "Họ Và Tên";
            this.HoVaTenColumn.FieldName = "HoVaTen";
            this.HoVaTenColumn.Name = "HoVaTenColumn";
            this.HoVaTenColumn.OptionsColumn.AllowEdit = false;
            this.HoVaTenColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.HoVaTenColumn.Visible = true;
            this.HoVaTenColumn.VisibleIndex = 0;
            this.HoVaTenColumn.Width = 100;
            // 
            // GioiTinhColumn
            // 
            this.GioiTinhColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinhColumn.AppearanceHeader.Options.UseFont = true;
            this.GioiTinhColumn.Caption = "Giới Tính";
            this.GioiTinhColumn.ColumnEdit = this.CheckEdit;
            this.GioiTinhColumn.FieldName = "GioiTinh";
            this.GioiTinhColumn.Name = "GioiTinhColumn";
            this.GioiTinhColumn.OptionsColumn.AllowEdit = false;
            this.GioiTinhColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.GioiTinhColumn.Visible = true;
            this.GioiTinhColumn.VisibleIndex = 1;
            // 
            // CheckEdit
            // 
            this.CheckEdit.AutoHeight = false;
            this.CheckEdit.Name = "CheckEdit";
            // 
            // NgaySinhColumn
            // 
            this.NgaySinhColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinhColumn.AppearanceCell.Options.UseFont = true;
            this.NgaySinhColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinhColumn.AppearanceHeader.Options.UseFont = true;
            this.NgaySinhColumn.Caption = "Ngày Sinh";
            this.NgaySinhColumn.ColumnEdit = this.DateEdit;
            this.NgaySinhColumn.FieldName = "NgayThangNamSinh";
            this.NgaySinhColumn.Name = "NgaySinhColumn";
            this.NgaySinhColumn.OptionsColumn.AllowEdit = false;
            this.NgaySinhColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NgaySinhColumn.Visible = true;
            this.NgaySinhColumn.VisibleIndex = 2;
            this.NgaySinhColumn.Width = 100;
            // 
            // DateEdit
            // 
            this.DateEdit.AutoHeight = false;
            this.DateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit.Name = "DateEdit";
            // 
            // TenDangNhapColumn
            // 
            this.TenDangNhapColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDangNhapColumn.AppearanceCell.Options.UseFont = true;
            this.TenDangNhapColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDangNhapColumn.AppearanceHeader.Options.UseFont = true;
            this.TenDangNhapColumn.Caption = "Tên Đăng Nhập";
            this.TenDangNhapColumn.FieldName = "TenDangNhap";
            this.TenDangNhapColumn.Name = "TenDangNhapColumn";
            this.TenDangNhapColumn.OptionsColumn.AllowEdit = false;
            this.TenDangNhapColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenDangNhapColumn.Visible = true;
            this.TenDangNhapColumn.VisibleIndex = 3;
            this.TenDangNhapColumn.Width = 120;
            // 
            // MatKhauColumn
            // 
            this.MatKhauColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhauColumn.AppearanceCell.Options.UseFont = true;
            this.MatKhauColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhauColumn.AppearanceHeader.Options.UseFont = true;
            this.MatKhauColumn.Caption = "Mật Khẩu";
            this.MatKhauColumn.FieldName = "MatKhau";
            this.MatKhauColumn.Name = "MatKhauColumn";
            this.MatKhauColumn.OptionsColumn.AllowEdit = false;
            this.MatKhauColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.MatKhauColumn.Visible = true;
            this.MatKhauColumn.VisibleIndex = 4;
            this.MatKhauColumn.Width = 100;
            // 
            // ChucVuColumn
            // 
            this.ChucVuColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChucVuColumn.AppearanceCell.Options.UseFont = true;
            this.ChucVuColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChucVuColumn.AppearanceHeader.Options.UseFont = true;
            this.ChucVuColumn.Caption = "Chức Vụ";
            this.ChucVuColumn.FieldName = "TenChucVu";
            this.ChucVuColumn.Name = "ChucVuColumn";
            this.ChucVuColumn.OptionsColumn.AllowEdit = false;
            this.ChucVuColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ChucVuColumn.Visible = true;
            this.ChucVuColumn.VisibleIndex = 5;
            this.ChucVuColumn.Width = 100;
            // 
            // SoDienThoaiColumn
            // 
            this.SoDienThoaiColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoDienThoaiColumn.AppearanceCell.Options.UseFont = true;
            this.SoDienThoaiColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoDienThoaiColumn.AppearanceHeader.Options.UseFont = true;
            this.SoDienThoaiColumn.Caption = "Số Điện Thoại";
            this.SoDienThoaiColumn.FieldName = "SoDienThoai";
            this.SoDienThoaiColumn.Name = "SoDienThoaiColumn";
            this.SoDienThoaiColumn.OptionsColumn.AllowEdit = false;
            this.SoDienThoaiColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SoDienThoaiColumn.Visible = true;
            this.SoDienThoaiColumn.VisibleIndex = 6;
            this.SoDienThoaiColumn.Width = 108;
            // 
            // DiaChiColumn
            // 
            this.DiaChiColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChiColumn.AppearanceCell.Options.UseFont = true;
            this.DiaChiColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChiColumn.AppearanceHeader.Options.UseFont = true;
            this.DiaChiColumn.Caption = "Địa Chỉ";
            this.DiaChiColumn.FieldName = "DiaChi";
            this.DiaChiColumn.Name = "DiaChiColumn";
            this.DiaChiColumn.OptionsColumn.AllowEdit = false;
            this.DiaChiColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.DiaChiColumn.Visible = true;
            this.DiaChiColumn.VisibleIndex = 7;
            this.DiaChiColumn.Width = 100;
            // 
            // EmailColumn
            // 
            this.EmailColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailColumn.AppearanceCell.Options.UseFont = true;
            this.EmailColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailColumn.AppearanceHeader.Options.UseFont = true;
            this.EmailColumn.Caption = "Email";
            this.EmailColumn.FieldName = "Email";
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.OptionsColumn.AllowEdit = false;
            this.EmailColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.EmailColumn.Visible = true;
            this.EmailColumn.VisibleIndex = 8;
            this.EmailColumn.Width = 100;
            // 
            // NguoiTaoColumn
            // 
            this.NguoiTaoColumn.Caption = "Người Tạo";
            this.NguoiTaoColumn.FieldName = "NhanVien2.TenDangNhap";
            this.NguoiTaoColumn.Name = "NguoiTaoColumn";
            this.NguoiTaoColumn.OptionsColumn.AllowEdit = false;
            this.NguoiTaoColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NguoiTaoColumn.Visible = true;
            this.NguoiTaoColumn.VisibleIndex = 9;
            this.NguoiTaoColumn.Width = 150;
            // 
            // NgayTaoColumn
            // 
            this.NgayTaoColumn.Caption = "Ngày Tạo";
            this.NgayTaoColumn.FieldName = "NgayTao";
            this.NgayTaoColumn.Name = "NgayTaoColumn";
            this.NgayTaoColumn.OptionsColumn.AllowEdit = false;
            this.NgayTaoColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NgayTaoColumn.Visible = true;
            this.NgayTaoColumn.VisibleIndex = 10;
            this.NgayTaoColumn.Width = 150;
            // 
            // NguoiChinhSuaColumn
            // 
            this.NguoiChinhSuaColumn.Caption = "Người Chỉnh Sửa";
            this.NguoiChinhSuaColumn.FieldName = "NhanVien3.TenDangNhap";
            this.NguoiChinhSuaColumn.Name = "NguoiChinhSuaColumn";
            this.NguoiChinhSuaColumn.OptionsColumn.AllowEdit = false;
            this.NguoiChinhSuaColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NguoiChinhSuaColumn.Visible = true;
            this.NguoiChinhSuaColumn.VisibleIndex = 11;
            this.NguoiChinhSuaColumn.Width = 150;
            // 
            // NgayChinhSuaColumn
            // 
            this.NgayChinhSuaColumn.Caption = "Ngày Chỉnh Sửa";
            this.NgayChinhSuaColumn.FieldName = "NgayChinhSua";
            this.NgayChinhSuaColumn.Name = "NgayChinhSuaColumn";
            this.NgayChinhSuaColumn.OptionsColumn.AllowEdit = false;
            this.NgayChinhSuaColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NgayChinhSuaColumn.Visible = true;
            this.NgayChinhSuaColumn.VisibleIndex = 12;
            this.NgayChinhSuaColumn.Width = 150;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(935, 416);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.NhanVienGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(915, 396);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Image = global::QuanLySieuThi.Properties.Resources.Actions_exit_icon__1_;
            this.CancelButtonControl.Location = new System.Drawing.Point(12, 412);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(120, 30);
            this.CancelButtonControl.TabIndex = 1;
            this.CancelButtonControl.Text = "Thoát";
            this.CancelButtonControl.Click += new System.EventHandler(this.CancelButtonControl_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Appearance.Options.UseFont = true;
            this.DeleteButton.Image = global::QuanLySieuThi.Properties.Resources.Actions_button_cancel_icon;
            this.DeleteButton.Location = new System.Drawing.Point(138, 412);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 30);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Appearance.Options.UseFont = true;
            this.OKButton.Image = global::QuanLySieuThi.Properties.Resources.Alarm_Arrow_Down_icon__1_;
            this.OKButton.Location = new System.Drawing.Point(804, 412);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Appearance.Options.UseFont = true;
            this.EditButton.Image = global::QuanLySieuThi.Properties.Resources.Cofigure_icon;
            this.EditButton.Location = new System.Drawing.Point(678, 412);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(120, 30);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Sửa";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Appearance.Options.UseFont = true;
            this.AddButton.Image = global::QuanLySieuThi.Properties.Resources.Actions_edit_add_icon;
            this.AddButton.Location = new System.Drawing.Point(552, 412);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 30);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NhanVienListForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 454);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhanVienListForm";
            this.Text = "NHÂN VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl DeleteButton;
        private Common.Controls.QButtonControl OKButton;
        private Common.Controls.QButtonControl EditButton;
        private Common.Controls.QButtonControl AddButton;
        private DevExpress.XtraGrid.GridControl NhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn HoVaTenColumn;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinhColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinhColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit DateEdit;
        private DevExpress.XtraGrid.Columns.GridColumn TenDangNhapColumn;
        private DevExpress.XtraGrid.Columns.GridColumn MatKhauColumn;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVuColumn;
        private DevExpress.XtraGrid.Columns.GridColumn SoDienThoaiColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiColumn;
        private DevExpress.XtraGrid.Columns.GridColumn EmailColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiTaoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTaoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiChinhSuaColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NgayChinhSuaColumn;
    }
}