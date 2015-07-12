using Common.Forms;

namespace QuanLySieuThi.HangHoa
{
    partial class ChiTietDonHangEditForm :QuanLySieuThiForm
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.MaDonHangTextBox = new Common.Controls.QTextBoxControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.TenHangHoaTextBox = new Common.Controls.QTextBoxControl();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LoaiHangHoaLookupEdit = new Common.Controls.QLookupEditControl();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.NhaCungCapLookupEdit = new Common.Controls.QLookupEditControl();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.QuayHangLookupEdit = new Common.Controls.QLookupEditControl();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.SoLuongNummeric = new Common.Controls.QNummericControl();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.DonGiaNummeric = new Common.Controls.QNummericControl();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ChiTietDonHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.ChiTietDonHangGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.TenHangHoaGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiHangHoaGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhaCungCapGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuayHangGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.DeleteButton = new Common.Controls.QButtonControl();
            this.OKButton = new Common.Controls.QButtonControl();
            this.EditButton = new Common.Controls.QButtonControl();
            this.AddButton = new Common.Controls.QButtonControl();
            this.SearchTenHangHoaButton = new Common.Controls.QButtonControl();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaDonHangTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenHangHoaTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiHangHoaLookupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhaCungCapLookupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuayHangLookupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongNummeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonGiaNummeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietDonHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietDonHangGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.SearchTenHangHoaButton);
            this.layoutControl1.Controls.Add(this.ChiTietDonHangGridControl);
            this.layoutControl1.Controls.Add(this.DonGiaNummeric);
            this.layoutControl1.Controls.Add(this.SoLuongNummeric);
            this.layoutControl1.Controls.Add(this.QuayHangLookupEdit);
            this.layoutControl1.Controls.Add(this.NhaCungCapLookupEdit);
            this.layoutControl1.Controls.Add(this.LoaiHangHoaLookupEdit);
            this.layoutControl1.Controls.Add(this.TenHangHoaTextBox);
            this.layoutControl1.Controls.Add(this.MaDonHangTextBox);
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(863, 412);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
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
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(863, 412);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // MaDonHangTextBox
            // 
            this.MaDonHangTextBox.Location = new System.Drawing.Point(533, 12);
            this.MaDonHangTextBox.Name = "MaDonHangTextBox";
            this.MaDonHangTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MaDonHangTextBox.Properties.Appearance.Options.UseFont = true;
            this.MaDonHangTextBox.Size = new System.Drawing.Size(318, 26);
            this.MaDonHangTextBox.StyleController = this.layoutControl1;
            this.MaDonHangTextBox.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.MaDonHangTextBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(421, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(422, 30);
            this.layoutControlItem1.Text = "Ma Don Hang";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(96, 20);
            // 
            // TenHangHoaTextBox
            // 
            this.TenHangHoaTextBox.Location = new System.Drawing.Point(112, 42);
            this.TenHangHoaTextBox.Name = "TenHangHoaTextBox";
            this.TenHangHoaTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TenHangHoaTextBox.Properties.Appearance.Options.UseFont = true;
            this.TenHangHoaTextBox.Size = new System.Drawing.Size(317, 26);
            this.TenHangHoaTextBox.StyleController = this.layoutControl1;
            this.TenHangHoaTextBox.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.TenHangHoaTextBox;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(421, 31);
            this.layoutControlItem2.Text = "Ten Hang Hoa";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(96, 20);
            // 
            // LoaiHangHoaLookupEdit
            // 
            this.LoaiHangHoaLookupEdit.Location = new System.Drawing.Point(112, 73);
            this.LoaiHangHoaLookupEdit.Name = "LoaiHangHoaLookupEdit";
            this.LoaiHangHoaLookupEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LoaiHangHoaLookupEdit.Properties.Appearance.Options.UseFont = true;
            this.LoaiHangHoaLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LoaiHangHoaLookupEdit.Size = new System.Drawing.Size(739, 26);
            this.LoaiHangHoaLookupEdit.StyleController = this.layoutControl1;
            this.LoaiHangHoaLookupEdit.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.LoaiHangHoaLookupEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 61);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(843, 30);
            this.layoutControlItem3.Text = "Loai Hang";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(96, 20);
            // 
            // NhaCungCapLookupEdit
            // 
            this.NhaCungCapLookupEdit.Location = new System.Drawing.Point(112, 103);
            this.NhaCungCapLookupEdit.Name = "NhaCungCapLookupEdit";
            this.NhaCungCapLookupEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.NhaCungCapLookupEdit.Properties.Appearance.Options.UseFont = true;
            this.NhaCungCapLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NhaCungCapLookupEdit.Size = new System.Drawing.Size(739, 26);
            this.NhaCungCapLookupEdit.StyleController = this.layoutControl1;
            this.NhaCungCapLookupEdit.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.NhaCungCapLookupEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 91);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(843, 30);
            this.layoutControlItem4.Text = "Nha Cung Cap";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(96, 20);
            // 
            // QuayHangLookupEdit
            // 
            this.QuayHangLookupEdit.Location = new System.Drawing.Point(112, 133);
            this.QuayHangLookupEdit.Name = "QuayHangLookupEdit";
            this.QuayHangLookupEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.QuayHangLookupEdit.Properties.Appearance.Options.UseFont = true;
            this.QuayHangLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.QuayHangLookupEdit.Size = new System.Drawing.Size(739, 26);
            this.QuayHangLookupEdit.StyleController = this.layoutControl1;
            this.QuayHangLookupEdit.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.QuayHangLookupEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 121);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(843, 30);
            this.layoutControlItem5.Text = "Quay Hang";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(96, 20);
            // 
            // SoLuongNummeric
            // 
            this.SoLuongNummeric.Location = new System.Drawing.Point(112, 163);
            this.SoLuongNummeric.Name = "SoLuongNummeric";
            this.SoLuongNummeric.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.SoLuongNummeric.Properties.Appearance.Options.UseFont = true;
            this.SoLuongNummeric.Size = new System.Drawing.Size(739, 26);
            this.SoLuongNummeric.StyleController = this.layoutControl1;
            this.SoLuongNummeric.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.SoLuongNummeric;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 151);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(843, 30);
            this.layoutControlItem6.Text = "So Luong";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(96, 20);
            // 
            // DonGiaNummeric
            // 
            this.DonGiaNummeric.Location = new System.Drawing.Point(112, 193);
            this.DonGiaNummeric.Name = "DonGiaNummeric";
            this.DonGiaNummeric.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.DonGiaNummeric.Properties.Appearance.Options.UseFont = true;
            this.DonGiaNummeric.Size = new System.Drawing.Size(739, 26);
            this.DonGiaNummeric.StyleController = this.layoutControl1;
            this.DonGiaNummeric.TabIndex = 10;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.DonGiaNummeric;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 181);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(843, 30);
            this.layoutControlItem7.Text = "Don Gia";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(96, 20);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(421, 30);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ChiTietDonHangGridControl
            // 
            this.ChiTietDonHangGridControl.Location = new System.Drawing.Point(12, 223);
            this.ChiTietDonHangGridControl.MainView = this.ChiTietDonHangGridView;
            this.ChiTietDonHangGridControl.Name = "ChiTietDonHangGridControl";
            this.ChiTietDonHangGridControl.Size = new System.Drawing.Size(839, 177);
            this.ChiTietDonHangGridControl.TabIndex = 11;
            this.ChiTietDonHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ChiTietDonHangGridView});
            // 
            // ChiTietDonHangGridView
            // 
            this.ChiTietDonHangGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChiTietDonHangGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.ChiTietDonHangGridView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChiTietDonHangGridView.Appearance.Row.Options.UseFont = true;
            this.ChiTietDonHangGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenHangHoaGridColumn,
            this.LoaiHangHoaGridColumn,
            this.NhaCungCapGridColumn,
            this.QuayHangGridColumn,
            this.SoLuongGridColumn,
            this.DonGiaGridColumn});
            this.ChiTietDonHangGridView.GridControl = this.ChiTietDonHangGridControl;
            this.ChiTietDonHangGridView.Name = "ChiTietDonHangGridView";
            this.ChiTietDonHangGridView.OptionsBehavior.Editable = false;
            this.ChiTietDonHangGridView.OptionsView.ColumnAutoWidth = false;
            this.ChiTietDonHangGridView.OptionsView.ShowAutoFilterRow = true;
            this.ChiTietDonHangGridView.OptionsView.ShowGroupPanel = false;
            this.ChiTietDonHangGridView.OptionsView.ShowIndicator = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.ChiTietDonHangGridControl;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 211);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(843, 181);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // TenHangHoaGridColumn
            // 
            this.TenHangHoaGridColumn.Caption = "Ten Hang Hoa";
            this.TenHangHoaGridColumn.FieldName = "TenHangHoa";
            this.TenHangHoaGridColumn.Name = "TenHangHoaGridColumn";
            this.TenHangHoaGridColumn.OptionsColumn.AllowEdit = false;
            this.TenHangHoaGridColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenHangHoaGridColumn.Visible = true;
            this.TenHangHoaGridColumn.VisibleIndex = 0;
            this.TenHangHoaGridColumn.Width = 150;
            // 
            // LoaiHangHoaGridColumn
            // 
            this.LoaiHangHoaGridColumn.Caption = "Loai Hang Hoa";
            this.LoaiHangHoaGridColumn.FieldName = "LoaiHangHoa";
            this.LoaiHangHoaGridColumn.Name = "LoaiHangHoaGridColumn";
            this.LoaiHangHoaGridColumn.OptionsColumn.AllowEdit = false;
            this.LoaiHangHoaGridColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.LoaiHangHoaGridColumn.Visible = true;
            this.LoaiHangHoaGridColumn.VisibleIndex = 1;
            this.LoaiHangHoaGridColumn.Width = 150;
            // 
            // NhaCungCapGridColumn
            // 
            this.NhaCungCapGridColumn.Caption = "Nha Cung Cap";
            this.NhaCungCapGridColumn.FieldName = "NhaCungCap";
            this.NhaCungCapGridColumn.Name = "NhaCungCapGridColumn";
            this.NhaCungCapGridColumn.OptionsColumn.AllowEdit = false;
            this.NhaCungCapGridColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NhaCungCapGridColumn.Visible = true;
            this.NhaCungCapGridColumn.VisibleIndex = 2;
            this.NhaCungCapGridColumn.Width = 150;
            // 
            // QuayHangGridColumn
            // 
            this.QuayHangGridColumn.Caption = "Quay Hang";
            this.QuayHangGridColumn.FieldName = "TenQuayHang";
            this.QuayHangGridColumn.Name = "QuayHangGridColumn";
            this.QuayHangGridColumn.OptionsColumn.AllowEdit = false;
            this.QuayHangGridColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.QuayHangGridColumn.Visible = true;
            this.QuayHangGridColumn.VisibleIndex = 3;
            this.QuayHangGridColumn.Width = 150;
            // 
            // SoLuongGridColumn
            // 
            this.SoLuongGridColumn.Caption = "So Luong";
            this.SoLuongGridColumn.FieldName = "SoLuong";
            this.SoLuongGridColumn.Name = "SoLuongGridColumn";
            this.SoLuongGridColumn.OptionsColumn.AllowEdit = false;
            this.SoLuongGridColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SoLuongGridColumn.Visible = true;
            this.SoLuongGridColumn.VisibleIndex = 4;
            // 
            // DonGiaGridColumn
            // 
            this.DonGiaGridColumn.Caption = "Don Gia";
            this.DonGiaGridColumn.FieldName = "DonGia";
            this.DonGiaGridColumn.Name = "DonGiaGridColumn";
            this.DonGiaGridColumn.OptionsColumn.AllowEdit = false;
            this.DonGiaGridColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.DonGiaGridColumn.Visible = true;
            this.DonGiaGridColumn.VisibleIndex = 5;
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Location = new System.Drawing.Point(12, 409);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(120, 30);
            this.CancelButtonControl.TabIndex = 1;
            this.CancelButtonControl.Text = "Thoat";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.DeleteButton.Appearance.Options.UseFont = true;
            this.DeleteButton.Location = new System.Drawing.Point(138, 409);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 30);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Xoa";
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.OKButton.Appearance.Options.UseFont = true;
            this.OKButton.Location = new System.Drawing.Point(731, 409);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.EditButton.Appearance.Options.UseFont = true;
            this.EditButton.Location = new System.Drawing.Point(605, 409);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(120, 30);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Sua";
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.AddButton.Appearance.Options.UseFont = true;
            this.AddButton.Location = new System.Drawing.Point(479, 409);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 30);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Them";
            // 
            // SearchTenHangHoaButton
            // 
            this.SearchTenHangHoaButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.SearchTenHangHoaButton.Appearance.Options.UseFont = true;
            this.SearchTenHangHoaButton.Location = new System.Drawing.Point(433, 42);
            this.SearchTenHangHoaButton.MaximumSize = new System.Drawing.Size(150, 0);
            this.SearchTenHangHoaButton.MinimumSize = new System.Drawing.Size(150, 0);
            this.SearchTenHangHoaButton.Name = "SearchTenHangHoaButton";
            this.SearchTenHangHoaButton.Size = new System.Drawing.Size(150, 27);
            this.SearchTenHangHoaButton.StyleController = this.layoutControl1;
            this.SearchTenHangHoaButton.TabIndex = 12;
            this.SearchTenHangHoaButton.Text = "Tim Hang Hoa";
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.SearchTenHangHoaButton;
            this.layoutControlItem9.Location = new System.Drawing.Point(421, 30);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(154, 31);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(575, 30);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(268, 31);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ChiTietDonHangEditForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 451);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChiTietDonHangEditForm";
            this.Text = "Chi Tiet Don Hang";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaDonHangTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenHangHoaTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiHangHoaLookupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhaCungCapLookupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuayHangLookupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongNummeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonGiaNummeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietDonHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietDonHangGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Common.Controls.QTextBoxControl MaDonHangTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl ChiTietDonHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ChiTietDonHangGridView;
        private Common.Controls.QNummericControl DonGiaNummeric;
        private Common.Controls.QNummericControl SoLuongNummeric;
        private Common.Controls.QLookupEditControl QuayHangLookupEdit;
        private Common.Controls.QLookupEditControl NhaCungCapLookupEdit;
        private Common.Controls.QLookupEditControl LoaiHangHoaLookupEdit;
        private Common.Controls.QTextBoxControl TenHangHoaTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraGrid.Columns.GridColumn TenHangHoaGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiHangHoaGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NhaCungCapGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn QuayHangGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaGridColumn;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl DeleteButton;
        private Common.Controls.QButtonControl OKButton;
        private Common.Controls.QButtonControl EditButton;
        private Common.Controls.QButtonControl AddButton;
        private Common.Controls.QButtonControl SearchTenHangHoaButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}