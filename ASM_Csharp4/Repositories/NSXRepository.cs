using ASM_Csharp4.Context;
using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public class NSXRepository : INSXRrpository
    {
        FpolyContext _Context;
        public NSXRepository()
        {
            _Context = new FpolyContext();
        }
        public bool Create(NSX nSX)
        {
            if (nSX == null) return false;
            _Context.nSXes.Add(nSX);
            _Context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            NSX nSX = _Context.nSXes.ToList().FirstOrDefault(c=>c.Id==id);
            if (nSX == null) return false;
            _Context.nSXes.Remove(nSX);
            _Context.SaveChanges();
            return true;
        }

        public List<NSX> GetAll()
        {
            return _Context.nSXes.ToList();
        }

        public bool Update(NSX nSX)
        {
            if (nSX == null) return false;
            _Context.nSXes.Update(nSX);
            _Context.SaveChanges();
            return true;
        }
    }
}
