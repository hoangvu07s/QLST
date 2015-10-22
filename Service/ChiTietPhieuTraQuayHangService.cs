using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Helper;
using Model;

namespace Service
{
    public class ChiTietPhieuTraQuayHangService : BaseService
    {
        public ChiTietPhieuTraQuayHangService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public CT_PhieuTraQuayHang AddChiTietPhieuTraQuayHang(CT_PhieuTraQuayHang chiTietPhieuTraQuayHang)
        {
            try
            {
                return Entities.CT_PhieuTraQuayHang.Add(chiTietPhieuTraQuayHang);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public int TomSoLuongTraVeKho(long hangHoaId)
        {
            int tongSoLuong = 0;
            try
            {
                tongSoLuong = Entities.CT_PhieuTraQuayHang.Where(_ => _.HangHoaId == hangHoaId).Sum(_ => _.SoLuong);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return tongSoLuong;
        }

        public IList<CT_PhieuTraQuayHang> Get(Guid maPhieuTraQuayHang)
        {
            try
            {
                return Entities.CT_PhieuTraQuayHang.Where(_ => _.PhieuTraQuayHangId == maPhieuTraQuayHang).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public override void Save()
        {
            Entities.SaveChanges();
        } 
    }
}
