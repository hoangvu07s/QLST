using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Model;

namespace Service
{
    public class HangHoaService: BaseService
    {
        public HangHoaService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public HangHoa AddHangHoa()
        {
            try
            {
                var hangHoa = new HangHoa();
                return Entities.HangHoas.Add(hangHoa);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public HangHoa GetByTenHangHoa(string tenHangHoa)
        {
            try
            {
                return
                    Entities.HangHoas.FirstOrDefault(
                        _ => _.TenHangHoa == tenHangHoa && _.HoatDong.HasValue && _.HoatDong == true);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public HangHoa GetByTenHangHoaLoaiHangHoaNhaCungCap(string tenHangHoa, long loaiHangHoaId, long nhaCungCapId)
        {
            try
            {
                return
                    Entities.HangHoas.FirstOrDefault(
                        _ =>
                            _.TenHangHoa == tenHangHoa && _.LoaiHangHoaId == loaiHangHoaId &&
                            _.NhaCungCapId == nhaCungCapId && _.HoatDong.HasValue && _.HoatDong == true);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public HangHoa GetByNgayTao(DateTime ngayTaoDateTime)
        {
            try
            {
                return
                    Entities.HangHoas.FirstOrDefault(
                        _ => _.NgayTao == ngayTaoDateTime && _.HoatDong.HasValue && _.HoatDong == true);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<HangHoa> GetAll()
        {
            try
            {
                return
                    Entities.HangHoas.Where(_ => _.HoatDong.HasValue && _.HoatDong == true)
                        .Include(_ => _.LoaiHangHoa)
                        .Include(_ => _.NhaCungCap)
                        .Include(_ => _.QuayHang)
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
