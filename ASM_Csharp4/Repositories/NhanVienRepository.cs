using ASM_Csharp4.Context;
using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public class NhanVienRepository:INhanVienRepository
    {
        FpolyContext _Context;
        public NhanVienRepository()
        {
            _Context = new FpolyContext();
        }

        public bool Create(NhanVien nhanVien)
        {
            if (nhanVien == null) return false;
            _Context.nhanViens.Add(nhanVien);
            _Context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            NhanVien nhanVien = _Context.nhanViens.FirstOrDefault(c => c.Id == id);
            if (nhanVien == null) return false;
            _Context.nhanViens.Remove(nhanVien);
            _Context.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _Context.nhanViens.ToList();
        }

        public bool Update(NhanVien nhanVien)
        {
            if (nhanVien == null) return false;
            _Context.nhanViens.Update(nhanVien);
            _Context.SaveChanges();
            return true;
        }
    }
}
