﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbDoiTuongChinhSachCanBo
{
    public int IdDoiTuongChinhSachCanBo { get; set; }

    public int? IdCanBo { get; set; }

    public int? IdDoiTuongChinhSach { get; set; }

    public DateOnly? TuNgay { get; set; }

    public DateOnly? DenNgay { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmDoiTuongChinhSach? IdDoiTuongChinhSachNavigation { get; set; }
}
