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
            this.layoutControl1.Size = new System.Drawing.Size(722, 299);
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
            this.NhanVienGridControl.Size = new System.Drawing.Size(698, 275);
            this.NhanVienGridControl.TabIndex = 4;
            this.NhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView1});
            // 
            // GridView1
            // 
            this.GridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.EmailColumn});
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
            this.HoVaTenColumn.Caption = "Ho Va Ten";
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
            this.GioiTinhColumn.Caption = "Gioi Tinh";
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
            this.NgaySinhColumn.Caption = "Ngay Sinh";
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
            this.TenDangNhapColumn.Caption = "Ten Dang Nhap";
            this.TenDangNhapColumn.FieldName = "TenDangNhap";
            this.TenDangNhapColumn.Name = "TenDangNhapColumn";
            this.TenDangNhapColumn.OptionsColumn.AllowEdit = false;
            this.TenDangNhapColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenDangNhapColumn.Visible = true;
            this.TenDangNhapColumn.VisibleIndex = 3;
            this.TenDangNhapColumn.Width = 100;
            // 
            // MatKhauColumn
            // 
            this.MatKhauColumn.Caption = "Mat Khau";
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
            this.ChucVuColumn.Caption = "Chuc Vu";
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
            this.SoDienThoaiColumn.Caption = "So Dien Thoai";
            this.SoDienThoaiColumn.FieldName = "SoDienThoai";
            this.SoDienThoaiColumn.Name = "SoDienThoaiColumn";
            this.SoDienThoaiColumn.OptionsColumn.AllowEdit = false;
            this.SoDienThoaiColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SoDienThoaiColumn.Visible = true;
            this.SoDienThoaiColumn.VisibleIndex = 6;
            this.SoDienThoaiColumn.Width = 100;
            // 
            // DiaChiColumn
            // 
            this.DiaChiColumn.Caption = "Dia Chi";
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
            this.EmailColumn.Caption = "Email";
            this.EmailColumn.FieldName = "Email";
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.OptionsColumn.AllowEdit = false;
            this.EmailColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.EmailColumn.Visible = true;
            this.EmailColumn.VisibleIndex = 8;
            this.EmailColumn.Width = 100;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(722, 299);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.NhanVienGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(702, 279);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Location = new System.Drawing.Point(12, 292);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(120, 30);
            this.CancelButtonControl.TabIndex = 1;
            this.CancelButtonControl.Text = "Thoat";
            this.CancelButtonControl.Click += new System.EventHandler(this.CancelButtonControl_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.DeleteButton.Appearance.Options.UseFont = true;
            this.DeleteButton.Location = new System.Drawing.Point(138, 292);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 30);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Xoa";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.OKButton.Appearance.Options.UseFont = true;
            this.OKButton.Location = new System.Drawing.Point(591, 291);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.EditButton.Appearance.Options.UseFont = true;
            this.EditButton.Location = new System.Drawing.Point(465, 292);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(120, 30);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Sua";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.AddButton.Appearance.Options.UseFont = true;
            this.AddButton.Location = new System.Drawing.Point(339, 292);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 30);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Them";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NhanVienListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 334);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.Name = "NhanVienListForm";
            this.Text = "Nhan Vien";
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
    }
}