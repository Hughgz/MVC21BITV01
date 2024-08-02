using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC21BITV01Test.Models;

public partial class SanPham
{
    public int MaSp { get; set; }

    [Required(ErrorMessage = "Tên sản phẩm là bắt buộc.")]
    public string TenSp { get; set; } = null!;

    [Required(ErrorMessage = "Đơn vị tính sản phẩm là bắt buộc.")]
    public string? DonViTinh { get; set; }
    
    [Required(ErrorMessage = "Đơn giá sản phẩm là bắt buộc.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Đơn giá phải lớn hơn 0.")]
    public double? DonGia { get; set; }

    public string? Hinh { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();
}
