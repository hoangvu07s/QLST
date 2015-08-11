﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Model;

namespace Service
{
    public class XuatKhoService: BaseService
    {
        public XuatKhoService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public XuatKho Add()
        {
            try
            {
                return Entities.XuatKhoes.Add(new XuatKho());
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