using System;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Service;

namespace QuanLySieuThi.KhachHang
{
    public partial class QuanLyKhachHangForm : QuanLySieuThiForm
    {
        private KhachHangService _khachHangService;
        private TheKhachHangService _theKhachHangService;
        public Model.KhachHang KhachHang;

        private Object _selRow;

        private bool _isSelectedRow = true;
        private bool _isSearched;

        public QuanLyKhachHangForm(bool isSearched = false)
        {
            InitializeComponent();

            MinimumSizeWidth = 1003;
            MinimumSizeHeight = 602;

            _isSearched = isSearched;
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);

            try
            {
                _theKhachHangService = new TheKhachHangService(Entities);

                ShowData();

                ReadOnlyControls(true);
                SaveButton.Enabled = false;
                RefreshButton.Enabled = false;

                if (_isSearched)
                {
                    TenKhachHangTextBox.Enabled = false;
                    DiaChiTextBox.Enabled = false;
                    SoDienThoaiTextBox.Enabled = false;
                    TuoiTextBox.Enabled = false;
                    EmailTextBox.Enabled = false;
                    KhachHangThanThietCheckEdit.Enabled = false;
                    TheKhachHangTextBox.Enabled = false;
                    DiemTichLuyTextBox.Enabled = false;
                    AddButton.Enabled = false;
                    SaveButton.Enabled = false;
                    EditButton.Enabled = false;
                    DeleteButton.Enabled = false;
                    RefreshButton.Enabled = false;
                    SelectButton.Enabled = true;
                }
                else
                {
                    SelectButton.Enabled = false;
                }
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
                _khachHangService = new KhachHangService(Entities);
                var khachHangs = _khachHangService.GetAll();

                KhachHangGridControl.DataSource = khachHangs;
                KhachHangGridControl.RefreshDataSource();
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
                DataBinding.BindEditor(TenKhachHangTextBox, "Text", Entity, "TenKhachHang");
                DataBinding.BindEditor(DiaChiTextBox, "Text", Entity, "DiaChi");
                DataBinding.BindEditor(SoDienThoaiTextBox, "Text", Entity, "SoDienThoai");
                DataBinding.BindEditor(TuoiTextBox, "Text", Entity, "Tuoi");
                DataBinding.BindEditor(EmailTextBox, "Text", Entity, "Email");
                DataBinding.BindEditor(KhachHangThanThietCheckEdit, "EditValue", Entity, "KhachHangThanThiet");

                var khachHang = Entity as Model.KhachHang;
                if (khachHang != null)
                {
                    var theKhachHang = _theKhachHangService.GetByKhachHangId(khachHang.Id);
                    if (theKhachHang == null)
                    {
                        TheKhachHangTextBox.Text = string.Empty;
                        DiemTichLuyTextBox.Text = string.Empty;
                    }
                    else
                    {
                        TheKhachHangTextBox.Text = theKhachHang.TheKhachHangId.ToString();
                        DiemTichLuyTextBox.Text = theKhachHang.DiemTichLuy.ToString();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void ReadOnlyControls(bool isDisable)
        {
            TenKhachHangTextBox.Properties.ReadOnly = isDisable;
            DiaChiTextBox.Properties.ReadOnly = isDisable;
            SoDienThoaiTextBox.Properties.ReadOnly = isDisable;
            TuoiTextBox.Properties.ReadOnly = isDisable;
            EmailTextBox.Properties.ReadOnly = isDisable;
        }

        private void CancelButtonControl_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void KhachHanggridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (_isSelectedRow)
                {
                    _selRow = KhachHanggridView.GetRow(e.FocusedRowHandle);
                    Entity = _selRow;
                    BindData();                  
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var khachHang = _khachHangService.Add();
                khachHang.NgayChinhSua = DateTime.Now;
                khachHang.NgayTao = DateTime.Now;
                khachHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                khachHang.NguoiTaoId = CurrentFormInfo.CurrentUserId;
                khachHang.HoatDong = true;
                Entity = khachHang;

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
                if (_isSearched == false)
                {
                    var khachHang = Entity as Model.KhachHang;
                    if (khachHang != null)
                    {
                        if (string.IsNullOrEmpty(khachHang.TenKhachHang))
                        {
                            MessageBox.Show(@"Vui lòng nhập Tên Khách Hàng.", @"Thông Báo", MessageBoxButtons.OK);
                            return false;
                        }

                        if (string.IsNullOrEmpty(khachHang.DiaChi))
                        {
                            MessageBox.Show(@"Vui lòng nhập Địa Chỉ.", @"Thông Báo", MessageBoxButtons.OK);
                            return false;
                        }

                        if (khachHang.Email != null)
                        {
                            if (!Regexp.checkForMail(khachHang.Email))
                            {
                                MessageBox.Show(@"Email của bạn không đúng vui lòng kiểm tra lại.", @"Thông Báo", MessageBoxButtons.OK);
                                return false;
                            }
                          }

                        if (string.IsNullOrEmpty(khachHang.SoDienThoai))
                        {
                            MessageBox.Show(@"Vui lòng nhập Số Điện Thoại.", @"Thông Báo", MessageBoxButtons.OK);
                            return false;
                        }

                        if (khachHang.SoDienThoai != null)
                        {
                            if (!Regexp.checkPhone(khachHang.SoDienThoai))
                            {
                                MessageBox.Show(@"Số điện thoại của bạn không đúng vui lòng kiểm tra lại.", @"Thông Báo", MessageBoxButtons.OK);
                                return false;
                            }
                        }

                        if (TuoiTextBox.Text.ToInt() <= 0)
                        {
                            MessageBox.Show(@"Nhập Tuổi không đúng, mời nhập lại.", @"Thông Báo", MessageBoxButtons.OK);
                            return false;
                        }

                        if (FormMode == FormMode.Add)
                        {
                            var khachHangs = _khachHangService.GetKhachHangsBySoDienThoai(khachHang.SoDienThoai);
                            if (khachHangs.Count > 0)
                            {
                                MessageBox.Show(@"Số Điện Thoại đã tồn tại.", @"Thông Báo", MessageBoxButtons.OK);
                                return false;
                            }
                        }

                        if (FormMode == FormMode.Edit)
                        {
                            var khachHangs = _khachHangService.GetKhachHangsBySoDienThoai(khachHang.SoDienThoai);
                            var khachHangInDatabase = _khachHangService.Get(khachHang.Id);
                            khachHangs.Remove(khachHangInDatabase);

                            if (khachHangs.Count > 0)
                            {
                                MessageBox.Show(@"Số Điện Thoại đã tồn tại.", @"Thông Báo", MessageBoxButtons.OK);
                                return false;
                            }
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
                RefreshButton.Enabled = false;
                AddButton.Enabled = true;

                _isSelectedRow = true;
            }
        }

        private void SaveData()
        {
            try
            {
                var khachHang = Entity as Model.KhachHang;

                if (FormMode == FormMode.Edit)
                {
                    if (khachHang != null)
                    {
                        khachHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                        khachHang.NgayChinhSua = DateTime.Now;
                        _khachHangService.Update(khachHang);
                    }
                }
                
                _khachHangService.Save();

                if (FormMode == FormMode.Add)
                {
                    var countTheKhachHang = _theKhachHangService.CountTheKhachHang();
                    var theKhachHang = _theKhachHangService.Add();
                    theKhachHang.TheKhachHangId = new Guid(countTheKhachHang.ToString("00000000000000000000000000000000"));
                    theKhachHang.NgayChinhSua = DateTime.Now;
                    theKhachHang.NgayTao = DateTime.Now;
                    theKhachHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                    theKhachHang.NguoiTaoId = CurrentFormInfo.CurrentUserId;
                    theKhachHang.HoatDong = true;
                    if (khachHang != null) theKhachHang.KhachHangId = khachHang.Id;

                    _theKhachHangService.Save();
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
                var selRow = _selRow as Model.KhachHang;
                if (selRow != null)
                {
                    if (DialogResult.Yes ==
                            MessageBox.Show(
                                string.Format("Bạn có muốn xóa thông tin Khách Hàng : {0}", selRow.TenKhachHang),
                                @"Xác Nhận", MessageBoxButtons.YesNo))
                    {
                        selRow.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                        selRow.NgayChinhSua = DateTime.Now;
                        _khachHangService.Delete(selRow);
                        _khachHangService.Save();

                        var theKhachHang = _theKhachHangService.GetByKhachHangId(selRow.Id);
                        theKhachHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                        theKhachHang.NgayChinhSua = DateTime.Now;
                        _theKhachHangService.Delete(theKhachHang);
                        _theKhachHangService.Save();

                        ShowData();
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

        private void SelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                var khachHang = _selRow as Model.KhachHang;
                if (khachHang != null)
                {
                    KhachHang = khachHang;
                }

                Close();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
