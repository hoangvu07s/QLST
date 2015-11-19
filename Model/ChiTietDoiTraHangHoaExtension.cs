namespace Model
{
    public partial class CT_DoiTraHangHoa
    {
        public string TenKho { get; set; }

        public decimal TongTienTraLai
        {
            get { return (SoLuong * DonGia) - (SoLuong * DonGia * ChietKhauPhanTram.Value) / 100; }
        }
    }
}
