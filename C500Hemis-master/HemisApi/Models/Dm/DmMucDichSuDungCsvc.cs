﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmMucDichSuDungCsvc
{
    public int IdMucDichSuDungCsvc { get; set; }

    public string? MucDichSuDungCsvc { get; set; }

    public  ICollection<TbCongTrinhCoSoVatChat> TbCongTrinhCoSoVatChats { get; set; } = new List<TbCongTrinhCoSoVatChat>();
}
