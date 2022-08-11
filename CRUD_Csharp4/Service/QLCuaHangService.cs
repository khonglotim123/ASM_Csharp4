using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASM_Csharp4.Repositories;
using CodeFirst_13Bang.Models;
using CRUD_Csharp4.IServices;

namespace CRUD_Csharp4.Service
{
    public class QLCuaHangService: IQLCuaHangService
    {
        private ICuaHangRepository _ch;
        public QLCuaHangService()
        {
            _ch = new CuaHangRepository();
        }

        public bool Create(CuaHang cuaHang)
        {
            _ch.Create(cuaHang);
            return true;
        }

        public bool Delete(int id)
        {
            _ch.Delete(id);
            return true;
        }

        public List<CuaHang> GetAll()
        {
            return _ch.GetAll();
        }

        public bool Update(CuaHang cuaHang)
        {
            _ch.Update(cuaHang);
            return true;
        }
    }
}
