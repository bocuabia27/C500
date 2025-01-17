﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbLinhVucNghienCuuCuaCanBo
{
    public int IdLinhVucNghienCuuCuaCanBo { get; set; }

    public int? IdCanBo { get; set; }

    public int? IdLinhVucNghienCuu { get; set; }

    public bool? LaLinhVucNghienCuuChuyenSau { get; set; }

    public int? SoNamNghienCuu { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmLinhVucNghienCuu? IdLinhVucNghienCuuNavigation { get; set; }
}
