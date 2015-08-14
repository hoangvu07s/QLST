using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Model;

namespace Service
{
    public class NhapKhoService: BaseService
    {
        public NhapKhoService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public int GetSoluongNhapKho(Guid donHangId, long hangHoaId)
        {
            try
            {
                var soluong = 0;
                var nhapKhos =
                    Entities.NhapKhoes.Where(_ => _.DonHangId == donHangId && _.HoatDong.HasValue && _.HoatDong == true).ToList();

                foreach (var nhapKho in nhapKhos)
                {
                    var ctNhapKhos = Entities.CT_NhapKho.Where(_ => _.NhapKhoId == nhapKho.PhieuNhapKhoId).ToList();
                    var sl = ctNhapKhos.Where(_ => _.HangHoaId == hangHoaId).Sum(_ => _.SoLuong);
                    soluong = soluong + sl;
                }

                return soluong;

            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return 0;
        }

        public NhapKho Add()
        {
            try
            {
                var nhapKho = new NhapKho();
                return Entities.NhapKhoes.Add(nhapKho);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<NhapKho> Get(Guid donHangId)
        {
            try
            {
                return
                    Entities.NhapKhoes.Where(_ => _.DonHangId == donHangId && _.HoatDong.HasValue && _.HoatDong == true)
                        .ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<NhapKho> Get(long khoId)
        {
            try
            {
                return
                    Entities.NhapKhoes.Where(_ => _.KhoId == khoId && _.HoatDong.HasValue && _.HoatDong == true)
                        .ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<NhapKho> GetAll()
        {
            try
            {
                return
                    Entities.NhapKhoes.Where(_ => _.HoatDong.HasValue && _.HoatDong == true)
                        .Include(_ => _.Kho)
                        .Include(_ => _.NhanVien)
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
