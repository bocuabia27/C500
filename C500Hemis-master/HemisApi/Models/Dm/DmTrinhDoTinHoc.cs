﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmTrinhDoTinHoc
{
    public int IdTrinhDoTinHoc { get; set; }

    public string? TrinhDoTinHoc { get; set; }

    public  ICollection<TbNguoi> TbNguois { get; set; } = new List<TbNguoi>();
}