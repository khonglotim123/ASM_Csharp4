using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public interface INhanVienRepository
    {
        bool Create(NhanVien nhanVien);
        bool Update(NhanVien nhanVien);
        bool Delete(int id);
        List<NhanVien> GetAll();
    }
}
