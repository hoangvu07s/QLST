using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.HangHoa
{
    public partial class QuanLyHangHoaForm : QuanLySieuThiForm
    {
        private HangHoaService _hangHoaService;
        private LoaiHangHoaService _loaiHangHoaService;
        private NhaCungCapService _nhaCungCapService;
        private QuayHangService _quayHangService;
        private Object _selRow;

        private bool _isSelectedRow = true;

        private IList<LoaiHangHoa> _loaiHangHoas;
        private IList<Model.NhaCungCap> _nhaCungCaps;
        private IList<QuayHang> _quayHangs; 

        public QuanLyHangHoaForm()
        {
            InitializeComponent();

            MinimumSizeWidth = 1003;
            MinimumSizeHeight = 602; 
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);

            try
            {
                _hangHoaService = new HangHoaService(Entities);
                _loaiHangHoaService = new LoaiHangHoaService(Entities);
                _nhaCungCapService = new NhaCungCapService(Entities);
                _quayHangService = new QuayHangService(Entities);
                _loaiHangHoas = _loaiHangHoaService.GetAll();
                _nhaCungCaps = _nhaCungCapService.GetAll();
                _quayHangs = _quayHangService.GetAll();

                ShowData();

                ReadOnlyControls(true);
                SaveButton.Enabled = false;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void BindData()
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

        private void ShowData()
        {
            try
            {
                ResetEntities();
                _hangHoaService = new HangHoaService(Entities);
                var hangHoas = _hangHoaService.GetAll();

                HangHoaGridControl.DataSource = hangHoas;
                HangHoaGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ReadOnlyControls(bool isReadOnly)
        {
            TenHangHoaTextBox.Properties.ReadOnly = isReadOnly;
            LoaiHangHoaLookupEdit.Properties.ReadOnly = isReadOnly;
            NhaCungCapLookupEdit.Properties.ReadOnly = isReadOnly;
            QuayHangLookupEdit.Properties.ReadOnly = isReadOnly;
            TraLaiCheckEdit.Properties.ReadOnly = isReadOnly;
            GiaNhapVaoNummeric.Properties.ReadOnly = isReadOnly;
            GiaBanRaNummeric.Properties.ReadOnly = isReadOnly;
        }

        private void HangHoaGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (_isSelectedRow)
                {
                    _selRow = HangHoaGridView.GetRow(e.FocusedRowHandle);

                    Entity = _selRow;

                    BindData();
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var hangHoa = _hangHoaService.AddHangHoa();

                Entity = hangHoa;

                BindData();
                ReadOnlyControls(false);

                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
                AddButton.Enabled = false;
                SaveButton.Enabled = true;

                _isSelectedRow = false;

                FormMode = FormMode.Add;
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
                    if (GiaNhapVaoNummeric.Text.ToDecimal() <= 0)
                    {
                        MessageBox.Show(@"Giá Nhập vào phải lớn hơn 0", @"Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }
                    if (GiaBanRaNummeric.Text.ToDecimal() <= GiaNhapVaoNummeric.Text.ToDecimal())
                    {
                        MessageBox.Show(@"Giá bán ra phải lớn hơn giá nhập vào", @"Thông Báo", MessageBoxButtons.OK);
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
                    else if (FormMode == FormMode.Edit)
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput(e))
            {
                SaveData();
                ShowData();

                ReadOnlyControls(true);
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;
                SaveButton.Enabled = false;
                AddButton.Enabled = true;

                _isSelectedRow = true;
            }
        }

        private void SaveData()
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
                        hangHoa.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                        hangHoa.NguoiTaoId = CurrentFormInfo.CurrentUserId;
                    }
                    else if (FormMode == FormMode.Edit)
                    {
                        hangHoa.NgayChinhSua = DateTime.Now;
                        hangHoa.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;

                        _hangHoaService.Update(hangHoa);
                    }

                    hangHoa.HoatDong = true;

                    _hangHoaService.Save();
                }

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                ReadOnlyControls(false);

                _isSelectedRow = false;

                AddButton.Enabled = false;
                SaveButton.Enabled = true;
                EditButton.Enabled = false;
                DeleteButton.Enabled = false;

                FormMode = FormMode.Edit;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _selRow as Model.HangHoa;
                if (selRow != null)
                {

                    var hangHoa = _hangHoaService.Get(selRow.Id);
                    if (hangHoa != null)
                    {
                        if (hangHoa.SoLuongTonQuay == null)
                        {
                            hangHoa.SoLuongTonQuay = 0;
                        }
                        if (hangHoa.SoLuongTonQuay != 0 ||
                            hangHoa.TonKhoes.Any(_ => _.SoLuongTon != 0))
                        {
                            MessageBox.Show(
                            @"Số lượng hàng hóa này hiện đang còn số lượng tồn. Bạn không thể xóa",
                            @"Thông Báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (DialogResult.Yes ==
                                    MessageBox.Show(string.Format("Bạn có muốn xóa hàng hóa '{0}' ?", selRow.TenHangHoa),
                                        @"Xác nhận", MessageBoxButtons.YesNo))
                            {
                                _hangHoaService.Delete(selRow.Id);
                                _hangHoaService.Save();
                                ShowData();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            _isSelectedRow = true;
            LoadData(e);
            AddButton.Enabled = true;
            EditButton.Enabled = true;
            DeleteButton.Enabled = true;
        }
    }
}
