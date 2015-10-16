using System;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Service;

namespace QuanLySieuThi.NhaCungCap
{
    public partial class QuanLyNhaCungCapForm : QuanLySieuThiForm
    {
        private NhaCungCapService _nhaCungCapService;
        private Object _selRow;

        private bool _isSelectedRow = true;
        public QuanLyNhaCungCapForm()
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
                try
                {
                    DataBinding.BindEditor(TenNhaCungCapTextBox, "Text", Entity, "TenNhaCungCap");
                    DataBinding.BindEditor(TenCongTyTextBox, "Text", Entity, "TenCongTy");
                    DataBinding.BindEditor(DiaChiTextBox, "Text", Entity, "DiaChi");
                    DataBinding.BindEditor(SoDienThoaiTextBox, "Text", Entity, "SoDienThoai");
                    DataBinding.BindEditor(EmailTextBox, "Text", Entity, "Email");
                }
                catch (Exception ex)
                {
                    QuanLySieuThiHelper.LogError(ex);
                }
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

        private void ReadOnlyControls(bool isReadOnly)
        {
            TenNhaCungCapTextBox.Properties.ReadOnly = isReadOnly;
            TenCongTyTextBox.Properties.ReadOnly = isReadOnly;
            DiaChiTextBox.Properties.ReadOnly = isReadOnly;
            SoDienThoaiTextBox.Properties.ReadOnly = isReadOnly;
            EmailTextBox.Properties.ReadOnly = isReadOnly;
        }

        private void NhaCungCapGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (_isSelectedRow)
                {
                    _selRow = NhaCungCapGridView.GetRow(e.FocusedRowHandle);

                    Entity = _selRow;

                    BindData();
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
                var nhaCungCap = _nhaCungCapService.Add();

                Entity = nhaCungCap;

                BindData();
                ReadOnlyControls(false);

                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
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
                var nhaCungCap = Entity as Model.NhaCungCap;
                if (nhaCungCap != null)
                {
                    if (string.IsNullOrEmpty(nhaCungCap.TenNhaCungCap))
                    {
                        MessageBox.Show(
                                @"Vui lòng nhập tên Nhà Cung Cấp",
                                @"Thông Báo", MessageBoxButtons.OK);

                        return false;
                    }

                    if (string.IsNullOrEmpty(nhaCungCap.TenCongTy))
                    {
                        MessageBox.Show(
                                @"Vui lòng nhập Tên Công Ty",
                                @"Thông Báo", MessageBoxButtons.OK);

                        return false;
                    }

                    if (string.IsNullOrEmpty(nhaCungCap.DiaChi))
                    {
                        MessageBox.Show(
                                @"Vui lòng nhập Địa Chỉ",
                                @"Thông Báo", MessageBoxButtons.OK);

                        return false;
                    }

                    if (string.IsNullOrEmpty(nhaCungCap.SoDienThoai))
                    {
                        MessageBox.Show(
                                @"Vui lòng nhập Số Điện Thoại",
                                @"Thông Báo", MessageBoxButtons.OK);

                        return false;
                    }

                    if (FormMode == FormMode.Add)
                    {
                        var nhaCungCapInDatabase = _nhaCungCapService.GetByTenNhaCungCap(nhaCungCap.TenNhaCungCap);
                        if (nhaCungCapInDatabase != null)
                        {
                            MessageBox.Show(
                                @"Tên Nhà Cung Cấp đã tồn tại trong cở sở dữ liệu",
                                @"Thông Báo", MessageBoxButtons.OK);

                            return false;
                        }
                    }
                    else if (FormMode == FormMode.Edit)
                    {
                        var nhaCungCapInDatabase = _nhaCungCapService.GetByTenNhaCungCap(nhaCungCap.TenNhaCungCap);
                        if (nhaCungCapInDatabase != null && nhaCungCapInDatabase.Id != nhaCungCap.Id)
                        {
                            MessageBox.Show(
                                @"Tên Nhà Cung Cấp đã tồn tại trong cở sở dữ liệu",
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
                AddButton.Enabled = true;

                _isSelectedRow = true;
            }
        }

        private void SaveData()
        {
            try
            {
                var nhaCungCap = Entity as Model.NhaCungCap;

                if (nhaCungCap != null)
                {
                    if (FormMode == FormMode.Add)
                    {
                        nhaCungCap.NgayChinhSua = DateTime.Now;
                        nhaCungCap.NgayTao = DateTime.Now;
                        nhaCungCap.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                        nhaCungCap.NguoiTaoId = CurrentFormInfo.CurrentUserId;
                    }
                    else if (FormMode == FormMode.Edit)
                    {
                        nhaCungCap.NgayChinhSua = DateTime.Now;
                        nhaCungCap.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;

                        _nhaCungCapService.Update(nhaCungCap);
                    }

                    nhaCungCap.HoatDong = true;

                    _nhaCungCapService.Save();
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
                // TODO VuDao: check nha cung cap dang duoc su dung trong database
                var selRow = _selRow as Model.NhaCungCap;
                if (selRow != null)
                {
                    if (_nhaCungCapService.CountHangHoa(selRow.Id) > 0 ||
                        _nhaCungCapService.CountDonHang(selRow.Id) > 0)
                    {
                        MessageBox.Show(@"Nhà Cung Cấp đã được sủ dụng trong cơ sở dữ liệu", @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (DialogResult.Yes ==
                         MessageBox.Show(string.Format("Bạn có muốn xóa Nhà Cung Cấp '{0}' ?", selRow.TenNhaCungCap),
                             @"Xác Nhận", MessageBoxButtons.YesNo))
                        {
                            _nhaCungCapService.Delete(selRow.Id);
                            _nhaCungCapService.Save();
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

        private void CancelButtonControl_Click(object sender, EventArgs e)
        {
            Cancel();
        }
    }
}
