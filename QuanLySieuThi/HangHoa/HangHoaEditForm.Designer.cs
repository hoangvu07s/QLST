using Common.Forms;

namespace QuanLySieuThi.HangHoa
{
    partial class HangHoaEditForm : QuanLySieuThiForm
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
            this.GiaBanRaNummeric = new Common.Controls.QNummericControl();
            this.GiaNhapVaoNummeric = new Common.Controls.QNummericControl();
            this.TraLaiCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.QuayHangLookupEdit = new Common.Controls.QLookupEditControl();
            this.NhaCungCapLookupEdit = new Common.Controls.QLookupEditControl();
            this.LoaiHangHoaLookupEdit = new Common.Controls.QLookupEditControl();
            this.TenHangHoaTextBox = new Common.Controls.QTextBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.OKButton = new Common.Controls.QButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiaBanRaNummeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiaNhapVaoNummeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraLaiCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuayHangLookupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhaCungCapLookupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiHangHoaLookupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenHangHoaTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.GiaBanRaNummeric);
            this.layoutControl1.Controls.Add(this.GiaNhapVaoNummeric);
            this.layoutControl1.Controls.Add(this.TraLaiCheckEdit);
            this.layoutControl1.Controls.Add(this.QuayHangLookupEdit);
            this.layoutControl1.Controls.Add(this.NhaCungCapLookupEdit);
            this.layoutControl1.Controls.Add(this.LoaiHangHoaLookupEdit);
            this.layoutControl1.Controls.Add(this.TenHangHoaTextBox);
            this.layoutControl1.Location = new System.Drawing.Point(-1, -1);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(456, 332);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GiaBanRaNummeric
            // 
            this.GiaBanRaNummeric.Location = new System.Drawing.Point(12, 295);
            this.GiaBanRaNummeric.Name = "GiaBanRaNummeric";
            this.GiaBanRaNummeric.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.GiaBanRaNummeric.Properties.Appearance.Options.UseFont = true;
            this.GiaBanRaNummeric.Properties.DisplayFormat.FormatString = "n";
            this.GiaBanRaNummeric.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBanRaNummeric.Properties.Mask.EditMask = "n";
            this.GiaBanRaNummeric.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.GiaBanRaNummeric.Properties.NullText = "0.00";
            this.GiaBanRaNummeric.Size = new System.Drawing.Size(432, 24);
            this.GiaBanRaNummeric.StyleController = this.layoutControl1;
            this.GiaBanRaNummeric.TabIndex = 10;
            // 
            // GiaNhapVaoNummeric
            // 
            this.GiaNhapVaoNummeric.Location = new System.Drawing.Point(12, 247);
            this.GiaNhapVaoNummeric.Name = "GiaNhapVaoNummeric";
            this.GiaNhapVaoNummeric.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.GiaNhapVaoNummeric.Properties.Appearance.Options.UseFont = true;
            this.GiaNhapVaoNummeric.Properties.DisplayFormat.FormatString = "n";
            this.GiaNhapVaoNummeric.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaNhapVaoNummeric.Properties.Mask.EditMask = "n";
            this.GiaNhapVaoNummeric.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.GiaNhapVaoNummeric.Properties.NullText = "0.00";
            this.GiaNhapVaoNummeric.Size = new System.Drawing.Size(432, 24);
            this.GiaNhapVaoNummeric.StyleController = this.layoutControl1;
            this.GiaNhapVaoNummeric.TabIndex = 9;
            // 
            // TraLaiCheckEdit
            // 
            this.TraLaiCheckEdit.Location = new System.Drawing.Point(108, 204);
            this.TraLaiCheckEdit.Name = "TraLaiCheckEdit";
            this.TraLaiCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraLaiCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.TraLaiCheckEdit.Properties.Caption = "";
            this.TraLaiCheckEdit.Size = new System.Drawing.Size(336, 19);
            this.TraLaiCheckEdit.StyleController = this.layoutControl1;
            this.TraLaiCheckEdit.TabIndex = 8;
            // 
            // QuayHangLookupEdit
            // 
            this.QuayHangLookupEdit.Location = new System.Drawing.Point(12, 176);
            this.QuayHangLookupEdit.Name = "QuayHangLookupEdit";
            this.QuayHangLookupEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.QuayHangLookupEdit.Properties.Appearance.Options.UseFont = true;
            this.QuayHangLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.QuayHangLookupEdit.Size = new System.Drawing.Size(432, 24);
            this.QuayHangLookupEdit.StyleController = this.layoutControl1;
            this.QuayHangLookupEdit.TabIndex = 7;
            // 
            // NhaCungCapLookupEdit
            // 
            this.NhaCungCapLookupEdit.Location = new System.Drawing.Point(12, 128);
            this.NhaCungCapLookupEdit.Name = "NhaCungCapLookupEdit";
            this.NhaCungCapLookupEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.NhaCungCapLookupEdit.Properties.Appearance.Options.UseFont = true;
            this.NhaCungCapLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NhaCungCapLookupEdit.Size = new System.Drawing.Size(432, 24);
            this.NhaCungCapLookupEdit.StyleController = this.layoutControl1;
            this.NhaCungCapLookupEdit.TabIndex = 6;
            // 
            // LoaiHangHoaLookupEdit
            // 
            this.LoaiHangHoaLookupEdit.Location = new System.Drawing.Point(12, 80);
            this.LoaiHangHoaLookupEdit.Name = "LoaiHangHoaLookupEdit";
            this.LoaiHangHoaLookupEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.LoaiHangHoaLookupEdit.Properties.Appearance.Options.UseFont = true;
            this.LoaiHangHoaLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LoaiHangHoaLookupEdit.Size = new System.Drawing.Size(432, 24);
            this.LoaiHangHoaLookupEdit.StyleController = this.layoutControl1;
            this.LoaiHangHoaLookupEdit.TabIndex = 5;
            // 
            // TenHangHoaTextBox
            // 
            this.TenHangHoaTextBox.Location = new System.Drawing.Point(12, 32);
            this.TenHangHoaTextBox.Name = "TenHangHoaTextBox";
            this.TenHangHoaTextBox.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TenHangHoaTextBox.Properties.Appearance.Options.UseFont = true;
            this.TenHangHoaTextBox.Size = new System.Drawing.Size(432, 24);
            this.TenHangHoaTextBox.StyleController = this.layoutControl1;
            this.TenHangHoaTextBox.TabIndex = 4;
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
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(456, 332);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.TenHangHoaTextBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(436, 48);
            this.layoutControlItem1.Text = "Tên Hàng Hóa";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.LoaiHangHoaLookupEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(436, 48);
            this.layoutControlItem2.Text = "Loại Hàng Hóa";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.NhaCungCapLookupEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(436, 48);
            this.layoutControlItem3.Text = "Nhà Cung Cấp";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.QuayHangLookupEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(436, 48);
            this.layoutControlItem4.Text = "Quầy Hàng";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(93, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.TraLaiCheckEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(436, 23);
            this.layoutControlItem5.Text = "Có Thể Trả Lại";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(93, 17);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.GiaNhapVaoNummeric;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 215);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(436, 48);
            this.layoutControlItem6.Text = "Giá Nhập Vào";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(93, 17);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.GiaBanRaNummeric;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 263);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(436, 49);
            this.layoutControlItem7.Text = "Giá Bán Ra";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(93, 17);
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Image = global::QuanLySieuThi.Properties.Resources.Actions_exit_icon__1_;
            this.CancelButtonControl.Location = new System.Drawing.Point(12, 326);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(120, 30);
            this.CancelButtonControl.TabIndex = 1;
            this.CancelButtonControl.Text = "Thoát";
            this.CancelButtonControl.Click += new System.EventHandler(this.CancelButtonControl_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.OKButton.Appearance.Options.UseFont = true;
            this.OKButton.Image = global::QuanLySieuThi.Properties.Resources.Alarm_Arrow_Down_icon__1_;
            this.OKButton.Location = new System.Drawing.Point(324, 326);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // HangHoaEditForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 365);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HangHoaEditForm";
            this.Text = "HÀNG HÓA";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GiaBanRaNummeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiaNhapVaoNummeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraLaiCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuayHangLookupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhaCungCapLookupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiHangHoaLookupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenHangHoaTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Common.Controls.QTextBoxControl TenHangHoaTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Common.Controls.QLookupEditControl LoaiHangHoaLookupEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private Common.Controls.QLookupEditControl QuayHangLookupEdit;
        private Common.Controls.QLookupEditControl NhaCungCapLookupEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.CheckEdit TraLaiCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private Common.Controls.QNummericControl GiaNhapVaoNummeric;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private Common.Controls.QNummericControl GiaBanRaNummeric;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl OKButton;
    }
}