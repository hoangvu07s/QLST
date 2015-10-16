using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Model;

namespace Service
{
    public class KhoHangService : BaseService
    {
        public KhoHangService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public IList<Kho> GetAll()
        {
            try
            {
                return
                    Entities.Khoes
                        .Include(_ => _.NhanVien2)
                        .Include(_=>_.TonKhoes)
                        .Include(_=>_.PhieuTraQuayHangs)
                        .Include(_ => _.NhapKhoes)
                        .Include(_ => _.XuatKhoes)
                        .Where(_ => _.HoatDong.HasValue && _.HoatDong == true)
                        .ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public Kho Get(long khoId)
        {
            try
            {
                return
                    Entities.Khoes.Where(_ => _.Id == khoId && _.HoatDong.HasValue && _.HoatDong == true)
                        .Include(_ => _.NhapKhoes)
                        .Include(_ => _.PhieuTraQuayHangs)
                        .FirstOrDefault();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public void Delete(long khoId)
        {
            try
            {
                var kho = Entities.Khoes.FirstOrDefault(_ => _.Id == khoId && _.HoatDong.HasValue && _.HoatDong == true);
                if (kho != null)
                {
                    kho.HoatDong = false;
                    Entities.Khoes.AddOrUpdate(kho);
                }                
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public Kho AddKho()
        {
            try
            {
                var kho = new Kho();

                return Entities.Khoes.Add(kho);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public void Update(Kho kho)
        {
            try
            {
                Entities.Khoes.AddOrUpdate(kho);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public override void Save()
        {
            Entities.SaveChanges();
        }
    }
}
