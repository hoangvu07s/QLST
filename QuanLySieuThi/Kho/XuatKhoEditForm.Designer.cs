using Common.Forms;

namespace QuanLySieuThi.Kho
{
    partial class XuatKhoEditForm: QuanLySieuThiForm
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
            this.CTXuatKhoGridControl = new DevExpress.XtraGrid.GridControl();
            this.CTXuatKhoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HangHoaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongXuatKhoNummeric = new Common.Controls.QNummericControl();
            this.SoLuongTonKhoNummeric = new Common.Controls.QNummericControl();
            this.HangHoaLookupEdit = new Common.Controls.QLookupEditControl();
            this.KhoHangLookupEdit = new Common.Controls.QLookupEditControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.DeleteButton = new Common.Controls.QButtonControl();
            this.AddButton = new Common.Controls.QButtonControl();
            this.EditButton = new Common.Controls.QButtonControl();
            this.OKButton = new Common.Controls.QButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTXuatKhoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTXuatKhoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongXuatKhoNummeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongTonKhoNummeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaLookupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoHangLookupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.CTXuatKhoGridControl);
            this.layoutControl1.Controls.Add(this.SoLuongXuatKhoNummeric);
            this.layoutControl1.Controls.Add(this.SoLuongTonKhoNummeric);
            this.layoutControl1.Controls.Add(this.HangHoaLookupEdit);
            this.layoutControl1.Controls.Add(this.KhoHangLookupEdit);
            this.layoutControl1.Location = new System.Drawing.Point(-1, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(766, 368);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CTXuatKhoGridControl
            // 
            this.CTXuatKhoGridControl.Location = new System.Drawing.Point(12, 124);
            this.CTXuatKhoGridControl.MainView = this.CTXuatKhoGridView;
            this.CTXuatKhoGridControl.Name = "CTXuatKhoGridControl";
            this.CTXuatKhoGridControl.Size = new System.Drawing.Size(742, 232);
            this.CTXuatKhoGridControl.TabIndex = 8;
            this.CTXuatKhoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CTXuatKhoGridView});
            // 
            // CTXuatKhoGridView
            // 
            this.CTXuatKhoGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTXuatKhoGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.CTXuatKhoGridView.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTXuatKhoGridView.Appearance.Row.Options.UseFont = true;
            this.CTXuatKhoGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HangHoaColumn,
            this.SoLuongColumn});
            this.CTXuatKhoGridView.GridControl = this.CTXuatKhoGridControl;
            this.CTXuatKhoGridView.Name = "CTXuatKhoGridView";
            this.CTXuatKhoGridView.OptionsBehavior.Editable = false;
            this.CTXuatKhoGridView.OptionsView.ColumnAutoWidth = false;
            this.CTXuatKhoGridView.OptionsView.ShowAutoFilterRow = true;
            this.CTXuatKhoGridView.OptionsView.ShowGroupPanel = false;
            this.CTXuatKhoGridView.OptionsView.ShowIndicator = false;
            this.CTXuatKhoGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.CTXuatKhoGridView_FocusedRowChanged);
            // 
            // HangHoaColumn
            // 
            this.HangHoaColumn.Caption = "Hàng Hóa";
            this.HangHoaColumn.FieldName = "TenHangHoa";
            this.HangHoaColumn.Name = "HangHoaColumn";
            this.HangHoaColumn.OptionsColumn.AllowEdit = false;
            this.HangHoaColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.HangHoaColumn.Visible = true;
            this.HangHoaColumn.VisibleIndex = 0;
            // 
            // SoLuongColumn
            // 
            this.SoLuongColumn.Caption = "Số Lượng";
            this.SoLuongColumn.FieldName = "SoLuong";
            this.SoLuongColumn.Name = "SoLuongColumn";
            this.SoLuongColumn.OptionsColumn.AllowEdit = false;
            this.SoLuongColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SoLuongColumn.Visible = true;
            this.SoLuongColumn.VisibleIndex = 1;
            // 
            // SoLuongXuatKhoNummeric
            // 
            this.SoLuongXuatKhoNummeric.Location = new System.Drawing.Point(134, 96);
            this.SoLuongXuatKhoNummeric.Name = "SoLuongXuatKhoNummeric";
            this.SoLuongXuatKhoNummeric.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SoLuongXuatKhoNummeric.Properties.Appearance.Options.UseFont = true;
            this.SoLuongXuatKhoNummeric.Properties.DisplayFormat.FormatString = "d";
            this.SoLuongXuatKhoNummeric.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuongXuatKhoNummeric.Properties.Mask.EditMask = "d";
            this.SoLuongXuatKhoNummeric.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.SoLuongXuatKhoNummeric.Properties.NullText = "0";
            this.SoLuongXuatKhoNummeric.Size = new System.Drawing.Size(620, 24);
            this.SoLuongXuatKhoNummeric.StyleController = this.layoutControl1;
            this.SoLuongXuatKhoNummeric.TabIndex = 7;
            // 
            // SoLuongTonKhoNummeric
            // 
            this.SoLuongTonKhoNummeric.Location = new System.Drawing.Point(134, 68);
            this.SoLuongTonKhoNummeric.Name = "SoLuongTonKhoNummeric";
            this.SoLuongTonKhoNummeric.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SoLuongTonKhoNummeric.Properties.Appearance.Options.UseFont = true;
            this.SoLuongTonKhoNummeric.Properties.DisplayFormat.FormatString = "d";
            this.SoLuongTonKhoNummeric.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuongTonKhoNummeric.Properties.Mask.EditMask = "d";
            this.SoLuongTonKhoNummeric.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.SoLuongTonKhoNummeric.Properties.NullText = "0";
            this.SoLuongTonKhoNummeric.Properties.ReadOnly = true;
            this.SoLuongTonKhoNummeric.Size = new System.Drawing.Size(620, 24);
            this.SoLuongTonKhoNummeric.StyleController = this.layoutControl1;
            this.SoLuongTonKhoNummeric.TabIndex = 6;
            // 
            // HangHoaLookupEdit
            // 
            this.HangHoaLookupEdit.Location = new System.Drawing.Point(134, 40);
            this.HangHoaLookupEdit.Name = "HangHoaLookupEdit";
            this.HangHoaLookupEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.HangHoaLookupEdit.Properties.Appearance.Options.UseFont = true;
            this.HangHoaLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.HangHoaLookupEdit.Properties.NullText = "";
            this.HangHoaLookupEdit.Size = new System.Drawing.Size(620, 24);
            this.HangHoaLookupEdit.StyleController = this.layoutControl1;
            this.HangHoaLookupEdit.TabIndex = 5;
            this.HangHoaLookupEdit.EditValueChanged += new System.EventHandler(this.HangHoaLookupEdit_EditValueChanged);
            // 
            // KhoHangLookupEdit
            // 
            this.KhoHangLookupEdit.Location = new System.Drawing.Point(134, 12);
            this.KhoHangLookupEdit.Name = "KhoHangLookupEdit";
            this.KhoHangLookupEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.KhoHangLookupEdit.Properties.Appearance.Options.UseFont = true;
            this.KhoHangLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.KhoHangLookupEdit.Properties.NullText = "";
            this.KhoHangLookupEdit.Size = new System.Drawing.Size(620, 24);
            this.KhoHangLookupEdit.StyleController = this.layoutControl1;
            this.KhoHangLookupEdit.TabIndex = 4;
            this.KhoHangLookupEdit.EditValueChanged += new System.EventHandler(this.KhoHangLookupEdit_EditValueChanged);
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
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(766, 368);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.KhoHangLookupEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(746, 28);
            this.layoutControlItem1.Text = "Kho Hàng";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(119, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.HangHoaLookupEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(746, 28);
            this.layoutControlItem2.Text = "Hàng Hóa";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(119, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.SoLuongTonKhoNummeric;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(746, 28);
            this.layoutControlItem3.Text = "Số Lượng Tồn Kho";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(119, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.SoLuongXuatKhoNummeric;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(746, 28);
            this.layoutControlItem4.Text = "Số Lượng Xuất Kho";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(119, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.CTXuatKhoGridControl;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(746, 236);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Location = new System.Drawing.Point(11, 366);
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
            this.DeleteButton.Location = new System.Drawing.Point(137, 366);
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
            this.AddButton.Location = new System.Drawing.Point(382, 366);
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
            this.EditButton.Location = new System.Drawing.Point(508, 366);
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
            this.OKButton.Location = new System.Drawing.Point(634, 366);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // XuatKhoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 408);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.Name = "XuatKhoEditForm";
            this.Text = "XuatKhoEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CTXuatKhoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTXuatKhoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongXuatKhoNummeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongTonKhoNummeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaLookupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoHangLookupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Common.Controls.QLookupEditControl KhoHangLookupEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Common.Controls.QLookupEditControl HangHoaLookupEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private Common.Controls.QNummericControl SoLuongXuatKhoNummeric;
        private Common.Controls.QNummericControl SoLuongTonKhoNummeric;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl CTXuatKhoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView CTXuatKhoGridView;
        private DevExpress.XtraGrid.Columns.GridColumn HangHoaColumn;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongColumn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl DeleteButton;
        private Common.Controls.QButtonControl AddButton;
        private Common.Controls.QButtonControl EditButton;
        private Common.Controls.QButtonControl OKButton;
    }
}