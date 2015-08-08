using System;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Service;

namespace QuanLySieuThi.NhaCungCap
{
    public partial class NhaCungCapEditForm
    {
        private readonly NhaCungCapService _nhaCungCapService;
        public NhaCungCapEditForm(long? nhaCungCapId)
        {
            InitializeComponent();

            MinimumSizeWidth = 472;
            MinimumSizeHeight = 150;

            EntityId = nhaCungCapId.ToString();

            _nhaCungCapService = new NhaCungCapService(Entities);
        }

        public override void BindData(EventArgs e)
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

        public override void LoadData(EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(EntityId))
                {
                    FormMode = FormMode.Add;
                    Entity = _nhaCungCapService.Add();
                }
                else
                {
                    FormMode = FormMode.Edit;
                    Entity = _nhaCungCapService.Get(EntityId.ToLong());
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
                _nhaCungCapService.Save();
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
                    else
                    {
                        nhaCungCap.NgayChinhSua = DateTime.Now;
                        nhaCungCap.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                    }

                    nhaCungCap.HoatDong = true;
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
                var nhaCungCap = Entity as Model.NhaCungCap;
                if (nhaCungCap != null)
                {
                    if (string.IsNullOrEmpty(nhaCungCap.TenNhaCungCap))
                    {
                        MessageBox.Show(
                                @"Vui long nhap Ten Nha Cung Cap",
                                @"Thong Bao", MessageBoxButtons.OK);

                        return false;
                    }

                    if (string.IsNullOrEmpty(nhaCungCap.TenCongTy))
                    {
                        MessageBox.Show(
                                @"Vui long nhap Ten Cong Ty",
                                @"Thong Bao", MessageBoxButtons.OK);

                        return false;
                    }

                    if (string.IsNullOrEmpty(nhaCungCap.DiaChi))
                    {
                        MessageBox.Show(
                                @"Vui long nhap Dia Chi",
                                @"Thong Bao", MessageBoxButtons.OK);

                        return false;
                    }

                    if (string.IsNullOrEmpty(nhaCungCap.SoDienThoai))
                    {
                        MessageBox.Show(
                                @"Vui long nhap So Dien Thoai",
                                @"Thong Bao", MessageBoxButtons.OK);

                        return false;
                    }

                    if (FormMode == FormMode.Add)
                    {
                        var nhaCungCapInDatabase = _nhaCungCapService.GetByTenNhaCungCap(nhaCungCap.TenNhaCungCap);
                        if (nhaCungCapInDatabase != null)
                        {
                            MessageBox.Show(
                                @"Ten Nha Cung Cap da ton tai trong co so du lieu",
                                @"Thong Bao", MessageBoxButtons.OK);

                            return false;
                        }
                    }
                    else if(FormMode == FormMode.Edit)
                    {
                        var nhaCungCapInDatabase = _nhaCungCapService.GetByTenNhaCungCap(nhaCungCap.TenNhaCungCap);
                        if (nhaCungCapInDatabase != null && nhaCungCapInDatabase.Id != nhaCungCap.Id)
                        {
                            MessageBox.Show(
                                @"Ten Nha Cung Cap da ton tai trong co so du lieu",
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
