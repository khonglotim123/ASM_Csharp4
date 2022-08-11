using ASM_Csharp4.Context;
using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public class CuaHangRepository:ICuaHangRepository
    {
        FpolyContext _Context;
        public CuaHangRepository()
        {
            _Context = new FpolyContext();
        }

        public bool Create(CuaHang cuaHang)
        {
            if (cuaHang == null) return false;
            _Context.cuaHangs.Add(cuaHang);
            _Context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            CuaHang cuaHang = _Context.cuaHangs.ToList().FirstOrDefault(c=>c.Id==id);
            if (cuaHang == null) return false;
            _Context.cuaHangs.Remove(cuaHang);
            _Context.SaveChanges();
            return true;
        }

        public List<CuaHang> GetAll()
        {
            return _Context.cuaHangs.ToList();
        }

        public bool Update(CuaHang cuaHang)
        {
            if (cuaHang == null) return false;
            _Context.cuaHangs.Update(cuaHang);
            _Context.SaveChanges();
            return true;
        }
    }
}
