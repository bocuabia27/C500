﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmHocCheDaoTao
{
    public int IdHocCheDaoTao { get; set; }

    public string? HocCheDaoTao { get; set; }

    public  ICollection<TbChuongTrinhDaoTao> TbChuongTrinhDaoTaos { get; set; } = new List<TbChuongTrinhDaoTao>();
}
