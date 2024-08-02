using System;
using System.Collections.Generic;

namespace MVC21BITV01Test.Models;

public partial class ThanhPho
{
    public int MaThanhPho { get; set; }

    public string? TenThanhPho { get; set; }

    public virtual ICollection<KhachHang> KhachHangs { get; set; } = new List<KhachHang>();
}
