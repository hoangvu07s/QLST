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
using Service;

namespace QuanLySieuThi.Kho
{
    public partial class ChiTietNhapKhoForm
    {
        private ChiTietNhapKhoService _chiTietNhapKhoService;
        private Guid _nhapKhoId;
        public ChiTietNhapKhoForm(Guid nhapKhoId)
        {
            InitializeComponent();

            MinimumSizeWidth = 635;
            MinimumSizeHeight = 318;
            _nhapKhoId = nhapKhoId;
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
                _chiTietNhapKhoService = new ChiTietNhapKhoService(Entities);
                var chiTietNhapKho = _chiTietNhapKhoService.Get(_nhapKhoId);
                CTNhapKhoGridControl.DataSource = chiTietNhapKho;
                CTNhapKhoGridControl.RefreshDataSource();
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
