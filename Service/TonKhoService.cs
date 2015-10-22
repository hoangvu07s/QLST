using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Model;

namespace Service
{
    public class TonKhoService: BaseService
    {
        public TonKhoService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public TonKho Add()
        {
            try
            {
                return Entities.TonKhoes.Add(new TonKho());
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public TonKho Get(long khoId, long hangHoaId)
        {
            try
            {
                return Entities.TonKhoes.FirstOrDefault(_ => _.KhoId == khoId && _.HangHoaId == hangHoaId);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public int GetSoLuongTonKho(long hangHoaId)
        {
            try
            {
                var soluong = Entities.TonKhoes.Where(_ => _.HangHoaId == hangHoaId).Sum(_ => _.SoLuongTon);
                if (soluong == null)
                {
                    return 0;
                }

                return (int) soluong;
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return 0;
        }

        public TonKho GetByHangHoaIdKhoId(long hangHoaId, long khoId)
        {
            try
            {
                return Entities.TonKhoes.FirstOrDefault(_ => _.HangHoaId == hangHoaId && _.KhoId == khoId);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public void UpdateTonKho(TonKho tonKho)
        {
            try
            {
                Entities.TonKhoes.AddOrUpdate(tonKho);
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
