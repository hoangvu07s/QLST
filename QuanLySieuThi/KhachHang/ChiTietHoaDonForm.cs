using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Model;
using QuanLySieuThi.HangHoa;
using Service;

namespace QuanLySieuThi.KhachHang
{
    public partial class ChiTietHoaDonForm : QuanLySieuThiForm
    {
        private ChiTietHoaDonService _chiTietHoaDonService;
        private HoaDonService _hoaDonService;
        private HangHoaService _hangHoaService;

        private QuanLyHangHoaForm _quanLyHangHoaForm;
        private QuanLyKhachHangForm _quanLyKhachHangForm;

        private Guid? _maHoaDon;
        private IList<CT_HoaDon> _chiTietHoaDons;
        private Model.HangHoa _hangHoa;
        private Model.KhachHang _khachHang;
        private Object _selRow;

        public ChiTietHoaDonForm(Guid? maHoaDon)
        {
            InitializeComponent();
            MinimumSizeWidth = 1003;
            MinimumSizeHeight = 602;

            _maHoaDon = maHoaDon;
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);
            try
            {
                _chiTietHoaDonService = new ChiTietHoaDonService(Entities);
                _hoaDonService = new HoaDonService(Entities);
                _hangHoaService = new HangHoaService(Entities);

                if (!_maHoaDon.HasValue)
                {
                    FormMode = FormMode.Add;
                    _chiTietHoaDons = new List<CT_HoaDon>();
                    EnabledControls(true);

                    _maHoaDon = new Guid(QuanLySieuThiHelper.NextId());
                }
                else
                {
                    FormMode = FormMode.View;
                    _chiTietHoaDons = _chiTietHoaDonService.GetByHoaDonId(_maHoaDon.Value);
                    ShowData();

                    EnabledControls(false);
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
                ChiTietHoaDonGridControl.DataSource = _chiTietHoaDons;
                ChiTietHoaDonGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void EnabledControls(bool isEnabled)
        {
            try
            {
                HangHoaTextBox.Enabled = isEnabled;
                SearchButton.Enabled = isEnabled;
                SoLuongTonKhoNummeric.Enabled = isEnabled;
                SoLuongDatMuaNummeric.Enabled = isEnabled;
                DonGiaNummeric.Enabled = isEnabled;
                AddButton.Enabled = isEnabled;
                SaveButton.Enabled = isEnabled;
                EditButton.Enabled = isEnabled;
                DeleteButton.Enabled = isEnabled;
                TenKhachHangTextBox.Enabled = isEnabled;
                SearchKhachHangButton.Enabled = isEnabled;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                _quanLyHangHoaForm = new QuanLyHangHoaForm(true);
                _quanLyHangHoaForm.ShowForm("OpenSearchHangHoaForm");
                _quanLyHangHoaForm.FormClosed += QuanLyHangHoaFormOnFormClosed;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void QuanLyHangHoaFormOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            try
            {
                if (_quanLyHangHoaForm.HangHoa != null)
                {
                    _hangHoa = _quanLyHangHoaForm.HangHoa;
                    HangHoaTextBox.Text = _hangHoa.TenHangHoa;
                    SoLuongTonKhoNummeric.Text = _hangHoa.SoLuongTonQuay.ToString();
                    DonGiaNummeric.Text = _hangHoa.GiaBanRa.ToString(CultureInfo.InvariantCulture);
                }               
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
                if (_hangHoa != null)
                {
                    if (_chiTietHoaDons.Any(_ => _.HangHoaId == _hangHoa.Id))
                    {
                        MessageBox.Show(
                                    @"Hàng Hóa đã có sẵn trong danh sách Hàng Hóa",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (SoLuongDatMuaNummeric.Text.ToInt() <= 0)
                    {
                        MessageBox.Show(
                                    @"Số lượng đặt mua phải lớn hơn 0",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (SoLuongDatMuaNummeric.Text.ToInt() > SoLuongTonKhoNummeric.Text.ToInt())
                    {
                        MessageBox.Show(
                                    @"Số lượng đặt mua phải bé hơn số lượng tồn quầy",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (string.IsNullOrWhiteSpace(HangHoaTextBox.Text))
                    {
                        MessageBox.Show(
                                    @"Xin vui lòng chọn Hàng Hóa",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        var chiTietHoaDon = new CT_HoaDon
                        {
                            HangHoaId = _hangHoa.Id,
                            HangHoa = _hangHoa,
                            DonGia = _hangHoa.GiaBanRa,
                            HoaDonId = _maHoaDon.Value,
                            SoLuong = SoLuongDatMuaNummeric.Text.ToInt()
                        };

                        _chiTietHoaDons.Add(chiTietHoaDon);

                        ShowData();
                    }
                }
                
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ChiTietHoaDonGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _selRow = ChiTietHoaDonGridView.GetRow(e.FocusedRowHandle);

                var chiTietHoaDon = _selRow as CT_HoaDon;
                if (chiTietHoaDon != null)
                {
                    HangHoaTextBox.Text = chiTietHoaDon.HangHoa.TenHangHoa;
                    SoLuongTonKhoNummeric.Text = chiTietHoaDon.HangHoa.SoLuongTonQuay.ToString();
                    SoLuongDatMuaNummeric.Text = chiTietHoaDon.SoLuong.ToString(CultureInfo.InvariantCulture);
                    DonGiaNummeric.Text = chiTietHoaDon.HangHoa.GiaBanRa.ToString(CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                var chiTietHoaDon = _selRow as CT_HoaDon;
                var chiTietHoaDonInList = _chiTietHoaDons.FirstOrDefault(_ => chiTietHoaDon != null && _.HangHoaId == chiTietHoaDon.HangHoaId);
                if (chiTietHoaDonInList != null)
                {
                    if (SoLuongDatMuaNummeric.Text.ToInt() <= 0)
                    {
                        MessageBox.Show(
                                    @"Số lượng đặt mua phải lớn hơn 0",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (SoLuongDatMuaNummeric.Text.ToInt() > SoLuongTonKhoNummeric.Text.ToInt())
                    {
                        MessageBox.Show(
                                    @"Số lượng đặt mua phải bé hơn số lượng tồn quầy",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        _chiTietHoaDons.Remove(chiTietHoaDonInList);
                        chiTietHoaDonInList.SoLuong = SoLuongDatMuaNummeric.Text.ToInt();

                        _chiTietHoaDons.Add(chiTietHoaDonInList);

                        ShowData();
                    }
                    
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
                var chiTietHoaDon = _selRow as CT_HoaDon;
                var chiTietHoaDonInList = _chiTietHoaDons.FirstOrDefault(_ => chiTietHoaDon != null && _.HangHoaId == chiTietHoaDon.HangHoaId);
                if (chiTietHoaDonInList != null)
                {
                    _chiTietHoaDons.Remove(chiTietHoaDonInList);
                    _hangHoa = null;

                    ShowData();
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_chiTietHoaDons.Count > 0)
                {
                    
                    if (string.IsNullOrWhiteSpace(TenKhachHangTextBox.Text))
                    {
                        MessageBox.Show(
                                    @"Vui lòng chọn tên Khách Hàng",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        // Luu Hoa Don
                        var hoaDon = new HoaDon
                        {
                            HoaDonId = _maHoaDon.Value,
                            KhachHangId = _khachHang.Id,
                            NhanVienId = CurrentFormInfo.CurrentUserId,
                            NgayLap = DateTime.Now,
                            NgayChinhSua = DateTime.Now,
                            NguoiChinhSuaId = CurrentFormInfo.CurrentUserId,
                            HoatDong = true
                        };

                        hoaDon = _hoaDonService.Add(hoaDon);
                        _hoaDonService.Save();

                        // luu chi tiet hoa don
                        foreach (var chiTietHoaDon in _chiTietHoaDons)
                        {
                            var chiTietHoaDonSaveToDatabase = new CT_HoaDon
                            {
                                HoaDonId = hoaDon.HoaDonId,
                                DonGia = chiTietHoaDon.DonGia,
                                HangHoaId = chiTietHoaDon.HangHoaId,
                                SoLuong = chiTietHoaDon.SoLuong
                            };

                            _chiTietHoaDonService.Add(chiTietHoaDonSaveToDatabase);
                        }

                        _chiTietHoaDonService.Save();

                        // update Hang hoa
                        foreach (var chiTietHoaDon in _chiTietHoaDons)
                        {
                            var hangHoa = _hangHoaService.Get(chiTietHoaDon.HangHoaId);
                            hangHoa.SoLuongTonQuay = hangHoa.SoLuongTonQuay - chiTietHoaDon.SoLuong;
                            hangHoa.NgayChinhSua = DateTime.Now;
                            hangHoa.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;

                            _hangHoaService.Update(hangHoa);
                        }

                        _hangHoaService.Save();

                        Close();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void SearchKhachHangButton_Click(object sender, EventArgs e)
        {
            try
            {
                _quanLyKhachHangForm = new QuanLyKhachHangForm(true);
                _quanLyKhachHangForm.ShowForm("OpenSearchKhachHangForm");
                _quanLyKhachHangForm.FormClosed += QuanLyKhachHangFormOnFormClosed;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void QuanLyKhachHangFormOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            try
            {
                if (_quanLyKhachHangForm.KhachHang != null)
                {
                    _khachHang = _quanLyKhachHangForm.KhachHang;
                    TenKhachHangTextBox.Text = _khachHang.TenKhachHang;
                }
                
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
    }
}
