
using ASM_Csharp4.Repositories;
using CodeFirst_13Bang.Models;
using CRUD_Csharp4.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.Service
{
    public class QLSanPhamService : IQLSanPhamService
    {
        ISanPhamRepository _sp;
        public QLSanPhamService()
        {
            _sp = new SanPhamRepository();
        }

        public bool Create(SanPham sanPham)
        {
            _sp.Create(sanPham);
            return true;
        }

        public bool Delete(int id)
        {
            _sp.Delete(id);
            return true;
        }

        public List<SanPham> GetAll()
        {
            return _sp.GetAll();
        }

        public bool Update(SanPham sanPham)
        {
            _sp.Update(sanPham);
            return true;

        }
    }
}
