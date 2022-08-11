using ASM_Csharp4.Context;
using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public class HoaDonRepository:IHoaDonRepository
    {
        FpolyContext _Context;
        public HoaDonRepository()
        {
            _Context = new FpolyContext();
        }

        public bool Create(HoaDon chucVu)
        {
            if (chucVu == null) return false;
            _Context.hoaDons.Add(chucVu);
            _Context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<HoaDon> GetAll()
        {
            return _Context.hoaDons.ToList();
        }

        public bool Update(HoaDon chucVu)
        {
            throw new NotImplementedException();
        }
    }
}
