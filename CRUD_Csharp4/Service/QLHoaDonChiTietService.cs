using ASM_Csharp4.Repositories;
using CodeFirst_13Bang.Models;
using CRUD_Csharp4.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.Service
{
    public class QLHoaDonChiTietService: IQLHoaDonChiTiet
    {
        private IHoaDonChiTietRepository _cv;
        public QLHoaDonChiTietService()
        {
            _cv = new HoaDonChiTietRepository();
        }

        public bool Create(HoaDonChiTiet chucVu)
        {
            _cv.Create(chucVu);
            return true;
        }

        public bool Delete(HoaDonChiTiet hoaDonChiTiet)
        {
            _cv.Delete(hoaDonChiTiet);
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _cv.GetAll();
        }

        public bool Update(HoaDonChiTiet chucVu)
        {
            _cv.Update(chucVu);
            return true;
        }
    }
}
