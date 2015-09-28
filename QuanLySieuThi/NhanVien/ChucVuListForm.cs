using System;
using System.Windows.Forms;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.NhanVien
{
    public partial class ChucVuListForm
    {
        private ChucVuService _chucVuService;
        private Object _selRow;

        public ChucVuListForm()
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
            try{
                ResetEntities();
                _chucVuService = new ChucVuService(Entities);
                var chucVuList = _chucVuService.GetChucVus();
                ChucVuGridControl.DataSource = chucVuList;
                ChucVuGridControl.RefreshDataSource();
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
                var selRow = _selRow as ChucVu;
                if (selRow != null)
                {                  
                    var id = selRow.Id;
                    var nhanViens = _chucVuService.GetNhanViens(id);

                    if (nhanViens.Count > 0)
                    {
                        MessageBox.Show(
                            @"Chuc Vu ngay dang duoc su dung trong co so du lieu cua nhan vien. Ban khong the xoa",
                            @"Thong Bao", MessageBoxButtons.OK);                       
                    }
                    else if(selRow.TenChucVu == "Admin")
                    {
                        MessageBox.Show(@"Ban khong the xoa chuc vu Admin", @"Thong Bao", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (DialogResult.Yes ==
                            MessageBox.Show(string.Format("Ban co muon xoa Chuc Vu '{0}' ?", selRow.TenChucVu),
                                @"Xac Nhan", MessageBoxButtons.YesNo))
                        {
                            _chucVuService.DeleteChucVu(selRow.Id);
                            _chucVuService.Save();
                            ShowData();
                        }
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
                var selRow = _selRow as ChucVu;
                if (selRow != null)
                {
                    if (selRow.TenChucVu == "Admin")
                    {
                        MessageBox.Show(@"Ban khong the sua chuc vu Admin", @"Thong Bao", MessageBoxButtons.OK);
                    }
                    else
                    {
                        var chucVuEditForm = new ChucVuEditForm(selRow.Id);
                        chucVuEditForm.ShowForm(string.Format("ThemChucVu: {0}",selRow.Id));
                        chucVuEditForm.FormClosed += ChucVuEditFormClosed;
                    }
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ChucVuEditFormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ShowData();
            }catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var chucVuEditForm = new ChucVuEditForm(null);
                chucVuEditForm.ShowForm("ThemChucVu");
                chucVuEditForm.FormClosed += ChucVuEditFormClosed;}
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
