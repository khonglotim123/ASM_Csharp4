using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public interface IDongSPRepository
    {
        bool Create(DongSP dongSP);
        bool Update(DongSP dongSP);
        bool Delete(int id);
        List<DongSP> GetAll();
    }
}
