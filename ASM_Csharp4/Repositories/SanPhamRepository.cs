using ASM_Csharp4.Context;
using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public class SanPhamRepository : ISanPhamRepository
    {
        FpolyContext _Context;
        public SanPhamRepository()
        {
            _Context = new FpolyContext();
        }
        public bool Create(SanPham sanPham)
        {
            if (sanPham == null) return false;
            _Context.sanPhams.Add(sanPham);
            _Context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            SanPham sanPham = _Context.sanPhams.FirstOrDefault(c=>c.Id==id);
            if (sanPham == null) return false;
            _Context.sanPhams.Remove(sanPham);
            _Context.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            return _Context.sanPhams.ToList();
        }

        public bool Update(SanPham sanPham)
        {
            if (sanPham == null) return false;
            _Context.sanPhams.Update(sanPham);
            _Context.SaveChanges();
            return true;
        }
    }
}
