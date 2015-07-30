using System;
using System.Windows.Forms;
using Helper;
using Service;

namespace QuanLySieuThi.HangHoa
{
    public partial class HangHoaListForm
    {
        private HangHoaService _hangHoaService;
        private Object _selRow;
        public HangHoaListForm()
        {
            InitializeComponent();

            MinimumSizeWidth = 694;
            MinimumSizeHeight = 279;
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
                        if (hangHoa.CT_DoiTraHangHoa.Count > 0 ||
                            hangHoa.CT_DonHang.Count > 0 ||
                            hangHoa.CT_HoaDon.Count > 0 ||
                            hangHoa.CT_NhapKho.Count > 0 ||
                            hangHoa.CT_PhieuTraQuayHang.Count > 0 ||
                            hangHoa.CT_XuatKho.Count > 0 ||
                            hangHoa.HangHoaKhuyenMais.Count > 0 ||
                            hangHoa.HangHoaKhuyenMais1.Count > 0 ||
                            hangHoa.TonKhoes.Count > 0)
                        {
                            MessageBox.Show(
                            @"Hàng Hóa này hiện đang được sử dụng trong database. Bạn không thể xóa",
                            @"Thông Báo", MessageBoxButtons.OK);
                        }
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
    }
}
