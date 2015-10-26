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

namespace QuanLySieuThi.KhachHang
{
    public partial class ChiTietHoaDonForm : QuanLySieuThiForm
    {
        public ChiTietHoaDonForm(Guid? maHoaDon)
        {
            InitializeComponent();
            MinimumSizeWidth = 1003;
            MinimumSizeHeight = 602;
        }
    }
}
