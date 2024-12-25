﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmPhanCapNhiemVu
{
    public int IdPhanCapNhiemVu { get; set; }

    public string? PhanCapNhiemVu { get; set; }

    public ICollection<TbHoatDongBaoVeMoiTruong> TbHoatDongBaoVeMoiTruongs { get; set; } = new List<TbHoatDongBaoVeMoiTruong>();

    public ICollection<TbNhiemVuKhcn> TbNhiemVuKhcns { get; set; } = new List<TbNhiemVuKhcn>();
}
