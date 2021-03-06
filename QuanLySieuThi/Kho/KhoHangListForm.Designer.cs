﻿using Common.Forms;

namespace QuanLySieuThi.Kho
{
    partial class KhoHangListForm : QuanLySieuThiForm
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
            this.KhoGridControl = new DevExpress.XtraGrid.GridControl();
            this.KhoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenKhoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenQuanLyKhoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDienThoaiColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiTaoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTaoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiChinhSuaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayChinhSuaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.DeleteButton = new Common.Controls.QButtonControl();
            this.AddButton = new Common.Controls.QButtonControl();
            this.EditButton = new Common.Controls.QButtonControl();
            this.OKButton = new Common.Controls.QButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KhoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.KhoGridControl);
            this.layoutControl1.Location = new System.Drawing.Point(-1, -1);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(723, 295);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // KhoGridControl
            // 
            this.KhoGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.KhoGridControl.Location = new System.Drawing.Point(12, 12);
            this.KhoGridControl.MainView = this.KhoGridView;
            this.KhoGridControl.Name = "KhoGridControl";
            this.KhoGridControl.Size = new System.Drawing.Size(699, 271);
            this.KhoGridControl.TabIndex = 4;
            this.KhoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.KhoGridView});
            // 
            // KhoGridView
            // 
            this.KhoGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.KhoGridView.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoGridView.Appearance.Row.Options.UseFont = true;
            this.KhoGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenKhoColumn,
            this.TenQuanLyKhoColumn,
            this.DiaChiColumn,
            this.SoDienThoaiColumn,
            this.NguoiTaoColumn,
            this.NgayTaoColumn,
            this.NguoiChinhSuaColumn,
            this.NgayChinhSuaColumn});
            this.KhoGridView.GridControl = this.KhoGridControl;
            this.KhoGridView.Name = "KhoGridView";
            this.KhoGridView.OptionsBehavior.Editable = false;
            this.KhoGridView.OptionsView.ColumnAutoWidth = false;
            this.KhoGridView.OptionsView.ShowAutoFilterRow = true;
            this.KhoGridView.OptionsView.ShowGroupPanel = false;
            this.KhoGridView.OptionsView.ShowIndicator = false;
            this.KhoGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.KhoGridView_FocusedRowChanged);
            this.KhoGridView.DoubleClick += new System.EventHandler(this.KhoGridView_DoubleClick);
            // 
            // TenKhoColumn
            // 
            this.TenKhoColumn.Caption = "Tên Kho";
            this.TenKhoColumn.FieldName = "TenKho";
            this.TenKhoColumn.Name = "TenKhoColumn";
            this.TenKhoColumn.OptionsColumn.AllowEdit = false;
            this.TenKhoColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenKhoColumn.Visible = true;
            this.TenKhoColumn.VisibleIndex = 0;
            // 
            // TenQuanLyKhoColumn
            // 
            this.TenQuanLyKhoColumn.Caption = "Tên Người Quản Lý Kho";
            this.TenQuanLyKhoColumn.FieldName = "NhanVien2.TenDangNhap";
            this.TenQuanLyKhoColumn.Name = "TenQuanLyKhoColumn";
            this.TenQuanLyKhoColumn.OptionsColumn.AllowEdit = false;
            this.TenQuanLyKhoColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenQuanLyKhoColumn.Visible = true;
            this.TenQuanLyKhoColumn.VisibleIndex = 1;
            this.TenQuanLyKhoColumn.Width = 177;
            // 
            // DiaChiColumn
            // 
            this.DiaChiColumn.Caption = "Địa Chỉ";
            this.DiaChiColumn.FieldName = "DiaChi";
            this.DiaChiColumn.Name = "DiaChiColumn";
            this.DiaChiColumn.OptionsColumn.AllowEdit = false;
            this.DiaChiColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.DiaChiColumn.Visible = true;
            this.DiaChiColumn.VisibleIndex = 2;
            this.DiaChiColumn.Width = 108;
            // 
            // SoDienThoaiColumn
            // 
            this.SoDienThoaiColumn.Caption = "Số Điện Thoại";
            this.SoDienThoaiColumn.FieldName = "SoDienThoai";
            this.SoDienThoaiColumn.Name = "SoDienThoaiColumn";
            this.SoDienThoaiColumn.OptionsColumn.AllowEdit = false;
            this.SoDienThoaiColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SoDienThoaiColumn.Visible = true;
            this.SoDienThoaiColumn.VisibleIndex = 3;
            this.SoDienThoaiColumn.Width = 140;
            // 
            // NguoiTaoColumn
            // 
            this.NguoiTaoColumn.Caption = "Người Tạo";
            this.NguoiTaoColumn.FieldName = "NhanVien1.TenDangNhap";
            this.NguoiTaoColumn.Name = "NguoiTaoColumn";
            this.NguoiTaoColumn.OptionsColumn.AllowEdit = false;
            this.NguoiTaoColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NguoiTaoColumn.Visible = true;
            this.NguoiTaoColumn.VisibleIndex = 4;
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
            this.NgayTaoColumn.VisibleIndex = 5;
            // 
            // NguoiChinhSuaColumn
            // 
            this.NguoiChinhSuaColumn.Caption = "Người Chỉnh Sửa";
            this.NguoiChinhSuaColumn.FieldName = "NhanVien.TenDangNhap";
            this.NguoiChinhSuaColumn.Name = "NguoiChinhSuaColumn";
            this.NguoiChinhSuaColumn.OptionsColumn.AllowEdit = false;
            this.NguoiChinhSuaColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NguoiChinhSuaColumn.Visible = true;
            this.NguoiChinhSuaColumn.VisibleIndex = 6;
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
            this.NgayChinhSuaColumn.VisibleIndex = 7;
            this.NgayChinhSuaColumn.Width = 150;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(723, 295);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.KhoGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(703, 275);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CancelButtonControl.Appearance.Options.UseFont = true;
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
            this.AddButton.Location = new System.Drawing.Point(339, 292);
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
            this.EditButton.Location = new System.Drawing.Point(465, 292);
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
            this.OKButton.Location = new System.Drawing.Point(591, 292);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // KhoHangListForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 334);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KhoHangListForm";
            this.Text = "KHO HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KhoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl DeleteButton;
        private Common.Controls.QButtonControl AddButton;
        private Common.Controls.QButtonControl EditButton;
        private Common.Controls.QButtonControl OKButton;
        private DevExpress.XtraGrid.GridControl KhoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView KhoGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn TenKhoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn TenQuanLyKhoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiColumn;
        private DevExpress.XtraGrid.Columns.GridColumn SoDienThoaiColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiTaoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTaoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiChinhSuaColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NgayChinhSuaColumn;
    }
}