namespace MVC21BITV01Test.Models
{
    public class SanPhamCreateDto
    {
        public int MaSp { get; set; }

        public string TenSp { get; set; } = null!;

        public string? DonViTinh { get; set; }

        public double? DonGia { get; set; }

        public byte[]? Hinh { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();
    }
}
