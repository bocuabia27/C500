﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiSachTapChi
{
    public int IdLoaiSachTapChi { get; set; }

    public string? LoaiSachTapChi { get; set; }

    public  ICollection<TbSachDaXuatBan> TbSachDaXuatBans { get; set; } = new List<TbSachDaXuatBan>();
}