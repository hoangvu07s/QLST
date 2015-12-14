namespace QuanLySieuThi.HeThong
{
    partial class SaoLuuDuLieuForm
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
            this.CancelButtonControl = new Common.Controls.QButtonControl();
            this.CopyDatabaseButton = new Common.Controls.QButtonControl();
            this.SelectThuMucButton = new Common.Controls.QButtonControl();
            this.ThuMucTextBox = new Common.Controls.QTextBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThuMucTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.CancelButtonControl);
            this.layoutControl1.Controls.Add(this.CopyDatabaseButton);
            this.layoutControl1.Controls.Add(this.SelectThuMucButton);
            this.layoutControl1.Controls.Add(this.ThuMucTextBox);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(554, 110);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CancelButtonControl.Appearance.Options.UseFont = true;
            this.CancelButtonControl.Location = new System.Drawing.Point(435, 68);
            this.CancelButtonControl.MaximumSize = new System.Drawing.Size(0, 30);
            this.CancelButtonControl.MinimumSize = new System.Drawing.Size(0, 30);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(107, 30);
            this.CancelButtonControl.StyleController = this.layoutControl1;
            this.CancelButtonControl.TabIndex = 7;
            this.CancelButtonControl.Text = "Thoát";
            this.CancelButtonControl.Click += new System.EventHandler(this.CancelButtonControl_Click);
            // 
            // CopyDatabaseButton
            // 
            this.CopyDatabaseButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.CopyDatabaseButton.Appearance.Options.UseFont = true;
            this.CopyDatabaseButton.Location = new System.Drawing.Point(12, 68);
            this.CopyDatabaseButton.MaximumSize = new System.Drawing.Size(0, 30);
            this.CopyDatabaseButton.MinimumSize = new System.Drawing.Size(0, 30);
            this.CopyDatabaseButton.Name = "CopyDatabaseButton";
            this.CopyDatabaseButton.Size = new System.Drawing.Size(114, 30);
            this.CopyDatabaseButton.StyleController = this.layoutControl1;
            this.CopyDatabaseButton.TabIndex = 6;
            this.CopyDatabaseButton.Text = "Sao Lưu Dữ Liệu";
            this.CopyDatabaseButton.Click += new System.EventHandler(this.CopyDatabaseButton_Click);
            // 
            // SelectThuMucButton
            // 
            this.SelectThuMucButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.SelectThuMucButton.Appearance.Options.UseFont = true;
            this.SelectThuMucButton.Location = new System.Drawing.Point(433, 12);
            this.SelectThuMucButton.MaximumSize = new System.Drawing.Size(0, 30);
            this.SelectThuMucButton.MinimumSize = new System.Drawing.Size(0, 30);
            this.SelectThuMucButton.Name = "SelectThuMucButton";
            this.SelectThuMucButton.Size = new System.Drawing.Size(109, 30);
            this.SelectThuMucButton.StyleController = this.layoutControl1;
            this.SelectThuMucButton.TabIndex = 5;
            this.SelectThuMucButton.Text = "Chọn Thư Mục";
            this.SelectThuMucButton.Click += new System.EventHandler(this.SelectThuMucButton_Click);
            // 
            // ThuMucTextBox
            // 
            this.ThuMucTextBox.Location = new System.Drawing.Point(68, 12);
            this.ThuMucTextBox.Name = "ThuMucTextBox";
            this.ThuMucTextBox.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.ThuMucTextBox.Properties.Appearance.Options.UseFont = true;
            this.ThuMucTextBox.Properties.ReadOnly = true;
            this.ThuMucTextBox.Size = new System.Drawing.Size(361, 24);
            this.ThuMucTextBox.StyleController = this.layoutControl1;
            this.ThuMucTextBox.TabIndex = 4;
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
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(554, 110);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.ThuMucTextBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(421, 34);
            this.layoutControlItem1.Text = "Thư mục";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(53, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.SelectThuMucButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(421, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(113, 34);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CopyDatabaseButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(118, 34);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.CancelButtonControl;
            this.layoutControlItem4.Location = new System.Drawing.Point(423, 56);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(111, 34);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(118, 56);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(305, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 34);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(534, 22);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // SaoLuuDuLieuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 110);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaoLuuDuLieuForm";
            this.Text = "SaoLuuDuLieuForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThuMucTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Common.Controls.QButtonControl SelectThuMucButton;
        private Common.Controls.QTextBoxControl ThuMucTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private Common.Controls.QButtonControl CancelButtonControl;
        private Common.Controls.QButtonControl CopyDatabaseButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}