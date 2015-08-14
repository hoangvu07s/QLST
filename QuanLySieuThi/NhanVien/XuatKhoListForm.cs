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

namespace QuanLySieuThi.NhanVien
{
    public partial class XuatKhoListForm
    {
        private XuatKhoService _xuatKhoService;
        private object _selRow;
        public XuatKhoListForm()
        {
            InitializeComponent();

            MinimumSizeWidth = 613;
            MinimumSizeHeight = 347;  
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
            ResetEntities();
            _xuatKhoService = new XuatKhoService(Entities);
            var xuatKho = _xuatKhoService.GetAll();
            gridControl1.DataSource = xuatKho;
            gridControl1.RefreshDataSource();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _selRow = gridView1.GetRow(e.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            SelectButton_Click(sender,e);
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _selRow as XuatKho;
                if (selRow != null)
                {
                    var chiTietXuatKhoForm = new ChiTietXuatKhoForm(selRow.PhieuXuatKhoId);
                    chiTietXuatKhoForm.ShowForm("OpenChiTietXuatKho");
                }
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
    }
}
