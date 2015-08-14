using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Model;
using  Helper;

namespace Service
{
    public class ChucVuService: BaseService
    {
        public ChucVuService(QuanLySieuThiEntities quanLySieuThiEntities )
        {
            Entities = quanLySieuThiEntities;
        }

        public ChucVu AddChucVu()
        {
            try
            {
                var chucVu = new ChucVu();
                return Entities.ChucVus.Add(chucVu);
            }
            catch (Exception ex )
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public void DeleteChucVu(long id)
        {
            try
            {
                var chucVu =
                    Entities.ChucVus.FirstOrDefault(_ => _.Id == id && _.HoatDong.HasValue && _.HoatDong == true);
                if (chucVu != null)
                {
                    chucVu.HoatDong = false;
                    Entities.ChucVus.AddOrUpdate(chucVu);
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public IList<ChucVu> GetChucVus()
        {
            try
            {
                return Entities.ChucVus.Where(_ => _.HoatDong.HasValue && _.HoatDong == true).Include(_=>_.NhanVien).Include(_=>_.NhanVien1).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }
        

        public ChucVu GetChucVu(long id)
        {
            try
            {
                return Entities.ChucVus.FirstOrDefault(_ => _.Id == id && (_.HoatDong.HasValue && _.HoatDong == true));
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public ChucVu GetByName(string tenChucVu)
        {
            try
            {
                return
                    Entities.ChucVus.FirstOrDefault(
                        _ => _.TenChucVu == tenChucVu && (_.HoatDong.HasValue && _.HoatDong == true));
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<NhanVien> GetNhanViens(long chucVuId)
        {
            try
            {
                return
                    Entities.NhanViens.Where(_ => _.ChucVuId == chucVuId && (_.HoatDong.HasValue && _.HoatDong == true))
                        .ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return new List<NhanVien>();
        }

        public override void Save()
        {
            Entities.SaveChanges();
        }
    }
}
