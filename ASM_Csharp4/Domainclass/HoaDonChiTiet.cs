using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_13Bang.Models
{

    public class HoaDonChiTiet
    {
        public int IdHoaDon { get; set; }
        public int IdChiTietSP { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public HoaDon hoaDon { get; set; }
        public ChiTietSP chiTietSP { get; set; }

    }
}
