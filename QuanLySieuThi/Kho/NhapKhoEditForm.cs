using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using Helper;
using Helper.ValueObjects;
using QuanLySieuThi.HangHoa;
using Service;

namespace QuanLySieuThi.Kho
{
    public partial class NhapKhoEditForm
    {
        private readonly NhapKhoService _nhapKhoService;
        private readonly KhoHangService _khoHangService;
        private readonly ChiTietDonHangService _chiTietDonHangService;
        private readonly ChiTietNhapKhoService _chiTietNhapKhoService;
        private readonly DonHangService _donHangService;
        private readonly TonKhoService _tonKhoService;

        private string _donHangId;
        private IList<ChiTietNhapKho> _chiTietNhapKhos;

        private object _selRow;

        public NhapKhoEditForm()
        {
            InitializeComponent();
            MinimumSizeWidth = 782;
            MinimumSizeHeight = 447;

            _nhapKhoService = new NhapKhoService(Entities);
            _khoHangService = new KhoHangService(Entities);
            _chiTietDonHangService = new ChiTietDonHangService(Entities);
            _chiTietNhapKhoService = new ChiTietNhapKhoService(Entities);
            _donHangService = new DonHangService(Entities);
            _tonKhoService = new TonKhoService(Entities);
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);
            try
            {
                _chiTietNhapKhos = new List<ChiTietNhapKho>();
                ShowData();
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
                LoadKhoHang();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void LoadKhoHang()
        {
            try
            {
                var khoHangs = _khoHangService.GetAll();
                KhoLookupEdit.Properties.DataSource = khoHangs;
                KhoLookupEdit.Properties.DisplayMember = "TenKho";
                KhoLookupEdit.Properties.ValueMember = "Id";
                KhoLookupEdit.Properties.Columns.Add(new LookUpColumnInfo("TenKho"));
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void LoadHangHoa()
        {
            try
            {
                var hangHoas = _chiTietDonHangService.GetHangHoas(new Guid(_donHangId));
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

        private void SearchDonHangButton_Click(object sender, EventArgs e)
        {
            var donHangListForm = new DonHangListForm(true);
            donHangListForm.ShowForm("OpenDonHangListForm");
            donHangListForm.FormClosed += DonHangListFormOnFormClosed;
        }

        private void DonHangListFormOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            _donHangId = DonHangListForm.MaDonHang.ToString();
            MaDonHangTextBox.Text = _donHangId;
            LoadHangHoa();
            var chiTietDonHangs = _chiTietDonHangService.GetByDonHangId(new Guid(_donHangId));

            _chiTietNhapKhos = new List<ChiTietNhapKho>();
            foreach (var chiTietDonHang in chiTietDonHangs)
            {
                _chiTietNhapKhos.Add(new ChiTietNhapKho
                {
                    HangHoaId = chiTietDonHang.HangHoaId,
                    SoLuong = 0,
                    TenHangHoa = chiTietDonHang.HangHoa.TenHangHoa,
                    SoluongDatHang = chiTietDonHang.SoLuong
                });
            }

            ShowDataToGrid();
        }

        private void HangHoaLookupEdit_EditValueChanged(object sender, EventArgs e)
        {
            var ctDonHang = _chiTietDonHangService.Get(new Guid(_donHangId),
                HangHoaLookupEdit.EditValue.ToString().ToLong());
            var soLuongDaNhan = _nhapKhoService.GetSoluongNhapKho(new Guid(_donHangId),
                HangHoaLookupEdit.EditValue.ToString().ToLong());

            SoLuongDatHangNummeric.Text = ctDonHang.SoLuong.ToString(CultureInfo.InvariantCulture);
            SoLuongDaNhanNummeric.Text = soLuongDaNhan.ToString(CultureInfo.InvariantCulture);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChiTietNhapKho())
                {
                    _chiTietNhapKhos.Add(new ChiTietNhapKho
                    {
                        HangHoaId = HangHoaLookupEdit.EditValue.ToString().ToLong(),
                        TenHangHoa = HangHoaLookupEdit.Text,
                        SoLuong = SoLuongNummeric.Text.ToInt(),
                        SoluongDatHang = SoLuongDatHangNummeric.Text.ToInt()
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
                CTNhapKhoGridControl.DataSource = _chiTietNhapKhos;
                CTNhapKhoGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private bool ValidateChiTietNhapKho(bool isUpdated = false)
        {
            try
            {
                if (string.IsNullOrEmpty(HangHoaLookupEdit.Text))
                {
                    MessageBox.Show(@"Vui lòng chọn Hàng Hóa", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (SoLuongNummeric.Text.ToInt() == 0)
                {
                    MessageBox.Show(@"Vui lòng nhập số lượng Hàng Hóa", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (SoLuongNummeric.Text.ToInt() > SoLuongDatHangNummeric.Text.ToInt())
                {
                    MessageBox.Show(@"Số lượng nhập vào không thể lớn hơn số lượng đặt hàng", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (SoLuongDaNhanNummeric.Text.ToInt() > 0)
                {
                    var soluongDatHang = SoLuongDatHangNummeric.Text.ToInt();
                    var soluongDaNhan = SoLuongDaNhanNummeric.Text.ToInt();
                    var soluongNhapVao = SoLuongNummeric.Text.ToInt();

                    if (soluongNhapVao > (soluongDatHang - soluongDaNhan))
                    {
                        MessageBox.Show(string.Format("Số lượng nhập vào phải nằm trong khoản 0 đến {0}", soluongDatHang - soluongDaNhan), @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }
                }

                if (isUpdated == false)
                {
                    if (_chiTietNhapKhos.Any(_ => _.HangHoaId == HangHoaLookupEdit.EditValue.ToString().ToLong()))
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChiTietNhapKho(true))
                {
                    var chiTietNhapKho = _selRow as ChiTietNhapKho;
                    if (chiTietNhapKho != null)
                    {
                        chiTietNhapKho = _chiTietNhapKhos.FirstOrDefault(_ => _.HangHoaId == chiTietNhapKho.HangHoaId);
                        if (chiTietNhapKho != null)
                        {
                            chiTietNhapKho.SoLuong = SoLuongNummeric.Text.ToInt();
                            ShowDataToGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void CTNhapKhoGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _selRow = CTNhapKhoGridView.GetRow(e.FocusedRowHandle);

                var chiTietNhapKho = _selRow as ChiTietNhapKho;
                if (chiTietNhapKho != null)
                {
                    HangHoaLookupEdit.EditValue = chiTietNhapKho.HangHoaId;
                    SoLuongNummeric.Text = chiTietNhapKho.SoLuong.ToString(CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var chiTietNhapKho = _selRow as ChiTietNhapKho;
                _chiTietNhapKhos.Remove(chiTietNhapKho);

                ShowDataToGrid();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void CancelButtonControl_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateNhapKho())
                {
                    var nhapKho = _nhapKhoService.Add();
                    nhapKho.PhieuNhapKhoId = new Guid(QuanLySieuThiHelper.NextId());
                    nhapKho.DonHangId = new Guid(MaDonHangTextBox.Text);
                    nhapKho.KhoId = KhoLookupEdit.EditValue.ToString().ToLong();
                    nhapKho.NgayTao = DateTime.Now;
                    nhapKho.NguoiTaoId = CurrentFormInfo.CurrentUserId;
                    nhapKho.HoatDong = true;

                    _nhapKhoService.Save();

                    
                    foreach (var chiTietNhapKho in _chiTietNhapKhos)
                    {
                        var ctNhapKho = _chiTietNhapKhoService.Add();
                        ctNhapKho.NhapKhoId = nhapKho.PhieuNhapKhoId;
                        ctNhapKho.HangHoaId = chiTietNhapKho.HangHoaId;
                        ctNhapKho.SoLuong = chiTietNhapKho.SoLuong;
                    }

                    _chiTietNhapKhoService.Save();

                    var ctDonHangs = _chiTietDonHangService.GetByDonHangId(new Guid(MaDonHangTextBox.Text));
                    var soLuongInDonHang = ctDonHangs.Sum(_ => _.SoLuong);
                    var nhapKhos = _nhapKhoService.Get(new Guid(MaDonHangTextBox.Text));
                    var soluongDaNhap = 0;
                    foreach (var kho in nhapKhos)
                    {
                        var ctNhapKhos = _chiTietNhapKhoService.Get(kho.PhieuNhapKhoId);
                        soluongDaNhap = soluongDaNhap + ctNhapKhos.Sum(_ => _.SoLuong);
                    }

                    var donHang = _donHangService.Get(new Guid(MaDonHangTextBox.Text));

                    if (soLuongInDonHang > soluongDaNhap)
                    {
                        donHang.TrangThaiDonHang = "Chua Hoan Thanh";
                    }
                    else if(soLuongInDonHang == soluongDaNhap)
                    {
                        donHang.TrangThaiDonHang = "Hoan Thanh";
                    }

                    donHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                    donHang.NgayChinhSua = DateTime.Now;

                    _donHangService.Update(donHang);

                    _donHangService.Save();

                    foreach (var chiTietNhapKho in _chiTietNhapKhos)
                    {
                        var tonKho = _tonKhoService.Get(KhoLookupEdit.EditValue.ToString().ToLong(),
                            chiTietNhapKho.HangHoaId);
                        if (tonKho == null)
                        {
                            tonKho = _tonKhoService.Add();
                            tonKho.HangHoaId = chiTietNhapKho.HangHoaId;
                            tonKho.KhoId = KhoLookupEdit.EditValue.ToString().ToLong();
                            tonKho.SoLuongTon = chiTietNhapKho.SoLuong;
                        }
                        else
                        {
                            tonKho.SoLuongTon = tonKho.SoLuongTon + chiTietNhapKho.SoLuong;
                        }

                    }

                    _tonKhoService.Save();

                    Close();
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private bool ValidateNhapKho()
        {
            try
            {
                if (string.IsNullOrEmpty(MaDonHangTextBox.Text))
                {
                    MessageBox.Show(@"Vui lòng chọn Đơn Hàng", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrEmpty(KhoLookupEdit.Text))
                {
                    MessageBox.Show(@"Vui lòng chọn Kho", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (_chiTietNhapKhos.Count <= 0)
                {
                    MessageBox.Show(@"Vui lòng nhập hàng hóa", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (_chiTietNhapKhos.Any(_ => _.SoLuong == 0))
                {
                    MessageBox.Show(@"Số lượng phải nhập kho phải lớn hơn 0", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
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
