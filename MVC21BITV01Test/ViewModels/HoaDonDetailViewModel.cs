using MVC21BITV01Test.Models;

namespace MVC21BITV01Test.ViewModels
{
    public class HoaDonDetailViewModel
    {
        public HoaDon HoaDon { get; set; }
        public IEnumerable<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public double TongTien { get; set; } 

    }
}
