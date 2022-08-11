using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.IServices
{
    public interface IQLChucVuService
    {
        bool Create(ChucVu chucVu);
        bool Update(ChucVu chucVu);
        bool Delete(int id);
        List<ChucVu> GetAll();
    }
}
