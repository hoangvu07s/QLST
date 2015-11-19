using System;
using System.Collections.Generic;
using System.Linq;
using Helper;
using Model;

namespace Service
{
    public class QuyenService : BaseService
    {
        public QuyenService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public IList<Quyen> GetAll()
        {
            try
            {
                return Entities.Quyens.ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }
    }
}
