using ASM_Csharp4.Context;
using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public class KhachHangRepository:IKhachHangRepository
    {
        FpolyContext _Context;
        public KhachHangRepository()
        {
            _Context = new FpolyContext();
        }

        public bool Create(KhachHang khachHang)
        {
            if (khachHang == null) return false;
            _Context.khachHangs.Add(khachHang);
            _Context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            KhachHang khachHang = _Context.khachHangs.FirstOrDefault(c => c.Id == id);
            if (khachHang == null) return false;
            _Context.khachHangs.Remove(khachHang);
            _Context.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _Context.khachHangs.ToList();
        }

        public bool Update(KhachHang khachHang)
        {
            if (khachHang == null) return false;
            _Context.khachHangs.Update(khachHang);
            _Context.SaveChanges();
            return true;
        }
    }
}
