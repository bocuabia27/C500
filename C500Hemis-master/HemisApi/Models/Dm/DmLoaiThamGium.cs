﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiThamGium
{
    public int IdLoaiThamGia { get; set; }

    public string? LoaiThamGia { get; set; }

    public  ICollection<TbDoiTuongThamGium> TbDoiTuongThamGia { get; set; } = new List<TbDoiTuongThamGium>();
}
