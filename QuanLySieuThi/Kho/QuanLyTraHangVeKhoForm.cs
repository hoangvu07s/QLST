using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Common.Forms;
using DevExpress.Office.Utils;
using DevExpress.XtraEditors.Controls;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.Kho
{
    public partial class QuanLyTraHangVeKhoForm : QuanLySieuThiForm
    {
        private readonly PhieuTraQuayHangService _phieuTraQuayHangService;
        private readonly KhoHangService _khoHangService;
        private readonly QuayHangService _quayHangService;
        private readonly XuatKhoService _xuatKhoService;
        private readonly ChiTietXuatKhoService _chiTietXuatKhoService;
        private readonly HangHoaService _hangHoaService;
        private readonly ChiTietPhieuTraQuayHangService _chiTietPhieuTraQuayHangService;

        private IList<Model.Kho> _khos;
        private IList<CT_PhieuTraQuayHang> _chiTietPhieuTraQuayHangs; 
        public QuanLyTraHangVeKhoForm(string maPhieuTraQuayHang)
        {
            InitializeComponent();
            MinimumSizeWidth = 1003;
            MinimumSizeHeight = 602;

            EntityId = maPhieuTraQuayHang;

            _phieuTraQuayHangService = new PhieuTraQuayHangService(Entities);
            _khoHangService = new KhoHangService(Entities);
            _quayHangService = new QuayHangService(Entities);
            _xuatKhoService = new XuatKhoService(Entities);
            _hangHoaService = new HangHoaService(Entities);
            _chiTietXuatKhoService = new ChiTietXuatKhoService(Entities);
            _chiTietPhieuTraQuayHangService = new ChiTietPhieuTraQuayHangService(Entities);
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);

            try
            {
                _khos = _khoHangService.GetAll();
                if (string.IsNullOrWhiteSpace(EntityId))
                {
                    FormMode = FormMode.Add;
                    var phieuTraQuayHang = _phieuTraQuayHangService.Add();
                    phieuTraQuayHang.PhieuTraQuayHangId = Guid.NewGuid();

                    Entity = phieuTraQuayHang;

                    _chiTietPhieuTraQuayHangs = new List<CT_PhieuTraQuayHang>();
                }
                else
                {
                    FormMode = FormMode.Edit;
                    AddButton.Enabled = false;
                    SaveButton.Enabled = false;
                    EditButton.Enabled = false;
                    DeleteButton.Enabled = false;
                    KhoLookupEdit.Properties.ReadOnly = false;
                    QuayHangLookupEdit.Properties.ReadOnly = false;
                    HangHoaLookupEdit.Properties.ReadOnly = false;
                    SoLuongNummeric.Properties.ReadOnly = false;
                    LyDoTextBox.Properties.ReadOnly = false;

                    Entity = _phieuTraQuayHangService.Get(new Guid(EntityId));
                    _chiTietPhieuTraQuayHangs = _chiTietPhieuTraQuayHangService.Get(new Guid(EntityId));

                    LoadGridData();
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public override void BindData(EventArgs e)
        {
            base.BindData(e);

            try
            {
                DataBinding.BindEditor(MaPhieuTraQuayHangTextBox, "Text", Entity, "PhieuTraQuayHangId");
                DataBinding.BindLookupEdit(KhoLookupEdit, "EditValue", Entity, _khos, "KhoId",
                    "TenKho", "Id", "TenKho");
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void KhoLookupEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                IList<QuayHang> quayHangs = new List<QuayHang>();
                var khoId = KhoLookupEdit.EditValue.ToString().ToLong();
                if (khoId != 0)
                {
                    var xuatKhos = _xuatKhoService.GetByKhoId(khoId);

                    foreach (var xuatKho in xuatKhos)
                    {
                        foreach (var chiTietXuatKho in xuatKho.CT_XuatKho)
                        {
                            var hangHoa = _hangHoaService.Get(chiTietXuatKho.HangHoaId);

                            quayHangs.Add(hangHoa.QuayHang);
                        }
                    }
                }

                DataBinding.BindLookupEdit(QuayHangLookupEdit, "EditValue", Entity, quayHangs.Distinct(), "QuayHangId",
                    "TenQuay", "Id", "TenQuay");

                _chiTietPhieuTraQuayHangs = new List<CT_PhieuTraQuayHang>();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void QuayHangLookupEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                IList<Model.HangHoa> hangHoas = new List<Model.HangHoa>();
                var quayHangId = QuayHangLookupEdit.EditValue.ToString().ToLong();
                if (quayHangId != 0)
                {
                    hangHoas = _chiTietXuatKhoService.GetHangHoaByQuayHang(quayHangId);
                }

                LoadHangHoa(hangHoas);

                _chiTietPhieuTraQuayHangs = new List<CT_PhieuTraQuayHang>();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void LoadHangHoa(IList<Model.HangHoa> hangHoas)
        {
            try
            {
                HangHoaLookupEdit.Properties.DataSource = hangHoas;
                HangHoaLookupEdit.Properties.DisplayMember = "TenHangHoa";
                HangHoaLookupEdit.Properties.ValueMember = "Id";
                HangHoaLookupEdit.Properties.Columns.Clear();
                HangHoaLookupEdit.Properties.Columns.Add(new LookUpColumnInfo("TenHangHoa"));
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void HangHoaLookupEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var hangHoaId = HangHoaLookupEdit.EditValue.ToString().ToLong();

                if (hangHoaId != 0)
                {
                    var tongSoluongXuatKho = _chiTietXuatKhoService.TongSoLuongXuatKho(hangHoaId);
                    var tongSoLuongTraVeKho = _chiTietPhieuTraQuayHangService.TomSoLuongTraVeKho(hangHoaId);

                    SoLuongTonQuayNummeric.Text = (tongSoluongXuatKho - tongSoLuongTraVeKho).ToString(CultureInfo.InvariantCulture);

                    SoLuongNummeric.Text = string.Empty;
                    LyDoTextBox.Text = string.Empty;
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
                if (string.IsNullOrWhiteSpace(SoLuongNummeric.Text) || SoLuongNummeric.Text.ToInt() == 0)
                {
                    MessageBox.Show(@"Số Lượng trả về kho phải lớn hơn 0", @"Thông Báo", MessageBoxButtons.OK);
                }
                else if (SoLuongNummeric.Text.ToInt() > SoLuongTonQuayNummeric.Text.ToInt())
                {
                    MessageBox.Show(@"Số Lượng trả về kho phải bé hơn hoắc bằng với số lượng tông quầy", @"Thông Báo", MessageBoxButtons.OK);
                }
                else if (_chiTietPhieuTraQuayHangs.Any(_ => _.HangHoaId == HangHoaLookupEdit.EditValue.ToString().ToLong()))
                {
                    MessageBox.Show(@"Hàng Hóa đã được thêm vào danh sách", @"Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    var chiTietTraHang = new CT_PhieuTraQuayHang
                    {
                        PhieuTraQuayHangId = new Guid(MaPhieuTraQuayHangTextBox.Text),
                        HangHoaId = HangHoaLookupEdit.EditValue.ToString().ToLong(),
                        SoLuong = SoLuongNummeric.Text.ToInt(),
                        LyDo = LyDoTextBox.Text,
                        HangHoa = new Model.HangHoa
                        {
                            TenHangHoa = HangHoaLookupEdit.Text
                        }                     
                    };

                    _chiTietPhieuTraQuayHangs.Add(chiTietTraHang);

                    LoadGridData();
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }            
        }

        private void LoadGridData()
        {
            try
            {
                TraHangVeKhoGridControl.DataSource = _chiTietPhieuTraQuayHangs;
                TraHangVeKhoGridControl.RefreshDataSource();
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
                if (string.IsNullOrWhiteSpace(SoLuongNummeric.Text) || SoLuongNummeric.Text.ToInt() == 0)
                {
                    MessageBox.Show(@"Số Lượng trả về kho phải lớn hơn 0", @"Thông Báo", MessageBoxButtons.OK);
                }
                else if (SoLuongNummeric.Text.ToInt() > SoLuongTonQuayNummeric.Text.ToInt())
                {
                    MessageBox.Show(@"Số Lượng trả về kho phải bé hơn hoắc bằng với số lượng tông quầy", @"Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    var chiTietPhieuTraQuayHang =
                        _chiTietPhieuTraQuayHangs.FirstOrDefault(
                            _ => _.HangHoaId == HangHoaLookupEdit.EditValue.ToString().ToLong());

                    if (chiTietPhieuTraQuayHang != null)
                    {
                        chiTietPhieuTraQuayHang.SoLuong = SoLuongNummeric.Text.ToInt();
                        chiTietPhieuTraQuayHang.LyDo = LyDoTextBox.Text;

                        LoadGridData();
                    }
                    else
                    {
                        MessageBox.Show(@"Hàng Hóa không nằm trong danh sách", @"Thông Báo", MessageBoxButtons.OK);
                    }
                }
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
                var chiTietPhieuTraQuayHang =
                        _chiTietPhieuTraQuayHangs.FirstOrDefault(
                            _ => _.HangHoaId == HangHoaLookupEdit.EditValue.ToString().ToLong());

                if (chiTietPhieuTraQuayHang != null)
                {
                    _chiTietPhieuTraQuayHangs.Remove(chiTietPhieuTraQuayHang);

                    LoadGridData();
                }
                else
                {
                    MessageBox.Show(@"Hàng Hóa không nằm trong danh sách", @"Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void TraHangVeKhoGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var selRow = TraHangVeKhoGridView.GetRow(e.FocusedRowHandle);
                var chiTietPhieuTraQuayHang = selRow as CT_PhieuTraQuayHang;

                if (chiTietPhieuTraQuayHang != null)
                {
                    HangHoaLookupEdit.EditValue = chiTietPhieuTraQuayHang.HangHoaId;
                    SoLuongNummeric.Text = chiTietPhieuTraQuayHang.SoLuong.ToString(CultureInfo.InvariantCulture);
                    LyDoTextBox.Text = chiTietPhieuTraQuayHang.LyDo;
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var phieuTraQuayHang = Entity as PhieuTraQuayHang;
                if (phieuTraQuayHang != null)
                {
                    if (phieuTraQuayHang.KhoId == 0)
                    {
                        MessageBox.Show(@"Vui lòng chọn Kho", @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if(phieuTraQuayHang.QuayHangId == 0)
                    {
                        MessageBox.Show(@"Vui lòng chọn Quầy Hàng", @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else if (!_chiTietPhieuTraQuayHangs.Any())
                    {
                        MessageBox.Show(@"Vui lòng thêm danh sách hàng được trả về quầy", @"Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        phieuTraQuayHang.NhanVienId = CurrentFormInfo.CurrentUserId;
                        phieuTraQuayHang.NgayLap = DateTime.Now;
                        phieuTraQuayHang.NgayChinhSua = DateTime.Now;
                        phieuTraQuayHang.NguoiChinhSuaId = CurrentFormInfo.CurrentUserId;
                        phieuTraQuayHang.HoatDong = true;
                        _phieuTraQuayHangService.Save();

                        foreach (var chiTietPhieuTraQuayHang in _chiTietPhieuTraQuayHangs)
                        {
                            var chiTietPhieuTraQuayHangValue = new CT_PhieuTraQuayHang
                            {
                                PhieuTraQuayHangId = chiTietPhieuTraQuayHang.PhieuTraQuayHangId,
                                HangHoaId = chiTietPhieuTraQuayHang.HangHoaId,
                                SoLuong = chiTietPhieuTraQuayHang.SoLuong,
                                LyDo = chiTietPhieuTraQuayHang.LyDo
                            };
                            _chiTietPhieuTraQuayHangService.AddChiTietPhieuTraQuayHang(chiTietPhieuTraQuayHangValue);                            
                        }

                        _chiTietPhieuTraQuayHangService.Save();

                        Close();
                    }
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
    }
}
