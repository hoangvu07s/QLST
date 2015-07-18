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

namespace QuanLySieuThi.HangHoa
{
    public partial class ChiTietDonHangEditForm
    {
        private DonHangService _donHangService;
        private HangHoaService _hangHoaService;
        private ChiTietDonHangService _chiTietDonHangService;
        private LoaiHangHoaService _loaiHangHoaService;
        private NhaCungCapService _nhaCungCapService;
        private QuayHangService _quayHangService;
        private IList<ChiTietDonHang> _chiTietDonHangs; 

        private object _selRow;

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
                    FormMode = FormMode.Add;
                }
                else
                {
                    FormMode = FormMode.View;
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
                _hangHoaService = new HangHoaService(Entities);
                _loaiHangHoaService = new LoaiHangHoaService(Entities);
                _nhaCungCapService = new NhaCungCapService(Entities);
                _quayHangService = new QuayHangService(Entities);
                _chiTietDonHangService = new ChiTietDonHangService(Entities);

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

        private bool ValidateInput()
        {
            try
            {
                var isValidedValue = true;
                if (string.IsNullOrEmpty(TenHangHoaTextBox.Text))
                {
                    MessageBox.Show(@"Vui long nhap Ten Hang Hoa", @"Thong Bao", MessageBoxButtons.OK);
                    isValidedValue = false;
                }
                else if (string.IsNullOrEmpty(NhaCungCapLookupEdit.Text))
                {
                    MessageBox.Show(@"Vui long chon Nha Cung Cap", @"Thong Bao", MessageBoxButtons.OK);
                    isValidedValue = false;
                }
                else if (string.IsNullOrEmpty(QuayHangLookupEdit.Text))
                {
                    MessageBox.Show(@"Vui long chon Quay Hang", @"Thong Bao", MessageBoxButtons.OK);
                    isValidedValue = false;
                }
                else if (string.IsNullOrEmpty(LoaiHangHoaLookupEdit.Text))
                {
                    MessageBox.Show(@"Vui long chon Loai Hang Hoa", @"Thong Bao", MessageBoxButtons.OK);
                    isValidedValue = false;
                }
                else if (string.IsNullOrEmpty(SoLuongNummeric.Text))
                {
                    MessageBox.Show(@"Vui long nhap So Luong", @"Thong Bao", MessageBoxButtons.OK);
                    isValidedValue = false;
                }
                else if (string.IsNullOrEmpty(DonGiaNummeric.Text))
                {
                    MessageBox.Show(@"Vui long nhap Don Gia", @"Thong Bao", MessageBoxButtons.OK);
                    isValidedValue = false;
                }

                return isValidedValue;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);

                return false;
            }
        }

        private bool ValidateTenHangHoaLoaiHangHoaNhaCungCap(string tenHangHoa, string loaiHang, string nhaCungCap)
        {
            try
            {
                var isValidated = true;
                var hangHoas = _chiTietDonHangs.Where(_ => _.TenHangHoa == tenHangHoa).ToList();
                if (hangHoas.Count > 0)
                {
                     
                    if (hangHoas.Count(_ => _.TenLoaiHangHoa == loaiHang) > 0)
                    {
                        if (hangHoas.Count(
                            _ =>
                                _.TenHangHoa == tenHangHoa && _.TenNhaCungCap == nhaCungCap &&
                                _.TenLoaiHangHoa == loaiHang) > 0)
                        {
                            MessageBox.Show(@"Ten Hang Hoa, Loai Hang Hoa, Nha Cung Cap da ton tai trong don hang",
                                @"Thong Bao",
                                MessageBoxButtons.OK);
                            isValidated = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Hang Hoa phai co Loai Hang hoa nhu trong chi tiet don hang",
                            @"Thong Bao",
                            MessageBoxButtons.OK);
                        isValidated = false;
                    }

                }

                if (_chiTietDonHangs.Count(_ => _.TenNhaCungCap == nhaCungCap) < _chiTietDonHangs.Count)
                {
                    MessageBox.Show(@"Chi cho phep lap don hang voi mot nha cung cap",
                            @"Thong Bao",
                            MessageBoxButtons.OK);
                    isValidated = false;
                }

                return isValidated;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);

                return false;
            }
        }

        private bool ValidateSoLuongDonGia(string soLuong, string donGia)
        {
            try
            {
                var isValidated = true;
                if (soLuong.ToInt() == 0)
                {
                    MessageBox.Show(@"So luong phai lon hon 0", @"Thong Bao",
                        MessageBoxButtons.OK);

                    isValidated = false;
                }
                else if (donGia.ToDecimal() == 0)
                {
                    MessageBox.Show(@"Don gia phai lon hon 0", @"Thong Bao",
                        MessageBoxButtons.OK);

                    isValidated = false;
                }

                return isValidated;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);

                return false;
            }
        }

        private bool ValidateChiTietDonHang()
        {
            try
            {
                var tenHangHoa = TenHangHoaTextBox.Text;
                var loaiHang = LoaiHangHoaLookupEdit.Text;
                var nhaCungCap = NhaCungCapLookupEdit.Text;
                var soLuong = SoLuongNummeric.Text;
                var donGia = DonGiaNummeric.Text;

                bool isValidated = ValidateInput();

                if (isValidated)
                {
                    isValidated = ValidateTenHangHoaLoaiHangHoaNhaCungCap(tenHangHoa, loaiHang, nhaCungCap);

                    if (isValidated)
                    {
                        isValidated = ValidateSoLuongDonGia(soLuong, donGia);
                    }
                }

                return isValidated;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);

                return false;
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChiTietDonHang())
                {
                    var chiTietDonHang = InitChiTietDonHang();
                    _chiTietDonHangs.Add(chiTietDonHang);

                    LoadGridData();
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private ChiTietDonHang InitChiTietDonHang()
        {
            var chiTietDonHang = new ChiTietDonHang
            {
                DonGia = DonGiaNummeric.Text.ToDecimal(),
                LoaiHangHoaId = LoaiHangHoaLookupEdit.EditValue.ToString().ToLong(),
                MaDonHang = MaDonHangTextBox.Text,
                NhaCungCapId = NhaCungCapLookupEdit.EditValue.ToString().ToLong(),
                QuayHangId = QuayHangLookupEdit.EditValue.ToString().ToLong(),
                SoLuong = SoLuongNummeric.Text.ToInt(),
                TenHangHoa = TenHangHoaTextBox.Text,
                TenLoaiHangHoa = LoaiHangHoaLookupEdit.Text,
                TenNhaCungCap = NhaCungCapLookupEdit.Text,
                TenQuayHang = QuayHangLookupEdit.Text
            };

            return chiTietDonHang;
        }

        private void LoadGridData()
        {
            try
            {
                ChiTietDonHangGridControl.DataSource = _chiTietDonHangs;
                ChiTietDonHangGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ChiTietDonHangGridView_FocusedRowChanged(object sender,
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _selRow = ChiTietDonHangGridView.GetRow(e.FocusedRowHandle);

                var chiTietDonHang = _selRow as ChiTietDonHang;
                if (chiTietDonHang != null)
                {
                    LoadDataToControls(chiTietDonHang);
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
                var chiTietDonHang = _selRow as ChiTietDonHang;
                if (chiTietDonHang != null)
                {
                    _chiTietDonHangs.Remove(chiTietDonHang);
                    LoadGridData();
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void LoadDataToControls(ChiTietDonHang chiTietDonHang)
        {
            TenHangHoaTextBox.Text = chiTietDonHang.TenHangHoa;
            LoaiHangHoaLookupEdit.EditValue = chiTietDonHang.LoaiHangHoaId;
            NhaCungCapLookupEdit.EditValue = chiTietDonHang.NhaCungCapId;
            QuayHangLookupEdit.EditValue = chiTietDonHang.QuayHangId;
            SoLuongNummeric.Text = chiTietDonHang.SoLuong.ToString(CultureInfo.InvariantCulture);
            DonGiaNummeric.Text = chiTietDonHang.DonGia.ToString(CultureInfo.InvariantCulture);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                var tenHangHoa = TenHangHoaTextBox.Text;
                var loaiHang = LoaiHangHoaLookupEdit.Text;
                var nhaCungCap = NhaCungCapLookupEdit.Text;
                var soLuong = SoLuongNummeric.Text;
                var donGia = DonGiaNummeric.Text;
                var isValidated = true;
                var chiTietDonHang = _selRow as ChiTietDonHang;
                if (ValidateInput() && chiTietDonHang != null)
                {
                    if (chiTietDonHang.TenHangHoa != tenHangHoa || chiTietDonHang.TenLoaiHangHoa != loaiHang ||
                        chiTietDonHang.TenNhaCungCap != nhaCungCap)
                    {
                        isValidated = ValidateTenHangHoaLoaiHangHoaNhaCungCap(tenHangHoa, loaiHang, nhaCungCap);
                    }
                    else
                    {
                        isValidated = ValidateSoLuongDonGia(soLuong, donGia);
                    }
                }
                if (isValidated)
                {
                    _chiTietDonHangs.Remove(chiTietDonHang);
                    chiTietDonHang = InitChiTietDonHang();
                    _chiTietDonHangs.Add(chiTietDonHang);

                    LoadGridData();
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

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Save Hang Hoa
                var hangHoas = new List<Model.HangHoa>();
                foreach (var chiTietDonHang in _chiTietDonHangs)
                {
                    var hangHoa = _hangHoaService.GetByTenHangHoaLoaiHangHoaNhaCungCap(chiTietDonHang.TenHangHoa,
                        chiTietDonHang.LoaiHangHoaId, chiTietDonHang.NhaCungCapId);
                    if (hangHoa == null)
                    {
                        hangHoa = _hangHoaService.AddHangHoa();
                        hangHoa.TenHangHoa = chiTietDonHang.TenHangHoa;
                        hangHoa.LoaiHangHoaId = chiTietDonHang.LoaiHangHoaId;
                        hangHoa.NhaCungCapId = chiTietDonHang.NhaCungCapId;
                        hangHoa.QuayHangId = chiTietDonHang.QuayHangId;
                        hangHoa.GiaNhapVao = chiTietDonHang.DonGia;
                        hangHoa.GiaBanRa = 0;
                        hangHoa.NgayChinhSua = DateTime.Now;
                        hangHoa.NgayTao = DateTime.Now;
                        hangHoa.NguoiChinhSuaId = CurrentUserId;
                        hangHoa.NguoiTaoId = CurrentUserId;
                        hangHoa.HoatDong = true;

                        hangHoas.Add(hangHoa);
                    }                    
                }

                // Save Don Hang
                var donHang = _donHangService.AddDonHang();
                donHang.DonHangId = new Guid(_chiTietDonHangs.First().MaDonHang);
                donHang.NhaCungCapId = _chiTietDonHangs.First().NhaCungCapId;
                donHang.TrangThaiDonHang = "Dang Cho";
                donHang.NgayChinhSua = DateTime.Now;
                donHang.NgayTao = DateTime.Now;
                donHang.NguoiChinhSuaId = CurrentUserId;
                donHang.NguoiTaoId = CurrentUserId;

                // Save Chi Tiet Don Hang
                foreach (var hangHoa in hangHoas)
                {
                    var chiTietDonHang = _chiTietDonHangService.AddChiTietDonHang();
                    chiTietDonHang.HangHoaId = hangHoa.Id;
                    chiTietDonHang.DonHangId = new Guid(_chiTietDonHangs.First().MaDonHang);
                }

                _hangHoaService.Save();
                _donHangService.Save();
                _chiTietDonHangService.Save();

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

    }
}
