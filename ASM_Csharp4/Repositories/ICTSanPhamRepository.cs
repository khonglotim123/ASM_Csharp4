using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public interface ICTSanPhamRepository
    {
        bool Create(ChiTietSP chucVu);
        bool Update(ChiTietSP chucVu);
        bool Delete(int id);
        List<ChiTietSP> GetAll();
    }
}
