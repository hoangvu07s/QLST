using Common.Forms;

namespace QuanLySieuThi.NhaCungCap
{
    partial class NhaCungCapEditForm : QuanLySieuThiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaCungCapEditForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.EmailTextBox = new Common.Controls.QTextBoxControl();
            this.SoDienThoaiTextBox = new Common.Controls.QTextBoxControl();
            this.DiaChiTextBox = new Common.Controls.QTextBoxControl();
            this.TenCongTyTextBox = new Common.Controls.QTextBoxControl();
            this.TenNhaCungCapTextBox = new Common.Controls.QTextBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.OKButton = new Common.Controls.QButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoDienThoaiTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChiTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenCongTyTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenNhaCungCapTextBox.Properties)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.EmailTextBox);
            this.layoutControl1.Controls.Add(this.SoDienThoaiTextBox);
            this.layoutControl1.Controls.Add(this.DiaChiTextBox);
            this.layoutControl1.Controls.Add(this.TenCongTyTextBox);
            this.layoutControl1.Controls.Add(this.TenNhaCungCapTextBox);
            this.layoutControl1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControl1.Location = new System.Drawing.Point(3, 1);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(594, 261);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(12, 224);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Properties.Appearance.Options.UseFont = true;
            this.EmailTextBox.Size = new System.Drawing.Size(570, 24);
            this.EmailTextBox.StyleController = this.layoutControl1;
            this.EmailTextBox.TabIndex = 8;
            // 
            // SoDienThoaiTextBox
            // 
            this.SoDienThoaiTextBox.Location = new System.Drawing.Point(12, 176);
            this.SoDienThoaiTextBox.Name = "SoDienThoaiTextBox";
            this.SoDienThoaiTextBox.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoDienThoaiTextBox.Properties.Appearance.Options.UseFont = true;
            this.SoDienThoaiTextBox.Size = new System.Drawing.Size(570, 24);
            this.SoDienThoaiTextBox.StyleController = this.layoutControl1;
            this.SoDienThoaiTextBox.TabIndex = 7;
            this.SoDienThoaiTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoDienThoaiTextBox_KeyPress);
            // 
            // DiaChiTextBox
            // 
            this.DiaChiTextBox.Location = new System.Drawing.Point(12, 128);
            this.DiaChiTextBox.Name = "DiaChiTextBox";
            this.DiaChiTextBox.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChiTextBox.Properties.Appearance.Options.UseFont = true;
            this.DiaChiTextBox.Size = new System.Drawing.Size(570, 24);
            this.DiaChiTextBox.StyleController = this.layoutControl1;
            this.DiaChiTextBox.TabIndex = 6;
            // 
            // TenCongTyTextBox
            // 
            this.TenCongTyTextBox.Location = new System.Drawing.Point(12, 80);
            this.TenCongTyTextBox.Name = "TenCongTyTextBox";
            this.TenCongTyTextBox.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenCongTyTextBox.Properties.Appearance.Options.UseFont = true;
            this.TenCongTyTextBox.Size = new System.Drawing.Size(570, 24);
            this.TenCongTyTextBox.StyleController = this.layoutControl1;
            this.TenCongTyTextBox.TabIndex = 5;
            this.TenCongTyTextBox.EditValueChanged += new System.EventHandler(this.TenCongTyTextBox_EditValueChanged);
            this.TenCongTyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TenCongTyTextBox_KeyPress);
            // 
            // TenNhaCungCapTextBox
            // 
            this.TenNhaCungCapTextBox.Location = new System.Drawing.Point(12, 32);
            this.TenNhaCungCapTextBox.Name = "TenNhaCungCapTextBox";
            this.TenNhaCungCapTextBox.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhaCungCapTextBox.Properties.Appearance.Options.UseFont = true;
            this.TenNhaCungCapTextBox.Size = new System.Drawing.Size(570, 24);
            this.TenNhaCungCapTextBox.StyleController = this.layoutControl1;
            this.TenNhaCungCapTextBox.TabIndex = 4;
            this.TenNhaCungCapTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TenNhaCungCapTextBox_KeyPress);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(594, 261);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.TenNhaCungCapTextBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(574, 48);
            this.layoutControlItem1.Text = "Tên Nhà Cung Cấp";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(115, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.TenCongTyTextBox;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(574, 48);
            this.layoutControlItem2.Text = "Tên Công Ty";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(115, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.DiaChiTextBox;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(574, 48);
            this.layoutControlItem3.Text = "Địa Chỉ";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(115, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.SoDienThoaiTextBox;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(574, 48);
            this.layoutControlItem4.Text = "Số Điện Thoại";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(115, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.EmailTextBox;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(574, 49);
            this.layoutControlItem5.Text = "Email";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(115, 17);
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Image = global::QuanLySieuThi.Properties.Resources.Actions_exit_icon__1_;
            this.CancelButtonControl.Location = new System.Drawing.Point(13, 260);
            this.CancelButtonControl.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(120, 30);
            this.CancelButtonControl.TabIndex = 1;
            this.CancelButtonControl.Text = "Thoát";
            this.CancelButtonControl.Click += new System.EventHandler(this.CancelButtonControl_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Appearance.Options.UseFont = true;
            this.OKButton.Image = global::QuanLySieuThi.Properties.Resources.Alarm_Arrow_Down_icon__1_;
            this.OKButton.Location = new System.Drawing.Point(465, 260);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // NhaCungCapEditForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 303);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhaCungCapEditForm";
            this.Text = "NHÀ CUNG CẤP";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoDienThoaiTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChiTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenCongTyTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenNhaCungCapTextBox.Properties)).EndInit();
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
        private Common.Controls.QTextBoxControl SoDienThoaiTextBox;
        private Common.Controls.QTextBoxControl DiaChiTextBox;
        private Common.Controls.QTextBoxControl TenCongTyTextBox;
        private Common.Controls.QTextBoxControl TenNhaCungCapTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Common.Controls.QTextBoxControl EmailTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl OKButton;
    }
}