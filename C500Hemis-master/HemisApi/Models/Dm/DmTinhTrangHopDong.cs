﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmTinhTrangHopDong
{
    public int IdTinhTrangHopDong { get; set; }

    public string? TinhTrangHopDong { get; set; }

    public  ICollection<TbHopDong> TbHopDongs { get; set; } = new List<TbHopDong>();
}
