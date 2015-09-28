using Model;

namespace Service
{
    public class PhieuTraQuayHangService : BaseService
    {
        public PhieuTraQuayHangService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }
    }
}
