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
