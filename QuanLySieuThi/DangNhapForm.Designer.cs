using Common.Forms;

namespace QuanLySieuThi
{
    partial class DangNhapForm : QuanLySieuThiForm
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
            this.MatKhauTextBox = new Common.Controls.QTextBoxControl();
            this.TenDangNhapTextBox = new Common.Controls.QTextBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.OKButton = new Common.Controls.QButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatKhauTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenDangNhapTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.MatKhauTextBox);
            this.layoutControl1.Controls.Add(this.TenDangNhapTextBox);
            this.layoutControl1.Location = new System.Drawing.Point(-1, -1);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(363, 80);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // MatKhauTextBox
            // 
            this.MatKhauTextBox.Location = new System.Drawing.Point(113, 40);
            this.MatKhauTextBox.Name = "MatKhauTextBox";
            this.MatKhauTextBox.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.MatKhauTextBox.Properties.Appearance.Options.UseFont = true;
            this.MatKhauTextBox.Properties.PasswordChar = '*';
            this.MatKhauTextBox.Size = new System.Drawing.Size(238, 24);
            this.MatKhauTextBox.StyleController = this.layoutControl1;
            this.MatKhauTextBox.TabIndex = 5;
            // 
            // TenDangNhapTextBox
            // 
            this.TenDangNhapTextBox.Location = new System.Drawing.Point(113, 12);
            this.TenDangNhapTextBox.Name = "TenDangNhapTextBox";
            this.TenDangNhapTextBox.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TenDangNhapTextBox.Properties.Appearance.Options.UseFont = true;
            this.TenDangNhapTextBox.Size = new System.Drawing.Size(238, 24);
            this.TenDangNhapTextBox.StyleController = this.layoutControl1;
            this.TenDangNhapTextBox.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(363, 80);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.TenDangNhapTextBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(343, 28);
            this.layoutControlItem1.Text = "Tên Đăng Nhập:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(98, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.MatKhauTextBox;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(343, 32);
            this.layoutControlItem2.Text = "Mật Khẩu:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(98, 17);
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Location = new System.Drawing.Point(12, 89);
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
            this.OKButton.Location = new System.Drawing.Point(231, 89);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // DangNhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 131);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangNhapForm";
            this.Text = "ĐĂNG NHẬP";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MatKhauTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenDangNhapTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Common.Controls.QTextBoxControl MatKhauTextBox;
        private Common.Controls.QTextBoxControl TenDangNhapTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl OKButton;
    }
}