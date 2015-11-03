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
    public class ChiTietXuatKhoService: BaseService
    {
        public ChiTietXuatKhoService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public CT_XuatKho Add()
        {
            try
            {
                return Entities.CT_XuatKho.Add(new CT_XuatKho());
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<CT_XuatKho> Get(Guid xuatKhoId)
        {
            try
            {
                return Entities.CT_XuatKho.Where(_ => _.XuatKhoId == xuatKhoId).Include(_ => _.HangHoa).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<HangHoa> GetHangHoaByQuayHang(long quayHangId)
        {
            try
            {
                return
                    Entities.CT_XuatKho.Include(_ => _.HangHoa)
                        .Where(_ => _.HangHoa.QuayHangId == quayHangId)
                        .Select(_ => _.HangHoa)
                        .ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public int TongSoLuongXuatKho(long hangHoaId)
        {
            int tongSoLuong = 0;
            try
            {

                tongSoLuong = Entities.CT_XuatKho.Where(_ => _.HangHoaId == hangHoaId).Sum(_ => _.SoLuong);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return tongSoLuong;
        }

        public int TongSoLuongTuKhoToiQuay(long khoId, long hangHoaId)
        {
            int tongSoLuong = 0;
            try
            {
                var chiTietXuatKhos = Entities.XuatKhoes.Where(_ => _.KhoId == khoId)
                        .Include(_ => _.CT_XuatKho)
                        .SelectMany(_ => _.CT_XuatKho.Where(__=>__.HangHoaId == hangHoaId))
                        .ToList().Distinct().ToList();

                tongSoLuong = chiTietXuatKhos.Sum(_ => _.SoLuong);

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return tongSoLuong;
        }

        public IList<CT_XuatKho> GetByHangHoaId(long hangHoaId)
        {
            try
            {
                return Entities.CT_XuatKho.Where(_ => _.HangHoaId == hangHoaId).ToList();
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
