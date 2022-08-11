using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public interface ICuaHangRepository
    {
        bool Create(CuaHang cuaHang);
        bool Update(CuaHang cuaHang);
        bool Delete(int id);
        List<CuaHang> GetAll();
    }
}
