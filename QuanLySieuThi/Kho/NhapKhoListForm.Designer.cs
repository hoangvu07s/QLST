using Common.Forms;

namespace QuanLySieuThi.Kho
{
    partial class NhapKhoListForm : QuanLySieuThiForm
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
            this.NhapKhoGridControl = new DevExpress.XtraGrid.GridControl();
            this.NhapKhoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PhieuNhapColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonHangColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiTaoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTaoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.OKButton = new Common.Controls.QButtonControl();
            this.SelectButton = new Common.Controls.QButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhapKhoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhapKhoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.NhapKhoGridControl);
            this.layoutControl1.Location = new System.Drawing.Point(-1, -1);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(610, 249);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // NhapKhoGridControl
            // 
            this.NhapKhoGridControl.Location = new System.Drawing.Point(12, 12);
            this.NhapKhoGridControl.MainView = this.NhapKhoGridView;
            this.NhapKhoGridControl.Name = "NhapKhoGridControl";
            this.NhapKhoGridControl.Size = new System.Drawing.Size(586, 225);
            this.NhapKhoGridControl.TabIndex = 4;
            this.NhapKhoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.NhapKhoGridView});
            // 
            // NhapKhoGridView
            // 
            this.NhapKhoGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapKhoGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.NhapKhoGridView.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapKhoGridView.Appearance.Row.Options.UseFont = true;
            this.NhapKhoGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PhieuNhapColumn,
            this.DonHangColumn,
            this.KhoColumn,
            this.NguoiTaoColumn,
            this.NgayTaoColumn});
            this.NhapKhoGridView.GridControl = this.NhapKhoGridControl;
            this.NhapKhoGridView.Name = "NhapKhoGridView";
            this.NhapKhoGridView.OptionsBehavior.Editable = false;
            this.NhapKhoGridView.OptionsView.ColumnAutoWidth = false;
            this.NhapKhoGridView.OptionsView.ShowAutoFilterRow = true;
            this.NhapKhoGridView.OptionsView.ShowGroupPanel = false;
            this.NhapKhoGridView.OptionsView.ShowIndicator = false;
            this.NhapKhoGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.NhapKhoGridView_FocusedRowChanged);
            this.NhapKhoGridView.DoubleClick += new System.EventHandler(this.NhapKhoGridView_DoubleClick);
            // 
            // PhieuNhapColumn
            // 
            this.PhieuNhapColumn.Caption = "Phiếu Nhập ID";
            this.PhieuNhapColumn.FieldName = "PhieuNhapKhoId";
            this.PhieuNhapColumn.Name = "PhieuNhapColumn";
            this.PhieuNhapColumn.OptionsColumn.AllowEdit = false;
            this.PhieuNhapColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.PhieuNhapColumn.Visible = true;
            this.PhieuNhapColumn.VisibleIndex = 0;
            this.PhieuNhapColumn.Width = 300;
            // 
            // DonHangColumn
            // 
            this.DonHangColumn.Caption = "Đơn Hàng";
            this.DonHangColumn.FieldName = "DonHangId";
            this.DonHangColumn.Name = "DonHangColumn";
            this.DonHangColumn.OptionsColumn.AllowEdit = false;
            this.DonHangColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.DonHangColumn.Visible = true;
            this.DonHangColumn.VisibleIndex = 1;
            this.DonHangColumn.Width = 300;
            // 
            // KhoColumn
            // 
            this.KhoColumn.Caption = "Kho";
            this.KhoColumn.FieldName = "Kho.TenKho";
            this.KhoColumn.Name = "KhoColumn";
            this.KhoColumn.OptionsColumn.AllowEdit = false;
            this.KhoColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.KhoColumn.Visible = true;
            this.KhoColumn.VisibleIndex = 2;
            this.KhoColumn.Width = 200;
            // 
            // NguoiTaoColumn
            // 
            this.NguoiTaoColumn.Caption = "Người Tạo";
            this.NguoiTaoColumn.FieldName = "NhanVien.HoVaTen";
            this.NguoiTaoColumn.Name = "NguoiTaoColumn";
            this.NguoiTaoColumn.OptionsColumn.AllowEdit = false;
            this.NguoiTaoColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NguoiTaoColumn.Visible = true;
            this.NguoiTaoColumn.VisibleIndex = 3;
            this.NguoiTaoColumn.Width = 250;
            // 
            // NgayTaoColumn
            // 
            this.NgayTaoColumn.Caption = "Ngày Tạo";
            this.NgayTaoColumn.FieldName = "NgayTao";
            this.NgayTaoColumn.Name = "NgayTaoColumn";
            this.NgayTaoColumn.OptionsColumn.AllowEdit = false;
            this.NgayTaoColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NgayTaoColumn.Visible = true;
            this.NgayTaoColumn.VisibleIndex = 4;
            this.NgayTaoColumn.Width = 200;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(610, 249);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.NhapKhoGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(590, 229);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.OKButton.Appearance.Options.UseFont = true;
            this.OKButton.Location = new System.Drawing.Point(477, 242);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SelectButton.Appearance.Options.UseFont = true;
            this.SelectButton.Location = new System.Drawing.Point(351, 242);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(120, 30);
            this.SelectButton.TabIndex = 3;
            this.SelectButton.Text = "Xem Chi Tiết";
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // NhapKhoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 284);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.layoutControl1);
            this.Name = "NhapKhoListForm";
            this.Text = "DANH SÁCH PHIẾU NHẬP KHO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NhapKhoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhapKhoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl NhapKhoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView NhapKhoGridView;
        private DevExpress.XtraGrid.Columns.GridColumn PhieuNhapColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DonHangColumn;
        private DevExpress.XtraGrid.Columns.GridColumn KhoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiTaoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTaoColumn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Common.Controls.QButtonControl OKButton;
        private Common.Controls.QButtonControl SelectButton;
    }
}