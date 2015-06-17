using System;
using Model;

namespace Service
{
    public abstract class BaseService
    {
        public Object Entity;

        private QuanLySieuThiEntities _entities;

        public QuanLySieuThiEntities Entities
        {
            get { return _entities; }
            set { _entities = value; }
        }

        public virtual void Save()
        { }
    }
}
