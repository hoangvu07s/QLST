using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Helper;
using Model;

namespace Service
{
    public class LoaiHangHoaService: BaseService
    {
        public LoaiHangHoaService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public LoaiHangHoa Add()
        {
            try
            {
                return Entities.LoaiHangHoas.Add(new LoaiHangHoa());
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
            return null;
        }

        public void Delete(long loaiHangHoaId)
        {
            try
            {
                var loaiHangHoa =
                    Entities.LoaiHangHoas.FirstOrDefault(
                        _ => _.Id == loaiHangHoaId && _.HoatDong.HasValue && _.HoatDong == true);
                if (loaiHangHoa != null)
                {
                    loaiHangHoa.HoatDong = false;
                    Entities.LoaiHangHoas.AddOrUpdate(loaiHangHoa);
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public LoaiHangHoa Get(long loaiHangHoaId)
        {
            try
            {
                return
                    Entities.LoaiHangHoas.FirstOrDefault(
                        _ => _.Id == loaiHangHoaId && _.HoatDong.HasValue && _.HoatDong == true);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
            return null;
        }

        public IList<LoaiHangHoa> GetAll()
        {
            try
            {
                return
                    Entities.LoaiHangHoas
                        .Include(_ => _.ChungLoaiHangHoa)
                        .Include(_ => _.NhanVien)
                        .Include(_ => _.NhanVien1)
                        .Include(_ => _.HangHoas)
                        .Where(
                        _ => _.HoatDong.HasValue && _.HoatDong == true /*&&
                            _.HangHoas.Count(__ => __.HoatDong.HasValue && __.HoatDong == true) > 0*/)
                        .ToList();

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
            return null;
        }

        public LoaiHangHoa GetByTenLoaiHangHoa(string tenLoaiHangHoa)
        {
            try
            {
                return
                    Entities.LoaiHangHoas.FirstOrDefault(
                        _ => _.TenLoaiHangHoa == tenLoaiHangHoa && _.HoatDong.HasValue && _.HoatDong == true);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
            return null;
        }

        public IList<HangHoa> GetHangHoas(long loaiHangHoaId)
        {
            try
            {
                return
                    Entities.HangHoas.Where(
                        _ => _.LoaiHangHoaId == loaiHangHoaId && (_.HoatDong.HasValue && _.HoatDong == true)).ToList();
            }
            catch (Exception ex)
            {
                
                QuanLySieuThiHelper.LogError(ex);
            }
            return null;
            
        }
        public IList<LoaiHangHoa> GetByChungLoaiHangHoaId(long chungLoaiHangHoaId)
        {
            try
            {
                return
                    Entities.LoaiHangHoas
                        .Include(_ => _.NhanVien)
                        .Include(_ => _.NhanVien1)
                        .Include(_ => _.HangHoas)
                        .Where(
                        _ => _.ChungLoaiId == chungLoaiHangHoaId && _.HoatDong.HasValue && _.HoatDong == true)
                        .ToList();
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
