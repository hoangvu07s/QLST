using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Helper;
using Model;
using Service;

namespace QuanLySieuThi.HangHoa
{    
    public partial class LoaiHangHoaListForm
    {
        private LoaiHangHoaService _loaiHangHoaService;
        private Object _selRow;
        private long? _chungLoaiHangHoaId;
        public LoaiHangHoaListForm(long? chungLoaiHangHoaId)
        {
            InitializeComponent();
            MinimumSizeWidth = 694;
            MinimumSizeHeight = 279;
            if (chungLoaiHangHoaId.HasValue)
            {
                _chungLoaiHangHoaId = chungLoaiHangHoaId.Value;
            }
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
                _loaiHangHoaService = new LoaiHangHoaService(Entities);
                IList<LoaiHangHoa> loaiHangList;
                if (_chungLoaiHangHoaId.HasValue)
                {
                    loaiHangList = _loaiHangHoaService.GetByChungLoaiHangHoaId(_chungLoaiHangHoaId.Value);
                }
                else
                {
                    loaiHangList = _loaiHangHoaService.GetAll();
                }
                LoaiHangHoaGridControl.DataSource = loaiHangList;
                LoaiHangHoaGridControl.RefreshDataSource();
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selRow = _selRow as LoaiHangHoa;
                if (selRow != null)
                {
                    //TODO VuDao: Check loai hang hoa  duoc su dung trong database
                    if (DialogResult.Yes ==
                        MessageBox.Show(string.Format("Ban co muon xoa Loai Hang Hoa '{0}' ?", selRow.TenLoaiHangHoa),
                            @"Xac Nhan", MessageBoxButtons.YesNo))
                    {
                        _loaiHangHoaService.Delete(selRow.Id);
                        _loaiHangHoaService.Save();
                        ShowData();
                    }
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
                var loaiHangHoaEditForm = new LoaiHangHoaEditForm(null);
                loaiHangHoaEditForm.ShowForm("AddLoaiHangHoa");
                loaiHangHoaEditForm.FormClosed += LoaiHangHoaEditFormClosed;
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
                var selRow = _selRow as LoaiHangHoa;
                if (selRow != null)
                {
                    var loaiHangHoaEditForm = new LoaiHangHoaEditForm(selRow.Id);
                    loaiHangHoaEditForm.ShowForm(string.Format("EditLoaiHangHoa: {0}", selRow.Id));
                    loaiHangHoaEditForm.FormClosed += LoaiHangHoaEditFormClosed;
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            AcceptAndSavechange();
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            EditButton_Click(sender,e);
        }
        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _selRow = GridView1.GetRow(e.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        private void LoaiHangHoaEditFormClosed(object sender, FormClosedEventArgs e)
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
