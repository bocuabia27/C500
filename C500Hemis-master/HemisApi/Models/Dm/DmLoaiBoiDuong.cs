﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiBoiDuong
{
    public int IdLoaiBoiDuong { get; set; }

    public string? LoaiBoiDuong { get; set; }

    public  ICollection<TbKhoaBoiDuongTapHuanThamGiaCuaCanBo> TbKhoaBoiDuongTapHuanThamGiaCuaCanBos { get; set; } = new List<TbKhoaBoiDuongTapHuanThamGiaCuaCanBo>();
}
