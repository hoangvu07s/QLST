using Service;

namespace QuanLySieuThi.NhaCungCap
{
    public partial class NhaCungCapEditForm
    {
        private NhaCungCapService _nhaCungCapService;
        public NhaCungCapEditForm(long? nhaCungCapId)
        {
            InitializeComponent();

            MinimumSizeWidth = 472;
            MinimumSizeHeight = 150;

            EntityId = nhaCungCapId.ToString();

            _nhaCungCapService = new NhaCungCapService(Entities);
        }
    }
}
