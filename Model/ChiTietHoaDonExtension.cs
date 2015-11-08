namespace Model
{
    public partial class CT_HoaDon
    {
        public decimal TongTien
        {
            get { return SoLuong*DonGia; }
        }

        public string TenHangHoa
        {
            get { return HangHoa.TenHangHoa; }
        }

    }
}
