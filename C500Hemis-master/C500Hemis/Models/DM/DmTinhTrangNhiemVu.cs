using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmTinhTrangNhiemVu
{
    public int IdTinhTrangNhiemVu { get; set; }

    public string? TinhTrangNhiemVu { get; set; }

    public  ICollection<TbHoatDongBaoVeMoiTruong> TbHoatDongBaoVeMoiTruongs { get; set; } = new List<TbHoatDongBaoVeMoiTruong>();

    public  ICollection<TbNhiemVuKhcn> TbNhiemVuKhcns { get; set; } = new List<TbNhiemVuKhcn>();
}
