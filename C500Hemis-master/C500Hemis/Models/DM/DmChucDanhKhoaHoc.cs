﻿using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmChucDanhKhoaHoc
{
    public int IdChucDanhKhoaHoc { get; set; }

    public string? ChucDanhKhoaHoc { get; set; }

    public  ICollection<TbChucDanhKhoaHocCuaCanBo> TbChucDanhKhoaHocCuaCanBos { get; set; } = new List<TbChucDanhKhoaHocCuaCanBo>();

    public  ICollection<TbNguoi> TbNguois { get; set; } = new List<TbNguoi>();
}
