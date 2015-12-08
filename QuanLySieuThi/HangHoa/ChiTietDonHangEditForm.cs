using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Common.Forms;
using DevExpress.XtraEditors.Controls;
using Helper;
using Helper.ValueObjects;
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
        private Model.HangHoa hangHoa;

        private object _selRow;

        public ChiTietDonHangEditForm(string donHangId)// nếu xem chi tiết sẽ có DonHangId truyền vào , nếu thêm mới DonHangId = null
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
                if (string.IsNullOrEmpty(EntityId))
                {
                    _chiTietDonHangs = new List<ChiTietDonHang>();
                    FormMode = FormMode.Add;
                }
                else
                {
                    FormMode = FormMode.View;
                }

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
                    MaDonHangTextBox.Text = QuanLySieuThiHelper.NextId();// Guid.New()

                    EntityId = MaDonHangTextBox.Text;
                }
                else
                {
                    MaDonHangTextBox.Text = EntityId; // Mã được gửi qua
                }

                if (FormMode == FormMode.View)
                {
                    _chiTietDonHangs = new List<ChiTietDonHang>();
                    var chiTietDonHangsInDatabase = _chiTietDonHangService.GetByDonHangId(new Guid(EntityId));
                    foreach (var ctDonHang in chiTietDonHangsInDatabase)
                    {
                        _chiTietDonHangs.Add(new ChiTietDonHang
                        {
                            DonGia = ctDonHang.DonGia,
                            LoaiHangHoaId = ctDonHang.HangHoa.LoaiHangHoaId,
                            MaDonHang = ctDonHang.DonHangId.ToString(),
                            NhaCungCapId = ctDonHang.HangHoa.NhaCungCapId,
                            QuayHangId = ctDonHang.HangHoa.QuayHangId,
                            SoLuong = ctDonHang.SoLuong,
                            TenHangHoa = ctDonHang.HangHoa.TenHangHoa,
                            TenLoaiHangHoa = ctDonHang.HangHoa.LoaiHangHoa.TenLoaiHangHoa,
                            TenNhaCungCap = ctDonHang.HangHoa.NhaCungCap.TenNhaCungCap,
                            TenQuayHang = ctDonHang.HangHoa.QuayHang.TenQuay
                        });
                    }

                    LoadGridData();// gán gridview = _chiTietDonHang
                    var donHang = _donHangService.Get(new Guid(EntityId));// xem chi tiết của những đơn hàng có mã là EntityId co trạng thái "đang chờ", thì cho phép sửa số lượng , đơn giá
                    if (donHang.TrangThaiDonHang != "Đang Chờ")
                    {
                        DisableControl();
                    }
                    else
                    {
                        DeleteButton.Enabled = false;// chỉ hiện button cập nhật khi đơn hàng có trạng thái đang chờ.
                        AddButton.Enabled = false;
                        SearchTenHangHoaButton.Enabled = false;
                    }
                }

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void DisableControl()
        {
            DeleteButton.Enabled = false;
            AddButton.Enabled = false;
            EditButton.Enabled = false;
            SearchTenHangHoaButton.Enabled = false;
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

        private bool ValidateInput()// kiểm tra không được để trống thông tin
        {
            try
            {
                var isValidedValue = true;
                if (string.IsNullOrEmpty(TenHangHoaTextBox.Text))
                {
                    MessageBox.Show(@"Vui lòng chọn hàng hóa.", @"Thong Bao", MessageBoxButtons.OK);
                    isValidedValue = false;
                }
                else if (string.IsNullOrEmpty(NhaCungCapLookupEdit.Text))
                {
                    MessageBox.Show(@"Vui lòng chọn nhà cung cấp.", @"Thong Bao", MessageBoxButtons.OK);
                    isValidedValue = false;
                }
                else if (string.IsNullOrEmpty(QuayHangLookupEdit.Text))
                {
                    MessageBox.Show(@"Vui lòng chọn quầy hàng.", @"Thong Bao", MessageBoxButtons.OK);
                    isValidedValue = false;
                }
                else if (string.IsNullOrEmpty(LoaiHangHoaLookupEdit.Text))
                {
                    MessageBox.Show(@"Vui lòng chọn loại hàng hóa.", @"Thong Bao", MessageBoxButtons.OK);
                    isValidedValue = false;
                }
                else if (string.IsNullOrEmpty(SoLuongNummeric.Text))
                {
                    MessageBox.Show(@"Vui lòng nhập số lượng.", @"Thong Bao", MessageBoxButtons.OK);
                    isValidedValue = false;
                }
                else if (string.IsNullOrEmpty(DonGiaNummeric.Text))
                {
                    MessageBox.Show(@"Vui lòng nhập đơn giá.", @"Thong Bao", MessageBoxButtons.OK);
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
                            MessageBox.Show(@"Tên hàng hóa, Loại hàng hóa, Nhà cung cấp đã tồn tại trong đơn hàng.",
                                @"Thong Bao",
                                MessageBoxButtons.OK);
                            isValidated = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Hàng hóa phải có loại hàng hóa như trong chi tiết đơn hàng.",
                            @"Thong Bao",
                            MessageBoxButtons.OK);
                        isValidated = false;
                    }

                }

                if (_chiTietDonHangs.Count(_ => _.TenNhaCungCap == nhaCungCap) < _chiTietDonHangs.Count)
                {
                    MessageBox.Show(@"Chỉ cho phép lập đơn hàng với một Nhà cung cấp.",
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
                if (soLuong.ToInt() <= 0)
                {
                    MessageBox.Show(@"Số lượng phải lớn hơn 0", @"Thong Bao",
                        MessageBoxButtons.OK);

                    isValidated = false;
                }
                else if (donGia.ToDecimal() <= 0)
                {
                    MessageBox.Show(@"Đơn giá phải lớn hơn 0", @"Thong Bao",
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

                bool isValidated = ValidateInput();// kiểm tra không được để trống thông tin, ban đầu đc khai báo  = true

                if (isValidated)
                {// không cho chọn hàng hóa khác loại hàng.
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
                    _chiTietDonHangs.Add(chiTietDonHang);// add lần lượt từng chi tiết đơn hàng mỗi lần nhập vào  để đổ vào gridview

                    LoadGridData();
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private ChiTietDonHang InitChiTietDonHang()// lấy thông tin của hàng hóa đặt mua trên các control
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
                if (ValidateInput() && chiTietDonHang != null)// kiểm tra dữ liệu không bị trống
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
                    var chiTietDonHangTemp = _chiTietDonHangs.FirstOrDefault(_ => _.TenHangHoa == chiTietDonHang.TenHangHoa);
                    _chiTietDonHangs.Remove(chiTietDonHangTemp);// remove dòng được chọn để sửa , 
                    chiTietDonHang = InitChiTietDonHang();
                    _chiTietDonHangs.Add(chiTietDonHang);// add lại thông tin mới sửa 

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
                if (_chiTietDonHangs.Count > 0)
                {
                    
                    var currentDateTime = DateTime.Now;
                    var donHang = _donHangService.Get(new Guid(EntityId));
                    if (donHang != null)
                    {
                        donHang.NgayChinhSua = currentDateTime;
                        donHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                        foreach (var chiTietDonHang in _chiTietDonHangs)// ứng với mỗi dòng trên gridview
                        {
                            var hanghoaInDatabase = _hangHoaService.GetByTenHangHoa(chiTietDonHang.TenHangHoa);// lấy thông tin hàng hóa trong bảng hàng hóa
                            var ctDonHang = _chiTietDonHangService.Get(new Guid(EntityId), hanghoaInDatabase.Id);//lấy chi tiết của hàng ID trên hóa đơn ID
                            ctDonHang.SoLuong = chiTietDonHang.SoLuong;
                            ctDonHang.DonGia = chiTietDonHang.DonGia;
                            _chiTietDonHangService.Update(ctDonHang);
                            _chiTietDonHangService.Save();

                            hanghoaInDatabase.GiaNhapVao = ctDonHang.DonGia; // chỉnh sửa giá nhập vào trên đơn hàng của hàng hóa

                            _hangHoaService.Update(hanghoaInDatabase);
                            _hangHoaService.Save();
                        }
                    }
                    else
                    {
                        // Save Don Hang
                        donHang = _donHangService.AddDonHang();
                        donHang.DonHangId = new Guid(_chiTietDonHangs.First().MaDonHang);
                        donHang.NhaCungCapId = _chiTietDonHangs.First().NhaCungCapId;
                        donHang.TrangThaiDonHang = "Đang Chờ";
                        donHang.NgayChinhSua = currentDateTime;
                        donHang.NgayTao = currentDateTime;
                        donHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                        donHang.NguoiTaoId = CurrentFormInfo.CurrentUserId;
                        donHang.HoatDong = true;

                        _donHangService.Save();

                        // Save Hang Hoa
                        foreach (var chiTietDonHang in _chiTietDonHangs)
                        {
                            var hanghoaInDatabase = _hangHoaService.GetByTenHangHoa(chiTietDonHang.TenHangHoa);

                            // Save Chi Tiet Don Hang
                            var ctDonHang = _chiTietDonHangService.AddChiTietDonHang();
                            ctDonHang.HangHoaId = hanghoaInDatabase.Id;
                            ctDonHang.DonHangId = new Guid(_chiTietDonHangs.First().MaDonHang);
                            ctDonHang.SoLuong = chiTietDonHang.SoLuong;
                            ctDonHang.DonGia = chiTietDonHang.DonGia;
                            _chiTietDonHangService.Save();
                            // không sử dụng
                            hanghoaInDatabase.GiaNhapVao = ctDonHang.DonGia;

                            _hangHoaService.Update(hanghoaInDatabase);
                            _hangHoaService.Save();
                        }
                    }
                    
                }
                
                Close();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void SearchTenHangHoaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var hangHoaListForm = new HangHoaListForm(true);
                hangHoaListForm.ShowForm("OpenHangHoaListForm");
                hangHoaListForm.FormClosed += HangHoaListFormOnFormClosed;
              /*  var QuanLyHangHoaForm = new QuanLyHangHoaForm(true);
                QuanLyHangHoaForm.ShowForm("OpenQuanLyHangHoaForm");
                QuanLyHangHoaForm.FormClosed += HangHoaListFormOnFormClosed;*/
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
        // load thông tin lên các control
        private void HangHoaListFormOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            try
            {
                hangHoa = HangHoaListForm.HangHoa;
               // hangHoa = QuanLyHangHoaForm.HangHoa;
                TenHangHoaTextBox.Text = hangHoa.TenHangHoa;
                LoaiHangHoaLookupEdit.EditValue = hangHoa.LoaiHangHoaId;
                NhaCungCapLookupEdit.EditValue = hangHoa.NhaCungCapId;
                QuayHangLookupEdit.EditValue = hangHoa.QuayHangId;
                DonGiaNummeric.Text = hangHoa.GiaNhapVao.ToString(CultureInfo.InvariantCulture);}
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
