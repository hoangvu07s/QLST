using System;
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

        public ChucVu AddChucVu(ChucVu chucVu)
        {
            try
            {
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
                var chucVu = Entities.ChucVus.FirstOrDefault(_ => _.Id == id);
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

        public override void Save()
        {
            Entities.SaveChanges();
        }
    }
}
