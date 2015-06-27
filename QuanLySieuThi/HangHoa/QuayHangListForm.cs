using System;
using System.Windows.Forms;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.HangHoa
{
    public partial class QuayHangListForm
    {
        private QuayHangService _quayHangService;
        private Object _selRow;

        public QuayHangListForm()
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
                _quayHangService = new QuayHangService(Entities);
                var quayHangList = _quayHangService.GetAll();
                QuayHangGridControl.DataSource = quayHangList;
                QuayHangGridControl.RefreshDataSource();
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _selRow as QuayHang;
                if (selRow != null)
                {
                    var quayHangEditForm = new QuayHangEditForm(selRow.Id);
                    quayHangEditForm.ShowForm(string.Format("EditQuayHang: {0}", selRow.Id));
                    quayHangEditForm.FormClosed += QuayHangEditFormClosed;
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
                var quayHangEditForm = new QuayHangEditForm(null);
                quayHangEditForm.ShowForm("AddQuayHang");
                quayHangEditForm.FormClosed += QuayHangEditFormClosed;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _selRow as QuayHang;
                if (selRow != null)
                {
                    // TODO VuDao: Check quay hang dang duoc su dung trong database
                    if (DialogResult.Yes ==
                        MessageBox.Show(string.Format("Ban co muon xoa Quay Hang '{0}' ?", selRow.TenQuay),
                            @"Xac Nhan", MessageBoxButtons.YesNo))
                    {
                        _quayHangService.Delete(selRow.Id);
                        _quayHangService.Save();
                        ShowData();
                    }
                }
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

        private void QuayHangEditFormClosed(object sender, FormClosedEventArgs e)
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

    }
}
