using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Common.Forms;
using DevExpress.XtraEditors.Controls;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.KhachHang
{
    public partial class ChiTietDoiTraHangHoaForm : QuanLySieuThiForm
    {
        private ChiTietDoiTraHangHoaService _chiTietDoiTraHangHoaService;
        private ChiTietHoaDonService _chiTietHoaDonService;
        private QuanLyHoaDonForm _quanLyHoaDonForm;
        private ChiTietXuatKhoService _chiTietXuatKhoService;
        private XuatKhoService _xuatKhoService;
        private DoiTraHangHoaService _doiTraHangHoaService;
        private TonKhoService _tonKhoService;
        private ChiTietNhapKhoService _chiTietNhapKhoService;
       private TheKhachHangService _theKhachHangService;

        private Guid? _maDoiTraHangHoa;
        private IList<CT_DoiTraHangHoa> _chiTietDoiTraHangHoas;
        private HoaDon _hoaDon;
        private IList<Model.HangHoa> _hangHoas;
        private Object _selRow;

        public ChiTietDoiTraHangHoaForm(Guid? maDoiTraHangHoa)
        {
            InitializeComponent();

            MinimumSizeWidth = 1003;
            MinimumSizeHeight = 602;

            _maDoiTraHangHoa = maDoiTraHangHoa;
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);
            try
            {
                _chiTietDoiTraHangHoaService = new ChiTietDoiTraHangHoaService(Entities);
                _chiTietHoaDonService = new ChiTietHoaDonService(Entities);
                _chiTietXuatKhoService = new ChiTietXuatKhoService(Entities);
                _xuatKhoService = new XuatKhoService(Entities);
                _chiTietNhapKhoService = new ChiTietNhapKhoService(Entities);
                _doiTraHangHoaService = new DoiTraHangHoaService(Entities);
                _tonKhoService = new TonKhoService(Entities);

                if (!_maDoiTraHangHoa.HasValue)
                {
                    FormMode = FormMode.Add;
                    _chiTietDoiTraHangHoas = new List<CT_DoiTraHangHoa>();

                    EnabledControls(true);

                    _maDoiTraHangHoa = new Guid(QuanLySieuThiHelper.NextId());
                }
                else
                {
                    FormMode = FormMode.View;
                    _chiTietDoiTraHangHoas = _chiTietDoiTraHangHoaService.GetByDoiTraHangHoaId(_maDoiTraHangHoa.Value);

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
                ChiTietTraHangGridControl.DataSource = _chiTietDoiTraHangHoas;
                ChiTietTraHangGridControl.RefreshDataSource();
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
                MaHoDonTextBox.Enabled = isEnabled;
                SearchHoaDonButton.Enabled = isEnabled;
                HangHoaLookupEdit.Enabled = isEnabled;
                KhoLookupEdit.Enabled = isEnabled;
                DonGiaNummeric.Enabled = isEnabled;
                SoLuongNummeric.Enabled = isEnabled;
                SoLuongTraLaiNummeric.Enabled = isEnabled;
                AddButton.Enabled = isEnabled;
                SaveButton.Enabled = isEnabled;
                EditButton.Enabled = isEnabled;
                DeleteButton.Enabled = isEnabled;
                TinhTrangTextBox.Enabled = isEnabled;
                ChietKhauNummeric.Enabled = isEnabled;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void SearchHoaDonButton_Click(object sender, EventArgs e)
        {
            try
            {
                _quanLyHoaDonForm = new QuanLyHoaDonForm(true);
                _quanLyHoaDonForm.ShowForm("OpenSeachHoaDon");
                _quanLyHoaDonForm.FormClosed += QuanLyHoaDonFormOnFormClosed;
           //     _chiTietDoiTraHangHoas = new List<CT_DoiTraHangHoa>();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void QuanLyHoaDonFormOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            try
            {
                _chiTietDoiTraHangHoas = new List<CT_DoiTraHangHoa>();
                _hoaDon = _quanLyHoaDonForm.HoaDon;
                if (DateTime.Now.Subtract(_hoaDon.NgayLap).Days > 3)
                {
                    MessageBox.Show(
                                    @"Không thể dổi hàng vì hóa đơn được mua quá 3 ngày",
                                    @"Thông Báo", MessageBoxButtons.OK);
                  
                }
                else
                {
                    MaHoDonTextBox.Text = _hoaDon.HoaDonId.ToString();
                    LoadHangHoa();
                }
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
                var chiTietHoaDon = _chiTietHoaDonService.GetByHoaDonId(_hoaDon.HoaDonId);
                _hangHoas = chiTietHoaDon.Where(_ => _.HangHoa.CoTheTraLai == true).Select(_ => _.HangHoa).ToList();

                HangHoaLookupEdit.Properties.Columns.Clear();
                HangHoaLookupEdit.Properties.DataSource = _hangHoas;
                HangHoaLookupEdit.Properties.DisplayMember = "TenHangHoa";
                HangHoaLookupEdit.Properties.ValueMember = "Id";
                HangHoaLookupEdit.Properties.Columns.Add(new LookUpColumnInfo("TenHangHoa"));

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
             /*   var xuatKhoIds =
                    _chiTietXuatKhoService.GetByHangHoaId(HangHoaLookupEdit.EditValue.ToString().ToLong())
                        .Select(_ => _.XuatKhoId).ToList();*/

               // var khos = _xuatKhoService.GetByXuatKhoIds(xuatKhoIds).Select(_ => _.Kho).ToList().Distinct().ToList();
                var khos = _chiTietNhapKhoService.GetKhos(HangHoaLookupEdit.EditValue.ToString().ToLong());
                LoadKho(khos);

                var chiTietHoaDons = _chiTietHoaDonService.GetByHoaDonId(_hoaDon.HoaDonId);
                var ctHoaDon = chiTietHoaDons.FirstOrDefault(_ => _.HangHoaId == HangHoaLookupEdit.EditValue.ToString().ToLong());
                if (ctHoaDon != null)
                {
                    SoLuongNummeric.Text = ctHoaDon.SoLuong.ToString(CultureInfo.InvariantCulture);
                    DonGiaNummeric.Text = ctHoaDon.DonGia.ToString(CultureInfo.InvariantCulture);
                }

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void LoadKho(IList<Model.Kho> khos)
        {
            try
            {
                KhoLookupEdit.Properties.Columns.Clear();
                KhoLookupEdit.Properties.DataSource = khos;
                KhoLookupEdit.Properties.DisplayMember = "TenKho";
                KhoLookupEdit.Properties.ValueMember = "Id";
                KhoLookupEdit.Properties.Columns.Add(new LookUpColumnInfo("TenKho"));
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
                if (_hoaDon != null)
                {
                    if (HangHoaLookupEdit.EditValue == null)
                    {
                        MessageBox.Show(
                                    @"Vui lòng chọn Hàng Hóa",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if(KhoLookupEdit.EditValue == null)
                    {
                        MessageBox.Show(
                                    @"Vui lòng chọn Kho",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (SoLuongTraLaiNummeric.Text.ToInt() <= 0)
                    {
                        MessageBox.Show(
                                    @"Số lượng trả lại phải lớn hơn 0",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (SoLuongTraLaiNummeric.Text.ToInt() > SoLuongNummeric.Text.ToInt())
                    {
                        MessageBox.Show(
                                    @"Số lượng trả lại phải bé hơn số lượng đặt mua",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if(string.IsNullOrEmpty(ChietKhauNummeric.Text))
                    {
                        MessageBox.Show(
                                    @"Vui lòng nhập số phần trăm chiết khấu",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (ChietKhauNummeric.Text.ToDecimal() < 0)
                    {
                        MessageBox.Show(
                                    @"Phần trăm chiết khấu phải lớn hơn 0",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (ChietKhauNummeric.Text.ToDecimal() > 100)
                    {
                        MessageBox.Show(
                                    @"Phần trăm chiết khấu phải bé hơn 100",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (
                        _chiTietDoiTraHangHoas.Any(
                            _ => _.HangHoaId == HangHoaLookupEdit.EditValue.ToString().ToLong()))
                    {
                        MessageBox.Show(
                                    @"Hàng Hóa đã có sẵn trong danh sách đổi trả Hàng Hóa",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        var chiTietDoiTraHangHoa = new CT_DoiTraHangHoa
                        {
                            DoiTraHangHoaId = _maDoiTraHangHoa.Value,
                            HangHoaId = HangHoaLookupEdit.EditValue.ToString().ToLong(),
                            SoLuong = SoLuongTraLaiNummeric.Text.ToInt(),
                            DonGia = DonGiaNummeric.Text.ToDecimal(),
                            TinhTrang = TinhTrangTextBox.Text,
                            ChietKhauPhanTram = ChietKhauNummeric.Text.ToDecimal(),
                            KhoId = KhoLookupEdit.EditValue.ToString().ToLong(),
  
                            TenKho = KhoLookupEdit.Text,
                            HangHoa = new Model.HangHoa
                            {
                                TenHangHoa = HangHoaLookupEdit.Text
                            
                            }
                        };

                        _chiTietDoiTraHangHoas.Add(chiTietDoiTraHangHoa);

                        ShowData();
                    }
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
                var chiTietDoiTraHangHoa = _selRow as CT_DoiTraHangHoa;
                var chiTietDoiTraHangHoaInList =
                    _chiTietDoiTraHangHoas.FirstOrDefault(_ => chiTietDoiTraHangHoa != null && _.HangHoaId == chiTietDoiTraHangHoa.HangHoaId);
                IList<CT_DoiTraHangHoa> chiTietDoiTraHangHoaTemp = _chiTietDoiTraHangHoas.ToList().Select(item => item.DeepCopy()).ToList();
                if (chiTietDoiTraHangHoaInList != null)
                {
                    chiTietDoiTraHangHoaTemp.Remove(chiTietDoiTraHangHoaTemp.FirstOrDefault(_ => chiTietDoiTraHangHoa != null && _.HangHoaId == chiTietDoiTraHangHoa.HangHoaId));
                    if (HangHoaLookupEdit.EditValue == null)
                    {
                        MessageBox.Show(
                                    @"Vui lòng chọn Hàng Hóa",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (KhoLookupEdit.EditValue == null)
                    {
                        MessageBox.Show(
                                    @"Vui lòng chọn Kho",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (SoLuongTraLaiNummeric.Text.ToInt() <= 0)
                    {
                        MessageBox.Show(
                                    @"Số lượng trả lại phải lớn hơn 0",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (SoLuongTraLaiNummeric.Text.ToInt() > SoLuongNummeric.Text.ToInt())
                    {
                        MessageBox.Show(
                                    @"Số lượng trả lại phải bé hơn số lượng đặt mua",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (string.IsNullOrEmpty(ChietKhauNummeric.Text))
                    {
                        MessageBox.Show(
                                    @"Vui lòng nhập số phần trăm chiết khấu",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (ChietKhauNummeric.Text.ToDecimal() < 0)
                    {
                        MessageBox.Show(
                                    @"Phần trăm chiết khấu phải lớn hơn 0",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (ChietKhauNummeric.Text.ToDecimal() > 100)
                    {
                        MessageBox.Show(
                                    @"Phần trăm chiết khấu phải bé hơn 100",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (
                        chiTietDoiTraHangHoaTemp.Any(
                            _ => _.HangHoaId == HangHoaLookupEdit.EditValue.ToString().ToLong()))
                    {
                        MessageBox.Show(
                                    @"Hàng Hóa đã có sẵn trong danh sách đổi trả Hàng Hóa",
                                    @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        _chiTietDoiTraHangHoas.Remove(chiTietDoiTraHangHoaInList);
                        chiTietDoiTraHangHoaInList.HangHoaId = HangHoaLookupEdit.EditValue.ToString().ToLong();
                        chiTietDoiTraHangHoaInList.SoLuong = SoLuongTraLaiNummeric.Text.ToInt();
                        chiTietDoiTraHangHoaInList.DonGia = DonGiaNummeric.Text.ToDecimal();
                        chiTietDoiTraHangHoaInList.TinhTrang = TinhTrangTextBox.Text;
                        chiTietDoiTraHangHoaInList.ChietKhauPhanTram = ChietKhauNummeric.Text.ToDecimal();
                        chiTietDoiTraHangHoaInList.KhoId = KhoLookupEdit.EditValue.ToString().ToLong();
                        chiTietDoiTraHangHoaInList.TenKho = KhoLookupEdit.Text;
                        chiTietDoiTraHangHoaInList.HangHoa = new Model.HangHoa
                        {
                            TenHangHoa = HangHoaLookupEdit.Text

                        };

                        _chiTietDoiTraHangHoas.Add(chiTietDoiTraHangHoaInList);

                        ShowData();
                    }
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ChiTietTraHangGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _selRow = ChiTietTraHangGridView.GetRow(e.FocusedRowHandle);

                var chiTietTraHang = _selRow as CT_DoiTraHangHoa;

                if (chiTietTraHang != null)
                {
                    HangHoaLookupEdit.EditValue = chiTietTraHang.HangHoaId;
                    KhoLookupEdit.EditValue = chiTietTraHang.KhoId;
                    SoLuongTraLaiNummeric.Text = chiTietTraHang.SoLuong.ToString(CultureInfo.InvariantCulture);
                    DonGiaNummeric.Text = chiTietTraHang.DonGia.ToString(CultureInfo.InvariantCulture);
                    TinhTrangTextBox.Text = chiTietTraHang.TinhTrang;
                    ChietKhauNummeric.Text = chiTietTraHang.ChietKhauPhanTram.ToString();
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
                var chiTietDoiTraHangHoa = _selRow as CT_DoiTraHangHoa;
                var chiTietDoiTraHangHoaInList =
                    _chiTietDoiTraHangHoas.FirstOrDefault(_ => chiTietDoiTraHangHoa != null && _.HangHoaId == chiTietDoiTraHangHoa.HangHoaId);

                if (chiTietDoiTraHangHoaInList != null)
                {
                    _chiTietDoiTraHangHoas.Remove(chiTietDoiTraHangHoaInList);

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
                // save Doi Tra Hang Hoa
                var doiTraHangHoa = new DoiTraHangHoa
                {
                    DoiTraHangHoaId = _maDoiTraHangHoa.Value,
                    HoaDonId = _hoaDon.HoaDonId,
                    NhanVienId = CurrentFormInfo.CurrentUserId,
                    NgayLap = DateTime.Now,
                    TongTienTraLai = _chiTietDoiTraHangHoas.Sum(_ => _.TongTienTraLai),
                    NgayChinhSua = DateTime.Now,
                    NguoiChinhSuaId = CurrentFormInfo.CurrentUserId,
                    HoatDong = true
                };

                _theKhachHangService = new TheKhachHangService(Entities);
                var theKhachHang = _theKhachHangService.GetByKhachHangId(_hoaDon.KhachHangId);
                var diemTichLuy = (int)doiTraHangHoa.TongTienTraLai / 100000;
                theKhachHang.DiemTichLuy = theKhachHang.DiemTichLuy - diemTichLuy;
                _theKhachHangService.Update(theKhachHang);


                doiTraHangHoa = _doiTraHangHoaService.Add(doiTraHangHoa);
                _doiTraHangHoaService.Save();

                // save chiTiet doi Tra Hang Hoa
                foreach (var chiTietDoiTraHangHoa in _chiTietDoiTraHangHoas)
                {
                    var chiTietDoiTraHangHoaToDatabase = new CT_DoiTraHangHoa
                    {
                        DoiTraHangHoaId = doiTraHangHoa.DoiTraHangHoaId,
                        HangHoaId = chiTietDoiTraHangHoa.HangHoaId,
                        SoLuong = chiTietDoiTraHangHoa.SoLuong,
                        DonGia = chiTietDoiTraHangHoa.DonGia,
                        TinhTrang = chiTietDoiTraHangHoa.TinhTrang,
                        ChietKhauPhanTram = chiTietDoiTraHangHoa.ChietKhauPhanTram,
                        KhoId = chiTietDoiTraHangHoa.KhoId
                    };

                    _chiTietDoiTraHangHoaService.Add(chiTietDoiTraHangHoaToDatabase);
                }

                _chiTietDoiTraHangHoaService.Save();

                // Update Ton kho
                foreach (var chiTietDoiTraHangHoa in _chiTietDoiTraHangHoas)
                {
                    var tonKho = _tonKhoService.GetByHangHoaIdKhoId(chiTietDoiTraHangHoa.HangHoaId, chiTietDoiTraHangHoa.KhoId.Value);
                    tonKho.SoLuongTon = tonKho.SoLuongTon + chiTietDoiTraHangHoa.SoLuong;

                    _tonKhoService.UpdateTonKho(tonKho);
                }

                _tonKhoService.Save();

                Close();
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
