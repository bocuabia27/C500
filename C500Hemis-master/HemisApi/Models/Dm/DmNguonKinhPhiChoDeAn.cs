﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmNguonKinhPhiChoDeAn
{
    public int IdNguonKinhPhiChoDeAn { get; set; }

    public string? NguonKinhPhiChoDeAn { get; set; }

    public  ICollection<TbDeAnDuAnChuongTrinh> TbDeAnDuAnChuongTrinhs { get; set; } = new List<TbDeAnDuAnChuongTrinh>();
}
