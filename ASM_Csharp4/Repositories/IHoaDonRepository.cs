using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public interface IHoaDonRepository
    {
        bool Create(HoaDon chucVu);
        bool Update(HoaDon chucVu);
        bool Delete(int id);
        List<HoaDon> GetAll();
    }
}
