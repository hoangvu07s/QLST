using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helper;
using Helper.ValueObjects;
using Service;

namespace QuanLySieuThi.HangHoa
{
    public partial class ThongKeHangHoaForm
    {
        private HangHoaService _hangHoaService;
        private TonKhoService _tonKhoService;
        private IList<ThongKeHangHoa> _thongKeHangHoas; 

        public ThongKeHangHoaForm()
        {
            InitializeComponent();
            MinimumSizeWidth = 690;
            MinimumSizeHeight = 346;
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);
            try
            {
                ShowData();
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
                _tonKhoService = new TonKhoService(Entities);
                _thongKeHangHoas = new List<ThongKeHangHoa>(); 
                var hangHoas = _hangHoaService.GetAll();
                foreach (var hangHoa in hangHoas)
                {
                    var soLuongTonKho = _tonKhoService.GetSoLuongTonKho(hangHoa.Id);
                    _thongKeHangHoas.Add(new ThongKeHangHoa
                    {
                        TenHangHoa = hangHoa.TenHangHoa,
                        SoLuongTonKho = soLuongTonKho,
                        SoLuongTonQuay = (int) (hangHoa.SoLuongTonQuay == null ? 0 : hangHoa.SoLuongTonQuay.Value)
                    });
                }

                gridControl1.DataSource = _thongKeHangHoas;
                gridControl1.RefreshDataSource();

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControl1.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControl1.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl1.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControl1.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl1.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl1.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
