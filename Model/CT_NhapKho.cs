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
    
    public partial class CT_NhapKho
    {
        public System.Guid NhapKhoId { get; set; }
        public long HangHoaId { get; set; }
        public int SoLuong { get; set; }
    
        public virtual HangHoa HangHoa { get; set; }
        public virtual NhapKho NhapKho { get; set; }
    }
}
