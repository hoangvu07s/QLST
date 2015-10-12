using Common.Forms;

namespace QuanLySieuThi.Kho
{
    partial class ChiTietPhieuTraQuayHangForm : QuanLySieuThiForm
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
            this.PhieuTraQuayHangIdTextBox = new Common.Controls.QTextBoxControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.HangHoaTextBox = new Common.Controls.QTextBoxControl();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.SearchButton = new Common.Controls.QButtonControl();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.SoLuongNummeric = new Common.Controls.QNummericControl();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.DonGiaNummeric = new Common.Controls.QNummericControl();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LyDoTextBox = new Common.Controls.QTextBoxControl();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.OKButton = new Common.Controls.QButtonControl();
            this.SoLuongTonQuayNummeric = new Common.Controls.QNummericControl();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuTraQuayHangIdTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongNummeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonGiaNummeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LyDoTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongTonQuayNummeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.SoLuongTonQuayNummeric);
            this.layoutControl1.Controls.Add(this.LyDoTextBox);
            this.layoutControl1.Controls.Add(this.DonGiaNummeric);
            this.layoutControl1.Controls.Add(this.SoLuongNummeric);
            this.layoutControl1.Controls.Add(this.SearchButton);
            this.layoutControl1.Controls.Add(this.HangHoaTextBox);
            this.layoutControl1.Controls.Add(this.PhieuTraQuayHangIdTextBox);
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(610, 196);
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
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(610, 196);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // PhieuTraQuayHangIdTextBox
            // 
            this.PhieuTraQuayHangIdTextBox.Location = new System.Drawing.Point(161, 12);
            this.PhieuTraQuayHangIdTextBox.Name = "PhieuTraQuayHangIdTextBox";
            this.PhieuTraQuayHangIdTextBox.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.PhieuTraQuayHangIdTextBox.Properties.Appearance.Options.UseFont = true;
            this.PhieuTraQuayHangIdTextBox.Size = new System.Drawing.Size(437, 24);
            this.PhieuTraQuayHangIdTextBox.StyleController = this.layoutControl1;
            this.PhieuTraQuayHangIdTextBox.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.PhieuTraQuayHangIdTextBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(590, 28);
            this.layoutControlItem1.Text = "Phiếu Trả Quầy Hàng Id";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(145, 17);
            // 
            // HangHoaTextBox
            // 
            this.HangHoaTextBox.Location = new System.Drawing.Point(161, 40);
            this.HangHoaTextBox.Name = "HangHoaTextBox";
            this.HangHoaTextBox.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.HangHoaTextBox.Properties.Appearance.Options.UseFont = true;
            this.HangHoaTextBox.Size = new System.Drawing.Size(326, 24);
            this.HangHoaTextBox.StyleController = this.layoutControl1;
            this.HangHoaTextBox.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.HangHoaTextBox;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(479, 28);
            this.layoutControlItem2.Text = "Hàng Hóa";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(145, 17);
            // 
            // SearchButton
            // 
            this.SearchButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SearchButton.Appearance.Options.UseFont = true;
            this.SearchButton.Location = new System.Drawing.Point(491, 40);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(107, 24);
            this.SearchButton.StyleController = this.layoutControl1;
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Tìm Hàng Hóa";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.SearchButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(479, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(111, 28);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // SoLuongNummeric
            // 
            this.SoLuongNummeric.Location = new System.Drawing.Point(161, 96);
            this.SoLuongNummeric.Name = "SoLuongNummeric";
            this.SoLuongNummeric.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SoLuongNummeric.Properties.Appearance.Options.UseFont = true;
            this.SoLuongNummeric.Size = new System.Drawing.Size(437, 24);
            this.SoLuongNummeric.StyleController = this.layoutControl1;
            this.SoLuongNummeric.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.SoLuongNummeric;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(590, 28);
            this.layoutControlItem4.Text = "Số Lượng";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(145, 17);
            // 
            // DonGiaNummeric
            // 
            this.DonGiaNummeric.Location = new System.Drawing.Point(161, 124);
            this.DonGiaNummeric.Name = "DonGiaNummeric";
            this.DonGiaNummeric.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.DonGiaNummeric.Properties.Appearance.Options.UseFont = true;
            this.DonGiaNummeric.Size = new System.Drawing.Size(437, 24);
            this.DonGiaNummeric.StyleController = this.layoutControl1;
            this.DonGiaNummeric.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.DonGiaNummeric;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(590, 28);
            this.layoutControlItem5.Text = "Đơn Giá";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(145, 17);
            // 
            // LyDoTextBox
            // 
            this.LyDoTextBox.Location = new System.Drawing.Point(161, 152);
            this.LyDoTextBox.Name = "LyDoTextBox";
            this.LyDoTextBox.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.LyDoTextBox.Properties.Appearance.Options.UseFont = true;
            this.LyDoTextBox.Size = new System.Drawing.Size(437, 24);
            this.LyDoTextBox.StyleController = this.layoutControl1;
            this.LyDoTextBox.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.LyDoTextBox;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 140);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(590, 36);
            this.layoutControlItem6.Text = "Lý Do";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(145, 17);
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Location = new System.Drawing.Point(12, 193);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(120, 30);
            this.CancelButtonControl.TabIndex = 1;
            this.CancelButtonControl.Text = "Thoát";
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.OKButton.Appearance.Options.UseFont = true;
            this.OKButton.Location = new System.Drawing.Point(478, 193);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            // 
            // SoLuongTonQuayNummeric
            // 
            this.SoLuongTonQuayNummeric.Location = new System.Drawing.Point(161, 68);
            this.SoLuongTonQuayNummeric.Name = "SoLuongTonQuayNummeric";
            this.SoLuongTonQuayNummeric.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SoLuongTonQuayNummeric.Properties.Appearance.Options.UseFont = true;
            this.SoLuongTonQuayNummeric.Size = new System.Drawing.Size(437, 24);
            this.SoLuongTonQuayNummeric.StyleController = this.layoutControl1;
            this.SoLuongTonQuayNummeric.TabIndex = 10;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.SoLuongTonQuayNummeric;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(590, 28);
            this.layoutControlItem7.Text = "Số Lượng Tồn Quầy";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(145, 17);
            // 
            // ChiTietPhieuTraQuayHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 228);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ChiTietPhieuTraQuayHangForm";
            this.Text = "ChiTietPhieuTraQuayHangForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuTraQuayHangIdTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongNummeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonGiaNummeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LyDoTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongTonQuayNummeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Common.Controls.QTextBoxControl PhieuTraQuayHangIdTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Common.Controls.QButtonControl SearchButton;
        private Common.Controls.QTextBoxControl HangHoaTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private Common.Controls.QNummericControl SoLuongNummeric;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Common.Controls.QNummericControl DonGiaNummeric;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private Common.Controls.QTextBoxControl LyDoTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl OKButton;
        private Common.Controls.QNummericControl SoLuongTonQuayNummeric;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;

    }
}