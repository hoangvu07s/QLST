using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.HangHoa
{
    public partial class LoaiHangHoaEditForm
    {
        private readonly LoaiHangHoaService _loaiHangHoaService;
        private readonly ChungLoaiHangHoaService _chungLoaiHangHoaService;

        private IList<ChungLoaiHangHoa> _chungLoaiHangHoas; 
        public LoaiHangHoaEditForm(long? loaiHangHoaId)
        {
            InitializeComponent();

            MinimumSizeWidth = 472;
            MinimumSizeHeight = 150;

            EntityId = loaiHangHoaId.ToString();
            _loaiHangHoaService = new LoaiHangHoaService(Entities);
            _chungLoaiHangHoaService = new ChungLoaiHangHoaService(Entities);
        }

        public override void BindData(EventArgs e)
        {
            try
            {
                DataBinding.BindEditor(TenLoaiHangHoaTextBox, "Text", Entity, "TenLoaiHangHoa");
                DataBinding.BindLookupEdit(TenChungLoaiHangHoaLookupEdit, "EditValue", Entity, _chungLoaiHangHoas,
                    "ChungLoaiId", "TenChungLoai", "Id", "TenChungLoai");
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
                _chungLoaiHangHoas = _chungLoaiHangHoaService.GetAll();

                if (string.IsNullOrEmpty(EntityId))
                {
                    FormMode = FormMode.Add;
                    Entity = _loaiHangHoaService.Add();
                }
                else
                {
                    FormMode = FormMode.Edit;
                    Entity = _loaiHangHoaService.Get(EntityId.ToLong());
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
                var loaiHangHoa = Entity as LoaiHangHoa;
                if (loaiHangHoa != null)
                {
                    if (FormMode == FormMode.Add)
                    {
                        loaiHangHoa.NgayChinhSua = DateTime.Now;
                        loaiHangHoa.NgayTao = DateTime.Now;
                        loaiHangHoa.NguoiChinhSuaId = CurrentUserId;
                        loaiHangHoa.NguoiTaoId = CurrentUserId;
                    }
                    else
                    {
                        loaiHangHoa.NgayChinhSua = DateTime.Now;
                        loaiHangHoa.NguoiChinhSuaId = CurrentUserId;
                    }

                    loaiHangHoa.HoatDong = true;
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
                var loaiHangHoa = Entity as LoaiHangHoa;
                if (loaiHangHoa != null)
                {
                    if (string.IsNullOrEmpty(loaiHangHoa.TenLoaiHangHoa))
                    {
                        MessageBox.Show(
                                @"Vui long nhap Ten Loai Hang Hoa",
                                @"Thong Bao", MessageBoxButtons.OK);

                        return false;
                    }

                    if (loaiHangHoa.ChungLoaiId == 0)
                    {
                        MessageBox.Show(
                                @"Vui long chon Chung Loai Hang Hoa",
                                @"Thong Bao", MessageBoxButtons.OK);

                        return false;
                    }

                    if (FormMode == FormMode.Add)
                    {
                        var loaiHangHoaInDatabase = _loaiHangHoaService.GetByTenLoaiHangHoa(loaiHangHoa.TenLoaiHangHoa);
                        if (loaiHangHoaInDatabase != null)
                        {
                            MessageBox.Show(
                                @"Ten Loai Hang Hoa da ton tai trong co so du lieu",
                                @"Thong Bao", MessageBoxButtons.OK);

                            return false;
                        }
                    }
                    else
                    {
                        var loaiHangHoaInDatabase = _loaiHangHoaService.GetByTenLoaiHangHoa(loaiHangHoa.TenLoaiHangHoa);
                        if (loaiHangHoaInDatabase != null && loaiHangHoaInDatabase.Id != loaiHangHoa.Id)
                        {
                            MessageBox.Show(
                                @"Ten Loai Hang Hoa da ton tai trong co so du lieu",
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
