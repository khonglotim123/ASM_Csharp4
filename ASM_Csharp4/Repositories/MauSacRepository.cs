using ASM_Csharp4.Context;
using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public class MauSacRepository : IMauSacRepository
    {
        FpolyContext _Context;
        public MauSacRepository()
        {
            _Context = new FpolyContext();
        }
        public bool Create(MauSac mauSac)
        {
            if (mauSac == null) return false;
            _Context.mauSacs.Add(mauSac);
            _Context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            MauSac mauSac = _Context.mauSacs.ToList().FirstOrDefault(c=>c.Id==id);
            if (mauSac == null) return false;
            _Context.mauSacs.Remove(mauSac);
            _Context.SaveChanges();
            return true;
        }

        public List<MauSac> GetAll()
        {
            return _Context.mauSacs.ToList();
        }

        public bool Update(MauSac mauSac)
        {
            if (mauSac == null) return false;
            _Context.mauSacs.Update(mauSac);
            _Context.SaveChanges();
            return true;
        }
    }
}
