using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Helper.ValueObjects;
using Model;
using Service;

namespace QuanLySieuThi.NhanVien
{
    public partial class QuanLyNhanVienForm : QuanLySieuThiForm
    {
        private NhanVienService _nhanVienService;
        private ChucVuService _chucVuService;
        private IList<GioiTinh> _gioiTinhs;
        private IList<ChucVu> _chucVus;
        private Object _selRow;

        private bool _isSelectedRow = true;

        public QuanLyNhanVienForm()
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
                _gioiTinhs = InitGioiTinhs();

                _chucVuService = new ChucVuService(Entities);
                _chucVus = _chucVuService.GetChucVus();

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
                DataBinding.BindEditor(HoVaTenTextBox, "Text", Entity, "HoVaTen");
                DataBinding.BindLookupEdit(GioiTinhLookupEdit, "EditValue", Entity, _gioiTinhs, "GioiTinh", "Name",
                    "BooleanValue", "Name");
                DataBinding.BindEditor(NgayThangNamSinhDateEdit, "EditValue", Entity, "NgayThangNamSinh");
                DataBinding.BindEditor(TenDangNhapTextBox, "Text", Entity, "TenDangNhap");
                DataBinding.BindEditor(MatKhauTextBox, "Text", Entity, "MatKhau");
                DataBinding.BindLookupEdit(ChucVuLookupEdit, "EditValue", Entity, _chucVus, "ChucVuId", "TenChucVu",
                        "Id", "TenChucVu");
                DataBinding.BindEditor(SoDienThoaiTextBox, "Text", Entity, "SoDienThoai");
                DataBinding.BindEditor(EmailTextBox, "Text", Entity, "Email");
                DataBinding.BindEditor(DiaChiTextBox, "Text", Entity, "DiaChi");
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

                //var nhanViensTemp = nhanViens.ToList().DeepCopy();
                var nhanViensTemp = new List<Model.NhanVien>();
                foreach (var nhanVien in nhanViens)
                {
                    nhanViensTemp.Add(nhanVien.DeepCopy());
                }

                //CollectNhanViens(nhanViensTemp);

                nhanVienGridControl.DataSource = nhanViensTemp;
                nhanVienGridControl.RefreshDataSource();
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
                var nhanVien = _nhanVienService.GetNhanVien(CurrentFormInfo.CurrentUserId);
                if (nhanVien != null && nhanVien.TenDangNhap == "admin")
                {
                    foreach (var item in nhanViens)
                    {
                        item.MatKhau = item.MatKhau.Decrypt();
                    }
                }

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private IList<GioiTinh> InitGioiTinhs()
        {
            var gioitinhs = new List<GioiTinh>
                {
                    new GioiTinh
                    {
                        Name = "Nam",
                        BooleanValue = true
                    },
                    new GioiTinh
                    {
                        Name = "Nữ",
                        BooleanValue = false
                    }
                };
            return gioitinhs;
        }

        private void CancelButtonControl_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void nhanVienGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (_isSelectedRow)
                {
                    _selRow = nhanVienGridView.GetRow(e.FocusedRowHandle);
                    Entity = _selRow;
                    BindData();
                }                
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ReadOnlyControls(bool isDisable)
        {
            HoVaTenTextBox.Properties.ReadOnly = isDisable;
            GioiTinhLookupEdit.Properties.ReadOnly = isDisable;
            NgayThangNamSinhDateEdit.Properties.ReadOnly = isDisable;
            TenDangNhapTextBox.Properties.ReadOnly = isDisable;
            MatKhauTextBox.Properties.ReadOnly = isDisable;
            ChucVuLookupEdit.Properties.ReadOnly = isDisable;
            SoDienThoaiTextBox.Properties.ReadOnly = isDisable;
            EmailTextBox.Properties.ReadOnly = isDisable;
            DiaChiTextBox.Properties.ReadOnly = isDisable;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var nhanVien = _nhanVienService.AddNhanVien();
                nhanVien.NgayChinhSua = DateTime.Now;
                nhanVien.NgayTao = DateTime.Now;
                nhanVien.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                nhanVien.NguoiTaoId = CurrentFormInfo.CurrentUserId;
                nhanVien.HoatDong = true;
                nhanVien.MatKhau = nhanVien.MatKhau.Decrypt();
                Entity = nhanVien;

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
                var nhanVien = Entity as Model.NhanVien;
                if (nhanVien != null)
                {
                    if (string.IsNullOrEmpty(nhanVien.HoVaTen))
                    {
                        MessageBox.Show(@"Vui lòng nhập họ tên.", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (string.IsNullOrEmpty(nhanVien.TenDangNhap))
                    {
                        MessageBox.Show(@"Vui lòng nhập Tên đăng nhập.", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (string.IsNullOrEmpty(nhanVien.MatKhau))
                    {
                        MessageBox.Show(@"Vui lòng nhập mật khẩu.", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (nhanVien.ChucVuId == 0)
                    {
                        MessageBox.Show(@"Vui lòng chọn chức vụ.", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (string.IsNullOrEmpty(nhanVien.Email))
                    {
                        MessageBox.Show(@"Vui lòng nhập Email", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (string.IsNullOrEmpty(nhanVien.DiaChi))
                    {
                        MessageBox.Show(@"Vui lòng nhập địa chỉ.", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (nhanVien.NgayThangNamSinh >= DateTime.Now)
                    {
                        MessageBox.Show(@"Ngày tháng năm sinh không được lớn hơn hiện tại.", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (string.IsNullOrEmpty(nhanVien.SoDienThoai))
                    {
                        MessageBox.Show(@"Vui lòng nhập số điện thoại.", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (FormMode == FormMode.Add)
                    {
                        var nhanVienInDatabase = _nhanVienService.GetByTenDangNhap(nhanVien.TenDangNhap);
                        if (nhanVienInDatabase != null)
                        {
                            MessageBox.Show(
                                @"Tên đăng nhập đã tồn tại trong Cơ sở dữ liệu.",
                                @"Thông Báo", MessageBoxButtons.OK);

                            return false;
                        }
                    }
                    else
                    {
                        var nhanVienInDatabase = _nhanVienService.GetByTenDangNhap(nhanVien.TenDangNhap);
                        if (nhanVienInDatabase != null && nhanVienInDatabase.Id != nhanVien.Id)
                        {
                            MessageBox.Show(
                                @"Tên đăng nhập đã tồn tại trong Cơ sở dữ liệu.",
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
                var nhanVien = Entity as Model.NhanVien;
                if (nhanVien != null) nhanVien.MatKhau = nhanVien.MatKhau.Encrypt();

                if (FormMode == FormMode.Edit)
                {
                    _nhanVienService.Update(nhanVien);
                }

                _nhanVienService.Save();
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
                var selRow = _selRow as Model.NhanVien;
                if (selRow != null)
                {
                    var id = selRow.Id;
                    //if (_nhanVienService.GetChucVus(id).Count > 0||
                    //    _nhanVienService.GetChungLoaiHangHoas(id).Count > 0 ||
                    //    _nhanVienService.GetDonHangs(id).Count > 0 ||
                    //    _nhanVienService.GetHangHoas(id).Count > 0 ||
                    //    _nhanVienService.GetHoaDons(id).Count > 0 ||
                    //    _nhanVienService.GetKhos(id).Count > 0 ||
                    //    _nhanVienService.GetLoaiHangHoas(id).Count > 0 ||
                    //    _nhanVienService.GetNhaCungCaps(id).Count > 0 ||
                    //    _nhanVienService.GetNhapKhos(id).Count > 0 ||
                    //    _nhanVienService.GetQuayHangs(id).Count > 0 ||
                    //    _nhanVienService.GetXuatKhos(id).Count > 0)
                    //{
                    //    MessageBox.Show(@"Nhân Viên đã được sủ dụng trong cơ sở dữ liệu", @"Thong Bao", MessageBoxButtons.OK);
                    //}
                    //else
                    //{
                    if (selRow.TenDangNhap == "admin")
                    {
                        MessageBox.Show(@"Bạn không thể xóa tài khoản Admin", @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (DialogResult.Yes ==
                            MessageBox.Show(
                                string.Format("Bạn có muốn xóa thông tin nhân viên : {0}", selRow.HoVaTen),
                                @"Xác Nhận", MessageBoxButtons.YesNo))
                        {
                            _nhanVienService.DeleteNhanVien(selRow.Id);
                            _nhanVienService.Save();
                            ShowData();
                        }
                    }

                    //}                    
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
