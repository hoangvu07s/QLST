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
using DevExpress.XtraEditors.Controls;
using Helper;
using Service;

namespace QuanLySieuThi.ThongKe
{
    public partial class ThongKeHangHoaTrongKho : QuanLySieuThiForm
    {
        private KhoHangService _khoHangService;
        private TonKhoService _tonKhoService;
        private HangHoaService _hangHoaService;

        public ThongKeHangHoaTrongKho()
        {
            InitializeComponent();
        }

        private void CancelButtonControl_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        public override void LoadData(EventArgs e)
        {
            base.LoadData(e);
            try
            {
                _khoHangService = new KhoHangService(Entities);
                var khoHangs = _khoHangService.GetAll();

                KhoLookupEdit.Properties.DataSource = khoHangs;
                KhoLookupEdit.Properties.ValueMember = "Id";
                KhoLookupEdit.Properties.DisplayMember = "TenKho";
                KhoLookupEdit.Properties.Columns.Clear();
                foreach (var column in new List<string>() { "TenKho" })
                {
                    KhoLookupEdit.Properties.Columns.Add(new LookUpColumnInfo(column));
                }
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
                IList<Model.HangHoa> hangHoasList = new List<Model.HangHoa>(); 
                _tonKhoService = new TonKhoService(Entities);
                _hangHoaService = new HangHoaService(Entities);
                var tonKhos = _tonKhoService.GetByKhoId(KhoLookupEdit.EditValue.ToString().ToLong());
                foreach (var tonKho in tonKhos)
                {
                    var hangHoas = _hangHoaService.Get(tonKho.HangHoaId);
                    hangHoasList.Add(hangHoas);
                }

                gridControl1.DataSource = hangHoasList;
                gridControl1.RefreshDataSource();

                TongSoLuongTonKhoNummeri.Text = tonKhos.Sum(_ => _.SoLuongTon).ToString();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _tonKhoService = new TonKhoService(Entities);
                var selRow = gridView1.GetRow(e.FocusedRowHandle);
                var hangHoa = selRow as Model.HangHoa;
                if (hangHoa != null)
                {
                    var tonKho = _tonKhoService.GetByHangHoaIdKhoId(hangHoa.Id, KhoLookupEdit.EditValue.ToString().ToLong());
                    SoLuongTonKhoNummeric.Text = tonKho.SoLuongTon.ToString();
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }
    }
}
