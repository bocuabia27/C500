﻿using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmHeSoLuong
{
    public int IdHeSoLuong { get; set; }

    public string? HeSoLuong { get; set; }

    public  ICollection<TbDienBienLuong> TbDienBienLuongs { get; set; } = new List<TbDienBienLuong>();

    public  ICollection<TbPhuCap> TbPhuCaps { get; set; } = new List<TbPhuCap>();
}
