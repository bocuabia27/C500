﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmPhanLoaiThuChi
{
    public int IdPhanLoaiThuChi { get; set; }

    public string? PhanLoaiThuChi { get; set; }

    public  ICollection<TbLoaiThuChi> TbLoaiThuChis { get; set; } = new List<TbLoaiThuChi>();
}
