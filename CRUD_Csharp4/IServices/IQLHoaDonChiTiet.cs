using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.IServices
{
    public interface IQLHoaDonChiTiet
    {
        bool Create(HoaDonChiTiet chucVu);
        bool Update(HoaDonChiTiet chucVu);
        bool Delete(HoaDonChiTiet hoaDonChiTiet);
        List<HoaDonChiTiet> GetAll();
    }
}
