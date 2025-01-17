﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbThongTinViPham
{
    public int IdThongTinViPham { get; set; }

    public int? IdHocVien { get; set; }

    public DateOnly? ThoiGianViPham { get; set; }

    public string? NoiDungViPham { get; set; }

    public string? HinhThucXuLy { get; set; }

    public int? IdLoaiViPham { get; set; }

    public  TbHocVien? IdHocVienNavigation { get; set; }

    public  DmLoaiViPham? IdLoaiViPhamNavigation { get; set; }
}
