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
using Model;
using Service;

namespace QuanLySieuThi.NhanVien
{
    public partial class QuanLyQuyenNhanVienForm : QuanLySieuThiForm
    {
        private QuyenService _quyenService;
        private QuyenNhanVienService _quyenNhanVienService;
        private IList<Quyen> _quyens;
        private Object _selRow;

        private bool _isSelectedRow = true;
        private QuanLyNhanVienForm _quanLyNhanVienForm;

        public QuanLyQuyenNhanVienForm()
        {
            InitializeComponent();
            MinimumSizeWidth = 1003;
            MinimumSizeHeight = 602;
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);

            try
            {
                _quyenService = new QuyenService(Entities);
                _quyens = _quyenService.GetAll();

                ShowData();

                ReadOnlyControls(true);
                SaveButton.Enabled = false;
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
                _quyenNhanVienService = new QuyenNhanVienService(Entities);
                var quyenNhanViens = _quyenNhanVienService.GetAll();

                QuyenNhanVienGridControl.DataSource = quyenNhanViens;
                QuyenNhanVienGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ReadOnlyControls(bool isDisabled)
        {
            SearchButton.Enabled = !isDisabled;
            QuyenLookupEdit.Properties.ReadOnly = isDisabled;
        }

        private void BindData()
        {
            try
            {
                DataBinding.BindEditor(TenNhanVienTextBox, "Text", Entity, "TenNhanVien");
                DataBinding.BindLookupEdit(QuyenLookupEdit, "EditValue", Entity, _quyens, "QuyenId", "Quyen1", "Id",
                    "Quyen1");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void QuyenNhanVienGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (_isSelectedRow)
                {
                    _selRow = QuyenNhanVienGridView.GetRow(e.FocusedRowHandle);

                    Entity = _selRow as QuyenNhanVien;

                    BindData();
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var quyenNhanVien = _quyenNhanVienService.AddQuyenNhanVien();
                quyenNhanVien.NhanVien = new Model.NhanVien();
                Entity = quyenNhanVien;

                BindData();
                ReadOnlyControls(false);

                EditButton.Enabled = false;
                DeleteButtonControl.Enabled = false;
                AddButton.Enabled = false;
                SaveButton.Enabled = true;

                _isSelectedRow = false;

                FormMode = FormMode.Add;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public override bool ValidateInput(EventArgs e)
        {
            try
            {
                var quyenNhanVien = Entity as QuyenNhanVien;

                if (quyenNhanVien != null)
                {
                    if (string.IsNullOrWhiteSpace(quyenNhanVien.NhanVien.HoVaTen))
                    {
                        MessageBox.Show(@"Vui lòng nhập họ tên.", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (quyenNhanVien.QuyenId == 0)
                    {
                        MessageBox.Show(@"Vui lòng chọn quyền cho Nhân Viên.", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (FormMode == FormMode.Add)
                    {
                        var quyenNhanVienInDatabase = _quyenNhanVienService.GetByNhanVienId(quyenNhanVien.NhanVienId);
                        if (quyenNhanVienInDatabase != null)
                        {
                            MessageBox.Show(
                                @"Nhân Viên đã được phân quyền",
                                @"Thông Báo", MessageBoxButtons.OK);

                            return false;
                        }
                    }
                    else
                    {
                        if (quyenNhanVien.NhanVien.TenDangNhap == "admin")
                        {
                            MessageBox.Show(
                                @"Không Thể Sửa Quyền của Admin",
                                @"Thông Báo", MessageBoxButtons.OK);return false;
                        }
                        var quyenNhanVienInDatabase = _quyenNhanVienService.GetByNhanVienId(quyenNhanVien.NhanVienId);
                        if (quyenNhanVienInDatabase != null && quyenNhanVienInDatabase.Id != quyenNhanVien.Id)
                        {
                            MessageBox.Show(
                                @"Nhân Viên đã được phân quyền",
                                @"Thông Báo", MessageBoxButtons.OK);

                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput(e))
                {
                    SaveData();
                    ShowData();

                    ReadOnlyControls(true);
                    EditButton.Enabled = true;
                    DeleteButtonControl.Enabled = true;
                    SaveButton.Enabled = false;
                    AddButton.Enabled = true;

                    _isSelectedRow = true;
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void SaveData()
        {
            try
            {
                var quyenNhanVien = Entity as QuyenNhanVien;
                
                if (quyenNhanVien != null)
                {
                    if (FormMode == FormMode.Edit)
                    {
                        _quyenNhanVienService.Update(quyenNhanVien);
                    }
                    else
                    {
                        quyenNhanVien.NhanVienId = quyenNhanVien.NhanVien.Id;
                        quyenNhanVien.NhanVien = null;
                        quyenNhanVien.Quyen = null;
                        quyenNhanVien.HoatDong = true;
                    }

                    _quyenNhanVienService.Save();
                }
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
                var selRow = _selRow as QuyenNhanVien;
                if (selRow != null && selRow.NhanVien.TenDangNhap == "admin")
                {
                    MessageBox.Show(
                        @"Không Thể Sửa Quyền của Admin",
                        @"Thông Báo", MessageBoxButtons.OK); return ;
                }

                ReadOnlyControls(false);

                _isSelectedRow = false;

                AddButton.Enabled = false;
                SaveButton.Enabled = true;
                EditButton.Enabled = false;
                DeleteButtonControl.Enabled = false;

                FormMode = FormMode.Edit;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void DeleteButtonControl_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _selRow as QuyenNhanVien;
                if (selRow != null)
                {

                    if (selRow.NhanVien.TenDangNhap == "admin")
                    {
                        MessageBox.Show(
                            @"Không Thể Sửa Quyền của Admin",
                            @"Thông Báo", MessageBoxButtons.OK); return;
                    }

                    if (DialogResult.Yes ==
                        MessageBox.Show(
                            string.Format("Bạn có muốn xóa quyền của Nhân Viên '{0}' ?", selRow.NhanVien.HoVaTen),
                            @"Xác nhận", MessageBoxButtons.YesNo))
                    {
                        _quyenNhanVienService.Delete(selRow);
                        _quyenNhanVienService.Save();
                        ShowData();
                    }
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            _isSelectedRow = true;
            LoadData(e);
            AddButton.Enabled = true;
            EditButton.Enabled = true;
            DeleteButtonControl.Enabled = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                 _quanLyNhanVienForm = new QuanLyNhanVienForm(true);
                 _quanLyNhanVienForm.ShowForm("OpenSearchNhanVienForm");
                 _quanLyNhanVienForm.FormClosed += NhanVienFormOnFormClosed;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void NhanVienFormOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            try
            {
                var quyanLyNhanVien = Entity as QuyenNhanVien;
                if (quyanLyNhanVien != null) quyanLyNhanVien.NhanVien = _quanLyNhanVienForm.NhanVien;
                BindData();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
