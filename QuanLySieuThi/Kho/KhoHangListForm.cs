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
    public partial class KhoHangListForm
    {
        private KhoHangService _khoHangService;
        private Object _sellRow;

        public KhoHangListForm()
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
                _khoHangService = new KhoHangService(Entities);

                var kho = _khoHangService.GetAll();

                KhoGridControl.DataSource = kho;
                KhoGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void CancelButtonControl_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _sellRow as Model.Kho;
                if (selRow != null)
                {
                    var kho = _khoHangService.Get(selRow.Id);
                    if (kho != null)
                    {
                        if (kho.NhapKhoes.Count > 0 || kho.PhieuTraQuayHangs.Count > 0)
                        {
                            MessageBox.Show(
                            @"Kho này hiện đang được sử dụng trong database. Bạn không thể xóa",
                            @"Thông Báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (DialogResult.Yes ==
                                MessageBox.Show(string.Format("Bạn có muốn xóa kho hàng '{0}' ?", selRow.TenKho),
                                    @"Xác nhận", MessageBoxButtons.YesNo))
                            {
                                _khoHangService.Delete(selRow.Id);
                                _khoHangService.Save();
                                ShowData();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
