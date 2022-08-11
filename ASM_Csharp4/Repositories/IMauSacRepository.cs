using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public interface IMauSacRepository
    {
        bool Create(MauSac mauSac);
        bool Update(MauSac mauSac);
        bool Delete(int id);
        List<MauSac> GetAll();
    }
}
