﻿using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmTrangThaiCanBo
{
    public int IdTrangThaiCanBo { get; set; }

    public string? TrangThaiCanBo { get; set; }

    public  ICollection<TbCanBo> TbCanBos { get; set; } = new List<TbCanBo>();
}