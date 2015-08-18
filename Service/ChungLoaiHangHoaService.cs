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
    public class ChungLoaiHangHoaService : BaseService
    {
        public ChungLoaiHangHoaService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public ChungLoaiHangHoa Add()
        {
            try
            {
                return Entities.ChungLoaiHangHoas.Add(new ChungLoaiHangHoa());
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public void Delete(long chungLoaiHangHoaId)
        {
            try
            {
                var chungLoaiHangHoa =
                    Entities.ChungLoaiHangHoas.FirstOrDefault(
                        _ => _.Id == chungLoaiHangHoaId && _.HoatDong.HasValue && _.HoatDong == true);
                if (chungLoaiHangHoa != null)
                {
                    chungLoaiHangHoa.HoatDong = false;

                    Entities.ChungLoaiHangHoas.AddOrUpdate(chungLoaiHangHoa);
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public ChungLoaiHangHoa Get(long chungLoaiHangHoaId)
        {
            try
            {
                var chungLoaiHangHoa =
                    Entities.ChungLoaiHangHoas.FirstOrDefault(
                        _ => _.Id == chungLoaiHangHoaId && _.HoatDong.HasValue && _.HoatDong == true);
        
                return chungLoaiHangHoa;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<ChungLoaiHangHoa> GetAll()
        {
            try
            {
                return
                    Entities.ChungLoaiHangHoas
                        .Include(_ => _.NhanVien)
                        .Include(_ => _.NhanVien1)
                        .Include(_ => _.LoaiHangHoas)
                        .Where(_ => _.HoatDong.HasValue && _.HoatDong == true)
                        .ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<LoaiHangHoa> GetLoaiHangHoas(long ChungLoaiHangHoaId)
        {
            try
            {
                return
                    Entities.LoaiHangHoas.Where(
                        _ => _.ChungLoaiId == ChungLoaiHangHoaId && (_.HoatDong.HasValue && _.HoatDong == true))
                        .ToList();
            }
            catch (Exception ex)
            {
                
                QuanLySieuThiHelper.LogError(ex);
            }
            return null;
        }

        public ChungLoaiHangHoa GetByTenChungLoaiHangHoa(string tenChungLoaiHangHoa)
        {
            try
            {
                return
                    Entities.ChungLoaiHangHoas.FirstOrDefault(
                        _ => _.TenChungLoai == tenChungLoaiHangHoa && _.HoatDong.HasValue && _.HoatDong == true);
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
