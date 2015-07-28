using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;

namespace QuanLySieuThi.Kho
{
    public partial class KhoHangEditForm
    {
        private KhoHangService _khoHangService;

        public KhoHangEditForm(long? khoId)
        {
            InitializeComponent();

            MinimumSizeWidth = 472;
            MinimumSizeHeight = 150;

            EntityId = khoId.ToString();

            _khoHangService = new KhoHangService(Entities);
        }
    }
}
