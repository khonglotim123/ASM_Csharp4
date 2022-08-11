using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirst_13Bang.Models
{
    
    public class ChiTietSP
    {        
        public int Id { get; set; }
        public int NamBH { get; set; }
        public string MoTa { get; set; }
        public int SoLuongTon { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public int IdSP { get; set; }
        public int IdNsx { get; set; }
        public int IdMauSac { get; set; }
        public int IdDongSP { get; set; }
        public NSX nSX { get; set; }
        public DongSP dongSP { get; set; }
        public SanPham sanPham { get; set; }
        public MauSac mauSac { get; set; }
        public IList<GioHangChiTiet> GioHangChiTiets { get; set; }
        public IList<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    }
}
