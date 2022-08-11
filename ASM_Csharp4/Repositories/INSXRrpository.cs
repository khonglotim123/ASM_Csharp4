using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public interface INSXRrpository
    {
        bool Create(NSX nSX);
        bool Update(NSX nSX);
        bool Delete(int id);
        List<NSX> GetAll();
    }
}
