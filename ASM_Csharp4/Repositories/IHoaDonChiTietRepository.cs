using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public interface IHoaDonChiTietRepository
    {
        bool Create(HoaDonChiTiet chucVu);
        bool Update(HoaDonChiTiet chucVu);
        bool Delete(HoaDonChiTiet hoaDonChiTiet);
        List<HoaDonChiTiet> GetAll();
    }
}
