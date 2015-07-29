using System;
using System.Windows.Forms;
using Helper;
using Service;

namespace QuanLySieuThi.HangHoa
{
    public partial class HangHoaListForm
    {
        private HangHoaService _hangHoaService;
        public HangHoaListForm()
        {
            InitializeComponent();

            MinimumSizeWidth = 694;
            MinimumSizeHeight = 279;
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
                var hangHoas = _hangHoaService.GetAll();

                HangHoaGridControl.DataSource = hangHoas;
                HangHoaGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
