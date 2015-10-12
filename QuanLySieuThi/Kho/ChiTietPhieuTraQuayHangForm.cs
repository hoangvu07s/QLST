using System;

namespace QuanLySieuThi.Kho
{
    public partial class ChiTietPhieuTraQuayHangForm
    {
        public ChiTietPhieuTraQuayHangForm(string phieuTraQuayHangId)
        {
            InitializeComponent();

            MinimumSizeWidth = 626;
            MinimumSizeHeight = 267;

            EntityId = phieuTraQuayHangId;
        }
    }
}
