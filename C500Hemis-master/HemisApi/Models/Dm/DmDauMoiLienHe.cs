﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmDauMoiLienHe
{
    public int IdDauMoiLienHe { get; set; }

    public string? DauMoiLienHe { get; set; }

    public  ICollection<TbDauMoiLienHe> TbDauMoiLienHes { get; set; } = new List<TbDauMoiLienHe>();
}
