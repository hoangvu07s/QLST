//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CT_DoiTraHangHoa
    {
        public System.Guid DoiTraHangHoaId { get; set; }
        public long HangHoaId { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public string TinhTrang { get; set; }
        public Nullable<decimal> ChietKhauPhanTram { get; set; }
        public Nullable<long> KhoId { get; set; }
    
        public virtual DoiTraHangHoa DoiTraHangHoa { get; set; }
        public virtual HangHoa HangHoa { get; set; }
        public virtual Kho Kho { get; set; }
    }
}
