using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Service;

namespace QuanLySieuThi.Kho
{
    public partial class KhoHangEditForm
    {
        private readonly KhoHangService _khoHangService;
        private readonly NhanVienService _nhanVienService;
        private IList<Model.NhanVien> _nhanViens;

        public KhoHangEditForm(long? khoId)
        {
            InitializeComponent();

            MinimumSizeWidth = 472;
            MinimumSizeHeight = 150;

            EntityId = khoId.ToString();

            _khoHangService = new KhoHangService(Entities);
            _nhanVienService=new NhanVienService(Entities);
        }

        public override void BindData(EventArgs e)
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

        public override void LoadData(EventArgs e)
        {
            try
            {
                _nhanViens = _nhanVienService.GetNhanViens();

                if (string.IsNullOrEmpty(EntityId))
                {
                    FormMode = FormMode.Add;
                    Entity = _khoHangService.AddKho();
                }
                else
                {
                    FormMode = FormMode.Edit;
                    Entity = _khoHangService.Get(EntityId.ToLong());
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
                _khoHangService.Save();
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
                    else
                    {
                        khoHang.NgayChinhSua = DateTime.Now;
                        khoHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                    }

                    khoHang.HoatDong = true;
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

                    if (FormMode == FormMode.Add)
                    {
                        var khoHangs = _khoHangService.GetAll();
                        if (
                            khoHangs.Any(
                                _ =>
                                    _.TenKho == khoHang.TenKho || _.DiaChi == khoHang.DiaChi ||
                                    _.SoDienThoai == khoHang.SoDienThoai))
                        {
                            MessageBox.Show(@"Tên Kho Hàng, Địa Chỉ và Số Điện Thoại Đã Tồn Tại", @"Thông Báo", MessageBoxButtons.OK);
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
