﻿using System;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.KhachHang
{
    public partial class QuanLyHoaDonForm : QuanLySieuThiForm
    {
        private HoaDonService _hoaDonService;
        private ChiTietHoaDonService _chiTietHoaDonService;
        private HangHoaService _hangHoaService;

        private Object _selRow;

        public QuanLyHoaDonForm()
        {
            InitializeComponent();
            MinimumSizeWidth = 1003;
            MinimumSizeHeight = 602;
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);
            try
            {
                _hoaDonService = new HoaDonService(Entities);

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
                var hoaDons = _hoaDonService.GetAll();
                HoaDonGridControl.DataSource = hoaDons;
                HoaDonGridControl.RefreshDataSource();
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
                var chiTietHoaDonForm = new ChiTietHoaDonForm(null);
                chiTietHoaDonForm.ShowForm("OpenChiTietHoaDonForm");

                chiTietHoaDonForm.FormClosed += ChiTietHoaDonFormOnFormClosed;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void HoaDonGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _selRow = HoaDonGridView.GetRow(e.FocusedRowHandle);

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void HoaDonGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ViewButton_Click(sender,e);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                var hoaDon = _selRow as HoaDon;

                if (hoaDon != null)
                {
                    var chiTietHoaDonForm = new ChiTietHoaDonForm(hoaDon.HoaDonId);
                    chiTietHoaDonForm.ShowForm("ViewChiTietHoaDownForm");

                    chiTietHoaDonForm.FormClosed += ChiTietHoaDonFormOnFormClosed;
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }           
        }

        private void ChiTietHoaDonFormOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            try
            {
                ShowData();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var hoaDon = _selRow as HoaDon;
                if (hoaDon != null)
                {
                    if (DialogResult.Yes ==
                     MessageBox.Show(
                         string.Format("Bạn có muốn hủy Hóa Đơn với mã : {0}", hoaDon.HoaDonId),
                         @"Xác Nhận", MessageBoxButtons.YesNo))
                    {
                        hoaDon.HoatDong = false;
                        _hoaDonService.Update(hoaDon);
                        _hoaDonService.Save();

                        UpdateHangHoa(hoaDon.HoaDonId);

                        ShowData();
                    } 
                }
                
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void UpdateHangHoa(Guid hoaDonId)
        {
            try
            {
                _chiTietHoaDonService = new ChiTietHoaDonService(Entities);
                _hangHoaService = new HangHoaService(Entities);
                var chiTietHoaDons = _chiTietHoaDonService.GetByHoaDonId(hoaDonId);

                foreach (var chiTietHoaDon in chiTietHoaDons)
                {
                    var hangHoa = _hangHoaService.Get(chiTietHoaDon.HangHoaId);
                    hangHoa.SoLuongTonQuay = hangHoa.SoLuongTonQuay + chiTietHoaDon.SoLuong;
                    hangHoa.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                    hangHoa.NgayChinhSua = DateTime.Now;
                    _hangHoaService.Update(hangHoa);
                }

                _hangHoaService.Save();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}