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
using Helper.ValueObjects;
using Service;

namespace QuanLySieuThi.HangHoa
{
    public partial class ThongKeHangHoaForm
    {
        private HangHoaService _hangHoaService;
        private TonKhoService _tonKhoService;
        private IList<ThongKeHangHoa> _thongKeHangHoas; 

        public ThongKeHangHoaForm()
        {
            InitializeComponent();
            MinimumSizeWidth = 690;
            MinimumSizeHeight = 346;
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
                _hangHoaService = new HangHoaService(Entities);
                _tonKhoService = new TonKhoService(Entities);
                _thongKeHangHoas = new List<ThongKeHangHoa>(); 
                var hangHoas = _hangHoaService.GetAll();
                foreach (var hangHoa in hangHoas)
                {
                    var soLuongTonKho = _tonKhoService.GetSoLuongTonKho(hangHoa.Id);
                    _thongKeHangHoas.Add(new ThongKeHangHoa
                    {
                        TenHangHoa = hangHoa.TenHangHoa,
                        SoLuongTonKho = soLuongTonKho,
                        SoLuongTonQuay = (int) (hangHoa.SoLuongTonQuay == null ? 0 : hangHoa.SoLuongTonQuay.Value)
                    });
                }

                gridControl1.DataSource = _thongKeHangHoas;
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
