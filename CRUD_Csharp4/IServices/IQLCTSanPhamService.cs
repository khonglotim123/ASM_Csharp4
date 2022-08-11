using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.IServices
{
   public interface IQLCTSanPhamService
    {
        bool Create(ChiTietSP chucVu);
        bool Update(ChiTietSP chucVu);
        bool Delete(int id);
        List<ChiTietSP> GetAll();
    }
}
