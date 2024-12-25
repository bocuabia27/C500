﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiHinhCoSoDaoTao
{
    public int IdLoaiHinhCoSoDaoTao { get; set; }

    public string? LoaiHinhCoSoDaoTao { get; set; }

    public  ICollection<TbCoSoGiaoDuc> TbCoSoGiaoDucs { get; set; } = new List<TbCoSoGiaoDuc>();
}
