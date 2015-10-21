using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Helper;
using Model;

namespace Service
{
    public class PhieuTraQuayHangService : BaseService
    {
        public PhieuTraQuayHangService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public IList<PhieuTraQuayHang> GetAll()
        {
            try
            {
                return
                    Entities.PhieuTraQuayHangs.Where(_ => _.HoatDong.HasValue && _.HoatDong == true)
                        .Include(_ => _.NhanVien1)
                        .Include(_ => _.QuayHang)
                        .Include(_ => _.Kho)
                        .ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return new List<PhieuTraQuayHang>();
        }

        public PhieuTraQuayHang Add()
        {
            try
            {
                return Entities.PhieuTraQuayHangs.Add(new PhieuTraQuayHang());
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public PhieuTraQuayHang Get(Guid phieuTraQuayHangId)
        {
            try
            {
                return Entities.PhieuTraQuayHangs.FirstOrDefault(_ => _.PhieuTraQuayHangId == phieuTraQuayHangId);
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
