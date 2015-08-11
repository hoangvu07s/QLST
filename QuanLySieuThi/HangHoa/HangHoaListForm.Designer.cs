using Common.Forms;

namespace QuanLySieuThi.HangHoa
{
    partial class HangHoaListForm : QuanLySieuThiForm
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
            this.HangHoaGridControl = new DevExpress.XtraGrid.GridControl();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenHangHoaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiHangHoaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhaCungCapColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuayHangColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongTonQuayColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoTheTraLaiColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TraLaiItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.GiaNhapVaoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBanRaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HinhAnhColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.DeleteButton = new Common.Controls.QButtonControl();
            this.AddButton = new Common.Controls.QButtonControl();
            this.EditButton = new Common.Controls.QButtonControl();
            this.OKButton = new Common.Controls.QButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraLaiItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.HangHoaGridControl);
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(920, 294);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // HangHoaGridControl
            // 
            this.HangHoaGridControl.Location = new System.Drawing.Point(12, 12);
            this.HangHoaGridControl.MainView = this.GridView1;
            this.HangHoaGridControl.Name = "HangHoaGridControl";
            this.HangHoaGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TraLaiItemCheckEdit});
            this.HangHoaGridControl.Size = new System.Drawing.Size(896, 270);
            this.HangHoaGridControl.TabIndex = 4;
            this.HangHoaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView1});
            // 
            // GridView1
            // 
            this.GridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView1.Appearance.Row.Options.UseFont = true;
            this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenHangHoaColumn,
            this.LoaiHangHoaColumn,
            this.NhaCungCapColumn,
            this.QuayHangColumn,
            this.SoLuongTonQuayColumn,
            this.CoTheTraLaiColumn,
            this.GiaNhapVaoColumn,
            this.GiaBanRaColumn,
            this.HinhAnhColumn});
            this.GridView1.GridControl = this.HangHoaGridControl;
            this.GridView1.Name = "GridView1";
            this.GridView1.OptionsBehavior.Editable = false;
            this.GridView1.OptionsView.ColumnAutoWidth = false;
            this.GridView1.OptionsView.ShowAutoFilterRow = true;
            this.GridView1.OptionsView.ShowGroupPanel = false;
            this.GridView1.OptionsView.ShowIndicator = false;
            this.GridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridView1_FocusedRowChanged);
            this.GridView1.DoubleClick += new System.EventHandler(this.GridView1_DoubleClick);
            // 
            // TenHangHoaColumn
            // 
            this.TenHangHoaColumn.Caption = "Tên Hàng Hóa";
            this.TenHangHoaColumn.FieldName = "TenHangHoa";
            this.TenHangHoaColumn.Name = "TenHangHoaColumn";
            this.TenHangHoaColumn.OptionsColumn.AllowEdit = false;
            this.TenHangHoaColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenHangHoaColumn.Visible = true;
            this.TenHangHoaColumn.VisibleIndex = 0;
            this.TenHangHoaColumn.Width = 103;
            // 
            // LoaiHangHoaColumn
            // 
            this.LoaiHangHoaColumn.Caption = "Loại Hàng Hóa";
            this.LoaiHangHoaColumn.FieldName = "LoaiHangHoa.TenLoaiHangHoa";
            this.LoaiHangHoaColumn.Name = "LoaiHangHoaColumn";
            this.LoaiHangHoaColumn.OptionsColumn.AllowEdit = false;
            this.LoaiHangHoaColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.LoaiHangHoaColumn.Visible = true;
            this.LoaiHangHoaColumn.VisibleIndex = 1;
            this.LoaiHangHoaColumn.Width = 112;
            // 
            // NhaCungCapColumn
            // 
            this.NhaCungCapColumn.Caption = "Nhà Cung Cấp";
            this.NhaCungCapColumn.FieldName = "NhaCungCap.TenNhaCungCap";
            this.NhaCungCapColumn.Name = "NhaCungCapColumn";
            this.NhaCungCapColumn.OptionsColumn.AllowEdit = false;
            this.NhaCungCapColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NhaCungCapColumn.Visible = true;
            this.NhaCungCapColumn.VisibleIndex = 2;
            this.NhaCungCapColumn.Width = 113;
            // 
            // QuayHangColumn
            // 
            this.QuayHangColumn.Caption = "Quầy Hàng";
            this.QuayHangColumn.FieldName = "QuayHang.TenQuay";
            this.QuayHangColumn.Name = "QuayHangColumn";
            this.QuayHangColumn.OptionsColumn.AllowEdit = false;
            this.QuayHangColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.QuayHangColumn.Visible = true;
            this.QuayHangColumn.VisibleIndex = 3;
            this.QuayHangColumn.Width = 105;
            // 
            // SoLuongTonQuayColumn
            // 
            this.SoLuongTonQuayColumn.Caption = "Số lượng Tồn Quầy";
            this.SoLuongTonQuayColumn.FieldName = "SoLuongTonQuay";
            this.SoLuongTonQuayColumn.Name = "SoLuongTonQuayColumn";
            this.SoLuongTonQuayColumn.OptionsColumn.AllowEdit = false;
            this.SoLuongTonQuayColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SoLuongTonQuayColumn.Visible = true;
            this.SoLuongTonQuayColumn.VisibleIndex = 4;
            this.SoLuongTonQuayColumn.Width = 123;
            // 
            // CoTheTraLaiColumn
            // 
            this.CoTheTraLaiColumn.Caption = "Trả Lại";
            this.CoTheTraLaiColumn.ColumnEdit = this.TraLaiItemCheckEdit;
            this.CoTheTraLaiColumn.FieldName = "CoTheTraLai";
            this.CoTheTraLaiColumn.Name = "CoTheTraLaiColumn";
            this.CoTheTraLaiColumn.OptionsColumn.AllowEdit = false;
            this.CoTheTraLaiColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.CoTheTraLaiColumn.Visible = true;
            this.CoTheTraLaiColumn.VisibleIndex = 5;
            // 
            // TraLaiItemCheckEdit
            // 
            this.TraLaiItemCheckEdit.AutoHeight = false;
            this.TraLaiItemCheckEdit.Name = "TraLaiItemCheckEdit";
            // 
            // GiaNhapVaoColumn
            // 
            this.GiaNhapVaoColumn.Caption = "Giá Nhập Vào";
            this.GiaNhapVaoColumn.FieldName = "GiaNhapVao";
            this.GiaNhapVaoColumn.Name = "GiaNhapVaoColumn";
            this.GiaNhapVaoColumn.OptionsColumn.AllowEdit = false;
            this.GiaNhapVaoColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.GiaNhapVaoColumn.Visible = true;
            this.GiaNhapVaoColumn.VisibleIndex = 6;
            this.GiaNhapVaoColumn.Width = 94;
            // 
            // GiaBanRaColumn
            // 
            this.GiaBanRaColumn.Caption = "Giá Bán Ra";
            this.GiaBanRaColumn.FieldName = "GiaBanRa";
            this.GiaBanRaColumn.Name = "GiaBanRaColumn";
            this.GiaBanRaColumn.OptionsColumn.AllowEdit = false;
            this.GiaBanRaColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.GiaBanRaColumn.Visible = true;
            this.GiaBanRaColumn.VisibleIndex = 7;
            this.GiaBanRaColumn.Width = 90;
            // 
            // HinhAnhColumn
            // 
            this.HinhAnhColumn.Caption = "Hình Ảnh";
            this.HinhAnhColumn.FieldName = "HinhAnh";
            this.HinhAnhColumn.Name = "HinhAnhColumn";
            this.HinhAnhColumn.OptionsColumn.AllowEdit = false;
            this.HinhAnhColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.HinhAnhColumn.Visible = true;
            this.HinhAnhColumn.VisibleIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(920, 294);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.HangHoaGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(900, 274);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Image = global::QuanLySieuThi.Properties.Resources.Actions_exit_icon__1_;
            this.CancelButtonControl.Location = new System.Drawing.Point(12, 292);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(120, 30);
            this.CancelButtonControl.TabIndex = 1;
            this.CancelButtonControl.Text = "Thoát";
            this.CancelButtonControl.Click += new System.EventHandler(this.CancelButtonControl_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.DeleteButton.Appearance.Options.UseFont = true;
            this.DeleteButton.Image = global::QuanLySieuThi.Properties.Resources.Actions_button_cancel_icon;
            this.DeleteButton.Location = new System.Drawing.Point(138, 292);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 30);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.AddButton.Appearance.Options.UseFont = true;
            this.AddButton.Image = global::QuanLySieuThi.Properties.Resources.Actions_edit_add_icon;
            this.AddButton.Location = new System.Drawing.Point(536, 292);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 30);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.EditButton.Appearance.Options.UseFont = true;
            this.EditButton.Image = global::QuanLySieuThi.Properties.Resources.Cofigure_icon;
            this.EditButton.Location = new System.Drawing.Point(662, 292);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(120, 30);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Sửa";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.OKButton.Appearance.Options.UseFont = true;
            this.OKButton.Image = global::QuanLySieuThi.Properties.Resources.Alarm_Arrow_Down_icon__1_;
            this.OKButton.Location = new System.Drawing.Point(788, 292);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // HangHoaListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 334);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.Name = "HangHoaListForm";
            this.Text = "HÀNG HÓA";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraLaiItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl HangHoaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn TenHangHoaColumn;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiHangHoaColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NhaCungCapColumn;
        private DevExpress.XtraGrid.Columns.GridColumn QuayHangColumn;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongTonQuayColumn;
        private DevExpress.XtraGrid.Columns.GridColumn CoTheTraLaiColumn;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNhapVaoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBanRaColumn;
        private DevExpress.XtraGrid.Columns.GridColumn HinhAnhColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit TraLaiItemCheckEdit;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl DeleteButton;
        private Common.Controls.QButtonControl AddButton;
        private Common.Controls.QButtonControl EditButton;
        private Common.Controls.QButtonControl OKButton;
    }
}