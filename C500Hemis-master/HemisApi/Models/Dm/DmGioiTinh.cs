﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmGioiTinh
{
    public int IdGioiTinh { get; set; }

    public string? GioiTinh { get; set; }

    public  ICollection<TbNguoi> TbNguois { get; set; } = new List<TbNguoi>();
}
