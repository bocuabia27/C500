﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmChuongTrinhDaoTao
{
    public int IdChuongTrinhDaoTao { get; set; }

    public string? ChuongTrinhDaoTao { get; set; }

    public  ICollection<TbThongTinHocTapNghienCuuSinh> TbThongTinHocTapNghienCuuSinhs { get; set; } = new List<TbThongTinHocTapNghienCuuSinh>();
}
