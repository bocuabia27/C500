﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmNguonKinhPhiChoLuuHocSinh
{
    public int IdNguonKinhPhiChoLuuHocSinh { get; set; }

    public string? NguonKinhPhiChoLuuHocSinh { get; set; }

    public  ICollection<TbLuuHocSinhSinhVienNn> TbLuuHocSinhSinhVienNns { get; set; } = new List<TbLuuHocSinhSinhVienNn>();
}