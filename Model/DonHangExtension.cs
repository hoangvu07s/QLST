namespace Model
{
    public partial class DonHang
    {
        public string NguoiLapDonHang {
            get
            {
                return NhanVien1.HoVaTen; 
                
            }
        }

        public string TenNhaCungCap
        {
            get
            {
                return NhaCungCap.TenNhaCungCap;
                
            }
        }
    }
}
