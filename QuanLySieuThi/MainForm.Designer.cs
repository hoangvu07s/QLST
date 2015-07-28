﻿namespace QuanLySieuThi
{
    partial class MainForm
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.QuanLyNhanVienButton = new DevExpress.XtraBars.BarButtonItem();
            this.QuanLyChucVuButton = new DevExpress.XtraBars.BarButtonItem();
            this.NhaCUngCapBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.QuanLyQuayHangButton = new DevExpress.XtraBars.BarButtonItem();
            this.QuanLyChungLoaiHangHoaButton = new DevExpress.XtraBars.BarButtonItem();
            this.QuanLyDonHangButton = new DevExpress.XtraBars.BarButtonItem();
            this.nhanVienRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.HangHoaRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.NhaCungCapRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.QuanLyNhanVienButton,
            this.QuanLyChucVuButton,
            this.NhaCUngCapBarButton,
            this.QuanLyQuayHangButton,
            this.QuanLyChungLoaiHangHoaButton,
            this.QuanLyDonHangButton});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.nhanVienRibbonPage,
            this.HangHoaRibbonPage,
            this.NhaCungCapRibbonPage});
            this.ribbon.Size = new System.Drawing.Size(873, 148);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // QuanLyNhanVienButton
            // 
            this.QuanLyNhanVienButton.Caption = "Quản Lý Nhân Viên";
            this.QuanLyNhanVienButton.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.QuanLyNhanVienButton.Id = 1;
            this.QuanLyNhanVienButton.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyNhanVienButton.ItemAppearance.Disabled.Options.UseFont = true;
            this.QuanLyNhanVienButton.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyNhanVienButton.ItemAppearance.Hovered.Options.UseFont = true;
            this.QuanLyNhanVienButton.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyNhanVienButton.ItemAppearance.Normal.Options.UseFont = true;
            this.QuanLyNhanVienButton.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyNhanVienButton.ItemAppearance.Pressed.Options.UseFont = true;
            this.QuanLyNhanVienButton.Name = "QuanLyNhanVienButton";
            this.QuanLyNhanVienButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.QuanLyNhanVienButton_ItemClick);
            // 
            // QuanLyChucVuButton
            // 
            this.QuanLyChucVuButton.Caption = "Quản Lý Chức Vụ";
            this.QuanLyChucVuButton.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.QuanLyChucVuButton.Id = 2;
            this.QuanLyChucVuButton.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyChucVuButton.ItemAppearance.Disabled.Options.UseFont = true;
            this.QuanLyChucVuButton.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyChucVuButton.ItemAppearance.Hovered.Options.UseFont = true;
            this.QuanLyChucVuButton.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyChucVuButton.ItemAppearance.Normal.Options.UseFont = true;
            this.QuanLyChucVuButton.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyChucVuButton.ItemAppearance.Pressed.Options.UseFont = true;
            this.QuanLyChucVuButton.Name = "QuanLyChucVuButton";
            this.QuanLyChucVuButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.QuanLyChucVuButton_ItemClick);
            // 
            // NhaCUngCapBarButton
            // 
            this.NhaCUngCapBarButton.Caption = "Quản Lý Nhà Cung Cấp";
            this.NhaCUngCapBarButton.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.NhaCUngCapBarButton.Id = 3;
            this.NhaCUngCapBarButton.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhaCUngCapBarButton.ItemAppearance.Disabled.Options.UseFont = true;
            this.NhaCUngCapBarButton.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhaCUngCapBarButton.ItemAppearance.Hovered.Options.UseFont = true;
            this.NhaCUngCapBarButton.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhaCUngCapBarButton.ItemAppearance.Normal.Options.UseFont = true;
            this.NhaCUngCapBarButton.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhaCUngCapBarButton.ItemAppearance.Pressed.Options.UseFont = true;
            this.NhaCUngCapBarButton.Name = "NhaCUngCapBarButton";
            this.NhaCUngCapBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NhaCUngCapBarButton_ItemClick);
            // 
            // QuanLyQuayHangButton
            // 
            this.QuanLyQuayHangButton.Caption = "Quản Lý Quầy Hàng";
            this.QuanLyQuayHangButton.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.QuanLyQuayHangButton.Id = 4;
            this.QuanLyQuayHangButton.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyQuayHangButton.ItemAppearance.Disabled.Options.UseFont = true;
            this.QuanLyQuayHangButton.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyQuayHangButton.ItemAppearance.Hovered.Options.UseFont = true;
            this.QuanLyQuayHangButton.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyQuayHangButton.ItemAppearance.Normal.Options.UseFont = true;
            this.QuanLyQuayHangButton.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyQuayHangButton.ItemAppearance.Pressed.Options.UseFont = true;
            this.QuanLyQuayHangButton.Name = "QuanLyQuayHangButton";
            this.QuanLyQuayHangButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.QuanLyQuayHangButton_ItemClick);
            // 
            // QuanLyChungLoaiHangHoaButton
            // 
            this.QuanLyChungLoaiHangHoaButton.Caption = "Quản Lý Chủng Loại Hàng Hóa";
            this.QuanLyChungLoaiHangHoaButton.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.QuanLyChungLoaiHangHoaButton.Id = 6;
            this.QuanLyChungLoaiHangHoaButton.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyChungLoaiHangHoaButton.ItemAppearance.Disabled.Options.UseFont = true;
            this.QuanLyChungLoaiHangHoaButton.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyChungLoaiHangHoaButton.ItemAppearance.Hovered.Options.UseFont = true;
            this.QuanLyChungLoaiHangHoaButton.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyChungLoaiHangHoaButton.ItemAppearance.Normal.Options.UseFont = true;
            this.QuanLyChungLoaiHangHoaButton.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyChungLoaiHangHoaButton.ItemAppearance.Pressed.Options.UseFont = true;
            this.QuanLyChungLoaiHangHoaButton.Name = "QuanLyChungLoaiHangHoaButton";
            // 
            // QuanLyDonHangButton
            // 
            this.QuanLyDonHangButton.Caption = "Quản Lý Đơn Hàng";
            this.QuanLyDonHangButton.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.QuanLyDonHangButton.Id = 7;
            this.QuanLyDonHangButton.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyDonHangButton.ItemAppearance.Disabled.Options.UseFont = true;
            this.QuanLyDonHangButton.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyDonHangButton.ItemAppearance.Hovered.Options.UseFont = true;
            this.QuanLyDonHangButton.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyDonHangButton.ItemAppearance.Normal.Options.UseFont = true;
            this.QuanLyDonHangButton.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyDonHangButton.ItemAppearance.Pressed.Options.UseFont = true;
            this.QuanLyDonHangButton.Name = "QuanLyDonHangButton";
            this.QuanLyDonHangButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.QuanLyDonHangButton_ItemClick);
            // 
            // nhanVienRibbonPage
            // 
            this.nhanVienRibbonPage.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhanVienRibbonPage.Appearance.Options.UseFont = true;
            this.nhanVienRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.nhanVienRibbonPage.Name = "nhanVienRibbonPage";
            this.nhanVienRibbonPage.Text = "Nhân Viên";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.QuanLyChucVuButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.QuanLyNhanVienButton);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // HangHoaRibbonPage
            // 
            this.HangHoaRibbonPage.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HangHoaRibbonPage.Appearance.Options.UseFont = true;
            this.HangHoaRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.HangHoaRibbonPage.Name = "HangHoaRibbonPage";
            this.HangHoaRibbonPage.Text = "Hàng Hóa";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.QuanLyQuayHangButton);
            this.ribbonPageGroup3.ItemLinks.Add(this.QuanLyChungLoaiHangHoaButton);
            this.ribbonPageGroup3.ItemLinks.Add(this.QuanLyDonHangButton);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // NhaCungCapRibbonPage
            // 
            this.NhaCungCapRibbonPage.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhaCungCapRibbonPage.Appearance.Options.UseFont = true;
            this.NhaCungCapRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.NhaCungCapRibbonPage.Name = "NhaCungCapRibbonPage";
            this.NhaCungCapRibbonPage.Text = "Nhà Cung Cấp";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.NhaCUngCapBarButton);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 660);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(873, 31);
            // 
            // MainForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 691);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage nhanVienRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem QuanLyNhanVienButton;
        private DevExpress.XtraBars.BarButtonItem QuanLyChucVuButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage NhaCungCapRibbonPage;
        private DevExpress.XtraBars.BarButtonItem NhaCUngCapBarButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage HangHoaRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem QuanLyQuayHangButton;
        private DevExpress.XtraBars.BarButtonItem QuanLyChungLoaiHangHoaButton;
        private DevExpress.XtraBars.BarButtonItem QuanLyDonHangButton;
    }
}