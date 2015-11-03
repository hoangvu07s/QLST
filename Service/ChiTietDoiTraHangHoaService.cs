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
    public class ChiTietDoiTraHangHoaService : BaseService
    {
        public ChiTietDoiTraHangHoaService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public IList<CT_DoiTraHangHoa> GetByDoiTraHangHoaId(Guid doiTraHangHoaId)
        {
            try
            {
                return
                    Entities.CT_DoiTraHangHoa.Where(_ => _.DoiTraHangHoaId == doiTraHangHoaId)
                        .Include(_ => _.HangHoa)
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
