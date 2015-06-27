using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Helper;
using Model;

namespace Service
{
    public class NhaCungCapService : BaseService
    {
        public NhaCungCapService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public NhaCungCap AddNhaCungCap()
        {
            try
            {
                return Entities.NhaCungCaps.Add(new NhaCungCap());
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public void Delete(long nhaCungCapId)
        {
            try
            {
                var nhaCungCap =
                    Entities.NhaCungCaps.FirstOrDefault(
                        _ => _.Id == nhaCungCapId && _.HoatDong.HasValue && _.HoatDong == true);
                if (nhaCungCap != null)
                {
                    nhaCungCap.HoatDong = false;
                    Entities.NhaCungCaps.AddOrUpdate(nhaCungCap);
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public NhaCungCap Get(long nhaCungCapId)
        {
            try
            {
                var nhaCungCap =
                    Entities.NhaCungCaps.FirstOrDefault(
                        _ => _.Id == nhaCungCapId && _.HoatDong.HasValue && _.HoatDong == true);

                return nhaCungCap;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<NhaCungCap> GetAll()
        {
            try
            {
                return Entities.NhaCungCaps.Where(_ => _.HoatDong.HasValue && _.HoatDong == true).ToList();
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
