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
    public class QuyenNhanVienService : BaseService
    {
        public QuyenNhanVienService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public IList<QuyenNhanVien> GetAll()
        {
            try
            {
                return Entities.QuyenNhanViens.Where(_=>_.HoatDong).Include(_ => _.NhanVien).Include(_ => _.Quyen).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public QuyenNhanVien AddQuyenNhanVien()
        {
            try
            {
                return Entities.QuyenNhanViens.Add(new QuyenNhanVien());
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public QuyenNhanVien GetByNhanVienId(long nhanVienId)
        {
            try
            {
                return Entities.QuyenNhanViens.FirstOrDefault(_ => _.NhanVienId == nhanVienId && _.HoatDong);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public void Update(QuyenNhanVien quyenNhanVien)
        {
            try
            {
                Entities.QuyenNhanViens.AddOrUpdate(quyenNhanVien);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public void Delete(QuyenNhanVien quyenNhanVien)
        {
            try
            {
                quyenNhanVien.HoatDong = false;

                Entities.QuyenNhanViens.AddOrUpdate(quyenNhanVien);
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
