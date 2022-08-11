using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public interface ISanPhamRepository
    {
        bool Create(SanPham sanPham);
        bool Update(SanPham sanPham);
        bool Delete(int id);
        List<SanPham> GetAll();

    }
}
