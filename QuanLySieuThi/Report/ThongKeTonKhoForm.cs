using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Common.Forms;
using Helper;
using Helper.ValueObjects;
using Microsoft.Reporting.WinForms;
using Service;

namespace QuanLySieuThi.Report
{
    public partial class ThongKeTonKhoForm : QuanLySieuThiForm
    {
        private readonly HangHoaService _hangHoaService;
        public ThongKeTonKhoForm()
        {
            InitializeComponent();

            MinimumSizeWidth = 1003;
            MinimumSizeHeight = 602;

            _hangHoaService = new HangHoaService(Entities);
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    IList<ThongKeTonKho> thongKeTonKhos = new List<ThongKeTonKho>();
                    var hangHoas = _hangHoaService.GetInRangeDateTime((DateTime) FromDateEdit.EditValue,
                        (DateTime) ToDateEdit.EditValue);

                    foreach (var hangHoa in hangHoas)
                    {
                        var soLuongKho = hangHoa.TonKhoes.Sum(_ => _.SoLuongTon);
                        var thongkeTonKho = new ThongKeTonKho
                        {
                            MaHangHoa = hangHoa.Id,
                            TenHangHoa = hangHoa.TenHangHoa,
                            SoLuongTonQuay = hangHoa.SoLuongTonQuay.HasValue ? hangHoa.SoLuongTonQuay.Value : 0,
                            SoLuongTonKho = soLuongKho.HasValue ? soLuongKho.Value : 0,
                            DonGiaNhapBinhQuan = hangHoa.CT_NhapKho.Count > 0 ? hangHoa.CT_NhapKho.Average(_=>_.DonGia) : 0
                        };

                        thongKeTonKhos.Add(thongkeTonKho);
                    }

                    var reportParameter = new ReportParameter[]
                    {
                        new ReportParameter("TuNgay", FromDateEdit.Text),
                        new ReportParameter("DenNgay", ToDateEdit.Text)
                    };

                    reportViewer1.LocalReport.SetParameters(reportParameter);
                    var datasource = new ReportDataSource("ThongKeTonKho", thongKeTonKhos);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(datasource);
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }           
        }

        private bool ValidateInput()
        {
            bool isValidate = true;
            if (string.IsNullOrWhiteSpace(FromDateEdit.Text))
            {
                MessageBox.Show(@"Vui lòng chọn Ngày Bắt Đầu",
                                    @"Thông Báo", MessageBoxButtons.OK);

                isValidate = false;
            }
            else if (string.IsNullOrWhiteSpace(ToDateEdit.Text))
            {
                MessageBox.Show(@"Vui lòng chọn Ngày Kết Thúc",
                                    @"Thông Báo", MessageBoxButtons.OK);
                isValidate = false;
            }
            else if ((DateTime) FromDateEdit.EditValue > (DateTime) ToDateEdit.EditValue)
            {
                MessageBox.Show(@"Ngày Bắt Đầu phải bé hơn Ngày Kết Thúc",
                                    @"Thông Báo", MessageBoxButtons.OK);
                isValidate = false;
            }

            return isValidate;
        }
    }
}
