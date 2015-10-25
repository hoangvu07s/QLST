using System;
using DevExpress.XtraBars;
using Helper;
using QuanLySieuThi.HangHoa;
using QuanLySieuThi.KhachHang;
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
                var quanLyNhaCungCap = new QuanLyNhaCungCapForm();
                quanLyNhaCungCap.ShowForm("OpenQuanLyNhaCungCapForm");
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
                var quanLyQuayHang = new QuanLyQuayHangForm();
                quanLyQuayHang.ShowForm("OpenQuanLyQuayHangForm");
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
                var quanLyKhoHangForm = new QuanLyKhoHangForm();
                quanLyKhoHangForm.ShowForm("OpenQuanLyKhoHangForm");
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
                var quanLyHangHoaForm = new QuanLyHangHoaForm();
                quanLyHangHoaForm.ShowForm("OpenQuanLyHangHoaForm");
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
                var quanLyChungLoaiHangHoa = new QuanLyChungLoaiHangHoa();
                quanLyChungLoaiHangHoa.ShowForm("OpenQuanLyChungHoaiHangHoaForm");
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

        private void QuanLyKhachHangBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var quanLyKhachHang = new QuanLyKhachHangForm();
                quanLyKhachHang.ShowForm("OpenQuanLyKhachHang");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        
    }
}