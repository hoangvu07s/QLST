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

namespace QuanLySieuThi.Kho
{
    public partial class NhapKhoListForm
    {

        private NhapKhoService _nhapKhoService;
        private object _selRow;
        public NhapKhoListForm()
        {
            InitializeComponent();

            MinimumSizeWidth = 626;
            MinimumSizeHeight = 323;  
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

                _nhapKhoService = new NhapKhoService(Entities);
                var nhapKho = _nhapKhoService.GetAll();
                NhapKhoGridControl.DataSource = nhapKho;
                NhapKhoGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            var selRow = _selRow as NhapKho;
            if (selRow != null)
            {
                var chiTietNhapKhoForm = new ChiTietNhapKhoForm(selRow.PhieuNhapKhoId);
                chiTietNhapKhoForm.ShowForm("OpenChiTietNhapKhoForm");
            }
        }

        private void NhapKhoGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _selRow = NhapKhoGridView.GetRow(e.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void NhapKhoGridView_DoubleClick(object sender, EventArgs e)
        {
            SelectButton_Click(sender,e);
        }
    }
}
