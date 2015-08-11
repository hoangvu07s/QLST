namespace Helper.ValueObjects
{
    public class ChiTietDonHang
    {
        public string MaDonHang { get; set; }
        public string TenHangHoa { get; set; }
        public long LoaiHangHoaId { get; set; }
        public string TenLoaiHangHoa { get; set; }
        public long NhaCungCapId { get; set; }
        public string TenNhaCungCap { get; set; }
        public long QuayHangId { get; set; }
        public string TenQuayHang { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }
}
