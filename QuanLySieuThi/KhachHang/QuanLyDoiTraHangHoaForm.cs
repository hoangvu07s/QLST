using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Forms;
using Helper;

namespace QuanLySieuThi.KhachHang
{
    public partial class QuanLyDoiTraHangHoaForm : QuanLySieuThiForm
    {
        public QuanLyDoiTraHangHoaForm()
        {
            InitializeComponent();

            MinimumSizeWidth = 1003;
            MinimumSizeHeight = 602;
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

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
