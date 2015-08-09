using Common.Forms;

namespace QuanLySieuThi.Kho
{
    partial class NhapKhoEditForm: QuanLySieuThiForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.DeleteButton = new Common.Controls.QButtonControl();
            this.EditButton = new Common.Controls.QButtonControl();
            this.AddButton = new Common.Controls.QButtonControl();
            this.CTNhapKhoGridControl = new DevExpress.XtraGrid.GridControl();
            this.CTNhapKhoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenHangHoaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongNummeric = new Common.Controls.QNummericControl();
            this.HangHoaLookupEdit = new Common.Controls.QLookupEditControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.KhoLookupEdit = new Common.Controls.QLookupEditControl();
            this.SearchDonHangButton = new Common.Controls.QButtonControl();
            this.MaDonHangTextBox = new Common.Controls.QTextBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.OKButton = new Common.Controls.QButtonControl();
            this.SoLuongDatHangNummeric = new Common.Controls.QNummericControl();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.SoLuongDaNhanNummeric = new Common.Controls.QNummericControl();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTNhapKhoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTNhapKhoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongNummeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaLookupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoLookupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaDonHangTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongDatHangNummeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongDaNhanNummeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Controls.Add(this.KhoLookupEdit);
            this.layoutControl1.Controls.Add(this.SearchDonHangButton);
            this.layoutControl1.Controls.Add(this.MaDonHangTextBox);
            this.layoutControl1.Location = new System.Drawing.Point(0, -1);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(766, 373);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.layoutControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 68);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(742, 293);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Chi Tiết Nhập Kho";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.SoLuongDaNhanNummeric);
            this.layoutControl2.Controls.Add(this.SoLuongDatHangNummeric);
            this.layoutControl2.Controls.Add(this.DeleteButton);
            this.layoutControl2.Controls.Add(this.EditButton);
            this.layoutControl2.Controls.Add(this.AddButton);
            this.layoutControl2.Controls.Add(this.CTNhapKhoGridControl);
            this.layoutControl2.Controls.Add(this.SoLuongNummeric);
            this.layoutControl2.Controls.Add(this.HangHoaLookupEdit);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 25);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(738, 266);
            this.layoutControl2.TabIndex = 2;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.DeleteButton.Appearance.Options.UseFont = true;
            this.DeleteButton.Location = new System.Drawing.Point(606, 230);
            this.DeleteButton.MaximumSize = new System.Drawing.Size(120, 0);
            this.DeleteButton.MinimumSize = new System.Drawing.Size(120, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 24);
            this.DeleteButton.StyleController = this.layoutControl2;
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Xóa";
            // 
            // EditButton
            // 
            this.EditButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.EditButton.Appearance.Options.UseFont = true;
            this.EditButton.Location = new System.Drawing.Point(472, 230);
            this.EditButton.MaximumSize = new System.Drawing.Size(120, 0);
            this.EditButton.MinimumSize = new System.Drawing.Size(120, 0);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(120, 24);
            this.EditButton.StyleController = this.layoutControl2;
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Sửa";
            // 
            // AddButton
            // 
            this.AddButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.AddButton.Appearance.Options.UseFont = true;
            this.AddButton.Location = new System.Drawing.Point(338, 230);
            this.AddButton.MaximumSize = new System.Drawing.Size(120, 0);
            this.AddButton.MinimumSize = new System.Drawing.Size(120, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 24);
            this.AddButton.StyleController = this.layoutControl2;
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Thêm";
            // 
            // CTNhapKhoGridControl
            // 
            this.CTNhapKhoGridControl.Location = new System.Drawing.Point(12, 124);
            this.CTNhapKhoGridControl.MainView = this.CTNhapKhoGridView;
            this.CTNhapKhoGridControl.Name = "CTNhapKhoGridControl";
            this.CTNhapKhoGridControl.Size = new System.Drawing.Size(714, 102);
            this.CTNhapKhoGridControl.TabIndex = 6;
            this.CTNhapKhoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CTNhapKhoGridView});
            // 
            // CTNhapKhoGridView
            // 
            this.CTNhapKhoGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTNhapKhoGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.CTNhapKhoGridView.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTNhapKhoGridView.Appearance.Row.Options.UseFont = true;
            this.CTNhapKhoGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenHangHoaColumn,
            this.SoLuongGridColumn});
            this.CTNhapKhoGridView.GridControl = this.CTNhapKhoGridControl;
            this.CTNhapKhoGridView.Name = "CTNhapKhoGridView";
            this.CTNhapKhoGridView.OptionsBehavior.Editable = false;
            this.CTNhapKhoGridView.OptionsView.ColumnAutoWidth = false;
            this.CTNhapKhoGridView.OptionsView.ShowAutoFilterRow = true;
            this.CTNhapKhoGridView.OptionsView.ShowGroupPanel = false;
            this.CTNhapKhoGridView.OptionsView.ShowIndicator = false;
            // 
            // TenHangHoaColumn
            // 
            this.TenHangHoaColumn.Caption = "Tên Hàng Hóa";
            this.TenHangHoaColumn.Name = "TenHangHoaColumn";
            this.TenHangHoaColumn.OptionsColumn.AllowEdit = false;
            this.TenHangHoaColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenHangHoaColumn.Visible = true;
            this.TenHangHoaColumn.VisibleIndex = 0;
            // 
            // SoLuongGridColumn
            // 
            this.SoLuongGridColumn.Caption = "Số Lượng";
            this.SoLuongGridColumn.Name = "SoLuongGridColumn";
            this.SoLuongGridColumn.OptionsColumn.AllowEdit = false;
            this.SoLuongGridColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SoLuongGridColumn.Visible = true;
            this.SoLuongGridColumn.VisibleIndex = 1;
            // 
            // SoLuongNummeric
            // 
            this.SoLuongNummeric.Location = new System.Drawing.Point(138, 96);
            this.SoLuongNummeric.Name = "SoLuongNummeric";
            this.SoLuongNummeric.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SoLuongNummeric.Properties.Appearance.Options.UseFont = true;
            this.SoLuongNummeric.Size = new System.Drawing.Size(588, 24);
            this.SoLuongNummeric.StyleController = this.layoutControl2;
            this.SoLuongNummeric.TabIndex = 5;
            // 
            // HangHoaLookupEdit
            // 
            this.HangHoaLookupEdit.Location = new System.Drawing.Point(138, 12);
            this.HangHoaLookupEdit.Name = "HangHoaLookupEdit";
            this.HangHoaLookupEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.HangHoaLookupEdit.Properties.Appearance.Options.UseFont = true;
            this.HangHoaLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.HangHoaLookupEdit.Size = new System.Drawing.Size(588, 24);
            this.HangHoaLookupEdit.StyleController = this.layoutControl2;
            this.HangHoaLookupEdit.TabIndex = 4;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem11,
            this.layoutControlItem12});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(738, 266);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.HangHoaLookupEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(718, 28);
            this.layoutControlItem5.Text = "Hàng Hóa";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(123, 17);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.SoLuongNummeric;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(718, 28);
            this.layoutControlItem6.Text = "Số Lượng Nhập Kho";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(123, 17);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.CTNhapKhoGridControl;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(718, 106);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.AddButton;
            this.layoutControlItem8.Location = new System.Drawing.Point(326, 218);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(124, 28);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(124, 28);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(124, 28);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.EditButton;
            this.layoutControlItem9.Location = new System.Drawing.Point(460, 218);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(124, 28);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(124, 28);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(124, 28);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.DeleteButton;
            this.layoutControlItem10.Location = new System.Drawing.Point(594, 218);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(124, 28);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(124, 28);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(124, 28);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(450, 218);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(10, 0);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 28);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(584, 218);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(10, 0);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 28);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 218);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(326, 28);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // KhoLookupEdit
            // 
            this.KhoLookupEdit.Location = new System.Drawing.Point(101, 40);
            this.KhoLookupEdit.Name = "KhoLookupEdit";
            this.KhoLookupEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.KhoLookupEdit.Properties.Appearance.Options.UseFont = true;
            this.KhoLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.KhoLookupEdit.Size = new System.Drawing.Size(653, 24);
            this.KhoLookupEdit.StyleController = this.layoutControl1;
            this.KhoLookupEdit.TabIndex = 3;
            // 
            // SearchDonHangButton
            // 
            this.SearchDonHangButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SearchDonHangButton.Appearance.Options.UseFont = true;
            this.SearchDonHangButton.Location = new System.Drawing.Point(626, 12);
            this.SearchDonHangButton.Name = "SearchDonHangButton";
            this.SearchDonHangButton.Size = new System.Drawing.Size(128, 24);
            this.SearchDonHangButton.StyleController = this.layoutControl1;
            this.SearchDonHangButton.TabIndex = 2;
            this.SearchDonHangButton.Text = "Tìm Đơn Hàng";
            this.SearchDonHangButton.Click += new System.EventHandler(this.SearchDonHangButton_Click);
            // 
            // MaDonHangTextBox
            // 
            this.MaDonHangTextBox.Location = new System.Drawing.Point(101, 12);
            this.MaDonHangTextBox.Name = "MaDonHangTextBox";
            this.MaDonHangTextBox.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.MaDonHangTextBox.Properties.Appearance.Options.UseFont = true;
            this.MaDonHangTextBox.Size = new System.Drawing.Size(521, 24);
            this.MaDonHangTextBox.StyleController = this.layoutControl1;
            this.MaDonHangTextBox.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(766, 373);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.MaDonHangTextBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(614, 28);
            this.layoutControlItem1.Text = "Mã Đơn Hàng";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(86, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.SearchDonHangButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(614, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(132, 28);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(132, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(132, 28);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.KhoLookupEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(746, 28);
            this.layoutControlItem3.Text = "Kho";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(86, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.groupControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(746, 297);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Location = new System.Drawing.Point(14, 366);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(120, 30);
            this.CancelButtonControl.TabIndex = 1;
            this.CancelButtonControl.Text = "Thoát";
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.OKButton.Appearance.Options.UseFont = true;
            this.OKButton.Location = new System.Drawing.Point(634, 366);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            // 
            // SoLuongDatHangNummeric
            // 
            this.SoLuongDatHangNummeric.Location = new System.Drawing.Point(138, 40);
            this.SoLuongDatHangNummeric.Name = "SoLuongDatHangNummeric";
            this.SoLuongDatHangNummeric.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SoLuongDatHangNummeric.Properties.Appearance.Options.UseFont = true;
            this.SoLuongDatHangNummeric.Size = new System.Drawing.Size(588, 24);
            this.SoLuongDatHangNummeric.StyleController = this.layoutControl2;
            this.SoLuongDatHangNummeric.TabIndex = 10;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem11.Control = this.SoLuongDatHangNummeric;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(718, 28);
            this.layoutControlItem11.Text = "Số Lượng Đặt Hàng";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(123, 17);
            // 
            // SoLuongDaNhanNummeric
            // 
            this.SoLuongDaNhanNummeric.Location = new System.Drawing.Point(138, 68);
            this.SoLuongDaNhanNummeric.Name = "SoLuongDaNhanNummeric";
            this.SoLuongDaNhanNummeric.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SoLuongDaNhanNummeric.Properties.Appearance.Options.UseFont = true;
            this.SoLuongDaNhanNummeric.Size = new System.Drawing.Size(588, 24);
            this.SoLuongDaNhanNummeric.StyleController = this.layoutControl2;
            this.SoLuongDaNhanNummeric.TabIndex = 11;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem12.Control = this.SoLuongDaNhanNummeric;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(718, 28);
            this.layoutControlItem12.Text = "Số Lượng Đã Nhận";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(123, 17);
            // 
            // NhapKhoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 408);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.Name = "NhapKhoEditForm";
            this.Text = "NhapKhoEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CTNhapKhoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTNhapKhoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongNummeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaLookupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoLookupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaDonHangTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongDatHangNummeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongDaNhanNummeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl CTNhapKhoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView CTNhapKhoGridView;
        private Common.Controls.QNummericControl SoLuongNummeric;
        private Common.Controls.QLookupEditControl HangHoaLookupEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private Common.Controls.QLookupEditControl KhoLookupEdit;
        private Common.Controls.QButtonControl SearchDonHangButton;
        private Common.Controls.QTextBoxControl MaDonHangTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Common.Controls.QButtonControl DeleteButton;
        private Common.Controls.QButtonControl EditButton;
        private Common.Controls.QButtonControl AddButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl OKButton;
        private DevExpress.XtraGrid.Columns.GridColumn TenHangHoaColumn;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongGridColumn;
        private Common.Controls.QNummericControl SoLuongDaNhanNummeric;
        private Common.Controls.QNummericControl SoLuongDatHangNummeric;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
    }
}