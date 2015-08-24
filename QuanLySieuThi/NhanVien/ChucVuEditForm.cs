using System;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.NhanVien
{
    public partial class ChucVuEditForm
    {
        private readonly ChucVuService _chucVuService;

        public ChucVuEditForm(long? chucVuId)
        {
            InitializeComponent();

            MinimumSizeWidth = 472;
            MinimumSizeHeight = 150;

            EntityId = chucVuId.ToString();

            _chucVuService = new ChucVuService(Entities);
        }

        public override void BindData(EventArgs e)
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

        public override void LoadData(EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(EntityId))
                {
                    FormMode = FormMode.Add;
                    Entity = _chucVuService.AddChucVu();}
                else
                {
                    FormMode = FormMode.Edit;
                    Entity = _chucVuService.GetChucVu(EntityId.ToLong());
                }}
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
                _chucVuService.Save();
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
                    else
                    {
                        chucVu.NgayChinhSua = DateTime.Now;
                        chucVu.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                    }

                    chucVu.HoatDong = true;}
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
                                @"Vui long nhap Ten Chu Vu",
                                @"Thong Bao", MessageBoxButtons.OK);

                        return false;
                    }

                    if (FormMode == FormMode.Add)
                    {
                        var chucVuInDatabase = _chucVuService.GetByName(chucVu.TenChucVu);
                        if (chucVuInDatabase != null)
                        {
                            MessageBox.Show(
                                @"Ten Chuc Vu da ton tai trong co so du lieu",
                                @"Thong Bao", MessageBoxButtons.OK);

                            return false;
                        }
                    }
                    else if (FormMode == FormMode.Edit)
                    {
                        var chucVuInDatabase = _chucVuService.GetByName(chucVu.TenChucVu);
                        if (chucVuInDatabase != null && chucVuInDatabase.Id != chucVu.Id)
                        {
                            MessageBox.Show(
                                @"Ten Chuc Vu da ton tai trong co so du lieu",
                                @"Thong Bao", MessageBoxButtons.OK);

                            return false;}
                    }                    
                }
                
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return true;
        }

        private void ChucVuTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
