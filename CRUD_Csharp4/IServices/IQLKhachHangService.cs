using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.IServices
{
    public interface IQLKhachHangService
    {
        bool Create(KhachHang khachHang);
        bool Update(KhachHang khachHang);
        bool Delete(int id);
        List<KhachHang> GetAll();
    }
}
