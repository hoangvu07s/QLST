using System;
using System.Collections.Generic;
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
                    "BooleanValue");
                DataBinding.BindEditor(NgaySinhDateEdit, "EditValue", Entity, "NgayThangNamSinh");
                DataBinding.BindEditor(TenDangNhapTextBox, "Text", Entity, "TenDangNhap");
                DataBinding.BindEditor(MatKhauTextBox, "Text", Entity, "MatKhau");
                DataBinding.BindLookupEdit(ChucVuLookupEdit, "EditValue", Entity, _chucVus, "ChucVuId", "TenChucVu",
                        "Id");
                DataBinding.BindEditor(SoDienThoaiTextBox, "Text", Entity, "SoDienThoai");
                DataBinding.BindEditor(EmailTextBox, "Text", Entity, "Email");
                DataBinding.BindEditor(DiaChiTextBox, "Text", Entity, "DiaChi");
            }
            catch (Exception ex)
            {
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

    }
}
