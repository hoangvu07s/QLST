﻿using Common.Forms;

namespace QuanLySieuThi.NhanVien
{
    partial class NhanVienEditForm : QuanLySieuThiForm
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
            this.GioiTinhLookupEdit = new Common.Controls.QLookupEditControl();
            this.EmailTextBox = new Common.Controls.QTextBoxControl();
            this.DiaChiTextBox = new Common.Controls.QTextBoxControl();
            this.SoDienThoaiTextBox = new Common.Controls.QTextBoxControl();
            this.ChucVuLookupEdit = new Common.Controls.QLookupEditControl();
            this.MatKhauTextBox = new Common.Controls.QTextBoxControl();
            this.TenDangNhapTextBox = new Common.Controls.QTextBoxControl();
            this.NgaySinhDateEdit = new Common.Controls.QDateEditControl();
            this.HoVaTenTextBox = new Common.Controls.QTextBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.OKButton = new Common.Controls.QButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GioiTinhLookupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChiTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoDienThoaiTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChucVuLookupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatKhauTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenDangNhapTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoVaTenTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.GioiTinhLookupEdit);
            this.layoutControl1.Controls.Add(this.EmailTextBox);
            this.layoutControl1.Controls.Add(this.DiaChiTextBox);
            this.layoutControl1.Controls.Add(this.SoDienThoaiTextBox);
            this.layoutControl1.Controls.Add(this.ChucVuLookupEdit);
            this.layoutControl1.Controls.Add(this.MatKhauTextBox);
            this.layoutControl1.Controls.Add(this.TenDangNhapTextBox);
            this.layoutControl1.Controls.Add(this.NgaySinhDateEdit);
            this.layoutControl1.Controls.Add(this.HoVaTenTextBox);
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(553, 447);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GioiTinhLookupEdit
            // 
            this.GioiTinhLookupEdit.Location = new System.Drawing.Point(12, 88);
            this.GioiTinhLookupEdit.MaximumSize = new System.Drawing.Size(120, 0);
            this.GioiTinhLookupEdit.MinimumSize = new System.Drawing.Size(120, 0);
            this.GioiTinhLookupEdit.Name = "GioiTinhLookupEdit";
            this.GioiTinhLookupEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.GioiTinhLookupEdit.Properties.Appearance.Options.UseFont = true;
            this.GioiTinhLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GioiTinhLookupEdit.Properties.NullText = "";
            this.GioiTinhLookupEdit.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.GioiTinhLookupEdit.Size = new System.Drawing.Size(120, 26);
            this.GioiTinhLookupEdit.StyleController = this.layoutControl1;
            this.GioiTinhLookupEdit.TabIndex = 13;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(278, 353);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.EmailTextBox.Properties.Appearance.Options.UseFont = true;
            this.EmailTextBox.Size = new System.Drawing.Size(263, 26);
            this.EmailTextBox.StyleController = this.layoutControl1;
            this.EmailTextBox.TabIndex = 12;
            // 
            // DiaChiTextBox
            // 
            this.DiaChiTextBox.Location = new System.Drawing.Point(12, 406);
            this.DiaChiTextBox.Name = "DiaChiTextBox";
            this.DiaChiTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.DiaChiTextBox.Properties.Appearance.Options.UseFont = true;
            this.DiaChiTextBox.Size = new System.Drawing.Size(529, 26);
            this.DiaChiTextBox.StyleController = this.layoutControl1;
            this.DiaChiTextBox.TabIndex = 11;
            // 
            // SoDienThoaiTextBox
            // 
            this.SoDienThoaiTextBox.Location = new System.Drawing.Point(12, 353);
            this.SoDienThoaiTextBox.Name = "SoDienThoaiTextBox";
            this.SoDienThoaiTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.SoDienThoaiTextBox.Properties.Appearance.Options.UseFont = true;
            this.SoDienThoaiTextBox.Size = new System.Drawing.Size(262, 26);
            this.SoDienThoaiTextBox.StyleController = this.layoutControl1;
            this.SoDienThoaiTextBox.TabIndex = 10;
            // 
            // ChucVuLookupEdit
            // 
            this.ChucVuLookupEdit.Location = new System.Drawing.Point(12, 300);
            this.ChucVuLookupEdit.MaximumSize = new System.Drawing.Size(120, 0);
            this.ChucVuLookupEdit.MinimumSize = new System.Drawing.Size(120, 0);
            this.ChucVuLookupEdit.Name = "ChucVuLookupEdit";
            this.ChucVuLookupEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ChucVuLookupEdit.Properties.Appearance.Options.UseFont = true;
            this.ChucVuLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ChucVuLookupEdit.Properties.NullText = "";
            this.ChucVuLookupEdit.Size = new System.Drawing.Size(120, 26);
            this.ChucVuLookupEdit.StyleController = this.layoutControl1;
            this.ChucVuLookupEdit.TabIndex = 9;
            // 
            // MatKhauTextBox
            // 
            this.MatKhauTextBox.Location = new System.Drawing.Point(12, 247);
            this.MatKhauTextBox.Name = "MatKhauTextBox";
            this.MatKhauTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MatKhauTextBox.Properties.Appearance.Options.UseFont = true;
            this.MatKhauTextBox.Size = new System.Drawing.Size(529, 26);
            this.MatKhauTextBox.StyleController = this.layoutControl1;
            this.MatKhauTextBox.TabIndex = 8;
            // 
            // TenDangNhapTextBox
            // 
            this.TenDangNhapTextBox.Location = new System.Drawing.Point(12, 194);
            this.TenDangNhapTextBox.Name = "TenDangNhapTextBox";
            this.TenDangNhapTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TenDangNhapTextBox.Properties.Appearance.Options.UseFont = true;
            this.TenDangNhapTextBox.Size = new System.Drawing.Size(529, 26);
            this.TenDangNhapTextBox.StyleController = this.layoutControl1;
            this.TenDangNhapTextBox.TabIndex = 7;
            // 
            // NgaySinhDateEdit
            // 
            this.NgaySinhDateEdit.EditValue = null;
            this.NgaySinhDateEdit.Location = new System.Drawing.Point(12, 141);
            this.NgaySinhDateEdit.MaximumSize = new System.Drawing.Size(120, 0);
            this.NgaySinhDateEdit.MinimumSize = new System.Drawing.Size(120, 0);
            this.NgaySinhDateEdit.Name = "NgaySinhDateEdit";
            this.NgaySinhDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.NgaySinhDateEdit.Properties.Appearance.Options.UseFont = true;
            this.NgaySinhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgaySinhDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgaySinhDateEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.NgaySinhDateEdit.Size = new System.Drawing.Size(120, 26);
            this.NgaySinhDateEdit.StyleController = this.layoutControl1;
            this.NgaySinhDateEdit.TabIndex = 6;
            // 
            // HoVaTenTextBox
            // 
            this.HoVaTenTextBox.Location = new System.Drawing.Point(12, 35);
            this.HoVaTenTextBox.Name = "HoVaTenTextBox";
            this.HoVaTenTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.HoVaTenTextBox.Properties.Appearance.Options.UseFont = true;
            this.HoVaTenTextBox.Size = new System.Drawing.Size(529, 26);
            this.HoVaTenTextBox.StyleController = this.layoutControl1;
            this.HoVaTenTextBox.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem2,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(553, 447);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.HoVaTenTextBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(533, 53);
            this.layoutControlItem1.Text = "Ho Va Ten";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(104, 20);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.NgaySinhDateEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 106);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(533, 53);
            this.layoutControlItem3.Text = "Ngay Sinh";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(104, 20);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.TenDangNhapTextBox;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 159);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(533, 53);
            this.layoutControlItem4.Text = "Ten Dang Nhap";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(104, 20);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.MatKhauTextBox;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 212);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(533, 53);
            this.layoutControlItem5.Text = "Mat Khau";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(104, 20);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.ChucVuLookupEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 265);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(533, 53);
            this.layoutControlItem6.Text = "Chuc Vu";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(104, 20);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.SoDienThoaiTextBox;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 318);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(266, 53);
            this.layoutControlItem7.Text = "So Dien Thoai";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(104, 20);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.Control = this.DiaChiTextBox;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 371);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(533, 56);
            this.layoutControlItem8.Text = "Dia Chi";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(104, 20);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.GioiTinhLookupEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(533, 53);
            this.layoutControlItem2.Text = "Gioi Tinh";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(104, 20);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.Control = this.EmailTextBox;
            this.layoutControlItem9.Location = new System.Drawing.Point(266, 318);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(267, 53);
            this.layoutControlItem9.Text = "Email";
            this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(104, 20);
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Location = new System.Drawing.Point(12, 442);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(120, 30);
            this.CancelButtonControl.TabIndex = 1;
            this.CancelButtonControl.Text = "Thoat";
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.OKButton.Appearance.Options.UseFont = true;
            this.OKButton.Location = new System.Drawing.Point(421, 442);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            // 
            // NhanVienEditForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 484);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NhanVienEditForm";
            this.Text = "Nhan Vien Edit Form";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GioiTinhLookupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChiTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoDienThoaiTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChucVuLookupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatKhauTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenDangNhapTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySinhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoVaTenTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Common.Controls.QTextBoxControl HoVaTenTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Common.Controls.QDateEditControl NgaySinhDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private Common.Controls.QTextBoxControl TenDangNhapTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Common.Controls.QTextBoxControl MatKhauTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private Common.Controls.QLookupEditControl ChucVuLookupEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private Common.Controls.QTextBoxControl SoDienThoaiTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private Common.Controls.QTextBoxControl EmailTextBox;
        private Common.Controls.QTextBoxControl DiaChiTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl OKButton;
        private Common.Controls.QLookupEditControl GioiTinhLookupEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}