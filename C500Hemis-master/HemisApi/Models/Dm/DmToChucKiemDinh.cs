﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmToChucKiemDinh
{
    public int IdToChucKiemDinh { get; set; }

    public string? ToChucKiemDinh { get; set; }

    public  ICollection<TbThongTinKiemDinhCuaChuongTrinh> TbThongTinKiemDinhCuaChuongTrinhs { get; set; } = new List<TbThongTinKiemDinhCuaChuongTrinh>();

    public  ICollection<TbToChucKiemDinh> TbToChucKiemDinhs { get; set; } = new List<TbToChucKiemDinh>();
}
