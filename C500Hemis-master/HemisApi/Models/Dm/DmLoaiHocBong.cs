﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiHocBong
{
    public int IdLoaiHocBong { get; set; }

    public string? LoaiHocBong { get; set; }

    public  ICollection<TbThongTinHocBong> TbThongTinHocBongs { get; set; } = new List<TbThongTinHocBong>();
}
