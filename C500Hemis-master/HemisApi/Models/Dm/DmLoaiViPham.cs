﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiViPham
{
    public int IdLoaiViPham { get; set; }

    public string? LoaiViPham { get; set; }

    public  ICollection<TbThongTinViPham> TbThongTinViPhams { get; set; } = new List<TbThongTinViPham>();
}
