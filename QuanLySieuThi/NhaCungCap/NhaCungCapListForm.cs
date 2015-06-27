using System;
using System.Windows.Forms;
using Helper;
using Service;

namespace QuanLySieuThi.NhaCungCap
{
    public partial class NhaCungCapListForm
    {
        private NhaCungCapService _nhaCungCapService;
        private Object _selRow;

        public NhaCungCapListForm()
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
                _nhaCungCapService = new NhaCungCapService(Entities);
                var nhaCungCaps = _nhaCungCapService.GetAll();
                NhaCungCapGridControl.DataSource = nhaCungCaps;
                NhaCungCapGridControl.RefreshDataSource();

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

        private void CancelButtonControl_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO VuDao: check nha cung cap dang duoc su dung trong database
                var selRow = _selRow as Model.NhaCungCap;
                if (selRow != null)
                {
                    if (DialogResult.Yes ==
                        MessageBox.Show(string.Format("Ban co muon xoa Nha Cung Cap '{0}' ?", selRow.TenNhaCungCap),
                            @"Xac Nhan", MessageBoxButtons.YesNo))
                    {
                        _nhaCungCapService.Delete(selRow.Id);
                        _nhaCungCapService.Save();
                        ShowData();
                    }
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            EditButton_Click(sender,e);
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _selRow = GridView1.GetRow(e.FocusedRowHandle);
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
                var selRow = _selRow as Model.NhaCungCap;
                if (selRow != null)
                {
                    var nhaCungCapEditForm = new NhaCungCapEditForm(selRow.Id);
                    nhaCungCapEditForm.ShowForm(string.Format("EditNhaCungCap: {0}", selRow.Id));
                    nhaCungCapEditForm.FormClosed += NhaCungCapEditFormClosed;
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void NhaCungCapEditFormClosed(object sender, FormClosedEventArgs e)
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var nhaCungCapEditForm = new NhaCungCapEditForm(null);
                nhaCungCapEditForm.ShowForm("AddNhaCungCap");
                nhaCungCapEditForm.FormClosed += NhaCungCapEditFormClosed;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
