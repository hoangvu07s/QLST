﻿using System;
using System.Linq;
using System.Windows.Forms;
using Helper;
using Service;

namespace QuanLySieuThi.HangHoa
{
    public partial class HangHoaListForm
    {
        private HangHoaService _hangHoaService;
        private Object _selRow;
        private bool _isSearched;

        public static Model.HangHoa HangHoa;
        public HangHoaListForm(bool isSearched = false)
        {
            InitializeComponent();

            MinimumSizeWidth = 694;
            MinimumSizeHeight = 279;
            _isSearched = isSearched;
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);
            try
            {
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
                _hangHoaService = new HangHoaService(Entities);
                var hangHoas = _hangHoaService.GetAll();

                HangHoaGridControl.DataSource = hangHoas;
                HangHoaGridControl.RefreshDataSource();

                if (_isSearched)
                {
                    AddButton.Enabled = false;
                    DeleteButton.Enabled = false;
                }
                else
                {
                    SelectButton.Enabled = false;
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _selRow as Model.HangHoa;
                if (selRow != null)
                {
                    
                    var hangHoa = _hangHoaService.Get(selRow.Id);
                    if (hangHoa != null)
                    {
                        if (hangHoa.SoLuongTonQuay == null)
                        {
                            hangHoa.SoLuongTonQuay = 0;
                        }
                        if (hangHoa.SoLuongTonQuay != 0 ||                           
                            hangHoa.TonKhoes.Any(_=>_.SoLuongTon != 0))
                        {
                            MessageBox.Show(
                            @"Số lượng hàng hóa này hiện đang còn số lượng tồn. Bạn không thể xóa",
                            @"Thông Báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (DialogResult.Yes ==
                                    MessageBox.Show(string.Format("Bạn có muốn xóa hàng hóa '{0}' ?", selRow.TenHangHoa),
                                        @"Xác nhận", MessageBoxButtons.YesNo))
                            {
                                _hangHoaService.Delete(selRow.Id);
                                _hangHoaService.Save();
                                ShowData();
                            }
                        }
                    }                   
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
                var hangHoaEditForm = new HangHoaEditForm(null);
                hangHoaEditForm.ShowForm("AddHangHoa");
                hangHoaEditForm.FormClosed += HangHoaEditFormOnFormClosed;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void HangHoaEditFormOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _selRow as Model.HangHoa;
                if (selRow != null)
                {
                    var hangHoaEditForm = new HangHoaEditForm(selRow.Id);
                    hangHoaEditForm.ShowForm(string.Format("EditHangHoa {0}", selRow.Id));
                    hangHoaEditForm.FormClosed += HangHoaEditFormOnFormClosed;
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            AcceptAndSavechange();
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            EditButton_Click(sender,e);
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _selRow = GridView1.GetRow(e.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoa = _selRow as Model.HangHoa;

                Close();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            try
            {
                HangHoa = _selRow as Model.HangHoa;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
