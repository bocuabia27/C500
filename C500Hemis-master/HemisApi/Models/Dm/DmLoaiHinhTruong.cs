﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiHinhTruong
{
    public int IdLoaiHinhTruong { get; set; }

    public string? LoaiHinhTruong { get; set; }

    public  ICollection<TbCoSoGiaoDuc> TbCoSoGiaoDucs { get; set; } = new List<TbCoSoGiaoDuc>();
}