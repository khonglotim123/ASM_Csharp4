using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.IServices
{
    public interface IQLNhanVienService
    {
        bool Create(NhanVien nhanVien);
        bool Update(NhanVien nhanVien);
        bool Delete(int id);
        List<NhanVien> GetAll();
    }
}
