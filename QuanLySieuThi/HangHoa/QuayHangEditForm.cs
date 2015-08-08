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
    public partial class QuayHangEditForm
    {
        private readonly QuayHangService _quayHangService;

        public QuayHangEditForm(long? quayHangId)
        {
            InitializeComponent();

            MinimumSizeWidth = 472;
            MinimumSizeHeight = 150;

            EntityId = quayHangId.ToString();

            _quayHangService = new QuayHangService(Entities);
        }

        public override void BindData(EventArgs e)
        {
            try
            {
                DataBinding.BindEditor(TenQuayHangTextBox, "Text", Entity, "TenQuay");
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
                    Entity = _quayHangService.Add();
                }
                else
                {
                    FormMode = FormMode.Edit;
                    Entity = _quayHangService.Get(EntityId.ToLong());
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
                _quayHangService.Save();
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
                var quayHang = Entity as QuayHang;
                if (quayHang != null)
                {
                    if (FormMode == FormMode.Add)
                    {
                        quayHang.NgayChinhSua = DateTime.Now;
                        quayHang.NgayTao = DateTime.Now;
                        quayHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                        quayHang.NguoiTaoId = CurrentFormInfo.CurrentUserId;
                    }
                    else
                    {
                        quayHang.NgayChinhSua = DateTime.Now;
                        quayHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                    }

                    quayHang.HoatDong = true;
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
                var quayHang = Entity as QuayHang;
                if (quayHang != null)
                {
                    if (string.IsNullOrEmpty(quayHang.TenQuay))
                    {
                        MessageBox.Show(
                                @"Vui long nhap Ten Quay Hang",
                                @"Thong Bao", MessageBoxButtons.OK);

                        return false;
                    }

                    if (FormMode == FormMode.Add)
                    {
                        var quayHangInDatabase = _quayHangService.GetByTenQuayHang(quayHang.TenQuay);
                        if (quayHangInDatabase != null)
                        {
                            MessageBox.Show(
                                @"Ten Quay Hang da ton tai trong co so du lieu",
                                @"Thong Bao", MessageBoxButtons.OK);

                            return false;
                        }
                    }
                    else if (FormMode == FormMode.Edit)
                    {
                        var quayHangInDatabase = _quayHangService.GetByTenQuayHang(quayHang.TenQuay);
                        if (quayHangInDatabase != null && quayHangInDatabase.Id != quayHang.Id)
                        {
                            MessageBox.Show(
                                @"Ten Quay Hang da ton tai trong co so du lieu",
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
