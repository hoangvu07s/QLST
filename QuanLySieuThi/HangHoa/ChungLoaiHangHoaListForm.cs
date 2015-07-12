using System;
using System.Windows.Forms;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.HangHoa
{
    public partial class ChungLoaiHangHoaListForm
    {
        private ChungLoaiHangHoaService _chungLoaiHangHoaService;
        private Object _selRow;

        public ChungLoaiHangHoaListForm()
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
                _chungLoaiHangHoaService = new ChungLoaiHangHoaService(Entities);
                var chungLoaiHoangHoaList = _chungLoaiHangHoaService.GetAll();
                ChungLoaiHangHoaGridControl.DataSource = chungLoaiHoangHoaList;
                ChungLoaiHangHoaGridControl.RefreshDataSource();
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
                var selRow = _selRow as ChungLoaiHangHoa;
                if (selRow != null)
                {
                    // TODO VuDao: check chung loai hang hoa dang duoc su dung trong database
                    if (DialogResult.Yes ==
                        MessageBox.Show(string.Format("Ban co muon xoa Chung Loai '{0}' ?", selRow.TenChungLoai),
                            @"Xac Nhan", MessageBoxButtons.YesNo))
                    {
                        _chungLoaiHangHoaService.Delete(selRow.Id);
                        _chungLoaiHangHoaService.Save();
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
                var selRow = _selRow as ChungLoaiHangHoa;
                if (selRow != null)
                {
                    var chungLoaiHangHoaEditForm = new ChungLoaiHangHoaEditForm(selRow.Id);
                    chungLoaiHangHoaEditForm.ShowForm(string.Format("EditChungLoai: {0}", selRow.Id));
                    chungLoaiHangHoaEditForm.FormClosed += ChungLoaiHangHoaEditFormClosed;
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ChungLoaiHangHoaEditFormClosed(object sender, FormClosedEventArgs a)
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
                var chungLoaiHangHoaEditForm = new ChungLoaiHangHoaEditForm(null);
                chungLoaiHangHoaEditForm.ShowForm("AddChungLoaiHangHoa");
                chungLoaiHangHoaEditForm.FormClosed += ChungLoaiHangHoaEditFormClosed;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void LoaiHoangHoaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _selRow as ChungLoaiHangHoa;
                if (selRow != null)
                {
                    var loaiHangHoaListForm = new LoaiHangHoaListForm(selRow.Id);
                    loaiHangHoaListForm.ShowForm("LoaiHangHoaListForm");
                    loaiHangHoaListForm.FormClosed += ChungLoaiHangHoaEditFormClosed;}
                
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
