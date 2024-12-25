﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmChucDanhNckh
{
    public int IdChucDanhNghienCuuKhoaHoc { get; set; }

    public string? ChucDanhNghienCuuKhoaHoc { get; set; }

    public  ICollection<TbCanBo> TbCanBos { get; set; } = new List<TbCanBo>();
}