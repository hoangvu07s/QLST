using Common.Forms;

namespace QuanLySieuThi.HangHoa
{
    partial class QuayHangListForm: QuanLySieuThiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuayHangListForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.QuayHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenQuayHangColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.DeleteButton = new Common.Controls.QButtonControl();
            this.OKButton = new Common.Controls.QButtonControl();
            this.EditButton = new Common.Controls.QButtonControl();
            this.AddButton = new Common.Controls.QButtonControl();
            this.NguoiTaoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTaoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiChinhSuaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayChinhSuaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuayHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.QuayHangGridControl);
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(716, 211);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // QuayHangGridControl
            // 
            this.QuayHangGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.QuayHangGridControl.Location = new System.Drawing.Point(12, 12);
            this.QuayHangGridControl.MainView = this.GridView1;
            this.QuayHangGridControl.Name = "QuayHangGridControl";
            this.QuayHangGridControl.Size = new System.Drawing.Size(692, 187);
            this.QuayHangGridControl.TabIndex = 4;
            this.QuayHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView1});
            // 
            // GridView1
            // 
            this.GridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView1.Appearance.Row.Options.UseFont = true;
            this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenQuayHangColumn,
            this.NguoiTaoColumn,
            this.NgayTaoColumn,
            this.NguoiChinhSuaColumn,
            this.NgayChinhSuaColumn});
            this.GridView1.GridControl = this.QuayHangGridControl;
            this.GridView1.Name = "GridView1";
            this.GridView1.OptionsBehavior.Editable = false;
            this.GridView1.OptionsView.ColumnAutoWidth = false;
            this.GridView1.OptionsView.ShowAutoFilterRow = true;
            this.GridView1.OptionsView.ShowGroupPanel = false;
            this.GridView1.OptionsView.ShowIndicator = false;
            this.GridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridView1_FocusedRowChanged);
            this.GridView1.DoubleClick += new System.EventHandler(this.GridView1_DoubleClick);
            // 
            // TenQuayHangColumn
            // 
            this.TenQuayHangColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenQuayHangColumn.AppearanceCell.Options.UseFont = true;
            this.TenQuayHangColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenQuayHangColumn.AppearanceHeader.Options.UseFont = true;
            this.TenQuayHangColumn.Caption = "Tên Quầy Hàng";
            this.TenQuayHangColumn.FieldName = "TenQuay";
            this.TenQuayHangColumn.Name = "TenQuayHangColumn";
            this.TenQuayHangColumn.OptionsColumn.AllowEdit = false;
            this.TenQuayHangColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenQuayHangColumn.Visible = true;
            this.TenQuayHangColumn.VisibleIndex = 0;
            this.TenQuayHangColumn.Width = 150;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(716, 211);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.QuayHangGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(696, 191);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Image = global::QuanLySieuThi.Properties.Resources.Actions_exit_icon__1_;
            this.CancelButtonControl.Location = new System.Drawing.Point(12, 208);
            this.CancelButtonControl.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(130, 30);
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
            this.DeleteButton.Location = new System.Drawing.Point(150, 208);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.OKButton.Location = new System.Drawing.Point(584, 208);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.EditButton.Location = new System.Drawing.Point(456, 208);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.AddButton.Location = new System.Drawing.Point(328, 208);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 30);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NguoiTaoColumn
            // 
            this.NguoiTaoColumn.Caption = "Người Tạo";
            this.NguoiTaoColumn.FieldName = "NhanVien1.TenDangNhap";
            this.NguoiTaoColumn.Name = "NguoiTaoColumn";
            this.NguoiTaoColumn.OptionsColumn.AllowEdit = false;
            this.NguoiTaoColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NguoiTaoColumn.Visible = true;
            this.NguoiTaoColumn.VisibleIndex = 1;
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
            this.NgayTaoColumn.VisibleIndex = 2;
            this.NgayTaoColumn.Width = 150;
            // 
            // NguoiChinhSuaColumn
            // 
            this.NguoiChinhSuaColumn.Caption = "Người Chỉnh Sửa";
            this.NguoiChinhSuaColumn.FieldName = "NhanVien.TenDangNhap";
            this.NguoiChinhSuaColumn.Name = "NguoiChinhSuaColumn";
            this.NguoiChinhSuaColumn.OptionsColumn.AllowEdit = false;
            this.NguoiChinhSuaColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NguoiChinhSuaColumn.Visible = true;
            this.NguoiChinhSuaColumn.VisibleIndex = 3;
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
            this.NgayChinhSuaColumn.VisibleIndex = 4;
            this.NgayChinhSuaColumn.Width = 150;
            // 
            // QuayHangListForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 251);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "QuayHangListForm";
            this.Text = "QUẦY HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuayHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl QuayHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn TenQuayHangColumn;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl DeleteButton;
        private Common.Controls.QButtonControl OKButton;
        private Common.Controls.QButtonControl EditButton;
        private Common.Controls.QButtonControl AddButton;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiTaoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTaoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiChinhSuaColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NgayChinhSuaColumn;

    }
}