using ASM_Csharp4.Context;
using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public class CTSanPhamRepository:ICTSanPhamRepository
    {
        FpolyContext _Context;
        public CTSanPhamRepository()
        {
            _Context = new FpolyContext();
        }

        public bool Create(ChiTietSP chucVu)
        {
            if (chucVu==null) return false;
            _Context.chiTietSPs.Add(chucVu);
            _Context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ChiTietSP> GetAll()
        {
            return _Context.chiTietSPs.ToList();
        }

        public bool Update(ChiTietSP chucVu)
        {
            throw new NotImplementedException();
        }
    }
}
