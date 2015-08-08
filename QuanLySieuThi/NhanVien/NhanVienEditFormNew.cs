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
    public partial class NhanVienEditFormNew
    {
        private readonly NhanVienService _nhanVienService;
        private readonly ChucVuService _chucVuService;
        private IList<GioiTinh> _gioiTinhs;
        private IList<ChucVu> _chucVus;

        public NhanVienEditFormNew(long? nhanvienId)
        {
            InitializeComponent();

            EntityId = nhanvienId.ToString();

            _nhanVienService = new NhanVienService(Entities);
            _chucVuService = new ChucVuService(Entities);
        }

        public override void BindData(EventArgs e)
        {
            try
            {
                DataBinding.BindEditor(HoVaTenTextBox, "Text", Entity, "HoVaTen");
                DataBinding.BindLookupEdit(GioiTinhLookupEdit, "EditValue", Entity, _gioiTinhs, "GioiTinh", "Name",
                    "BooleanValue","Name");
                DataBinding.BindEditor(NgaySinhDateEdit, "EditValue", Entity, "NgayThangNamSinh");
                DataBinding.BindEditor(TenDangNhapTextBox, "Text", Entity, "TenDangNhap");
                DataBinding.BindEditor(MatKhauTextBox, "Text", Entity, "MatKhau");
                DataBinding.BindLookupEdit(ChucVuLookupEdit, "EditValue", Entity, _chucVus, "ChucVuId", "TenChucVu",
                        "Id","TenChucVu");
                DataBinding.BindEditor(SoDienThoaiTextBox, "Text", Entity, "SoDienThoai");
                DataBinding.BindEditor(EmailTextBox, "Text", Entity, "Email");
                DataBinding.BindEditor(DiaChiTextBox, "Text", Entity, "DiaChi");
            }
            catch (Exception ex){
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public override void LoadData(EventArgs e)
        {
            try
            {
                _gioiTinhs = InitGioiTinhs();
                _chucVus = _chucVuService.GetChucVus();
                if (string.IsNullOrEmpty(EntityId))
                {
                    FormMode = FormMode.Add;
                    Entity = _nhanVienService.AddNhanVien();
                }
                else
                {
                    FormMode = FormMode.Edit;
                    Entity = _nhanVienService.GetNhanVien(EntityId.ToLong());
                    var nhanVien = Entity as Model.NhanVien;
                    if (nhanVien != null) nhanVien.MatKhau = nhanVien.MatKhau.Decrypt();
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
                        Name = "Nu",
                        BooleanValue = false
                    }
                };

            return gioitinhs;
        }

        private void CancelButtonControl_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput(e))
            {
                AcceptAndSavechange();
            }
        }

        public override void SaveData(EventArgs e)
        {
            try
            {
                _nhanVienService.Save();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public override void CollectInput(EventArgs e)
        {
            try
            {
                var nhanVien = Entity as Model.NhanVien;
                if (nhanVien != null)
                {
                    if (FormMode == FormMode.Add)
                    {
                        nhanVien.NgayChinhSua = DateTime.Now;
                        nhanVien.NgayTao = DateTime.Now;
                        nhanVien.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                        nhanVien.NguoiTaoId = CurrentFormInfo.CurrentUserId;
                    }
                    else
                    {
                        nhanVien.NgayChinhSua = DateTime.Now;
                        nhanVien.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                    }

                    nhanVien.HoatDong = true;
                    nhanVien.MatKhau = nhanVien.MatKhau.Encrypt();
                }
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
                        MessageBox.Show(@"Vui long nhap Ho Ten", @"Thong Bao", MessageBoxButtons.OK);
                        return false;
                    }

                    if (string.IsNullOrEmpty(nhanVien.TenDangNhap))
                    {
                        MessageBox.Show(@"Vui long nhap Ten Dang Nhap", @"Thong Bao", MessageBoxButtons.OK);
                        return false;
                    }

                    if (string.IsNullOrEmpty(nhanVien.MatKhau))
                    {
                        MessageBox.Show(@"Vui long nhap Mat Khau", @"Thong Bao", MessageBoxButtons.OK);
                        return false;
                    }

                    if (nhanVien.ChucVuId == 0)
                    {
                        MessageBox.Show(@"Vui long chon Chuc Vu", @"Thong Bao", MessageBoxButtons.OK);
                        return false;
                    }

                    if (string.IsNullOrEmpty(nhanVien.Email))
                    {
                        MessageBox.Show(@"Vui long nhap Email", @"Thong Bao", MessageBoxButtons.OK);
                        return false;
                    }

                    if (string.IsNullOrEmpty(nhanVien.DiaChi))
                    {
                        MessageBox.Show(@"Vui long nhap Dia Chi", @"Thong Bao", MessageBoxButtons.OK);
                        return false;
                    }

                    if (nhanVien.NgayThangNamSinh >= DateTime.Now)
                    {
                        MessageBox.Show(@"Ngay Thang Nam Sinh khong duoc lon hon hien tai", @"Thong Bao", MessageBoxButtons.OK);
                        return false;
                    }

                    if (string.IsNullOrEmpty(nhanVien.SoDienThoai))
                    {
                        MessageBox.Show(@"Vui long nhap So Dien Thoai", @"Thong Bao", MessageBoxButtons.OK);
                        return false;
                    }

                    if (FormMode == FormMode.Add)
                    {
                        var nhanVienInDatabase = _nhanVienService.GetByTenDangNhap(nhanVien.TenDangNhap);
                        if (nhanVienInDatabase != null)
                        {
                            MessageBox.Show(
                                @"Ten Dang Nhap da ton tai trong co so du lieu",
                                @"Thong Bao", MessageBoxButtons.OK);

                            return false;
                        }
                    }
                    else
                    {
                        var nhanVienInDatabase = _nhanVienService.GetByTenDangNhap(nhanVien.TenDangNhap);
                        if (nhanVienInDatabase != null && nhanVienInDatabase.Id != nhanVien.Id)
                        {
                            MessageBox.Show(
                                @"Ten Dang Nhap da ton tai trong co so du lieu",
                                @"Thong Bao", MessageBoxButtons.OK);

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
    }
}
