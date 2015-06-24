using System;
using Common.Forms;
using Helper;
using Service;

namespace QuanLySieuThi.NhanVien
{
    public partial class TestForm
    {
        private readonly ChucVuService _chucVuService;
        private readonly NhanVienService _nhanVienService;

        public TestForm(long? chucVuId)
        {
            InitializeComponent();

            EntityId = chucVuId.ToString();

            _chucVuService = new ChucVuService(Entities);
            _nhanVienService = new NhanVienService(Entities);
        }

        public override void BindData(EventArgs e)
        {
            try
            {
                DataBinding.BindEditor(TextTextBox, "Text", Entity, "HoVaTen");
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
                    Entity = _chucVuService.AddChucVu();
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
    }
}
