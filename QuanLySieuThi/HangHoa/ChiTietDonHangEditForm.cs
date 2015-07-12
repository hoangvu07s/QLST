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

namespace QuanLySieuThi.HangHoa
{
    public partial class ChiTietDonHangEditForm
    {
        private DonHangService _donHangService;
        public ChiTietDonHangEditForm(string donHangId)
        {
            InitializeComponent();
            MinimumSizeWidth = 879;
            MinimumSizeHeight = 490;
            EntityId = donHangId;

            _donHangService = new DonHangService(Entities);
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);
            try
            {

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
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
        
    }
}
