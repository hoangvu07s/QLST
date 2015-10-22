using System;
using System.Windows.Forms;
using Helper;
using Service;

namespace QuanLySieuThi.Kho
{
    public partial class PhieuTraQuayHangForm
    {
        private PhieuTraQuayHangService _phieuTraQuayHangService;
        private Object _sellRow;

        public PhieuTraQuayHangForm()
        {
            InitializeComponent();

            MinimumSizeWidth = 739;
            MinimumSizeHeight = 373; 
        }

        private void CancelButtonControl_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            AcceptAndSavechange();
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
                _phieuTraQuayHangService = new PhieuTraQuayHangService(Entities);

                var phieuTraQuayHangs = _phieuTraQuayHangService.GetAll();

                phieuTraHangGridControl.DataSource = phieuTraQuayHangs;
                phieuTraHangGridControl.RefreshDataSource();
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
                var chiTietPhieuTraQuayHang = new QuanLyTraHangVeKhoForm(string.Empty);
                chiTietPhieuTraQuayHang.ShowForm("AddChiTietPhieuTraQuayHang");
                chiTietPhieuTraQuayHang.FormClosed += chiTietPhieuTraQuayHang_FormClosed;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        void chiTietPhieuTraQuayHang_FormClosed(object sender, FormClosedEventArgs e)
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

        private void phieuTraHangGridControl_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void XemChiTietButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _sellRow as Model.PhieuTraQuayHang;
                if (selRow != null)
                {
                    var chiTietPhieuTraQuayHang = new QuanLyTraHangVeKhoForm(selRow.PhieuTraQuayHangId.ToString());
                    chiTietPhieuTraQuayHang.ShowForm(string.Format("ViewChiTietPhieuTraQuayHang : {0}", selRow.PhieuTraQuayHangId));
                    chiTietPhieuTraQuayHang.FormClosed += chiTietPhieuTraQuayHang_FormClosed;
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void phieuTraHangGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _sellRow = phieuTraHangGridView.GetRow(e.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void phieuTraHangGridView_DoubleClick(object sender, EventArgs e)
        {
            XemChiTietButton_Click(sender, e);
        }
    }
}
