﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmChucDanhNgheNghiep
{
    public int IdChucDanhNgheNghiep { get; set; }

    public string? ChucDanhNgheNghiep { get; set; }

    public  ICollection<TbCanBo> TbCanBos { get; set; } = new List<TbCanBo>();
}
