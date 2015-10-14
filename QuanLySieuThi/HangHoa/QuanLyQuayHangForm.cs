using System;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.HangHoa
{
    public partial class QuanLyQuayHangForm : QuanLySieuThiForm
    {
        private QuayHangService _quayHangService;
        private Object _selRow;

        private bool _isSelectedRow = true;

        public QuanLyQuayHangForm()
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
                DataBinding.BindEditor(QuayHangTextBox, "Text", Entity, "TenQuay");
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
                var quayHangs = _quayHangService.GetAll();

                quayHangGridControl.DataSource = quayHangs;
                quayHangGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }   
        }

        private void ReadOnlyControls(bool isReadOnly)
        {
            QuayHangTextBox.Properties.ReadOnly = isReadOnly;
        }

        private void quayHangGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (_isSelectedRow)
                {
                    _selRow = quayHangGridView.GetRow(e.FocusedRowHandle);

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
                var quayHang = _quayHangService.Add();

                Entity = quayHang;

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
                var quayHang = Entity as QuayHang;
                if (quayHang != null)
                {
                    if (string.IsNullOrEmpty(quayHang.TenQuay))
                    {
                        MessageBox.Show(
                                @"Vui lòng nhập tên Quầy Hàng",
                                @"Thông Báo", MessageBoxButtons.OK);

                        return false;
                    }

                    if (FormMode == FormMode.Add)
                    {
                        var quayHangInDatabase = _quayHangService.GetByTenQuayHang(quayHang.TenQuay);
                        if (quayHangInDatabase != null)
                        {
                            MessageBox.Show(
                                @"Tên Quầy Hàng đã tồn tại trong cơ sở dữ liệu",
                                @"Thông Báo", MessageBoxButtons.OK);

                            return false;
                        }
                    }
                    else if (FormMode == FormMode.Edit)
                    {
                        var quayHangInDatabase = _quayHangService.GetByTenQuayHang(quayHang.TenQuay);
                        if (quayHangInDatabase != null && quayHangInDatabase.Id != quayHang.Id)
                        {
                            MessageBox.Show(
                                @"Tên Quầy Hàng đã tồn tại trong cơ sở dữ liệu",
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
                var quayHang = Entity as QuayHang;

                if (quayHang != null)
                {
                    if (FormMode == FormMode.Add)
                    {
                        quayHang.NgayChinhSua = DateTime.Now;
                        quayHang.NgayTao = DateTime.Now;
                        quayHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                        quayHang.NguoiTaoId = CurrentFormInfo.CurrentUserId;
                    }
                    else if (FormMode == FormMode.Edit)
                    {
                        quayHang.NgayChinhSua = DateTime.Now;
                        quayHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;

                        _quayHangService.Update(quayHang);
                    }

                    quayHang.HoatDong = true;

                    _quayHangService.Save();
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
                var selRow = _selRow as QuayHang;
                if (selRow != null)
                {
                    if (selRow.HangHoas.Count > 0)
                    {
                        MessageBox.Show(@"Quầy Hàng đã được sử dụng trong cơ sở dữ liệu", @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (DialogResult.Yes ==
                        MessageBox.Show(string.Format("Bạn có muốn xóa Quầy Hàng '{0}' ?", selRow.TenQuay),
                            @"Xác Nhận", MessageBoxButtons.YesNo))
                        {
                            _quayHangService.Delete(selRow.Id);
                            _quayHangService.Save();
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
