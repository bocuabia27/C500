﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbDauMoiLienHe
{
    public int IdDauMoiLienHe { get; set; }

    public int? IdLoaiDauMoiLienHe { get; set; }

    public string? SoDienThoai { get; set; }

    public string? Email { get; set; }

    public  DmDauMoiLienHe? IdLoaiDauMoiLienHeNavigation { get; set; }
}
