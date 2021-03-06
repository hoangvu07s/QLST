﻿using System;

namespace Helper.ValueObjects
{
    public class ChiTietNhapKho
    {
        public long HangHoaId { get; set; }
        public string TenHangHoa { get; set; }
        public int SoLuong { get; set; }
        public int SoluongDatHang { get; set; }
        public decimal DonGia { get; set; }
        public DateTime? NgaySanXuat { get; set; }
        public DateTime? HanSuDung { get; set; }
    }
}
