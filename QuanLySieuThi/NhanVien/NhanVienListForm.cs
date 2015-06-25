using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Helper;
using Service;

namespace QuanLySieuThi.NhanVien
{
    public partial class NhanVienListForm
    {

        private NhanVienService _nhanVienService;
        private Object _selRow;
        public NhanVienListForm()
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
                _nhanVienService = new NhanVienService(Entities);
                var nhanViens = _nhanVienService.GetNhanViens();
                CollectNhanViens(nhanViens);
                NhanVienGridControl.DataSource = nhanViens;
                NhanVienGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void CollectNhanViens(IEnumerable<Model.NhanVien> nhanViens)
        {
            try
            {
                if (CurrentUserId.HasValue)
                {
                    var nhanVien = _nhanVienService.GetNhanVien(CurrentUserId.Value);
                    if (nhanVien != null && nhanVien.TenDangNhap == "admin")
                    {
                        foreach (var item in nhanViens)
                        {
                            item.MatKhau = item.MatKhau.Decrypt();
                        }
                    }
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

        private void CancelButtonControl_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _selRow as Model.NhanVien;
                if (selRow != null)
                {
                    var id = selRow.Id;
                    // TODO VuDao: need to check nhan vien is used in database

                    if (selRow.TenDangNhap == "admin")
                    {
                        MessageBox.Show(@"Ban khong the xoa tai khoan Admin", @"Thong Bao", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (DialogResult.Yes ==
                            MessageBox.Show(
                                string.Format("Ban co muon xoa thong tin cua nhan vien: {0}", selRow.HoVaTen),
                                @"Xac Nhan", MessageBoxButtons.YesNo))
                        {
                            _nhanVienService.DeleteNhanVien(selRow.Id);
                            _nhanVienService.Save();
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

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            EditButton_Click(sender,e);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _selRow as Model.NhanVien;
                if (selRow != null)
                {
                    if (selRow.TenDangNhap == "admin")
                    {
                        MessageBox.Show(@"Ban khong the sua nhan vien la Admin", @"Thong Bao", MessageBoxButtons.OK);
                    }
                    else
                    {
                        var nhanVienEditForm = new NhanVienEditFormNew(selRow.Id);
                        nhanVienEditForm.ShowForm(string.Format("NhanVien: {0}", selRow.Id));
                        nhanVienEditForm.FormClosed += NhanVienEditFormClosed;
                    }
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void NhanVienEditFormClosed(object sender, FormClosedEventArgs e)
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
                var nhanVienEditForm = new NhanVienEditFormNew(null);
                nhanVienEditForm.ShowForm("NhanVien");
                nhanVienEditForm.FormClosed += NhanVienEditFormClosed;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
