namespace QuanLySieuThi.KhachHang
{
    partial class QuanLyDoiTraHangHoaForm
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
            this.AddButton = new Common.Controls.QButtonControl();
            this.DoiTraHangHoaGridControl = new DevExpress.XtraGrid.GridControl();
            this.DoiTraHangHoaGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DoiTraHangHoaIdColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoaDonIdColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhanVienColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTienColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLapPhieuColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoiTraHangHoaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoiTraHangHoaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.OKButton);
            this.layoutControl1.Controls.Add(this.ViewButton);
            this.layoutControl1.Controls.Add(this.AddButton);
            this.layoutControl1.Controls.Add(this.DoiTraHangHoaGridControl);
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
            this.OKButton.TabIndex = 7;
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
            this.ViewButton.TabIndex = 6;
            this.ViewButton.Text = "Xem Chi Tiết";
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
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
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DoiTraHangHoaGridControl
            // 
            this.DoiTraHangHoaGridControl.Location = new System.Drawing.Point(12, 12);
            this.DoiTraHangHoaGridControl.MainView = this.DoiTraHangHoaGridView;
            this.DoiTraHangHoaGridControl.Name = "DoiTraHangHoaGridControl";
            this.DoiTraHangHoaGridControl.Size = new System.Drawing.Size(963, 505);
            this.DoiTraHangHoaGridControl.TabIndex = 4;
            this.DoiTraHangHoaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DoiTraHangHoaGridView});
            // 
            // DoiTraHangHoaGridView
            // 
            this.DoiTraHangHoaGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoiTraHangHoaGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.DoiTraHangHoaGridView.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoiTraHangHoaGridView.Appearance.Row.Options.UseFont = true;
            this.DoiTraHangHoaGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DoiTraHangHoaIdColumn,
            this.HoaDonIdColumn,
            this.NhanVienColumn,
            this.TongTienColumn,
            this.NgayLapPhieuColumn});
            this.DoiTraHangHoaGridView.GridControl = this.DoiTraHangHoaGridControl;
            this.DoiTraHangHoaGridView.Name = "DoiTraHangHoaGridView";
            this.DoiTraHangHoaGridView.OptionsBehavior.Editable = false;
            this.DoiTraHangHoaGridView.OptionsView.ColumnAutoWidth = false;
            this.DoiTraHangHoaGridView.OptionsView.ShowAutoFilterRow = true;
            this.DoiTraHangHoaGridView.OptionsView.ShowGroupPanel = false;
            this.DoiTraHangHoaGridView.OptionsView.ShowIndicator = false;
            this.DoiTraHangHoaGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.DoiTraHangHoaGridView_FocusedRowChanged);
            this.DoiTraHangHoaGridView.DoubleClick += new System.EventHandler(this.DoiTraHangHoaGridView_DoubleClick);
            // 
            // DoiTraHangHoaIdColumn
            // 
            this.DoiTraHangHoaIdColumn.Caption = "Đổi Trả Hàng Hóa Id";
            this.DoiTraHangHoaIdColumn.FieldName = "DoiTraHangHoaId";
            this.DoiTraHangHoaIdColumn.Name = "DoiTraHangHoaIdColumn";
            this.DoiTraHangHoaIdColumn.OptionsColumn.AllowEdit = false;
            this.DoiTraHangHoaIdColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.DoiTraHangHoaIdColumn.Visible = true;
            this.DoiTraHangHoaIdColumn.VisibleIndex = 0;
            this.DoiTraHangHoaIdColumn.Width = 200;
            // 
            // HoaDonIdColumn
            // 
            this.HoaDonIdColumn.Caption = "Hóa Đơn Id";
            this.HoaDonIdColumn.FieldName = "HoaDonId";
            this.HoaDonIdColumn.Name = "HoaDonIdColumn";
            this.HoaDonIdColumn.OptionsColumn.AllowEdit = false;
            this.HoaDonIdColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.HoaDonIdColumn.Visible = true;
            this.HoaDonIdColumn.VisibleIndex = 1;
            this.HoaDonIdColumn.Width = 200;
            // 
            // NhanVienColumn
            // 
            this.NhanVienColumn.Caption = "Nhân Viên Lập Phiếu";
            this.NhanVienColumn.FieldName = "NhanVien1.HoVaTen";
            this.NhanVienColumn.Name = "NhanVienColumn";
            this.NhanVienColumn.OptionsColumn.AllowEdit = false;
            this.NhanVienColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NhanVienColumn.Visible = true;
            this.NhanVienColumn.VisibleIndex = 2;
            this.NhanVienColumn.Width = 200;
            // 
            // TongTienColumn
            // 
            this.TongTienColumn.Caption = "Tổng Tiền Trả Lại";
            this.TongTienColumn.FieldName = "TongTienTraLai";
            this.TongTienColumn.Name = "TongTienColumn";
            this.TongTienColumn.OptionsColumn.AllowEdit = false;
            this.TongTienColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TongTienColumn.Visible = true;
            this.TongTienColumn.VisibleIndex = 3;
            this.TongTienColumn.Width = 150;
            // 
            // NgayLapPhieuColumn
            // 
            this.NgayLapPhieuColumn.Caption = "Ngày Lập Phiếu";
            this.NgayLapPhieuColumn.FieldName = "NgayLap";
            this.NgayLapPhieuColumn.Name = "NgayLapPhieuColumn";
            this.NgayLapPhieuColumn.OptionsColumn.AllowEdit = false;
            this.NgayLapPhieuColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NgayLapPhieuColumn.Visible = true;
            this.NgayLapPhieuColumn.VisibleIndex = 4;
            this.NgayLapPhieuColumn.Width = 150;
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
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(987, 563);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.DoiTraHangHoaGridControl;
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
            this.layoutControlItem3.Control = this.ViewButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(709, 509);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(124, 34);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.OKButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(843, 509);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(124, 34);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(124, 509);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(585, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(833, 509);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(10, 34);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 34);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 34);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // QuanLyDoiTraHangHoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 563);
            this.Controls.Add(this.layoutControl1);
            this.Name = "QuanLyDoiTraHangHoaForm";
            this.Text = "QuanLyDoiTraHangHoaForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoiTraHangHoaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoiTraHangHoaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl DoiTraHangHoaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView DoiTraHangHoaGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Common.Controls.QButtonControl OKButton;
        private Common.Controls.QButtonControl ViewButton;
        private Common.Controls.QButtonControl AddButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.Columns.GridColumn DoiTraHangHoaIdColumn;
        private DevExpress.XtraGrid.Columns.GridColumn HoaDonIdColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVienColumn;
        private DevExpress.XtraGrid.Columns.GridColumn TongTienColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLapPhieuColumn;
    }
}