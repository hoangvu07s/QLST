using Common.Forms;

namespace QuanLySieuThi.HangHoa
{
    partial class DonHangListForm : QuanLySieuThiForm
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
            this.DonHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.DonHangGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDonHangGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiLapDonHangGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhaCungCapGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThaiDonHangColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.DeleteButton = new Common.Controls.QButtonControl();
            this.OKButton = new Common.Controls.QButtonControl();
            this.EditButton = new Common.Controls.QButtonControl();
            this.AddButton = new Common.Controls.QButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonHangGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.DonHangGridControl);
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(829, 201);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // DonHangGridControl
            // 
            this.DonHangGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DonHangGridControl.Location = new System.Drawing.Point(12, 12);
            this.DonHangGridControl.MainView = this.DonHangGridView;
            this.DonHangGridControl.Name = "DonHangGridControl";
            this.DonHangGridControl.Size = new System.Drawing.Size(805, 177);
            this.DonHangGridControl.TabIndex = 4;
            this.DonHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DonHangGridView});
            // 
            // DonHangGridView
            // 
            this.DonHangGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonHangGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.DonHangGridView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonHangGridView.Appearance.Row.Options.UseFont = true;
            this.DonHangGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDonHangGridColumn,
            this.NguoiLapDonHangGridColumn,
            this.NhaCungCapGridColumn,
            this.TrangThaiDonHangColumn});
            this.DonHangGridView.GridControl = this.DonHangGridControl;
            this.DonHangGridView.Name = "DonHangGridView";
            this.DonHangGridView.OptionsBehavior.Editable = false;
            this.DonHangGridView.OptionsView.ColumnAutoWidth = false;
            this.DonHangGridView.OptionsView.ShowAutoFilterRow = true;
            this.DonHangGridView.OptionsView.ShowGroupPanel = false;
            this.DonHangGridView.OptionsView.ShowIndicator = false;
            this.DonHangGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.DonHangGridView_FocusedRowChanged);
            this.DonHangGridView.DoubleClick += new System.EventHandler(this.DonHangGridView_DoubleClick);
            // 
            // MaDonHangGridColumn
            // 
            this.MaDonHangGridColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDonHangGridColumn.AppearanceCell.Options.UseFont = true;
            this.MaDonHangGridColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDonHangGridColumn.AppearanceHeader.Options.UseFont = true;
            this.MaDonHangGridColumn.Caption = "Mã Đơn Hàng";
            this.MaDonHangGridColumn.FieldName = "DonHangId";
            this.MaDonHangGridColumn.Name = "MaDonHangGridColumn";
            this.MaDonHangGridColumn.OptionsColumn.AllowEdit = false;
            this.MaDonHangGridColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.MaDonHangGridColumn.Visible = true;
            this.MaDonHangGridColumn.VisibleIndex = 0;
            this.MaDonHangGridColumn.Width = 200;
            // 
            // NguoiLapDonHangGridColumn
            // 
            this.NguoiLapDonHangGridColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NguoiLapDonHangGridColumn.AppearanceCell.Options.UseFont = true;
            this.NguoiLapDonHangGridColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NguoiLapDonHangGridColumn.AppearanceHeader.Options.UseFont = true;
            this.NguoiLapDonHangGridColumn.Caption = "Người Lập Đơn Hàng";
            this.NguoiLapDonHangGridColumn.FieldName = "NguoiLapDonHang";
            this.NguoiLapDonHangGridColumn.Name = "NguoiLapDonHangGridColumn";
            this.NguoiLapDonHangGridColumn.OptionsColumn.AllowEdit = false;
            this.NguoiLapDonHangGridColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NguoiLapDonHangGridColumn.Visible = true;
            this.NguoiLapDonHangGridColumn.VisibleIndex = 1;
            this.NguoiLapDonHangGridColumn.Width = 200;
            // 
            // NhaCungCapGridColumn
            // 
            this.NhaCungCapGridColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhaCungCapGridColumn.AppearanceCell.Options.UseFont = true;
            this.NhaCungCapGridColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhaCungCapGridColumn.AppearanceHeader.Options.UseFont = true;
            this.NhaCungCapGridColumn.Caption = "Tên Nhà Cung Cấp";
            this.NhaCungCapGridColumn.FieldName = "TenNhaCungCap";
            this.NhaCungCapGridColumn.Name = "NhaCungCapGridColumn";
            this.NhaCungCapGridColumn.OptionsColumn.AllowEdit = false;
            this.NhaCungCapGridColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NhaCungCapGridColumn.Visible = true;
            this.NhaCungCapGridColumn.VisibleIndex = 2;
            this.NhaCungCapGridColumn.Width = 200;
            // 
            // TrangThaiDonHangColumn
            // 
            this.TrangThaiDonHangColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangThaiDonHangColumn.AppearanceCell.Options.UseFont = true;
            this.TrangThaiDonHangColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangThaiDonHangColumn.AppearanceHeader.Options.UseFont = true;
            this.TrangThaiDonHangColumn.Caption = "Trạng Thái Đơn Hàng";
            this.TrangThaiDonHangColumn.FieldName = "TrangThaiDonHang";
            this.TrangThaiDonHangColumn.Name = "TrangThaiDonHangColumn";
            this.TrangThaiDonHangColumn.OptionsColumn.AllowEdit = false;
            this.TrangThaiDonHangColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TrangThaiDonHangColumn.Visible = true;
            this.TrangThaiDonHangColumn.VisibleIndex = 3;
            this.TrangThaiDonHangColumn.Width = 200;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(829, 201);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.DonHangGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(809, 181);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Location = new System.Drawing.Point(12, 200);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(120, 26);
            this.CancelButtonControl.TabIndex = 1;
            this.CancelButtonControl.Text = "Thoát";
            this.CancelButtonControl.Click += new System.EventHandler(this.CancelButtonControl_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Appearance.Options.UseFont = true;
            this.DeleteButton.Location = new System.Drawing.Point(138, 200);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 26);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Hủy Đơn Hàng";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Appearance.Options.UseFont = true;
            this.OKButton.Location = new System.Drawing.Point(697, 200);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 26);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Appearance.Options.UseFont = true;
            this.EditButton.Location = new System.Drawing.Point(561, 200);
            this.EditButton.MinimumSize = new System.Drawing.Size(130, 0);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(130, 26);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Xem Chi Tiết";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Appearance.Options.UseFont = true;
            this.AddButton.Location = new System.Drawing.Point(435, 200);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 26);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DonHangListForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 234);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DonHangListForm";
            this.Text = "ĐƠN HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DonHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonHangGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl DonHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView DonHangGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl DeleteButton;
        private Common.Controls.QButtonControl OKButton;
        private Common.Controls.QButtonControl EditButton;
        private Common.Controls.QButtonControl AddButton;
        private DevExpress.XtraGrid.Columns.GridColumn MaDonHangGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiLapDonHangGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NhaCungCapGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThaiDonHangColumn;
    }
}