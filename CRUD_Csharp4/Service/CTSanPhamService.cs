using ASM_Csharp4.Repositories;
using CodeFirst_13Bang.Models;
using CRUD_Csharp4.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.Service
{
    public class CTSanPhamService:IQLCTSanPhamService
    {
        private ICTSanPhamRepository _ch;
        public CTSanPhamService()
        {
            _ch = new CTSanPhamRepository();
        }

        public bool Create(ChiTietSP chucVu)
        {
            if (chucVu == null) return false;
            _ch.Create(chucVu);
            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ChiTietSP> GetAll()
        {
            return _ch.GetAll();
        }

        public bool Update(ChiTietSP chucVu)
        {
            throw new NotImplementedException();
        }
    }
}
