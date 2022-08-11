using ASM_Csharp4.Context;
using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public class ChucVuRepository:IChucVuRepository
    {
        FpolyContext _Context;
        public ChucVuRepository()
        {
            _Context = new FpolyContext();
        }

        public bool Create(ChucVu chucVu)
        {
            if (chucVu == null) return false;
            _Context.chucVus.Add(chucVu);
            _Context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            ChucVu chucVu = _Context.chucVus.ToList().FirstOrDefault(c => c.Id == id);
            if (chucVu == null) return false;
            _Context.chucVus.Remove(chucVu);
            _Context.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _Context.chucVus.ToList();
        }

        public bool Update(ChucVu chucVu)
        {
            if (chucVu == null) return false;
            _Context.chucVus.Update(chucVu);
            _Context.SaveChanges();
            return true;
        }
    }
}
