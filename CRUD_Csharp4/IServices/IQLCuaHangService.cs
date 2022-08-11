using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.IServices
{
    public interface IQLCuaHangService
    {
        bool Create(CuaHang cuaHang);
        bool Update(CuaHang cuaHang);
        bool Delete(int id);
        List<CuaHang> GetAll();
    }
}
