using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
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

        public NhaCungCap Add()
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

        public NhaCungCap GetByTenNhaCungCap(string tenNhaCungCap)
        {
            try
            {
                var nhaCungCap =
                    Entities.NhaCungCaps.FirstOrDefault(
                        _ => _.TenNhaCungCap == tenNhaCungCap && _.HoatDong.HasValue && _.HoatDong == true);

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
                return
                    Entities.NhaCungCaps.Where(_ => _.HoatDong.HasValue && _.HoatDong == true)
                        .Include(_ => _.NhanVien)
                        .Include(_ => _.NhanVien1)
                        .ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public int CountHangHoa(long nhaCungCapId)
        {
            try
            {
                return Entities.HangHoas.Count(_ => _.NhaCungCapId == nhaCungCapId);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return 0;
        }

        public int CountDonHang(long nhaCungCapId)
        {
            try
            {
                return Entities.DonHangs.Count(_ => _.NhaCungCapId == nhaCungCapId);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return 0;
        }

        public override void Save()
        {
            Entities.SaveChanges();
        }
    }
}
