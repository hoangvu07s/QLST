﻿using System;
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
        private readonly HangHoaService _hangHoaService;

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
            _hangHoaService = new HangHoaService(Entities);
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
                KhoLookupEdit.Properties.Columns.Clear();
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

        private void LoadHangHoa(IList<Model.HangHoa> hangHoas )
        {
            try
            {
                if (hangHoas == null || hangHoas.Count == 0)
                {
                   hangHoas = _chiTietDonHangService.GetHangHoas(new Guid(_donHangId)); 
                }  
                HangHoaLookupEdit.Properties.Columns.Clear();
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
        // khi chọn đc đơn hàng và form đơn hàng đóng , các chi tiết đơn hàng sẽ hiện trên form nhập kho .. chỉ lấy những hàng hóa chưa nhập đủ
        private void DonHangListFormOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            _donHangId = DonHangListForm.MaDonHang.ToString();
            MaDonHangTextBox.Text = _donHangId;
            
            var chiTietDonHangs = _chiTietDonHangService.GetByDonHangId(new Guid(_donHangId));

            _chiTietNhapKhos = new List<ChiTietNhapKho>();
            var hangHoas = new List<Model.HangHoa>();
            foreach (var chiTietDonHang in chiTietDonHangs)
            {
                var soLuongDaNhan = _nhapKhoService.GetSoluongNhapKho(new Guid(_donHangId), chiTietDonHang.HangHoaId);
                if (soLuongDaNhan < chiTietDonHang.SoLuong)
                {
                    hangHoas.Add(chiTietDonHang.HangHoa);// chỉ lấy những hàng hóa chưa nhập đủ hiển thị trên cbb
                    _chiTietNhapKhos.Add(new ChiTietNhapKho
                    {
                        HangHoaId = chiTietDonHang.HangHoaId,
                        SoLuong = chiTietDonHang.SoLuong - soLuongDaNhan,
                        TenHangHoa = chiTietDonHang.HangHoa.TenHangHoa,
                        SoluongDatHang = chiTietDonHang.SoLuong,
                        DonGia = chiTietDonHang.DonGia
                    });
                }                
            }

            LoadHangHoa(hangHoas);

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
            {// kiểm tra không để trống hàng hóa , kiểm tra số lượng nhập , ngày sản xuất, hạn sử dụng
                if (ValidateChiTietNhapKho())
                {
                    _chiTietNhapKhos.Add(new ChiTietNhapKho
                    {
                        HangHoaId = HangHoaLookupEdit.EditValue.ToString().ToLong(),
                        TenHangHoa = HangHoaLookupEdit.Text,
                        SoLuong = SoLuongNummeric.Text.ToInt(),
                        SoluongDatHang = SoLuongDatHangNummeric.Text.ToInt(),
                        DonGia = DonGiaNummeric.Text.ToDecimal(),
                        NgaySanXuat = (DateTime) NgaySanXuatDateEdit.EditValue,
                        HanSuDung = (DateTime) HanSuDungDateEdit.EditValue
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

                if (SoLuongNummeric.Text.ToInt() <= 0)
                {
                    MessageBox.Show(@"Vui lòng nhập số lượng Hàng Hóa lớn hơn 0", @"Thông Báo", MessageBoxButtons.OK);
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

                if (DonGiaNummeric.Text.ToDecimal() <= 0)
                {
                    MessageBox.Show(@"Đơn giá phải lớn hơn 0", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(NgaySanXuatDateEdit.Text))
                {
                    MessageBox.Show(@"Vui lòng nhập Ngày sản xuất", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(HanSuDungDateEdit.Text))
                {
                    MessageBox.Show(@"Vui lòng nhập Hạn Sử Dụng", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                var ngaySanXuat = (DateTime) NgaySanXuatDateEdit.EditValue;
                var hanSuDung = (DateTime) HanSuDungDateEdit.EditValue;
                if (ngaySanXuat.Date > hanSuDung.Date)
                {
                    MessageBox.Show(@"Ngày Sản Xuất phải bé hơn Hạn Sử Dụng", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (ngaySanXuat.Date > DateTime.Now)
                {
                    MessageBox.Show(@"Ngày sản xuất không được lớn hơn ngày hiện tại", @"Thông Báo",
                        MessageBoxButtons.OK);
                    return false;
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
                            chiTietNhapKho.DonGia = DonGiaNummeric.Text.ToDecimal();
                            chiTietNhapKho.NgaySanXuat = (DateTime) NgaySanXuatDateEdit.EditValue;
                            chiTietNhapKho.HanSuDung = (DateTime) HanSuDungDateEdit.EditValue;
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
                    DonGiaNummeric.Text = chiTietNhapKho.DonGia.ToString(CultureInfo.InvariantCulture);
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
            {// kiểm tra không để trống kho ,hàng hóa , số lượng..
                if (ValidateNhapKho())
                {// Lưu bảng nhập kho
                    var nhapKho = _nhapKhoService.Add();
                    nhapKho.PhieuNhapKhoId = new Guid(QuanLySieuThiHelper.NextId());
                    nhapKho.DonHangId = new Guid(MaDonHangTextBox.Text);
                    nhapKho.KhoId = KhoLookupEdit.EditValue.ToString().ToLong();
                    nhapKho.NgayTao = DateTime.Now;
                    nhapKho.NguoiTaoId = CurrentFormInfo.CurrentUserId;
                    nhapKho.HoatDong = true;

                    _nhapKhoService.Save();

                    // Lưu chi tiết nhập kho
                    foreach (var chiTietNhapKho in _chiTietNhapKhos)
                    {
                        var ctNhapKho = _chiTietNhapKhoService.Add();
                        ctNhapKho.NhapKhoId = nhapKho.PhieuNhapKhoId;
                        ctNhapKho.HangHoaId = chiTietNhapKho.HangHoaId;
                        ctNhapKho.SoLuong = chiTietNhapKho.SoLuong;
                        ctNhapKho.DonGia = chiTietNhapKho.DonGia;
                        ctNhapKho.NgaySanXuat = chiTietNhapKho.NgaySanXuat.Value;
                        ctNhapKho.HanSuDung = chiTietNhapKho.HanSuDung.Value;
                    }

                    _chiTietNhapKhoService.Save();
                    // update trạng thái của đơn hàng
                    var ctDonHangs = _chiTietDonHangService.GetByDonHangId(new Guid(MaDonHangTextBox.Text));
                    var soLuongInDonHang = ctDonHangs.Sum(_ => _.SoLuong);// sum tổng số lượng hàng hóa nhập vào
                    var nhapKhos = _nhapKhoService.Get(new Guid(MaDonHangTextBox.Text));// lấy tất cả các phiếu nhập kho trên đơn hàng Id
                    var soluongDaNhap = 0;
                    foreach (var kho in nhapKhos)
                    {
                        var ctNhapKhos = _chiTietNhapKhoService.Get(kho.PhieuNhapKhoId);// lấy chi tiết nhập kho của phiếu nhập kho tương ứng
                        soluongDaNhap = soluongDaNhap + ctNhapKhos.Sum(_ => _.SoLuong);// sum tổng số lượng đã nhập trên từng đơn hàng
                    }

                    var donHang = _donHangService.Get(new Guid(MaDonHangTextBox.Text));

                    if (soLuongInDonHang > soluongDaNhap)
                    {
                        donHang.TrangThaiDonHang = "Chưa Hoàn Thành";
                    }
                    else if(soLuongInDonHang == soluongDaNhap)
                    {
                        donHang.TrangThaiDonHang = "Hoàn Thành";
                    }

                    donHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                    donHang.NgayChinhSua = DateTime.Now;

                    _donHangService.Update(donHang);

                    _donHangService.Save();
                    // update tồn kho
                    foreach (var chiTietNhapKho in _chiTietNhapKhos)
                    {// lấy thông tin tồn kho của kho được chọn với hàng hóa tưng ứng trên từng dòng của GV _chiTietNhapKhos
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

                        tonKho.NgayTao = DateTime.Now;

                    }

                    _tonKhoService.Save();

        // update giá hàng hóa trong bảng HH
                    foreach (var chiTietNhapKho in _chiTietNhapKhos)
                    {
                        var hangHoa = _hangHoaService.Get(chiTietNhapKho.HangHoaId);
                        hangHoa.GiaNhapVao = chiTietNhapKho.DonGia;

                        _hangHoaService.Update(hangHoa);
                    }
                    
                    _hangHoaService.Save();

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

                if (_chiTietNhapKhos.Any(_ => _.SoLuong <= 0))
                {
                    MessageBox.Show(@"Số lượng nhập kho phải lớn hơn 0", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (_chiTietNhapKhos.Any(_ => _.DonGia <= 0))
                {
                    MessageBox.Show(@"Đơn giá nhập kho phải lớn hơn 0", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (_chiTietNhapKhos.Any(_ => _.NgaySanXuat == null || _.HanSuDung == null))
                {
                    MessageBox.Show(@"Vui lòng thêm ngày sản xuất và hạn sử dụng", @"Thông Báo", MessageBoxButtons.OK);
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
