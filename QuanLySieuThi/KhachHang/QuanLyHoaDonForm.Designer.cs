namespace QuanLySieuThi.KhachHang
{
    partial class QuanLyHoaDonForm
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
            this.OKButton = new Common.Controls.QButtonControl();
            this.ViewButton = new Common.Controls.QButtonControl();
            this.DeleteButton = new Common.Controls.QButtonControl();
            this.AddButton = new Common.Controls.QButtonControl();
            this.HoaDonGridControl = new DevExpress.XtraGrid.GridControl();
            this.HoaDonGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHoaDonColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhachHangColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhanVienColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLapColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThaiHoaDonColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.OKButton);
            this.layoutControl1.Controls.Add(this.ViewButton);
            this.layoutControl1.Controls.Add(this.DeleteButton);
            this.layoutControl1.Controls.Add(this.AddButton);
            this.layoutControl1.Controls.Add(this.HoaDonGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(987, 563);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // OKButton
            // 
            this.OKButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.OKButton.Appearance.Options.UseFont = true;
            this.OKButton.Location = new System.Drawing.Point(855, 521);
            this.OKButton.MaximumSize = new System.Drawing.Size(120, 30);
            this.OKButton.MinimumSize = new System.Drawing.Size(120, 30);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.StyleController = this.layoutControl1;
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.ViewButton.Appearance.Options.UseFont = true;
            this.ViewButton.Location = new System.Drawing.Point(721, 521);
            this.ViewButton.MaximumSize = new System.Drawing.Size(120, 30);
            this.ViewButton.MinimumSize = new System.Drawing.Size(120, 30);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(120, 30);
            this.ViewButton.StyleController = this.layoutControl1;
            this.ViewButton.TabIndex = 7;
            this.ViewButton.Text = "Chi Tiết Hóa Đơn";
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.DeleteButton.Appearance.Options.UseFont = true;
            this.DeleteButton.Location = new System.Drawing.Point(587, 521);
            this.DeleteButton.MaximumSize = new System.Drawing.Size(120, 30);
            this.DeleteButton.MinimumSize = new System.Drawing.Size(120, 30);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 30);
            this.DeleteButton.StyleController = this.layoutControl1;
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Hủy Hóa Đơn";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.AddButton.Appearance.Options.UseFont = true;
            this.AddButton.Location = new System.Drawing.Point(12, 521);
            this.AddButton.MaximumSize = new System.Drawing.Size(120, 30);
            this.AddButton.MinimumSize = new System.Drawing.Size(120, 30);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 30);
            this.AddButton.StyleController = this.layoutControl1;
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Tạo Hóa Đơn";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // HoaDonGridControl
            // 
            this.HoaDonGridControl.Location = new System.Drawing.Point(12, 12);
            this.HoaDonGridControl.MainView = this.HoaDonGridView;
            this.HoaDonGridControl.Name = "HoaDonGridControl";
            this.HoaDonGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.HoaDonGridControl.Size = new System.Drawing.Size(963, 505);
            this.HoaDonGridControl.TabIndex = 4;
            this.HoaDonGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HoaDonGridView});
            // 
            // HoaDonGridView
            // 
            this.HoaDonGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoaDonGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.HoaDonGridView.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoaDonGridView.Appearance.Row.Options.UseFont = true;
            this.HoaDonGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHoaDonColumn,
            this.KhachHangColumn,
            this.NhanVienColumn,
            this.NgayLapColumn,
            this.TrangThaiHoaDonColumn});
            this.HoaDonGridView.GridControl = this.HoaDonGridControl;
            this.HoaDonGridView.Name = "HoaDonGridView";
            this.HoaDonGridView.OptionsBehavior.Editable = false;
            this.HoaDonGridView.OptionsView.ColumnAutoWidth = false;
            this.HoaDonGridView.OptionsView.ShowAutoFilterRow = true;
            this.HoaDonGridView.OptionsView.ShowGroupPanel = false;
            this.HoaDonGridView.OptionsView.ShowIndicator = false;
            this.HoaDonGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.HoaDonGridView_FocusedRowChanged);
            this.HoaDonGridView.DoubleClick += new System.EventHandler(this.HoaDonGridView_DoubleClick);
            // 
            // MaHoaDonColumn
            // 
            this.MaHoaDonColumn.Caption = "Mã Hóa Đơn";
            this.MaHoaDonColumn.FieldName = "HoaDonId";
            this.MaHoaDonColumn.Name = "MaHoaDonColumn";
            this.MaHoaDonColumn.OptionsColumn.AllowEdit = false;
            this.MaHoaDonColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.MaHoaDonColumn.Visible = true;
            this.MaHoaDonColumn.VisibleIndex = 0;
            this.MaHoaDonColumn.Width = 250;
            // 
            // KhachHangColumn
            // 
            this.KhachHangColumn.Caption = "Khách Hàng";
            this.KhachHangColumn.FieldName = "KhachHang.TenKhachHang";
            this.KhachHangColumn.Name = "KhachHangColumn";
            this.KhachHangColumn.OptionsColumn.AllowEdit = false;
            this.KhachHangColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.KhachHangColumn.Visible = true;
            this.KhachHangColumn.VisibleIndex = 1;
            this.KhachHangColumn.Width = 200;
            // 
            // NhanVienColumn
            // 
            this.NhanVienColumn.Caption = "Nhân Viên Lập Hóa Đơn";
            this.NhanVienColumn.FieldName = "NhanVien1.HoVaTen";
            this.NhanVienColumn.Name = "NhanVienColumn";
            this.NhanVienColumn.OptionsColumn.AllowEdit = false;
            this.NhanVienColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NhanVienColumn.Visible = true;
            this.NhanVienColumn.VisibleIndex = 2;
            this.NhanVienColumn.Width = 250;
            // 
            // NgayLapColumn
            // 
            this.NgayLapColumn.Caption = "Ngày Lập";
            this.NgayLapColumn.FieldName = "NgayLap";
            this.NgayLapColumn.Name = "NgayLapColumn";
            this.NgayLapColumn.OptionsColumn.AllowEdit = false;
            this.NgayLapColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NgayLapColumn.Visible = true;
            this.NgayLapColumn.VisibleIndex = 3;
            this.NgayLapColumn.Width = 150;
            // 
            // TrangThaiHoaDonColumn
            // 
            this.TrangThaiHoaDonColumn.Caption = "Trạng Thái Hóa Đơn";
            this.TrangThaiHoaDonColumn.ColumnEdit = this.repositoryItemCheckEdit1;
            this.TrangThaiHoaDonColumn.FieldName = "HoatDong";
            this.TrangThaiHoaDonColumn.Name = "TrangThaiHoaDonColumn";
            this.TrangThaiHoaDonColumn.OptionsColumn.AllowEdit = false;
            this.TrangThaiHoaDonColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TrangThaiHoaDonColumn.Visible = true;
            this.TrangThaiHoaDonColumn.VisibleIndex = 4;
            this.TrangThaiHoaDonColumn.Width = 150;
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
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(987, 563);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.HoaDonGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(967, 509);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.AddButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 509);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(124, 34);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.DeleteButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(575, 509);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(124, 34);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ViewButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(709, 509);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(124, 34);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.OKButton;
            this.layoutControlItem5.Location = new System.Drawing.Point(843, 509);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(124, 34);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(124, 509);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(451, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(699, 509);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 34);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(833, 509);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(10, 34);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // QuanLyHoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 563);
            this.Controls.Add(this.layoutControl1);
            this.Name = "QuanLyHoaDonForm";
            this.Text = "QuanLyHoaDonForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl HoaDonGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView HoaDonGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Common.Controls.QButtonControl OKButton;
        private Common.Controls.QButtonControl ViewButton;
        private Common.Controls.QButtonControl DeleteButton;
        private Common.Controls.QButtonControl AddButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraGrid.Columns.GridColumn MaHoaDonColumn;
        private DevExpress.XtraGrid.Columns.GridColumn KhachHangColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVienColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLapColumn;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThaiHoaDonColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}