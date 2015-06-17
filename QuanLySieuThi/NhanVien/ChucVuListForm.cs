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
using Service;

namespace QuanLySieuThi.NhanVien
{
    public partial class ChucVuListForm
    {
        private ChucVuService _chucVuService;
        private Object _selRow = null;

        public ChucVuListForm()
        {
            InitializeComponent();
            MinimumSizeWidth = 694;
            MinimumSizeHeight = 279;

            _chucVuService = new ChucVuService(Entities);
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);

            try
            {
                ShowData();}
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
                var chucVuList = Entities.ChucVus.ToList();
                ChucVuGridControl.DataSource = chucVuList;
                ChucVuGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
