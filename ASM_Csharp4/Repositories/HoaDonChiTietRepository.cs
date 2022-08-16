using ASM_Csharp4.Context;
using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public class HoaDonChiTietRepository:IHoaDonChiTietRepository
    {
        FpolyContext _Context;
        public HoaDonChiTietRepository()
        {
            _Context = new FpolyContext();
        }

        public bool Create(HoaDonChiTiet chucVu)
        {
            if (chucVu == null) return false;
            _Context.hoaDonChiTiets.Add(chucVu);
            _Context.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet hoaDonChiTiet)
        {
            if (hoaDonChiTiet == null) return false;           
            _Context.hoaDonChiTiets.Remove(hoaDonChiTiet);
            _Context.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _Context.hoaDonChiTiets.ToList();
        }

        public bool Update(HoaDonChiTiet chucVu)
        {
            if (chucVu == null) return false;
            _Context.hoaDonChiTiets.Update(chucVu);
            _Context.SaveChanges();
            return true;
        }
    }
}
