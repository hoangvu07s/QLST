﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
        private readonly XuatKhoService _xuatKhoService;
        private readonly ChiTietXuatKhoService _chiTietXuatKhoService;
        private readonly HangHoaService _hangHoaService;

        private IList<ChiTietXuatKho> _chiTietXuatKhos;
        private object _selRow;
        private bool _isSelected = false;
        private long _khoId;

        public XuatKhoEditForm()
        {
            InitializeComponent();
            MinimumSizeWidth = 782;
            MinimumSizeHeight = 447;

            _khoHangService = new KhoHangService(Entities);
            _nhapKhoService = new NhapKhoService(Entities);
            _chiTietNhapKhoService = new ChiTietNhapKhoService(Entities);
            _tonKhoService = new TonKhoService(Entities);
            _xuatKhoService = new XuatKhoService(Entities);
            _chiTietXuatKhoService = new ChiTietXuatKhoService(Entities);
            _hangHoaService = new HangHoaService(Entities);        
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
                KhoHangLookupEdit.Properties.Columns.Clear();
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
                HangHoaLookupEdit.Properties.Columns.Clear();
                HangHoaLookupEdit.Properties.Columns.Add(new LookUpColumnInfo("TenHangHoa"));
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
        // sau khi chạy LoadKhoHang trước sẽ chạy hamf KhoHangLookup để lấy những hàng hóa thuộc kho này,
        private void KhoHangLookupEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_chiTietXuatKhos.Count == 0)
                {
                    _isSelected = false;
                }

                if (_isSelected)
                {
                    _isSelected = false;
                    MessageBox.Show(@"Chỉ được xuất cho một kho Hàng duy nhất", @"Thông Báo", MessageBoxButtons.OK);

                    KhoHangLookupEdit.EditValue = _khoId;

                    _isSelected = true;
                }
                else
                {
                    IList<Model.HangHoa> hangHoas = new List<Model.HangHoa>();
                    var khoId = KhoHangLookupEdit.EditValue.ToString().ToLong();// lấy giá trị KhoId
                    var nhapKhos = _nhapKhoService.Get(khoId);// lấy các phiếu nhập kho của kho này.
                    foreach (var nhapKho in nhapKhos)
                    {
                        var chiTietNhapKhos = _chiTietNhapKhoService.Get(nhapKho.PhieuNhapKhoId);// lấy chi tiết của từng phiếu nhập kho của kho này
                        foreach (var chiTietNhapKho in chiTietNhapKhos)
                        {
                            hangHoas.Add(chiTietNhapKho.HangHoa);// trên từng chi tiết add hàng hóa vào
                        }
                    }

                    LoadHangHoa(hangHoas.Distinct().ToList());

                    _khoId = khoId;
                }
                
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

                var tonKho = _tonKhoService.Get(khoId, hangHoaId);// lấy thông tin tồn khi của hàng hóa tương ứng trong kho tương ứng

                SoLuongTonKhoNummeric.Text = tonKho.SoLuongTon.ToString();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
        // button thêm vào gridview
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

                    _isSelected = true;
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

        private bool ValidateChiTietXuatKho(bool isUpdate = false)
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

                if (SoLuongXuatKhoNummeric.Text.ToInt() <= 0)
                {
                    MessageBox.Show(@"Số lượng xuất kho phải lớn hơn 0", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }

                if (SoLuongXuatKhoNummeric.Text.ToInt() > SoLuongTonKhoNummeric.Text.ToInt())
                {
                    MessageBox.Show(@"Số lượng xuất kho phải bé hơn hoặc bằng số lượng tồn kho", @"Thông Báo", MessageBoxButtons.OK);
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
        // sửa : chỉ sửa số lượng
        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChiTietXuatKho(true))
                {
                    var chiTietXuatKho = _selRow as ChiTietXuatKho;
                    if (chiTietXuatKho != null)
                    {
                        chiTietXuatKho = _chiTietXuatKhos.FirstOrDefault(_ => _.HangHoaId == chiTietXuatKho.HangHoaId);
                        if (chiTietXuatKho != null)
                        {
                            chiTietXuatKho.SoLuong = SoLuongXuatKhoNummeric.Text.ToInt();

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

        private void CTXuatKhoGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _selRow = CTXuatKhoGridView.GetRow(e.FocusedRowHandle);

                var chiTietXuatKho = _selRow as ChiTietXuatKho;
                if (chiTietXuatKho != null)
                {
                    HangHoaLookupEdit.EditValue = chiTietXuatKho.HangHoaId;
                    SoLuongXuatKhoNummeric.Text = chiTietXuatKho.SoLuong.ToString(CultureInfo.InvariantCulture);

                    _isSelected = true;
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
                var chiTietXuatKho = _selRow as ChiTietXuatKho;
                _chiTietXuatKhos.Remove(chiTietXuatKho);

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
                if (ValidateXuatKho())// kiểm tra chọn kho
                {// lưu thông tin vào xuất kho
                    var xuatKho = _xuatKhoService.Add();
                    xuatKho.PhieuXuatKhoId = new Guid(QuanLySieuThiHelper.NextId());
                    xuatKho.KhoId = KhoHangLookupEdit.EditValue.ToString().ToLong();
                    xuatKho.NhanVienId = CurrentFormInfo.CurrentUserId;
                    xuatKho.NgayXuat = DateTime.Now;
                    xuatKho.HoatDong = true;

                    _xuatKhoService.Save();
                    // lưu chi tiết xuất kho của từng phiếu xuất
                    foreach (var chiTietXuatKho in _chiTietXuatKhos)
                    {
                        var ctXuatKho = _chiTietXuatKhoService.Add();
                        ctXuatKho.XuatKhoId = xuatKho.PhieuXuatKhoId;
                        ctXuatKho.HangHoaId = chiTietXuatKho.HangHoaId;
                        ctXuatKho.SoLuong = chiTietXuatKho.SoLuong;
                        // update tòn kho của từng mặt hàng
                        var tonKho = _tonKhoService.Get(KhoHangLookupEdit.EditValue.ToString().ToLong(),
                            chiTietXuatKho.HangHoaId);
                        tonKho.SoLuongTon = tonKho.SoLuongTon - ctXuatKho.SoLuong;
                        tonKho.NgayTao = DateTime.Now;

                        _tonKhoService.UpdateTonKho(tonKho);
                        // up date số lượng tồn quầy
                        var hangHoa = _hangHoaService.Get(chiTietXuatKho.HangHoaId);
                        if (!hangHoa.SoLuongTonQuay.HasValue)
                        {
                            hangHoa.SoLuongTonQuay = 0;
                        }
                        hangHoa.SoLuongTonQuay = hangHoa.SoLuongTonQuay + ctXuatKho.SoLuong;
                        _hangHoaService.Update(hangHoa);
                    }

                    _chiTietXuatKhoService.Save();
                    _tonKhoService.Save();
                    _hangHoaService.Save();

                    Close();
                }
                
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public bool ValidateXuatKho()
        {
            try
            {
                if (_chiTietXuatKhos.Count <= 0)
                {
                    MessageBox.Show(@"Vui lòng nhập hàng hóa", @"Thông Báo", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return true;
        }
    }
}
