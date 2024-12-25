﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmVaiTroThamGium
{
    public int IdVaiTroThamGia { get; set; }

    public string? VaiTroThamGia { get; set; }

    public  ICollection<TbDoiTuongThamGium> TbDoiTuongThamGia { get; set; } = new List<TbDoiTuongThamGium>();

    public  ICollection<TbThanhPhanThamGiaDoanCongTac> TbThanhPhanThamGiaDoanCongTacs { get; set; } = new List<TbThanhPhanThamGiaDoanCongTac>();
}