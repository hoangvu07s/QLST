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
    public partial class HangHoaEditForm
    {
        private HangHoaService _hangHoaService;
        private LoaiHangHoaService _loaiHangHoaService;
        private NhaCungCapService _nhaCungCapService;
        private QuayHangService _quayHangService;

        private IList<LoaiHangHoa> _loaiHangHoas;
        private IList<Model.NhaCungCap> _nhaCungCaps;
        private IList<QuayHang> _quayHangs; 

        public HangHoaEditForm(long? hangHoaId)
        {
            InitializeComponent();

            EntityId = hangHoaId.ToString();

            _hangHoaService = new HangHoaService(Entities);
            _loaiHangHoaService = new LoaiHangHoaService(Entities);
            _nhaCungCapService = new NhaCungCapService(Entities);
            _quayHangService = new QuayHangService(Entities);
        }

        public override void BindData(EventArgs e)
        {
            try
            {
                DataBinding.BindEditor(TenHangHoaTextBox, "Text", Entity, "TenHangHoa");
                DataBinding.BindLookupEdit(LoaiHangHoaLookupEdit, "EditValue", Entity, _loaiHangHoas, "LoaiHangHoaId", "TenLoaiHangHoa", "Id", "TenLoaiHangHoa");
                DataBinding.BindLookupEdit(NhaCungCapLookupEdit, "EditValue", Entity, _nhaCungCaps, "NhaCungCapId", "TenNhaCungCap", "Id", "TenNhaCungCap");
                DataBinding.BindLookupEdit(QuayHangLookupEdit, "EditValue", Entity, _quayHangs, "QuayHangId", "TenQuay", "Id", "TenQuay");
                DataBinding.BindEditor(TraLaiCheckEdit, "EditValue", Entity, "CoTheTraLai");
                DataBinding.BindEditor(GiaNhapVaoNummeric, "Text", Entity, "GiaNhapVao");
                DataBinding.BindEditor(GiaBanRaNummeric, "Text", Entity, "GiaBanRa");
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
                _loaiHangHoas = _loaiHangHoaService.GetAll();
                _nhaCungCaps = _nhaCungCapService.GetAll();
                _quayHangs = _quayHangService.GetAll();

                if (string.IsNullOrEmpty(EntityId))
                {
                    FormMode = FormMode.Add;
                    Entity = _hangHoaService.AddHangHoa();
                }
                else
                {
                    FormMode = FormMode.Edit;
                    Entity = _hangHoaService.Get(EntityId.ToLong());
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
                _hangHoaService.Save();
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
                var hangHoa = Entity as Model.HangHoa;
                if (hangHoa != null)
                {
                    if (FormMode == FormMode.Add)
                    {
                        hangHoa.NgayChinhSua = DateTime.Now;
                        hangHoa.NgayTao = DateTime.Now;
                        hangHoa.NguoiChinhSuaId = CurrentUserId;
                        hangHoa.NguoiTaoId = CurrentUserId;
                    }
                    else
                    {
                        hangHoa.NgayChinhSua = DateTime.Now;
                        hangHoa.NguoiChinhSuaId = CurrentUserId;
                    }

                    hangHoa.HoatDong = true;
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
                var hangHoa = Entity as Model.HangHoa;
                if (hangHoa != null)
                {
                    if (string.IsNullOrEmpty(hangHoa.TenHangHoa))
                    {
                        MessageBox.Show(@"Vui lòng nhập Tên Hàng Hóa", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (hangHoa.LoaiHangHoaId == 0)
                    {
                        MessageBox.Show(@"Vui lòng lòng chọn Loại Hàng Hóa", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (hangHoa.NhaCungCapId == 0)
                    {
                        MessageBox.Show(@"Vui lòng lòng chọn Nhà Cung Cấp", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (hangHoa.QuayHangId == 0)
                    {
                        MessageBox.Show(@"Vui lòng lòng chọn Quầy Hàng", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }

                    if (FormMode == FormMode.Add)
                    {
                        var hangHoaInDatabase = _hangHoaService.GetByTenHangHoa(hangHoa.TenHangHoa);
                        if (hangHoaInDatabase != null)
                        {
                            MessageBox.Show(
                                @"Tên Hàng Hóa đã tồn tại trong cơ sở dữ liệu",
                                @"Thông Báo", MessageBoxButtons.OK);

                            return false;
                        }
                    }
                    else if(FormMode == FormMode.Edit)
                    {
                        var hangHoaInDatabase = _hangHoaService.GetByTenHangHoa(hangHoa.TenHangHoa);
                        if (hangHoaInDatabase != null && hangHoaInDatabase.Id != hangHoa.Id)
                        {
                            MessageBox.Show(
                                @"Tên Hàng Hóa đã tồn tại trong cơ sở dữ liệu",
                                @"Thông Báo", MessageBoxButtons.OK);

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
