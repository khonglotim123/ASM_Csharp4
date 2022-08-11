using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.IServices
{
    public interface IQLHoaDonService
    {
        bool Create(HoaDon chucVu);
        bool Update(HoaDon chucVu);
        bool Delete(int id);
        List<HoaDon> GetAll();
    }
}
