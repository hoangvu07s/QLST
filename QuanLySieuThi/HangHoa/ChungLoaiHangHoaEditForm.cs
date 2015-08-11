using System;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.HangHoa
{
    public partial class ChungLoaiHangHoaEditForm
    {
        private readonly ChungLoaiHangHoaService _chungLoaiHangHoaService;
        public ChungLoaiHangHoaEditForm(long? chungLoaiHangHoaId)
        {
            InitializeComponent();

            MinimumSizeWidth = 472;
            MinimumSizeHeight = 150;

            EntityId = chungLoaiHangHoaId.ToString();

            _chungLoaiHangHoaService = new ChungLoaiHangHoaService(Entities);

        }

        public override void BindData(EventArgs e)
        {
            try
            {
                DataBinding.BindEditor(TenChungLoaiTextBox, "Text", Entity, "TenChungLoai");
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
                    Entity = _chungLoaiHangHoaService.Add();
                }
                else
                {
                    FormMode = FormMode.Edit;
                    Entity = _chungLoaiHangHoaService.Get(EntityId.ToLong());
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput(e))
            {
                AcceptAndSavechange();
            }
        }

        private void CancelButtonControl_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        public override void SaveData(EventArgs e)
        {
            try
            {
                _chungLoaiHangHoaService.Save();
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
                var chungLoaiHangHoa = Entity as ChungLoaiHangHoa;
                if (chungLoaiHangHoa != null)
                {
                    if (FormMode == FormMode.Add)
                    {
                        chungLoaiHangHoa.NgayChinhSua = DateTime.Now;
                        chungLoaiHangHoa.NgayTao = DateTime.Now;
                        chungLoaiHangHoa.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                        chungLoaiHangHoa.NguoiTaoId = CurrentFormInfo.CurrentUserId;
                    }
                    else
                    {
                        chungLoaiHangHoa.NgayChinhSua = DateTime.Now;
                        chungLoaiHangHoa.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                    }

                    chungLoaiHangHoa.HoatDong = true;
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
                var chungLoaiHangHoa = Entity as ChungLoaiHangHoa;
                if (chungLoaiHangHoa != null)
                {
                    if (string.IsNullOrEmpty(chungLoaiHangHoa.TenChungLoai))
                    {
                        MessageBox.Show(
                                @"Vui long nhap Ten Chung Loai Hang Hoa",
                                @"Thong Bao", MessageBoxButtons.OK);

                        return false;
                    }

                    if (FormMode == FormMode.Add)
                    {
                        var chungLoaiHangHoaInDatabase =
                            _chungLoaiHangHoaService.GetByTenChungLoaiHangHoa(chungLoaiHangHoa.TenChungLoai);
                        if (chungLoaiHangHoaInDatabase != null)
                        {
                            MessageBox.Show(
                                @"Ten Chung Loai Hang Hoa da ton tai trong co so du lieu",
                                @"Thong Bao", MessageBoxButtons.OK);

                            return false;
                        }
                    }
                    else if (FormMode == FormMode.Edit)
                    {
                        var chungLoaiHangHoaInDatabase =
                            _chungLoaiHangHoaService.GetByTenChungLoaiHangHoa(chungLoaiHangHoa.TenChungLoai);
                        if (chungLoaiHangHoaInDatabase != null && chungLoaiHangHoaInDatabase.Id != chungLoaiHangHoa.Id)
                        {
                            MessageBox.Show(
                                @"Ten Chung Loai da ton tai trong co so du lieu",
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
