using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Common.Forms;
using DevExpress.XtraEditors.Controls;
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

        public Model.NhanVien NhanVien;

        private bool _isSearchForm;
        private bool _isValidate = true;

        private IList<Quyen> _quyens;
        private QuyenService _quyenService;
        private QuyenNhanVienService _quyenNhanVienService;

        public QuanLyNhanVienForm(bool isSearchForm = false)
        {
            InitializeComponent();
            MinimumSizeWidth = 1003;
            MinimumSizeHeight = 602;

            _isSearchForm = isSearchForm;
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);

            try
            {
                _quyenNhanVienService = new QuyenNhanVienService(Entities);
                _gioiTinhs = InitGioiTinhs();

                _chucVuService = new ChucVuService(Entities);
                _chucVus = _chucVuService.GetChucVus();

                _quyenService = new QuyenService(Entities);
                _quyens = _quyenService.GetAll();

                QuyenLookupEdit.Properties.DataSource = _quyens;
                QuyenLookupEdit.Properties.ValueMember = "Id";
                QuyenLookupEdit.Properties.DisplayMember = "Quyen1";
                QuyenLookupEdit.Properties.Columns.Clear();
                foreach (var column in new List<string>(){"Quyen1"})
                {
                    QuyenLookupEdit.Properties.Columns.Add(new LookUpColumnInfo(column));
                }

                ShowData();

                ReadOnlyControls(true);
                SaveButton.Enabled = false;
                RefreshButton.Enabled = false;

                if (_isSearchForm)
                {
                    HoVaTenTextBox.Enabled = false;
                    TenDangNhapTextBox.Enabled = false;
                    MatKhauTextBox.Enabled = false;
                    EmailTextBox.Enabled = false;
                    DiaChiTextBox.Enabled = false;
                    GioiTinhLookupEdit.Enabled = false;
                    NgayThangNamSinhDateEdit.Enabled = false;
                    ChucVuLookupEdit.Enabled = false;
                    SoDienThoaiTextBox.Enabled = false;
                    AddButton.Enabled = false;
                    SaveButton.Enabled = false;
                    EditButton.Enabled = false;
                    DeleteButton.Enabled = false;
                    RefreshButton.Enabled = false;
                    QuyenLookupEdit.Enabled = false;
                    SelectButton.Enabled = true;
                }
                else
                {
                    SelectButton.Enabled = false;
                }
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
                var nhanViens = _nhanVienService.GetAllNhanVien();

                var admin = nhanViens.FirstOrDefault(_ => _.TenDangNhap == "admin");
                if (admin != null)
                {
                    nhanViens.Remove(admin);
                }

                //var nhanViensTemp = nhanViens.ToList().DeepCopy();
                var nhanViensTemp = new List<Model.NhanVien>();
                foreach (var nhanVien in nhanViens)
                {
                    nhanViensTemp.Add(nhanVien.DeepCopy());
                }

                //CollectNhanViens(nhanViensTemp);

                foreach (var nhanVien in nhanViensTemp)
                {
                    var quyenNhanVien =_quyenNhanVienService.GetByNhanVienId(nhanVien.Id);
                    if (quyenNhanVien != null)
                    {
                        nhanVien.TenQuyen = quyenNhanVien.Quyen.Quyen1;
                    }                   
                }

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

                    var nhanVien = _selRow as Model.NhanVien;

                    if (nhanVien != null)
                    {
                        var quyenNhanVien = _quyenNhanVienService.GetByNhanVienId(nhanVien.Id);

                        QuyenLookupEdit.EditValue = quyenNhanVien.QuyenId;
                    }
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
            if (CurrentFormInfo.QuyenId == (long) QuyenNhanVienEnum.Admin)
            {
                QuyenLookupEdit.Properties.ReadOnly = isDisable;
            }
            else
            {
                QuyenLookupEdit.Properties.ReadOnly = true;
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

                MatKhauTextBox.Text = MatKhauTextBox.Text.Decrypt();
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
                if (_isValidate)
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

                    /*    if (string.IsNullOrEmpty(nhanVien.Email))
                        {
                            MessageBox.Show(@"Vui lòng nhập Email", @"Thông Báo", MessageBoxButtons.OK);
                            return false;
                        }*/

                        if (nhanVien.Email != null)
                        {
                            if (!Regexp.checkForMail(nhanVien.Email))
                            {
                                MessageBox.Show(@"Email của bạn không đúng vui lòng kiểm tra lại.", @"Thông Báo", MessageBoxButtons.OK);
                                return false;
                            }
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

                        if (nhanVien.SoDienThoai != null)
                        {
                            if (!Regexp.checkPhone(nhanVien.SoDienThoai))
                            {
                                MessageBox.Show(@"Số điện thoại của bạn không đúng vui lòng kiểm tra lại.", @"Thông Báo", MessageBoxButtons.OK);
                                return false;
                            }
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

                            var nhanViens = _nhanVienService.GetNhanViensBySoDitenThoai(nhanVien.SoDienThoai);
                            if (nhanViens.Count > 0)
                            {
                                MessageBox.Show(@"Số Điện Thoại đã tồn tại.", @"Thông Báo", MessageBoxButtons.OK);
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

                            var nhanViens = _nhanVienService.GetNhanViensBySoDitenThoai(nhanVien.SoDienThoai);
                            nhanVienInDatabase = _nhanVienService.GetNhanVien(nhanVien.Id);
                            nhanViens.Remove(nhanVienInDatabase);

                            if (nhanViens.Count > 0)
                            {
                                MessageBox.Show(@"Số Điện Thoại đã tồn tại.", @"Thông Báo", MessageBoxButtons.OK);
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    _isValidate = true;
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
                var nhanVien = Entity as Model.NhanVien;
                

                if (FormMode == FormMode.Edit)
                {
                    if (nhanVien != null && !QuanLySieuThiHelper.IsEncrypted(nhanVien.MatKhau))
                    {
                        nhanVien.MatKhau = nhanVien.MatKhau.Encrypt();
                    }
                    _nhanVienService.Update(nhanVien);
                }
                else
                {
                    if (nhanVien != null) nhanVien.MatKhau = nhanVien.MatKhau.Encrypt();
                }

                _nhanVienService.Save();

                // Save Quyen Nhan Vien
                if (nhanVien != null)
                {
                    var quyenNhienVien = _quyenNhanVienService.GetByNhanVienId(nhanVien.Id);
                    if (quyenNhienVien != null)
                    {
                        quyenNhienVien.QuyenId = QuyenLookupEdit.EditValue.ToString().ToLong();

                        _quyenNhanVienService.Update(quyenNhienVien);
                    }
                    else
                    {
                        quyenNhienVien = _quyenNhanVienService.AddQuyenNhanVien();
                        quyenNhienVien.QuyenId = QuyenLookupEdit.EditValue.ToString().ToLong();
                        quyenNhienVien.NhanVienId = nhanVien.Id;
                        quyenNhienVien.HoatDong = true;
                    }

                    _quyenNhanVienService.Save();
                }
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
                    if (selRow.Id == CurrentFormInfo.CurrentUserId )
                    {
                        MessageBox.Show(@"Bạn đang đăng nhập vào hệ thống này nên bạn không thể xóa thông tin của bạn.", @"Thông Báo", MessageBoxButtons.OK);
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

        private void SelectButton_Click(object sender, EventArgs e)
        {
            var nhanVien = _selRow as Model.NhanVien;
            NhanVien = nhanVien;
            _isValidate = false;
            Close();
        }
    }
}
