﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmSinhVienNam
{
    public int IdSinhVienNam { get; set; }

    public string? SinhVienNam { get; set; }

    public  ICollection<TbThongTinHocTapNghienCuuSinh> TbThongTinHocTapNghienCuuSinhs { get; set; } = new List<TbThongTinHocTapNghienCuuSinh>();
}
