using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.IServices
{
    public interface IQLNSXService
    {
        bool Create(NSX nSX);
        bool Update(NSX nSX);
        bool Delete(int id);
        List<NSX> GetAll();
    }
}
