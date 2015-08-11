using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using Helper;
using Helper.ValueObjects;
using Service;

namespace QuanLySieuThi.Kho
{
    public partial class XuatKhoEditForm
    {
        private readonly KhoHangService _khoHangService;
        private readonly NhapKhoService _nhapKhoService;
        private readonly ChiTietNhapKhoService _chiTietNhapKhoService;
        private readonly TonKhoService _tonKhoService;

        private IList<ChiTietXuatKho> _chiTietXuatKhos; 

        public XuatKhoEditForm()
        {
            InitializeComponent();
            MinimumSizeWidth = 782;
            MinimumSizeHeight = 447;

            _khoHangService = new KhoHangService(Entities);
            _nhapKhoService = new NhapKhoService(Entities);
            _chiTietNhapKhoService = new ChiTietNhapKhoService(Entities);
            _tonKhoService = new TonKhoService(Entities);
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);
            try
            {
               _chiTietXuatKhos = new List<ChiTietXuatKho>();
               LoadKhoData();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void LoadKhoData()
        {
            try
            {
                var khoHangs = _khoHangService.GetAll();
                KhoHangLookupEdit.Properties.DataSource = khoHangs;
                KhoHangLookupEdit.Properties.DisplayMember = "TenKho";
                KhoHangLookupEdit.Properties.ValueMember = "Id";
                KhoHangLookupEdit.Properties.Columns.Add(new LookUpColumnInfo("TenKho"));
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void LoadHangHoa(IList<Model.HangHoa> hangHoas)
        {
            try
            {
                HangHoaLookupEdit.Properties.DataSource = hangHoas;
                HangHoaLookupEdit.Properties.DisplayMember = "TenHangHoa";
                HangHoaLookupEdit.Properties.ValueMember = "Id";
                HangHoaLookupEdit.Properties.Columns.Add(new LookUpColumnInfo("TenHangHoa"));
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void KhoHangLookupEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                IList<Model.HangHoa> hangHoas = new List<Model.HangHoa>();
                var khoId = KhoHangLookupEdit.EditValue.ToString().ToLong();
                var nhapKhos = _nhapKhoService.Get(khoId);
                foreach (var nhapKho in nhapKhos)
                {
                    var chiTietNhapKhos = _chiTietNhapKhoService.Get(nhapKho.PhieuNhapKhoId);
                    foreach (var chiTietNhapKho in chiTietNhapKhos)
                    {
                        hangHoas.Add(chiTietNhapKho.HangHoa);
                    }
                }

                LoadHangHoa(hangHoas.Distinct().ToList());
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void HangHoaLookupEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var khoId = KhoHangLookupEdit.EditValue.ToString().ToLong();
                var hangHoaId = HangHoaLookupEdit.EditValue.ToString().ToLong();

                var tonKho = _tonKhoService.Get(khoId, hangHoaId);

                SoLuongTonKhoNummeric.Text = tonKho.SoLuongTon.ToString();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChiTietXuatKho())
                {
                    _chiTietXuatKhos.Add(new ChiTietXuatKho
                    {
                        HangHoaId = HangHoaLookupEdit.EditValue.ToString().ToLong(),
                        TenHangHoa = HangHoaLookupEdit.Text,
                        SoLuong = SoLuongXuatKhoNummeric.Text.ToInt()
                    });

                    ShowDataToGrid();
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ShowDataToGrid()
        {
            try
            {
                CTXuatKhoGridControl.DataSource = _chiTietXuatKhos;
                CTXuatKhoGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private bool ValidateChiTietXuatKho(bool isUpdate = true)
        {
            try
            {
                if (string.IsNullOrEmpty(KhoHangLookupEdit.Text))
                {
                    MessageBox.Show(@"Vui lòng chọn Kho", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrEmpty(HangHoaLookupEdit.Text))
                {
                    MessageBox.Show(@"Vui lòng chọn Hàng Hóa", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (SoLuongXuatKhoNummeric.Text.ToInt() == 0)
                {
                    MessageBox.Show(@"Số lượng xuất kho phải lớn hơn 0", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (SoLuongXuatKhoNummeric.Text.ToInt() > SoLuongTonKhoNummeric.Text.ToInt())
                {
                    MessageBox.Show(@"Số lượng xuất kho phải bé hơn số lượng tồn kho", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (isUpdate == false)
                {
                    if (_chiTietXuatKhos.Any(_ => _.HangHoaId == HangHoaLookupEdit.EditValue.ToString().ToLong()))
                    {
                        MessageBox.Show(@"Hàng hóa đã được thêm vào", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }
                }

                return true;

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return false;
        }
    }
}
