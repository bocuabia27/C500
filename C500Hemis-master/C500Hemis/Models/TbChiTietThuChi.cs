﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;

namespace C500Hemis.Models;

[Authorize]
public partial class TbChiTietThuChi
{
    public int IdChiTietThuChi { get; set; }

    public int? IdLoaiThuChi { get; set; }

    public string? TenKhoanThuChi { get; set; }

    public string? NamTaiChinh { get; set; }

    public int? SoTien { get; set; }

    public  TbLoaiThuChi? IdLoaiThuChiNavigation { get; set; }
}
