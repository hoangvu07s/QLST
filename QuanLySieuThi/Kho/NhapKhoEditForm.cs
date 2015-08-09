using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.HangHoa;
using Service;

namespace QuanLySieuThi.Kho
{
    public partial class NhapKhoEditForm
    {
        private NhapKhoService _nhapKhoService;
        private string _donHangId;
        public NhapKhoEditForm()
        {
            InitializeComponent();
            MinimumSizeWidth = 782;
            MinimumSizeHeight = 447;

            _nhapKhoService = new NhapKhoService(Entities);
        }

        private void SearchDonHangButton_Click(object sender, EventArgs e)
        {
            var donHangListForm = new DonHangListForm(true);
            donHangListForm.ShowForm("OpenDonHangListForm");
            donHangListForm.FormClosed += DonHangListFormOnFormClosed;
        }

        private void DonHangListFormOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            _donHangId = DonHangListForm.MaDonHang.ToString();
            MaDonHangTextBox.Text = _donHangId;
        }
    }
}
