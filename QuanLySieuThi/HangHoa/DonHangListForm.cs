using System;
using System.Linq;
using System.Windows.Forms;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.HangHoa
{
    public partial class DonHangListForm
    {
        private DonHangService _donHangService;
        private object _sellRow;
        private readonly bool _isSearchDonHang;

        public static Guid MaDonHang;

        public DonHangListForm(bool isSearchDonHang = false)
        {
            InitializeComponent();
            MinimumSizeWidth = 694;
            MinimumSizeHeight = 279;
            _isSearchDonHang = isSearchDonHang;
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
                _donHangService = new DonHangService(Entities);
                var donHangs = _donHangService.GetAll();

                if (_isSearchDonHang)
                {
                    donHangs = donHangs.Where(_ => _.TrangThaiDonHang == "Dang Cho" || _.TrangThaiDonHang == "Chưa Hoàn Thành").ToList();
                }

                DonHangGridControl.DataSource = donHangs;
                DonHangGridControl.RefreshDataSource();

                DisableControls();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void DisableControls()
        {
            if (_isSearchDonHang)
            {
                DeleteButton.Enabled = false;
                AddButton.Enabled = false;
                SelectButton.Enabled = true;
            }
            else
            {
                SelectButton.Enabled = false;
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
                var selRow = _sellRow as DonHang;
                if (selRow != null)
                {
                    var donHang = _donHangService.Get(selRow.DonHangId);
                    if (donHang != null)
                    {
                        donHang.TrangThaiDonHang = "Huy";
                        _donHangService.Update(donHang);
                        _donHangService.Save();
                        ShowData();
                    }
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void DonHangGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _sellRow = DonHangGridView.GetRow(e.FocusedRowHandle);
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
                var selRow = _sellRow as DonHang;
                if (selRow != null)
                {
                    var chiTietDonHangForm = new ChiTietDonHangEditForm(selRow.DonHangId.ToString());
                    chiTietDonHangForm.ShowForm(string.Format("ChiTietDonHang: {0}", selRow.DonHangId));
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void DonHangGridView_DoubleClick(object sender, EventArgs e)
        {
            EditButton_Click(sender, e);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var chiTietDonHangForm = new ChiTietDonHangEditForm(null);
                chiTietDonHangForm.ShowForm(string.Format("AddChiTietDonHang"));
                chiTietDonHangForm.FormClosed += ChiTietDonHangEditFormClosed;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ChiTietDonHangEditFormClosed(object sender, FormClosedEventArgs e)
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
            AcceptAndSavechange();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _sellRow as DonHang;
                if (selRow != null) MaDonHang = selRow.DonHangId;
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
                var selRow = _sellRow as DonHang;
                if (selRow != null) MaDonHang = selRow.DonHangId;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
