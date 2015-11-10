namespace Helper.ValueObjects
{
    public class ThongKeTonKho
    {
        public long MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public long SoLuongTonQuay { get; set; }
        public long SoLuongTonKho { get; set; }
        public long TongSoLuongTon {
            get { return SoLuongTonKho + SoLuongTonQuay; }
        }
        public decimal DonGiaNhapBinhQuan { get; set; }
        public decimal GiaTriTon {
            get { return TongSoLuongTon*DonGiaNhapBinhQuan; }
        }
    }
}
