using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmLoaiNhiemVuBaoVeMoiTruong
{
    public int IdLoaiNhiemVuBaoVeMoiTruong { get; set; }

    public string? LoaiNhiemVuBaoVeMoiTruong { get; set; }

    public  ICollection<TbHoatDongBaoVeMoiTruong> TbHoatDongBaoVeMoiTruongs { get; set; } = new List<TbHoatDongBaoVeMoiTruong>();
}
