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

namespace QuanLySieuThi.NhanVien
{
    public partial class ChiTietXuatKhoForm
    {
        private ChiTietXuatKhoService _chiTietXuatKhoService;
        private Guid _xuatKhoId;

        public ChiTietXuatKhoForm(Guid xuatKhoId)
        {
            InitializeComponent();

            MinimumSizeWidth = 599;
            MinimumSizeHeight = 355;

            _xuatKhoId = xuatKhoId;
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
                _chiTietXuatKhoService = new ChiTietXuatKhoService(Entities);
                var chiTietXuatKho = _chiTietXuatKhoService.Get(_xuatKhoId);

                gridControl1.DataSource = chiTietXuatKho;
                gridControl1.RefreshDataSource();
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
