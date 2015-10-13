﻿using System;
using DevExpress.XtraBars;
using Helper;
using QuanLySieuThi.HangHoa;
using QuanLySieuThi.Kho;
using QuanLySieuThi.NhaCungCap;
using QuanLySieuThi.NhanVien;

namespace QuanLySieuThi
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void QuanLyChucVuButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var quanLyChucVuForm = new QuanLyChucVuForm();
                quanLyChucVuForm.ShowForm("OpenQuanLyChucVuForm");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void QuanLyNhanVienButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var quanLyNhanVienForm = new QuanLyNhanVienForm();
                quanLyNhanVienForm.ShowForm("OpenQuanLyNhanVienForm");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void NhaCUngCapBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var nhaCungCapListForm = new NhaCungCapListForm();
                nhaCungCapListForm.ShowForm("OpenNhaCungCapListForm");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void QuanLyQuayHangButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var quayHangListForm = new QuayHangListForm();
                quayHangListForm.ShowForm("OpenQuayHangListForm");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void QuanLyDonHangButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var donHangListForm = new DonHangListForm();
                donHangListForm.ShowForm("OpenDonHangListForm");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void QuanLyKhoHangButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var khoHangListForm = new KhoHangListForm();
                khoHangListForm.ShowForm("OpenKhoHangListForm");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void QuanLyHangHoaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var hangHoaListForm = new HangHoaListForm();
                hangHoaListForm.ShowForm("OpenHangHoaListForm");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void NhapKhoButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var nhapkhoEditForm = new NhapKhoEditForm();
                nhapkhoEditForm.ShowForm("OpenNhapKhoEditForm");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void XuatKhoButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var xuatKhoEditForm = new XuatKhoEditForm();
                xuatKhoEditForm.ShowForm("OpenXuatKhoEditForm");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void QuanLyChungLoaiHangHoaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var chungLoaiHangHoa = new ChungLoaiHangHoaListForm();
                chungLoaiHangHoa.ShowForm("OpenChungLoaiHangHoaLisForm");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void NhapKhoListButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var nhaoKhoListForm = new NhapKhoListForm();
                nhaoKhoListForm.ShowForm("OpenNhapKhoListForm");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var xuatKhoListForm = new XuatKhoListForm();
                xuatKhoListForm.ShowForm("OpenXuatKhoListForm");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ThongKeHangHoaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var thongKeHangHoa = new ThongKeHangHoaForm();
                thongKeHangHoa.ShowForm("OpenThongKeHangHoa");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

        }

        private void TraHangVeKhoButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var phieuTraHang = new PhieuTraQuayHangForm();
                phieuTraHang.ShowForm("OpenPhieuTraQuayHang");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        
    }
}