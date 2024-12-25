﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmTapChiTrongNuoc
{
    public int IdTapChiTrongNuoc { get; set; }

    public string? TapChiTrongNuoc { get; set; }

    public ICollection<TbBaiBaoKhdaCongBo> TbBaiBaoKhdaCongBos { get; set; } = new List<TbBaiBaoKhdaCongBo>();

    public ICollection<TbTapChiKhoaHoc> TbTapChiKhoaHocs { get; set; } = new List<TbTapChiKhoaHoc>();
}