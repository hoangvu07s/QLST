using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public DonHangListForm()
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
                _donHangService = new DonHangService(Entities);
                var donHangs = _donHangService.GetAll();

                DonHangGridControl.DataSource = donHangs;
                DonHangGridControl.RefreshDataSource();
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
    }
}
