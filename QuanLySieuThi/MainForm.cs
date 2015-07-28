using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Helper;
using QuanLySieuThi.HangHoa;
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
                var chucVuListForm = new ChucVuListForm();
                chucVuListForm.ShowForm("OpenChucVuListForm");
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
                var nhanvienListForm = new NhanVienListForm();
                nhanvienListForm.ShowForm("OpenNhanVienListForm");
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

    }
}