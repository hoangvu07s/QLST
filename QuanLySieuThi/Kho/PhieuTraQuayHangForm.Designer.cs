using Common.Forms;

namespace QuanLySieuThi.Kho
{
    partial class PhieuTraQuayHangForm : QuanLySieuThiForm
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
            this.phieuTraHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.phieuTraHangGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.phieuTraHangQuayHangColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhanVienColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quayHangColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKhoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayLapColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.OKButton = new Common.Controls.QButtonControl();
            this.AddButton = new Common.Controls.QButtonControl();
            this.XemChiTietButton = new Common.Controls.QButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuTraHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuTraHangGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.phieuTraHangGridControl);
            this.layoutControl1.Location = new System.Drawing.Point(-1, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(723, 299);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // phieuTraHangGridControl
            // 
            this.phieuTraHangGridControl.Location = new System.Drawing.Point(12, 12);
            this.phieuTraHangGridControl.MainView = this.phieuTraHangGridView;
            this.phieuTraHangGridControl.Name = "phieuTraHangGridControl";
            this.phieuTraHangGridControl.Size = new System.Drawing.Size(699, 275);
            this.phieuTraHangGridControl.TabIndex = 4;
            this.phieuTraHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.phieuTraHangGridView});
            this.phieuTraHangGridControl.DoubleClick += new System.EventHandler(this.phieuTraHangGridControl_DoubleClick);
            // 
            // phieuTraHangGridView
            // 
            this.phieuTraHangGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phieuTraHangGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.phieuTraHangGridView.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phieuTraHangGridView.Appearance.Row.Options.UseFont = true;
            this.phieuTraHangGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.phieuTraHangQuayHangColumn,
            this.nhanVienColumn,
            this.quayHangColumn,
            this.TenKhoColumn,
            this.ngayLapColumn});
            this.phieuTraHangGridView.GridControl = this.phieuTraHangGridControl;
            this.phieuTraHangGridView.Name = "phieuTraHangGridView";
            this.phieuTraHangGridView.OptionsBehavior.Editable = false;
            this.phieuTraHangGridView.OptionsView.ColumnAutoWidth = false;
            this.phieuTraHangGridView.OptionsView.ShowAutoFilterRow = true;
            this.phieuTraHangGridView.OptionsView.ShowGroupPanel = false;
            this.phieuTraHangGridView.OptionsView.ShowIndicator = false;
            this.phieuTraHangGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.phieuTraHangGridView_FocusedRowChanged);
            this.phieuTraHangGridView.DoubleClick += new System.EventHandler(this.phieuTraHangGridView_DoubleClick);
            // 
            // phieuTraHangQuayHangColumn
            // 
            this.phieuTraHangQuayHangColumn.Caption = "Phiếu trả quầy hàng Id";
            this.phieuTraHangQuayHangColumn.FieldName = "PhieuTraQuayHangId";
            this.phieuTraHangQuayHangColumn.Name = "phieuTraHangQuayHangColumn";
            this.phieuTraHangQuayHangColumn.OptionsColumn.AllowEdit = false;
            this.phieuTraHangQuayHangColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.phieuTraHangQuayHangColumn.Visible = true;
            this.phieuTraHangQuayHangColumn.VisibleIndex = 0;
            this.phieuTraHangQuayHangColumn.Width = 150;
            // 
            // nhanVienColumn
            // 
            this.nhanVienColumn.Caption = "Nhân Viên";
            this.nhanVienColumn.FieldName = "TenDangNhap";
            this.nhanVienColumn.Name = "nhanVienColumn";
            this.nhanVienColumn.OptionsColumn.AllowEdit = false;
            this.nhanVienColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nhanVienColumn.Visible = true;
            this.nhanVienColumn.VisibleIndex = 1;
            this.nhanVienColumn.Width = 150;
            // 
            // quayHangColumn
            // 
            this.quayHangColumn.Caption = "Quầy Hàng";
            this.quayHangColumn.FieldName = "TenQuay";
            this.quayHangColumn.Name = "quayHangColumn";
            this.quayHangColumn.OptionsColumn.AllowEdit = false;
            this.quayHangColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.quayHangColumn.Visible = true;
            this.quayHangColumn.VisibleIndex = 2;
            this.quayHangColumn.Width = 150;
            // 
            // TenKhoColumn
            // 
            this.TenKhoColumn.Caption = "Tên Kho";
            this.TenKhoColumn.FieldName = "TenKho";
            this.TenKhoColumn.Name = "TenKhoColumn";
            this.TenKhoColumn.OptionsColumn.AllowEdit = false;
            this.TenKhoColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenKhoColumn.Visible = true;
            this.TenKhoColumn.VisibleIndex = 3;
            this.TenKhoColumn.Width = 150;
            // 
            // ngayLapColumn
            // 
            this.ngayLapColumn.Caption = "Ngày Lập";
            this.ngayLapColumn.FieldName = "NgayLap";
            this.ngayLapColumn.Name = "ngayLapColumn";
            this.ngayLapColumn.OptionsColumn.AllowEdit = false;
            this.ngayLapColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ngayLapColumn.Visible = true;
            this.ngayLapColumn.VisibleIndex = 4;
            this.ngayLapColumn.Width = 150;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(723, 299);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.phieuTraHangGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(703, 279);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Location = new System.Drawing.Point(11, 298);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(120, 30);
            this.CancelButtonControl.TabIndex = 1;
            this.CancelButtonControl.Text = "Thoát";
            this.CancelButtonControl.Click += new System.EventHandler(this.CancelButtonControl_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.OKButton.Appearance.Options.UseFont = true;
            this.OKButton.Location = new System.Drawing.Point(591, 298);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.AddButton.Appearance.Options.UseFont = true;
            this.AddButton.Location = new System.Drawing.Point(465, 298);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 30);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // XemChiTietButton
            // 
            this.XemChiTietButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XemChiTietButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.XemChiTietButton.Appearance.Options.UseFont = true;
            this.XemChiTietButton.Location = new System.Drawing.Point(137, 298);
            this.XemChiTietButton.Name = "XemChiTietButton";
            this.XemChiTietButton.Size = new System.Drawing.Size(120, 30);
            this.XemChiTietButton.TabIndex = 6;
            this.XemChiTietButton.Text = "Xem Chi Tiết";
            this.XemChiTietButton.Click += new System.EventHandler(this.XemChiTietButton_Click);
            // 
            // PhieuTraQuayHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 334);
            this.Controls.Add(this.XemChiTietButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.Name = "PhieuTraQuayHangForm";
            this.Text = "PhieuTraQuayHangForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phieuTraHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuTraHangGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl phieuTraHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView phieuTraHangGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn phieuTraHangQuayHangColumn;
        private DevExpress.XtraGrid.Columns.GridColumn nhanVienColumn;
        private DevExpress.XtraGrid.Columns.GridColumn quayHangColumn;
        private DevExpress.XtraGrid.Columns.GridColumn TenKhoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn ngayLapColumn;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl OKButton;
        private Common.Controls.QButtonControl AddButton;
        private Common.Controls.QButtonControl XemChiTietButton;
    }
}