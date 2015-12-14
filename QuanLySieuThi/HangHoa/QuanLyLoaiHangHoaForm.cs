using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.HangHoa
{
    public partial class QuanLyLoaiHangHoaForm : QuanLySieuThiForm
    {
        private LoaiHangHoaService _loaiHangHoaService;
        private ChungLoaiHangHoaService _chungLoaiHangHoaService;
        private IList<ChungLoaiHangHoa> _chungLoaiHangHoas; 
        private Object _selRow;

        private bool _isSelectedRow = true;
        private long _chungLoaiHangHoaId;
      
        public QuanLyLoaiHangHoaForm(long chungLoaiHangHoaId)
        {
            InitializeComponent();

            MinimumSizeWidth = 1003;
            MinimumSizeHeight = 602;

            _chungLoaiHangHoaId = chungLoaiHangHoaId;
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);

            try
            {
                _chungLoaiHangHoaService = new ChungLoaiHangHoaService(Entities);
                _chungLoaiHangHoas = _chungLoaiHangHoaService.GetAll();
                ShowData();

                ReadOnlyControls(true);
                SaveButton.Enabled = false;
                TenChungLoaiHangHoaLookupEdit.Properties.ReadOnly = true;
                RefreshButton.Enabled = false;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public void BindData()
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

        private void ShowData()
        {
            try
            {
                ResetEntities();
                _loaiHangHoaService = new LoaiHangHoaService(Entities);
                var loaiHangHoas = _loaiHangHoaService.GetByChungLoaiHangHoaId(_chungLoaiHangHoaId);

                loaiHangHoaGridControl.DataSource = loaiHangHoas;
                loaiHangHoaGridControl.RefreshDataSource();

                var chungLoaiHangHoa = _chungLoaiHangHoaService.Get(_chungLoaiHangHoaId);
                TenChungLoaiHangHoaLookupEdit.SelectedText = chungLoaiHangHoa.TenChungLoai;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ReadOnlyControls(bool isReadOnly)
        {
            TenLoaiHangHoaTextBox.Properties.ReadOnly = isReadOnly;
            //TenChungLoaiHangHoaLookupEdit.Properties.ReadOnly = isReadOnly;
        }

        private void loaiHangHoaGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (_isSelectedRow)
                {
                    _selRow = loaiHangHoaGridView.GetRow(e.FocusedRowHandle);

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
                var loaiHangHoa = _loaiHangHoaService.Add();
                loaiHangHoa.ChungLoaiId = _chungLoaiHangHoaId;

                Entity = loaiHangHoa;

                BindData();
                ReadOnlyControls(false);

                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
                AddButton.Enabled = false;
                SaveButton.Enabled = true;
                RefreshButton.Enabled = true;

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
                var loaiHangHoa = Entity as LoaiHangHoa;
                if (loaiHangHoa != null)
                {
                    if (string.IsNullOrEmpty(loaiHangHoa.TenLoaiHangHoa))
                    {
                        MessageBox.Show(
                                @"Vui lòng nhập tên Loại Hàng Hóa",
                                @"Thông Báo", MessageBoxButtons.OK);

                        return false;
                    }

                    if (loaiHangHoa.ChungLoaiId == 0)
                    {
                        MessageBox.Show(
                                @"Vui lòng chọn Chủng Loại Hàng Hóa",
                                @"Thông Báo", MessageBoxButtons.OK);

                        return false;
                    }

                    if (FormMode == FormMode.Add)
                    {
                        var loaiHangHoaInDatabase = _loaiHangHoaService.GetByTenLoaiHangHoa(loaiHangHoa.TenLoaiHangHoa);
                        if (loaiHangHoaInDatabase != null)
                        {
                            MessageBox.Show(
                                @"Tên Loại Hàng Hóa đã tồn tại trong cơ sở dữ liệu",
                                @"Thông Báo", MessageBoxButtons.OK);

                            return false;
                        }
                    }
                    else
                    {
                        var loaiHangHoaInDatabase = _loaiHangHoaService.GetByTenLoaiHangHoa(loaiHangHoa.TenLoaiHangHoa);
                        if (loaiHangHoaInDatabase != null && loaiHangHoaInDatabase.Id != loaiHangHoa.Id)
                        {
                            MessageBox.Show(
                                @"Tên Loại Hàng Hóa đã tồn tại trong cơ sở dữ liệu",
                                @"Thông Báo", MessageBoxButtons.OK);

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

        private void SaveData()
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
                        loaiHangHoa.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                        loaiHangHoa.NguoiTaoId = CurrentFormInfo.CurrentUserId;
                    }
                    else if (FormMode == FormMode.Edit)
                    {
                        loaiHangHoa.NgayChinhSua = DateTime.Now;
                        loaiHangHoa.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;

                        _loaiHangHoaService.Update(loaiHangHoa);
                    }

                    loaiHangHoa.HoatDong = true;

                    _loaiHangHoaService.Save();
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
                RefreshButton.Enabled = true;
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
                var selRow = _selRow as LoaiHangHoa;
                if (selRow != null)
                {
                    var id = selRow.Id;
                    var hangHoas = _loaiHangHoaService.GetHangHoas(id);
                    if (hangHoas.Count > 0)
                    {
                        MessageBox.Show(@"Loại Hàng Hóa vẫn còn hàng hóa . Bạn chỉ được xóa khi loại hàng hóa này không có mặt hàng nào.", @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (DialogResult.Yes ==
                         MessageBox.Show(string.Format("Bạn có muốn xóa loại Hàng Hóa '{0}' ?", selRow.TenLoaiHangHoa),
                             @"Xác Nhận", MessageBoxButtons.YesNo))
                        {
                            _loaiHangHoaService.Delete(selRow.Id);
                            _loaiHangHoaService.Save();
                            ShowData();
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

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            if (ValidateInput(e))
            {
                SaveData();
                ShowData();

                ReadOnlyControls(true);
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;
                SaveButton.Enabled = false;
                RefreshButton.Enabled = false;
                AddButton.Enabled = true;

                _isSelectedRow = true;
            }
        }
    }
}
