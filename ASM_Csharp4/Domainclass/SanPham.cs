using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirst_13Bang.Models
{

    public class SanPham
    {
        
        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public List<ChiTietSP> chiTietSPs { get; set; }
    }
}
