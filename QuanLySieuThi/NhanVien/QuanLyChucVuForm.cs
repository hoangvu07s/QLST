using System;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.NhanVien
{
    public partial class QuanLyChucVuForm : QuanLySieuThiForm
    {
        private ChucVuService _chucVuService;
        private Object _selRow;

        private bool _isSelectedRow = true;

        public QuanLyChucVuForm()
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
                ShowData();

                ReadOnlyControls(true);
                SaveButton.Enabled = false;
                RefreshButton.Enabled = false;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void BindData()
        {
            try
            {
                DataBinding.BindEditor(ChucVuTextBox, "Text", Entity, "TenChucVu");
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
                _chucVuService = new ChucVuService(Entities);
                var chucVus = _chucVuService.GetChucVus();

                chucVuGridControl.DataSource = chucVus;
                chucVuGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ReadOnlyControls(bool isReadOnly)
        {
            ChucVuTextBox.Properties.ReadOnly = isReadOnly;
        }

        private void chucVuGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (_isSelectedRow)
                {
                    _selRow = chucVuGridView.GetRow(e.FocusedRowHandle);

                    Entity = _selRow;

                    BindData();
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var chucVu = _chucVuService.AddChucVu();

                Entity = chucVu;

                BindData();
                ReadOnlyControls(false);

                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
                AddButton.Enabled = false;
                SaveButton.Enabled = true;
                RefreshButton.Enabled = true;

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
                var chucVu = Entity as ChucVu;
                if (chucVu != null)
                {
                    if (string.IsNullOrEmpty(chucVu.TenChucVu))
                    {
                        MessageBox.Show(
                                @"Vui lòng nhập tên Chức Vụ",
                                @"Thông Báo", MessageBoxButtons.OK);

                        return false;
                    }

                    if (FormMode == FormMode.Add)
                    {
                        var chucVuInDatabase = _chucVuService.GetByName(chucVu.TenChucVu);
                        if (chucVuInDatabase != null)
                        {
                            MessageBox.Show(
                                @"Tên Chức Vụ đã tồn tại trong cơ sở dữ liệu",
                                @"Thông Báo", MessageBoxButtons.OK);

                            return false;
                        }
                    }
                    else if (FormMode == FormMode.Edit)
                    {
                        var chucVuInDatabase = _chucVuService.GetByName(chucVu.TenChucVu);
                        if (chucVuInDatabase != null && chucVuInDatabase.Id != chucVu.Id)
                        {
                            MessageBox.Show(
                                @"Tên Chức Vụ đã tồn tại trong cơ sở dữ liệu",
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
            if (ValidateInput(e))
            {
                SaveData();
                ShowData();

                ReadOnlyControls(true);
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;
                SaveButton.Enabled = false;
                RefreshButton.Enabled = false;
                AddButton.Enabled = true;

                _isSelectedRow = true;
            }
        }

        private void SaveData()
        {
            try
            {
                var chucVu = Entity as ChucVu;

                if (chucVu != null)
                {
                    if (FormMode == FormMode.Add)
                    {
                        chucVu.NgayChinhSua = DateTime.Now;
                        chucVu.NgayTao = DateTime.Now;
                        chucVu.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                        chucVu.NguoiTaoId = CurrentFormInfo.CurrentUserId;
                    }
                    else if (FormMode == FormMode.Edit)
                    {
                        chucVu.NgayChinhSua = DateTime.Now;
                        chucVu.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;

                        _chucVuService.Update(chucVu);
                    }

                    chucVu.HoatDong = true;

                    _chucVuService.Save();
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
                ReadOnlyControls(false);

                _isSelectedRow = false;

                AddButton.Enabled = false;
                SaveButton.Enabled = true;
                RefreshButton.Enabled = true;
                EditButton.Enabled = false;
                DeleteButton.Enabled = false;

                FormMode = FormMode.Edit;
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
                var selRow = _selRow as ChucVu;
                if (selRow != null)
                {
                    var id = selRow.Id;
                    var nhanViens = _chucVuService.GetNhanViens(id);

                    if (nhanViens.Count > 0)
                    {
                        MessageBox.Show(
                            @"Chức Vụ này đang được sử dụng trong cơ sở dữ liệu của nhân viên. Bạn không thể xóa",
                            @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (selRow.TenChucVu == "Admin")
                    {
                        MessageBox.Show(@"Bạn không thể xóa chức vụ Admin", @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (DialogResult.Yes ==
                            MessageBox.Show(string.Format("Bạn có muốn xóa Chức Vụ '{0}' ?", selRow.TenChucVu),
                                @"Xác Nhận", MessageBoxButtons.YesNo))
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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            _isSelectedRow = true;
            LoadData(e);
            AddButton.Enabled = true;
            EditButton.Enabled = true;
            DeleteButton.Enabled = true;
        }
    }
}
