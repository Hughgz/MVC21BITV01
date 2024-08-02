using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC21BITV01Test.Models;

namespace MVC21BITV01Test.Controllers
{
    public class HoaDonController : Controller
    {
        private readonly QlbanHangContext _context;

        public HoaDonController(QlbanHangContext context) {
            _context = context;
        }
        [HttpGet("/donhang/{mahd}")]
        public async Task<IActionResult> HoaDon(int maHD)
        {
            if (maHD == 0)
            {
                return NotFound();
            }

            var query = from hoaDon in _context.HoaDons
                        join chiTietHoaDon in _context.ChiTietHoaDons on hoaDon.MaHd equals chiTietHoaDon.MaHd
                        join sanPham in _context.SanPhams on chiTietHoaDon.MaSp equals sanPham.MaSp
                        join khachHang in _context.KhachHangs on hoaDon.MaKh equals khachHang.MaKh
                        where hoaDon.MaHd == maHD
                        select new ViewModel
                        {
                            MaSp = sanPham.MaSp,
                            MaHD = hoaDon.MaHd,
                            TenSp = sanPham.TenSp,
                            DonViTinh = sanPham.DonViTinh,
                            SoLuong = chiTietHoaDon.SoLuong,
                            DonGia = sanPham.DonGia,
                            ThanhTien = chiTietHoaDon.SoLuong * sanPham.DonGia,
                            TenKH = khachHang.TenCty,
                            NgayLapHd = hoaDon.NgayLapHd,
                                           
                        };

            var result = await query.ToListAsync();

            return View(result);
        }

    }
}
