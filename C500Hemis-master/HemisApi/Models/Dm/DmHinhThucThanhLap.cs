﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmHinhThucThanhLap
{
    public int IdHinhThucThanhLap { get; set; }

    public string? HinhThucThanhLap { get; set; }

    public  ICollection<TbCoSoGiaoDuc> TbCoSoGiaoDucs { get; set; } = new List<TbCoSoGiaoDuc>();
}
