using Common.Forms;

namespace QuanLySieuThi.Kho
{
    partial class ChiTietNhapKhoForm : QuanLySieuThiForm
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
            this.CTNhapKhoGridControl = new DevExpress.XtraGrid.GridControl();
            this.CTNhapKhoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HangHoaColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.OKButton = new Common.Controls.QButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTNhapKhoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTNhapKhoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.CTNhapKhoGridControl);
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(619, 241);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CTNhapKhoGridControl
            // 
            this.CTNhapKhoGridControl.Location = new System.Drawing.Point(12, 12);
            this.CTNhapKhoGridControl.MainView = this.CTNhapKhoGridView;
            this.CTNhapKhoGridControl.Name = "CTNhapKhoGridControl";
            this.CTNhapKhoGridControl.Size = new System.Drawing.Size(595, 217);
            this.CTNhapKhoGridControl.TabIndex = 4;
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
            this.HangHoaColumn,
            this.SoLuongColumn});
            this.CTNhapKhoGridView.GridControl = this.CTNhapKhoGridControl;
            this.CTNhapKhoGridView.Name = "CTNhapKhoGridView";
            this.CTNhapKhoGridView.OptionsBehavior.Editable = false;
            this.CTNhapKhoGridView.OptionsView.ColumnAutoWidth = false;
            this.CTNhapKhoGridView.OptionsView.ShowAutoFilterRow = true;
            this.CTNhapKhoGridView.OptionsView.ShowGroupPanel = false;
            this.CTNhapKhoGridView.OptionsView.ShowIndicator = false;
            // 
            // HangHoaColumn
            // 
            this.HangHoaColumn.Caption = "Hàng Hóa";
            this.HangHoaColumn.FieldName = "HangHoa.TenHangHoa";
            this.HangHoaColumn.Name = "HangHoaColumn";
            this.HangHoaColumn.OptionsColumn.AllowEdit = false;
            this.HangHoaColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.HangHoaColumn.Visible = true;
            this.HangHoaColumn.VisibleIndex = 0;
            this.HangHoaColumn.Width = 150;
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
            this.SoLuongColumn.Width = 150;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(619, 241);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.CTNhapKhoGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(599, 221);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.OKButton.Appearance.Options.UseFont = true;
            this.OKButton.Location = new System.Drawing.Point(487, 237);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ChiTietNhapKhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 279);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ChiTietNhapKhoForm";
            this.Text = "ChiTietNhapKhoForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CTNhapKhoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTNhapKhoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl CTNhapKhoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView CTNhapKhoGridView;
        private DevExpress.XtraGrid.Columns.GridColumn HangHoaColumn;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongColumn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Common.Controls.QButtonControl OKButton;
    }
}