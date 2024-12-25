﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiTaiSanTriTue
{
    public int IdLoaiTaiSanTriTue { get; set; }

    public string? LoaiTaiSanTriTue { get; set; }

    public  ICollection<TbTaiSanTriTue> TbTaiSanTriTues { get; set; } = new List<TbTaiSanTriTue>();
}