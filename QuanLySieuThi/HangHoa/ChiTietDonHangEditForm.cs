using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.HangHoa
{
    public partial class ChiTietDonHangEditForm
    {
        private DonHangService _donHangService;
        private LoaiHangHoaService _loaiHangHoaService;
        private NhaCungCapService _nhaCungCapService;
        private QuayHangService _quayHangService;
        private IList<ChiTietDonHang> _chiTietDonHangs;

        public ChiTietDonHangEditForm(string donHangId)
        {
            InitializeComponent();
            MinimumSizeWidth = 879;
            MinimumSizeHeight = 490;
            EntityId = donHangId;
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);
            try
            {
                ShowData();

                if (string.IsNullOrEmpty(EntityId))
                {
                    _chiTietDonHangs = new List<ChiTietDonHang>();
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ShowData()
        {
            try
            {
                ResetEntities();

                _donHangService = new DonHangService(Entities);
                _loaiHangHoaService = new LoaiHangHoaService(Entities);
                _nhaCungCapService = new NhaCungCapService(Entities);
                _quayHangService = new QuayHangService(Entities);

                LoadLoaiHangHoa();
                LoadNhaCungCap();
                LoadQuayHang();

                if (string.IsNullOrEmpty(EntityId))
                {
                    MaDonHangTextBox.Text = QuanLySieuThiHelper.NextId();
                }
                else
                {
                    MaDonHangTextBox.Text = EntityId;
                }

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void LoadLoaiHangHoa()
        {
            try
            {
                var loaiHangHoas = _loaiHangHoaService.GetAll();
                LoaiHangHoaLookupEdit.Properties.DataSource = loaiHangHoas;
                LoaiHangHoaLookupEdit.Properties.DisplayMember = "TenLoaiHangHoa";
                LoaiHangHoaLookupEdit.Properties.ValueMember = "Id";
                LoaiHangHoaLookupEdit.Properties.Columns.Add(new LookUpColumnInfo("TenLoaiHangHoa"));

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void LoadNhaCungCap()
        {
            try
            {
                var nhaCungCaps = _nhaCungCapService.GetAll();
                NhaCungCapLookupEdit.Properties.DataSource = nhaCungCaps;
                NhaCungCapLookupEdit.Properties.DisplayMember = "TenNhaCungCap";
                NhaCungCapLookupEdit.Properties.ValueMember = "Id";
                NhaCungCapLookupEdit.Properties.Columns.Add(new LookUpColumnInfo("TenNhaCungCap"));
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void LoadQuayHang()
        {
            try
            {
                var quayHangs = _quayHangService.GetAll();
                QuayHangLookupEdit.Properties.DataSource = quayHangs;
                QuayHangLookupEdit.Properties.DisplayMember = "TenQuay";
                QuayHangLookupEdit.Properties.ValueMember = "Id";
                QuayHangLookupEdit.Properties.Columns.Add(new LookUpColumnInfo("TenQuay"));
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ValidateInput()
        {
            try
            {
                if (string.IsNullOrEmpty(TenHangHoaTextBox.Text))
                {
                    MessageBox.Show(@"Vui long nhap Ten Hang Hoa", @"Thong Bao", MessageBoxButtons.OK);
                }

                if (string.IsNullOrEmpty(NhaCungCapLookupEdit.EditValue.ToString()))
                {
                    MessageBox.Show(@"Vui long chon Nha Cung Cap", @"Thong Bao", MessageBoxButtons.OK);
                }

                if (string.IsNullOrEmpty(QuayHangLookupEdit.EditValue.ToString()))
                {
                    MessageBox.Show(@"Vui long chon Quay Hang", @"Thong Bao", MessageBoxButtons.OK);
                }

                if (string.IsNullOrEmpty(LoaiHangHoaLookupEdit.EditValue.ToString()))
                {
                    MessageBox.Show(@"Vui long chon Loai Hang Hoa", @"Thong Bao", MessageBoxButtons.OK);
                }

                if (string.IsNullOrEmpty(SoLuongNummeric.Text))
                {
                    MessageBox.Show(@"Vui long nhap So Luong", @"Thong Bao", MessageBoxButtons.OK);
                }

                if (string.IsNullOrEmpty(DonGiaNummeric.Text))
                {
                    MessageBox.Show(@"Vui long nhap Don Gia", @"Thong Bao", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

    }
}
