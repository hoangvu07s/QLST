using Common.Forms;

namespace QuanLySieuThi.NhaCungCap
{
    partial class NhaCungCapListForm : QuanLySieuThiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaCungCapListForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.NhaCungCapGridControl = new DevExpress.XtraGrid.GridControl();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenNhaCungCapColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenCongTyColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDienThoaiColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmailColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.DeleteButton = new Common.Controls.QButtonControl();
            this.OKButton = new Common.Controls.QButtonControl();
            this.EditButton = new Common.Controls.QButtonControl();
            this.AddButton = new Common.Controls.QButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhaCungCapGridControl)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.NhaCungCapGridControl);
            this.layoutControl1.Location = new System.Drawing.Point(-1, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(722, 254);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // NhaCungCapGridControl
            // 
            this.NhaCungCapGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.NhaCungCapGridControl.Location = new System.Drawing.Point(12, 12);
            this.NhaCungCapGridControl.MainView = this.GridView1;
            this.NhaCungCapGridControl.Name = "NhaCungCapGridControl";
            this.NhaCungCapGridControl.Size = new System.Drawing.Size(698, 230);
            this.NhaCungCapGridControl.TabIndex = 4;
            this.NhaCungCapGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView1});
            // 
            // GridView1
            // 
            this.GridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView1.Appearance.Row.Options.UseFont = true;
            this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenNhaCungCapColumn,
            this.TenCongTyColumn,
            this.DiaChiColumn,
            this.SoDienThoaiColumn,
            this.EmailColumn});
            this.GridView1.GridControl = this.NhaCungCapGridControl;
            this.GridView1.Name = "GridView1";
            this.GridView1.OptionsBehavior.Editable = false;
            this.GridView1.OptionsView.ColumnAutoWidth = false;
            this.GridView1.OptionsView.ShowAutoFilterRow = true;
            this.GridView1.OptionsView.ShowGroupPanel = false;
            this.GridView1.OptionsView.ShowIndicator = false;
            this.GridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridView1_FocusedRowChanged);
            this.GridView1.DoubleClick += new System.EventHandler(this.GridView1_DoubleClick);
            // 
            // TenNhaCungCapColumn
            // 
            this.TenNhaCungCapColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhaCungCapColumn.AppearanceCell.Options.UseFont = true;
            this.TenNhaCungCapColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhaCungCapColumn.AppearanceHeader.Options.UseFont = true;
            this.TenNhaCungCapColumn.Caption = "Tên Nhà Cung Cấp";
            this.TenNhaCungCapColumn.FieldName = "TenNhaCungCap";
            this.TenNhaCungCapColumn.Name = "TenNhaCungCapColumn";
            this.TenNhaCungCapColumn.OptionsColumn.AllowEdit = false;
            this.TenNhaCungCapColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.TenNhaCungCapColumn.Visible = true;
            this.TenNhaCungCapColumn.VisibleIndex = 0;
            this.TenNhaCungCapColumn.Width = 150;
            // 
            // TenCongTyColumn
            // 
            this.TenCongTyColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenCongTyColumn.AppearanceCell.Options.UseFont = true;
            this.TenCongTyColumn.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenCongTyColumn.AppearanceHeader.Options.UseFont = true;
            this.TenCongTyColumn.Caption = "Tên Công Ty";
            this.TenCongTyColumn.FieldName = "TenCongTy";
            this.TenCongTyColumn.Name = "TenCongTyColumn";
            this.TenCongTyColumn.OptionsColumn.AllowEdit = false;
            this.TenCongTyColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenCongTyColumn.Visible = true;
            this.TenCongTyColumn.VisibleIndex = 1;
            this.TenCongTyColumn.Width = 150;
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
            this.DiaChiColumn.VisibleIndex = 2;
            this.DiaChiColumn.Width = 150;
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
            this.SoDienThoaiColumn.VisibleIndex = 3;
            this.SoDienThoaiColumn.Width = 150;
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
            this.EmailColumn.VisibleIndex = 4;
            this.EmailColumn.Width = 150;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(722, 254);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.NhaCungCapGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(702, 234);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Image = global::QuanLySieuThi.Properties.Resources.Actions_exit_icon__1_;
            this.CancelButtonControl.Location = new System.Drawing.Point(12, 249);
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
            this.DeleteButton.Location = new System.Drawing.Point(138, 249);
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
            this.OKButton.Location = new System.Drawing.Point(589, 249);
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
            this.EditButton.Location = new System.Drawing.Point(463, 249);
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
            this.AddButton.Location = new System.Drawing.Point(337, 249);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 30);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NhaCungCapListForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 284);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhaCungCapListForm";
            this.Text = "NHÀ CUNG CẤP";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NhaCungCapGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl NhaCungCapGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhaCungCapColumn;
        private DevExpress.XtraGrid.Columns.GridColumn TenCongTyColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiColumn;
        private DevExpress.XtraGrid.Columns.GridColumn SoDienThoaiColumn;
        private DevExpress.XtraGrid.Columns.GridColumn EmailColumn;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl DeleteButton;
        private Common.Controls.QButtonControl OKButton;
        private Common.Controls.QButtonControl EditButton;
        private Common.Controls.QButtonControl AddButton;
    }
}