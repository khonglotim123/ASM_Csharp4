using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public interface IKhachHangRepository
    {
        bool Create(KhachHang khachHang);
        bool Update(KhachHang khachHang);
        bool Delete(int id);
        List<KhachHang> GetAll();
    }
}
