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
    public partial class QuanLyChungLoaiHangHoa : QuanLySieuThiForm
    {
        private ChungLoaiHangHoaService _chungLoaiHangHoaService;
        private Object _selRow;

        private bool _isSelectedRow = true;
        public QuanLyChungLoaiHangHoa()
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
                DataBinding.BindEditor(ChungLoaiHangHoaTextBox, "Text", Entity, "TenChungLoai");
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
                _chungLoaiHangHoaService = new ChungLoaiHangHoaService(Entities);
                var chungLoais = _chungLoaiHangHoaService.GetAll();

                chungLoaiHangHoaGridControl.DataSource = chungLoais;
                chungLoaiHangHoaGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ReadOnlyControls(bool isReadOnly)
        {
            ChungLoaiHangHoaTextBox.Properties.ReadOnly = isReadOnly;
        }

        private void chungLoaiHangHoaGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (_isSelectedRow)
                {
                    _selRow = chungLoaiHangHoaGridView.GetRow(e.FocusedRowHandle);

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
                var chungLoaiHangHoa = _chungLoaiHangHoaService.Add();

                Entity = chungLoaiHangHoa;

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
                var chungLoaiHangHoa = Entity as ChungLoaiHangHoa;
                if (chungLoaiHangHoa != null)
                {
                    if (string.IsNullOrEmpty(chungLoaiHangHoa.TenChungLoai))
                    {
                        MessageBox.Show(
                                @"Vui lòng nhập tên Chủng Loại Hàng Hóa",
                                @"Thông Báo", MessageBoxButtons.OK);

                        return false;
                    }

                    if (FormMode == FormMode.Add)
                    {
                        var chungLoaiHangHoaInDatabase =
                            _chungLoaiHangHoaService.GetByTenChungLoaiHangHoa(chungLoaiHangHoa.TenChungLoai);
                        if (chungLoaiHangHoaInDatabase != null)
                        {
                            MessageBox.Show(
                                @"Tên Chủng Loại Hàng Hóa đã tồn tại trong cơ sở dữ liệu",
                                @"Thông Báo", MessageBoxButtons.OK);

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
                                @"Tên Chủng Loại Hàng Hóa đã tồn tại trong cơ sở dữ liệu",
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
                    else if (FormMode == FormMode.Edit)
                    {
                        chungLoaiHangHoa.NgayChinhSua = DateTime.Now;
                        chungLoaiHangHoa.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;

                        _chungLoaiHangHoaService.Update(chungLoaiHangHoa);
                    }

                    chungLoaiHangHoa.HoatDong = true;

                    _chungLoaiHangHoaService.Save();
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
                var selRow = _selRow as ChungLoaiHangHoa;
                if (selRow != null)
                {
                    var id = selRow.Id;
                    var loaiHangHoa = _chungLoaiHangHoaService.GetLoaiHangHoas(id);
                    if (loaiHangHoa.Count > 0)
                    {
                        MessageBox.Show(@"Chủng loại hàng hóa này vẫn còn Loại hàng hóa.", @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (DialogResult.Yes ==
                         MessageBox.Show(string.Format("Bạn có muốn xóa Chủng Loại Hàng Hóa '{0}' ?", selRow.TenChungLoai),
                             @"Xác Nhận", MessageBoxButtons.YesNo))
                        {
                            _chungLoaiHangHoaService.Delete(selRow.Id);
                            _chungLoaiHangHoaService.Save();
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

        private void LoaiHangHoaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _selRow as ChungLoaiHangHoa;
                if (selRow != null)
                {
                    var loaiHangHoaListForm = new QuanLyLoaiHangHoaForm(selRow.Id);
                    loaiHangHoaListForm.ShowForm("OpenQuanLyLoaiHangHoaForm");
                    loaiHangHoaListForm.FormClosed += ChungLoaiHangHoaEditFormClosed;
                }

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ChungLoaiHangHoaEditFormClosed(object sender, FormClosedEventArgs a)
        {
            try
            {
                ShowData();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
