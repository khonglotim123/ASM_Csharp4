using ASM_Csharp4.Repositories;
using CodeFirst_13Bang.Models;
using CRUD_Csharp4.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.Service
{
    public class QLHoaDonService: IQLHoaDonService
    {
        private IHoaDonRepository _cv;
        public QLHoaDonService()
        {
            _cv = new HoaDonRepository();
        }

        public bool Create(HoaDon chucVu)
        {
            _cv.Create(chucVu);
            return true;
        }

        public bool Delete(int id)
        {
            _cv.Delete(id);
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _cv.GetAll();
        }

        public bool Update(HoaDon chucVu)
        {
            throw new NotImplementedException();
        }
    }
}
