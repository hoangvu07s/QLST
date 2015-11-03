using System;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.KhachHang
{
    public partial class QuanLyDoiTraHangHoaForm : QuanLySieuThiForm
    {
        private DoiTraHangHoaService _doiTraHangHoaService;
        private Object _selRow;

        public QuanLyDoiTraHangHoaForm()
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
                _doiTraHangHoaService = new DoiTraHangHoaService(Entities);

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
                var doiTraHangHoas = _doiTraHangHoaService.GetAll();
                DoiTraHangHoaGridControl.DataSource = doiTraHangHoas;
                DoiTraHangHoaGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var chiTietDoiTraHangHoa = new ChiTietDoiTraHangHoaForm(null);
            chiTietDoiTraHangHoa.ShowForm("OpenAddChiTietDoiTraHangHoaForm");
            chiTietDoiTraHangHoa.FormClosed += ChiTietDoiTraHangHoaOnFormClosed;
        }

        private void ChiTietDoiTraHangHoaOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
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

        private void DoiTraHangHoaGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _selRow = DoiTraHangHoaGridView.GetRow(e.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        
        }

        private void DoiTraHangHoaGridView_DoubleClick(object sender, EventArgs e)
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
                var doiTraHangHoa = _selRow as DoiTraHangHoa;
                if (doiTraHangHoa != null)
                {
                    var chiTietDoiTraHangHoa = new ChiTietDoiTraHangHoaForm(doiTraHangHoa.DoiTraHangHoaId);
                    chiTietDoiTraHangHoa.ShowForm("ViewChiTietDoiTraHangHoa");

                    chiTietDoiTraHangHoa.FormClosed += ChiTietDoiTraHangHoaOnFormClosed;
                }
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
    }
}
