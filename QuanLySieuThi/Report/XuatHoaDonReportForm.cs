using System;
using System.Globalization;
using System.Linq;
using Common.Forms;
using Microsoft.Reporting.WinForms;
using Service;

namespace QuanLySieuThi.Report
{
    public partial class XuatHoaDonReportForm : QuanLySieuThiForm
    {
        private ChiTietHoaDonService _chiTietHoaDonService;
        private readonly Guid _hoaDonId;
        public XuatHoaDonReportForm(Guid hoaDonId)
        {
            InitializeComponent();

            MinimumSizeWidth = 1003;
            MinimumSizeHeight = 602;

            _hoaDonId = hoaDonId;
        }

        private void XuatHoaDonReportForm_Load(object sender, EventArgs e)
        {
            _chiTietHoaDonService = new ChiTietHoaDonService(Entities);
            var chiTietHoaDons = _chiTietHoaDonService.GetByHoaDonId(_hoaDonId);
            
            // Set Parameter:
            var reportParameter = new ReportParameter[]
            {
                new ReportParameter("NgayLap",chiTietHoaDons.First().HoaDon.NgayLap.ToShortDateString()), 
                new ReportParameter("NhanVien",chiTietHoaDons.First().HoaDon.NhanVien1.HoVaTen), 
                new ReportParameter("KhachHang",chiTietHoaDons.First().HoaDon.KhachHang.TenKhachHang),
                new ReportParameter("MaHoaDon",chiTietHoaDons.First().HoaDon.HoaDonId.ToString()), 
                new ReportParameter("TongTriGia",chiTietHoaDons.Sum(_=>_.TongTien).ToString(CultureInfo.InvariantCulture)) 
            };

            reportViewer1.LocalReport.SetParameters(reportParameter);
            var datasource = new ReportDataSource("ChiTietHoaDon", chiTietHoaDons);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);
            reportViewer1.RefreshReport();
        }
    }
}
