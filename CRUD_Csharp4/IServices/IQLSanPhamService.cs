using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.IServices
{
    interface IQLSanPhamService
    {
        bool Create(SanPham sanPham);
        bool Update(SanPham sanPham);
        bool Delete(int id);
        List<SanPham> GetAll();
    }
}
