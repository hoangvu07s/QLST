namespace Model
{
    public partial class DonHang
    {
        public string NguoiLapDonHang {
            get
            {
                return NhanVien1.TenDangNhap; 
                
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
