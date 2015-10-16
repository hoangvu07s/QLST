using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Service;

namespace QuanLySieuThi.Kho
{
    public partial class QuanLyKhoHangForm : QuanLySieuThiForm
    {
        private KhoHangService _khoHangService;
        private NhanVienService _nhanVienService;
        private IList<Model.NhanVien> _nhanViens;
        private Object _selRow;

        private bool _isSelectedRow = true;
        public QuanLyKhoHangForm()
        {
            InitializeComponent();
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);

            try
            {
                _nhanVienService = new NhanVienService(Entities);
                _nhanViens = _nhanVienService.GetNhanViens();

                ShowData();

                ReadOnlyControls(true);
                SaveButton.Enabled = false;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public void BindData()
        {
            try
            {
                DataBinding.BindEditor(TenKhoHangTextBox, "Text", Entity, "TenKho");
                DataBinding.BindLookupEdit(TenNhanVienLookupEdit, "EditValue", Entity, _nhanViens, "NhanVienId",
                    "TenDangNhap", "Id", "TenDangNhap");
                DataBinding.BindEditor(DiaChiTextBox, "Text", Entity, "DiaChi");
                DataBinding.BindEditor(SoDienThoaiTextBox, "Text", Entity, "SoDienThoai");
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
                var khoHangs = _khoHangService.GetAll();

                KhoHangGridControl.DataSource = khoHangs;
                KhoHangGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ReadOnlyControls(bool isReadOnly)
        {
            TenKhoHangTextBox.Properties.ReadOnly = isReadOnly;
            TenNhanVienLookupEdit.Properties.ReadOnly = isReadOnly;
            DiaChiTextBox.Properties.ReadOnly = isReadOnly;
            SoDienThoaiTextBox.Properties.ReadOnly = isReadOnly;
        }

        private void KhoHangGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (_isSelectedRow)
                {
                    _selRow = KhoHangGridView.GetRow(e.FocusedRowHandle);

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
                var khoHang = _khoHangService.AddKho();

                Entity = khoHang;

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
                var khoHang = Entity as Model.Kho;
                if (khoHang != null)
                {
                    if (string.IsNullOrEmpty(khoHang.TenKho))
                    {
                        MessageBox.Show(@"Vui lòng nhập Tên Kho Hàng", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (khoHang.NhanVienId == 0)
                    {
                        MessageBox.Show(@"Vui lòng chọn Nhân Viên", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (string.IsNullOrEmpty(khoHang.DiaChi))
                    {
                        MessageBox.Show(@"Vui lòng nhập Địa Chỉ Kho Hàng", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }


                    var khoHangs = _khoHangService.GetAll();
                    if (FormMode == FormMode.Edit)
                    {
                        khoHangs.Remove(khoHang);
                    }
                    if (
                        khoHangs.Any(
                            _ =>
                                _.TenKho == khoHang.TenKho || _.DiaChi == khoHang.DiaChi || _.SoDienThoai == khoHang.SoDienThoai))
                    {
                        MessageBox.Show(@"Tên Kho Hàng, Địa Chỉ và Số Điện Thoại Đã Tồn Tại", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
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
                var khoHang = Entity as Model.Kho;

                if (khoHang != null)
                {
                    if (FormMode == FormMode.Add)
                    {
                        khoHang.NgayChinhSua = DateTime.Now;
                        khoHang.NgayTao = DateTime.Now;
                        khoHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                        khoHang.NguoiTaoId = CurrentFormInfo.CurrentUserId;
                    }
                    else if (FormMode == FormMode.Edit)
                    {
                        khoHang.NgayChinhSua = DateTime.Now;
                        khoHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;

                        _khoHangService.Update(khoHang);
                    }

                    khoHang.HoatDong = true;

                    _khoHangService.Save();
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
                var selRow = _selRow as Model.Kho;
                if (selRow != null)
                {
                    var kho = _khoHangService.Get(selRow.Id);
                    if (kho != null)
                    {
                        if (kho.NhapKhoes.Count > 0 || kho.PhieuTraQuayHangs.Count > 0 || kho.TonKhoes.Count > 0 || kho.XuatKhoes.Count > 0)
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
