﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmTrinhDoLyLuanChinhTri
{
    public int IdTrinhDoLyLuanChinhTri { get; set; }

    public string? TenTrinhDoLyLuanChinhTri { get; set; }

    public  ICollection<TbNguoi> TbNguois { get; set; } = new List<TbNguoi>();
}
