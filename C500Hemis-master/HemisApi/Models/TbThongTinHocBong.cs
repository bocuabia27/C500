﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbThongTinHocBong
{
    public int IdThongTinHocBong { get; set; }

    public int? IdHocVien { get; set; }

    public string? TenHocBong { get; set; }

    public string? DonViTaiTro { get; set; }

    public DateOnly? ThoiGianTraoTangHocBong { get; set; }

    public int? IdLoaiHocBong { get; set; }

    public int? GiaTriHocBong { get; set; }

    public  TbHocVien? IdHocVienNavigation { get; set; }

    public  DmLoaiHocBong? IdLoaiHocBongNavigation { get; set; }
}
