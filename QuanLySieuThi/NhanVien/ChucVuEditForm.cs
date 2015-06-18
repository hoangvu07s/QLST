using System;
using Common.Forms;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.NhanVien
{
    //TODO VuDao: need to check duplidate chuc vu when we Edit or Add new chuc vu
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
            }}

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
            AcceptAndSavechange();
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
                        chucVu.NguoiChinhSuaId = CurrentUserId;
                        chucVu.NguoiTaoId = CurrentUserId;
                    }
                    else
                    {
                        chucVu.NgayChinhSua = DateTime.Now;
                        chucVu.NguoiChinhSuaId = CurrentUserId;
                    }

                    chucVu.HoatDong = true;}
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
