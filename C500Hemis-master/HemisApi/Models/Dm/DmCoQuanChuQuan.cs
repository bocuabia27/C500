using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmCoQuanChuQuan
{
    public int IdCoQuanChuQuan { get; set; }

    public string? CoQuanChuQuan { get; set; }

    public ICollection<TbCoSoGiaoDuc> TbCoSoGiaoDucs { get; set; } = new List<TbCoSoGiaoDuc>();

    public ICollection<TbHoatDongBaoVeMoiTruong> TbHoatDongBaoVeMoiTruongs { get; set; } = new List<TbHoatDongBaoVeMoiTruong>();

    public ICollection<TbNhiemVuKhcn> TbNhiemVuKhcns { get; set; } = new List<TbNhiemVuKhcn>();
}
