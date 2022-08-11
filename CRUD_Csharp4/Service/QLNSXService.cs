using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASM_Csharp4.Repositories;
using CodeFirst_13Bang.Models;
using CRUD_Csharp4.IServices;

namespace CRUD_Csharp4.Service
{
    public class QLNSXService : IQLNSXService
    {
        private INSXRrpository _nsx;
        public QLNSXService()
        {
            _nsx = new NSXRepository();
        }
        public bool Create(NSX nSX)
        {
            _nsx.Create(nSX);
            return true;
        }

        public bool Delete(int id)
        {
            _nsx.Delete(id);
            return true;
        }

        public List<NSX> GetAll()
        {
            return _nsx.GetAll();
        }

        public bool Update(NSX nSX)
        {
            _nsx.Update(nSX);
            return true;
        }
    }
}
