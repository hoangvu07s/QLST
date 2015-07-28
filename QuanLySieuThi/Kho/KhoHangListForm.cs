using System;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var khoHangEditForm = new KhoHangEditForm(null);
                khoHangEditForm.ShowForm("AddKhoHang");
                khoHangEditForm.FormClosed += KhoHangEditFormOnFormClosed;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void KhoHangEditFormOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            try
            {
                ShowData();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _sellRow as Model.Kho;
                if (selRow != null)
                {
                    var khoHangEditForm = new KhoHangEditForm(selRow.Id);
                    khoHangEditForm.ShowForm(string.Format("EditKhoHang: {0}", selRow.Id));
                    khoHangEditForm.FormClosed += KhoHangEditFormOnFormClosed;
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            AcceptAndSavechange();
        }

        private void KhoGridView_DoubleClick(object sender, EventArgs e)
        {
            EditButton_Click(sender,e);
        }

        private void KhoGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _sellRow = KhoGridView.GetRow(e.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
