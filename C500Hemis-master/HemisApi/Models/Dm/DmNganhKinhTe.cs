﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmNganhKinhTe
{
    public int IdNganhKinhTe { get; set; }

    public string? Cap1 { get; set; }

    public string? NganhKinhTe { get; set; }

    public  ICollection<TbChuyenGiaoCongNgheVaDaoTao> TbChuyenGiaoCongNgheVaDaoTaos { get; set; } = new List<TbChuyenGiaoCongNgheVaDaoTao>();
}
