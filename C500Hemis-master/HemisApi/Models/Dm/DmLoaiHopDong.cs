﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiHopDong
{
    public int IdLoaiHopDong { get; set; }

    public string? LoaiHopDong { get; set; }

    public  ICollection<TbHopDong> TbHopDongs { get; set; } = new List<TbHopDong>();
}