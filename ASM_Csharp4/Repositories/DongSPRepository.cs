using ASM_Csharp4.Context;
using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public class DongSPRepository:IDongSPRepository
    {
        FpolyContext _Context;
        public DongSPRepository()
        {
            _Context = new FpolyContext();
        }

        public bool Create(DongSP dongSP)
        {
            if (dongSP == null) return false;
            _Context.dongSPs.Add(dongSP);
            _Context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            DongSP dongSP = _Context.dongSPs.ToList().FirstOrDefault(c=>c.Id==id);
            if (dongSP == null) return false;
            _Context.dongSPs.Remove(dongSP);
            _Context.SaveChanges();
            return true;
        }

        public List<DongSP> GetAll()
        {
            return _Context.dongSPs.ToList();
        }

        public bool Update(DongSP dongSP)
        {
            if (dongSP == null) return false;
            _Context.dongSPs.Update(dongSP);
            _Context.SaveChanges();
            return true;
        }
    }
}
