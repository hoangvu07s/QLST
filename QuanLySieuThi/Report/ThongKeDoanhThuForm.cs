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
    public partial class ThongKeDoanhThuForm : QuanLySieuThiForm
    {
        private readonly HoaDonService _hoaDonService;
        private readonly DoiTraHangHoaService _doiTraHangHoaService;

        public ThongKeDoanhThuForm()
        {
            InitializeComponent();

            MinimumSizeWidth = 1003;
            MinimumSizeHeight = 602;

            _hoaDonService = new HoaDonService(Entities);
            _doiTraHangHoaService = new DoiTraHangHoaService(Entities);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(YearTextBox.Text) || YearTextBox.Text.ToInt() <= 0 || YearTextBox.Text.ToInt() > DateTime.Now.ToString().Trim().Substring(6,4).ToInt())
                {
                    MessageBox.Show(@"Năm bạn nhập không phù hợp.",
                                    @"Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    IList<DoanhThu> doanhThus = new List<DoanhThu>();
                    var hoaDons = _hoaDonService.GetByYear(YearTextBox.Text.ToInt());
                    var phieuTraHangHoas = _doiTraHangHoaService.GetByYear(YearTextBox.Text.ToInt());

                    for (int i = 1; i <= 12; i++)
                    {
                        var hoaDonTheoThang = hoaDons.Where(_ => _.NgayLap.Month == i).ToList();
                        decimal tongTienTheoThang = 0;
                        foreach (var hoaDon in hoaDonTheoThang)
                        {
                            tongTienTheoThang = tongTienTheoThang + hoaDon.CT_HoaDon.Sum(_ => _.DonGia * _.SoLuong);
                        }

                        var phieuTraQuayHangTheoThang = phieuTraHangHoas.Where(_ => _.NgayLap.Month == i).ToList();
                        var tongTienTraLai = phieuTraQuayHangTheoThang.Sum(_ => _.TongTienTraLai);

                        var doanhThu = new DoanhThu
                        {
                            Thang = i,
                            DoanhThuValue = tongTienTheoThang - tongTienTraLai
                        };

                        doanhThus.Add(doanhThu);
                    }
                    
                    decimal tongDoanhThu = doanhThus.Sum(_ => _.DoanhThuValue);

                    foreach (var doanhThu in doanhThus)
                    {
                        if (tongDoanhThu == 0)
                        {
                            doanhThu.PhanTramDoanhThu = 0;
                        }
                        else
                        {
                            doanhThu.PhanTramDoanhThu = Math.Round(doanhThu.DoanhThuValue / tongDoanhThu, 2) * 100;
                        }
                        
                    }

                    var reportParameter = new ReportParameter[]
                    {
                        new ReportParameter("Year", YearTextBox.Text)
                    };

                    reportViewer1.LocalReport.SetParameters(reportParameter);
                    var datasource = new ReportDataSource("ThongKeDoanhThu", doanhThus);
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

        //private void ThongKeDoanhThuForm_Load(object sender, EventArgs e)
        //{

        //    this.reportViewer1.RefreshReport();
        //}
    }
}
