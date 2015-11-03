using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Forms;
using DevExpress.XtraEditors.Controls;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.KhachHang
{
    public partial class ChiTietDoiTraHangHoaForm : QuanLySieuThiForm
    {
        private ChiTietDoiTraHangHoaService _chiTietDoiTraHangHoaService;
        private ChiTietHoaDonService _chiTietHoaDonService;
        private QuanLyHoaDonForm _quanLyHoaDonForm;
        private ChiTietXuatKhoService _chiTietXuatKhoService;
        private XuatKhoService _xuatKhoService;

        private Guid? _maDoiTraHangHoa;
        private IList<CT_DoiTraHangHoa> _chiTietDoiTraHangHoas;
        private HoaDon _hoaDon;
        private IList<Model.HangHoa> _hangHoa;

        public ChiTietDoiTraHangHoaForm(Guid? maDoiTraHangHoa)
        {
            InitializeComponent();

            MinimumSizeWidth = 1003;
            MinimumSizeHeight = 602;

            _maDoiTraHangHoa = maDoiTraHangHoa;
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);
            try
            {
                _chiTietDoiTraHangHoaService = new ChiTietDoiTraHangHoaService(Entities);
                _chiTietHoaDonService = new ChiTietHoaDonService(Entities);
                _chiTietXuatKhoService = new ChiTietXuatKhoService(Entities);
                _xuatKhoService = new XuatKhoService(Entities);

                if (!_maDoiTraHangHoa.HasValue)
                {
                    FormMode = FormMode.Add;
                    _chiTietDoiTraHangHoas = new List<CT_DoiTraHangHoa>();

                    EnabledControls(true);

                    _maDoiTraHangHoa = new Guid(QuanLySieuThiHelper.NextId());
                }
                else
                {
                    FormMode = FormMode.View;
                    _chiTietDoiTraHangHoas = _chiTietDoiTraHangHoaService.GetByDoiTraHangHoaId(_maDoiTraHangHoa.Value);

                    ShowData();

                    EnabledControls(false);
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
                ChiTietTraHangGridControl.DataSource = _chiTietDoiTraHangHoas;
                ChiTietTraHangGridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void EnabledControls(bool isEnabled)
        {
            try
            {
                MaHoDonTextBox.Enabled = isEnabled;
                SearchHoaDonButton.Enabled = isEnabled;
                HangHoaLookupEdit.Enabled = isEnabled;
                KhoLookupEdit.Enabled = isEnabled;
                DonGiaNummeric.Enabled = isEnabled;
                SoLuongNummeric.Enabled = isEnabled;
                AddButton.Enabled = isEnabled;
                SaveButton.Enabled = isEnabled;
                EditButton.Enabled = isEnabled;
                DeleteButton.Enabled = isEnabled;
                TinhTrangTextBox.Enabled = isEnabled;
                ChietKhauNummeric.Enabled = isEnabled;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void SearchHoaDonButton_Click(object sender, EventArgs e)
        {
            try
            {
                _quanLyHoaDonForm = new QuanLyHoaDonForm(true);
                _quanLyHoaDonForm.ShowForm("OpenSeachHoaDon");
                _quanLyHoaDonForm.FormClosed += QuanLyHoaDonFormOnFormClosed;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void QuanLyHoaDonFormOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            try
            {
                _hoaDon = _quanLyHoaDonForm.HoaDon;
                if (DateTime.Now.Subtract(_hoaDon.NgayLap).Days > 3)
                {
                    MessageBox.Show(
                                    @"Không thể dổi hàng vì hóa đơn được lập trước 3 ngày",
                                    @"Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MaHoDonTextBox.Text = _hoaDon.HoaDonId.ToString();
                    LoadHangHoa();
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void LoadHangHoa()
        {
            try
            {
                var chiTietHoaDon = _chiTietHoaDonService.GetByHoaDonId(_hoaDon.HoaDonId);
                _hangHoa = chiTietHoaDon.Where(_ => _.HangHoa.CoTheTraLai == true).Select(_ => _.HangHoa).ToList();

                HangHoaLookupEdit.Properties.Columns.Clear();
                HangHoaLookupEdit.Properties.DataSource = _hangHoa;
                HangHoaLookupEdit.Properties.DisplayMember = "TenHangHoa";
                HangHoaLookupEdit.Properties.ValueMember = "Id";
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
                var xuatKhoIds =
                    _chiTietXuatKhoService.GetByHangHoaId(HangHoaLookupEdit.EditValue.ToString().ToLong())
                        .Select(_ => _.XuatKhoId).ToList();

                var khos = _xuatKhoService.GetByXuatKhoIds(xuatKhoIds).Select(_ => _.Kho).ToList().Distinct().ToList();

                LoadKho(khos);

                var chiTietHoaDons = _chiTietHoaDonService.GetByHoaDonId(_hoaDon.HoaDonId);
                var ctHoaDon = chiTietHoaDons.FirstOrDefault(_ => _.HangHoaId == HangHoaLookupEdit.EditValue.ToString().ToLong());
                if (ctHoaDon != null)
                {
                    SoLuongNummeric.Text = ctHoaDon.SoLuong.ToString(CultureInfo.InvariantCulture);
                    DonGiaNummeric.Text = ctHoaDon.DonGia.ToString(CultureInfo.InvariantCulture);
                }

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void LoadKho(IList<Model.Kho> khos)
        {
            try
            {
                KhoLookupEdit.Properties.Columns.Clear();
                KhoLookupEdit.Properties.DataSource = khos;
                KhoLookupEdit.Properties.DisplayMember = "TenKho";
                KhoLookupEdit.Properties.ValueMember = "Id";
                KhoLookupEdit.Properties.Columns.Add(new LookUpColumnInfo("TenKho"));
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
